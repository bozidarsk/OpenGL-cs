using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.IO;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Shader : IDisposable
{
	public ShaderType Type { get; }
	public string? FileName { get; }
	internal IReadOnlyList<string[]> Properties => properties;

	private List<string[]> properties = new();

	private const string defaultVertex = @"
		#include <common.h>

		layout(location = 0) in Vertex v;
		layout(location = 0) out v2f o;

		void main() 
		{
			vec4 wp = LOCAL_TO_WORLD_M * vec4(v.position.xyz, 1);
			vec4 sp = PROJECTION_M * wp;

			o.worldPosition = wp.xyz;
			o.screenPosition = sp.xy;
			o.normal = (LOCAL_TO_WORLD_M * vec4(v.normal.xyz, 0)).xyz;
			o.uv = v.uv;

			gl_Position = sp;
		}
	";
	private const string defaultFragment = @"
		#include <common.h>

		layout(location = 0) in v2f f;
		layout(location = 0) out vec4 color;

		void main() 
		{
			color = vec4(f.uv.xy, 0, 1);
		}
	";

	private readonly uint id;

	public void Dispose() => glDeleteShader(this);

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(Shader x) => x.id;

	public static Shader FromFile(string file) => new Shader(
		File.ReadAllText(file),
		Path.GetExtension(file) switch 
		{
			".vert" => ShaderType.Vertex,
			".frag" => ShaderType.Fragment,
			".geom" => ShaderType.Geometry,
			".comp" => ShaderType.Compute,

			_ => throw new FileFormatException()
		},
		file
	);

	private static string ParseShader(string code, out List<string[]> properties) 
	{
		StringBuilder output = new();
		bool requiresRecursion = false;

		properties = new();

		foreach (string line in code
			.Split('\r', '\n')
			.Where(x => !string.IsNullOrWhiteSpace(x))
		)
		{
			string l = line.TrimStart();

			if (l.StartsWith("#pragma "))
				properties.Add(l.Split().Where(x => !string.IsNullOrWhiteSpace(x)).Skip(1).ToArray());
			else if (l.StartsWith("#include")) 
			{
				// TODO: check if it is in a comment

				string path = l.Remove(0, "#include".Length).Trim();
				path = path.Substring(1, path.Length - 2);
				requiresRecursion = true;

				foreach (string x in File.ReadAllLines(path))
					output.AppendLine(x);
			}
			else
				output.AppendLine(l);
		}

		if (requiresRecursion) 
		{
			string o = ParseShader(output.ToString(), out var p);
			properties.AddRange(p);
			return o;
		}

		return output.ToString();
	}

	public unsafe Shader(string? code, ShaderType type, string? fileName = null) 
	{
		this.Type = type;
		this.FileName = fileName;

		code ??= type switch 
		{
			ShaderType.Vertex => defaultVertex,
			ShaderType.Fragment => defaultFragment,

			_ => throw new NullReferenceException($"Default shader not found for 'ShaderType.{type}'.")
		};

		code = ParseShader(code, out properties);
		properties.Reverse();

		id = glCreateShader((uint)type);

		int codeLength = code.Length;
		glShaderSource(this, 1, ref code, ref codeLength);
		glCompileShader(this);

		glGetShaderiv(this, GL_COMPILE_STATUS, out int result);
		if (result == 0) 
		{
			glGetShaderiv(this, GL_INFO_LOG_LENGTH, out int length);

			sbyte* message = stackalloc sbyte[length];
			glGetShaderInfoLog(this, length, out length, ref Unsafe.AsRef<sbyte>(message));

			throw new GLException($"Shader compilation error in '{fileName}' {new string(message)}");
		}
	}
}

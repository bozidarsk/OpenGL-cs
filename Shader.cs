using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Shader : IDisposable
{
	public ShaderType Type { get; }
	public string? FileName { get; }

	private const string defaultVertex = @"
		#version 440 core

		struct Vertex 
		{
			vec3 position;
			vec3 normal;
			vec2 uv;
		};

		struct v2f 
		{
			vec3 normal;
			vec2 uv;
		};

		uniform mat4x4 LOCAL_TO_WORLD;
		uniform mat4x4 PROJECTION;





		layout(location = 0) in Vertex v;
		layout(location = 0) out v2f o;

		void main() 
		{
			o.normal = (LOCAL_TO_WORLD * vec4(v.normal.xyz, 0)).xyz;
			o.uv = v.uv;
			gl_Position = (PROJECTION * LOCAL_TO_WORLD) * vec4(v.position.xyz, 1);
		}
	";
	private const string defaultFragment = @"
		#version 440 core

		struct Vertex 
		{
			vec3 position;
			vec3 normal;
			vec2 uv;
		};

		struct v2f 
		{
			vec3 normal;
			vec2 uv;
		};

		uniform mat4x4 LOCAL_TO_WORLD;
		uniform mat4x4 PROJECTION;





		layout(location = 0) out vec4 color;
		layout(location = 0) in v2f f;

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
			_ => throw new FileFormatException(),
		},
		file
	);

	public unsafe Shader(string? code, ShaderType type, string? fileName = null) 
	{
		this.Type = type;
		this.FileName = fileName;

		code ??= type switch 
		{
			ShaderType.Vertex => defaultVertex,
			ShaderType.Fragment => defaultFragment,
			_ => throw new NullReferenceException($"Default shader not found for 'ShaderType.{type}'."),
		};

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

			Console.WriteLine($"Shader compilation error in '{fileName}' {new string(message)}");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Material : IDisposable
{
	private readonly uint id;

	public void Use() => glUseProgram(this);
	public void Dispose() => glDeleteProgram(this);

	public object this[string name] 
	{
		set 
		{
			if (name == null)
				throw new ArgumentNullException();

			Use();

			int location = glGetUniformLocation(this, name);
			if (location == -1)
				return;

			if (value is float)
				glUniform1f(location, (float)value);
			else if (value is Vector2)
				glUniform2f(location, ((Vector2)value).x, ((Vector2)value).y);
			else if (value is Vector3)
				glUniform3f(location, ((Vector3)value).x, ((Vector3)value).y, ((Vector3)value).z);
			else if (value is Vector4)
				glUniform4f(location, ((Vector4)value).x, ((Vector4)value).y, ((Vector4)value).z, ((Vector4)value).w);
			else
				throw new ArgumentException($"Invalid type '{value.GetType()}'.");
		}
	}

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(Material x) => x.id;

	public static Material FromFile(params string[] files) => FromFile((IEnumerable<string>)files);
	public static Material FromFile(IEnumerable<string> files) => new Material(
		files.Select(x => Shader.FromFile(x))
	);

	public Material() : this(new Shader(null, ShaderType.Vertex), new Shader(null, ShaderType.Fragment)) {}

	public Material(params Shader[] shaders) : this((IEnumerable<Shader>)shaders) {}
	public Material(IEnumerable<Shader> shaders) 
	{
		if (shaders == null)
			throw new ArgumentNullException();

		id = glCreateProgram();

		foreach (Shader shader in shaders)
			glAttachShader(this, shader);

		glLinkProgram(this);
		glValidateProgram(this);
		Use();
	}
}

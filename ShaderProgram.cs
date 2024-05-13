using System;
using System.Collections.Generic;
using System.Linq;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class ShaderProgram : IDisposable
{
	private readonly uint id;

	public void Use() => glUseProgram(this);
	public void Dispose() => glDeleteProgram(this);

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(ShaderProgram x) => x.id;

	public static ShaderProgram FromFile(params string[] files) => FromFile((IEnumerable<string>)files);
	public static ShaderProgram FromFile(IEnumerable<string> files) => new ShaderProgram(
		files.Select(x => Shader.FromFile(x))
	);

	public ShaderProgram(params Shader[] shaders) : this((IEnumerable<Shader>)shaders) {}
	public ShaderProgram(IEnumerable<Shader> shaders) 
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

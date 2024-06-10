using System;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public class Texture : IDisposable
{
	public int Width { get; }
	public int Height { get; }
	public TextureType Type { get; }
	public nint Data { get; }

	private readonly uint id;

	public void Bind() 
	{
		glActiveTexture(GL_TEXTURE0); // GL_TEXTURE0 + slot
		glBindTexture((uint)Type, this);
	}

	public void Dispose() 
	{
		uint obj = this;
		glDeleteTextures(1, ref obj);
	}

	public static Texture FromFile(string file) => throw new NotImplementedException();

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(Texture x) => x.id;

	public Texture(int width, int height, TextureType type) 
	{
		this.Width = width;
		this.Height = height;
		this.Type = type;
		this.Data = 0;

		glGenTextures(1, ref id);
		Bind();

		glTexParameteri((uint)type, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
		glTexParameteri((uint)type, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);
		glTexParameteri((uint)type, GL_TEXTURE_WRAP_S, (int)GL_CLAMP);
		glTexParameteri((uint)type, GL_TEXTURE_WRAP_T, (int)GL_CLAMP);
	}

	public Texture(
		int width,
		int height,
		TextureType type = TextureType.Generic2D,
		TextureFormat internalFormat = TextureFormat.RGBA8,
		TextureFormat format = TextureFormat.RGBA,
		TextureFormatType formatType = TextureFormatType.UnsignedByte,
		nint data = 0
	)
	{
		this.Width = width;
		this.Height = height;
		this.Type = type;
		this.Data = data;

		glGenTextures(1, ref id);
		Bind();

		glTexParameteri((uint)type, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
		glTexParameteri((uint)type, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);
		glTexParameteri((uint)type, GL_TEXTURE_WRAP_S, (int)GL_CLAMP);
		glTexParameteri((uint)type, GL_TEXTURE_WRAP_T, (int)GL_CLAMP);

		if (type != TextureType.Generic2D)
			throw new NotImplementedException($"Texture type is not '{type}'.");

		glTexImage2D((uint)type, 0, (int)internalFormat, width, height, 0, (uint)format, (uint)formatType, data);
	}
}

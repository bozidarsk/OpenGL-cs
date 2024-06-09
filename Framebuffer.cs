using System;
using System.Collections.Generic;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public class Framebuffer : IDisposable
{
	public int Width { get; }
	public int Height { get; }
	public FramebufferAttachment Attachment { get; }

	private readonly uint id;

	public void Bind() => glBindFramebuffer(GL_FRAMEBUFFER, this);
	public void Dispose() 
	{
		uint obj = this;
		glDeleteFramebuffers(1, ref obj);
	}

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(Framebuffer x) => x.id;

	public Framebuffer(int width, int height, FramebufferAttachment attachment) 
	{
		this.Width = width;
		this.Height = height;
		this.Attachment = attachment;

		glGenFramebuffers(1, ref id);
		glBindFramebuffer(GL_FRAMEBUFFER, id);

		foreach (FramebufferAttachment x in Enum.GetValues<FramebufferAttachment>()) 
		{
			if (!attachment.HasFlag(x))
				continue;

			glFramebufferTexture2D(
				GL_FRAMEBUFFER,
				(uint)x,
				GL_TEXTURE_2D,
				new Texture(
					width,
					height,
					type: TextureType.Generic2D,
					internalFormat: TextureFormat.RGBA8,
					format: TextureFormat.RGBA,
					formatType: TextureFormatType.UnsignedByte
				),
				0
			);
		}
	}
}

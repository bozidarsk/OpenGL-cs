using System;
using System.Collections.Generic;
using System.Linq;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class RenderTexture : Texture
{
	public FramebufferAttachment Attachment { get; }

	public override string ToString() => base.ToString();
	public static implicit operator uint(RenderTexture x) => (Texture)x;

	internal RenderTexture(int width, int height, FramebufferAttachment attachment) : base(width, height, TextureType.Generic2D)
	{
		this.Attachment = attachment;

		switch (attachment) 
		{
			case FramebufferAttachment.Color:
				glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA8, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, 0);
				break;
			case FramebufferAttachment.Depth:
				glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_DEPTH_COMPONENT24, width, height, 0, GL_DEPTH_COMPONENT, GL_FLOAT, 0);
				break;
			case FramebufferAttachment.Stencil:
				throw new NotImplementedException();
			default:
				throw new InvalidOperationException();
		}
	}
}

public class Framebuffer : IDisposable
{
	public int Width { get; }
	public int Height { get; }
	public List<RenderTexture> Textures { get; } = new();

	private readonly uint id;

	public void Bind() => glBindFramebuffer(GL_FRAMEBUFFER, this);
	public void Dispose() 
	{
		uint obj = this;
		glDeleteFramebuffers(1, ref obj);
	}

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(Framebuffer x) => x.id;

	public Framebuffer(int width, int height, params FramebufferAttachment[] attachments) 
	{
		this.Width = width;
		this.Height = height;

		glGenFramebuffers(1, ref id);
		Bind();

		foreach (FramebufferAttachment x in attachments) 
		{
			RenderTexture texture = new RenderTexture(width, height, x);
			this.Textures.Add(texture);

			glFramebufferTexture2D(
				GL_FRAMEBUFFER,
				(uint)x,
				GL_TEXTURE_2D,
				texture,
				0
			);
		}

		if (glCheckFramebufferStatus(GL_FRAMEBUFFER) != GL_FRAMEBUFFER_COMPLETE)
			throw new GLException("Framebuffer status is not complete.");
	}
}

using System;
using System.Collections.Generic;
using System.Linq;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Camera : IDisposable
{
	public Matrix4x4 Transform { set; get; }
	public Matrix4x4 Projection { set; get; }
	public bool UseWindow { set; get; }
	public Framebuffer Frame { get; } = new Framebuffer(1280, 720, FramebufferAttachment.Color);

	public void Dispose() => this.Frame.Dispose();

	private static readonly Mesh quad = new(
		new Vertex[] { new(new(0, 0, 0), Vector3.Forward, new(0, 0)), new(new(1280, 0, 0), Vector3.Forward, new(1, 0)), new(new(1280, 720, 0), Vector3.Forward, new(1, 1)), new(new(0, 720, 0), Vector3.Forward, new(0, 1)) },
		new uint[] { 0, 1, 2, 2, 3, 0 }
	);

	private static readonly Material textureRenderer = new(
		new(null, ShaderType.Vertex),
		new(@"
			#include <common.h>

			layout(location = 0) in v2f f;
			layout(location = 0) out vec4 color;

			uniform sampler2D COLOR_T;

			void main() 
			{
				color = texture(COLOR_T, f.uv);
			}
		", ShaderType.Fragment)
	);

	private void RenderToWindow() 
	{
		glBindFramebuffer(GL_FRAMEBUFFER, 0);
		glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);
		glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		glFrontFace(GL_CCW);
		glEnable(GL_CULL_FACE);

		textureRenderer.Use();
		textureRenderer["LOCAL_TO_WORLD_M"] = Matrix4x4.Identity;
		textureRenderer["PROJECTION_M"] = Matrix4x4.Ortho(0, this.Frame.Width, 0, this.Frame.Height, -1, 1);
		textureRenderer["COLOR_T"] = this.Frame.Textures.Where(x => x.Attachment == FramebufferAttachment.Color).Single();
		// textureRenderer["DEPTH_T"] = this.Frame.Textures.Where(x => x.Attachment == FramebufferAttachment.Depth).Single();

		quad.BindVertexBuffer();
		quad.BindIndexBuffer();
		quad.EnableVertexAttributes();
		glDrawElements(GL_TRIANGLES, quad.IndexCount, GL_UNSIGNED_INT, nint.Zero);
		quad.DisableVertexAttributes();
	}

	public void Render(params SceneObject[] objects) => Render((IEnumerable<SceneObject>)objects);
	public void Render(IEnumerable<SceneObject> objects) 
	{
		this.Frame.Bind();
		// glDrawBuffer((uint)this.Frame.Textures.Where(x => x.Attachment == FramebufferAttachment.Color).Single().Attachment);

		glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);

		foreach (SceneObject obj in objects) 
		{
			Transform transform = obj.GetComponent<Transform>();
			MeshRenderer renderer = obj.GetComponent<MeshRenderer>();
			MeshFilter filter = obj.GetComponent<MeshFilter>();

			if (renderer.Material.Properties.TryGetValue("cull", out string[]? cullp))
				switch (cullp[0]) 
				{
					case "back":
						glFrontFace(GL_CCW);
						glEnable(GL_CULL_FACE);
						break;
					case "front":
						glFrontFace(GL_CW);
						glEnable(GL_CULL_FACE);
						break;
					case "off":
						glDisable(GL_CULL_FACE);
						break;
				}
			else 
			{
				glFrontFace(GL_CCW);
				glEnable(GL_CULL_FACE);
			}

			if (renderer.Material.Properties.TryGetValue("blend", out string[]? blendp)) 
				glBlendFunc(
					blendp[0] switch 
					{
						"zero" => GL_ZERO,
						"one" => GL_ONE,
						"srccolor" => GL_SRC_COLOR,
						"oneminussrccolor" => GL_ONE_MINUS_SRC_COLOR,
						"dstcolor" => GL_DST_COLOR,
						"oneminusdstcolor" => GL_ONE_MINUS_DST_COLOR,
						"srcalpha" => GL_SRC_ALPHA,
						"oneminussrcalpha" => GL_ONE_MINUS_SRC_ALPHA,
						"dstalpha" => GL_DST_ALPHA,
						"oneminusdstalpha" => GL_ONE_MINUS_DST_ALPHA,
						"constantcolor" => GL_CONSTANT_COLOR,
						"oneminusconstantcolor" => GL_ONE_MINUS_CONSTANT_COLOR,
						"constantalpha" => GL_CONSTANT_ALPHA,
						"oneminusconstantalpha" => GL_ONE_MINUS_CONSTANT_ALPHA,

						_ => throw new InvalidOperationException()
					},
					blendp[1] switch 
					{
						"zero" => GL_ZERO,
						"one" => GL_ONE,
						"srccolor" => GL_SRC_COLOR,
						"oneminussrccolor" => GL_ONE_MINUS_SRC_COLOR,
						"dstcolor" => GL_DST_COLOR,
						"oneminusdstcolor" => GL_ONE_MINUS_DST_COLOR,
						"srcalpha" => GL_SRC_ALPHA,
						"oneminussrcalpha" => GL_ONE_MINUS_SRC_ALPHA,
						"dstalpha" => GL_DST_ALPHA,
						"oneminusdstalpha" => GL_ONE_MINUS_DST_ALPHA,
						"constantcolor" => GL_CONSTANT_COLOR,
						"oneminusconstantcolor" => GL_ONE_MINUS_CONSTANT_COLOR,
						"constantalpha" => GL_CONSTANT_ALPHA,
						"oneminusconstantalpha" => GL_ONE_MINUS_CONSTANT_ALPHA,

						_ => throw new InvalidOperationException()
					}
				);
			else
				glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);

			renderer.Material.Use();
			renderer.Material["LOCAL_TO_WORLD_M"] = transform.Matrix;
			renderer.Material["PROJECTION_M"] = this.Projection * this.Transform;

			filter.Mesh.BindVertexBuffer();
			filter.Mesh.BindIndexBuffer();
			filter.Mesh.EnableVertexAttributes();
			glDrawElements(GL_TRIANGLES, filter.Mesh.IndexCount, GL_UNSIGNED_INT, nint.Zero);
			filter.Mesh.DisableVertexAttributes();
		}

		if (this.UseWindow)
			RenderToWindow();
	}

	public Camera(Matrix4x4 transform, Matrix4x4 projection, bool useWindow) => 
		(this.Transform, this.Projection, this.UseWindow) = (transform, projection, useWindow)
	;
}

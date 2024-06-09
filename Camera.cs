using System;
using System.Collections.Generic;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Camera : IDisposable
{
	public Matrix4x4 Transform;
	public Matrix4x4 Projection;
	public Framebuffer Target = new Framebuffer(1920, 1080, FramebufferAttachment.Color);

	public void Dispose() => this.Target.Dispose();

	public static Camera MainCamera = new Camera(Matrix4x4.Identity, Matrix4x4.Perspective(60, 16 / 9, -1, 1));

	public void Render(params SceneObject[] objects) => Render((IEnumerable<SceneObject>)objects);
	public void Render(IEnumerable<SceneObject> objects) 
	{
		if (this != MainCamera) 
		{
			Target.Bind();
			glDrawBuffer((uint)Target.Attachment);
		}
		else 
		{
			glBindFramebuffer(GL_FRAMEBUFFER, 0);
		}

		glClear(GL_COLOR_BUFFER_BIT /*| GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT*/);

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
	}

	public Camera(Matrix4x4 transform, Matrix4x4 projection) => (this.Transform, this.Projection) = (transform, projection);
}

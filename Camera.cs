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
		glFrontFace(GL_CCW);
		glEnable(GL_CULL_FACE);

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

			renderer.Material.Use();
			renderer.Material["LOCAL_TO_WORLD"] = transform.Matrix;
			renderer.Material["PROJECTION"] = this.Projection * this.Transform;

			filter.Mesh.BindVertexBuffer();
			filter.Mesh.BindIndexBuffer();
			filter.Mesh.EnableVertexAttributes();
			glDrawElements(GL_TRIANGLES, filter.Mesh.IndexCount, GL_UNSIGNED_INT, nint.Zero);
			filter.Mesh.DisableVertexAttributes();
		}
	}

	public Camera(Matrix4x4 transform, Matrix4x4 projection) => (this.Transform, this.Projection) = (transform, projection);
}

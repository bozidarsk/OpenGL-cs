using System.Collections.Generic;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Camera 
{
	public Matrix4x4 Transform;
	public Matrix4x4 Projection;

	public void Render(params SceneObject[] objects) => Render((IEnumerable<SceneObject>)objects);
	public void Render(IEnumerable<SceneObject> objects) 
	{
		glClear(GL_COLOR_BUFFER_BIT);

		foreach (SceneObject obj in objects)
			obj.Render(Projection * Transform);
	}

	public Camera(Matrix4x4 transform, Matrix4x4 projection) => (this.Transform, this.Projection) = (transform, projection);
}

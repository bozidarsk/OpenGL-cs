using System.Collections.Generic;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public static class Renderer 
{
	public static void Render(Matrix4x4 projection, params SceneObject[] objects) => Render(projection, (IEnumerable<SceneObject>)objects);
	public static void Render(Matrix4x4 projection, IEnumerable<SceneObject> objects) 
	{
		glClear(GL_COLOR_BUFFER_BIT);

		foreach (SceneObject obj in objects)
			obj.Render(projection);
	}
}

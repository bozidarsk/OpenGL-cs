using System.Collections.Generic;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public static class Renderer 
{
	public static void Render(Material material, params Mesh[] meshes) => Render(material, (IEnumerable<Mesh>)meshes);
	public static void Render(Material material, IEnumerable<Mesh> meshes) 
	{
		glClear(GL_COLOR_BUFFER_BIT);

		material.Use();

		foreach (Mesh mesh in meshes) 
		{
			mesh.BindIndexBuffer();
			glDrawElements(GL_TRIANGLES, mesh.IndexCount, GL_UNSIGNED_INT, nint.Zero);
		}
	}
}

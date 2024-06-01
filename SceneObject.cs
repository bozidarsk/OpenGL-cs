using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class SceneObject 
{
	public Matrix4x4 Transform;
	public Material Material;
	public Mesh Mesh;

	public void Render(Matrix4x4 projection) 
	{
		Material.Use();
		Material["LOCAL_TO_WORLD"] = Transform;
		Material["PROJECTION"] = projection;

		Mesh.BindVertexBuffer();
		Mesh.BindIndexBuffer();
		Mesh.EnableVertexAttributes();
		glDrawElements(GL_TRIANGLES, Mesh.IndexCount, GL_UNSIGNED_INT, nint.Zero);
		Mesh.DisableVertexAttributes();
	}

	public SceneObject(Matrix4x4 transform, Material material, Mesh mesh) => (this.Transform, this.Material, this.Mesh) = (transform, material, mesh); 
}

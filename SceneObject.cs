using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public class SceneObject 
{
	public Matrix4x4 Transform;
	public Material Material;
	public Mesh Mesh;

	public SceneObject(Matrix4x4 transform, Material material, Mesh mesh) => (this.Transform, this.Material, this.Mesh) = (transform, material, mesh); 
}

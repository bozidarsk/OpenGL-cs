namespace OpenGL;

public sealed class MeshFilter : Component
{
	public Mesh Mesh;

	public MeshFilter(Mesh mesh) => this.Mesh = mesh;
}

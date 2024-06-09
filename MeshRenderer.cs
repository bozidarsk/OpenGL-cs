namespace OpenGL;

public sealed class MeshRenderer : Component
{
	public Material Material;

	public MeshRenderer(Material material) => this.Material = material;
}

using System.Runtime.InteropServices;

namespace OpenGL;

[StructLayout(LayoutKind.Sequential, Pack = sizeof(float))]
public struct Vertex 
{
	public Vector3 Position;
	public Vector3 Normal;
	public Vector2 UV;

	public Vertex(Vector3 position) : this(position, Vector3.Zero, Vector2.Zero) {}
	public Vertex(Vector3 position, Vector3 normal, Vector2 uv) => (this.Position, this.Normal, this.UV) = (position, normal, uv);
}

namespace OpenGL;

public sealed class Transform : Component
{
	public Matrix4x4 Matrix;

	public Transform(Matrix4x4 matrix) => this.Matrix = matrix;
}

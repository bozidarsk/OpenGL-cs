using System;
using System.Runtime.InteropServices;

namespace OpenGL;

[StructLayout(LayoutKind.Sequential)]
public struct Quaternion 
{
	public float w, x, y, z; // w + xi + yj + zk

	public readonly Quaternion Inversed => new Quaternion(w, -x, -y, -z);

	public static readonly Quaternion Identity = new Quaternion(1, 0, 0, 0);

	public static Quaternion operator * (Quaternion l, Quaternion r) => new Quaternion(
		l.w*r.w - l.x*r.x - l.y*r.y - l.z*r.z,
		l.w*r.x + l.x*r.w + l.y*r.z - l.z*r.y,
		l.w*r.y - l.x*r.z + l.y*r.w + l.z*r.x,
		l.w*r.z + l.x*r.y - l.y*r.x + l.z*r.w
	);

	public override string ToString() => $"({w:f6}, {x:f6}, {y:f6}, {z:f6})";

	public Quaternion(float w, float x, float y, float z) => (this.w, this.x, this.y, this.z) = (w, x, y, z);

	public Quaternion(Vector3 euler) => this = new Quaternion(Vector3.Right, euler.x) * new Quaternion(Vector3.Up, euler.y) * new Quaternion(Vector3.Forward, euler.z);

	public Quaternion(Vector3 axis, float angle) 
	{
		angle /= 2f;
		angle *= (float)Math.PI / 180f;

		axis = axis.Normalized * (float)Math.Sin(angle);

		this.w = (float)Math.Cos(angle);
		this.x = axis.x;
		this.y = axis.y;
		this.z = -axis.z;
	}
}

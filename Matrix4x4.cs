using System.Runtime.InteropServices;

namespace OpenGL;

[StructLayout(LayoutKind.Sequential)]
public struct Matrix4x4 
{
	public float xx, yx, zx, tx;
	public float xy, yy, zy, ty;
	public float xz, yz, zz, tz;
	public float xw, yw, zw, tw;

	public readonly Vector4 x => new Vector4(xx, xy, xz, xw);
	public readonly Vector4 y => new Vector4(yx, yy, yz, yw);
	public readonly Vector4 z => new Vector4(zx, zy, zz, zw);
	public readonly Vector4 t => new Vector4(tx, ty, tz, tw);

	public static readonly Matrix4x4 Identity = new Matrix4x4() 
	{
		xx = 1, yx = 0, zx = 0, tx = 0,
		xy = 0, yy = 1, zy = 0, ty = 0,
		xz = 0, yz = 0, zz = 1, tz = 0,
		xw = 0, yw = 0, zw = 0, tw = 1,
	};

	public static readonly Matrix4x4 Zero = new Matrix4x4() 
	{
		xx = 0, yx = 0, zx = 0, tx = 0,
		xy = 0, yy = 0, zy = 0, ty = 0,
		xz = 0, yz = 0, zz = 0, tz = 0,
		xw = 0, yw = 0, zw = 0, tw = 0,
	};

	public static Matrix4x4 operator * (Matrix4x4 l, Matrix4x4 r) => new Matrix4x4(
		new Vector4(r.xx, r.xy, r.xz, r.xw) * l,
		new Vector4(r.yx, r.yy, r.yz, r.yw) * l,
		new Vector4(r.zx, r.zy, r.zz, r.zw) * l,
		new Vector4(r.tx, r.ty, r.tz, r.tw) * l
	);

	public static Vector4 operator * (Vector4 v, Matrix4x4 m) => new Vector4(
		Vector4.Dot(v, m.x),
		Vector4.Dot(v, m.y),
		Vector4.Dot(v, m.z),
		Vector4.Dot(v, m.t)
	);

	public Matrix4x4(Vector4 x, Vector4 y, Vector4 z, Vector4 t) 
	{
		this.xx = x.x;
		this.xy = x.y;
		this.xz = x.z;
		this.xw = x.w;

		this.yx = y.x;
		this.yy = y.y;
		this.yz = y.z;
		this.yw = y.w;

		this.zx = z.x;
		this.zy = z.y;
		this.zz = z.z;
		this.zw = z.w;

		this.tx = t.x;
		this.ty = t.y;
		this.tz = t.z;
		this.tw = t.w;
	}
}

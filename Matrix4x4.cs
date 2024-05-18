using System;
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

	public readonly float Determinand => 0f
		+ (xx*yy - yx*xy) * (zz*tw - tz*zw)
		- (xx*zy - zx*xy) * (yz*tw - tz*yw)
		+ (xx*ty - tx*xy) * (yz*zw - zz*yw)
		+ (yx*zy - zx*yy) * (xz*tw - tz*xw)
		- (yx*ty - tx*yy) * (xz*zw - zz*xw)
		+ (zx*ty - tx*zy) * (xz*yw - yz*xw)
	;

	public readonly Matrix4x4 Transposed => new Matrix4x4(
		new Vector4(xx, yx, zx, tx),
		new Vector4(xy, yy, zy, ty),
		new Vector4(xz, yz, zz, tz),
		new Vector4(xw, yw, zw, tw)
	);

	public static readonly Matrix4x4 Identity = new Matrix4x4() 
	{
		xx = 1f, yx = 0f, zx = 0f, tx = 0f,
		xy = 0f, yy = 1f, zy = 0f, ty = 0f,
		xz = 0f, yz = 0f, zz = 1f, tz = 0f,
		xw = 0f, yw = 0f, zw = 0f, tw = 1f,
	};

	public static readonly Matrix4x4 Zero = new Matrix4x4() 
	{
		xx = 0f, yx = 0f, zx = 0f, tx = 0f,
		xy = 0f, yy = 0f, zy = 0f, ty = 0f,
		xz = 0f, yz = 0f, zz = 0f, tz = 0f,
		xw = 0f, yw = 0f, zw = 0f, tw = 0f,
	};

	public static Matrix4x4 operator * (Matrix4x4 l, Matrix4x4 r) => new Matrix4x4(
		l * r.x,
		l * r.y,
		l * r.z,
		l * r.t
	);

	public static Vector4 operator * (Matrix4x4 m, Vector4 v) => v * m.Transposed;

	public static Vector4 operator * (Vector4 v, Matrix4x4 m) => new Vector4(
		Vector4.Dot(v, m.x),
		Vector4.Dot(v, m.y),
		Vector4.Dot(v, m.z),
		Vector4.Dot(v, m.t)
	);

	public override string ToString() => $"{xx:f6} {yx:f6} {zx:f6} {tx:f6}\n{xy:f6} {yy:f6} {zy:f6} {ty:f6}\n{xz:f6} {yz:f6} {zz:f6} {tz:f6}\n{xw:f6} {yw:f6} {zw:f6} {tw:f6}";

	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) 
	{
		return new Matrix4x4() 
		{
			xx = 2f / (right - left), yx = 0f,                  zx = 0f,                 tx = -(right + left) / (right - left),
			xy = 0f,                  yy = 2f / (top - bottom), zy = 0f,                 ty = -(top + bottom) / (top - bottom),
			xz = 0f,                  yz = 0f,                  zz = -2f / (far - near), tz = -(far + near) / (far - near),
			xw = 0f,                  yw = 0f,                  zw = 0f,                 tw = 1f,
		};
	}

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

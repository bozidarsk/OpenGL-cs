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

	public static Vector4 operator * (Matrix4x4 m, Vector4 v) => (m.x * v.x) + (m.y * v.y) + (m.z * v.z) + (m.t * v.w);

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

	public static Matrix4x4 Translate(Vector3 v) => Matrix4x4.Identity with { tx = v.x, ty = v.y, tz = v.z };
	public static Matrix4x4 Scale(Vector3 v) => Matrix4x4.Identity with { xx = v.x, yy = v.y, zz = v.z };
	public static Matrix4x4 Rotate(Quaternion q) 
	{
		// from https://github.com/Unity-Technologies/UnityCsReference/blob/master/Runtime/Export/Math/Matrix4x4.cs#L370

		// Precalculate coordinate products
		float x = q.x * 2f;
		float y = q.y * 2f;
		float z = q.z * 2f;
		float xx = q.x * x;
		float yy = q.y * y;
		float zz = q.z * z;
		float xy = q.x * y;
		float xz = q.x * z;
		float yz = q.y * z;
		float wx = q.w * x;
		float wy = q.w * y;
		float wz = q.w * z;

		// Calculate 3x3 matrix from orthonormal basis
		Matrix4x4 m;
		m.xx = 1.0f - (yy + zz); m.yx = xy + wz; m.zx = xz - wy; m.tx = 0.0f;
		m.xy = xy - wz; m.yy = 1.0f - (xx + zz); m.zy = yz + wx; m.ty = 0.0f;
		m.xz = xz + wy; m.yz = yz - wx; m.zz = 1.0f - (xx + yy); m.tz = 0.0f;
		m.xw = 0.0f; m.yw = 0.0f; m.zw = 0.0f; m.tw = 1.0f;
		return m;
	}

	public static Matrix4x4 TRS(Vector3 t, Quaternion r, Vector3 s) => Translate(t) * (Rotate(r) * Scale(s));

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

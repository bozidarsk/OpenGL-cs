using System;

namespace OpenGL.GLFW;

public sealed unsafe class Image 
{
	private nint handle;

	public int Width => ((int*)handle)[0];
	public int Height => ((int*)handle)[1];

	public unsafe Color this[int x, int y] 
	{
		set => ((uint*)handle)[x + y * Width] = (x < 0 || x > Width || y < 0 || y > Height) ? throw new ArgumentOutOfRangeException() : (uint)value;
		get => (x < 0 || x > Width || y < 0 || y > Height) ? throw new ArgumentOutOfRangeException() : (Color)(((uint*)handle)[x + y * Width]);
	}

	public static implicit operator nint(Image? x) => (x != null) ? x.handle : nint.Zero;
	public static implicit operator Image(nint x) => new Image(x);
	private Image(nint handle) => this.handle = handle;
}

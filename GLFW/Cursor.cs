using System;
using System.Runtime.InteropServices;

using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public sealed class Cursor : IDisposable
{
	private nint handle;

	public void Dispose() => glfwDestroyCursor(this);

	public static implicit operator nint(Cursor? x) => (x != null) ? x.handle : nint.Zero;
	public static implicit operator Cursor(nint x) => new Cursor(x);
	private Cursor(nint handle) => this.handle = handle;

	public Cursor(Image image, int xhot, int yhot) => handle = glfwCreateCursor(image, xhot, yhot);
	public Cursor(CursorShape shape) => handle = glfwCreateStandardCursor(shape);

	[DllImport(GLFW_LIB)] private static extern nint glfwCreateCursor(nint image, int xhot, int yhot);
	[DllImport(GLFW_LIB)] private static extern nint glfwCreateStandardCursor(CursorShape shape);
	[DllImport(GLFW_LIB)] private static extern void glfwDestroyCursor(nint cursor);
}

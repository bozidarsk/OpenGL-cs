using System;
using System.Runtime.InteropServices;

namespace OpenGL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void DropCallback(nint window, int count, nint paths);

public delegate void DropEventHandler(object sender, DropEventArgs args);

public sealed class DropEventArgs : EventArgs
{
	public string[] Paths { get; }

	public DropEventArgs(string[] paths) => (this.Paths) = (paths);
}

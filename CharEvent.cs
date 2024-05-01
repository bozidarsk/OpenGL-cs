using System;
using System.Runtime.InteropServices;

namespace OpenGL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void CharCallback(nint window, uint codepoint);

public delegate void CharEventHandler(object sender, CharEventArgs args);

public sealed class CharEventArgs : EventArgs
{
	public uint CodePoint { get; }

	public CharEventArgs(uint codepoint) => (this.CodePoint) = (codepoint);
}

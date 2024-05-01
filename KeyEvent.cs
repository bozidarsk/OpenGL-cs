using System;
using System.Runtime.InteropServices;

namespace OpenGL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void KeyCallback(nint window, int scancode, KeyState state, KeyModifier modifiers);

public delegate void KeyEventHandler(object sender, KeyEventArgs args);

public sealed class KeyEventArgs : EventArgs
{
	public int Scancode { get; }
	public KeyState State { get; }
	public KeyModifier Modifiers { get; }

	public KeyEventArgs(int scancode, KeyState state, KeyModifier modifiers) => (this.Scancode, this.State, this.Modifiers) = (scancode, state, modifiers);
}

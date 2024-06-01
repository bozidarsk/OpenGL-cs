using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenGL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void ErrorCallback(uint source, uint type, uint id, uint severity, int length, string message, nint userPointer);

public delegate void ErrorEventHandler(object? sender, ErrorEventArgs args);

public sealed class ErrorEventArgs : EventArgs
{
	public uint Source { get; }
	public uint Type { get; }
	public uint Id { get; }
	public uint Severity { get; }
	public string Message { get; }
	public nint UserPointer { get; }

	public ErrorEventArgs(uint source, uint type, uint id, uint severity, string message, nint userPointer) => (this.Source, this.Type, this.Id, this.Severity, this.Message, this.UserPointer) = (source, type, id, severity, message, userPointer);
}

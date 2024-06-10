using System;

namespace OpenGL;

public class GLException : Exception
{
	public GLException() : base("OpenGL threw an exception.") {}
	public GLException(string message) : base(message) {}
	public GLException(string message, Exception inner) : base(message, inner) {}
}

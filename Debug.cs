using System;
using System.Collections.Generic;
using System.Linq;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public static class Debug 
{
	public static event ErrorEventHandler? OnError;

	public static IEnumerable<uint> Errors 
	{
		get 
		{
			uint error;
			while ((error = glGetError()) != 0)
				yield return error;
		}
	}

	public static void LogErrors() 
	{
		foreach (var x in Errors)
			Console.WriteLine($"Error {x}.");
	}

	public static void ClearErrors() 
	{
		foreach (var x in Errors);
	}

	static Debug() 
	{
		glDebugMessageCallback(
			(uint source, uint type, uint id, uint severity, int length, string message, nint userPointer) => 
				OnError?.Invoke(null!, new(source, type, id, severity, message, userPointer)),
			nint.Zero
		);
	}
}

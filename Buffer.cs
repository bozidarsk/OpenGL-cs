using System;
using System.Reflection;
using System.Runtime.InteropServices;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Buffer : IDisposable
{
	public int Count { get; }
	public int Stride { get; }
	public nint Data { get; }
	public BufferType Type { get; }
	public BufferUsage Usage { get; }

	private readonly uint id;

	public void Bind() => glBindBuffer((uint)Type, this);
	public void Dispose() 
	{
		uint obj = this;
		glDeleteBuffers(1, ref obj);
	}

	public void EnableAttributes<T>() where T : struct
	{
		Bind();

		uint fieldIndex = 0;
		foreach (FieldInfo field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance)) 
		{
			glEnableVertexAttribArray(fieldIndex);
			glVertexAttribPointer(
				fieldIndex,
				Marshal.SizeOf(field.FieldType) / sizeof(float),
				GL_FLOAT,
				false,
				Marshal.SizeOf(typeof(T)),
				Marshal.OffsetOf(typeof(T), field.Name)
			);

			fieldIndex++;
		}
	}

	public void DisableAttributes<T>() where T : struct
	{
		Bind();

		uint fieldIndex = 0;
		foreach (FieldInfo field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance))
			glDisableVertexAttribArray(fieldIndex++);
	}

	public override string ToString() => $"{this.GetType()} {id}";
	public static implicit operator uint(Buffer x) => x.id;

	public Buffer(int count, int stride, nint data, BufferType type, BufferUsage usage) 
	{
		this.Count = count;
		this.Stride = stride;
		this.Data = data;
		this.Type = type;
		this.Usage = usage;

		glGenBuffers(1, ref id);
		Bind();
		glBufferData((uint)type, (nuint)(count * stride), data, (uint)usage);
	}
}

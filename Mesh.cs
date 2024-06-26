using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public sealed class Mesh : IDisposable
{
	private Buffer vertices;
	private Buffer indices;

	public int VertexCount => vertices.Count;
	public int IndexCount => indices.Count;

	public unsafe ReadOnlySpan<Vertex> Vertices => new ReadOnlySpan<Vertex>((void*)vertices.Data, vertices.Count);
	public unsafe ReadOnlySpan<uint> Indices => new ReadOnlySpan<uint>((void*)indices.Data, indices.Count);

	public void Dispose() 
	{
		vertices.Dispose();
		indices.Dispose();
	}

	public void BindVertexBuffer() => vertices.Bind();
	public void BindIndexBuffer() => indices.Bind();
	public void EnableVertexAttributes() => vertices.EnableAttributes<Vertex>();
	public void DisableVertexAttributes() => vertices.DisableAttributes<Vertex>();

	public Mesh(Vertex[] vertices, uint[] indices) : this(new Span<Vertex>(vertices), new Span<uint>(indices)) {}

	public unsafe Mesh(Span<Vertex> vertices, Span<uint> indices) 
	{
		this.vertices = new Buffer(
			vertices.Length,
			sizeof(Vertex),
			(nint)Unsafe.AsPointer<Vertex>(ref vertices.GetPinnableReference()),
			BufferType.Array,
			BufferUsage.StaticDraw
		);

		this.indices = new Buffer(
			indices.Length,
			sizeof(uint),
			(nint)Unsafe.AsPointer<uint>(ref indices.GetPinnableReference()),
			BufferType.ElementArray,
			BufferUsage.StaticDraw
		);
	}
}

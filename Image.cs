namespace OpenGL;

public sealed unsafe class Image 
{
	private nint handle;

	public int Width => ((int*)handle)[0];
	public int Height => ((int*)handle)[1];
	public Span<Color> Pixels => new Span<Color>((void*)(handle + 8), Width * Height);

	public static implicit operator nint(Image? x) => (x != null) ? x.handle : nint.Zero;
	public static implicit operator Image(nint x) => new Image(x);
	private Image(nint handle) => this.handle = handle;
}

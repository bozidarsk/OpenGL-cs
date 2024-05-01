using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace OpenGL;

[StructLayout(LayoutKind.Sequential)]
public struct Color 
{
	public byte r, g, b, a;

	public override string ToString() => $"#{r:x2}{g:x2}{b:x2}{a:x2}";

	public unsafe Color(string format) 
	{
		if (format == null)
			throw new ArgumentNullException();

		int index = 0;

		if (format.StartsWith("#"))
			index = 1;

		if (format.StartsWith("0x"))
			index = 2;

		if (format.Length - index != 8)
			format += "ff";
        
        if (format.Length - index != 8)
			throw new FormatException(format);

		uint color = uint.Parse(format.Remove(0, index), System.Globalization.NumberStyles.HexNumber);

		byte* channels = (byte*)Unsafe.AsPointer<Color>(ref this);
        channels[3] = (byte)(color >> 0 * 8);
        channels[2] = (byte)(color >> 1 * 8);
        channels[1] = (byte)(color >> 2 * 8);
        channels[0] = (byte)(color >> 3 * 8);
	}

	public unsafe Color(uint color) 
	{
		byte* channels = (byte*)Unsafe.AsPointer<Color>(ref this);
        channels[3] = (byte)(color >> 0 * 8);
        channels[2] = (byte)(color >> 1 * 8);
        channels[1] = (byte)(color >> 2 * 8);
        channels[0] = (byte)(color >> 3 * 8);
	}

	public Color(float r, float g, float b, float a = 1f) 
	{
		this.r = (byte)(r * 255f);
		this.g = (byte)(g * 255f);
		this.b = (byte)(b * 255f);
		this.a = (byte)(a * 255f);
	}

	public Color(byte r, byte g, byte b, byte a = 0xff) 
	{
		this.r = r;
		this.g = g;
		this.b = b;
		this.a = a;
	}
}

namespace OpenGL;

public enum Platform : uint
{
	Any = 0x00060000,
	Win32 = 0x00060001,
	Cocoa = 0x00060002,
	Wayland = 0x00060003,
	X11 = 0x00060004,
	Null = 0x00060005,
}

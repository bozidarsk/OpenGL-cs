using static OpenGL.Constants;

namespace OpenGL;

public enum TextureFormatType : uint
{
	Float = GL_FLOAT,
	UnsignedByte = GL_UNSIGNED_BYTE,
	Byte = GL_BYTE,
	UnsignedShort = GL_UNSIGNED_SHORT,
	Short = GL_SHORT,
	UnsignedInt = GL_UNSIGNED_INT,
	Int = GL_INT,
}

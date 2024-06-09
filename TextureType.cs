using static OpenGL.Constants;

namespace OpenGL;

public enum TextureType : uint
{
	Generic1D = GL_TEXTURE_1D,
	Array1D = GL_TEXTURE_1D_ARRAY,
	Generic2D = GL_TEXTURE_2D,
	Array2D = GL_TEXTURE_2D_ARRAY,
	Multisample2D = GL_TEXTURE_2D_MULTISAMPLE,
	MultisampleArray2D = GL_TEXTURE_2D_MULTISAMPLE_ARRAY,
	Generic3D = GL_TEXTURE_3D,
	CubeMap = GL_TEXTURE_CUBE_MAP,
	CubeMapArray = GL_TEXTURE_CUBE_MAP_ARRAY,
	Rectangle = GL_TEXTURE_RECTANGLE,
}

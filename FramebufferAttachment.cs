using static OpenGL.Constants;

namespace OpenGL;

[System.Flags]
public enum FramebufferAttachment : uint
{
	Color = GL_COLOR_ATTACHMENT0,
	Depth = GL_DEPTH_ATTACHMENT,
	Stencil = GL_STENCIL_ATTACHMENT,
}

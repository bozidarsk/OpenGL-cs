using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public enum KeyState : int
{
	Release = GLFW_RELEASE,
	Press = GLFW_PRESS,
	Repeat = GLFW_REPEAT,
}

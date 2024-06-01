using System.Runtime.InteropServices;

using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public static class Input 
{
	public static bool IsRawMouseMotionSupported => glfwRawMouseMotionSupported();

	public static ulong TimerValue => glfwGetTimerValue();
	public static ulong TimerFrequency => glfwGetTimerFrequency();

	public static double Time 
	{
		set => glfwSetTime(value);
		get => glfwGetTime();
	}

	public static void SetJoystickUserPointer(int jid, nint value) => glfwSetJoystickUserPointer(jid, value);
	public static nint GetJoystickUserPointer(int jid) => glfwGetJoystickUserPointer(jid);
	public static bool IsJoystickPresent(int jid) => glfwJoystickPresent(jid);
	public static unsafe string GetJoystickName(int jid) => new string(glfwGetJoystickName(jid));
	public static unsafe string GetJoystickGUID(int jid) => new string(glfwGetJoystickGUID(jid));
	public static bool IsJoystickGamepad(int jid) => glfwJoystickIsGamepad(jid);
	public static unsafe string GetGamepadName(int jid) => new string(glfwGetGamepadName(jid));
	public static bool TryUpdateGamepadMappings(string mappings) => glfwUpdateGamepadMappings(mappings);

	public static void PollEvents() => glfwPollEvents();
	public static void WaitForEvents() => glfwWaitEvents();
	public static void WaitForEventsTimeout(double time) => glfwWaitEventsTimeout(time);
	public static void PostEmptyEvent() => glfwPostEmptyEvent();
	public static unsafe string GetKeyName(KeyCode key, int scancode) => new string(glfwGetKeyName(key, scancode));
	public static int GetKeyScancode(KeyCode key) => glfwGetKeyScancode(key);

	[DllImport(GLFW_LIB)] private static extern void glfwPollEvents();
	[DllImport(GLFW_LIB)] private static extern void glfwWaitEvents();
	[DllImport(GLFW_LIB)] private static extern void glfwWaitEventsTimeout(double timeout);
	[DllImport(GLFW_LIB)] private static extern void glfwPostEmptyEvent();
	[DllImport(GLFW_LIB)] private static extern bool glfwRawMouseMotionSupported();
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetKeyName(KeyCode key, int scancode);
	[DllImport(GLFW_LIB)] private static extern int glfwGetKeyScancode(KeyCode key);
	[DllImport(GLFW_LIB)] private static extern bool glfwJoystickPresent(int jid);
	// [DllImport(GLFW_LIB)] private static extern float* glfwGetJoystickAxes(int jid, int* count);
	// [DllImport(GLFW_LIB)] private static extern byte* glfwGetJoystickButtons(int jid, int* count);
	// [DllImport(GLFW_LIB)] private static extern byte* glfwGetJoystickHats(int jid, int* count);
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetJoystickName(int jid);
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetJoystickGUID(int jid);
	[DllImport(GLFW_LIB)] private static extern void glfwSetJoystickUserPointer(int jid, nint pointer);
	[DllImport(GLFW_LIB)] private static extern nint glfwGetJoystickUserPointer(int jid);
	[DllImport(GLFW_LIB)] private static extern bool glfwJoystickIsGamepad(int jid);
	// [DllImport(GLFW_LIB)] private static extern GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);
	[DllImport(GLFW_LIB)] private static extern bool glfwUpdateGamepadMappings(string str);
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetGamepadName(int jid);
	// [DllImport(GLFW_LIB)] private static extern int glfwGetGamepadState(int jid, GLFWgamepadstate* state);
	[DllImport(GLFW_LIB)] private static extern double glfwGetTime();
	[DllImport(GLFW_LIB)] private static extern void glfwSetTime(double time);
	[DllImport(GLFW_LIB)] private static extern ulong glfwGetTimerValue();
	[DllImport(GLFW_LIB)] private static extern ulong glfwGetTimerFrequency();
}

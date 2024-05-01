using System.Runtime.InteropServices;

namespace OpenGL;

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
	public static string GetJoystickName(int jid) => glfwGetJoystickName(jid);
	public static string GetJoystickGUID(int jid) => glfwGetJoystickGUID(jid);
	public static bool IsJoystickGamepad(int jid) => glfwJoystickIsGamepad(jid);
	public static string GetGamepadName(int jid) => glfwGetGamepadName(jid);
	public static bool TryUpdateGamepadMappings(string mappings) => glfwUpdateGamepadMappings(mappings);

	public static void PollEvents() => glfwPollEvents();
	public static void WaitForEvents() => glfwWaitEvents();
	public static void WaitForEventsTimeout(double time) => glfwWaitEventsTimeout(time);
	public static void PostEmptyEvent() => glfwPostEmptyEvent();
	public static string GetKeyName(KeyCode key, int scancode) => glfwGetKeyName(key, scancode);
	public static int GetKeyScancode(KeyCode key) => glfwGetKeyScancode(key);

	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwPollEvents();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwWaitEvents();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwWaitEventsTimeout(double timeout);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwPostEmptyEvent();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwRawMouseMotionSupported();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetKeyName(KeyCode key, int scancode);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern int glfwGetKeyScancode(KeyCode key);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwJoystickPresent(int jid);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern float* glfwGetJoystickAxes(int jid, int* count);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern byte* glfwGetJoystickButtons(int jid, int* count);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern byte* glfwGetJoystickHats(int jid, int* count);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetJoystickName(int jid);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetJoystickGUID(int jid);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetJoystickUserPointer(int jid, nint pointer);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern nint glfwGetJoystickUserPointer(int jid);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwJoystickIsGamepad(int jid);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwUpdateGamepadMappings(string str);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetGamepadName(int jid);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern int glfwGetGamepadState(int jid, GLFWgamepadstate* state);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern double glfwGetTime();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetTime(double time);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern ulong glfwGetTimerValue();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern ulong glfwGetTimerFrequency();
}

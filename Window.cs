using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace OpenGL;

public sealed class Window : IDisposable
{
	private nint handle;

	public string Title 
	{
		set => glfwSetWindowTitle(this, value);
		get => glfwGetWindowTitle(this);
	}

	public nint UserPointer 
	{
		set => glfwSetWindowUserPointer(this, value);
		get => glfwGetWindowUserPointer(this);
	}

	public bool ShouldClose 
	{
		set => glfwSetWindowShouldClose(this, value);
		get => glfwWindowShouldClose(this);
	}

	public float Opacity 
	{
		set => glfwSetWindowOpacity(this, value);
		get => glfwGetWindowOpacity(this);
	}

	public (int, int) Position 
	{
		set 
		{
			(int x, int y) = value;
			glfwSetWindowPos(this, x, y);
		}
		get 
		{
			glfwGetWindowPos(this, out int x, out int y);
			return (x, y);
		}
	}

	public (int, int) Size 
	{
		set 
		{
			(int width, int height) = value;
			glfwSetWindowSize(this, width, height);
		}
		get 
		{
			glfwGetWindowSize(this, out int width, out int height);
			return (width, height);
		}
	}

	public (int, int) FramebufferSize 
	{
		get 
		{
			glfwGetFramebufferSize(this, out int width, out int height);
			return (width, height);
		}
	}

	public Image Icon 
	{
		set => glfwSetWindowIcon(this, 1, value);
	}

	public (float, float) ContentScale 
	{
		get 
		{
			glfwGetWindowContentScale(this, out float x, out float y);
			return (x, y);
		}
	}

	public string ClipboardText 
	{
		set => glfwSetClipboardString(this, value);
		get => glfwGetClipboardString(this);
	}

	public (double, double) CursorPosition 
	{
		set 
		{
			(double x, double y) = value;
			glfwSetCursorPos(this, x, y);
		}
		get 
		{
			glfwGetCursorPos(this, out double x, out double y);
			return (x, y);
		}
	}

	public Cursor Cursor 
	{
		set => glfwSetCursor(this, value);
	}

	public Monitor Monitor => glfwGetWindowMonitor(this);
	public void SetMonitor(Monitor monitor, int x, int y, int width, int height, int refreshRate) => glfwSetWindowMonitor(this, monitor, x, y, width, height, refreshRate);

	public bool GetKey(KeyCode key) => glfwGetKey(this, key);
	public bool GetMouseButton(KeyCode button) => glfwGetKey(this, button);

	public void SetInputMode(InputMode mode, int value) => glfwSetInputMode(this, mode, value);
	public int GetInputMode(InputMode mode) => glfwGetInputMode(this, mode);

	public void SwapBuffers() => glfwSwapBuffers(this);
	public void MakeCurrentContext() => glfwMakeContextCurrent(this);
	public void Iconify() => glfwIconifyWindow(this);
	public void Restore() => glfwRestoreWindow(this);
	public void Maximize() => glfwMaximizeWindow(this);
	public void Show() => glfwShowWindow(this);
	public void Hide() => glfwHideWindow(this);
	public void Focus() => glfwFocusWindow(this);
	public void RequestAttention() => glfwRequestWindowAttention(this);

	public override string ToString() => this.Title;

	public void Dispose() => glfwDestroyWindow(this);

	public static implicit operator nint(Window? x) => (x != null) ? x.handle : nint.Zero;
	public static implicit operator Window(nint x) => new Window(x);
	private Window(nint handle) => this.handle = handle;

	public Window(int width, int height) : this(width, height, "Managed OpenGL Window", null, null) {}
	public Window(int width, int height, string title) : this(width, height, title, null, null) {}
	public unsafe Window(int width, int height, string title, Monitor? monitor, Window? share) 
	{
		handle = glfwCreateWindow(width, height, title, monitor, share);

		// glfwSetKeyCallback(this, (nint window, int scancode, KeyState state, KeyModifier modifiers) => OnKey?.Invoke(window, new KeyEventArgs(scancode, state, modifiers)));
		// glfwSetCharCallback(this, (nint window, uint codepoint) => OnChar?.Invoke(window, new CharEventArgs(codepoint)));
		// glfwSetMouseButtonCallback(this, (nint window, KeyCode button, KeyState state, KeyModifier modifiers) => OnMouseButton?.Invoke(window, new MouseButtonEventArgs(button, state, modifiers)));
		// glfwSetCursorPosCallback(this, (nint window, double x, double y) => OnCursorPosition?.Invoke(window, new CursorPositionEventArgs(x, y)));
		// glfwSetCursorEnterCallback(this, (nint window, bool entered) => OnCursorEnter?.Invoke(window, new CursorEnterEventArgs(entered)));
		// glfwSetScrollCallback(this, (nint window, double x, double y) => OnScroll?.Invoke(window, new ScrollEventArgs(x, y)));
		// glfwSetDropCallback(this, (nint window, int count, nint paths) => OnDrop?.Invoke(window, new DropEventArgs(new byte[count].Select((x, i) => new string((sbyte*)GLFW.PointerIndexer<nint>(paths, i))).ToArray())));
	}

	public event KeyEventHandler? OnKey;
	public event CharEventHandler? OnChar;
	public event MouseButtonEventHandler? OnMouseButton;
	public event CursorPositionEventHandler? OnCursorPosition;
	public event CursorEnterEventHandler? OnCursorEnter;
	public event ScrollEventHandler? OnScroll;
	public event DropEventHandler? OnDrop;

	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwDefaultWindowHints();
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwWindowHint(int hint, int value);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwWindowHintString(int hint, string value);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern nint glfwCreateWindow(int width, int height, string title, nint monitor, nint share);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwDestroyWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwWindowShouldClose(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowShouldClose(nint window, bool value);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetWindowTitle(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowTitle(nint window, string title);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowIcon(nint window, int count, nint image);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetWindowPos(nint window, out int xpos, out int ypos);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowPos(nint window, int xpos, int ypos);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetWindowSize(nint window, out int width, out int height);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowSizeLimits(nint window, int minwidth, int minheight, int maxwidth, int maxheight);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowAspectRatio(nint window, int numer, int denom);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowSize(nint window, int width, int height);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetFramebufferSize(nint window, out int width, out int height);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetWindowFrameSize(nint window, out int left, out int top, out int right, out int bottom);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetWindowContentScale(nint window, out float xscale, out float yscale);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern float glfwGetWindowOpacity(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowOpacity(nint window, float opacity);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwIconifyWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwRestoreWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwMaximizeWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwShowWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwHideWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwFocusWindow(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwRequestWindowAttention(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern nint glfwGetWindowMonitor(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowMonitor(nint window, nint monitor, int xpos, int ypos, int width, int height, int refreshRate);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern int glfwGetWindowAttrib(nint window, int attrib);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowAttrib(nint window, int attrib, int value);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetWindowUserPointer(nint window, nint pointer);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern nint glfwGetWindowUserPointer(nint window);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowposfun glfwSetWindowPosCallback(nint window, GLFWwindowposfun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowsizefun glfwSetWindowSizeCallback(nint window, GLFWwindowsizefun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowclosefun glfwSetWindowCloseCallback(nint window, GLFWwindowclosefun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback(nint window, GLFWwindowrefreshfun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowfocusfun glfwSetWindowFocusCallback(nint window, GLFWwindowfocusfun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback(nint window, GLFWwindowiconifyfun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowmaximizefun glfwSetWindowMaximizeCallback(nint window, GLFWwindowmaximizefun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback(nint window, GLFWframebuffersizefun callback);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern GLFWwindowcontentscalefun glfwSetWindowContentScaleCallback(nint window, GLFWwindowcontentscalefun callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSwapBuffers(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwMakeContextCurrent(nint window);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern int glfwGetInputMode(nint window, InputMode mode);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetInputMode(nint window, InputMode mode, int value);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwGetKey(nint window, KeyCode key);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwGetMouseButton(nint window, KeyCode button);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetCursorPos(nint window, out double xpos, out double ypos);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetCursorPos(nint window, double xpos, double ypos);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetCursor(nint window, nint cursor);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetKeyCallback(nint window, KeyCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetCharCallback(nint window, CharCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetMouseButtonCallback(nint window, MouseButtonCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetCursorPosCallback(nint window, CursorPositionCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetCursorEnterCallback(nint window, CursorEnterCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetScrollCallback(nint window, ScrollCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetDropCallback(nint window, DropCallback callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetClipboardString(nint window, string str);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetClipboardString(nint window);
}

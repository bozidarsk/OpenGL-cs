using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public sealed class Window : IDisposable
{
	private nint handle;

	public string Title 
	{
		set => glfwSetWindowTitle(this, value);
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

	public unsafe string ClipboardText 
	{
		set => glfwSetClipboardString(this, value);
		get => new string(glfwGetClipboardString(this));
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

	public void Dispose() => glfwDestroyWindow(this);

	public static implicit operator nint(Window? x) => (x != null) ? x.handle : nint.Zero;
	public static implicit operator Window(nint x) => new Window(x);
	private Window(nint handle) => this.handle = handle;

	public unsafe Window(int width, int height, string title = "Managed OpenGL Window", Monitor? monitor = null, Window? share = null) 
	{
		handle = glfwCreateWindow(width, height, title, monitor, share);

		glfwSetKeyCallback(this, (window, key, scancode, state, modifiers) => OnKey?.Invoke(this, new(key, scancode, state, modifiers)));
		glfwSetCharCallback(this, (window, codepoint) => OnChar?.Invoke(this, new(codepoint)));
		glfwSetMouseButtonCallback(this, (window, button, state, modifiers) => OnMouseButton?.Invoke(this, new(button, state, modifiers)));
		glfwSetCursorPosCallback(this, (window, x, y) => OnCursorPosition?.Invoke(this, new(x, y)));
		glfwSetCursorEnterCallback(this, (window, entered) => OnCursorEnter?.Invoke(this, new(entered)));
		glfwSetScrollCallback(this, (window, x, y) => OnScroll?.Invoke(this, new(x, y)));
		glfwSetDropCallback(this, (window, count, paths) => OnDrop?.Invoke(window, new(new ReadOnlySpan<nint>(paths, count).ToImmutableArray().Select(x => new string((sbyte*)x)).ToArray())));
	}

	public event KeyEventHandler? OnKey;
	public event CharEventHandler? OnChar;
	public event MouseButtonEventHandler? OnMouseButton;
	public event CursorPositionEventHandler? OnCursorPosition;
	public event CursorEnterEventHandler? OnCursorEnter;
	public event ScrollEventHandler? OnScroll;
	public event DropEventHandler? OnDrop;

	// [DllImport(GLFW_LIB)] private static extern void glfwDefaultWindowHints();
	// [DllImport(GLFW_LIB)] private static extern void glfwWindowHint(int hint, int value);
	// [DllImport(GLFW_LIB)] private static extern void glfwWindowHintString(int hint, string value);
	[DllImport(GLFW_LIB)] private static extern nint glfwCreateWindow(int width, int height, string title, nint monitor, nint share);
	[DllImport(GLFW_LIB)] private static extern void glfwDestroyWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern bool glfwWindowShouldClose(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowShouldClose(nint window, bool value);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowTitle(nint window, string title);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowIcon(nint window, int count, nint image);
	[DllImport(GLFW_LIB)] private static extern void glfwGetWindowPos(nint window, out int xpos, out int ypos);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowPos(nint window, int xpos, int ypos);
	[DllImport(GLFW_LIB)] private static extern void glfwGetWindowSize(nint window, out int width, out int height);
	// [DllImport(GLFW_LIB)] private static extern void glfwSetWindowSizeLimits(nint window, int minwidth, int minheight, int maxwidth, int maxheight);
	// [DllImport(GLFW_LIB)] private static extern void glfwSetWindowAspectRatio(nint window, int numer, int denom);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowSize(nint window, int width, int height);
	[DllImport(GLFW_LIB)] private static extern void glfwGetFramebufferSize(nint window, out int width, out int height);
	// [DllImport(GLFW_LIB)] private static extern void glfwGetWindowFrameSize(nint window, out int left, out int top, out int right, out int bottom);
	[DllImport(GLFW_LIB)] private static extern void glfwGetWindowContentScale(nint window, out float xscale, out float yscale);
	[DllImport(GLFW_LIB)] private static extern float glfwGetWindowOpacity(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowOpacity(nint window, float opacity);
	[DllImport(GLFW_LIB)] private static extern void glfwIconifyWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwRestoreWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwMaximizeWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwShowWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwHideWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwFocusWindow(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwRequestWindowAttention(nint window);
	[DllImport(GLFW_LIB)] private static extern nint glfwGetWindowMonitor(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowMonitor(nint window, nint monitor, int xpos, int ypos, int width, int height, int refreshRate);
	// [DllImport(GLFW_LIB)] private static extern int glfwGetWindowAttrib(nint window, int attrib);
	// [DllImport(GLFW_LIB)] private static extern void glfwSetWindowAttrib(nint window, int attrib, int value);
	[DllImport(GLFW_LIB)] private static extern void glfwSetWindowUserPointer(nint window, nint pointer);
	[DllImport(GLFW_LIB)] private static extern nint glfwGetWindowUserPointer(nint window);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowposfun glfwSetWindowPosCallback(nint window, GLFWwindowposfun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowsizefun glfwSetWindowSizeCallback(nint window, GLFWwindowsizefun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowclosefun glfwSetWindowCloseCallback(nint window, GLFWwindowclosefun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback(nint window, GLFWwindowrefreshfun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowfocusfun glfwSetWindowFocusCallback(nint window, GLFWwindowfocusfun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback(nint window, GLFWwindowiconifyfun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowmaximizefun glfwSetWindowMaximizeCallback(nint window, GLFWwindowmaximizefun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback(nint window, GLFWframebuffersizefun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWwindowcontentscalefun glfwSetWindowContentScaleCallback(nint window, GLFWwindowcontentscalefun callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSwapBuffers(nint window);
	[DllImport(GLFW_LIB)] private static extern void glfwMakeContextCurrent(nint window);
	[DllImport(GLFW_LIB)] private static extern int glfwGetInputMode(nint window, InputMode mode);
	[DllImport(GLFW_LIB)] private static extern void glfwSetInputMode(nint window, InputMode mode, int value);
	[DllImport(GLFW_LIB)] private static extern bool glfwGetKey(nint window, KeyCode key);
	[DllImport(GLFW_LIB)] private static extern bool glfwGetMouseButton(nint window, KeyCode button);
	[DllImport(GLFW_LIB)] private static extern void glfwGetCursorPos(nint window, out double xpos, out double ypos);
	[DllImport(GLFW_LIB)] private static extern void glfwSetCursorPos(nint window, double xpos, double ypos);
	[DllImport(GLFW_LIB)] private static extern void glfwSetCursor(nint window, nint cursor);
	[DllImport(GLFW_LIB)] private static extern void glfwSetKeyCallback(nint window, KeyCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetCharCallback(nint window, CharCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetMouseButtonCallback(nint window, MouseButtonCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetCursorPosCallback(nint window, CursorPositionCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetCursorEnterCallback(nint window, CursorEnterCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetScrollCallback(nint window, ScrollCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetDropCallback(nint window, DropCallback callback);
	[DllImport(GLFW_LIB)] private static extern void glfwSetClipboardString(nint window, string str);
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetClipboardString(nint window);
}

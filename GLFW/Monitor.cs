using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public sealed class Monitor 
{
	private nint handle;

	public string Name => glfwGetMonitorName(this);

	public (int, int) Position 
	{
		get 
		{
			glfwGetMonitorPos(this, out int x, out int y);
			return (x, y);
		}
	}

	public (int, int) PhysicalSize 
	{
		get 
		{
			glfwGetMonitorPhysicalSize(this, out int x, out int y);
			return (x, y);
		}
	}

	public (float, float) ContentScale 
	{
		get 
		{
			glfwGetMonitorContentScale(this, out float x, out float y);
			return (x, y);
		}
	}

	public (int, int, int, int) WorkArea 
	{
		get 
		{
			glfwGetMonitorWorkarea(this, out int x, out int y, out int width, out int height);
			return (x, y, width, height);
		}
	}

	public nint UserPointer 
	{
		set => glfwSetMonitorUserPointer(this, value);
		get => glfwGetMonitorUserPointer(this);
	}

	public static Monitor PrimaryMonitor => glfwGetPrimaryMonitor();

	public static IEnumerable<Monitor> GetMonitors() 
	{
		nint pointer = glfwGetMonitors(out int count);

		for (int i = 0; i < count; i++)
			yield return GLFW.PointerIndexer<nint>(pointer, i);
	}

	public override string ToString() => this.Name;

	public static implicit operator nint(Monitor? x) => (x != null) ? x.handle : nint.Zero;
	public static implicit operator Monitor(nint x) => new Monitor(x);
	private Monitor(nint handle) => this.handle = handle;

	[DllImport(GLFW_LIB)] private static extern nint glfwGetMonitors(out int count);
	[DllImport(GLFW_LIB)] private static extern nint glfwGetPrimaryMonitor();
	[DllImport(GLFW_LIB)] private static extern void glfwGetMonitorPos(nint monitor, out int xpos, out int ypos);
	[DllImport(GLFW_LIB)] private static extern void glfwGetMonitorWorkarea(nint monitor, out int xpos, out int ypos, out int width, out int height);
	[DllImport(GLFW_LIB)] private static extern void glfwGetMonitorPhysicalSize(nint monitor, out int widthMM, out int heightMM);
	[DllImport(GLFW_LIB)] private static extern void glfwGetMonitorContentScale(nint monitor, out float xscale, out float yscale);
	[DllImport(GLFW_LIB)] private static extern string glfwGetMonitorName(nint monitor);
	[DllImport(GLFW_LIB)] private static extern void glfwSetMonitorUserPointer(nint monitor, nint pointer);
	[DllImport(GLFW_LIB)] private static extern nint glfwGetMonitorUserPointer(nint monitor);
	// [DllImport(GLFW_LIB)] private static extern GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun callback);
	// [DllImport(GLFW_LIB)] private static extern GLFWvidmode* glfwGetVideoModes(nint monitor, out int count);
	// [DllImport(GLFW_LIB)] private static extern GLFWvidmode* glfwGetVideoMode(nint monitor);
	// [DllImport(GLFW_LIB)] private static extern void glfwSetGamma(nint monitor, float gamma);
	// [DllImport(GLFW_LIB)] private static extern GLFWgammaramp* glfwGetGammaRamp(nint monitor);
	// [DllImport(GLFW_LIB)] private static extern void glfwSetGammaRamp(nint monitor, GLFWgammaramp *ramp);
}

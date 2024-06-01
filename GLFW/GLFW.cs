using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public static class GLFW 
{
	public static bool IsInitialized => glfwInit();
	public static unsafe string Version => new string(glfwGetVersionString());
	public static Platform Platform => glfwGetPlatform();

	// separate in GLFW in OpenGl.GLFW ???
	public static ErrorHandlerDelegate ErrorHandler 
	{
		set => glfwSetErrorCallback(value);
	}

	public static void Terminate() => glfwTerminate();
	public static void InitializeHint(int hint, int value) => glfwInitHint(hint, value);
	public static void GetVersion(out int major, out int minor, out int revision) => glfwGetVersion(out major, out minor, out revision);
	public static bool IsSupported(Platform platform) => glfwPlatformSupported(platform);

	#pragma warning disable CS8500
	internal static unsafe T PointerIndexer<T>(nint pointer, int index) => ((T*)pointer)[index];
	#pragma warning restore

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ErrorHandlerDelegate(int code, string description);

	[DllImport(GLFW_LIB)] private static extern bool glfwInit();
	[DllImport(GLFW_LIB)] private static extern void glfwTerminate();
	[DllImport(GLFW_LIB)] private static extern void glfwInitHint(int hint, int value);
	// [DllImport(GLFW_LIB)] private static extern void glfwInitAllocator(GLFWallocator* allocator);
	// [DllImport(GLFW_LIB)] private static extern void glfwInitVulkanLoader(PFN_vkGetInstanceProcAddr loader);
	[DllImport(GLFW_LIB)] private static extern void glfwGetVersion(out int major, out int minor, out int rev);
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetVersionString();
	[DllImport(GLFW_LIB)] private static extern void glfwSetErrorCallback(ErrorHandlerDelegate callback);
	[DllImport(GLFW_LIB)] private static extern Platform glfwGetPlatform();
	[DllImport(GLFW_LIB)] private static extern bool glfwPlatformSupported(Platform platform);
}

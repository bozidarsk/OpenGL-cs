using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using static OpenGL.GLFW.Constants;

namespace OpenGL.GLFW;

public static class GLFW 
{
	public static bool IsInitialized => glfwInit();
	public static unsafe string Version => new string(glfwGetVersionString());
	public static Platform Platform => glfwGetPlatform();

	public static event ErrorEventHandler? OnError;

	public static void Terminate() => glfwTerminate();
	public static void InitializeHint(int hint, int value) => glfwInitHint(hint, value);
	public static void GetVersion(out int major, out int minor, out int revision) => glfwGetVersion(out major, out minor, out revision);
	public static bool IsSupported(Platform platform) => glfwPlatformSupported(platform);

	#pragma warning disable CS8500
	internal static unsafe T PointerIndexer<T>(nint pointer, int index) => ((T*)pointer)[index];
	#pragma warning restore

	static unsafe GLFW() 
	{
		glfwSetErrorCallback((code, message) => OnError?.Invoke(null, new(code, new string(message))));
	}

	[DllImport(GLFW_LIB)] private static extern bool glfwInit();
	[DllImport(GLFW_LIB)] private static extern void glfwTerminate();
	[DllImport(GLFW_LIB)] private static extern void glfwInitHint(int hint, int value);
	// [DllImport(GLFW_LIB)] private static extern void glfwInitAllocator(GLFWallocator* allocator);
	// [DllImport(GLFW_LIB)] private static extern void glfwInitVulkanLoader(PFN_vkGetInstanceProcAddr loader);
	[DllImport(GLFW_LIB)] private static extern void glfwGetVersion(out int major, out int minor, out int rev);
	[DllImport(GLFW_LIB)] private static extern unsafe sbyte* glfwGetVersionString();
	[DllImport(GLFW_LIB)] private static extern unsafe void glfwSetErrorCallback(ErrorCallback callback);
	[DllImport(GLFW_LIB)] private static extern Platform glfwGetPlatform();
	[DllImport(GLFW_LIB)] private static extern bool glfwPlatformSupported(Platform platform);
}

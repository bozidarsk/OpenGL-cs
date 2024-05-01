using System.Runtime.InteropServices;

namespace OpenGL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void ErrorHandler(int code, string description);

public static class GLFW 
{
	public static bool IsInitialized => glfwInit();
	public static string Version => glfwGetVersionString();
	public static Platform Platform => glfwGetPlatform();

	public static ErrorHandler ErrorHandler 
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

	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwInit();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwTerminate();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwInitHint(int hint, int value);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwInitAllocator(GLFWallocator* allocator);
	// [DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwInitVulkanLoader(PFN_vkGetInstanceProcAddr loader);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwGetVersion(out int major, out int minor, out int rev);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern string glfwGetVersionString();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern int glfwGetError(out string description);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern void glfwSetErrorCallback(ErrorHandler callback);
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern Platform glfwGetPlatform();
	[DllImport("glfw3", CharSet = CharSet.Ansi)] private static extern bool glfwPlatformSupported(Platform platform);
}

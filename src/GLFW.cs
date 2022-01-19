#nullable enable

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GLCs
{
    using GLFWwindow = IntPtr;
    using GLFWmonitor = IntPtr;
    using GLFWcursor = IntPtr;
    using VkInstance = IntPtr;
    using IntPtr = IntPtr;

    public static class GLFW
    {
        #region Constants

        public const int VERSION_MAJOR = 3,
            VERSION_MINOR = 3,
            VERSION_REVISION = 6;
        public const int TRUE = 1,
            FALSE = 0;
        public const int RELEASE = 0,
            PRESS = 1,
            REPEAT = 2;
        public const int HAT_CENTERED = 0,
            HAT_UP = 1,
            HAT_RIGHT = 2,
            HAT_DOWN = 4,
            HAT_LEFT = 8,
            HAT_RIGHT_UP = (HAT_RIGHT | HAT_UP),
            HAT_RIGHT_DOWN = (HAT_RIGHT | HAT_DOWN),
            HAT_LEFT_UP = (HAT_LEFT | HAT_UP),
            HAT_LEFT_DOWN = (HAT_LEFT | HAT_DOWN);
        public const int KEY_UNKNOWN = -1;
        public const int KEY_SPACE = 32,
            KEY_APOSTROPHE = 39, /* ' */
            KEY_COMMA = 44, /* , */
            KEY_MINUS = 45, /* - */
            KEY_PERIOD = 46, /* . */
            KEY_SLASH = 47, /* / */
            KEY_0 = 48,
            KEY_1 = 49,
            KEY_2 = 50,
            KEY_3 = 51,
            KEY_4 = 52,
            KEY_5 = 53,
            KEY_6 = 54,
            KEY_7 = 55,
            KEY_8 = 56,
            KEY_9 = 57,
            KEY_SEMICOLON = 59, /* ; */
            KEY_EQUAL = 61, /* = */
            KEY_A = 65,
            KEY_B = 66,
            KEY_C = 67,
            KEY_D = 68,
            KEY_E = 69,
            KEY_F = 70,
            KEY_G = 71,
            KEY_H = 72,
            KEY_I = 73,
            KEY_J = 74,
            KEY_K = 75,
            KEY_L = 76,
            KEY_M = 77,
            KEY_N = 78,
            KEY_O = 79,
            KEY_P = 80,
            KEY_Q = 81,
            KEY_R = 82,
            KEY_S = 83,
            KEY_T = 84,
            KEY_U = 85,
            KEY_V = 86,
            KEY_W = 87,
            KEY_X = 88,
            KEY_Y = 89,
            KEY_Z = 90,
            KEY_LEFT_BRACKET = 91, /* [ */
            KEY_BACKSLASH = 92, /* \ */
            KEY_RIGHT_BRACKET = 93, /* ] */
            KEY_GRAVE_ACCENT = 96, /* ` */
            KEY_WORLD_1 = 161, /* non-US #1 */
            KEY_WORLD_2 = 162; /* non-US #2 */
        public const int KEY_ESCAPE = 256,
            KEY_ENTER = 257,
            KEY_TAB = 258,
            KEY_BACKSPACE = 259,
            KEY_INSERT = 260,
            KEY_DELETE = 261,
            KEY_RIGHT = 262,
            KEY_LEFT = 263,
            KEY_DOWN = 264,
            KEY_UP = 265,
            KEY_PAGE_UP = 266,
            KEY_PAGE_DOWN = 267,
            KEY_HOME = 268,
            KEY_END = 269,
            KEY_CAPS_LOCK = 280,
            KEY_SCROLL_LOCK = 281,
            KEY_NUM_LOCK = 282,
            KEY_PRINT_SCREEN = 283,
            KEY_PAUSE = 284,
            KEY_F1 = 290,
            KEY_F2 = 291,
            KEY_F3 = 292,
            KEY_F4 = 293,
            KEY_F5 = 294,
            KEY_F6 = 295,
            KEY_F7 = 296,
            KEY_F8 = 297,
            KEY_F9 = 298,
            KEY_F10 = 299,
            KEY_F11 = 300,
            KEY_F12 = 301,
            KEY_F13 = 302,
            KEY_F14 = 303,
            KEY_F15 = 304,
            KEY_F16 = 305,
            KEY_F17 = 306,
            KEY_F18 = 307,
            KEY_F19 = 308,
            KEY_F20 = 309,
            KEY_F21 = 310,
            KEY_F22 = 311,
            KEY_F23 = 312,
            KEY_F24 = 313,
            KEY_F25 = 314,
            KEY_KP_0 = 320,
            KEY_KP_1 = 321,
            KEY_KP_2 = 322,
            KEY_KP_3 = 323,
            KEY_KP_4 = 324,
            KEY_KP_5 = 325,
            KEY_KP_6 = 326,
            KEY_KP_7 = 327,
            KEY_KP_8 = 328,
            KEY_KP_9 = 329,
            KEY_KP_DECIMAL = 330,
            KEY_KP_DIVIDE = 331,
            KEY_KP_MULTIPLY = 332,
            KEY_KP_SUBTRACT = 333,
            KEY_KP_ADD = 334,
            KEY_KP_ENTER = 335,
            KEY_KP_EQUAL = 336,
            KEY_LEFT_SHIFT = 340,
            KEY_LEFT_CONTROL = 341,
            KEY_LEFT_ALT = 342,
            KEY_LEFT_SUPER = 343,
            KEY_RIGHT_SHIFT = 344,
            KEY_RIGHT_CONTROL = 345,
            KEY_RIGHT_ALT = 346,
            KEY_RIGHT_SUPER = 347,
            KEY_MENU = 348,
            KEY_LAST = KEY_MENU;
        public const int MOD_SHIFT = 0x0001,
            MOD_CONTROL = 0x0002,
            MOD_ALT = 0x0004,
            MOD_SUPER = 0x0008,
            MOD_CAPS_LOCK = 0x0010,
            MOD_NUM_LOCK = 0x0020;
        public const int MOUSE_BUTTON_1 = 0,
            MOUSE_BUTTON_2 = 1,
            MOUSE_BUTTON_3 = 2,
            MOUSE_BUTTON_4 = 3,
            MOUSE_BUTTON_5 = 4,
            MOUSE_BUTTON_6 = 5,
            MOUSE_BUTTON_7 = 6,
            MOUSE_BUTTON_8 = 7,
            MOUSE_BUTTON_LAST = MOUSE_BUTTON_8,
            MOUSE_BUTTON_LEFT = MOUSE_BUTTON_1,
            MOUSE_BUTTON_RIGHT = MOUSE_BUTTON_2,
            MOUSE_BUTTON_MIDDLE = MOUSE_BUTTON_3;
        public const int JOYSTICK_1 = 0,
            JOYSTICK_2 = 1,
            JOYSTICK_3 = 2,
            JOYSTICK_4 = 3,
            JOYSTICK_5 = 4,
            JOYSTICK_6 = 5,
            JOYSTICK_7 = 6,
            JOYSTICK_8 = 7,
            JOYSTICK_9 = 8,
            JOYSTICK_10 = 9,
            JOYSTICK_11 = 10,
            JOYSTICK_12 = 11,
            JOYSTICK_13 = 12,
            JOYSTICK_14 = 13,
            JOYSTICK_15 = 14,
            JOYSTICK_16 = 15,
            JOYSTICK_LAST = JOYSTICK_16;
        public const int GAMEPAD_BUTTON_A = 0,
            GAMEPAD_BUTTON_B = 1,
            GAMEPAD_BUTTON_X = 2,
            GAMEPAD_BUTTON_Y = 3,
            GAMEPAD_BUTTON_LEFT_BUMPER = 4,
            GAMEPAD_BUTTON_RIGHT_BUMPER = 5,
            GAMEPAD_BUTTON_BACK = 6,
            GAMEPAD_BUTTON_START = 7,
            GAMEPAD_BUTTON_GUIDE = 8,
            GAMEPAD_BUTTON_LEFT_THUMB = 9,
            GAMEPAD_BUTTON_RIGHT_THUMB = 10,
            GAMEPAD_BUTTON_DPAD_UP = 11,
            GAMEPAD_BUTTON_DPAD_RIGHT = 12,
            GAMEPAD_BUTTON_DPAD_DOWN = 13,
            GAMEPAD_BUTTON_DPAD_LEFT = 14,
            GAMEPAD_BUTTON_LAST = GAMEPAD_BUTTON_DPAD_LEFT,
            GAMEPAD_BUTTON_CROSS = GAMEPAD_BUTTON_A,
            GAMEPAD_BUTTON_CIRCLE = GAMEPAD_BUTTON_B,
            GAMEPAD_BUTTON_SQUARE = GAMEPAD_BUTTON_X,
            GAMEPAD_BUTTON_TRIANGLE = GAMEPAD_BUTTON_Y;
        public const int GAMEPAD_AXIS_LEFT_X = 0,
            GAMEPAD_AXIS_LEFT_Y = 1,
            GAMEPAD_AXIS_RIGHT_X = 2,
            GAMEPAD_AXIS_RIGHT_Y = 3,
            GAMEPAD_AXIS_LEFT_TRIGGER = 4,
            GAMEPAD_AXIS_RIGHT_TRIGGER = 5,
            GAMEPAD_AXIS_LAST = GAMEPAD_AXIS_RIGHT_TRIGGER;
        public const int NO_ERROR = 0,
            NOT_INITIALIZED = 0x00010001,
            NO_CURRENT_CONTEXT = 0x00010002,
            INVALID_ENUM = 0x00010003;
        /// <summary>
        /// One of the arguments to the function was an invalid value.
        /// <para>
        /// One of the arguments to the function was an invalid value, for example
        /// requesting a non-existent OpenGL or OpenGL ES version like 2.7.
        /// </para><para>
        /// Requesting a valid but unavailable OpenGL or OpenGL ES version will instead
        /// result in a <see cref="VERSION_UNAVAILABLE"/> error.
        /// </para>
        /// <remark>
        /// <b>Analysis: </b> Application programmer error.  Fix the offending call.
        /// </remark>
        /// </summary>
        public const int INVALID_VALUE = 0x00010004;
        public const int OUT_OF_MEMORY = 0x00010005,
            API_UNAVAILABLE = 0x00010006,
            VERSION_UNAVAILABLE = 0x00010007,
            PLATFORM_ERROR = 0x00010008,
            FORMAT_UNAVAILABLE = 0x00010009,
            NO_WINDOW_CONTEXT = 0x0001000A;
        public const int FOCUSED = 0x00020001,
            ICONIFIED = 0x00020002,
            RESIZABLE = 0x00020003,
            VISIBLE = 0x00020004,
            DECORATED = 0x00020005,
            AUTO_ICONIFY = 0x00020006,
            FLOATING = 0x00020007,
            MAXIMIZED = 0x00020008,
            CENTER_CURSOR = 0x00020009,
            TRANSPARENT_FRAMEBUFFER = 0x0002000A,
            HOVERED = 0x0002000B,
            FOCUS_ON_SHOW = 0x0002000C,
            RED_BITS = 0x00021001,
            GREEN_BITS = 0x00021002,
            BLUE_BITS = 0x00021003,
            ALPHA_BITS = 0x00021004,
            DEPTH_BITS = 0x00021005,
            STENCIL_BITS = 0x00021006,
            ACCUM_RED_BITS = 0x00021007,
            ACCUM_GREEN_BITS = 0x00021008,
            ACCUM_BLUE_BITS = 0x00021009,
            ACCUM_ALPHA_BITS = 0x0002100A,
            AUX_BUFFERS = 0x0002100B,
            STEREO = 0x0002100C,
            SAMPLES = 0x0002100D,
            SRGB_CAPABLE = 0x0002100E,
            REFRESH_RATE = 0x0002100F,
            DOUBLEBUFFER = 0x00021010,
            CLIENT_API = 0x00022001,
            CONTEXT_VERSION_MAJOR = 0x00022002,
            CONTEXT_VERSION_MINOR = 0x00022003,
            CONTEXT_VERSION_REVISION = 0x00022004,
            CONTEXT_ROBUSTNESS = 0x00022005,
            OPENGL_FORWARD_COMPAT = 0x00022006,
            OPENGL_DEBUG_CONTEXT = 0x00022007,
            OPENGL_PROFILE = 0x00022008,
            CONTEXT_RELEASE_BEHAVIOR = 0x00022009,
            CONTEXT_NO_ERROR = 0x0002200A,
            CONTEXT_CREATION_API = 0x0002200B,
            SCALE_TO_MONITOR = 0x0002200C,
            COCOA_RETINA_FRAMEBUFFER = 0x00023001,
            COCOA_FRAME_NAME = 0x00023002,
            COCOA_GRAPHICS_SWITCHING = 0x00023003,
            X11_CLASS_NAME = 0x00024001,
            X11_INSTANCE_NAME = 0x00024002;
        public const int NO_API = 0,
            OPENGL_API = 0x00030001,
            OPENGL_ES_API = 0x00030002,
            NO_ROBUSTNESS = 0,
            NO_RESET_NOTIFICATION = 0x00031001,
            LOSE_CONTEXT_ON_CLOSE = 0x00031002,
            OPENGL_ANY_PROFILE = 0,
            OPENGL_CORE_PROFILE = 0x00032001,
            OPENGL_COMPAT_PROFILE = 0x00032002,
            CURSOR = 0x00033001,
            STICKY_KEYS = 0x00033002,
            STICKY_MOUSE_BUTTONS = 0x00033003,
            LOCK_KEY_MODS = 0x00033004,
            RAW_MOUSE_MOTION = 0x00033005,
            CURSOR_NORMAL = 0x00034001,
            GLFW_CURSOR_HIDDEN = 0x00034002,
            GLFW_CURSOR_DISABLED = 0x00034003,
            GLFW_ANY_RELEASE_BEHAVIOR = 0,
            GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001,
            GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002,
            GLFW_NATIVE_CONTEXT_API = 0x00036001,
            GLFW_EGL_CONTEXT_API = 0x00036002,
            GLFW_OSMESA_CONTEXT_API = 0x00036003;
        public const int ARROW_CURSOR = 0x00036001,
            IBEAN_CURSOR = 0x00036002,
            CROSSHAIR_CURSOR = 0x00036003,
            HAND_CURSOR = 0x00036004,
            HRESIZE_CURSOR = 0x00036005,
            VRESIZE_CURSOR = 0x00036006;
        public const int CONNECTED = 0x00040001,
            GLFW_DISCONNECTED = 0x00040002;
        public const int JOYSTICK_HAT_BUTTONS = 0x00050001,
            COCOA_CHDIR_RESOURCES = 0x00051001,
            COCOA_MENUBAR = 0x00051002;
        public const int DONT_CARE = -1;

        #endregion // Constants
        #region Delegates

        public delegate void GlProc();
        public delegate void VkProc();
        public delegate void ErrorFun(int errorCode, string description);
        public delegate void WindowPosFun(GLFWwindow window, int xPos, int yPos);
        public delegate void WindowSizeFun(GLFWwindow window, int width, int height);
        public delegate void WindowCloseFun(GLFWwindow window);
        public delegate void WindowRefreshFun(GLFWwindow window);
        public delegate void WindowFocusFun(GLFWwindow window, int focused);
        public delegate void WindowIconifyFun(GLFWwindow window, int iconified);
        public delegate void WindowMaximizeFun(GLFWwindow window, int iconified);
        public delegate void FramebufferSizeFun(GLFWwindow window, int width, int height);
        public delegate void WindowContentScaleFun(GLFWwindow window, float xScale, float yScale);
        public delegate void MouseButtonFun(GLFWwindow window, int button, int action, int mods);
        public delegate void CursorPosFun(GLFWwindow window, double xPos, double yPos);
        public delegate void CursorEnterFun(GLFWwindow window, int entered);
        public delegate void ScrollFun(GLFWwindow window, double xOffset, double yOffset);
        public delegate void KeyFun(GLFWwindow window, int key, int scancode, int action, int mods);
        public delegate void CharFun(GLFWwindow window, uint codepoint);
        public delegate void CharModsFun(GLFWwindow window, uint codepoint, int mods);
        public delegate void DropFun(GLFWwindow window, int pathCount, string[] paths);
        public delegate void MonitorFun(GLFWmonitor monitor, int @event);
        public delegate void JoystickFun(int jid, int @event);

        #endregion // Delegates
        #region Structs

        public struct VidMode
        {
            public int width;
            public int height;
            public int redBits;
            public int greenBits;
            public int blueBits;
            public int refreshRate;
        }
        public struct GammaRamp
        {
            public ushort[] red;
            public ushort[] green;
            public ushort[] blue;
            public uint size;
        }
        public struct Image
        {
            public int width;
            public int height;
            public byte[] pixels;
        }
        public unsafe struct GamepadState
        {
            public fixed byte buttons[15];
            public fixed float axes[6];
        }

        #endregion // Structs
        #region Core

        [DllImport("glfw3.dll", EntryPoint = "glfwInit")]
        private static extern int GlfwInit();
        /// <summary>
        /// Initializes the GLFW library.
        /// <para>
        /// This function initializes the GLFW library.  Before most GLFW functions can
        /// be used, GLFW must be initialized, and before an application terminates GLFW
        /// should be terminated in order to free any resources allocated during or
        /// after initialization.
        /// </para><para>
        /// If this function fails, it calls <see cref="Terminate"/> before returning.
        /// If it succeeds, you should call <see cref="Terminate"/> before the
        /// application exits.
        /// </para><para>
        /// Additional calls to this function after successful initialization but before
        /// termination will return <c>true</c> immediately.
        /// </para></summary>
        /// <returns><c>true</c> if successful, or <c>false</c> if an
        /// <a href="https://www.glfw.org/docs/latest/intro_guide.html#error_handling">error</a>
        /// occurred.</returns>
        /// <exception cref='PLATFORM_ERROR'/>
        /// <remarks>
        /// <para><b>macOS: </b>This function will change the current directory of the
        /// application to the <c>Contents/Resources</c> subdirectory of the application's
        /// bundle, if present.  This can be disabled with the
        /// <see cref="COCOA_CHDIR_RESOURCES"/> init hint.</para>
        /// <para><b>X11: </b>This function will set the <c>LC_CTYPE</c> category of the
        /// application locale according to the current environment if that category is
        /// still "C".  This is because the "C" locale breaks Unicode text input.</para>
        /// <para>This function must only be called from the main thread.</para>
        /// <para>See also
        /// <br/>
        /// <ul>
        /// <li>
        ///   <a href="https://www.glfw.org/docs/latest/intro_guide.html#intro_init">
        ///   Initialization and termination</a><br/>
        /// </li>
        /// <li><seealso cref="Terminate"/></li>
        /// </ul>
        /// </para>
        /// </remarks>
        public static bool Init()
        {
            return GlfwInit() == TRUE;
        }
        /// <summary>
        /// Terminates the GLFW library.
        /// <para>
        /// This function destroys all remaining windows and cursors, restores any
        /// modified gamma ramps and frees any other allocated resources.  Once this
        /// function is called, you must again call <see cref="Init"/> successfully before
        /// you will be able to use most GLFW functions.
        /// </para><para>
        /// If GLFW has been successfully initialized, this function should be called
        /// before the application exits.  If initialization fails, there is no need to
        /// call this function, as it is called by @ref glfwInit before it returns
        /// failure.
        /// </para><para>
        /// This function has no effect if GLFW is not initialized.
        /// </para>
        /// </summary>
        /// <exception cref="PLATFORM_ERROR"/>
        /// <remarks>
        /// This function may be called before <see cref="Init"/>.
        /// <para>
        /// The contexts of any remaining windows must not be current on any other thread when this function is called.
        /// </para><para>
        /// This function must not be called from a callback.
        /// </para><para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>See also
        /// <br/>
        /// <ul>
        /// <li>
        ///   <a href="https://www.glfw.org/docs/latest/intro_guide.html#intro_init">
        ///   Initialization and termination</a><br/>
        /// </li>
        /// <li><seealso cref="Init"/></li>
        /// </ul>
        /// </para>
        /// </remarks>
        [DllImport("glfw3.dll", EntryPoint = "glfwTerminate")]
        public static extern void Terminate();
        /// <summary>
        /// Sets the specified init hint to the desired value.
        /// <para>
        /// This function sets hints for the next initialization of GLFW.
        /// </para><para>
        /// The values you set hints to are never reset by GLFW, but they only take
        /// effect during initialization.  Once GLFW has been initialized, any values
        /// you set will be ignored until the library is terminated and initialized
        /// again.
        /// </para><para>
        /// Some hints are platform specific.  These may be set on any platform but they
        /// will only affect their specific platform.  Other platforms will ignore them.
        /// Setting these hints requires no platform specific headers or functions.
        /// </para>
        /// </summary>
        /// <param name="hint">The <a href="https://www.glfw.org/docs/latest/intro_guide.html#init_hints">
        /// init hint</a> to set.</param>
        /// <param name="value">The new value of the init hint.</param>
        /// <exception cref="INVALID_ENUM"/>
        /// <exception cref="INVALID_VALUE"/>
        /// <remarks>
        /// This function may be called before <see cref="Init"/>.
        /// <para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>See also
        /// <br/>
        /// <ul>
        /// <li>
        ///   <a href="https://www.glfw.org/docs/latest/intro_guide.html#init_hints">
        ///   Initialization hints</a><br/>
        /// </li>
        /// <li><seealso cref="Init"/></li>
        /// </ul>
        /// </para>
        /// </remarks>
        [DllImport("glfw3.dll", EntryPoint = "glfwInitHint")]
        public static extern void InitHint(int hint, int value);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetVersion")]
        public static extern void GetVersion(int[]? major, int[]? minor, int[]? rev);
        public static void GetVersion(ref int major, ref int minor, ref int rev)
        {
            int[] ma = { 0 }, mi = { 0 }, re = { 0 };
            GetVersion(ma, mi, re);
            major = ma[0];
            minor = mi[0];
            rev = re[0];
        }
        public static int[] GetVersion()
        {
            int major = 0, minor = 0, rev = 0;
            GetVersion(ref major, ref minor, ref rev);
            return new int[] { major, minor, rev };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetVersionString")]
        public static extern string[] GetVersionString();
        [DllImport("glfw3.dll", EntryPoint = "glfwGetError")]
        public static extern int GetError([Nullable] ref string description);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetErrorCallback"), Nullable]
        public static extern ErrorFun SetErrorCallback([Nullable] ErrorFun callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitors"), Nullable]
        public static extern GLFWmonitor[] GetMonitors(IntPtr count);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetPrimaryMonitor"), Nullable]
        public static extern GLFWmonitor GetPrimaryMonitor();
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitorPos")]
        public static extern void GetMonitorPos(GLFWmonitor monitor, ref int? xPos, ref int? yPos);
        public static int[] GetMonitorPos(GLFWmonitor monitor)
        {
            int? xPos = 0, yPos = 0;
            GetMonitorPos(monitor, ref xPos, ref yPos);
            return new int[] { xPos ?? 0, yPos ?? 0 };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitorWorkarea")]
        public static extern void GetMonitorWorkarea(GLFWmonitor monitor, ref int? xPos, ref int? yPos, ref int? width, ref int? height);
        public static int[] GetMonitorWorkarea(GLFWmonitor monitor)
        {
            int? xPos = 0, yPos = 0, width = 0, height = 0;
            GetMonitorWorkarea(monitor, ref xPos, ref yPos, ref width, ref height);
            return new int[] { xPos ?? 0, yPos ?? 0, width ?? 0, height ?? 0 };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static extern void GetMonitorPhysicalSize(GLFWmonitor monitor, ref int? widthMM, ref int? heightMM);
        public static int[] GetMonitorPhysicalSize(GLFWmonitor monitor)
        {
            int? widthMM = 0, heightMM = 0;
            GetMonitorPhysicalSize(monitor, ref widthMM, ref heightMM);
            return new int[] { widthMM ?? 0, heightMM ?? 0 };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitorContentScale")]
        public static extern void GetMonitorContentScale(GLFWmonitor monitor, ref float? xScale, ref float? yScale);
        public static float[] GetMonitorContentScale(GLFWmonitor monitor)
        {
            float? xScale = 0, yScale = 0;
            GetMonitorContentScale(monitor, ref xScale, ref yScale);
            return new float[] { xScale ?? 0, yScale ?? 0 };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitorName"), Nullable]
        public static extern byte[] GetMonitorName(GLFWmonitor monitor);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetMonitorUserPointer")]
        public static extern void SetMonitorUserPointer(GLFWmonitor monitor, IntPtr pointer);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMonitorUserPointer")]
        public static extern IntPtr GetMonitorUserPointer(GLFWmonitor monitor);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetMonitorCallback"), Nullable]
        public static extern MonitorFun SetMonitorCallback([Nullable] MonitorFun monitor);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetVideoModes"), Nullable]
        public static extern IntPtr GetVideoModes(GLFWmonitor monitor, ref int count);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetVideoMode"), Nullable]
        private static extern IntPtr GlfwGetVideoMode(GLFWmonitor monitor);
        public static VidMode? GetVideoMode(GLFWmonitor monitor)
        {
            IntPtr ptr = GlfwGetVideoMode(monitor);
            if (ptr == IntPtr.Zero) return null;
            unsafe
            {
                return *(VidMode*)ptr.ToPointer();
            }
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetGamma")]
        public static extern void SetGamma(GLFWmonitor monitor, float gamma);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetGammaRamp"), Nullable]
        public static extern GammaRamp[] GetGammaRamp(GLFWmonitor monitor);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetGammaRamp")]
        public static extern void SetGammaRamp(GLFWmonitor monitor, GammaRamp[] ramp);
        [DllImport("glfw3.dll", EntryPoint = "glfwDefaultWindowHints")]
        public static extern void DefaultWindowHints();
        [DllImport("glfw3.dll", EntryPoint = "glfwWindowHint")]
        public static extern void WindowHint(int hint, int value);
        [DllImport("glfw3.dll", EntryPoint = "glfwWindowHintString")]
        public static extern void WindowHintString(int hint, string value);
        [DllImport("glfw3.dll", EntryPoint = "glfwCreateWindow")]
        public static extern GLFWwindow CreateWindow(int width, int height, string title, [Nullable] GLFWmonitor monitor, [Nullable] GLFWwindow share);
        [DllImport("glfw3.dll", EntryPoint = "glfwDestroyWindow")]
        public static extern void DestroyWindow(GLFWwindow window);
        [DllImport("glfw3.dll")]
        public static extern int glfwWindowShouldClose(GLFWwindow window);
        public static bool WindowShouldClose(GLFWwindow window)
        {
            return glfwWindowShouldClose(window) == TRUE;
        }
        [DllImport("glfw3.dll")]
        public static extern void glfwSetWindowShouldClose(GLFWwindow window, int value);
        public static void SetWindowShouldClose(GLFWwindow window, bool value)
        {
            glfwSetWindowShouldClose(window, value ? TRUE : FALSE);
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowTitle")]
        public static extern void SetWindowTitle(GLFWwindow window, string title);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowIcon")]
        public static extern void SetWindowIcon(GLFWwindow window, int count, Image[] images);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowPos")]
        public static extern void GetWindowPos(GLFWwindow window, int[]? xPos, int[]? yPos);
        public static void GetWindowPos(GLFWwindow window, ref int xPos, ref int yPos)
        {
            int[] x = { 0 }, y = { 0 };
            GetWindowPos(window, x, y);
            xPos = x[0];
            yPos = y[0];
        }
        public static int[] GetWindowPos(GLFWwindow window)
        {
            int x = 0, y = 0;
            GetWindowPos(window, ref x, ref y);
            return new int[] { x, y };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowPos")]
        public static extern void SetWindowPos(GLFWwindow window, int xPos, int yPos);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowSize")]
        public static extern void GetWindowSize(GLFWwindow window, int[]? width, int[]? height);
        public static void GetWindowSize(GLFWwindow window, ref int width, ref int height)
        {
            int[] w = { 0 }, h = { 0 };
            GetWindowSize(window, w, h);
            width = w[0];
            height = h[0];
        }
        public static int[] GetWindowSize(GLFWwindow window)
        {
            int w = 0, h = 0;
            GetWindowSize(window, ref w, ref h);
            return new int[] { w, h };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowSizeLimits")]
        public static extern void SetWindowSizeLimits(GLFWwindow window, int minWidth, int minHeight, int maxWidth, int maxHeight);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowAspectRatio")]
        public static extern void SetWindowAspectRatio(GLFWwindow window, int numer, int denom);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowSize")]
        public static extern void SetWindowSize(GLFWwindow window, int width, int height);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetFramebufferSize")]
        public static extern void GetFramebufferSize(GLFWwindow window, ref int width, ref int height);
        public static int[] GetFramebufferSize(GLFWwindow window)
        {
            int w = 0, h = 0;
            GetFramebufferSize(window, ref w, ref h);
            return new int[] { w, h };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowFrameSize")]
        public static extern void GetWindowFrameSize(GLFWwindow window, ref int? left, ref int? top, ref int? right, ref int? bottom);
        public static int[] GetWindowFrameSize(GLFWwindow window)
        {
            int? l = 0, t = 0, r = 0, b = 0;
            GetWindowFrameSize(window, ref l, ref t, ref r, ref b);
            return new int[] { l ?? 0, t ?? 0, r ?? 0, b ?? 0 };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowContentScale")]
        public static extern void GetWindowContentScale(GLFWwindow window, ref float? xScale, ref float? yScale);
        public static float[] GetWindowContentScale(GLFWwindow window)
        {
            float? xs = 0, ys = 0;
            GetWindowContentScale(window, ref xs, ref ys);
            return new float[] { xs ?? 0, ys ?? 0 };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowOpacity")]
        public static extern float GetWindowOpacity(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowOpacity")]
        public static extern void SetWindowOpacity(GLFWwindow window, float opacity);
        [DllImport("glfw3.dll", EntryPoint = "glfwIconifyWindow")]
        public static extern void IconifyWindow(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwRestoreWindow")]
        public static extern void RestoreWindow(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwMaximizeWindow")]
        public static extern void MaximizeWindow(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwShowWindow")]
        public static extern void ShowWindow(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwHideWindow")]
        public static extern void HideWindow(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwFocusWindow")]
        public static extern void FocusWindow(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwRequestWindowAttention")]
        public static extern void RequestWindowAttention(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowMonitor"), Nullable]
        public static extern GLFWmonitor GetWindowMonitor(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowMonitor")]
        public static extern void SetWindowMonitor(GLFWwindow window, GLFWmonitor monitor, int xPos, int yPos, int width, int height, int refreshRate);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowAttrib")]
        public static extern int GetWindowAttrib(GLFWwindow window, int attrib);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowAttrib")]
        public static extern void SetWindowAttrib(GLFWwindow window, int attrib, int value);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowUserPointer")]
        public static extern void SetWindowUserPointer(GLFWwindow window, IntPtr pointer);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetWindowUserPointer")]
        public static extern IntPtr GetWindowUserPointer(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowPosCallback")]
        public static extern WindowPosFun? SetWindowPosCallback(GLFWwindow window, WindowPosFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowSizeCallback")]
        public static extern WindowSizeFun? SetWindowSizeCallback(GLFWwindow window, WindowSizeFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowCloseCallback")]
        public static extern WindowCloseFun? SetWindowCloseCallback(GLFWwindow window, WindowCloseFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowRefreshCallback")]
        public static extern WindowRefreshFun? SetWindowRefreshCallback(GLFWwindow window, WindowRefreshFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowFocusCallback")]
        public static extern WindowFocusFun? SetWindowFocusCallback(GLFWwindow window, WindowFocusFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowIconifyCallback")]
        public static extern WindowIconifyFun? SetWindowIconifyCallback(GLFWwindow window, WindowIconifyFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public static extern WindowMaximizeFun? SetWindowMaximizeCallback(GLFWwindow window, WindowMaximizeFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static extern FramebufferSizeFun? SetFramebufferSizeCallback(GLFWwindow window, FramebufferSizeFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public static extern WindowContentScaleFun? SetWindowContentScaleCallback(GLFWwindow window, WindowContentScaleFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwPollEvents")]
        public static extern void PollEvents();
        [DllImport("glfw3.dll", EntryPoint = "glfwWaitEvents")]
        public static extern void WaitEvents();
        [DllImport("glfw3.dll", EntryPoint = "glfwWaitEventsTimeout")]
        public static extern void WaitEventsTimeout(double timeout);
        [DllImport("glfw3.dll", EntryPoint = "glfwPostEmptyEvent")]
        public static extern void PostEmptyEvent();
        [DllImport("glfw3.dll", EntryPoint = "glfwGetInputMode")]
        public static extern int GetInputMode(GLFWwindow window, int mode);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetInputMode")]
        public static extern void SetInputMode(GLFWwindow window, int mode, int value);
        [DllImport("glfw3.dll")]
        public static extern int glfwRawMouseMotionSupported();
        public static bool RawMouseMotionSupported()
        {
            return glfwRawMouseMotionSupported() == TRUE;
        }
        [DllImport("glfw3.dll")]
        public static extern byte[] glfwGetKeyName(int key, int scancode);
        public static string GetKeyName(int key, int scancode)
        {
            return Encoding.UTF8.GetString(glfwGetKeyName(key, scancode));
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetKeyScancode")]
        public static extern int GetKeyScancode(int key);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetKey")]
        public static extern int GetKey(GLFWwindow window, int key);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetMouseButton")]
        public static extern int GetMouseButton(GLFWwindow window, int button);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetCursorPos")]
        public static extern void GetCursorPos(GLFWwindow window, double[]? xPos, double[]? yPos);
        public static void GetCursorPos(GLFWwindow window, ref double xPos, ref double yPos)
        {
            double[] x = { 0 }, y = { 0 };
            GetCursorPos(window, x, y);
            xPos = x[0];
            yPos = y[0];
        }
        public static double[] GetCursorPos(GLFWwindow window)
        {
            double x = 0, y = 0;
            GetCursorPos(window, ref x, ref y);
            return new double[] { x, y };
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetCursorPos")]
        public static extern void SetCursorPos(GLFWwindow window, double xPos, double yPos);
        [DllImport("glfw3.dll", EntryPoint = "glfwCreateCursor"), Nullable]
        public static extern GLFWcursor CreateCursor(Image[] image, int xHot, int yHot);
        [DllImport("glfw3.dll", EntryPoint = "glfwCreateStandardCursor"), Nullable]
        public static extern GLFWcursor CreateStandardCursor(int shape);
        [DllImport("glfw3.dll", EntryPoint = "glfwDestroyCursor")]
        public static extern void DestroyCursor(IntPtr cursor);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetCursor")]
        public static extern void SetCursor(GLFWwindow window, GLFWcursor? cursor);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetKeyCallback")]
        public static extern KeyFun? SetKeyCallback(GLFWwindow window, KeyFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetCharCallback")]
        public static extern CharFun? SetCharCallback(GLFWwindow window, CharFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetCharModsCallback")]
        public static extern CharModsFun? SetCharModsCallback(GLFWwindow window, CharModsFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetMouseButtonCallback")]
        public static extern MouseButtonFun? SetMouseButtonCallback(GLFWwindow window, MouseButtonFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetCursorPosCallback")]
        public static extern CursorPosFun? SetMouseCursorPosCallback(GLFWwindow window, CursorPosFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetCursorEnterCallback")]
        public static extern CursorEnterFun? SetMouseCursorEnterCallback(GLFWwindow window, CursorEnterFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetScrollCallback")]
        public static extern ScrollFun? SetScrollCallback(GLFWwindow window, ScrollFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetDropCallback")]
        public static extern DropFun? SetDropCallback(GLFWwindow window, DropFun? callback);
        [DllImport("glfw3.dll", EntryPoint = "glfwJoystickPresent")]
        public static extern int JoystickPresent(int jid);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetJoystickAxes"), Nullable]
        public static extern float[] GetJoystickAxes(int jid, ref int count);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetJoystickButtons"), Nullable]
        public static extern byte[] GetJoystickButtons(int jid, ref int count);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetJoystickHats"), Nullable]
        public static extern byte[] GetJoystickHats(int jid, ref int count);
        [DllImport("glfw3.dll"), Nullable]
        public static extern byte[] glfwGetJoystickName(int jid);
        public static string GetJoystickName(int jid)
        {
            return Encoding.UTF8.GetString(glfwGetJoystickName(jid));
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetJoystickGUID"), Nullable]
        public static extern string GetJoystickGUID(int jid);
        [DllImport("glfw3.dll", EntryPoint = "glfwSetJoystickUserPointer")]
        public static extern void SetJoystickUserPointer(int jid, IntPtr pointer);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetJoystickUserPointer")]
        public static extern IntPtr GetJoystickUserPointer(int jid);
        [DllImport("glfw3.dll")]
        public static extern int glfwJoystickIsGamepad(int jid);
        public static bool JoystickIsGamepad(int jid)
        {
            return glfwJoystickIsGamepad(jid) == TRUE;
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetJoystickCallback")] public static extern JoystickFun? SetJoystickCallback(IntPtr window, JoystickFun? callback);
        [DllImport("glfw3.dll")]
        public static extern int glfwUpdateGamepadMappings(string @string);
        public static bool UpdateGamepadMappings(string @string)
        {
            return glfwUpdateGamepadMappings(@string) == TRUE;
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetGamepadName")]
        public static extern string GetGamepadName(int jid);
        [DllImport("glfw3.dll")]
        public static extern int glfwGetGamepadState(int jid, IntPtr state);
        public static bool GetGamepadState(int jid, IntPtr state)
        {
            return glfwGetGamepadState(jid, state) == TRUE;
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwSetClipboardString")]
        public static extern void SetClipboardString(GLFWwindow window, string @string);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetClipboardString")]
        public static extern string GetClipboardString(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetTime")]
        public static extern double GetTime();
        [DllImport("glfw3.dll", EntryPoint = "glfwSetTime")]
        public static extern void SetTime(double time);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetTimerValue")]
        public static extern ulong GetTimerValue();
        [DllImport("glfw3.dll", EntryPoint = "glfwGetTimerFrequency")]
        public static extern ulong GetTimerFrequency();
        [DllImport("glfw3.dll", EntryPoint = "glfwMakeContextCurrent")]
        public static extern void MakeContextCurrent(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetCurrentContext")]
        public static extern GLFWwindow GetCurrentContext();
        [DllImport("glfw3.dll", EntryPoint = "glfwSwapBuffers")]
        public static extern void SwapBuffers(GLFWwindow window);
        [DllImport("glfw3.dll", EntryPoint = "glfwSwapInterval")]
        public static extern void SwapInterval(int interval);
        [DllImport("glfw3.dll", EntryPoint = "glfwExtensionSupported")]
        private static extern int GlfwExtensionSupported(string extension);
        public static bool ExtensionSupported(string extension)
        {
            return GlfwExtensionSupported(extension) == TRUE;
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetProcAddress"), Nullable]
        public static extern GlProc GlfwGetProcAddress(string procname);
        public static GlProc GetProcAddress(string procname)
        {
            return GlfwGetProcAddress(procname);
        }
        [DllImport("glfw3.dll")]
        public static extern int glfwVulkanSupported();
        public static bool VulkanSupported()
        {
            return glfwVulkanSupported() == TRUE;
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwGetRequiredInstanceExtensions"), Nullable]
        public static extern string[] GetRequiredInstanceExtensions(ref uint count);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetInstanceProcAddress"), Nullable]
        public static extern VkProc GetInstanceProcAddress(VkInstance vkInstance, byte[] procName);
        [DllImport("glfw3.dll", EntryPoint = "glfwGetInstanceProcAddress"), Nullable]
        public static extern VkProc GetInstanceProcAddress(VkInstance vkInstance, string procName);
        [DllImport("glfw3.dll")]
        public static extern int glfwGetPhysicalDevicePresentationSupport(VkInstance vkInstance, IntPtr device, uint queueFamily);
        public static bool GetPhysicalDevicePresentationSupport(VkInstance vkInstance, VkInstance device, uint queueFamily)
        {
            return glfwGetPhysicalDevicePresentationSupport(vkInstance, device, queueFamily) == TRUE;
        }
        [DllImport("glfw3.dll", EntryPoint = "glfwCreateWindowSurface")]
        public static extern IntPtr CreateWindowSurface(VkInstance vkInstance, GLFWwindow window, [Nullable] IntPtr allocator, IntPtr surface);

        #endregion // Core
        #region Ext

        public delegate void VideoModeLet(VidMode vidMode);
        public static void GetVideoModeLet(IntPtr monitor, VideoModeLet block)
        {
            VidMode? vidMode = GetVideoMode(monitor);
            if (vidMode != null)
            {
                block((VidMode)vidMode);
            }
        }

        #endregion // Ext
    }
}

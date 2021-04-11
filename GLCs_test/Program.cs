using GLCs;
using System;

namespace GLCs_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are using GLCs {0}", GLCS.GetVersionString());
            GLFW.SetErrorCallback((error, description) =>
            {
                Console.WriteLine("########## GL ERROR ##########");
                Console.WriteLine("{0}: {1}", error, description);
            });
            if (!GLFW.Init())
            {
                throw new ContextException("Unable to initialize GLFW");
            }
            GLFW.WindowHint(GLFW.VISIBLE, GLFW.FALSE);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 2);
            IntPtr window = GLFW.CreateWindow(854, 480, "GLC# Test", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                throw new ContextException("Failed to create the window");
            }
            GLFW.SetKeyCallback(window, (window, key, scancode, action, mods) =>
            {
                if (action == GLFW.PRESS && key == GLFW.KEY_ESCAPE)
                {
                    GLFW.SetWindowShouldClose(window, true);
                }
            });
            GLFW.GetVideoModeLet(GLFW.GetPrimaryMonitor(), (vidMode) =>
            {
                int w = 0;
                int h = 0;
                GLFW.GetWindowSize(window, ref w, ref h);
                GLFW.SetWindowPos(
                    window,
                    (vidMode.width - w) / 2,
                    (vidMode.height - h) / 2
                );
            });
            GLFW.MakeContextCurrent(window);
            GLFW.SwapInterval(1);
            GLFW.ShowWindow(window);
            GL.ClearColor(.4f, .6f, .9f, 1);
            GLProgram program = new GLProgram()
                .CreateVsh(@"#version 110
attribute vec3 vert;
attribute vec3 in_color;
varying vec3 out_color;
void main() {
    gl_Position = vec4(vert, 1.0);
    out_color = in_color;
}")
                .CreateFsh(@"#version 110
varying vec3 out_color;
void main() {
    gl_FragColor = vec4(out_color, 1.0);
}")
                .Link();
            float[] vertices =
            {
                0.5f, 0.5f, 0f,
                -0.5f, -0.5f, 0f,
                0.5f, -0.5f, 0f
            };
            float[] colors =
            {
                1, 0, 0,
                0, 1, 0,
                0, 0, 1
            };
            uint vertVbo = GL.GenBuffer();
            uint colorVbo = GL.GenBuffer();
            //fixme: there is not any triangles rendered
            while (!GLFW.WindowShouldClose(window))
            {
                GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
                program.Bind();
                GL.BindBuffer(GL.ARRAY_BUFFER, vertVbo);
                GL.BufferData(GL.ARRAY_BUFFER, vertices, GL.STATIC_DRAW);
                program.EnableVertAttribArrPtr(
                    "vert",
                    3,
                    GL.FLOAT,
                    false,
                    0
                );
                GL.BindBuffer(GL.ARRAY_BUFFER, colorVbo);
                GL.BufferData(GL.ARRAY_BUFFER, colors, GL.STATIC_DRAW);
                program.EnableVertAttribArrPtr(
                    "in_color",
                    3,
                    GL.FLOAT,
                    false,
                    0
                );
                GL.BindBuffer(GL.ARRAY_BUFFER, GL.NONE);
                GL.DrawArrays(GL.TRIANGLES, 0, 3);
                GLProgram.Unbind();
                /*GL.Begin(GL.TRIANGLES);
                GL.Color3f(1, 0, 0);
                GL.Vertex2f(0, .5f);
                GL.Color3f(0, 1, 0);
                GL.Vertex2f(-.5f, -.5f);
                GL.Color3f(0, 0, 1);
                GL.Vertex2f(.5f, -.5f);
                GL.End();*/
                GLFW.SwapBuffers(window);
                GLFW.PollEvents();
            }
            Console.WriteLine("Bye!");
            GL.BindBuffer(GL.ARRAY_BUFFER, GL.NONE);
            GL.DeleteBuffer(vertVbo);
            GL.DeleteBuffer(colorVbo);
            GLFW.SetKeyCallback(window, null);
            GLFW.DestroyWindow(window);
            GLFW.Terminate();
        }
    }
}

using GLCs;
using System;

namespace GLCs_test
{
    class Program
    {
        static void Main(string[] args)
        {
            GLFW.SetErrorCallback((error, description) =>
            {
                Console.WriteLine("########## GL ERROR ##########");
                Console.WriteLine("{0}: {1}", error, description);
            });
            if (!GLFW.Init())
            {
                throw new ApplicationException("Unable to initialize GLFW");
            }
            GLFW.WindowHint(GLFW.VISIBLE, GLFW.FALSE);
            IntPtr window = GLFW.CreateWindow(854, 480, "GLC# Test", IntPtr.Zero, IntPtr.Zero);
            GLFW.SetKeyCallback(window, (window, key, scancode, action, mods) =>
            {
                if (action == GLFW.PRESS && key == GLFW.KEY_ESCAPE)
                {
                    GLFW.SetWindowShouldClose(window, true);
                }
            });
            GLFW.MakeContextCurrent(window);
            GLFW.SwapInterval(1);
            GLFW.ShowWindow(window);
            GL.ClearColor(.4f, .6f, .9f, 1);
            while (!GLFW.WindowShouldClose(window))
            {
                GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
                GL.Begin(GL.TRIANGLES);
                GL.Color3f(1, 0, 0);
                GL.Vertex2f(0, .5f);
                GL.Color3f(0, 1, 0);
                GL.Vertex2f(-.5f, -.5f);
                GL.Color3f(0, 0, 1);
                GL.Vertex2f(.5f, -.5f);
                GL.End();
                GLFW.SwapBuffers(window);
                GLFW.PollEvents();
            }
            GLFW.SetKeyCallback(window, null);
            GLFW.DestroyWindow(window);
            GLFW.Terminate();
        }
    }
}

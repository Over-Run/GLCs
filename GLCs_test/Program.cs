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
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 3);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 3);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);
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
            GL.Viewport(0, 0, 854, 480);
            GLProgram program = new GLProgram()
                .CreateVsh(@"#version 330 core
layout (location = 0) in vec3 vert;
layout (location = 1) in vec3 in_color;
out vec3 out_color;
void main() {
    gl_Position = vec4(vert, 1.0);
    out_color = in_color;
}")
                .CreateFsh(@"#version 330 core
in vec3 out_color;
out vec4 FragColor;
void main() {
    FragColor = vec4(out_color, 1.0);
}")
                .Link();
            float[] data =
            {
                0.5f, 0.5f, 0f, 1, 0, 0,
                -0.5f, -0.5f, 0f, 0, 1, 0,
                0.5f, -0.5f, 0f, 0, 0, 1
            };
            uint vao = GL.GenVertexArrays();
            uint vbo = GL.GenBuffers();
            GL.BindVertexArray(vao);
            GL.BindBuffer(GL.ARRAY_BUFFER, vbo);
            GL.BufferData(GL.ARRAY_BUFFER, data, GL.STATIC_DRAW);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, GL.FLOAT, false, 24, 0);
            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 3, GL.FLOAT, false, 24, 12);
            GL.BindBuffer(GL.ARRAY_BUFFER, 0);
            GL.DrawArrays(GL.TRIANGLES, 0, 3);
            GL.BindVertexArray(0);
            while (!GLFW.WindowShouldClose(window))
            {
                GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
                program.Bind();
                GL.BindVertexArray(vao);
                GL.DrawArrays(GL.TRIANGLES, 0, 3);
                GL.BindVertexArray(0);
                GLProgram.Unbind();
                GLFW.SwapBuffers(window);
                GLFW.PollEvents();
            }
            Console.WriteLine("Bye!");
            GL.BindBuffer(GL.ARRAY_BUFFER, 0);
            GL.DeleteBuffer(vbo);
            GL.DeleteVertexArrays(vao);
            program.Free();
            GLFW.SetKeyCallback(window, null);
            GLFW.DestroyWindow(window);
            GLFW.Terminate();
        }
    }
}

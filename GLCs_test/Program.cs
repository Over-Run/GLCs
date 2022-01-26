using GLCs;
using GLCs.GLMath;
using GLCs.STB;
using System;
using System.IO;
using System.Numerics;
using System.Text;

namespace GLCs_test
{
    enum CameraMovement
    {
        FORWARD,
        BACKWARD,
        LEFT,
        RIGHT
    }
    class Camera
    {
        public const float YAW = -90.0f;
        public const float PITCH = 0.0f;
        public const float SPEED = 2.5f;
        public const float SENSITIVITY = 0.1f;

        public Vector3 position;
        public Vector3 front;
        public Vector3 up;
        public Vector3 right;
        public Vector3 worldUp;
        public float yaw, pitch;
        public float movementSpeed;
        public float mouseSensitivity;

        public Camera(
            Vector3 position,
            Vector3 up,
            float yaw = YAW,
            float pitch = PITCH)
        {
            this.position = position;
            worldUp = up;
            this.yaw = yaw;
            this.pitch = pitch;
            front = new(0, 0, -1);
            movementSpeed = SPEED;
            mouseSensitivity = SENSITIVITY;
            UpdateCameraVectors();
        }
        public Camera() : this(Vector3.Zero, new(0, 1, 0), YAW, PITCH)
        { }

        public Matrix4x4 GetViewMatrix()
        {
            return Matrix4x4.CreateLookAt(position, position + front, up);
        }

        public void ProcessKeyboard(CameraMovement direction, float deltaTime)
        {
            float velocity = movementSpeed * deltaTime;
            switch (direction)
            {
                case CameraMovement.FORWARD:
                    position += front * velocity;
                    break;
                case CameraMovement.BACKWARD:
                    position -= front * velocity;
                    break;
                case CameraMovement.LEFT:
                    position -= right * velocity;
                    break;
                case CameraMovement.RIGHT:
                    position += right * velocity;
                    break;
                default:
                    break;
            }
            // make sure the user stays at the ground level
            position.Y = 0.0f; // <-- this one-liner keeps the user at the ground level (xz plane)
        }

        public void ProcessMouseMovement(float xoffset, float yoffset, bool constrainPitch = true)
        {
            xoffset *= mouseSensitivity;
            yoffset *= mouseSensitivity;

            yaw += xoffset;
            pitch += yoffset;

            // make sure that when pitch is out of bounds, screen doesn't get flipped
            if (constrainPitch)
            {
                if (pitch > 89.0f)
                    pitch = 89.0f;
                if (pitch < -89.0f)
                    pitch = -89.0f;
            }

            // update Front, Right and Up Vectors using the updated Euler angles
            UpdateCameraVectors();
        }

        // calculates the front vector from the Camera's (updated) Euler Angles
        private void UpdateCameraVectors()
        {
            // calculate the new Front vector
            Vector3 front = new(
                (float)(Math.Cos(GMath.ToRadians(yaw)) * Math.Cos(GMath.ToRadians(pitch))),
                (float)Math.Sin(GMath.ToRadians(pitch)),
                (float)(Math.Sin(GMath.ToRadians(yaw)) * Math.Cos(GMath.ToRadians(pitch)))
            );
            this.front = Vector3.Normalize(front);
            // also re-calculate the Right and Up vector
            right = Vector3.Normalize(Vector3.Cross(this.front, worldUp));  // normalize the vectors, because their length gets closer to 0 the more you look up or down which results in slower movement.
            up = Vector3.Normalize(Vector3.Cross(right, this.front));
        }
    }
    class Program
    {
        static int width = 854, height = 480;
        static uint vao = 0;
        static uint fbo = 0;
        static uint[] bufs = new uint[2], textures = new uint[2];
        static Matrix4x4 proj = Matrix4x4.Identity;
        static Matrix4x4 view = Matrix4x4.Identity;
        static Matrix4x4 model = Matrix4x4.Identity;
        static GLProgram? program;
        static readonly Vector3[] cubePositions =
        {
            new( 0.0f,  0.0f,  0.0f),
            new( 2.0f,  5.0f, -15.0f),
            new(-1.5f, -2.2f, -2.5f),
            new(-3.8f, -2.0f, -12.3f),
            new( 2.4f, -0.4f, -3.5f),
            new(-1.7f,  3.0f, -7.5f),
            new( 1.3f, -2.0f, -2.5f),
            new( 1.5f,  2.0f, -2.5f),
            new( 1.5f,  0.2f, -1.5f),
            new(-1.3f,  1.0f, -1.5f)
        };
        static bool paused = false;
        static bool firstMouse = true;
        static float lastX = width / 2, lastY = height / 2;
        static readonly Camera camera = new();
        static float deltaTime = 0.0f;
        static float lastFrame = 0.0f;
        static readonly float[] vertices =
        {
            // 5y+x
            // x0,y1,z2,u3,v4
            0, 1, 0, 0, 0, // 0
            0, 0, 0, 0, 1, // 1
            0, 1, 1, 1, 0, // 2
            0, 0, 1, 1, 1, // 3
            1, 1, 1, 0, 0, // 4
            1, 0, 1, 0, 1, // 5
            1, 1, 0, 1, 0, // 6
            1, 0, 0, 1, 1, // 7
            0, 0, 1, 0, 0, // 8
            0, 0, 0, 0, 1, // 9
            1, 0, 1, 1, 0, // 10
            1, 0, 0, 1, 1, // 11
            0, 1, 0, 0, 0, // 12
            0, 1, 1, 0, 1, // 13
            1, 1, 0, 1, 0, // 14
            1, 1, 1, 1, 1, // 15
            1, 1, 0, 0, 0, // 16
            1, 0, 0, 0, 1, // 17
            0, 1, 0, 1, 0, // 18
            0, 0, 0, 1, 1, // 19
            0, 1, 1, 0, 0, // 20
            0, 0, 1, 0, 1, // 21
            1, 1, 1, 1, 0, // 22
            1, 0, 1, 1, 1  // 23
        };
        static readonly int[] indices =
        {
            0, 1, 2, 2, 1, 3,
            4, 5, 6, 6, 5, 7,
            8, 9, 10, 10, 9, 11,
            12, 13, 14, 14, 13, 15,
            16, 17, 18, 18, 17, 19,
            20, 21, 22, 22, 21, 23
        };

        static void Init()
        {
            GL.ClearColor(0.4f, 0.6f, 0.9f, 1.0f);
            GL.Enable(GL.DEPTH_TEST);
            GL.DepthFunc(GL.LEQUAL);
            GL.Enable(GL.CULL_FACE);
            GL.Viewport(0, 0, width, height);

            textures = new uint[] { 0, 0 };
            GL.GenTextures(textures);
            GL.BindTexture(GL.TEXTURE_2D, textures[0]);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_WRAP_S, GL.REPEAT);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_WRAP_T, GL.REPEAT);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, GL.LINEAR);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, GL.LINEAR);
            int w = 0, h = 0, c = 0;
            IntPtr data = STBImage.Load("container.jpg", ref w, ref h, ref c, STBImage.RGB);
            if (data != IntPtr.Zero)
            {
                GL.TexImage2D(GL.TEXTURE_2D, 0, (int)GL.RGB, w, h, 0, GL.RGB, GL.UNSIGNED_BYTE, data);
                GL.GenerateMipmap(GL.TEXTURE_2D);
            }
            else
            {
                Console.WriteLine("Failed to load texture");
            }
            STBImage.ImageFree(data);
            GL.BindTexture(GL.TEXTURE_2D, textures[1]);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_WRAP_S, GL.REPEAT);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_WRAP_T, GL.REPEAT);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, GL.LINEAR);
            GL.TexParameterui(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, GL.LINEAR);
            w = 0;
            h = 0;
            c = 0;
            data = STBImage.Load("awesomeface.png", ref w, ref h, ref c, STBImage.RGB);
            if (data != IntPtr.Zero)
            {
                GL.TexImage2D(GL.TEXTURE_2D, 0, (int)GL.RGB, w, h, 0, GL.RGB, GL.UNSIGNED_BYTE, data);
                GL.GenerateMipmap(GL.TEXTURE_2D);
            }
            else
            {
                Console.WriteLine("Failed to load texture");
            }
            STBImage.ImageFree(data);

            program = new();
            StringBuilder sb = new();
            using (StreamReader fs = new("shader.vert"))
            {
                string? ln;
                int i = 0;
                while ((ln = fs.ReadLine()) != null)
                {
                    if (i != 0) sb.AppendLine();
                    sb.Append(ln);
                    ++i;
                }
            }
            program.CreateVsh(sb.ToString());
            sb.Clear();
            using (StreamReader fs = new("shader.frag"))
            {
                string? ln;
                int i = 0;
                while ((ln = fs.ReadLine()) != null)
                {
                    if (i != 0) sb.AppendLine();
                    sb.Append(ln);
                    ++i;
                }
            }
            program.CreateFsh(sb.ToString())
                .Link();

            vao = GL.GenVertexArrays();
            bufs = new uint[] { 0, 0 };
            GL.GenBuffers(bufs);
            GL.BindVertexArray(vao);
            GL.BindBuffer(GL.ARRAY_BUFFER, bufs[0]);
            GL.BufferData(GL.ARRAY_BUFFER, vertices, GL.DYNAMIC_DRAW);
            GL.BindBuffer(GL.ELEMENT_ARRAY_BUFFER, bufs[1]);
            GL.BufferData(GL.ELEMENT_ARRAY_BUFFER, indices, GL.STATIC_DRAW);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, GL.FLOAT, false, 20, 0);
            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 2, GL.FLOAT, false, 20, 12);
            GL.BindBuffer(GL.ARRAY_BUFFER, 0);
            GL.BindVertexArray(0);

            fbo = GL.GenFramebuffers();
            GL.BindFramebuffer(GL.FRAMEBUFFER, fbo);
            if (GL.CheckFramebufferStatus(GL.FRAMEBUFFER) != GL.FRAMEBUFFER_COMPLETE)
            {
                // error
            }

            program.Bind();
            program.SetUniform("texture1", 0);
            program.SetUniform("texture2", 1);
        }

        static void Tick(IntPtr window)
        {
            if (GLFW.GetKey(window, GLFW.KEY_W) == GLFW.PRESS)
                camera.ProcessKeyboard(CameraMovement.FORWARD, deltaTime);
            if (GLFW.GetKey(window, GLFW.KEY_S) == GLFW.PRESS)
                camera.ProcessKeyboard(CameraMovement.BACKWARD, deltaTime);
            if (GLFW.GetKey(window, GLFW.KEY_A) == GLFW.PRESS)
                camera.ProcessKeyboard(CameraMovement.LEFT, deltaTime);
            if (GLFW.GetKey(window, GLFW.KEY_D) == GLFW.PRESS)
                camera.ProcessKeyboard(CameraMovement.RIGHT, deltaTime);
        }

        static void Render()
        {
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);

            proj = Matrix4x4.CreatePerspectiveFieldOfView((float)GMath.ToRadians(90.0f),
                (float)width / height,
                0.05f,
                100.0f);
            view = camera.GetViewMatrix();

            program?.Bind();
            program?.SetUniform("proj", proj);
            program?.SetUniform("view", view);
            GL.ActiveTexture(GL.TEXTURE0);
            GL.BindTexture(GL.TEXTURE_2D, textures[0]);
            GL.ActiveTexture(GL.TEXTURE1);
            GL.BindTexture(GL.TEXTURE_2D, textures[1]);
            GL.BindVertexArray(vao);
            for (int i = 0; i < cubePositions.Length; ++i)
            {
                float angle = 20.0f * i;
                model = Matrix4x4.CreateFromAxisAngle(new Vector3(1.0f, 0.3f, 0.5f), (float)GMath.ToRadians(angle));
                model *= Matrix4x4.CreateTranslation(cubePositions[i]);
                program?.SetUniform("model", model);
                GL.DrawElements(GL.TRIANGLES, 36, GL.UNSIGNED_INT, 0);
            }
            GL.BindVertexArray(0);
            GLProgram.Unbind();
        }

        static void Free(IntPtr window)
        {
            Console.WriteLine("Bye!");
            GL.DeleteTextures(textures);
            GL.BindBuffer(GL.ARRAY_BUFFER, 0);
            GL.DeleteBuffers(bufs);
            GL.DeleteVertexArrays(vao);
            GL.DeleteFramebuffers(fbo);
            program?.Free();
            GLFW.DestroyWindow(window);
        }

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
            IntPtr window = GLFW.CreateWindow(width, height, "GLC# Test", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                throw new ContextException("Failed to create the window");
            }
            GLFW.SetKeyCallback(window, (window, key, scancode, action, mods) =>
            {
                if (action == GLFW.PRESS)
                {
                    if (key == GLFW.KEY_ESCAPE)
                    {
                        paused = !paused;
                        firstMouse = true;
                        GLFW.SetInputMode(window, GLFW.CURSOR, paused ? GLFW.CURSOR_NORMAL : GLFW.CURSOR_DISABLED);
                    }
                }
            });
            GLFW.SetFramebufferSizeCallback(window, (window, w, h) =>
            {
                width = w;
                height = h;
                GL.Viewport(0, 0, w, h);
            });
            GLFW.SetCursorPosCallback(window, (window, xp, yp) =>
            {
                float xpos = (float)xp;
                float ypos = (float)yp;

                if (firstMouse)
                {
                    lastX = xpos;
                    lastY = ypos;
                    firstMouse = false;
                }

                float xoffset = xpos - lastX;
                float yoffset = lastY - ypos;
                lastX = xpos;
                lastY = ypos;

                camera.ProcessMouseMovement(xoffset, yoffset);
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
            GLCaps.LoadGL();
            //GLFW.SwapInterval(1);

            Init();

            GLFW.ShowWindow(window);
            GLFW.SetInputMode(window, GLFW.CURSOR, GLFW.CURSOR_DISABLED);

            while (!GLFW.WindowShouldClose(window))
            {
                float currentFrame = (float)GLFW.GetTime();
                deltaTime = currentFrame - lastFrame;
                lastFrame = currentFrame;
                Tick(window);
                Render();
                GLFW.SwapBuffers(window);
                GLFW.PollEvents();
            }
            Free(window);
            GLFW.Terminate();
        }
    }
}

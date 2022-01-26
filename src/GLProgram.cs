using System;
using System.Collections.Generic;
using System.Numerics;

namespace GLCs
{
    public class GLProgram
    {
        private readonly Dictionary<string, int> uniforms = new();
        private readonly Dictionary<string, int> attributes = new();
        private readonly uint programId = GL.CreateProgram();
        private uint vshId = 0;
        private uint fshId = 0;

        public GLProgram()
        {
            if (programId == 0)
            {
                throw new NullPointerException("Failed to create GL program");
            }
        }

        public GLProgram CreateVsh(string src)
        {
            vshId = CreateShader(src, GL.VERTEX_SHADER);
            return this;
        }

        public GLProgram CreateFsh(string src)
        {
            fshId = CreateShader(src, GL.FRAGMENT_SHADER);
            return this;
        }

        public GLProgram Link()
        {
            GL.LinkProgram(programId);
            if (GL.GetProgrami(programId, GL.LINK_STATUS) == GL.FALSE)
            {
                throw new ContextException("Error linking GL program: " + GL.GetProgramInfoLog(programId));
            }
            if (vshId != 0)
            {
                GL.DetachShader(programId, vshId);
                GL.DeleteShader(vshId);
                vshId = 0;
            }
            if (fshId != 0)
            {
                GL.DetachShader(programId, fshId);
                GL.DeleteShader(fshId);
                fshId = 0;
            }
            GL.ValidateProgram(programId);
            if (GL.GetProgrami(programId, GL.VALIDATE_STATUS) == GL.FALSE)
                Console.Error.WriteLine(GL.GetProgramInfoLog(programId));
            return this;
        }

        public void Bind()
        {
            GL.UseProgram(programId);
        }

        public static void Unbind()
        {
            GL.UseProgram(0);
        }

        public KeyValuePair<bool, int> HasUniform(string name)
        {
            int loc = GL.GetUniformLocation(programId, name);
            return new KeyValuePair<bool, int>(loc >= 0, loc);
        }

        public int GetUniform(string name)
        {
            if (uniforms.ContainsKey(name)) return uniforms[name];
            var pair = HasUniform(name);
            if (!pair.Key)
                throw new ArgumentException("Couldn't find uniform: \"" + name + "\"");
            uniforms[name] = pair.Value;
            return pair.Value;
        }

        public void SetUniform(string name, int value)
        {
            GL.Uniform1i(GetUniform(name), value);
        }

        public void SetUniform(string name, float value)
        {
            GL.Uniform1f(GetUniform(name), value);
        }

        public void SetUniform(string name, Matrix4x4 mat)
        {
            GL.UniformMatrix4fv(GetUniform(name), false, mat);
        }

        public int GetAttrib(string name)
        {
            if (attributes.ContainsKey(name)) return attributes[name];
            var loc = GL.GetAttribLocation(programId, name);
            attributes[name] = loc;
            return loc;
        }

        public void EnableVertexAttribArray(string name)
        {
            GL.EnableVertexAttribArray((uint) GL.GetAttribLocation(programId, name));
        }

        public void VertexAttribPointer(
            string name,
            int size,
            uint type,
            bool normalized,
            int stride)
        {
            GL.VertexAttribPointer(
                (uint) GL.GetAttribLocation(programId, name),
                size,
                type,
                normalized,
                stride,
                IntPtr.Zero
            );
        }

        public void EnableVertAttribArrPtr(
            string name,
            int size,
            uint type,
            bool normalized,
            int stride)
        {
            EnableVertexAttribArray(name);
            VertexAttribPointer(name, size, type, normalized, stride);
        }

        public void DisableVertexAttribArrays(params string[] names)
        {
            foreach (var name in names)
            {
                GL.DisableVertexAttribArray((uint) GL.GetAttribLocation(programId, name));
            }
        }

        private uint CreateShader(string src, uint type)
        {
            uint id = GL.CreateShader(type);
            if (id == 0)
            {
                throw new NullPointerException(
                    "An error occurred creating the shader "
                        + type
                        + " object."
                );
            }
            GL.ShaderSource(id, src);
            GL.CompileShader(id);
            if (GL.GetShaderi(id, GL.COMPILE_STATUS) == GL.FALSE)
            {
                throw new ArgumentException("Error compiling shader src: " + GL.GetShaderInfoLog(id));
            }
            GL.AttachShader(programId, id);
            return id;
        }

        public void Free()
        {
            if (GL.IsProgram(programId)) GL.DeleteProgram(programId);
        }
    }
}

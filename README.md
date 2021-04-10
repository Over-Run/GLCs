# GLCs ![License](https://img.shields.io/github/license/Over-Run/GLCs)

OpenGL bindings for C#. ![Nuget](https://img.shields.io/nuget/v/GLCs) ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/GLCs)

Now include:
- [GLFW](https://www.glfw.org/) 3.3.4
- OpenGL 2.1

## How to Use

1. Add package to your project:
   ```
   dotnet add package GLCs
   ```
2. Use it just like [GLCs_test](GLCs_test).

**Note**: Required `glfw3.dll` and `opengl32.dll`.

The all classes are under `GLCs` namespace.

The `GL` class includes all functions (2.1) in `glew.h`.

### The `GLFW` class

Includes all funtions in `glfw3.h`.

#### Nullable Types

Mark a method may return "NULL" in C, or mark a param can be "NULL" in C.

`[Nullable] type[] param`:

```c#
void themethod([Nullable] ref type[] param) { }
void othermethod()
{
    type[] a = {};
    themethod(ref a);
}
```

`[Nullable] aDelegate param`:

```c#
delegate void aDelegate();
void themethod([Nullable] ref aDelegate param) { }
void othermethod()
{
    themethod(null);
}
```

`[Nullable] IntPtr param`:

```c#
void themethod([Nullable] IntPtr param) { }
void othermethod()
{
    themethod(IntPtr.Zero);
}
```

## Plans

| Time       | Support to OpenGL... |
| ---------- | -------------------- |
| 2021-05-22 | 3.0 & 3.1            |
| 2020-06-12 | 3.2                  |
| 2020-07-03 | 3.3 & 4.0            |
| 2020-07-24 | 4.5 & 4.6            |

using System;

namespace GLCs
{
    public static class GLCS
    {
        public const int VERSION_MAJOR = 0;
        public const int VERSION_MINOR = 3;
        public const int VERSION_REVISION = 0;
        public static string GetVersionString()
        {
            return VERSION_MAJOR + "." + VERSION_MINOR + "." + VERSION_REVISION;
        }
    }
    public class ContextException : ApplicationException
    {
        public ContextException(string message) : base(message) { }
    }
    public class NullPointerException : ApplicationException
    {
        public NullPointerException() { }
        public NullPointerException(string message) : base(message) { }
    }
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false)]
    public sealed class Nullable : System.Attribute { }
}
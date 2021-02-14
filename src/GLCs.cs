namespace GLCs
{
    public static class GLCs
    {
        public const int VERSION_MAJOR = 0;
        public const int VERSION_MINOR = 1;
        public const int VERSION_REVISION = 0;
        public static string GetVersionString() {
            return VERSION_MAJOR + "." + VERSION_MINOR + "." + VERSION_REVISION;
        }
    }
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false)]
    public sealed class Nullable : System.Attribute { }
}
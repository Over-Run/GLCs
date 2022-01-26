namespace GLCs.GLMath
{
    public static class GMath
    {
        private const double DEGREES_TO_RADIANS = 0.017453292519943295;
        private const double RADIANS_TO_DEGREES = 57.29577951308232;

        public static double ToRadians(double angdeg)
        {
            return angdeg * DEGREES_TO_RADIANS;
        }

        public static double ToDegrees(double angrad)
        {
            return angrad * RADIANS_TO_DEGREES;
        }
    }
}

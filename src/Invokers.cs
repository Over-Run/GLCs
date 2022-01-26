using System;
using System.Text;

namespace GLCs
{
    /// <summary>
    /// OpenGL invokers. Format: Invoke[ParamsType][ReturnType]
    /// <para>
    /// Types: bool-Z
    /// byte-A
    /// sbyte-B
    /// char-C
    /// decimal-E
    /// double-D
    /// float-F
    /// IntPtr-P
    /// int-I
    /// uint-U
    /// long-J
    /// ulong-L
    /// short-S
    /// ushort-H
    /// void-V
    /// array-O
    /// ref-R
    /// string-X
    /// StringBuilder-Y
    /// </para>
    /// </summary>
    public static class Invokers
    {
        #region Delegates

        public delegate void InvokeAAAV(byte a, byte b, byte c);
        public delegate void InvokeBBBV(sbyte a, sbyte b, sbyte c);
        public delegate void InvokeDDDV(double a, double b, double c);
        public delegate void InvokeDDV(double a, double b);
        public delegate void InvokeDV(double a);
        public delegate void InvokeFFFFV(float a, float b, float c, float d);
        public delegate void InvokeFFFV(float a, float b, float c);
        public delegate void InvokeFFV(float a, float b);
        public delegate void InvokeFV(float a);
        public delegate void InvokeFZV(float a, bool b);
        public delegate void InvokeHHHV(ushort a, ushort b, ushort c);
        public delegate void InvokeIFFFFV(int a, float b, float c, float d, float e);
        public delegate void InvokeIFFFV(int a, float b, float c, float d);
        public delegate void InvokeIFFV(int a, float b, float c);
        public delegate void InvokeIFV(int a, float b);
        public delegate void InvokeIIIIIIIIUUV(int a, int b, int c, int d, int e, int f, int g, int h, uint i, uint j);
        public delegate void InvokeIIIIIV(int a, int b, int c, int d, int e);
        public delegate void InvokeIIIIV(int a, int b, int c, int d);
        public delegate void InvokeIIIV(int a, int b, int c);
        public delegate void InvokeIIOfV(int a, int b, float[] c);
        public delegate void InvokeIIOiV(int a, int b, int[] c);
        public delegate void InvokeIIOuV(int a, int b, uint[] c);
        public delegate void InvokeIIV(int a, int b);
        public delegate void InvokeIIZOfV(int a, int b, bool c, float[] d);
        public delegate void InvokeIOuV(int a, uint[] b);
        public delegate void InvokeIUIPV(int a, uint b, int c, IntPtr d);
        public delegate void InvokeIUUUUV(int a, uint b, uint c, uint d, uint e);
        public delegate void InvokeIUUUV(int a, uint b, uint c, uint d);
        public delegate void InvokeIUUV(int a, uint b, uint c);
        public delegate void InvokeIUV(int a, uint b);
        public delegate void InvokeOaV(byte[] a);
        public delegate void InvokeObV(sbyte[] a);
        public delegate void InvokeOdV(double[] a);
        public delegate void InvokeOfV(float[] a);
        public delegate void InvokeOhV(ushort[] a);
        public delegate void InvokeOiIOuV(int[] a, int b, uint[] c);
        public delegate void InvokeOiV(int[] a);
        public delegate void InvokeOsV(short[] a);
        public delegate void InvokeOuV(uint[] a);
        public delegate void InvokePUIOiOiV(IntPtr a, uint b, int c, int[] d, int[] e);
        public delegate uint InvokePULU(IntPtr a, uint b, ulong c);
        public delegate void InvokePULV(IntPtr a, uint b, ulong c);
        public delegate void InvokePV(IntPtr a);
        public delegate bool InvokePZ(IntPtr a);
        public delegate void InvokeSSSV(short a, short b, short c);
        public delegate void InvokeSSV(short a, short b);
        public delegate uint InvokeU();
        public delegate void InvokeUAAAAV(uint a, byte b, byte c, byte d, byte e);
        public delegate void InvokeUDDDDV(uint a, double b, double c, double d, double e);
        public delegate void InvokeUDDDV(uint a, double b, double c, double d);
        public delegate void InvokeUDDV(uint a, double b, double c);
        public delegate void InvokeUDV(uint a, double b);
        public delegate void InvokeUFFFFV(uint a, float b, float c, float d, float e);
        public delegate void InvokeUFFFV(uint a, float b, float c, float d);
        public delegate void InvokeUFFV(uint a, float b, float c);
        public delegate void InvokeUFV(uint a, float b);
        public delegate void InvokeUIIIIIIIIV(uint a, int b, int c, int d, int e, int f, int g, int h, int i);
        public delegate void InvokeUIIIIIIIUIPV(uint a, int b, int c, int d, int e, int f, int g, int h, uint i, int j, IntPtr k);
        public delegate void InvokeUIIIIIIIUUPV(uint a, int b, int c, int d, int e, int f, int g, int h, uint i, uint j, IntPtr k);
        public delegate void InvokeUIIIIIIIV(uint a, int b, int c, int d, int e, int f, int g, int h);
        public delegate void InvokeUIIIIIIUUPV(uint a, int b, int c, int d, int e, int f, int g, uint h, uint i, IntPtr j);
        public delegate void InvokeUIIIIIUIPV(uint a, int b, int c, int d, int e, int f, uint g, int h, IntPtr i);
        public delegate void InvokeUIIIIIUUPV(uint a, int b, int c, int d, int e, int f, uint g, uint h, IntPtr i);
        public delegate void InvokeUIIIIIV(uint a, int b, int c, int d, int e, int f);
        public delegate void InvokeUIIIIV(uint a, int b, int c, int d, int e);
        public delegate void InvokeUIIIUIPV(uint a, int b, int c, int d, uint e, int f, IntPtr g);
        public delegate void InvokeUIIIUUPV(uint a, int b, int c, int d, uint e, uint f, IntPtr g);
        public delegate void InvokeUIIIV(uint a, int b, int c, int d);
        public delegate void InvokeUIIOdV(uint a, int b, int c, double[] d);
        public delegate void InvokeUIIPV(uint a, int b, int c, IntPtr d);
        public delegate void InvokeUIIUIIV(uint a, int b, int c, uint d, int e, int f);
        public delegate void InvokeUIUIIV(uint a, int b, uint c, int d, int e);
        public delegate void InvokeUIUUIPV(uint a, int b, uint c, uint d, int e, IntPtr f);
        public delegate void InvokeUIIV(uint a, int b, int c);
        public delegate void InvokeUIFIV(uint a, int b, float c, int d);
        public delegate void InvokeUIOiV(uint a, int b, int[] c);
        public delegate void InvokeUIOiYV(uint a, int b, int[] c, StringBuilder d);
        public delegate void InvokeUIOfV(uint a, int b, float[] c);
        public delegate void InvokeUIOuIIIIV(uint a, int b, uint[] c, int d, int e, int f, int g);
        public delegate uint InvokeUIOuOuOuOiYU(uint a, int b, uint[] c, uint[] d, uint[] e, int[] f, StringBuilder g);
        public delegate void InvokeUIOuV(uint a, int b, uint[] c);
        public delegate void InvokeUIOxOiV(uint a, int b, string[] c, int[] d);
        public delegate void InvokeUIOxUV(uint a, int b, string[] c, uint d);
        public delegate void InvokeUIPV(uint a, int b, IntPtr c);
        public delegate void InvokeUIRiOuV(uint a, int b, ref int c, uint[] d);
        public delegate void InvokeUIRiYV(uint a, int b, ref int c, StringBuilder d);
        public delegate void InvokeUIUIIIIIPV(uint a, int b, uint c, int d, int e, int f, int g, int h, IntPtr i);
        public delegate void InvokeUIUIIIIPV(uint a, int b, uint c, int d, int e, int f, int g, IntPtr h);
        public delegate void InvokeUIUIIIPV(uint a, int b, uint c, int d, int e, int f, IntPtr g);
        public delegate void InvokeUIUIIIV(uint a, int b, uint c, int d, int e, int f);
        public delegate void InvokeUIUIIIZV(uint a, int b, uint c, int d, int e, int f, bool g);
        public delegate void InvokeUIUIIZV(uint a, int b, uint c, int d, int e, bool f);
        public delegate void InvokeUIUIPV(uint a, int b, uint c, int d, IntPtr e);
        public delegate void InvokeUIUIOfV(uint a, int b, uint c, int d, float[] e);
        public delegate void InvokeUIUIOiV(uint a, int b, uint c, int d, int[] e);
        public delegate void InvokeUIUIV(uint a, int b, uint c, int d);
        public delegate void InvokeUIUOfV(uint a, int b, uint c, float[] d);
        public delegate void InvokeUIUOiV(uint a, int b, uint c, int[] d);
        public delegate void InvokeUIUPIIV(uint a, int b, uint c, IntPtr d, int e, int f);
        public delegate void InvokeUIUPIV(uint a, int b, uint c, IntPtr d, int e);
        public delegate void InvokeUIUZIPV(uint a, int b, uint c, bool d, int e, IntPtr f);
        public delegate void InvokeUIV(uint a, int b);
        public delegate void InvokeUJJPV(uint a, long b, long c, IntPtr d);
        public delegate void InvokeUJPUV(uint a, long b, IntPtr c, uint d);
        public delegate void InvokeUOaV(uint a, byte[] b);
        public delegate void InvokeUObV(uint a, sbyte[] b);
        public delegate void InvokeUOdV(uint a, double[] b);
        public delegate void InvokeUOfV(uint a, float[] b);
        public delegate void InvokeUOhV(uint a, ushort[] b);
        public delegate void InvokeUOiOiIV(uint a, int[] b, int[] c, int d);
        public delegate void InvokeUOiOiIOuV(uint a, int[] b, int[] c, int d, uint[] e);
        public delegate void InvokeUOiOiPV(uint a, int[] b, int[] c, IntPtr d);
        public delegate IntPtr InvokeUOiOiUP(uint a, int[] b, int[] c, uint d);
        public delegate void InvokeUOiOiV(uint a, int[] b, int[] c);
        public delegate void InvokeUOiPUV(uint a, int[] b, IntPtr c, uint d);
        public delegate void InvokeUOiUOpIOiV(uint a, int[] b, uint c, IntPtr[] d, int e, int[] f);
        public delegate void InvokeUOiUOpIV(uint a, int[] b, uint c, IntPtr[] d, int e);
        public delegate void InvokeUOiV(uint a, int[] b);
        public delegate void InvokeUOjV(uint a, long[] b);
        public delegate void InvokeUOsV(uint a, short[] b);
        public delegate void InvokeUOuV(uint a, uint[] b);
        public delegate void InvokeUPIIV(uint a, IntPtr b, int c, int d);
        public delegate void InvokeUPV(uint a, IntPtr b);
        public delegate void InvokeUPOiIIV(uint a, IntPtr b, int[] c, int d, int e);
        public delegate void InvokeUSSSSV(uint a, short b, short c, short d, short e);
        public delegate void InvokeUSSSV(uint a, short b, short c, short d);
        public delegate void InvokeUSSV(uint a, short b, short c);
        public delegate void InvokeUSV(uint a, short b);
        public delegate uint InvokeUU(uint a);
        public delegate void InvokeUUIFIV(uint a, uint b, int c, float d, int e);
        public delegate void InvokeUUIIIIIIIIUUV(uint a, uint b, int c, int d, int e, int f, int g, int h, int i, int j, uint k, uint l);
        public delegate void InvokeUUIIIIUV(uint a, uint b, int c, int d, int e, int f, uint g);
        public delegate void InvokeUUIIV(uint a, uint b, int c, int d);
        public delegate void InvokeUUIOfV(uint a, uint b, int c, float[] d);
        public delegate void InvokeUUIOiV(uint a, uint b, int c, int[] d);
        public delegate void InvokeUUIOuV(uint a, uint b, int c, uint[] d);
        public delegate void InvokeUUIOuOiV(uint a, uint b, int c, uint[] d, int[] e);
        public delegate void InvokeUUIOiYV(uint a, uint b, int c, int[] d, StringBuilder e);
        public delegate void InvokeUUIOuOpOiV(uint a, uint b, int c, uint[] d, IntPtr[] e, int[] f);
        public delegate void InvokeUUIOuRiV(uint a, uint b, int c, uint[] d, ref int e);
        public delegate void InvokeUUIOuZV(uint a, uint b, int c, uint[] d, bool e);
        public delegate void InvokeUUIRiRiRuXV(uint a, uint b, int c, ref int d, ref int e, ref uint f, string g);
        public delegate void InvokeUUIUUV(uint a, uint b, int c, uint d, uint e);
        public delegate void InvokeUUIUV(uint a, uint b, int c, uint d);
        public delegate void InvokeUUIUZUV(uint a, uint b, int c, uint d, bool e, uint f);
        public delegate void InvokeUUIV(uint a, uint b, int c);
        public delegate void InvokeUUFV(uint a, uint b, float c);
        public delegate void InvokeUUOdV(uint a, uint b, double[] c);
        public delegate void InvokeUUOfV(uint a, uint b, float[] c);
        public delegate void InvokeUUOiOiOiV(uint a, uint b, int[] c, int[] d, int[] e);
        public delegate void InvokeUUOiOiUUPV(uint a, uint b, int[] c, int[] d, uint e, uint f, IntPtr g);
        public delegate void InvokeUUOiV(uint a, uint b, int[] c);
        public delegate void InvokeUUOjV(uint a, uint b, long[] c);
        public delegate void InvokeUUOlV(uint a, uint b, ulong[] c);
        public delegate void InvokeUUOpV(uint a, uint b, IntPtr[] c);
        public delegate void InvokeUUOuV(uint a, uint b, uint[] c);
        public delegate void InvokeUUOzV(uint a, uint b, bool[] c);
        public delegate IntPtr InvokeUUP(uint a, uint b);
        public delegate void InvokeUUPIIV(uint a, uint b, IntPtr c, int d, int e);
        public delegate void InvokeUUPOiIIV(uint a, uint b, IntPtr c, int[] d, int e, int f);
        public delegate void InvokeUUPV(uint a, uint b, IntPtr c);
        public delegate uint InvokeUUU(uint a, uint b);
        public delegate void InvokeUUUIIIIUV(uint a, uint b, uint c, int d, int e, int f, int g, uint h);
        public delegate void InvokeUUUIIV(uint a, uint b, uint c, int d, int e);
        public delegate void InvokeUUUIUPIV(uint a, uint b, uint c, int d, uint e, IntPtr f, int g);
        public delegate void InvokeUUUIUPV(uint a, uint b, uint c, int d, uint e, IntPtr f);
        public delegate void InvokeUUUIV(uint a, uint b, uint c, int d);
        public delegate void InvokeUUUIXV(uint a, uint b, uint c, int d, string e);
        public delegate void InvokeUUUOfV(uint a, uint b, uint c, float[] d);
        public delegate void InvokeUUUOiIV(uint a, uint b, uint c, int[] d, int e);
        public delegate void InvokeUUUOiOiIV(uint a, uint b, uint c, int[] d, int[] e, int f);
        public delegate void InvokeUUUOiOiV(uint a, uint b, uint c, int[] d, int[] e);
        public delegate void InvokeUUUOiV(uint a, uint b, uint c, int[] d);
        public delegate void InvokeUUUOjV(uint a, uint b, uint c, long[] d);
        public delegate void InvokeUUUPV(uint a, uint b, uint c, IntPtr d);
        public delegate void InvokeUUUUIOfV(uint a, uint b, uint c, uint d, int e, float[] f);
        public delegate void InvokeUUUUIIV(uint a, uint b, uint c, uint d, int e, int f);
        public delegate void InvokeUUUUIV(uint a, uint b, uint c, uint d, int e);
        public delegate void InvokeUUUUPV(uint a, uint b, uint c, uint d, IntPtr e);
        public delegate void InvokeUUUUUUV(uint a, uint b, uint c, uint d, uint e, uint f);
        public delegate void InvokeUUUUUV(uint a, uint b, uint c, uint d, uint e);
        public delegate void InvokeUUUUV(uint a, uint b, uint c, uint d);
        public delegate void InvokeUUUV(uint a, uint b, uint c);
        public delegate void InvokeUUV(uint a, uint b);
        public delegate string InvokeUUX(uint a, uint b);
        public delegate void InvokeUUXV(uint a, uint b, string c);
        public delegate void InvokeUV(uint a);
        public delegate int InvokeUXI(uint a, string b);
        public delegate void InvokeUXUOuOuV(uint a, string b, uint c, uint[] d, uint[] e);
        public delegate bool InvokeUUZ(uint a, uint b);
        public delegate void InvokeUZZZZV(uint a, bool b, bool c, bool d, bool e);
        public delegate bool InvokeUZ(uint a);
        public delegate void InvokeUZUIOuV(uint a, bool b, uint c, int d, uint[] e);
        public delegate void InvokeV();

        #endregion // Delegates
    }
}

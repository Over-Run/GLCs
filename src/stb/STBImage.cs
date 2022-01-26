using System;
using System.Runtime.InteropServices;

namespace GLCs.STB
{
    public static class STBImage
    {
        private const string LIB = "stb.dll";
        public const int VERSION = 1;
        public const int DEFAULT = 0;
        public const int GREY = 1;
        public const int GREY_ALPHA = 2;
        public const int RGB = 3;
        public const int RGB_ALPHA = 4;
        [StructLayout(LayoutKind.Sequential)]
        public struct IOCallbacks
        {
            public delegate int Readd(IntPtr user, sbyte[] data, int size);
            public delegate void Skipd(IntPtr user, int n);
            public delegate int Eofd(IntPtr user);
            [MarshalAs(UnmanagedType.FunctionPtr)]
            private Readd read;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            private Skipd skip;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            private Eofd eof;

            public Readd Read
            {
                get { return read; }
                set { read = value; }
            }
            public Skipd Skip
            {
                get { return skip; }
                set { skip = value; }
            }
            public Eofd Eof
            {
                get { return eof; }
                set { eof = value; }
            }
        }
        [DllImport(LIB, EntryPoint = "?stbi__unpremultiply_on_load_thread@@YAXH@Z")]
        public static extern void UnpremultiplyOnLoadThread(int flag_true_if_should_unpremultiply);
        [DllImport(LIB, EntryPoint = "stbi_convert_iphone_png_to_rgb")]
        public static extern void ConvertIphonePngToRgb(int flag_true_if_should_convert);
        [DllImport(LIB, EntryPoint = "stbi_convert_iphone_png_to_rgb_thread")]
        public static extern void ConvertIphonePngToRgbThread(int flag_true_if_should_convert);
        [DllImport(LIB, EntryPoint = "stbi_failure_reason")]
        public static extern string FailureReason();
        [DllImport(LIB, EntryPoint = "stbi_hdr_to_ldr_gamma")]
        public static extern void HdrToLdrGamma(float gamma);
        [DllImport(LIB, EntryPoint = "stbi_hdr_to_ldr_scale")]
        public static extern void HdrToLdrScale(float scale);
        [DllImport(LIB, EntryPoint = "stbi_image_free")]
        public static extern void ImageFree(IntPtr retval_from_stbi_load);
        public static void ImageFree<T>(T[]? retval_from_stbi_load) where T : unmanaged
        {
            unsafe
            {
                fixed (T* ptr = retval_from_stbi_load)
                {
                    ImageFree(new(ptr));
                }
            }
        }
        [DllImport(LIB, EntryPoint = "stbi_info")]
        public static extern int Info(string filename, ref int x, ref int y, ref int comp);
        [DllImport(LIB, EntryPoint = "stbi_info_from_callbacks")]
        public static extern int InfoFromCallbacks(IOCallbacks[] clbk, IntPtr user, ref int x, ref int y, ref int comp);
        [DllImport(LIB, EntryPoint = "stbi_info_from_file")]
        public static extern int InfoFromFile(IntPtr f, ref int x, ref int y, ref int comp);
        [DllImport(LIB, EntryPoint = "stbi_info_from_memory")]
        private static extern int InfoFromMemory(byte[] buffer, int len, ref int x, ref int y, ref int comp);
        public static int InfoFromMemory(byte[] buffer, ref int x, ref int y, ref int comp) =>
            InfoFromMemory(buffer, buffer.Length, ref x, ref y, ref comp);
        [DllImport(LIB, EntryPoint = "stbi_is_16_bit")]
        public static extern int Is16Bit(string filename);
        [DllImport(LIB, EntryPoint = "stbi_is_16_bit_from_callbacks")]
        public static extern int Is16BitFromCallbacks(IOCallbacks[] clbk, IntPtr user);
        [DllImport(LIB, EntryPoint = "stbi_is_16_bit_from_file")]
        public static extern int Is16BitFromFile(IntPtr f);
        [DllImport(LIB, EntryPoint = "stbi_is_16_bit_from_memory")]
        public static extern int Is16BitFromMemory(byte[] buffer, int len);
        [DllImport(LIB, EntryPoint = "stbi_is_hdr")]
        public static extern int IsHdr(string filename);
        [DllImport(LIB, EntryPoint = "stbi_is_hdr_from_callbacks")]
        public static extern int IsHdrFromCallbacks(IOCallbacks[] clbk, IntPtr user);
        [DllImport(LIB, EntryPoint = "stbi_is_hdr_from_file")]
        public static extern int IsHdrFromFile(IntPtr f);
        [DllImport(LIB, EntryPoint = "stbi_is_hdr_from_memory")]
        public static extern int IsHdrFromMemory(byte[] buffer, int len);
        [DllImport(LIB, EntryPoint = "stbi_ldr_to_hdr_gamma")]
        public static extern void LdrToHdrGamma(float gamma);
        [DllImport(LIB, EntryPoint = "stbi_ldr_to_hdr_scale")]
        public static extern void LdrToHdrScale(float scale);
        [DllImport(LIB, EntryPoint = "stbi_load")]
        public static extern IntPtr Load(string filename, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_16")]
        public static extern IntPtr Load16(string filename, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_16_from_callbacks")]
        public static extern IntPtr Load16FromCallbacks(IOCallbacks[] clbk, IntPtr user, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_16_from_memory")]
        private static extern IntPtr Load16FromMemory(byte[] buffer, int len, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        public static IntPtr Load16FromMemory(byte[] buffer, ref int x, ref int y, ref int channels_in_file, int desired_channels) =>
            Load16FromMemory(buffer, buffer.Length, ref x, ref y, ref channels_in_file, desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_from_callbacks")]
        public static extern IntPtr LoadFromCallbacks(IOCallbacks[] clbk, IntPtr user, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_from_file")]
        public static extern IntPtr LoadFromFile(IntPtr f, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_from_file_16")]
        public static extern IntPtr LoadFromFile16(IntPtr f, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_from_memory")]
        private static extern IntPtr LoadFromMemory(byte[] buffer, int len, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        public static IntPtr LoadFromMemory(byte[] buffer, ref int x, ref int y, ref int channels_in_file, int desired_channels) =>
            LoadFromMemory(buffer, buffer.Length, ref x, ref y, ref channels_in_file, desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_load_gif_from_memory")]
        private static extern IntPtr LoadGifFromMemory(byte[] buffer, int len, ref int[] delays, ref int x, ref int y, ref int z, ref int comp, int req_comp);
        public static IntPtr LoadGifFromMemory(byte[] buffer, ref int[] delays, ref int x, ref int y, ref int z, ref int comp, int req_comp) =>
            LoadGifFromMemory(buffer, buffer.Length, ref delays, ref x, ref y, ref z, ref comp, req_comp);
        [DllImport(LIB, EntryPoint = "stbi_loadf")]
        public static extern float Loadf(string filename, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_loadf_from_callbacks")]
        public static extern float LoadfFromCallbacks(IOCallbacks[] clbk, IntPtr user, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_loadf_from_file")]
        public static extern float LoadfFromFile(IntPtr f, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_loadf_from_memory")]
        private static extern float LoadfFromMemory(byte[] buffer, int len, ref int x, ref int y, ref int channels_in_file, int desired_channels);
        public static float LoadfFromMemory(byte[] buffer, ref int x, ref int y, ref int channels_in_file, int desired_channels) =>
            LoadfFromMemory(buffer, buffer.Length, ref x, ref y, ref channels_in_file, desired_channels);
        [DllImport(LIB, EntryPoint = "stbi_set_flip_vertically_on_load")]
        public static extern void SetFlipVerticallyOnLoad(int flag_true_if_should_flip);
        [DllImport(LIB, EntryPoint = "stbi_set_flip_vertically_on_load_thread")]
        public static extern void SetFlipVerticallyOnLoadThread(int flag_true_if_should_flip);
        [DllImport(LIB, EntryPoint = "stbi_set_unpremultiply_on_load")]
        public static extern void SetUnpremultiplyOnLoad(int flag_true_if_should_unpremultiply);
        [DllImport(LIB, EntryPoint = "stbi_zlib_decode_buffer")]
        private static extern int ZlibDecodeBuffer(sbyte[] obuffer, int olen, sbyte[] ibuffer, int ilen);
        public static int ZlibDecodeBuffer(sbyte[] obuffer, sbyte[] ibuffer) =>
            ZlibDecodeBuffer(obuffer, obuffer.Length, ibuffer, ibuffer.Length);
        [DllImport(LIB, EntryPoint = "stbi_zlib_decode_malloc")]
        private static extern IntPtr ZlibDecodeMalloc(sbyte[] buffer, int len, ref int outlen);
        public static IntPtr ZlibDecodeMalloc(sbyte[] buffer, ref int outlen) =>
            ZlibDecodeMalloc(buffer, buffer.Length, ref outlen);
        [DllImport(LIB, EntryPoint = "stbi_zlib_decode_malloc_guesssize")]
        private static extern IntPtr ZlibDecodeMallocGuesssize(sbyte[] buffer, int len, int initial_size, ref int outlen);
        public static IntPtr ZlibDecodeMallocGuesssize(sbyte[] buffer, int initial_size, ref int outlen) =>
            ZlibDecodeMallocGuesssize(buffer, buffer.Length, initial_size, ref outlen);
        [DllImport(LIB, EntryPoint = "stbi_zlib_decode_malloc_guesssize_headerflag")]
        private static extern IntPtr ZlibDecodeMallocGuesssizeHeaderflag(sbyte[] buffer, int len, int initial_size, ref int outlen, int parse_header);
        public static IntPtr ZlibDecodeMallocGuesssizeHeaderflag(sbyte[] buffer, int initial_size, ref int outlen, int parse_header) =>
            ZlibDecodeMallocGuesssizeHeaderflag(buffer, buffer.Length, initial_size, ref outlen, parse_header);
        [DllImport(LIB, EntryPoint = "stbi_zlib_decode_noheader_buffer")]
        private static extern int ZlibDecodeNoheaderBuffer(sbyte[] obuffer, int olen, sbyte[] ibuffer, int ilen);
        public static int ZlibDecodeNoheaderBuffer(sbyte[] obuffer, sbyte[] ibuffer) =>
            ZlibDecodeNoheaderBuffer(obuffer, obuffer.Length, ibuffer, ibuffer.Length);
        [DllImport(LIB, EntryPoint = "stbi_zlib_decode_noheader_malloc")]
        private static extern IntPtr ZlibDecodeNoheaderMalloc(sbyte[] buffer, int len, ref int outlen);
        public static IntPtr ZlibDecodeNoheaderMalloc(sbyte[] buffer, ref int outlen) =>
            ZlibDecodeNoheaderMalloc(buffer, buffer.Length, ref outlen);
    }
}

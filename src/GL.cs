using System;
using System.Runtime.InteropServices;

namespace GLCs
{
    public static class GL
    {
        public const int VERSION_MAJOR = 1, VERSION_MINOR = 5;
        [DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress", CallingConvention = CallingConvention.StdCall), Nullable]
        private static extern IntPtr wglGetProcAddress(string lpszProc);
        private static T getDelegate<T>(string lpszProc)
        {
            return Marshal.GetDelegateForFunctionPointer<T>(wglGetProcAddress(lpszProc));
        }
        #region Constants

        public const uint VERSION_1_1 = 1;
        public const uint ZERO = 0;
        public const byte FALSE = 0;
        public const uint LOGIC_OP = 0x0BF1;
        public const uint NONE = 0;
        public const uint TEXTURE_COMPONENTS = 0x1003;
        public const uint NO_ERROR = 0;
        public const uint POINTS = 0x0000;
        public const uint CURRENT_BIT = 0x00000001;
        public const byte TRUE = 1;
        public const uint ONE = 1;
        public const uint CLIENT_PIXEL_STORE_BIT = 0x00000001;
        public const uint LINES = 0x0001;
        public const uint LINE_LOOP = 0x0002;
        public const uint POINT_BIT = 0x00000002;
        public const uint CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
        public const uint LINE_STRIP = 0x0003;
        public const uint LINE_BIT = 0x00000004;
        public const uint TRIANGLES = 0x0004;
        public const uint TRIANGLE_STRIP = 0x0005;
        public const uint TRIANGLE_FAN = 0x0006;
        public const uint QUADS = 0x0007;
        public const uint QUAD_STRIP = 0x0008;
        public const uint POLYGON_BIT = 0x00000008;
        public const uint POLYGON = 0x0009;
        public const uint POLYGON_STIPPLE_BIT = 0x00000010;
        public const uint PIXEL_MODE_BIT = 0x00000020;
        public const uint LIGHTING_BIT = 0x00000040;
        public const uint FOG_BIT = 0x00000080;
        public const uint DEPTH_BUFFER_BIT = 0x00000100;
        public const uint ACCUM = 0x0100;
        public const uint LOAD = 0x0101;
        public const uint RETURN = 0x0102;
        public const uint MULT = 0x0103;
        public const uint ADD = 0x0104;
        public const uint NEVER = 0x0200;
        public const uint ACCUM_BUFFER_BIT = 0x00000200;
        public const uint LESS = 0x0201;
        public const uint EQUAL = 0x0202;
        public const uint LEQUAL = 0x0203;
        public const uint GREATER = 0x0204;
        public const uint NOTEQUAL = 0x0205;
        public const uint GEQUAL = 0x0206;
        public const uint ALWAYS = 0x0207;
        public const uint SRC_COLOR = 0x0300;
        public const uint ONE_MINUS_SRC_COLOR = 0x0301;
        public const uint SRC_ALPHA = 0x0302;
        public const uint ONE_MINUS_SRC_ALPHA = 0x0303;
        public const uint DST_ALPHA = 0x0304;
        public const uint ONE_MINUS_DST_ALPHA = 0x0305;
        public const uint DST_COLOR = 0x0306;
        public const uint ONE_MINUS_DST_COLOR = 0x0307;
        public const uint SRC_ALPHA_SATURATE = 0x0308;
        public const uint STENCIL_BUFFER_BIT = 0x00000400;
        public const uint FRONT_LEFT = 0x0400;
        public const uint FRONT_RIGHT = 0x0401;
        public const uint BACK_LEFT = 0x0402;
        public const uint BACK_RIGHT = 0x0403;
        public const uint FRONT = 0x0404;
        public const uint BACK = 0x0405;
        public const uint LEFT = 0x0406;
        public const uint RIGHT = 0x0407;
        public const uint FRONT_AND_BACK = 0x0408;
        public const uint AUX0 = 0x0409;
        public const uint AUX1 = 0x040A;
        public const uint AUX2 = 0x040B;
        public const uint AUX3 = 0x040C;
        public const uint INVALID_ENUM = 0x0500;
        public const uint INVALID_VALUE = 0x0501;
        public const uint INVALID_OPERATION = 0x0502;
        public const uint STACK_OVERFLOW = 0x0503;
        public const uint STACK_UNDERFLOW = 0x0504;
        public const uint OUT_OF_MEMORY = 0x0505;
        public const uint _2D = 0x0600;
        public const uint _3D = 0x0601;
        public const uint _3D_COLOR = 0x0602;
        public const uint _3D_COLOR_TEXTURE = 0x0603;
        public const uint _4D_COLOR_TEXTURE = 0x0604;
        public const uint PASS_THROUGH_TOKEN = 0x0700;
        public const uint POINT_TOKEN = 0x0701;
        public const uint LINE_TOKEN = 0x0702;
        public const uint POLYGON_TOKEN = 0x0703;
        public const uint BITMAP_TOKEN = 0x0704;
        public const uint DRAW_PIXEL_TOKEN = 0x0705;
        public const uint COPY_PIXEL_TOKEN = 0x0706;
        public const uint LINE_RESET_TOKEN = 0x0707;
        public const uint EXP = 0x0800;
        public const uint VIEWPORT_BIT = 0x00000800;
        public const uint EXP2 = 0x0801;
        public const uint CW = 0x0900;
        public const uint CCW = 0x0901;
        public const uint COEFF = 0x0A00;
        public const uint ORDER = 0x0A01;
        public const uint DOMAIN = 0x0A02;
        public const uint CURRENT_COLOR = 0x0B00;
        public const uint CURRENT_INDEX = 0x0B01;
        public const uint CURRENT_NORMAL = 0x0B02;
        public const uint CURRENT_TEXTURE_COORDS = 0x0B03;
        public const uint CURRENT_RASTER_COLOR = 0x0B04;
        public const uint CURRENT_RASTER_INDEX = 0x0B05;
        public const uint CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
        public const uint CURRENT_RASTER_POSITION = 0x0B07;
        public const uint CURRENT_RASTER_POSITION_VALID = 0x0B08;
        public const uint CURRENT_RASTER_DISTANCE = 0x0B09;
        public const uint POINT_SMOOTH = 0x0B10;
        public const uint POINT_SIZE = 0x0B11;
        public const uint POINT_SIZE_RANGE = 0x0B12;
        public const uint POINT_SIZE_GRANULARITY = 0x0B13;
        public const uint LINE_SMOOTH = 0x0B20;
        public const uint LINE_WIDTH = 0x0B21;
        public const uint LINE_WIDTH_RANGE = 0x0B22;
        public const uint LINE_WIDTH_GRANULARITY = 0x0B23;
        public const uint LINE_STIPPLE = 0x0B24;
        public const uint LINE_STIPPLE_PATTERN = 0x0B25;
        public const uint LINE_STIPPLE_REPEAT = 0x0B26;
        public const uint LIST_MODE = 0x0B30;
        public const uint MAX_LIST_NESTING = 0x0B31;
        public const uint LIST_BASE = 0x0B32;
        public const uint LIST_INDEX = 0x0B33;
        public const uint POLYGON_MODE = 0x0B40;
        public const uint POLYGON_SMOOTH = 0x0B41;
        public const uint POLYGON_STIPPLE = 0x0B42;
        public const uint EDGE_FLAG = 0x0B43;
        public const uint CULL_FACE = 0x0B44;
        public const uint CULL_FACE_MODE = 0x0B45;
        public const uint FRONT_FACE = 0x0B46;
        public const uint LIGHTING = 0x0B50;
        public const uint LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
        public const uint LIGHT_MODEL_TWO_SIDE = 0x0B52;
        public const uint LIGHT_MODEL_AMBIENT = 0x0B53;
        public const uint SHADE_MODEL = 0x0B54;
        public const uint COLOR_MATERIAL_FACE = 0x0B55;
        public const uint COLOR_MATERIAL_PARAMETER = 0x0B56;
        public const uint COLOR_MATERIAL = 0x0B57;
        public const uint FOG = 0x0B60;
        public const uint FOG_INDEX = 0x0B61;
        public const uint FOG_DENSITY = 0x0B62;
        public const uint FOG_START = 0x0B63;
        public const uint FOG_END = 0x0B64;
        public const uint FOG_MODE = 0x0B65;
        public const uint FOG_COLOR = 0x0B66;
        public const uint DEPTH_RANGE = 0x0B70;
        public const uint DEPTH_TEST = 0x0B71;
        public const uint DEPTH_WRITEMASK = 0x0B72;
        public const uint DEPTH_CLEAR_VALUE = 0x0B73;
        public const uint DEPTH_FUNC = 0x0B74;
        public const uint ACCUM_CLEAR_VALUE = 0x0B80;
        public const uint STENCIL_TEST = 0x0B90;
        public const uint STENCIL_CLEAR_VALUE = 0x0B91;
        public const uint STENCIL_FUNC = 0x0B92;
        public const uint STENCIL_VALUE_MASK = 0x0B93;
        public const uint STENCIL_FAIL = 0x0B94;
        public const uint STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const uint STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const uint STENCIL_REF = 0x0B97;
        public const uint STENCIL_WRITEMASK = 0x0B98;
        public const uint MATRIX_MODE = 0x0BA0;
        public const uint NORMALIZE = 0x0BA1;
        public const uint VIEWPORT = 0x0BA2;
        public const uint MODELVIEW_STACK_DEPTH = 0x0BA3;
        public const uint PROJECTION_STACK_DEPTH = 0x0BA4;
        public const uint TEXTURE_STACK_DEPTH = 0x0BA5;
        public const uint MODELVIEW_MATRIX = 0x0BA6;
        public const uint PROJECTION_MATRIX = 0x0BA7;
        public const uint TEXTURE_MATRIX = 0x0BA8;
        public const uint ATTRIB_STACK_DEPTH = 0x0BB0;
        public const uint CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
        public const uint ALPHA_TEST = 0x0BC0;
        public const uint ALPHA_TEST_FUNC = 0x0BC1;
        public const uint ALPHA_TEST_REF = 0x0BC2;
        public const uint DITHER = 0x0BD0;
        public const uint BLEND_DST = 0x0BE0;
        public const uint BLEND_SRC = 0x0BE1;
        public const uint BLEND = 0x0BE2;
        public const uint LOGIC_OP_MODE = 0x0BF0;
        public const uint INDEX_LOGIC_OP = 0x0BF1;
        public const uint COLOR_LOGIC_OP = 0x0BF2;
        public const uint AUX_BUFFERS = 0x0C00;
        public const uint DRAW_BUFFER = 0x0C01;
        public const uint READ_BUFFER = 0x0C02;
        public const uint SCISSOR_BOX = 0x0C10;
        public const uint SCISSOR_TEST = 0x0C11;
        public const uint INDEX_CLEAR_VALUE = 0x0C20;
        public const uint INDEX_WRITEMASK = 0x0C21;
        public const uint COLOR_CLEAR_VALUE = 0x0C22;
        public const uint COLOR_WRITEMASK = 0x0C23;
        public const uint INDEX_MODE = 0x0C30;
        public const uint RGBA_MODE = 0x0C31;
        public const uint DOUBLEBUFFER = 0x0C32;
        public const uint STEREO = 0x0C33;
        public const uint RENDER_MODE = 0x0C40;
        public const uint PERSPECTIVE_CORRECTION_HINT = 0x0C50;
        public const uint POINT_SMOOTH_HINT = 0x0C51;
        public const uint LINE_SMOOTH_HINT = 0x0C52;
        public const uint POLYGON_SMOOTH_HINT = 0x0C53;
        public const uint FOG_HINT = 0x0C54;
        public const uint TEXTURE_GEN_S = 0x0C60;
        public const uint TEXTURE_GEN_T = 0x0C61;
        public const uint TEXTURE_GEN_R = 0x0C62;
        public const uint TEXTURE_GEN_Q = 0x0C63;
        public const uint PIXEL_MAP_I_TO_I = 0x0C70;
        public const uint PIXEL_MAP_S_TO_S = 0x0C71;
        public const uint PIXEL_MAP_I_TO_R = 0x0C72;
        public const uint PIXEL_MAP_I_TO_G = 0x0C73;
        public const uint PIXEL_MAP_I_TO_B = 0x0C74;
        public const uint PIXEL_MAP_I_TO_A = 0x0C75;
        public const uint PIXEL_MAP_R_TO_R = 0x0C76;
        public const uint PIXEL_MAP_G_TO_G = 0x0C77;
        public const uint PIXEL_MAP_B_TO_B = 0x0C78;
        public const uint PIXEL_MAP_A_TO_A = 0x0C79;
        public const uint PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
        public const uint PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
        public const uint PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
        public const uint PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
        public const uint PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
        public const uint PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
        public const uint PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
        public const uint PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
        public const uint PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
        public const uint PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
        public const uint UNPACK_SWAP_BYTES = 0x0CF0;
        public const uint UNPACK_LSB_FIRST = 0x0CF1;
        public const uint UNPACK_ROW_LENGTH = 0x0CF2;
        public const uint UNPACK_SKIP_ROWS = 0x0CF3;
        public const uint UNPACK_SKIP_PIXELS = 0x0CF4;
        public const uint UNPACK_ALIGNMENT = 0x0CF5;
        public const uint PACK_SWAP_BYTES = 0x0D00;
        public const uint PACK_LSB_FIRST = 0x0D01;
        public const uint PACK_ROW_LENGTH = 0x0D02;
        public const uint PACK_SKIP_ROWS = 0x0D03;
        public const uint PACK_SKIP_PIXELS = 0x0D04;
        public const uint PACK_ALIGNMENT = 0x0D05;
        public const uint MAP_COLOR = 0x0D10;
        public const uint MAP_STENCIL = 0x0D11;
        public const uint INDEX_SHIFT = 0x0D12;
        public const uint INDEX_OFFSET = 0x0D13;
        public const uint RED_SCALE = 0x0D14;
        public const uint RED_BIAS = 0x0D15;
        public const uint ZOOM_X = 0x0D16;
        public const uint ZOOM_Y = 0x0D17;
        public const uint GREEN_SCALE = 0x0D18;
        public const uint GREEN_BIAS = 0x0D19;
        public const uint BLUE_SCALE = 0x0D1A;
        public const uint BLUE_BIAS = 0x0D1B;
        public const uint ALPHA_SCALE = 0x0D1C;
        public const uint ALPHA_BIAS = 0x0D1D;
        public const uint DEPTH_SCALE = 0x0D1E;
        public const uint DEPTH_BIAS = 0x0D1F;
        public const uint MAX_EVAL_ORDER = 0x0D30;
        public const uint MAX_LIGHTS = 0x0D31;
        public const uint MAX_CLIP_PLANES = 0x0D32;
        public const uint MAX_TEXTURE_SIZE = 0x0D33;
        public const uint MAX_PIXEL_MAP_TABLE = 0x0D34;
        public const uint MAX_ATTRIB_STACK_DEPTH = 0x0D35;
        public const uint MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
        public const uint MAX_NAME_STACK_DEPTH = 0x0D37;
        public const uint MAX_PROJECTION_STACK_DEPTH = 0x0D38;
        public const uint MAX_TEXTURE_STACK_DEPTH = 0x0D39;
        public const uint MAX_VIEWPORT_DIMS = 0x0D3A;
        public const uint MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
        public const uint SUBPIXEL_BITS = 0x0D50;
        public const uint INDEX_BITS = 0x0D51;
        public const uint RED_BITS = 0x0D52;
        public const uint GREEN_BITS = 0x0D53;
        public const uint BLUE_BITS = 0x0D54;
        public const uint ALPHA_BITS = 0x0D55;
        public const uint DEPTH_BITS = 0x0D56;
        public const uint STENCIL_BITS = 0x0D57;
        public const uint ACCUM_RED_BITS = 0x0D58;
        public const uint ACCUM_GREEN_BITS = 0x0D59;
        public const uint ACCUM_BLUE_BITS = 0x0D5A;
        public const uint ACCUM_ALPHA_BITS = 0x0D5B;
        public const uint NAME_STACK_DEPTH = 0x0D70;
        public const uint AUTO_NORMAL = 0x0D80;
        public const uint MAP1_COLOR_4 = 0x0D90;
        public const uint MAP1_INDEX = 0x0D91;
        public const uint MAP1_NORMAL = 0x0D92;
        public const uint MAP1_TEXTURE_COORD_1 = 0x0D93;
        public const uint MAP1_TEXTURE_COORD_2 = 0x0D94;
        public const uint MAP1_TEXTURE_COORD_3 = 0x0D95;
        public const uint MAP1_TEXTURE_COORD_4 = 0x0D96;
        public const uint MAP1_VERTEX_3 = 0x0D97;
        public const uint MAP1_VERTEX_4 = 0x0D98;
        public const uint MAP2_COLOR_4 = 0x0DB0;
        public const uint MAP2_INDEX = 0x0DB1;
        public const uint MAP2_NORMAL = 0x0DB2;
        public const uint MAP2_TEXTURE_COORD_1 = 0x0DB3;
        public const uint MAP2_TEXTURE_COORD_2 = 0x0DB4;
        public const uint MAP2_TEXTURE_COORD_3 = 0x0DB5;
        public const uint MAP2_TEXTURE_COORD_4 = 0x0DB6;
        public const uint MAP2_VERTEX_3 = 0x0DB7;
        public const uint MAP2_VERTEX_4 = 0x0DB8;
        public const uint MAP1_GRID_DOMAIN = 0x0DD0;
        public const uint MAP1_GRID_SEGMENTS = 0x0DD1;
        public const uint MAP2_GRID_DOMAIN = 0x0DD2;
        public const uint MAP2_GRID_SEGMENTS = 0x0DD3;
        public const uint TEXTURE_1D = 0x0DE0;
        public const uint TEXTURE_2D = 0x0DE1;
        public const uint FEEDBACK_BUFFER_POINTER = 0x0DF0;
        public const uint FEEDBACK_BUFFER_SIZE = 0x0DF1;
        public const uint FEEDBACK_BUFFER_TYPE = 0x0DF2;
        public const uint SELECTION_BUFFER_POINTER = 0x0DF3;
        public const uint SELECTION_BUFFER_SIZE = 0x0DF4;
        public const uint TEXTURE_WIDTH = 0x1000;
        public const uint TRANSFORM_BIT = 0x00001000;
        public const uint TEXTURE_HEIGHT = 0x1001;
        public const uint TEXTURE_INTERNAL_FORMAT = 0x1003;
        public const uint TEXTURE_BORDER_COLOR = 0x1004;
        public const uint TEXTURE_BORDER = 0x1005;
        public const uint DONT_CARE = 0x1100;
        public const uint FASTEST = 0x1101;
        public const uint NICEST = 0x1102;
        public const uint AMBIENT = 0x1200;
        public const uint DIFFUSE = 0x1201;
        public const uint SPECULAR = 0x1202;
        public const uint POSITION = 0x1203;
        public const uint SPOT_DIRECTION = 0x1204;
        public const uint SPOT_EXPONENT = 0x1205;
        public const uint SPOT_CUTOFF = 0x1206;
        public const uint CONSTANT_ATTENUATION = 0x1207;
        public const uint LINEAR_ATTENUATION = 0x1208;
        public const uint QUADRATIC_ATTENUATION = 0x1209;
        public const uint COMPILE = 0x1300;
        public const uint COMPILE_AND_EXECUTE = 0x1301;
        public const uint BYTE = 0x1400;
        public const uint UNSIGNED_BYTE = 0x1401;
        public const uint SHORT = 0x1402;
        public const uint UNSIGNED_SHORT = 0x1403;
        public const uint INT = 0x1404;
        public const uint UNSIGNED_INT = 0x1405;
        public const uint FLOAT = 0x1406;
        public const uint _2_BYTES = 0x1407;
        public const uint _3_BYTES = 0x1408;
        public const uint _4_BYTES = 0x1409;
        public const uint DOUBLE = 0x140A;
        public const uint CLEAR = 0x1500;
        public const uint AND = 0x1501;
        public const uint AND_REVERSE = 0x1502;
        public const uint COPY = 0x1503;
        public const uint AND_INVERTED = 0x1504;
        public const uint NOOP = 0x1505;
        public const uint XOR = 0x1506;
        public const uint OR = 0x1507;
        public const uint NOR = 0x1508;
        public const uint EQUIV = 0x1509;
        public const uint INVERT = 0x150A;
        public const uint OR_REVERSE = 0x150B;
        public const uint COPY_INVERTED = 0x150C;
        public const uint OR_INVERTED = 0x150D;
        public const uint NAND = 0x150E;
        public const uint SET = 0x150F;
        public const uint EMISSION = 0x1600;
        public const uint SHININESS = 0x1601;
        public const uint AMBIENT_AND_DIFFUSE = 0x1602;
        public const uint COLOR_INDEXES = 0x1603;
        public const uint MODELVIEW = 0x1700;
        public const uint PROJECTION = 0x1701;
        public const uint TEXTURE = 0x1702;
        public const uint COLOR = 0x1800;
        public const uint DEPTH = 0x1801;
        public const uint STENCIL = 0x1802;
        public const uint COLOR_INDEX = 0x1900;
        public const uint STENCIL_INDEX = 0x1901;
        public const uint DEPTH_COMPONENT = 0x1902;
        public const uint RED = 0x1903;
        public const uint GREEN = 0x1904;
        public const uint BLUE = 0x1905;
        public const uint ALPHA = 0x1906;
        public const uint RGB = 0x1907;
        public const uint RGBA = 0x1908;
        public const uint LUMINANCE = 0x1909;
        public const uint LUMINANCE_ALPHA = 0x190A;
        public const uint BITMAP = 0x1A00;
        public const uint POINT = 0x1B00;
        public const uint LINE = 0x1B01;
        public const uint FILL = 0x1B02;
        public const uint RENDER = 0x1C00;
        public const uint FEEDBACK = 0x1C01;
        public const uint SELECT = 0x1C02;
        public const uint FLAT = 0x1D00;
        public const uint SMOOTH = 0x1D01;
        public const uint KEEP = 0x1E00;
        public const uint REPLACE = 0x1E01;
        public const uint INCR = 0x1E02;
        public const uint DECR = 0x1E03;
        public const uint VENDOR = 0x1F00;
        public const uint RENDERER = 0x1F01;
        public const uint VERSION = 0x1F02;
        public const uint EXTENSIONS = 0x1F03;
        public const uint S = 0x2000;
        public const uint ENABLE_BIT = 0x00002000;
        public const uint T = 0x2001;
        public const uint R = 0x2002;
        public const uint Q = 0x2003;
        public const uint MODULATE = 0x2100;
        public const uint DECAL = 0x2101;
        public const uint TEXTURE_ENV_MODE = 0x2200;
        public const uint TEXTURE_ENV_COLOR = 0x2201;
        public const uint TEXTURE_ENV = 0x2300;
        public const uint EYE_LINEAR = 0x2400;
        public const uint OBJECT_LINEAR = 0x2401;
        public const uint SPHERE_MAP = 0x2402;
        public const uint TEXTURE_GEN_MODE = 0x2500;
        public const uint OBJECT_PLANE = 0x2501;
        public const uint EYE_PLANE = 0x2502;
        public const uint NEAREST = 0x2600;
        public const uint LINEAR = 0x2601;
        public const uint NEAREST_MIPMAP_NEAREST = 0x2700;
        public const uint LINEAR_MIPMAP_NEAREST = 0x2701;
        public const uint NEAREST_MIPMAP_LINEAR = 0x2702;
        public const uint LINEAR_MIPMAP_LINEAR = 0x2703;
        public const uint TEXTURE_MAG_FILTER = 0x2800;
        public const uint TEXTURE_MIN_FILTER = 0x2801;
        public const uint TEXTURE_WRAP_S = 0x2802;
        public const uint TEXTURE_WRAP_T = 0x2803;
        public const uint CLAMP = 0x2900;
        public const uint REPEAT = 0x2901;
        public const uint POLYGON_OFFSET_UNITS = 0x2A00;
        public const uint POLYGON_OFFSET_POINT = 0x2A01;
        public const uint POLYGON_OFFSET_LINE = 0x2A02;
        public const uint R3_G3_B2 = 0x2A10;
        public const uint V2F = 0x2A20;
        public const uint V3F = 0x2A21;
        public const uint C4UB_V2F = 0x2A22;
        public const uint C4UB_V3F = 0x2A23;
        public const uint C3F_V3F = 0x2A24;
        public const uint N3F_V3F = 0x2A25;
        public const uint C4F_N3F_V3F = 0x2A26;
        public const uint T2F_V3F = 0x2A27;
        public const uint T4F_V4F = 0x2A28;
        public const uint T2F_C4UB_V3F = 0x2A29;
        public const uint T2F_C3F_V3F = 0x2A2A;
        public const uint T2F_N3F_V3F = 0x2A2B;
        public const uint T2F_C4F_N3F_V3F = 0x2A2C;
        public const uint T4F_C4F_N3F_V4F = 0x2A2D;
        public const uint CLIP_PLANE0 = 0x3000;
        public const uint CLIP_PLANE1 = 0x3001;
        public const uint CLIP_PLANE2 = 0x3002;
        public const uint CLIP_PLANE3 = 0x3003;
        public const uint CLIP_PLANE4 = 0x3004;
        public const uint CLIP_PLANE5 = 0x3005;
        public const uint LIGHT0 = 0x4000;
        public const uint COLOR_BUFFER_BIT = 0x00004000;
        public const uint LIGHT1 = 0x4001;
        public const uint LIGHT2 = 0x4002;
        public const uint LIGHT3 = 0x4003;
        public const uint LIGHT4 = 0x4004;
        public const uint LIGHT5 = 0x4005;
        public const uint LIGHT6 = 0x4006;
        public const uint LIGHT7 = 0x4007;
        public const uint HINT_BIT = 0x00008000;
        public const uint POLYGON_OFFSET_FILL = 0x8037;
        public const uint POLYGON_OFFSET_FACTOR = 0x8038;
        public const uint ALPHA4 = 0x803B;
        public const uint ALPHA8 = 0x803C;
        public const uint ALPHA12 = 0x803D;
        public const uint ALPHA16 = 0x803E;
        public const uint LUMINANCE4 = 0x803F;
        public const uint LUMINANCE8 = 0x8040;
        public const uint LUMINANCE12 = 0x8041;
        public const uint LUMINANCE16 = 0x8042;
        public const uint LUMINANCE4_ALPHA4 = 0x8043;
        public const uint LUMINANCE6_ALPHA2 = 0x8044;
        public const uint LUMINANCE8_ALPHA8 = 0x8045;
        public const uint LUMINANCE12_ALPHA4 = 0x8046;
        public const uint LUMINANCE12_ALPHA12 = 0x8047;
        public const uint LUMINANCE16_ALPHA16 = 0x8048;
        public const uint INTENSITY = 0x8049;
        public const uint INTENSITY4 = 0x804A;
        public const uint INTENSITY8 = 0x804B;
        public const uint INTENSITY12 = 0x804C;
        public const uint INTENSITY16 = 0x804D;
        public const uint RGB4 = 0x804F;
        public const uint RGB5 = 0x8050;
        public const uint RGB8 = 0x8051;
        public const uint RGB10 = 0x8052;
        public const uint RGB12 = 0x8053;
        public const uint RGB16 = 0x8054;
        public const uint RGBA2 = 0x8055;
        public const uint RGBA4 = 0x8056;
        public const uint RGB5_A1 = 0x8057;
        public const uint RGBA8 = 0x8058;
        public const uint RGB10_A2 = 0x8059;
        public const uint RGBA12 = 0x805A;
        public const uint RGBA16 = 0x805B;
        public const uint TEXTURE_RED_SIZE = 0x805C;
        public const uint TEXTURE_GREEN_SIZE = 0x805D;
        public const uint TEXTURE_BLUE_SIZE = 0x805E;
        public const uint TEXTURE_ALPHA_SIZE = 0x805F;
        public const uint TEXTURE_LUMINANCE_SIZE = 0x8060;
        public const uint TEXTURE_INTENSITY_SIZE = 0x8061;
        public const uint PROXY_TEXTURE_1D = 0x8063;
        public const uint PROXY_TEXTURE_2D = 0x8064;
        public const uint TEXTURE_PRIORITY = 0x8066;
        public const uint TEXTURE_RESIDENT = 0x8067;
        public const uint TEXTURE_BINDING_1D = 0x8068;
        public const uint TEXTURE_BINDING_2D = 0x8069;
        public const uint VERTEX_ARRAY = 0x8074;
        public const uint NORMAL_ARRAY = 0x8075;
        public const uint COLOR_ARRAY = 0x8076;
        public const uint INDEX_ARRAY = 0x8077;
        public const uint TEXTURE_COORD_ARRAY = 0x8078;
        public const uint EDGE_FLAG_ARRAY = 0x8079;
        public const uint VERTEX_ARRAY_SIZE = 0x807A;
        public const uint VERTEX_ARRAY_TYPE = 0x807B;
        public const uint VERTEX_ARRAY_STRIDE = 0x807C;
        public const uint NORMAL_ARRAY_TYPE = 0x807E;
        public const uint NORMAL_ARRAY_STRIDE = 0x807F;
        public const uint COLOR_ARRAY_SIZE = 0x8081;
        public const uint COLOR_ARRAY_TYPE = 0x8082;
        public const uint COLOR_ARRAY_STRIDE = 0x8083;
        public const uint INDEX_ARRAY_TYPE = 0x8085;
        public const uint INDEX_ARRAY_STRIDE = 0x8086;
        public const uint TEXTURE_COORD_ARRAY_SIZE = 0x8088;
        public const uint TEXTURE_COORD_ARRAY_TYPE = 0x8089;
        public const uint TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
        public const uint EDGE_FLAG_ARRAY_STRIDE = 0x808C;
        public const uint VERTEX_ARRAY_POINTER = 0x808E;
        public const uint NORMAL_ARRAY_POINTER = 0x808F;
        public const uint COLOR_ARRAY_POINTER = 0x8090;
        public const uint INDEX_ARRAY_POINTER = 0x8091;
        public const uint TEXTURE_COORD_ARRAY_POINTER = 0x8092;
        public const uint EDGE_FLAG_ARRAY_POINTER = 0x8093;
        public const uint COLOR_INDEX1_EXT = 0x80E2;
        public const uint COLOR_INDEX2_EXT = 0x80E3;
        public const uint COLOR_INDEX4_EXT = 0x80E4;
        public const uint COLOR_INDEX8_EXT = 0x80E5;
        public const uint COLOR_INDEX12_EXT = 0x80E6;
        public const uint COLOR_INDEX16_EXT = 0x80E7;
        public const uint EVAL_BIT = 0x00010000;
        public const uint LIST_BIT = 0x00020000;
        public const uint TEXTURE_BIT = 0x00040000;
        public const uint SCISSOR_BIT = 0x00080000;
        public const uint ALL_ATTRIB_BITS = 0x000fffff;
        public const uint CLIENT_ALL_ATTRIB_BITS = 0xffffffff;
        public const uint VERSION_1_2 = 1;
        public const uint SMOOTH_POINT_SIZE_RANGE = 0x0B12;
        public const uint SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
        public const uint SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
        public const uint SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const uint UNSIGNED_BYTE_3_3_2 = 0x8032;
        public const uint UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const uint UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const uint UNSIGNED_INT_8_8_8_8 = 0x8035;
        public const uint UNSIGNED_INT_10_10_10_2 = 0x8036;
        public const uint RESCALE_NORMAL = 0x803A;
        public const uint TEXTURE_BINDING_3D = 0x806A;
        public const uint PACK_SKIP_IMAGES = 0x806B;
        public const uint PACK_IMAGE_HEIGHT = 0x806C;
        public const uint UNPACK_SKIP_IMAGES = 0x806D;
        public const uint UNPACK_IMAGE_HEIGHT = 0x806E;
        public const uint TEXTURE_3D = 0x806F;
        public const uint PROXY_TEXTURE_3D = 0x8070;
        public const uint TEXTURE_DEPTH = 0x8071;
        public const uint TEXTURE_WRAP_R = 0x8072;
        public const uint MAX_3D_TEXTURE_SIZE = 0x8073;
        public const uint BGR = 0x80E0;
        public const uint BGRA = 0x80E1;
        public const uint MAX_ELEMENTS_VERTICES = 0x80E8;
        public const uint MAX_ELEMENTS_INDICES = 0x80E9;
        public const uint CLAMP_TO_EDGE = 0x812F;
        public const uint TEXTURE_MIN_LOD = 0x813A;
        public const uint TEXTURE_MAX_LOD = 0x813B;
        public const uint TEXTURE_BASE_LEVEL = 0x813C;
        public const uint TEXTURE_MAX_LEVEL = 0x813D;
        public const uint LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
        public const uint SINGLE_COLOR = 0x81F9;
        public const uint SEPARATE_SPECULAR_COLOR = 0x81FA;
        public const uint UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        public const uint UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const uint UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const uint UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const uint UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const uint UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        public const uint ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const uint ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const uint VERSION_1_2_1 = 1;
        public const uint VERSION_1_3 = 1;
        public const uint MULTISAMPLE = 0x809D;
        public const uint SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const uint SAMPLE_ALPHA_TO_ONE = 0x809F;
        public const uint SAMPLE_COVERAGE = 0x80A0;
        public const uint SAMPLE_BUFFERS = 0x80A8;
        public const uint SAMPLES = 0x80A9;
        public const uint SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const uint SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const uint CLAMP_TO_BORDER = 0x812D;
        public const uint TEXTURE0 = 0x84C0;
        public const uint TEXTURE1 = 0x84C1;
        public const uint TEXTURE2 = 0x84C2;
        public const uint TEXTURE3 = 0x84C3;
        public const uint TEXTURE4 = 0x84C4;
        public const uint TEXTURE5 = 0x84C5;
        public const uint TEXTURE6 = 0x84C6;
        public const uint TEXTURE7 = 0x84C7;
        public const uint TEXTURE8 = 0x84C8;
        public const uint TEXTURE9 = 0x84C9;
        public const uint TEXTURE10 = 0x84CA;
        public const uint TEXTURE11 = 0x84CB;
        public const uint TEXTURE12 = 0x84CC;
        public const uint TEXTURE13 = 0x84CD;
        public const uint TEXTURE14 = 0x84CE;
        public const uint TEXTURE15 = 0x84CF;
        public const uint TEXTURE16 = 0x84D0;
        public const uint TEXTURE17 = 0x84D1;
        public const uint TEXTURE18 = 0x84D2;
        public const uint TEXTURE19 = 0x84D3;
        public const uint TEXTURE20 = 0x84D4;
        public const uint TEXTURE21 = 0x84D5;
        public const uint TEXTURE22 = 0x84D6;
        public const uint TEXTURE23 = 0x84D7;
        public const uint TEXTURE24 = 0x84D8;
        public const uint TEXTURE25 = 0x84D9;
        public const uint TEXTURE26 = 0x84DA;
        public const uint TEXTURE27 = 0x84DB;
        public const uint TEXTURE28 = 0x84DC;
        public const uint TEXTURE29 = 0x84DD;
        public const uint TEXTURE30 = 0x84DE;
        public const uint TEXTURE31 = 0x84DF;
        public const uint ACTIVE_TEXTURE = 0x84E0;
        public const uint CLIENT_ACTIVE_TEXTURE = 0x84E1;
        public const uint MAX_TEXTURE_UNITS = 0x84E2;
        public const uint TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
        public const uint TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
        public const uint TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
        public const uint TRANSPOSE_COLOR_MATRIX = 0x84E6;
        public const uint SUBTRACT = 0x84E7;
        public const uint COMPRESSED_ALPHA = 0x84E9;
        public const uint COMPRESSED_LUMINANCE = 0x84EA;
        public const uint COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
        public const uint COMPRESSED_INTENSITY = 0x84EC;
        public const uint COMPRESSED_RGB = 0x84ED;
        public const uint COMPRESSED_RGBA = 0x84EE;
        public const uint TEXTURE_COMPRESSION_HINT = 0x84EF;
        public const uint NORMAL_MAP = 0x8511;
        public const uint REFLECTION_MAP = 0x8512;
        public const uint TEXTURE_CUBE_MAP = 0x8513;
        public const uint TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const uint PROXY_TEXTURE_CUBE_MAP = 0x851B;
        public const uint MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const uint COMBINE = 0x8570;
        public const uint COMBINE_RGB = 0x8571;
        public const uint COMBINE_ALPHA = 0x8572;
        public const uint RGB_SCALE = 0x8573;
        public const uint ADD_SIGNED = 0x8574;
        public const uint INTERPOLATE = 0x8575;
        public const uint CONSTANT = 0x8576;
        public const uint PRIMARY_COLOR = 0x8577;
        public const uint PREVIOUS = 0x8578;
        public const uint SOURCE0_RGB = 0x8580;
        public const uint SOURCE1_RGB = 0x8581;
        public const uint SOURCE2_RGB = 0x8582;
        public const uint SOURCE0_ALPHA = 0x8588;
        public const uint SOURCE1_ALPHA = 0x8589;
        public const uint SOURCE2_ALPHA = 0x858A;
        public const uint OPERAND0_RGB = 0x8590;
        public const uint OPERAND1_RGB = 0x8591;
        public const uint OPERAND2_RGB = 0x8592;
        public const uint OPERAND0_ALPHA = 0x8598;
        public const uint OPERAND1_ALPHA = 0x8599;
        public const uint OPERAND2_ALPHA = 0x859A;
        public const uint TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        public const uint TEXTURE_COMPRESSED = 0x86A1;
        public const uint NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const uint COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const uint DOT3_RGB = 0x86AE;
        public const uint DOT3_RGBA = 0x86AF;
        public const uint MULTISAMPLE_BIT = 0x20000000;
        public const uint VERSION_1_4 = 1;
        public const uint BLEND_DST_RGB = 0x80C8;
        public const uint BLEND_SRC_RGB = 0x80C9;
        public const uint BLEND_DST_ALPHA = 0x80CA;
        public const uint BLEND_SRC_ALPHA = 0x80CB;
        public const uint POINT_SIZE_MIN = 0x8126;
        public const uint POINT_SIZE_MAX = 0x8127;
        public const uint POINT_FADE_THRESHOLD_SIZE = 0x8128;
        public const uint POINT_DISTANCE_ATTENUATION = 0x8129;
        public const uint GENERATE_MIPMAP = 0x8191;
        public const uint GENERATE_MIPMAP_HINT = 0x8192;
        public const uint DEPTH_COMPONENT16 = 0x81A5;
        public const uint DEPTH_COMPONENT24 = 0x81A6;
        public const uint DEPTH_COMPONENT32 = 0x81A7;
        public const uint MIRRORED_REPEAT = 0x8370;
        public const uint FOG_COORDINATE_SOURCE = 0x8450;
        public const uint FOG_COORDINATE = 0x8451;
        public const uint FRAGMENT_DEPTH = 0x8452;
        public const uint CURRENT_FOG_COORDINATE = 0x8453;
        public const uint FOG_COORDINATE_ARRAY_TYPE = 0x8454;
        public const uint FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
        public const uint FOG_COORDINATE_ARRAY_POINTER = 0x8456;
        public const uint FOG_COORDINATE_ARRAY = 0x8457;
        public const uint COLOR_SUM = 0x8458;
        public const uint CURRENT_SECONDARY_COLOR = 0x8459;
        public const uint SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
        public const uint SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
        public const uint SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
        public const uint SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
        public const uint SECONDARY_COLOR_ARRAY = 0x845E;
        public const uint MAX_TEXTURE_LOD_BIAS = 0x84FD;
        public const uint TEXTURE_FILTER_CONTROL = 0x8500;
        public const uint TEXTURE_LOD_BIAS = 0x8501;
        public const uint INCR_WRAP = 0x8507;
        public const uint DECR_WRAP = 0x8508;
        public const uint TEXTURE_DEPTH_SIZE = 0x884A;
        public const uint DEPTH_TEXTURE_MODE = 0x884B;
        public const uint TEXTURE_COMPARE_MODE = 0x884C;
        public const uint TEXTURE_COMPARE_FUNC = 0x884D;
        public const uint COMPARE_R_TO_TEXTURE = 0x884E;
        public const uint VERSION_1_5 = 1;
        public const uint CURRENT_FOG_COORD = CURRENT_FOG_COORDINATE;
        public const uint FOG_COORD = FOG_COORDINATE;
        public const uint FOG_COORD_ARRAY = FOG_COORDINATE_ARRAY;
        public const uint FOG_COORD_ARRAY_BUFFER_BINDING = FOG_COORDINATE_ARRAY_BUFFER_BINDING;
        public const uint FOG_COORD_ARRAY_POINTER = FOG_COORDINATE_ARRAY_POINTER;
        public const uint FOG_COORD_ARRAY_STRIDE = FOG_COORDINATE_ARRAY_STRIDE;
        public const uint FOG_COORD_ARRAY_TYPE = FOG_COORDINATE_ARRAY_TYPE;
        public const uint FOG_COORD_SRC = FOG_COORDINATE_SOURCE;
        public const uint SRC0_ALPHA = SOURCE0_ALPHA;
        public const uint SRC0_RGB = SOURCE0_RGB;
        public const uint SRC1_ALPHA = SOURCE1_ALPHA;
        public const uint SRC1_RGB = SOURCE1_RGB;
        public const uint SRC2_ALPHA = SOURCE2_ALPHA;
        public const uint SRC2_RGB = SOURCE2_RGB;
        public const uint BUFFER_SIZE = 0x8764;
        public const uint BUFFER_USAGE = 0x8765;
        public const uint QUERY_COUNTER_BITS = 0x8864;
        public const uint CURRENT_QUERY = 0x8865;
        public const uint QUERY_RESULT = 0x8866;
        public const uint QUERY_RESULT_AVAILABLE = 0x8867;
        public const uint ARRAY_BUFFER = 0x8892;
        public const uint ELEMENT_ARRAY_BUFFER = 0x8893;
        public const uint ARRAY_BUFFER_BINDING = 0x8894;
        public const uint ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const uint VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
        public const uint NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
        public const uint COLOR_ARRAY_BUFFER_BINDING = 0x8898;
        public const uint INDEX_ARRAY_BUFFER_BINDING = 0x8899;
        public const uint TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
        public const uint EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
        public const uint SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
        public const uint FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
        public const uint WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
        public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const uint READ_ONLY = 0x88B8;
        public const uint WRITE_ONLY = 0x88B9;
        public const uint READ_WRITE = 0x88BA;
        public const uint BUFFER_ACCESS = 0x88BB;
        public const uint BUFFER_MAPPED = 0x88BC;
        public const uint BUFFER_MAP_POINTER = 0x88BD;
        public const uint STREAM_DRAW = 0x88E0;
        public const uint STREAM_READ = 0x88E1;
        public const uint STREAM_COPY = 0x88E2;
        public const uint STATIC_DRAW = 0x88E4;
        public const uint STATIC_READ = 0x88E5;
        public const uint STATIC_COPY = 0x88E6;
        public const uint DYNAMIC_DRAW = 0x88E8;
        public const uint DYNAMIC_READ = 0x88E9;
        public const uint DYNAMIC_COPY = 0x88EA;
        public const uint SAMPLES_PASSED = 0x8914;
        public const uint VERSION_2_0 = 1;
        public const uint BLEND_EQUATION_RGB = BLEND_EQUATION;
        public const uint VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const uint VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const uint VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const uint VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const uint CURRENT_VERTEX_ATTRIB = 0x8626;
        public const uint VERTEX_PROGRAM_POINT_SIZE = 0x8642;
        public const uint VERTEX_PROGRAM_TWO_SIDE = 0x8643;
        public const uint VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const uint STENCIL_BACK_FUNC = 0x8800;
        public const uint STENCIL_BACK_FAIL = 0x8801;
        public const uint STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const uint STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const uint MAX_DRAW_BUFFERS = 0x8824;
        public const uint DRAW_BUFFER0 = 0x8825;
        public const uint DRAW_BUFFER1 = 0x8826;
        public const uint DRAW_BUFFER2 = 0x8827;
        public const uint DRAW_BUFFER3 = 0x8828;
        public const uint DRAW_BUFFER4 = 0x8829;
        public const uint DRAW_BUFFER5 = 0x882A;
        public const uint DRAW_BUFFER6 = 0x882B;
        public const uint DRAW_BUFFER7 = 0x882C;
        public const uint DRAW_BUFFER8 = 0x882D;
        public const uint DRAW_BUFFER9 = 0x882E;
        public const uint DRAW_BUFFER10 = 0x882F;
        public const uint DRAW_BUFFER11 = 0x8830;
        public const uint DRAW_BUFFER12 = 0x8831;
        public const uint DRAW_BUFFER13 = 0x8832;
        public const uint DRAW_BUFFER14 = 0x8833;
        public const uint DRAW_BUFFER15 = 0x8834;
        public const uint BLEND_EQUATION_ALPHA = 0x883D;
        public const uint POINT_SPRITE = 0x8861;
        public const uint COORD_REPLACE = 0x8862;
        public const uint MAX_VERTEX_ATTRIBS = 0x8869;
        public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const uint MAX_TEXTURE_COORDS = 0x8871;
        public const uint MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const uint FRAGMENT_SHADER = 0x8B30;
        public const uint VERTEX_SHADER = 0x8B31;
        public const uint MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
        public const uint MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
        public const uint MAX_VARYING_FLOATS = 0x8B4B;
        public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const uint SHADER_TYPE = 0x8B4F;
        public const uint FLOAT_VEC2 = 0x8B50;
        public const uint FLOAT_VEC3 = 0x8B51;
        public const uint FLOAT_VEC4 = 0x8B52;
        public const uint INT_VEC2 = 0x8B53;
        public const uint INT_VEC3 = 0x8B54;
        public const uint INT_VEC4 = 0x8B55;
        public const uint BOOL = 0x8B56;
        public const uint BOOL_VEC2 = 0x8B57;
        public const uint BOOL_VEC3 = 0x8B58;
        public const uint BOOL_VEC4 = 0x8B59;
        public const uint FLOAT_MAT2 = 0x8B5A;
        public const uint FLOAT_MAT3 = 0x8B5B;
        public const uint FLOAT_MAT4 = 0x8B5C;
        public const uint SAMPLER_1D = 0x8B5D;
        public const uint SAMPLER_2D = 0x8B5E;
        public const uint SAMPLER_3D = 0x8B5F;
        public const uint SAMPLER_CUBE = 0x8B60;
        public const uint SAMPLER_1D_SHADOW = 0x8B61;
        public const uint SAMPLER_2D_SHADOW = 0x8B62;
        public const uint DELETE_STATUS = 0x8B80;
        public const uint COMPILE_STATUS = 0x8B81;
        public const uint LINK_STATUS = 0x8B82;
        public const uint VALIDATE_STATUS = 0x8B83;
        public const uint INFO_LOG_LENGTH = 0x8B84;
        public const uint ATTACHED_SHADERS = 0x8B85;
        public const uint ACTIVE_UNIFORMS = 0x8B86;
        public const uint ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const uint SHADER_SOURCE_LENGTH = 0x8B88;
        public const uint ACTIVE_ATTRIBUTES = 0x8B89;
        public const uint ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const uint FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
        public const uint SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const uint CURRENT_PROGRAM = 0x8B8D;
        public const uint POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
        public const uint LOWER_LEFT = 0x8CA1;
        public const uint UPPER_LEFT = 0x8CA2;
        public const uint STENCIL_BACK_REF = 0x8CA3;
        public const uint STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const uint STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const uint VERSION_2_1 = 1;
        public const uint CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
        public const uint PIXEL_PACK_BUFFER = 0x88EB;
        public const uint PIXEL_UNPACK_BUFFER = 0x88EC;
        public const uint PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const uint PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const uint FLOAT_MAT2x3 = 0x8B65;
        public const uint FLOAT_MAT2x4 = 0x8B66;
        public const uint FLOAT_MAT3x2 = 0x8B67;
        public const uint FLOAT_MAT3x4 = 0x8B68;
        public const uint FLOAT_MAT4x2 = 0x8B69;
        public const uint FLOAT_MAT4x3 = 0x8B6A;
        public const uint SRGB = 0x8C40;
        public const uint SRGB8 = 0x8C41;
        public const uint SRGB_ALPHA = 0x8C42;
        public const uint SRGB8_ALPHA8 = 0x8C43;
        public const uint SLUMINANCE_ALPHA = 0x8C44;
        public const uint SLUMINANCE8_ALPHA8 = 0x8C45;
        public const uint SLUMINANCE = 0x8C46;
        public const uint SLUMINANCE8 = 0x8C47;
        public const uint COMPRESSED_SRGB = 0x8C48;
        public const uint COMPRESSED_SRGB_ALPHA = 0x8C49;
        public const uint COMPRESSED_SLUMINANCE = 0x8C4A;
        public const uint COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
        public const uint VERSION_3_0 = 1;
        public const uint CLIP_DISTANCE0 = CLIP_PLANE0;
        public const uint CLIP_DISTANCE1 = CLIP_PLANE1;
        public const uint CLIP_DISTANCE2 = CLIP_PLANE2;
        public const uint CLIP_DISTANCE3 = CLIP_PLANE3;
        public const uint CLIP_DISTANCE4 = CLIP_PLANE4;
        public const uint CLIP_DISTANCE5 = CLIP_PLANE5;
        public const uint COMPARE_REF_TO_TEXTURE = COMPARE_R_TO_TEXTURE_ARB;
        public const uint MAX_CLIP_DISTANCES = MAX_CLIP_PLANES;
        public const uint MAX_VARYING_COMPONENTS = MAX_VARYING_FLOATS;
        public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x0001;
        public const uint MAJOR_VERSION = 0x821B;
        public const uint MINOR_VERSION = 0x821C;
        public const uint NUM_EXTENSIONS = 0x821D;
        public const uint CONTEXT_FLAGS = 0x821E;
        public const uint DEPTH_BUFFER = 0x8223;
        public const uint STENCIL_BUFFER = 0x8224;
        public const uint RGBA32F = 0x8814;
        public const uint RGB32F = 0x8815;
        public const uint RGBA16F = 0x881A;
        public const uint RGB16F = 0x881B;
        public const uint VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
        public const uint MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
        public const uint MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
        public const uint MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
        public const uint CLAMP_VERTEX_COLOR = 0x891A;
        public const uint CLAMP_FRAGMENT_COLOR = 0x891B;
        public const uint CLAMP_READ_COLOR = 0x891C;
        public const uint FIXED_ONLY = 0x891D;
        public const uint TEXTURE_RED_TYPE = 0x8C10;
        public const uint TEXTURE_GREEN_TYPE = 0x8C11;
        public const uint TEXTURE_BLUE_TYPE = 0x8C12;
        public const uint TEXTURE_ALPHA_TYPE = 0x8C13;
        public const uint TEXTURE_LUMINANCE_TYPE = 0x8C14;
        public const uint TEXTURE_INTENSITY_TYPE = 0x8C15;
        public const uint TEXTURE_DEPTH_TYPE = 0x8C16;
        public const uint TEXTURE_1D_ARRAY = 0x8C18;
        public const uint PROXY_TEXTURE_1D_ARRAY = 0x8C19;
        public const uint TEXTURE_2D_ARRAY = 0x8C1A;
        public const uint PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
        public const uint TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
        public const uint TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        public const uint R11F_G11F_B10F = 0x8C3A;
        public const uint UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
        public const uint RGB9_E5 = 0x8C3D;
        public const uint UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        public const uint TEXTURE_SHARED_SIZE = 0x8C3F;
        public const uint TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        public const uint TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const uint TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
        public const uint TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
        public const uint PRIMITIVES_GENERATED = 0x8C87;
        public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
        public const uint RASTERIZER_DISCARD = 0x8C89;
        public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        public const uint INTERLEAVED_ATTRIBS = 0x8C8C;
        public const uint SEPARATE_ATTRIBS = 0x8C8D;
        public const uint TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
        public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
        public const uint RGBA32UI = 0x8D70;
        public const uint RGB32UI = 0x8D71;
        public const uint RGBA16UI = 0x8D76;
        public const uint RGB16UI = 0x8D77;
        public const uint RGBA8UI = 0x8D7C;
        public const uint RGB8UI = 0x8D7D;
        public const uint RGBA32I = 0x8D82;
        public const uint RGB32I = 0x8D83;
        public const uint RGBA16I = 0x8D88;
        public const uint RGB16I = 0x8D89;
        public const uint RGBA8I = 0x8D8E;
        public const uint RGB8I = 0x8D8F;
        public const uint RED_INTEGER = 0x8D94;
        public const uint GREEN_INTEGER = 0x8D95;
        public const uint BLUE_INTEGER = 0x8D96;
        public const uint ALPHA_INTEGER = 0x8D97;
        public const uint RGB_INTEGER = 0x8D98;
        public const uint RGBA_INTEGER = 0x8D99;
        public const uint BGR_INTEGER = 0x8D9A;
        public const uint BGRA_INTEGER = 0x8D9B;
        public const uint SAMPLER_1D_ARRAY = 0x8DC0;
        public const uint SAMPLER_2D_ARRAY = 0x8DC1;
        public const uint SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
        public const uint SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
        public const uint SAMPLER_CUBE_SHADOW = 0x8DC5;
        public const uint UNSIGNED_INT_VEC2 = 0x8DC6;
        public const uint UNSIGNED_INT_VEC3 = 0x8DC7;
        public const uint UNSIGNED_INT_VEC4 = 0x8DC8;
        public const uint INT_SAMPLER_1D = 0x8DC9;
        public const uint INT_SAMPLER_2D = 0x8DCA;
        public const uint INT_SAMPLER_3D = 0x8DCB;
        public const uint INT_SAMPLER_CUBE = 0x8DCC;
        public const uint INT_SAMPLER_1D_ARRAY = 0x8DCE;
        public const uint INT_SAMPLER_2D_ARRAY = 0x8DCF;
        public const uint UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
        public const uint UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
        public const uint UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
        public const uint UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
        public const uint UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
        public const uint UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
        public const uint QUERY_WAIT = 0x8E13;
        public const uint QUERY_NO_WAIT = 0x8E14;
        public const uint QUERY_BY_REGION_WAIT = 0x8E15;
        public const uint QUERY_BY_REGION_NO_WAIT = 0x8E16;
        public const uint VERSION_3_1 = 1;
        public const uint TEXTURE_RECTANGLE = 0x84F5;
        public const uint TEXTURE_BINDING_RECTANGLE = 0x84F6;
        public const uint PROXY_TEXTURE_RECTANGLE = 0x84F7;
        public const uint MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
        public const uint SAMPLER_2D_RECT = 0x8B63;
        public const uint SAMPLER_2D_RECT_SHADOW = 0x8B64;
        public const uint TEXTURE_BUFFER = 0x8C2A;
        public const uint MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
        public const uint TEXTURE_BINDING_BUFFER = 0x8C2C;
        public const uint TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        public const uint TEXTURE_BUFFER_FORMAT = 0x8C2E;
        public const uint SAMPLER_BUFFER = 0x8DC2;
        public const uint INT_SAMPLER_2D_RECT = 0x8DCD;
        public const uint INT_SAMPLER_BUFFER = 0x8DD0;
        public const uint UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
        public const uint UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
        public const uint RED_SNORM = 0x8F90;
        public const uint RG_SNORM = 0x8F91;
        public const uint RGB_SNORM = 0x8F92;
        public const uint RGBA_SNORM = 0x8F93;
        public const uint R8_SNORM = 0x8F94;
        public const uint RG8_SNORM = 0x8F95;
        public const uint RGB8_SNORM = 0x8F96;
        public const uint RGBA8_SNORM = 0x8F97;
        public const uint R16_SNORM = 0x8F98;
        public const uint RG16_SNORM = 0x8F99;
        public const uint RGB16_SNORM = 0x8F9A;
        public const uint RGBA16_SNORM = 0x8F9B;
        public const uint SIGNED_NORMALIZED = 0x8F9C;
        public const uint PRIMITIVE_RESTART = 0x8F9D;
        public const uint PRIMITIVE_RESTART_INDEX = 0x8F9E;
        public const uint BUFFER_ACCESS_FLAGS = 0x911F;
        public const uint BUFFER_MAP_LENGTH = 0x9120;
        public const uint BUFFER_MAP_OFFSET = 0x9121;
        public const uint VERSION_3_2 = 1;
        public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;
        public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
        public const uint LINES_ADJACENCY = 0x000A;
        public const uint LINE_STRIP_ADJACENCY = 0x000B;
        public const uint TRIANGLES_ADJACENCY = 0x000C;
        public const uint TRIANGLE_STRIP_ADJACENCY = 0x000D;
        public const uint PROGRAM_POINT_SIZE = 0x8642;
        public const uint GEOMETRY_VERTICES_OUT = 0x8916;
        public const uint GEOMETRY_INPUT_TYPE = 0x8917;
        public const uint GEOMETRY_OUTPUT_TYPE = 0x8918;
        public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
        public const uint FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
        public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
        public const uint GEOMETRY_SHADER = 0x8DD9;
        public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
        public const uint MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        public const uint MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        public const uint MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
        public const uint MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
        public const uint MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        public const uint CONTEXT_PROFILE_MASK = 0x9126;
        public const uint VERSION_3_3 = 1;
        public const uint VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
        public const uint RGB10_A2UI = 0x906F;
        public const uint VERSION_4_0 = 1;
        public const uint SAMPLE_SHADING = 0x8C36;
        public const uint MIN_SAMPLE_SHADING_VALUE = 0x8C37;
        public const uint MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
        public const uint MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
        public const uint MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS = 0x8F9F;
        public const uint TEXTURE_CUBE_MAP_ARRAY = 0x9009;
        public const uint TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        public const uint PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
        public const uint SAMPLER_CUBE_MAP_ARRAY = 0x900C;
        public const uint SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
        public const uint INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
        public const uint UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
        public const uint VERSION_4_1 = 1;
        public const uint VERSION_4_2 = 1;
        public const uint TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const uint TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        public const uint COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
        public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
        public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
        public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
        public const uint COPY_READ_BUFFER_BINDING = 0x8F36;
        public const uint COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const uint VERSION_4_3 = 1;
        public const uint NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
        public const uint VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
        public const uint VERSION_4_4 = 1;
        public const uint PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
        public const uint MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
        public const uint TEXTURE_BUFFER_BINDING = 0x8C2A;
        public const uint VERSION_4_5 = 1;
        public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
        public const uint VERSION_4_6 = 1;
        public const uint CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
        public const uint PARAMETER_BUFFER = 0x80EE;
        public const uint PARAMETER_BUFFER_BINDING = 0x80EF;
        public const uint TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;
        public const uint TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
        public const uint VERTICES_SUBMITTED = 0x82EE;
        public const uint PRIMITIVES_SUBMITTED = 0x82EF;
        public const uint VERTEX_SHADER_INVOCATIONS = 0x82F0;
        public const uint TESS_CONTROL_SHADER_PATCHES = 0x82F1;
        public const uint TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
        public const uint GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
        public const uint FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
        public const uint COMPUTE_SHADER_INVOCATIONS = 0x82F5;
        public const uint CLIPPING_INPUT_PRIMITIVES = 0x82F6;
        public const uint CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
        public const uint TEXTURE_MAX_ANISOTROPY = 0x84FE;
        public const uint MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
        public const uint POLYGON_OFFSET_CLAMP = 0x8E1B;
        public const uint SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
        public const uint SPIR_V_BINARY = 0x9552;
        public const uint SPIR_V_EXTENSIONS = 0x9553;
        public const uint NUM_SPIR_V_EXTENSIONS = 0x9554;
        public const uint _3DFX_multisample = 1;
        public const uint MULTISAMPLE_3DFX = 0x86B2;
        public const uint SAMPLE_BUFFERS_3DFX = 0x86B3;
        public const uint SAMPLES_3DFX = 0x86B4;
        public const uint MULTISAMPLE_BIT_3DFX = 0x20000000;
        public const uint _3DFX_tbuffer = 1;
        public const uint _3DFX_texture_compression_FXT1 = 1;
        public const uint COMPRESSED_RGB_FXT1_3DFX = 0x86B0;
        public const uint COMPRESSED_RGBA_FXT1_3DFX = 0x86B1;
        public const uint AMD_blend_minmax_factor = 1;
        public const uint FACTOR_MIN_AMD = 0x901C;
        public const uint FACTOR_MAX_AMD = 0x901D;
        public const uint AMD_compressed_3DC_texture = 1;
        public const uint _3DC_X_AMD = 0x87F9;
        public const uint _3DC_XY_AMD = 0x87FA;
        public const uint AMD_compressed_ATC_texture = 1;
        public const uint ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
        public const uint ATC_RGB_AMD = 0x8C92;
        public const uint ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
        public const uint AMD_conservative_depth = 1;
        public const uint AMD_debug_output = 1;
        public const uint MAX_DEBUG_MESSAGE_LENGTH_AMD = 0x9143;
        public const uint MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144;
        public const uint DEBUG_LOGGED_MESSAGES_AMD = 0x9145;
        public const uint DEBUG_SEVERITY_HIGH_AMD = 0x9146;
        public const uint DEBUG_SEVERITY_MEDIUM_AMD = 0x9147;
        public const uint DEBUG_SEVERITY_LOW_AMD = 0x9148;
        public const uint DEBUG_CATEGORY_API_ERROR_AMD = 0x9149;
        public const uint DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A;
        public const uint DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B;
        public const uint DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C;
        public const uint DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D;
        public const uint DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E;
        public const uint DEBUG_CATEGORY_APPLICATION_AMD = 0x914F;
        public const uint DEBUG_CATEGORY_OTHER_AMD = 0x9150;
        public const uint AMD_depth_clamp_separate = 1;
        public const uint DEPTH_CLAMP_NEAR_AMD = 0x901E;
        public const uint DEPTH_CLAMP_FAR_AMD = 0x901F;
        public const uint AMD_draw_buffers_blend = 1;
        public const uint AMD_framebuffer_sample_positions = 1;
        public const uint SUBSAMPLE_DISTANCE_AMD = 0x883F;
        public const uint PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE;
        public const uint PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF;
        public const uint ALL_PIXELS_AMD = 0xFFFFFFFF;
        public const uint AMD_gcn_shader = 1;
        public const uint AMD_gpu_shader_half_float = 1;
        public const uint FLOAT16_NV = 0x8FF8;
        public const uint FLOAT16_VEC2_NV = 0x8FF9;
        public const uint FLOAT16_VEC3_NV = 0x8FFA;
        public const uint FLOAT16_VEC4_NV = 0x8FFB;
        public const uint FLOAT16_MAT2_AMD = 0x91C5;
        public const uint FLOAT16_MAT3_AMD = 0x91C6;
        public const uint FLOAT16_MAT4_AMD = 0x91C7;
        public const uint FLOAT16_MAT2x3_AMD = 0x91C8;
        public const uint FLOAT16_MAT2x4_AMD = 0x91C9;
        public const uint FLOAT16_MAT3x2_AMD = 0x91CA;
        public const uint FLOAT16_MAT3x4_AMD = 0x91CB;
        public const uint FLOAT16_MAT4x2_AMD = 0x91CC;
        public const uint FLOAT16_MAT4x3_AMD = 0x91CD;
        public const uint AMD_gpu_shader_int16 = 1;
        public const uint AMD_gpu_shader_int64 = 1;
        public const uint AMD_interleaved_elements = 1;
        public const uint RG8UI = 0x8238;
        public const uint RG16UI = 0x823A;
        public const uint VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4;
        public const uint VERTEX_ID_SWIZZLE_AMD = 0x91A5;
        public const uint AMD_multi_draw_indirect = 1;
        public const uint AMD_name_gen_delete = 1;
        public const uint DATA_BUFFER_AMD = 0x9151;
        public const uint PERFORMANCE_MONITOR_AMD = 0x9152;
        public const uint QUERY_OBJECT_AMD = 0x9153;
        public const uint VERTEX_ARRAY_OBJECT_AMD = 0x9154;
        public const uint SAMPLER_OBJECT_AMD = 0x9155;
        public const uint AMD_occlusion_query_event = 1;
        public const uint QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001;
        public const uint QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002;
        public const uint QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004;
        public const uint QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008;
        public const uint OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F;
        public const uint QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF;
        public const uint AMD_performance_monitor = 1;
        public const uint COUNTER_TYPE_AMD = 0x8BC0;
        public const uint COUNTER_RANGE_AMD = 0x8BC1;
        public const uint UNSIGNED_INT64_AMD = 0x8BC2;
        public const uint PERCENTAGE_AMD = 0x8BC3;
        public const uint PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;
        public const uint PERFMON_RESULT_SIZE_AMD = 0x8BC5;
        public const uint PERFMON_RESULT_AMD = 0x8BC6;
        public const uint AMD_pinned_memory = 1;
        public const uint EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;
        public const uint AMD_program_binary_Z400 = 1;
        public const uint Z400_BINARY_AMD = 0x8740;
        public const uint AMD_query_buffer_object = 1;
        public const uint QUERY_BUFFER_AMD = 0x9192;
        public const uint QUERY_BUFFER_BINDING_AMD = 0x9193;
        public const uint QUERY_RESULT_NO_WAIT_AMD = 0x9194;
        public const uint AMD_sample_positions = 1;
        public const uint AMD_seamless_cubemap_per_texture = 1;
        public const uint TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
        public const uint AMD_shader_atomic_counter_ops = 1;
        public const uint AMD_shader_ballot = 1;
        public const uint AMD_shader_explicit_vertex_parameter = 1;
        public const uint AMD_shader_stencil_export = 1;
        public const uint AMD_shader_stencil_value_export = 1;
        public const uint AMD_shader_trinary_minmax = 1;
        public const uint AMD_sparse_texture = 1;
        public const uint TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001;
        public const uint VIRTUAL_PAGE_SIZE_X_AMD = 0x9195;
        public const uint VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196;
        public const uint VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197;
        public const uint MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198;
        public const uint MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199;
        public const uint MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A;
        public const uint MIN_SPARSE_LEVEL_AMD = 0x919B;
        public const uint MIN_LOD_WARNING_AMD = 0x919C;
        public const uint AMD_stencil_operation_extended = 1;
        public const uint SET_AMD = 0x874A;
        public const uint REPLACE_VALUE_AMD = 0x874B;
        public const uint STENCIL_OP_VALUE_AMD = 0x874C;
        public const uint STENCIL_BACK_OP_VALUE_AMD = 0x874D;
        public const uint AMD_texture_gather_bias_lod = 1;
        public const uint AMD_texture_texture4 = 1;
        public const uint AMD_transform_feedback3_lines_triangles = 1;
        public const uint AMD_transform_feedback4 = 1;
        public const uint STREAM_RASTERIZATION_AMD = 0x91A0;
        public const uint AMD_vertex_shader_layer = 1;
        public const uint AMD_vertex_shader_tessellator = 1;
        public const uint SAMPLER_BUFFER_AMD = 0x9001;
        public const uint INT_SAMPLER_BUFFER_AMD = 0x9002;
        public const uint UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003;
        public const uint TESSELLATION_MODE_AMD = 0x9004;
        public const uint TESSELLATION_FACTOR_AMD = 0x9005;
        public const uint DISCRETE_AMD = 0x9006;
        public const uint CONTINUOUS_AMD = 0x9007;
        public const uint AMD_vertex_shader_viewport_index = 1;
        public const uint ANDROID_extension_pack_es31a = 1;
        public const uint ANGLE_depth_texture = 1;
        public const uint ANGLE_framebuffer_blit = 1;
        public const uint DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;
        public const uint READ_FRAMEBUFFER_ANGLE = 0x8CA8;
        public const uint DRAW_FRAMEBUFFER_ANGLE = 0x8CA9;
        public const uint READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA;
        public const uint ANGLE_framebuffer_multisample = 1;
        public const uint RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB;
        public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56;
        public const uint MAX_SAMPLES_ANGLE = 0x8D57;
        public const uint ANGLE_instanced_arrays = 1;
        public const uint VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE = 0x88FE;
        public const uint ANGLE_pack_reverse_row_order = 1;
        public const uint PACK_REVERSE_ROW_ORDER_ANGLE = 0x93A4;
        public const uint ANGLE_program_binary = 1;
        public const uint PROGRAM_BINARY_ANGLE = 0x93A6;
        public const uint ANGLE_texture_compression_dxt1 = 1;
        public const uint COMPRESSED_RGB_S3TC_DXT1_ANGLE = 0x83F0;
        public const uint COMPRESSED_RGBA_S3TC_DXT1_ANGLE = 0x83F1;
        public const uint COMPRESSED_RGBA_S3TC_DXT3_ANGLE = 0x83F2;
        public const uint COMPRESSED_RGBA_S3TC_DXT5_ANGLE = 0x83F3;
        public const uint ANGLE_texture_compression_dxt3 = 1;
        public const uint ANGLE_texture_compression_dxt5 = 1;
        public const uint ANGLE_texture_usage = 1;
        public const uint TEXTURE_USAGE_ANGLE = 0x93A2;
        public const uint FRAMEBUFFER_ATTACHMENT_ANGLE = 0x93A3;
        public const uint ANGLE_timer_query = 1;
        public const uint QUERY_COUNTER_BITS_ANGLE = 0x8864;
        public const uint CURRENT_QUERY_ANGLE = 0x8865;
        public const uint QUERY_RESULT_ANGLE = 0x8866;
        public const uint QUERY_RESULT_AVAILABLE_ANGLE = 0x8867;
        public const uint TIME_ELAPSED_ANGLE = 0x88BF;
        public const uint TIMESTAMP_ANGLE = 0x8E28;
        public const uint ANGLE_translated_shader_source = 1;
        public const uint TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE = 0x93A0;
        public const uint APPLE_aux_depth_stencil = 1;
        public const uint AUX_DEPTH_STENCIL_APPLE = 0x8A14;
        public const uint APPLE_client_storage = 1;
        public const uint UNPACK_CLIENT_STORAGE_APPLE = 0x85B2;
        public const uint APPLE_clip_distance = 1;
        public const uint MAX_CLIP_DISTANCES_APPLE = 0x0D32;
        public const uint CLIP_DISTANCE0_APPLE = 0x3000;
        public const uint CLIP_DISTANCE1_APPLE = 0x3001;
        public const uint CLIP_DISTANCE2_APPLE = 0x3002;
        public const uint CLIP_DISTANCE3_APPLE = 0x3003;
        public const uint CLIP_DISTANCE4_APPLE = 0x3004;
        public const uint CLIP_DISTANCE5_APPLE = 0x3005;
        public const uint CLIP_DISTANCE6_APPLE = 0x3006;
        public const uint CLIP_DISTANCE7_APPLE = 0x3007;
        public const uint APPLE_color_buffer_packed_float = 1;
        public const uint APPLE_copy_texture_levels = 1;
        public const uint APPLE_element_array = 1;
        public const uint ELEMENT_ARRAY_APPLE = 0x8A0C;
        public const uint ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;
        public const uint ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;
        public const uint APPLE_fence = 1;
        public const uint DRAW_PIXELS_APPLE = 0x8A0A;
        public const uint FENCE_APPLE = 0x8A0B;
        public const uint APPLE_float_pixels = 1;
        public const uint HALF_APPLE = 0x140B;
        public const uint RGBA_FLOAT32_APPLE = 0x8814;
        public const uint RGB_FLOAT32_APPLE = 0x8815;
        public const uint ALPHA_FLOAT32_APPLE = 0x8816;
        public const uint INTENSITY_FLOAT32_APPLE = 0x8817;
        public const uint LUMINANCE_FLOAT32_APPLE = 0x8818;
        public const uint LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819;
        public const uint RGBA_FLOAT16_APPLE = 0x881A;
        public const uint RGB_FLOAT16_APPLE = 0x881B;
        public const uint ALPHA_FLOAT16_APPLE = 0x881C;
        public const uint INTENSITY_FLOAT16_APPLE = 0x881D;
        public const uint LUMINANCE_FLOAT16_APPLE = 0x881E;
        public const uint LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F;
        public const uint COLOR_FLOAT_APPLE = 0x8A0F;
        public const uint APPLE_flush_buffer_range = 1;
        public const uint BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
        public const uint BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;
        public const uint APPLE_framebuffer_multisample = 1;
        public const uint DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6;
        public const uint READ_FRAMEBUFFER_APPLE = 0x8CA8;
        public const uint DRAW_FRAMEBUFFER_APPLE = 0x8CA9;
        public const uint READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA;
        public const uint RENDERBUFFER_SAMPLES_APPLE = 0x8CAB;
        public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56;
        public const uint MAX_SAMPLES_APPLE = 0x8D57;
        public const uint APPLE_object_purgeable = 1;
        public const uint BUFFER_OBJECT_APPLE = 0x85B3;
        public const uint RELEASED_APPLE = 0x8A19;
        public const uint VOLATILE_APPLE = 0x8A1A;
        public const uint RETAINED_APPLE = 0x8A1B;
        public const uint UNDEFINED_APPLE = 0x8A1C;
        public const uint PURGEABLE_APPLE = 0x8A1D;
        public const uint APPLE_pixel_buffer = 1;
        public const uint MIN_PBUFFER_VIEWPORT_DIMS_APPLE = 0x8A10;
        public const uint APPLE_rgb_422 = 1;
        public const uint UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
        public const uint UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
        public const uint RGB_422_APPLE = 0x8A1F;
        public const uint RGB_RAW_422_APPLE = 0x8A51;
        public const uint APPLE_row_bytes = 1;
        public const uint PACK_ROW_BYTES_APPLE = 0x8A15;
        public const uint UNPACK_ROW_BYTES_APPLE = 0x8A16;
        public const uint APPLE_specular_vector = 1;
        public const uint LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;
        public const uint APPLE_sync = 1;
        public const uint SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001;
        public const uint SYNC_OBJECT_APPLE = 0x8A53;
        public const uint MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111;
        public const uint OBJECT_TYPE_APPLE = 0x9112;
        public const uint SYNC_CONDITION_APPLE = 0x9113;
        public const uint SYNC_STATUS_APPLE = 0x9114;
        public const uint SYNC_FLAGS_APPLE = 0x9115;
        public const uint SYNC_FENCE_APPLE = 0x9116;
        public const uint SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117;
        public const uint UNSIGNALED_APPLE = 0x9118;
        public const uint SIGNALED_APPLE = 0x9119;
        public const uint ALREADY_SIGNALED_APPLE = 0x911A;
        public const uint TIMEOUT_EXPIRED_APPLE = 0x911B;
        public const uint CONDITION_SATISFIED_APPLE = 0x911C;
        public const uint WAIT_FAILED_APPLE = 0x911D;
        public const ulong TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFFul;
        public const uint APPLE_texture_2D_limited_npot = 1;
        public const uint APPLE_texture_format_BGRA8888 = 1;
        public const uint BGRA_EXT = 0x80E1;
        public const uint BGRA8_EXT = 0x93A1;
        public const uint APPLE_texture_max_level = 1;
        public const uint TEXTURE_MAX_LEVEL_APPLE = 0x813D;
        public const uint APPLE_texture_packed_float = 1;
        public const uint R11F_G11F_B10F_APPLE = 0x8C3A;
        public const uint UNSIGNED_INT_10F_11F_11F_REV_APPLE = 0x8C3B;
        public const uint RGB9_E5_APPLE = 0x8C3D;
        public const uint UNSIGNED_INT_5_9_9_9_REV_APPLE = 0x8C3E;
        public const uint APPLE_texture_range = 1;
        public const uint TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;
        public const uint TEXTURE_RANGE_POINTER_APPLE = 0x85B8;
        public const uint TEXTURE_STORAGE_HINT_APPLE = 0x85BC;
        public const uint STORAGE_PRIVATE_APPLE = 0x85BD;
        public const uint STORAGE_CACHED_APPLE = 0x85BE;
        public const uint STORAGE_SHARED_APPLE = 0x85BF;
        public const uint APPLE_transform_hint = 1;
        public const uint TRANSFORM_HINT_APPLE = 0x85B1;
        public const uint APPLE_vertex_array_object = 1;
        public const uint VERTEX_ARRAY_BINDING_APPLE = 0x85B5;
        public const uint APPLE_vertex_array_range = 1;
        public const uint VERTEX_ARRAY_RANGE_APPLE = 0x851D;
        public const uint VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;
        public const uint VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;
        public const uint MAX_VERTEX_ARRAY_RANGE_ELEMENT_APPLE = 0x8520;
        public const uint VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;
        public const uint STORAGE_CLIENT_APPLE = 0x85B4;
        public const uint APPLE_vertex_program_evaluators = 1;
        public const uint VERTEX_ATTRIB_MAP1_APPLE = 0x8A00;
        public const uint VERTEX_ATTRIB_MAP2_APPLE = 0x8A01;
        public const uint VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02;
        public const uint VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03;
        public const uint VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04;
        public const uint VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05;
        public const uint VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06;
        public const uint VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07;
        public const uint VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08;
        public const uint VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09;
        public const uint APPLE_ycbcr_422 = 1;
        public const uint YCBCR_422_APPLE = 0x85B9;
        public const uint ARB_ES2_compatibility = 1;
        public const uint FIXED = 0x140C;
        public const uint IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const uint IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const uint RGB565 = 0x8D62;
        public const uint LOW_FLOAT = 0x8DF0;
        public const uint MEDIUM_FLOAT = 0x8DF1;
        public const uint HIGH_FLOAT = 0x8DF2;
        public const uint LOW_INT = 0x8DF3;
        public const uint MEDIUM_INT = 0x8DF4;
        public const uint HIGH_INT = 0x8DF5;
        public const uint SHADER_BINARY_FORMATS = 0x8DF8;
        public const uint NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const uint SHADER_COMPILER = 0x8DFA;
        public const uint MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const uint MAX_VARYING_VECTORS = 0x8DFC;
        public const uint MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const uint ARB_ES3_1_compatibility = 1;
        public const uint ARB_ES3_2_compatibility = 1;
        public const uint PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
        public const uint MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
        public const uint MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
        public const uint ARB_ES3_compatibility = 1;
        public const uint TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
        public const uint PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        public const uint ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        public const uint MAX_ELEMENT_INDEX = 0x8D6B;
        public const uint COMPRESSED_R11_EAC = 0x9270;
        public const uint COMPRESSED_SIGNED_R11_EAC = 0x9271;
        public const uint COMPRESSED_RG11_EAC = 0x9272;
        public const uint COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        public const uint COMPRESSED_RGB8_ETC2 = 0x9274;
        public const uint COMPRESSED_SRGB8_ETC2 = 0x9275;
        public const uint COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        public const uint COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        public const uint COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        public const uint COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
        public const uint ARB_arrays_of_arrays = 1;
        public const uint ARB_base_instance = 1;
        public const uint ARB_bindless_texture = 1;
        public const uint UNSIGNED_INT64_ARB = 0x140F;
        public const uint ARB_blend_func_extended = 1;
        public const uint SRC1_COLOR = 0x88F9;
        public const uint ONE_MINUS_SRC1_COLOR = 0x88FA;
        public const uint ONE_MINUS_SRC1_ALPHA = 0x88FB;
        public const uint MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
        public const uint ARB_buffer_storage = 1;
        public const uint MAP_READ_BIT = 0x0001;
        public const uint MAP_WRITE_BIT = 0x0002;
        public const uint MAP_PERSISTENT_BIT = 0x00000040;
        public const uint MAP_COHERENT_BIT = 0x00000080;
        public const uint DYNAMIC_STORAGE_BIT = 0x0100;
        public const uint CLIENT_STORAGE_BIT = 0x0200;
        public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
        public const uint BUFFER_IMMUTABLE_STORAGE = 0x821F;
        public const uint BUFFER_STORAGE_FLAGS = 0x8220;
        public const uint ARB_cl_event = 1;
        public const uint SYNC_CL_EVENT_ARB = 0x8240;
        public const uint SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;
        public const uint ARB_clear_buffer_object = 1;
        public const uint ARB_clear_texture = 1;
        public const uint CLEAR_TEXTURE = 0x9365;
        public const uint ARB_clip_control = 1;
        public const uint CLIP_ORIGIN = 0x935C;
        public const uint CLIP_DEPTH_MODE = 0x935D;
        public const uint NEGATIVE_ONE_TO_ONE = 0x935E;
        public const uint ZERO_TO_ONE = 0x935F;
        public const uint ARB_color_buffer_float = 1;
        public const uint RGBA_FLOAT_MODE_ARB = 0x8820;
        public const uint CLAMP_VERTEX_COLOR_ARB = 0x891A;
        public const uint CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
        public const uint CLAMP_READ_COLOR_ARB = 0x891C;
        public const uint FIXED_ONLY_ARB = 0x891D;
        public const uint ARB_compatibility = 1;
        public const uint ARB_compressed_texture_pixel_storage = 1;
        public const uint UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        public const uint UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const uint UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        public const uint UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        public const uint PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        public const uint PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        public const uint PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        public const uint PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
        public const uint ARB_compute_shader = 1;
        public const uint COMPUTE_SHADER_BIT = 0x00000020;
        public const uint MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const uint MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        public const uint MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        public const uint MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
        public const uint MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        public const uint COMPUTE_WORK_GROUP_SIZE = 0x8267;
        public const uint MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
        public const uint DISPATCH_INDIRECT_BUFFER = 0x90EE;
        public const uint DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        public const uint COMPUTE_SHADER = 0x91B9;
        public const uint MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
        public const uint MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        public const uint MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        public const uint MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
        public const uint MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
        public const uint ARB_compute_variable_group_size = 1;
        public const uint MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
        public const uint MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
        public const uint MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
        public const uint MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;
        public const uint ARB_conditional_render_inverted = 1;
        public const uint QUERY_WAIT_INVERTED = 0x8E17;
        public const uint QUERY_NO_WAIT_INVERTED = 0x8E18;
        public const uint QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
        public const uint QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
        public const uint ARB_conservative_depth = 1;
        public const uint ARB_copy_buffer = 1;
        public const uint COPY_READ_BUFFER = 0x8F36;
        public const uint COPY_WRITE_BUFFER = 0x8F37;
        public const uint ARB_copy_image = 1;
        public const uint ARB_cull_distance = 1;
        public const uint MAX_CULL_DISTANCES = 0x82F9;
        public const uint MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
        public const uint ARB_debug_output = 1;
        public const uint DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;
        public const uint DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;
        public const uint DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;
        public const uint DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;
        public const uint DEBUG_SOURCE_API_ARB = 0x8246;
        public const uint DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;
        public const uint DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;
        public const uint DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;
        public const uint DEBUG_SOURCE_APPLICATION_ARB = 0x824A;
        public const uint DEBUG_SOURCE_OTHER_ARB = 0x824B;
        public const uint DEBUG_TYPE_ERROR_ARB = 0x824C;
        public const uint DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;
        public const uint DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;
        public const uint DEBUG_TYPE_PORTABILITY_ARB = 0x824F;
        public const uint DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;
        public const uint DEBUG_TYPE_OTHER_ARB = 0x8251;
        public const uint MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;
        public const uint MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;
        public const uint DEBUG_LOGGED_MESSAGES_ARB = 0x9145;
        public const uint DEBUG_SEVERITY_HIGH_ARB = 0x9146;
        public const uint DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;
        public const uint DEBUG_SEVERITY_LOW_ARB = 0x9148;
        public const uint ARB_depth_buffer_float = 1;
        public const uint DEPTH_COMPONENT32F = 0x8CAC;
        public const uint DEPTH32F_STENCIL8 = 0x8CAD;
        public const uint FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        public const uint ARB_depth_clamp = 1;
        public const uint DEPTH_CLAMP = 0x864F;
        public const uint ARB_depth_texture = 1;
        public const uint DEPTH_COMPONENT16_ARB = 0x81A5;
        public const uint DEPTH_COMPONENT24_ARB = 0x81A6;
        public const uint DEPTH_COMPONENT32_ARB = 0x81A7;
        public const uint TEXTURE_DEPTH_SIZE_ARB = 0x884A;
        public const uint DEPTH_TEXTURE_MODE_ARB = 0x884B;
        public const uint ARB_derivative_control = 1;
        public const uint ARB_direct_state_access = 1;
        public const uint TEXTURE_TARGET = 0x1006;
        public const uint QUERY_TARGET = 0x82EA;
        public const uint ARB_draw_buffers = 1;
        public const uint MAX_DRAW_BUFFERS_ARB = 0x8824;
        public const uint DRAW_BUFFER0_ARB = 0x8825;
        public const uint DRAW_BUFFER1_ARB = 0x8826;
        public const uint DRAW_BUFFER2_ARB = 0x8827;
        public const uint DRAW_BUFFER3_ARB = 0x8828;
        public const uint DRAW_BUFFER4_ARB = 0x8829;
        public const uint DRAW_BUFFER5_ARB = 0x882A;
        public const uint DRAW_BUFFER6_ARB = 0x882B;
        public const uint DRAW_BUFFER7_ARB = 0x882C;
        public const uint DRAW_BUFFER8_ARB = 0x882D;
        public const uint DRAW_BUFFER9_ARB = 0x882E;
        public const uint DRAW_BUFFER10_ARB = 0x882F;
        public const uint DRAW_BUFFER11_ARB = 0x8830;
        public const uint DRAW_BUFFER12_ARB = 0x8831;
        public const uint DRAW_BUFFER13_ARB = 0x8832;
        public const uint DRAW_BUFFER14_ARB = 0x8833;
        public const uint DRAW_BUFFER15_ARB = 0x8834;
        public const uint ARB_draw_buffers_blend = 1;
        public const uint ARB_draw_elements_base_vertex = 1;
        public const uint ARB_draw_indirect = 1;
        public const uint DRAW_INDIRECT_BUFFER = 0x8F3F;
        public const uint DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
        public const uint ARB_draw_instanced = 1;
        public const uint ARB_enhanced_layouts = 1;
        public const uint LOCATION_COMPONENT = 0x934A;
        public const uint TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
        public const uint TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
        public const uint ARB_explicit_attrib_location = 1;
        public const uint ARB_explicit_uniform_location = 1;
        public const uint MAX_UNIFORM_LOCATIONS = 0x826E;
        public const uint ARB_fragment_coord_conventions = 1;
        public const uint ARB_fragment_layer_viewport = 1;
        public const uint ARB_fragment_program = 1;
        public const uint FRAGMENT_PROGRAM_ARB = 0x8804;
        public const uint PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;
        public const uint PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;
        public const uint PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;
        public const uint PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;
        public const uint PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;
        public const uint PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;
        public const uint MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;
        public const uint MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;
        public const uint MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;
        public const uint MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;
        public const uint MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;
        public const uint MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;
        public const uint MAX_TEXTURE_COORDS_ARB = 0x8871;
        public const uint MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
        public const uint ARB_fragment_program_shadow = 1;
        public const uint ARB_fragment_shader = 1;
        public const uint FRAGMENT_SHADER_ARB = 0x8B30;
        public const uint MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
        public const uint FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B;
        public const uint ARB_fragment_shader_interlock = 1;
        public const uint ARB_framebuffer_no_attachments = 1;
        public const uint FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
        public const uint FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
        public const uint FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
        public const uint FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
        public const uint FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        public const uint MAX_FRAMEBUFFER_WIDTH = 0x9315;
        public const uint MAX_FRAMEBUFFER_HEIGHT = 0x9316;
        public const uint MAX_FRAMEBUFFER_LAYERS = 0x9317;
        public const uint MAX_FRAMEBUFFER_SAMPLES = 0x9318;
        public const uint ARB_framebuffer_object = 1;
        public const uint INVALID_FRAMEBUFFER_OPERATION = 0x0506;
        public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        public const uint FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        public const uint FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        public const uint FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        public const uint FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        public const uint FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        public const uint FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        public const uint FRAMEBUFFER_DEFAULT = 0x8218;
        public const uint FRAMEBUFFER_UNDEFINED = 0x8219;
        public const uint DEPTH_STENCIL_ATTACHMENT = 0x821A;
        public const uint INDEX = 0x8222;
        public const uint MAX_RENDERBUFFER_SIZE = 0x84E8;
        public const uint DEPTH_STENCIL = 0x84F9;
        public const uint UNSIGNED_INT_24_8 = 0x84FA;
        public const uint DEPTH24_STENCIL8 = 0x88F0;
        public const uint TEXTURE_STENCIL_SIZE = 0x88F1;
        public const uint UNSIGNED_NORMALIZED = 0x8C17;
        public const uint DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
        public const uint FRAMEBUFFER_BINDING = 0x8CA6;
        public const uint RENDERBUFFER_BINDING = 0x8CA7;
        public const uint READ_FRAMEBUFFER = 0x8CA8;
        public const uint DRAW_FRAMEBUFFER = 0x8CA9;
        public const uint READ_FRAMEBUFFER_BINDING = 0x8CAA;
        public const uint RENDERBUFFER_SAMPLES = 0x8CAB;
        public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const uint FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const uint FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
        public const uint FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
        public const uint FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public const uint MAX_COLOR_ATTACHMENTS = 0x8CDF;
        public const uint COLOR_ATTACHMENT0 = 0x8CE0;
        public const uint COLOR_ATTACHMENT1 = 0x8CE1;
        public const uint COLOR_ATTACHMENT2 = 0x8CE2;
        public const uint COLOR_ATTACHMENT3 = 0x8CE3;
        public const uint COLOR_ATTACHMENT4 = 0x8CE4;
        public const uint COLOR_ATTACHMENT5 = 0x8CE5;
        public const uint COLOR_ATTACHMENT6 = 0x8CE6;
        public const uint COLOR_ATTACHMENT7 = 0x8CE7;
        public const uint COLOR_ATTACHMENT8 = 0x8CE8;
        public const uint COLOR_ATTACHMENT9 = 0x8CE9;
        public const uint COLOR_ATTACHMENT10 = 0x8CEA;
        public const uint COLOR_ATTACHMENT11 = 0x8CEB;
        public const uint COLOR_ATTACHMENT12 = 0x8CEC;
        public const uint COLOR_ATTACHMENT13 = 0x8CED;
        public const uint COLOR_ATTACHMENT14 = 0x8CEE;
        public const uint COLOR_ATTACHMENT15 = 0x8CEF;
        public const uint DEPTH_ATTACHMENT = 0x8D00;
        public const uint STENCIL_ATTACHMENT = 0x8D20;
        public const uint FRAMEBUFFER = 0x8D40;
        public const uint RENDERBUFFER = 0x8D41;
        public const uint RENDERBUFFER_WIDTH = 0x8D42;
        public const uint RENDERBUFFER_HEIGHT = 0x8D43;
        public const uint RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const uint STENCIL_INDEX1 = 0x8D46;
        public const uint STENCIL_INDEX4 = 0x8D47;
        public const uint STENCIL_INDEX8 = 0x8D48;
        public const uint STENCIL_INDEX16 = 0x8D49;
        public const uint RENDERBUFFER_RED_SIZE = 0x8D50;
        public const uint RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const uint RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const uint RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const uint RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const uint RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const uint MAX_SAMPLES = 0x8D57;
        public const uint ARB_framebuffer_sRGB = 1;
        public const uint FRAMEBUFFER_SRGB = 0x8DB9;
        public const uint ARB_geometry_shader4 = 1;
        public const uint LINES_ADJACENCY_ARB = 0xA;
        public const uint LINE_STRIP_ADJACENCY_ARB = 0xB;
        public const uint TRIANGLES_ADJACENCY_ARB = 0xC;
        public const uint TRIANGLE_STRIP_ADJACENCY_ARB = 0xD;
        public const uint PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
        public const uint FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;
        public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
        public const uint FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
        public const uint GEOMETRY_SHADER_ARB = 0x8DD9;
        public const uint GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
        public const uint GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
        public const uint GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
        public const uint MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
        public const uint MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
        public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
        public const uint MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
        public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;
        public const uint ARB_get_program_binary = 1;
        public const uint PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const uint PROGRAM_BINARY_LENGTH = 0x8741;
        public const uint NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const uint PROGRAM_BINARY_FORMATS = 0x87FF;
        public const uint ARB_get_texture_sub_image = 1;
        public const uint ARB_gl_spirv = 1;
        public const uint SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;
        public const uint SPIR_V_BINARY_ARB = 0x9552;
        public const uint ARB_gpu_shader5 = 1;
        public const uint GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        public const uint MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const uint MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const uint MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const uint FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        public const uint MAX_VERTEX_STREAMS = 0x8E71;
        public const uint ARB_gpu_shader_fp64 = 1;
        public const uint DOUBLE_MAT2 = 0x8F46;
        public const uint DOUBLE_MAT3 = 0x8F47;
        public const uint DOUBLE_MAT4 = 0x8F48;
        public const uint DOUBLE_MAT2x3 = 0x8F49;
        public const uint DOUBLE_MAT2x4 = 0x8F4A;
        public const uint DOUBLE_MAT3x2 = 0x8F4B;
        public const uint DOUBLE_MAT3x4 = 0x8F4C;
        public const uint DOUBLE_MAT4x2 = 0x8F4D;
        public const uint DOUBLE_MAT4x3 = 0x8F4E;
        public const uint DOUBLE_VEC2 = 0x8FFC;
        public const uint DOUBLE_VEC3 = 0x8FFD;
        public const uint DOUBLE_VEC4 = 0x8FFE;
        public const uint ARB_gpu_shader_int64 = 1;
        public const uint INT64_ARB = 0x140E;
        public const uint INT64_VEC2_ARB = 0x8FE9;
        public const uint INT64_VEC3_ARB = 0x8FEA;
        public const uint INT64_VEC4_ARB = 0x8FEB;
        public const uint UNSIGNED_INT64_VEC2_ARB = 0x8FF5;
        public const uint UNSIGNED_INT64_VEC3_ARB = 0x8FF6;
        public const uint UNSIGNED_INT64_VEC4_ARB = 0x8FF7;
        public const uint ARB_half_float_pixel = 1;
        public const uint HALF_FLOAT_ARB = 0x140B;
        public const uint ARB_half_float_vertex = 1;
        public const uint HALF_FLOAT = 0x140B;
        public const uint ARB_imaging = 1;
        public const uint CONSTANT_COLOR = 0x8001;
        public const uint ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const uint CONSTANT_ALPHA = 0x8003;
        public const uint ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const uint BLEND_COLOR = 0x8005;
        public const uint FUNC_ADD = 0x8006;
        public const uint MIN = 0x8007;
        public const uint MAX = 0x8008;
        public const uint BLEND_EQUATION = 0x8009;
        public const uint FUNC_SUBTRACT = 0x800A;
        public const uint FUNC_REVERSE_SUBTRACT = 0x800B;
        public const uint CONVOLUTION_1D = 0x8010;
        public const uint CONVOLUTION_2D = 0x8011;
        public const uint SEPARABLE_2D = 0x8012;
        public const uint CONVOLUTION_BORDER_MODE = 0x8013;
        public const uint CONVOLUTION_FILTER_SCALE = 0x8014;
        public const uint CONVOLUTION_FILTER_BIAS = 0x8015;
        public const uint REDUCE = 0x8016;
        public const uint CONVOLUTION_FORMAT = 0x8017;
        public const uint CONVOLUTION_WIDTH = 0x8018;
        public const uint CONVOLUTION_HEIGHT = 0x8019;
        public const uint MAX_CONVOLUTION_WIDTH = 0x801A;
        public const uint MAX_CONVOLUTION_HEIGHT = 0x801B;
        public const uint POST_CONVOLUTION_RED_SCALE = 0x801C;
        public const uint POST_CONVOLUTION_GREEN_SCALE = 0x801D;
        public const uint POST_CONVOLUTION_BLUE_SCALE = 0x801E;
        public const uint POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
        public const uint POST_CONVOLUTION_RED_BIAS = 0x8020;
        public const uint POST_CONVOLUTION_GREEN_BIAS = 0x8021;
        public const uint POST_CONVOLUTION_BLUE_BIAS = 0x8022;
        public const uint POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
        public const uint HISTOGRAM = 0x8024;
        public const uint PROXY_HISTOGRAM = 0x8025;
        public const uint HISTOGRAM_WIDTH = 0x8026;
        public const uint HISTOGRAM_FORMAT = 0x8027;
        public const uint HISTOGRAM_RED_SIZE = 0x8028;
        public const uint HISTOGRAM_GREEN_SIZE = 0x8029;
        public const uint HISTOGRAM_BLUE_SIZE = 0x802A;
        public const uint HISTOGRAM_ALPHA_SIZE = 0x802B;
        public const uint HISTOGRAM_LUMINANCE_SIZE = 0x802C;
        public const uint HISTOGRAM_SINK = 0x802D;
        public const uint MINMAX = 0x802E;
        public const uint MINMAX_FORMAT = 0x802F;
        public const uint MINMAX_SINK = 0x8030;
        public const uint TABLE_TOO_LARGE = 0x8031;
        public const uint COLOR_MATRIX = 0x80B1;
        public const uint COLOR_MATRIX_STACK_DEPTH = 0x80B2;
        public const uint MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
        public const uint POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
        public const uint POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
        public const uint POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
        public const uint POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
        public const uint POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
        public const uint POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
        public const uint POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
        public const uint POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
        public const uint COLOR_TABLE = 0x80D0;
        public const uint POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
        public const uint POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
        public const uint PROXY_COLOR_TABLE = 0x80D3;
        public const uint PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
        public const uint PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
        public const uint COLOR_TABLE_SCALE = 0x80D6;
        public const uint COLOR_TABLE_BIAS = 0x80D7;
        public const uint COLOR_TABLE_FORMAT = 0x80D8;
        public const uint COLOR_TABLE_WIDTH = 0x80D9;
        public const uint COLOR_TABLE_RED_SIZE = 0x80DA;
        public const uint COLOR_TABLE_GREEN_SIZE = 0x80DB;
        public const uint COLOR_TABLE_BLUE_SIZE = 0x80DC;
        public const uint COLOR_TABLE_ALPHA_SIZE = 0x80DD;
        public const uint COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
        public const uint COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
        public const uint IGNORE_BORDER = 0x8150;
        public const uint CONSTANT_BORDER = 0x8151;
        public const uint WRAP_BORDER = 0x8152;
        public const uint REPLICATE_BORDER = 0x8153;
        public const uint CONVOLUTION_BORDER_COLOR = 0x8154;
        public const uint ARB_indirect_parameters = 1;
        public const uint PARAMETER_BUFFER_ARB = 0x80EE;
        public const uint PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
        public const uint ARB_instanced_arrays = 1;
        public const uint VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;
        public const uint ARB_internalformat_query = 1;
        public const uint NUM_SAMPLE_COUNTS = 0x9380;
        public const uint ARB_internalformat_query2 = 1;
        public const uint INTERNALFORMAT_SUPPORTED = 0x826F;
        public const uint INTERNALFORMAT_PREFERRED = 0x8270;
        public const uint INTERNALFORMAT_RED_SIZE = 0x8271;
        public const uint INTERNALFORMAT_GREEN_SIZE = 0x8272;
        public const uint INTERNALFORMAT_BLUE_SIZE = 0x8273;
        public const uint INTERNALFORMAT_ALPHA_SIZE = 0x8274;
        public const uint INTERNALFORMAT_DEPTH_SIZE = 0x8275;
        public const uint INTERNALFORMAT_STENCIL_SIZE = 0x8276;
        public const uint INTERNALFORMAT_SHARED_SIZE = 0x8277;
        public const uint INTERNALFORMAT_RED_TYPE = 0x8278;
        public const uint INTERNALFORMAT_GREEN_TYPE = 0x8279;
        public const uint INTERNALFORMAT_BLUE_TYPE = 0x827A;
        public const uint INTERNALFORMAT_ALPHA_TYPE = 0x827B;
        public const uint INTERNALFORMAT_DEPTH_TYPE = 0x827C;
        public const uint INTERNALFORMAT_STENCIL_TYPE = 0x827D;
        public const uint MAX_WIDTH = 0x827E;
        public const uint MAX_HEIGHT = 0x827F;
        public const uint MAX_DEPTH = 0x8280;
        public const uint MAX_LAYERS = 0x8281;
        public const uint MAX_COMBINED_DIMENSIONS = 0x8282;
        public const uint COLOR_COMPONENTS = 0x8283;
        public const uint DEPTH_COMPONENTS = 0x8284;
        public const uint STENCIL_COMPONENTS = 0x8285;
        public const uint COLOR_RENDERABLE = 0x8286;
        public const uint DEPTH_RENDERABLE = 0x8287;
        public const uint STENCIL_RENDERABLE = 0x8288;
        public const uint FRAMEBUFFER_RENDERABLE = 0x8289;
        public const uint FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
        public const uint FRAMEBUFFER_BLEND = 0x828B;
        public const uint READ_PIXELS = 0x828C;
        public const uint READ_PIXELS_FORMAT = 0x828D;
        public const uint READ_PIXELS_TYPE = 0x828E;
        public const uint TEXTURE_IMAGE_FORMAT = 0x828F;
        public const uint TEXTURE_IMAGE_TYPE = 0x8290;
        public const uint GET_TEXTURE_IMAGE_FORMAT = 0x8291;
        public const uint GET_TEXTURE_IMAGE_TYPE = 0x8292;
        public const uint MIPMAP = 0x8293;
        public const uint MANUAL_GENERATE_MIPMAP = 0x8294;
        public const uint AUTO_GENERATE_MIPMAP = 0x8295;
        public const uint COLOR_ENCODING = 0x8296;
        public const uint SRGB_READ = 0x8297;
        public const uint SRGB_WRITE = 0x8298;
        public const uint SRGB_DECODE_ARB = 0x8299;
        public const uint FILTER = 0x829A;
        public const uint VERTEX_TEXTURE = 0x829B;
        public const uint TESS_CONTROL_TEXTURE = 0x829C;
        public const uint TESS_EVALUATION_TEXTURE = 0x829D;
        public const uint GEOMETRY_TEXTURE = 0x829E;
        public const uint FRAGMENT_TEXTURE = 0x829F;
        public const uint COMPUTE_TEXTURE = 0x82A0;
        public const uint TEXTURE_SHADOW = 0x82A1;
        public const uint TEXTURE_GATHER = 0x82A2;
        public const uint TEXTURE_GATHER_SHADOW = 0x82A3;
        public const uint SHADER_IMAGE_LOAD = 0x82A4;
        public const uint SHADER_IMAGE_STORE = 0x82A5;
        public const uint SHADER_IMAGE_ATOMIC = 0x82A6;
        public const uint IMAGE_TEXEL_SIZE = 0x82A7;
        public const uint IMAGE_COMPATIBILITY_CLASS = 0x82A8;
        public const uint IMAGE_PIXEL_FORMAT = 0x82A9;
        public const uint IMAGE_PIXEL_TYPE = 0x82AA;
        public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
        public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
        public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
        public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
        public const uint TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
        public const uint TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
        public const uint TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
        public const uint CLEAR_BUFFER = 0x82B4;
        public const uint TEXTURE_VIEW = 0x82B5;
        public const uint VIEW_COMPATIBILITY_CLASS = 0x82B6;
        public const uint FULL_SUPPORT = 0x82B7;
        public const uint CAVEAT_SUPPORT = 0x82B8;
        public const uint IMAGE_CLASS_4_X_32 = 0x82B9;
        public const uint IMAGE_CLASS_2_X_32 = 0x82BA;
        public const uint IMAGE_CLASS_1_X_32 = 0x82BB;
        public const uint IMAGE_CLASS_4_X_16 = 0x82BC;
        public const uint IMAGE_CLASS_2_X_16 = 0x82BD;
        public const uint IMAGE_CLASS_1_X_16 = 0x82BE;
        public const uint IMAGE_CLASS_4_X_8 = 0x82BF;
        public const uint IMAGE_CLASS_2_X_8 = 0x82C0;
        public const uint IMAGE_CLASS_1_X_8 = 0x82C1;
        public const uint IMAGE_CLASS_11_11_10 = 0x82C2;
        public const uint IMAGE_CLASS_10_10_10_2 = 0x82C3;
        public const uint VIEW_CLASS_128_BITS = 0x82C4;
        public const uint VIEW_CLASS_96_BITS = 0x82C5;
        public const uint VIEW_CLASS_64_BITS = 0x82C6;
        public const uint VIEW_CLASS_48_BITS = 0x82C7;
        public const uint VIEW_CLASS_32_BITS = 0x82C8;
        public const uint VIEW_CLASS_24_BITS = 0x82C9;
        public const uint VIEW_CLASS_16_BITS = 0x82CA;
        public const uint VIEW_CLASS_8_BITS = 0x82CB;
        public const uint VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
        public const uint VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
        public const uint VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
        public const uint VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
        public const uint VIEW_CLASS_RGTC1_RED = 0x82D0;
        public const uint VIEW_CLASS_RGTC2_RG = 0x82D1;
        public const uint VIEW_CLASS_BPTC_UNORM = 0x82D2;
        public const uint VIEW_CLASS_BPTC_FLOAT = 0x82D3;
        public const uint ARB_invalidate_subdata = 1;
        public const uint ARB_map_buffer_alignment = 1;
        public const uint MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
        public const uint ARB_map_buffer_range = 1;
        public const uint MAP_INVALIDATE_RANGE_BIT = 0x0004;
        public const uint MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        public const uint MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        public const uint MAP_UNSYNCHRONIZED_BIT = 0x0020;
        public const uint ARB_matrix_palette = 1;
        public const uint MATRIX_PALETTE_ARB = 0x8840;
        public const uint MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
        public const uint MAX_PALETTE_MATRICES_ARB = 0x8842;
        public const uint CURRENT_PALETTE_MATRIX_ARB = 0x8843;
        public const uint MATRIX_INDEX_ARRAY_ARB = 0x8844;
        public const uint CURRENT_MATRIX_INDEX_ARB = 0x8845;
        public const uint MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
        public const uint MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
        public const uint MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
        public const uint MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
        public const uint ARB_multi_bind = 1;
        public const uint ARB_multi_draw_indirect = 1;
        public const uint ARB_multisample = 1;
        public const uint MULTISAMPLE_ARB = 0x809D;
        public const uint SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
        public const uint SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
        public const uint SAMPLE_COVERAGE_ARB = 0x80A0;
        public const uint SAMPLE_BUFFERS_ARB = 0x80A8;
        public const uint SAMPLES_ARB = 0x80A9;
        public const uint SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
        public const uint SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
        public const uint MULTISAMPLE_BIT_ARB = 0x20000000;
        public const uint ARB_multitexture = 1;
        public const uint TEXTURE0_ARB = 0x84C0;
        public const uint TEXTURE1_ARB = 0x84C1;
        public const uint TEXTURE2_ARB = 0x84C2;
        public const uint TEXTURE3_ARB = 0x84C3;
        public const uint TEXTURE4_ARB = 0x84C4;
        public const uint TEXTURE5_ARB = 0x84C5;
        public const uint TEXTURE6_ARB = 0x84C6;
        public const uint TEXTURE7_ARB = 0x84C7;
        public const uint TEXTURE8_ARB = 0x84C8;
        public const uint TEXTURE9_ARB = 0x84C9;
        public const uint TEXTURE10_ARB = 0x84CA;
        public const uint TEXTURE11_ARB = 0x84CB;
        public const uint TEXTURE12_ARB = 0x84CC;
        public const uint TEXTURE13_ARB = 0x84CD;
        public const uint TEXTURE14_ARB = 0x84CE;
        public const uint TEXTURE15_ARB = 0x84CF;
        public const uint TEXTURE16_ARB = 0x84D0;
        public const uint TEXTURE17_ARB = 0x84D1;
        public const uint TEXTURE18_ARB = 0x84D2;
        public const uint TEXTURE19_ARB = 0x84D3;
        public const uint TEXTURE20_ARB = 0x84D4;
        public const uint TEXTURE21_ARB = 0x84D5;
        public const uint TEXTURE22_ARB = 0x84D6;
        public const uint TEXTURE23_ARB = 0x84D7;
        public const uint TEXTURE24_ARB = 0x84D8;
        public const uint TEXTURE25_ARB = 0x84D9;
        public const uint TEXTURE26_ARB = 0x84DA;
        public const uint TEXTURE27_ARB = 0x84DB;
        public const uint TEXTURE28_ARB = 0x84DC;
        public const uint TEXTURE29_ARB = 0x84DD;
        public const uint TEXTURE30_ARB = 0x84DE;
        public const uint TEXTURE31_ARB = 0x84DF;
        public const uint ACTIVE_TEXTURE_ARB = 0x84E0;
        public const uint CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
        public const uint MAX_TEXTURE_UNITS_ARB = 0x84E2;
        public const uint ARB_occlusion_query = 1;
        public const uint QUERY_COUNTER_BITS_ARB = 0x8864;
        public const uint CURRENT_QUERY_ARB = 0x8865;
        public const uint QUERY_RESULT_ARB = 0x8866;
        public const uint QUERY_RESULT_AVAILABLE_ARB = 0x8867;
        public const uint SAMPLES_PASSED_ARB = 0x8914;
        public const uint ARB_occlusion_query2 = 1;
        public const uint ANY_SAMPLES_PASSED = 0x8C2F;
        public const uint ARB_parallel_shader_compile = 1;
        public const uint MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
        public const uint COMPLETION_STATUS_ARB = 0x91B1;
        public const uint ARB_pipeline_statistics_query = 1;
        public const uint VERTICES_SUBMITTED_ARB = 0x82EE;
        public const uint PRIMITIVES_SUBMITTED_ARB = 0x82EF;
        public const uint VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;
        public const uint TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;
        public const uint TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;
        public const uint GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;
        public const uint FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;
        public const uint COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;
        public const uint CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;
        public const uint CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;
        public const uint ARB_pixel_buffer_object = 1;
        public const uint PIXEL_PACK_BUFFER_ARB = 0x88EB;
        public const uint PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
        public const uint PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
        public const uint PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;
        public const uint ARB_point_parameters = 1;
        public const uint POINT_SIZE_MIN_ARB = 0x8126;
        public const uint POINT_SIZE_MAX_ARB = 0x8127;
        public const uint POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
        public const uint POINT_DISTANCE_ATTENUATION_ARB = 0x8129;
        public const uint ARB_point_sprite = 1;
        public const uint POINT_SPRITE_ARB = 0x8861;
        public const uint COORD_REPLACE_ARB = 0x8862;
        public const uint ARB_polygon_offset_clamp = 1;
        public const uint ARB_post_depth_coverage = 1;
        public const uint ARB_program_interface_query = 1;
        public const uint UNIFORM = 0x92E1;
        public const uint UNIFORM_BLOCK = 0x92E2;
        public const uint PROGRAM_INPUT = 0x92E3;
        public const uint PROGRAM_OUTPUT = 0x92E4;
        public const uint BUFFER_VARIABLE = 0x92E5;
        public const uint SHADER_STORAGE_BLOCK = 0x92E6;
        public const uint IS_PER_PATCH = 0x92E7;
        public const uint VERTEX_SUBROUTINE = 0x92E8;
        public const uint TESS_CONTROL_SUBROUTINE = 0x92E9;
        public const uint TESS_EVALUATION_SUBROUTINE = 0x92EA;
        public const uint GEOMETRY_SUBROUTINE = 0x92EB;
        public const uint FRAGMENT_SUBROUTINE = 0x92EC;
        public const uint COMPUTE_SUBROUTINE = 0x92ED;
        public const uint VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
        public const uint TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
        public const uint TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
        public const uint GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
        public const uint FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
        public const uint COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
        public const uint TRANSFORM_FEEDBACK_VARYING = 0x92F4;
        public const uint ACTIVE_RESOURCES = 0x92F5;
        public const uint MAX_NAME_LENGTH = 0x92F6;
        public const uint MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
        public const uint MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
        public const uint NAME_LENGTH = 0x92F9;
        public const uint TYPE = 0x92FA;
        public const uint ARRAY_SIZE = 0x92FB;
        public const uint OFFSET = 0x92FC;
        public const uint BLOCK_INDEX = 0x92FD;
        public const uint ARRAY_STRIDE = 0x92FE;
        public const uint MATRIX_STRIDE = 0x92FF;
        public const uint IS_ROW_MAJOR = 0x9300;
        public const uint ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
        public const uint BUFFER_BINDING = 0x9302;
        public const uint BUFFER_DATA_SIZE = 0x9303;
        public const uint NUM_ACTIVE_VARIABLES = 0x9304;
        public const uint ACTIVE_VARIABLES = 0x9305;
        public const uint REFERENCED_BY_VERTEX_SHADER = 0x9306;
        public const uint REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
        public const uint REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
        public const uint REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
        public const uint REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
        public const uint REFERENCED_BY_COMPUTE_SHADER = 0x930B;
        public const uint TOP_LEVEL_ARRAY_SIZE = 0x930C;
        public const uint TOP_LEVEL_ARRAY_STRIDE = 0x930D;
        public const uint LOCATION = 0x930E;
        public const uint LOCATION_INDEX = 0x930F;
        public const uint ARB_provoking_vertex = 1;
        public const uint QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        public const uint FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const uint LAST_VERTEX_CONVENTION = 0x8E4E;
        public const uint PROVOKING_VERTEX = 0x8E4F;
        public const uint ARB_query_buffer_object = 1;
        public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;
        public const uint QUERY_BUFFER = 0x9192;
        public const uint QUERY_BUFFER_BINDING = 0x9193;
        public const uint QUERY_RESULT_NO_WAIT = 0x9194;
        public const uint ARB_robust_buffer_access_behavior = 1;
        public const uint ARB_robustness = 1;
        public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;
        public const uint LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
        public const uint GUILTY_CONTEXT_RESET_ARB = 0x8253;
        public const uint INNOCENT_CONTEXT_RESET_ARB = 0x8254;
        public const uint UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
        public const uint RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
        public const uint NO_RESET_NOTIFICATION_ARB = 0x8261;
        public const uint ARB_robustness_application_isolation = 1;
        public const uint ARB_robustness_share_group_isolation = 1;
        public const uint ARB_sample_locations = 1;
        public const uint SAMPLE_LOCATION_ARB = 0x8E50;
        public const uint SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;
        public const uint SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;
        public const uint SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;
        public const uint PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;
        public const uint PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;
        public const uint FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;
        public const uint FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;
        public const uint ARB_sample_shading = 1;
        public const uint SAMPLE_SHADING_ARB = 0x8C36;
        public const uint MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;
        public const uint ARB_sampler_objects = 1;
        public const uint SAMPLER_BINDING = 0x8919;
        public const uint ARB_seamless_cube_map = 1;
        public const uint ARB_seamless_cubemap_per_texture = 1;
        public const uint ARB_separate_shader_objects = 1;
        public const uint VERTEX_SHADER_BIT = 0x00000001;
        public const uint FRAGMENT_SHADER_BIT = 0x00000002;
        public const uint GEOMETRY_SHADER_BIT = 0x00000004;
        public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;
        public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;
        public const uint PROGRAM_SEPARABLE = 0x8258;
        public const uint ACTIVE_PROGRAM = 0x8259;
        public const uint PROGRAM_PIPELINE_BINDING = 0x825A;
        public const uint ALL_SHADER_BITS = 0xFFFFFFFF;
        public const uint ARB_shader_atomic_counter_ops = 1;
        public const uint ARB_shader_atomic_counters = 1;
        public const uint ATOMIC_COUNTER_BUFFER = 0x92C0;
        public const uint ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
        public const uint ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        public const uint ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        public const uint ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
        public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
        public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
        public const uint MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const uint MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const uint MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const uint MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const uint MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const uint MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
        public const uint MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        public const uint MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
        public const uint MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
        public const uint MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
        public const uint MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const uint ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
        public const uint UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
        public const uint UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
        public const uint MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const uint ARB_shader_ballot = 1;
        public const uint ARB_shader_bit_encoding = 1;
        public const uint ARB_shader_clock = 1;
        public const uint ARB_shader_draw_parameters = 1;
        public const uint ARB_shader_group_vote = 1;
        public const uint ARB_shader_image_load_store = 1;
        public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
        public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
        public const uint UNIFORM_BARRIER_BIT = 0x00000004;
        public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
        public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
        public const uint COMMAND_BARRIER_BIT = 0x00000040;
        public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
        public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
        public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
        public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;
        public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
        public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
        public const uint MAX_IMAGE_UNITS = 0x8F38;
        public const uint MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        public const uint IMAGE_BINDING_NAME = 0x8F3A;
        public const uint IMAGE_BINDING_LEVEL = 0x8F3B;
        public const uint IMAGE_BINDING_LAYERED = 0x8F3C;
        public const uint IMAGE_BINDING_LAYER = 0x8F3D;
        public const uint IMAGE_BINDING_ACCESS = 0x8F3E;
        public const uint IMAGE_1D = 0x904C;
        public const uint IMAGE_2D = 0x904D;
        public const uint IMAGE_3D = 0x904E;
        public const uint IMAGE_2D_RECT = 0x904F;
        public const uint IMAGE_CUBE = 0x9050;
        public const uint IMAGE_BUFFER = 0x9051;
        public const uint IMAGE_1D_ARRAY = 0x9052;
        public const uint IMAGE_2D_ARRAY = 0x9053;
        public const uint IMAGE_CUBE_MAP_ARRAY = 0x9054;
        public const uint IMAGE_2D_MULTISAMPLE = 0x9055;
        public const uint IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
        public const uint INT_IMAGE_1D = 0x9057;
        public const uint INT_IMAGE_2D = 0x9058;
        public const uint INT_IMAGE_3D = 0x9059;
        public const uint INT_IMAGE_2D_RECT = 0x905A;
        public const uint INT_IMAGE_CUBE = 0x905B;
        public const uint INT_IMAGE_BUFFER = 0x905C;
        public const uint INT_IMAGE_1D_ARRAY = 0x905D;
        public const uint INT_IMAGE_2D_ARRAY = 0x905E;
        public const uint INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
        public const uint INT_IMAGE_2D_MULTISAMPLE = 0x9060;
        public const uint INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
        public const uint UNSIGNED_INT_IMAGE_1D = 0x9062;
        public const uint UNSIGNED_INT_IMAGE_2D = 0x9063;
        public const uint UNSIGNED_INT_IMAGE_3D = 0x9064;
        public const uint UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
        public const uint UNSIGNED_INT_IMAGE_CUBE = 0x9066;
        public const uint UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
        public const uint UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
        public const uint UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
        public const uint UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
        public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
        public const uint MAX_IMAGE_SAMPLES = 0x906D;
        public const uint IMAGE_BINDING_FORMAT = 0x906E;
        public const uint IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const uint IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const uint IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const uint MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        public const uint MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const uint MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const uint MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        public const uint MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        public const uint MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;
        public const uint ARB_shader_image_size = 1;
        public const uint ARB_shader_objects = 1;
        public const uint PROGRAM_OBJECT_ARB = 0x8B40;
        public const uint SHADER_OBJECT_ARB = 0x8B48;
        public const uint OBJECT_TYPE_ARB = 0x8B4E;
        public const uint OBJECT_SUBTYPE_ARB = 0x8B4F;
        public const uint FLOAT_VEC2_ARB = 0x8B50;
        public const uint FLOAT_VEC3_ARB = 0x8B51;
        public const uint FLOAT_VEC4_ARB = 0x8B52;
        public const uint INT_VEC2_ARB = 0x8B53;
        public const uint INT_VEC3_ARB = 0x8B54;
        public const uint INT_VEC4_ARB = 0x8B55;
        public const uint BOOL_ARB = 0x8B56;
        public const uint BOOL_VEC2_ARB = 0x8B57;
        public const uint BOOL_VEC3_ARB = 0x8B58;
        public const uint BOOL_VEC4_ARB = 0x8B59;
        public const uint FLOAT_MAT2_ARB = 0x8B5A;
        public const uint FLOAT_MAT3_ARB = 0x8B5B;
        public const uint FLOAT_MAT4_ARB = 0x8B5C;
        public const uint SAMPLER_1D_ARB = 0x8B5D;
        public const uint SAMPLER_2D_ARB = 0x8B5E;
        public const uint SAMPLER_3D_ARB = 0x8B5F;
        public const uint SAMPLER_CUBE_ARB = 0x8B60;
        public const uint SAMPLER_1D_SHADOW_ARB = 0x8B61;
        public const uint SAMPLER_2D_SHADOW_ARB = 0x8B62;
        public const uint SAMPLER_2D_RECT_ARB = 0x8B63;
        public const uint SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
        public const uint OBJECT_DELETE_STATUS_ARB = 0x8B80;
        public const uint OBJECT_COMPILE_STATUS_ARB = 0x8B81;
        public const uint OBJECT_LINK_STATUS_ARB = 0x8B82;
        public const uint OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
        public const uint OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
        public const uint OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
        public const uint OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
        public const uint OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
        public const uint OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;
        public const uint ARB_shader_precision = 1;
        public const uint ARB_shader_stencil_export = 1;
        public const uint ARB_shader_storage_buffer_object = 1;
        public const uint SHADER_STORAGE_BARRIER_BIT = 0x2000;
        public const uint MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        public const uint SHADER_STORAGE_BUFFER = 0x90D2;
        public const uint SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
        public const uint SHADER_STORAGE_BUFFER_START = 0x90D4;
        public const uint SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
        public const uint MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        public const uint MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        public const uint MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        public const uint MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        public const uint MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        public const uint MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        public const uint MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        public const uint MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        public const uint MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        public const uint SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
        public const uint ARB_shader_subroutine = 1;
        public const uint ACTIVE_SUBROUTINES = 0x8DE5;
        public const uint ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
        public const uint MAX_SUBROUTINES = 0x8DE7;
        public const uint MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
        public const uint ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
        public const uint ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
        public const uint ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
        public const uint NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
        public const uint COMPATIBLE_SUBROUTINES = 0x8E4B;
        public const uint ARB_shader_texture_image_samples = 1;
        public const uint ARB_shader_texture_lod = 1;
        public const uint ARB_shader_viewport_layer_array = 1;
        public const uint ARB_shading_language_100 = 1;
        public const uint SHADING_LANGUAGE_VERSION_ARB = 0x8B8C;
        public const uint ARB_shading_language_420pack = 1;
        public const uint ARB_shading_language_include = 1;
        public const uint SHADER_INCLUDE_ARB = 0x8DAE;
        public const uint NAMED_STRING_LENGTH_ARB = 0x8DE9;
        public const uint NAMED_STRING_TYPE_ARB = 0x8DEA;
        public const uint ARB_shading_language_packing = 1;
        public const uint ARB_shadow = 1;
        public const uint TEXTURE_COMPARE_MODE_ARB = 0x884C;
        public const uint TEXTURE_COMPARE_FUNC_ARB = 0x884D;
        public const uint COMPARE_R_TO_TEXTURE_ARB = 0x884E;
        public const uint ARB_shadow_ambient = 1;
        public const uint TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;
        public const uint ARB_sparse_buffer = 1;
        public const uint SPARSE_STORAGE_BIT_ARB = 0x0400;
        public const uint SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;
        public const uint ARB_sparse_texture = 1;
        public const uint VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;
        public const uint VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;
        public const uint VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;
        public const uint MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;
        public const uint MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;
        public const uint MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;
        public const uint TEXTURE_SPARSE_ARB = 0x91A6;
        public const uint VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;
        public const uint NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;
        public const uint SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;
        public const uint NUM_SPARSE_LEVELS_ARB = 0x91AA;
        public const uint ARB_sparse_texture2 = 1;
        public const uint ARB_sparse_texture_clamp = 1;
        public const uint ARB_spirv_extensions = 1;
        public const uint ARB_stencil_texturing = 1;
        public const uint DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
        public const uint ARB_sync = 1;
        public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        public const uint MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        public const uint OBJECT_TYPE = 0x9112;
        public const uint SYNC_CONDITION = 0x9113;
        public const uint SYNC_STATUS = 0x9114;
        public const uint SYNC_FLAGS = 0x9115;
        public const uint SYNC_FENCE = 0x9116;
        public const uint SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        public const uint UNSIGNALED = 0x9118;
        public const uint SIGNALED = 0x9119;
        public const uint ALREADY_SIGNALED = 0x911A;
        public const uint TIMEOUT_EXPIRED = 0x911B;
        public const uint CONDITION_SATISFIED = 0x911C;
        public const uint WAIT_FAILED = 0x911D;
        public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFFul;
        public const uint ARB_tessellation_shader = 1;
        public const uint PATCHES = 0xE;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
        public const uint MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const uint MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const uint MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const uint MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const uint PATCH_VERTICES = 0x8E72;
        public const uint PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
        public const uint PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
        public const uint TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        public const uint TESS_GEN_MODE = 0x8E76;
        public const uint TESS_GEN_SPACING = 0x8E77;
        public const uint TESS_GEN_VERTEX_ORDER = 0x8E78;
        public const uint TESS_GEN_POINT_MODE = 0x8E79;
        public const uint ISOLINES = 0x8E7A;
        public const uint FRACTIONAL_ODD = 0x8E7B;
        public const uint FRACTIONAL_EVEN = 0x8E7C;
        public const uint MAX_PATCH_VERTICES = 0x8E7D;
        public const uint MAX_TESS_GEN_LEVEL = 0x8E7E;
        public const uint MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const uint MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const uint MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const uint MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const uint MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const uint MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        public const uint MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const uint MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const uint TESS_EVALUATION_SHADER = 0x8E87;
        public const uint TESS_CONTROL_SHADER = 0x8E88;
        public const uint MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        public const uint MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
        public const uint ARB_texture_barrier = 1;
        public const uint ARB_texture_border_clamp = 1;
        public const uint CLAMP_TO_BORDER_ARB = 0x812D;
        public const uint ARB_texture_buffer_object = 1;
        public const uint TEXTURE_BUFFER_ARB = 0x8C2A;
        public const uint MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
        public const uint TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
        public const uint TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
        public const uint TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;
        public const uint ARB_texture_buffer_object_rgb32 = 1;
        public const uint ARB_texture_buffer_range = 1;
        public const uint TEXTURE_BUFFER_OFFSET = 0x919D;
        public const uint TEXTURE_BUFFER_SIZE = 0x919E;
        public const uint TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
        public const uint ARB_texture_compression = 1;
        public const uint COMPRESSED_ALPHA_ARB = 0x84E9;
        public const uint COMPRESSED_LUMINANCE_ARB = 0x84EA;
        public const uint COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
        public const uint COMPRESSED_INTENSITY_ARB = 0x84EC;
        public const uint COMPRESSED_RGB_ARB = 0x84ED;
        public const uint COMPRESSED_RGBA_ARB = 0x84EE;
        public const uint TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
        public const uint TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
        public const uint TEXTURE_COMPRESSED_ARB = 0x86A1;
        public const uint NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
        public const uint COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
        public const uint ARB_texture_compression_bptc = 1;
        public const uint COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C;
        public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D;
        public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E;
        public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F;
        public const uint ARB_texture_compression_rgtc = 1;
        public const uint COMPRESSED_RED_RGTC1 = 0x8DBB;
        public const uint COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
        public const uint COMPRESSED_RG_RGTC2 = 0x8DBD;
        public const uint COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
        public const uint ARB_texture_cube_map = 1;
        public const uint NORMAL_MAP_ARB = 0x8511;
        public const uint REFLECTION_MAP_ARB = 0x8512;
        public const uint TEXTURE_CUBE_MAP_ARB = 0x8513;
        public const uint TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A;
        public const uint PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B;
        public const uint MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C;
        public const uint ARB_texture_cube_map_array = 1;
        public const uint TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;
        public const uint TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;
        public const uint PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;
        public const uint SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;
        public const uint SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;
        public const uint INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;
        public const uint UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;
        public const uint ARB_texture_env_add = 1;
        public const uint ARB_texture_env_combine = 1;
        public const uint SUBTRACT_ARB = 0x84E7;
        public const uint COMBINE_ARB = 0x8570;
        public const uint COMBINE_RGB_ARB = 0x8571;
        public const uint COMBINE_ALPHA_ARB = 0x8572;
        public const uint RGB_SCALE_ARB = 0x8573;
        public const uint ADD_SIGNED_ARB = 0x8574;
        public const uint INTERPOLATE_ARB = 0x8575;
        public const uint CONSTANT_ARB = 0x8576;
        public const uint PRIMARY_COLOR_ARB = 0x8577;
        public const uint PREVIOUS_ARB = 0x8578;
        public const uint SOURCE0_RGB_ARB = 0x8580;
        public const uint SOURCE1_RGB_ARB = 0x8581;
        public const uint SOURCE2_RGB_ARB = 0x8582;
        public const uint SOURCE0_ALPHA_ARB = 0x8588;
        public const uint SOURCE1_ALPHA_ARB = 0x8589;
        public const uint SOURCE2_ALPHA_ARB = 0x858A;
        public const uint OPERAND0_RGB_ARB = 0x8590;
        public const uint OPERAND1_RGB_ARB = 0x8591;
        public const uint OPERAND2_RGB_ARB = 0x8592;
        public const uint OPERAND0_ALPHA_ARB = 0x8598;
        public const uint OPERAND1_ALPHA_ARB = 0x8599;
        public const uint OPERAND2_ALPHA_ARB = 0x859A;
        public const uint ARB_texture_env_crossbar = 1;
        public const uint ARB_texture_env_dot3 = 1;
        public const uint DOT3_RGB_ARB = 0x86AE;
        public const uint DOT3_RGBA_ARB = 0x86AF;
        public const uint ARB_texture_filter_anisotropic = 1;
        public const uint ARB_texture_filter_minmax = 1;
        public const uint TEXTURE_REDUCTION_MODE_ARB = 0x9366;
        public const uint WEIGHTED_AVERAGE_ARB = 0x9367;
        public const uint ARB_texture_float = 1;
        public const uint RGBA32F_ARB = 0x8814;
        public const uint RGB32F_ARB = 0x8815;
        public const uint ALPHA32F_ARB = 0x8816;
        public const uint INTENSITY32F_ARB = 0x8817;
        public const uint LUMINANCE32F_ARB = 0x8818;
        public const uint LUMINANCE_ALPHA32F_ARB = 0x8819;
        public const uint RGBA16F_ARB = 0x881A;
        public const uint RGB16F_ARB = 0x881B;
        public const uint ALPHA16F_ARB = 0x881C;
        public const uint INTENSITY16F_ARB = 0x881D;
        public const uint LUMINANCE16F_ARB = 0x881E;
        public const uint LUMINANCE_ALPHA16F_ARB = 0x881F;
        public const uint TEXTURE_RED_TYPE_ARB = 0x8C10;
        public const uint TEXTURE_GREEN_TYPE_ARB = 0x8C11;
        public const uint TEXTURE_BLUE_TYPE_ARB = 0x8C12;
        public const uint TEXTURE_ALPHA_TYPE_ARB = 0x8C13;
        public const uint TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;
        public const uint TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;
        public const uint TEXTURE_DEPTH_TYPE_ARB = 0x8C16;
        public const uint UNSIGNED_NORMALIZED_ARB = 0x8C17;
        public const uint ARB_texture_gather = 1;
        public const uint MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E;
        public const uint MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F;
        public const uint MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F;
        public const uint ARB_texture_mirror_clamp_to_edge = 1;
        public const uint MIRROR_CLAMP_TO_EDGE = 0x8743;
        public const uint ARB_texture_mirrored_repeat = 1;
        public const uint MIRRORED_REPEAT_ARB = 0x8370;
        public const uint ARB_texture_multisample = 1;
        public const uint SAMPLE_POSITION = 0x8E50;
        public const uint SAMPLE_MASK = 0x8E51;
        public const uint SAMPLE_MASK_VALUE = 0x8E52;
        public const uint MAX_SAMPLE_MASK_WORDS = 0x8E59;
        public const uint TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const uint PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
        public const uint TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const uint PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
        public const uint TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const uint TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const uint TEXTURE_SAMPLES = 0x9106;
        public const uint TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const uint SAMPLER_2D_MULTISAMPLE = 0x9108;
        public const uint INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const uint SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        public const uint INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        public const uint MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        public const uint MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        public const uint MAX_INTEGER_SAMPLES = 0x9110;
        public const uint ARB_texture_non_power_of_two = 1;
        public const uint ARB_texture_query_levels = 1;
        public const uint ARB_texture_query_lod = 1;
        public const uint ARB_texture_rectangle = 1;
        public const uint TEXTURE_RECTANGLE_ARB = 0x84F5;
        public const uint TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6;
        public const uint PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7;
        public const uint MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8;
        public const uint ARB_texture_rg = 1;
        public const uint COMPRESSED_RED = 0x8225;
        public const uint COMPRESSED_RG = 0x8226;
        public const uint RG = 0x8227;
        public const uint RG_INTEGER = 0x8228;
        public const uint R8 = 0x8229;
        public const uint R16 = 0x822A;
        public const uint RG8 = 0x822B;
        public const uint RG16 = 0x822C;
        public const uint R16F = 0x822D;
        public const uint R32F = 0x822E;
        public const uint RG16F = 0x822F;
        public const uint RG32F = 0x8230;
        public const uint R8I = 0x8231;
        public const uint R8UI = 0x8232;
        public const uint R16I = 0x8233;
        public const uint R16UI = 0x8234;
        public const uint R32I = 0x8235;
        public const uint R32UI = 0x8236;
        public const uint RG8I = 0x8237;
        public const uint RG16I = 0x8239;
        public const uint RG32I = 0x823B;
        public const uint RG32UI = 0x823C;
        public const uint ARB_texture_rgb10_a2ui = 1;
        public const uint ARB_texture_stencil8 = 1;
        public const uint ARB_texture_storage = 1;
        public const uint TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const uint ARB_texture_storage_multisample = 1;
        public const uint ARB_texture_swizzle = 1;
        public const uint TEXTURE_SWIZZLE_R = 0x8E42;
        public const uint TEXTURE_SWIZZLE_G = 0x8E43;
        public const uint TEXTURE_SWIZZLE_B = 0x8E44;
        public const uint TEXTURE_SWIZZLE_A = 0x8E45;
        public const uint TEXTURE_SWIZZLE_RGBA = 0x8E46;
        public const uint ARB_texture_view = 1;
        public const uint TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
        public const uint TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
        public const uint TEXTURE_VIEW_MIN_LAYER = 0x82DD;
        public const uint TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
        public const uint ARB_timer_query = 1;
        public const uint TIME_ELAPSED = 0x88BF;
        public const uint TIMESTAMP = 0x8E28;
        public const uint ARB_transform_feedback2 = 1;
        public const uint TRANSFORM_FEEDBACK = 0x8E22;
        public const uint TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        public const uint TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
        public const uint TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        public const uint ARB_transform_feedback3 = 1;
        public const uint MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const uint ARB_transform_feedback_instanced = 1;
        public const uint ARB_transform_feedback_overflow_query = 1;
        public const uint TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC;
        public const uint TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED;
        public const uint ARB_transpose_matrix = 1;
        public const uint TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
        public const uint TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
        public const uint TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
        public const uint TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
        public const uint ARB_uniform_buffer_object = 1;
        public const uint UNIFORM_BUFFER = 0x8A11;
        public const uint UNIFORM_BUFFER_BINDING = 0x8A28;
        public const uint UNIFORM_BUFFER_START = 0x8A29;
        public const uint UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const uint MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const uint MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        public const uint MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const uint MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const uint MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const uint MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const uint MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const uint MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        public const uint MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const uint UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const uint ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const uint ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        public const uint UNIFORM_TYPE = 0x8A37;
        public const uint UNIFORM_SIZE = 0x8A38;
        public const uint UNIFORM_NAME_LENGTH = 0x8A39;
        public const uint UNIFORM_BLOCK_INDEX = 0x8A3A;
        public const uint UNIFORM_OFFSET = 0x8A3B;
        public const uint UNIFORM_ARRAY_STRIDE = 0x8A3C;
        public const uint UNIFORM_MATRIX_STRIDE = 0x8A3D;
        public const uint UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        public const uint UNIFORM_BLOCK_BINDING = 0x8A3F;
        public const uint UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        public const uint UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        public const uint UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        public const uint UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint INVALID_INDEX = 0xFFFFFFFFu;
        public const uint ARB_vertex_array_bgra = 1;
        public const uint ARB_vertex_array_object = 1;
        public const uint VERTEX_ARRAY_BINDING = 0x85B5;
        public const uint ARB_vertex_attrib_64bit = 1;
        public const uint ARB_vertex_attrib_binding = 1;
        public const uint VERTEX_ATTRIB_BINDING = 0x82D4;
        public const uint VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
        public const uint VERTEX_BINDING_DIVISOR = 0x82D6;
        public const uint VERTEX_BINDING_OFFSET = 0x82D7;
        public const uint VERTEX_BINDING_STRIDE = 0x82D8;
        public const uint MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        public const uint MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
        public const uint VERTEX_BINDING_BUFFER = 0x8F4F;
        public const uint ARB_vertex_blend = 1;
        public const uint MODELVIEW0_ARB = 0x1700;
        public const uint MODELVIEW1_ARB = 0x850A;
        public const uint MAX_VERTEX_UNITS_ARB = 0x86A4;
        public const uint ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
        public const uint WEIGHT_SUM_UNITY_ARB = 0x86A6;
        public const uint VERTEX_BLEND_ARB = 0x86A7;
        public const uint CURRENT_WEIGHT_ARB = 0x86A8;
        public const uint WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
        public const uint WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
        public const uint WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
        public const uint WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
        public const uint WEIGHT_ARRAY_ARB = 0x86AD;
        public const uint MODELVIEW2_ARB = 0x8722;
        public const uint MODELVIEW3_ARB = 0x8723;
        public const uint MODELVIEW4_ARB = 0x8724;
        public const uint MODELVIEW5_ARB = 0x8725;
        public const uint MODELVIEW6_ARB = 0x8726;
        public const uint MODELVIEW7_ARB = 0x8727;
        public const uint MODELVIEW8_ARB = 0x8728;
        public const uint MODELVIEW9_ARB = 0x8729;
        public const uint MODELVIEW10_ARB = 0x872A;
        public const uint MODELVIEW11_ARB = 0x872B;
        public const uint MODELVIEW12_ARB = 0x872C;
        public const uint MODELVIEW13_ARB = 0x872D;
        public const uint MODELVIEW14_ARB = 0x872E;
        public const uint MODELVIEW15_ARB = 0x872F;
        public const uint MODELVIEW16_ARB = 0x8730;
        public const uint MODELVIEW17_ARB = 0x8731;
        public const uint MODELVIEW18_ARB = 0x8732;
        public const uint MODELVIEW19_ARB = 0x8733;
        public const uint MODELVIEW20_ARB = 0x8734;
        public const uint MODELVIEW21_ARB = 0x8735;
        public const uint MODELVIEW22_ARB = 0x8736;
        public const uint MODELVIEW23_ARB = 0x8737;
        public const uint MODELVIEW24_ARB = 0x8738;
        public const uint MODELVIEW25_ARB = 0x8739;
        public const uint MODELVIEW26_ARB = 0x873A;
        public const uint MODELVIEW27_ARB = 0x873B;
        public const uint MODELVIEW28_ARB = 0x873C;
        public const uint MODELVIEW29_ARB = 0x873D;
        public const uint MODELVIEW30_ARB = 0x873E;
        public const uint MODELVIEW31_ARB = 0x873F;
        public const uint ARB_vertex_buffer_object = 1;
        public const uint BUFFER_SIZE_ARB = 0x8764;
        public const uint BUFFER_USAGE_ARB = 0x8765;
        public const uint ARRAY_BUFFER_ARB = 0x8892;
        public const uint ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
        public const uint ARRAY_BUFFER_BINDING_ARB = 0x8894;
        public const uint ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
        public const uint VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
        public const uint NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
        public const uint COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
        public const uint INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
        public const uint TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
        public const uint EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
        public const uint SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
        public const uint FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
        public const uint WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
        public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
        public const uint READ_ONLY_ARB = 0x88B8;
        public const uint WRITE_ONLY_ARB = 0x88B9;
        public const uint READ_WRITE_ARB = 0x88BA;
        public const uint BUFFER_ACCESS_ARB = 0x88BB;
        public const uint BUFFER_MAPPED_ARB = 0x88BC;
        public const uint BUFFER_MAP_POINTER_ARB = 0x88BD;
        public const uint STREAM_DRAW_ARB = 0x88E0;
        public const uint STREAM_READ_ARB = 0x88E1;
        public const uint STREAM_COPY_ARB = 0x88E2;
        public const uint STATIC_DRAW_ARB = 0x88E4;
        public const uint STATIC_READ_ARB = 0x88E5;
        public const uint STATIC_COPY_ARB = 0x88E6;
        public const uint DYNAMIC_DRAW_ARB = 0x88E8;
        public const uint DYNAMIC_READ_ARB = 0x88E9;
        public const uint DYNAMIC_COPY_ARB = 0x88EA;
        public const uint ARB_vertex_program = 1;
        public const uint COLOR_SUM_ARB = 0x8458;
        public const uint VERTEX_PROGRAM_ARB = 0x8620;
        public const uint VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
        public const uint VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
        public const uint VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
        public const uint VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
        public const uint CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
        public const uint PROGRAM_LENGTH_ARB = 0x8627;
        public const uint PROGRAM_STRING_ARB = 0x8628;
        public const uint MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
        public const uint MAX_PROGRAM_MATRICES_ARB = 0x862F;
        public const uint CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
        public const uint CURRENT_MATRIX_ARB = 0x8641;
        public const uint VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const uint VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
        public const uint VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
        public const uint PROGRAM_ERROR_POSITION_ARB = 0x864B;
        public const uint PROGRAM_BINDING_ARB = 0x8677;
        public const uint MAX_VERTEX_ATTRIBS_ARB = 0x8869;
        public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
        public const uint PROGRAM_ERROR_STRING_ARB = 0x8874;
        public const uint PROGRAM_FORMAT_ASCII_ARB = 0x8875;
        public const uint PROGRAM_FORMAT_ARB = 0x8876;
        public const uint PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
        public const uint MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
        public const uint PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
        public const uint MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
        public const uint PROGRAM_TEMPORARIES_ARB = 0x88A4;
        public const uint MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
        public const uint PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
        public const uint MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
        public const uint PROGRAM_PARAMETERS_ARB = 0x88A8;
        public const uint MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
        public const uint PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
        public const uint MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
        public const uint PROGRAM_ATTRIBS_ARB = 0x88AC;
        public const uint MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
        public const uint PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
        public const uint MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
        public const uint PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
        public const uint MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
        public const uint PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
        public const uint MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
        public const uint MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
        public const uint MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
        public const uint PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
        public const uint TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
        public const uint MATRIX0_ARB = 0x88C0;
        public const uint MATRIX1_ARB = 0x88C1;
        public const uint MATRIX2_ARB = 0x88C2;
        public const uint MATRIX3_ARB = 0x88C3;
        public const uint MATRIX4_ARB = 0x88C4;
        public const uint MATRIX5_ARB = 0x88C5;
        public const uint MATRIX6_ARB = 0x88C6;
        public const uint MATRIX7_ARB = 0x88C7;
        public const uint MATRIX8_ARB = 0x88C8;
        public const uint MATRIX9_ARB = 0x88C9;
        public const uint MATRIX10_ARB = 0x88CA;
        public const uint MATRIX11_ARB = 0x88CB;
        public const uint MATRIX12_ARB = 0x88CC;
        public const uint MATRIX13_ARB = 0x88CD;
        public const uint MATRIX14_ARB = 0x88CE;
        public const uint MATRIX15_ARB = 0x88CF;
        public const uint MATRIX16_ARB = 0x88D0;
        public const uint MATRIX17_ARB = 0x88D1;
        public const uint MATRIX18_ARB = 0x88D2;
        public const uint MATRIX19_ARB = 0x88D3;
        public const uint MATRIX20_ARB = 0x88D4;
        public const uint MATRIX21_ARB = 0x88D5;
        public const uint MATRIX22_ARB = 0x88D6;
        public const uint MATRIX23_ARB = 0x88D7;
        public const uint MATRIX24_ARB = 0x88D8;
        public const uint MATRIX25_ARB = 0x88D9;
        public const uint MATRIX26_ARB = 0x88DA;
        public const uint MATRIX27_ARB = 0x88DB;
        public const uint MATRIX28_ARB = 0x88DC;
        public const uint MATRIX29_ARB = 0x88DD;
        public const uint MATRIX30_ARB = 0x88DE;
        public const uint MATRIX31_ARB = 0x88DF;
        public const uint ARB_vertex_shader = 1;
        public const uint VERTEX_SHADER_ARB = 0x8B31;
        public const uint MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
        public const uint MAX_VARYING_FLOATS_ARB = 0x8B4B;
        public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
        public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
        public const uint OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
        public const uint OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;
        public const uint ARB_vertex_type_10f_11f_11f_rev = 1;
        public const uint ARB_vertex_type_2_10_10_10_rev = 1;
        public const uint UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const uint INT_2_10_10_10_REV = 0x8D9F;
        public const uint ARB_viewport_array = 1;
        public const uint MAX_VIEWPORTS = 0x825B;
        public const uint VIEWPORT_SUBPIXEL_BITS = 0x825C;
        public const uint VIEWPORT_BOUNDS_RANGE = 0x825D;
        public const uint LAYER_PROVOKING_VERTEX = 0x825E;
        public const uint VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
        public const uint UNDEFINED_VERTEX = 0x8260;
        public const uint ARB_window_pos = 1;
        public const uint ARM_mali_program_binary = 1;
        public const uint MALI_PROGRAM_BINARY_ARM = 0x8F61;
        public const uint ARM_mali_shader_binary = 1;
        public const uint MALI_SHADER_BINARY_ARM = 0x8F60;
        public const uint ARM_rgba8 = 1;
        public const uint RGBA8_OES = 0x8058;
        public const uint ARM_shader_framebuffer_fetch = 1;
        public const uint FETCH_PER_SAMPLE_ARM = 0x8F65;
        public const uint FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM = 0x8F66;
        public const uint ARM_shader_framebuffer_fetch_depth_stencil = 1;
        public const uint ATIX_point_sprites = 1;
        public const uint TEXTURE_POINT_MODE_ATIX = 0x60B0;
        public const uint TEXTURE_POINT_ONE_COORD_ATIX = 0x60B1;
        public const uint TEXTURE_POINT_SPRITE_ATIX = 0x60B2;
        public const uint POINT_SPRITE_CULL_MODE_ATIX = 0x60B3;
        public const uint POINT_SPRITE_CULL_CENTER_ATIX = 0x60B4;
        public const uint POINT_SPRITE_CULL_CLIP_ATIX = 0x60B5;
        public const uint ATIX_texture_env_combine3 = 1;
        public const uint MODULATE_ADD_ATIX = 0x8744;
        public const uint MODULATE_SIGNED_ADD_ATIX = 0x8745;
        public const uint MODULATE_SUBTRACT_ATIX = 0x8746;
        public const uint ATIX_texture_env_route = 1;
        public const uint SECONDARY_COLOR_ATIX = 0x8747;
        public const uint TEXTURE_OUTPUT_RGB_ATIX = 0x8748;
        public const uint TEXTURE_OUTPUT_ALPHA_ATIX = 0x8749;
        public const uint ATIX_vertex_shader_output_point_size = 1;
        public const uint OUTPUT_POINT_SIZE_ATIX = 0x610E;
        public const uint ATI_draw_buffers = 1;
        public const uint MAX_DRAW_BUFFERS_ATI = 0x8824;
        public const uint DRAW_BUFFER0_ATI = 0x8825;
        public const uint DRAW_BUFFER1_ATI = 0x8826;
        public const uint DRAW_BUFFER2_ATI = 0x8827;
        public const uint DRAW_BUFFER3_ATI = 0x8828;
        public const uint DRAW_BUFFER4_ATI = 0x8829;
        public const uint DRAW_BUFFER5_ATI = 0x882A;
        public const uint DRAW_BUFFER6_ATI = 0x882B;
        public const uint DRAW_BUFFER7_ATI = 0x882C;
        public const uint DRAW_BUFFER8_ATI = 0x882D;
        public const uint DRAW_BUFFER9_ATI = 0x882E;
        public const uint DRAW_BUFFER10_ATI = 0x882F;
        public const uint DRAW_BUFFER11_ATI = 0x8830;
        public const uint DRAW_BUFFER12_ATI = 0x8831;
        public const uint DRAW_BUFFER13_ATI = 0x8832;
        public const uint DRAW_BUFFER14_ATI = 0x8833;
        public const uint DRAW_BUFFER15_ATI = 0x8834;
        public const uint ATI_element_array = 1;
        public const uint ELEMENT_ARRAY_ATI = 0x8768;
        public const uint ELEMENT_ARRAY_TYPE_ATI = 0x8769;
        public const uint ELEMENT_ARRAY_POINTER_ATI = 0x876A;
        public const uint ATI_envmap_bumpmap = 1;
        public const uint BUMP_ROT_MATRIX_ATI = 0x8775;
        public const uint BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;
        public const uint BUMP_NUM_TEX_UNITS_ATI = 0x8777;
        public const uint BUMP_TEX_UNITS_ATI = 0x8778;
        public const uint DUDV_ATI = 0x8779;
        public const uint DU8DV8_ATI = 0x877A;
        public const uint BUMP_ENVMAP_ATI = 0x877B;
        public const uint BUMP_TARGET_ATI = 0x877C;
        public const uint ATI_fragment_shader = 1;
        public const uint _2X_BIT_ATI = 0x00000001;
        public const uint RED_BIT_ATI = 0x00000001;
        public const uint _4X_BIT_ATI = 0x00000002;
        public const uint COMP_BIT_ATI = 0x00000002;
        public const uint GREEN_BIT_ATI = 0x00000002;
        public const uint _8X_BIT_ATI = 0x00000004;
        public const uint BLUE_BIT_ATI = 0x00000004;
        public const uint NEGATE_BIT_ATI = 0x00000004;
        public const uint BIAS_BIT_ATI = 0x00000008;
        public const uint HALF_BIT_ATI = 0x00000008;
        public const uint QUARTER_BIT_ATI = 0x00000010;
        public const uint EIGHTH_BIT_ATI = 0x00000020;
        public const uint SATURATE_BIT_ATI = 0x00000040;
        public const uint FRAGMENT_SHADER_ATI = 0x8920;
        public const uint REG_0_ATI = 0x8921;
        public const uint REG_1_ATI = 0x8922;
        public const uint REG_2_ATI = 0x8923;
        public const uint REG_3_ATI = 0x8924;
        public const uint REG_4_ATI = 0x8925;
        public const uint REG_5_ATI = 0x8926;
        public const uint CON_0_ATI = 0x8941;
        public const uint CON_1_ATI = 0x8942;
        public const uint CON_2_ATI = 0x8943;
        public const uint CON_3_ATI = 0x8944;
        public const uint CON_4_ATI = 0x8945;
        public const uint CON_5_ATI = 0x8946;
        public const uint CON_6_ATI = 0x8947;
        public const uint CON_7_ATI = 0x8948;
        public const uint MOV_ATI = 0x8961;
        public const uint ADD_ATI = 0x8963;
        public const uint MUL_ATI = 0x8964;
        public const uint SUB_ATI = 0x8965;
        public const uint DOT3_ATI = 0x8966;
        public const uint DOT4_ATI = 0x8967;
        public const uint MAD_ATI = 0x8968;
        public const uint LERP_ATI = 0x8969;
        public const uint CND_ATI = 0x896A;
        public const uint CND0_ATI = 0x896B;
        public const uint DOT2_ADD_ATI = 0x896C;
        public const uint SECONDARY_INTERPOLATOR_ATI = 0x896D;
        public const uint NUM_FRAGMENT_REGISTERS_ATI = 0x896E;
        public const uint NUM_FRAGMENT_CONSTANTS_ATI = 0x896F;
        public const uint NUM_PASSES_ATI = 0x8970;
        public const uint NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971;
        public const uint NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972;
        public const uint NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;
        public const uint NUM_LOOPBACK_COMPONENTS_ATI = 0x8974;
        public const uint COLOR_ALPHA_PAIRING_ATI = 0x8975;
        public const uint SWIZZLE_STR_ATI = 0x8976;
        public const uint SWIZZLE_STQ_ATI = 0x8977;
        public const uint SWIZZLE_STR_DR_ATI = 0x8978;
        public const uint SWIZZLE_STQ_DQ_ATI = 0x8979;
        public const uint SWIZZLE_STRQ_ATI = 0x897A;
        public const uint SWIZZLE_STRQ_DQ_ATI = 0x897B;
        public const uint ATI_map_object_buffer = 1;
        public const uint ATI_meminfo = 1;
        public const uint VBO_FREE_MEMORY_ATI = 0x87FB;
        public const uint TEXTURE_FREE_MEMORY_ATI = 0x87FC;
        public const uint RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;
        public const uint ATI_pn_triangles = 1;
        public const uint PN_TRIANGLES_ATI = 0x87F0;
        public const uint MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
        public const uint PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;
        public const uint PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;
        public const uint PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;
        public const uint PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
        public const uint PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
        public const uint PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
        public const uint PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
        public const uint ATI_separate_stencil = 1;
        public const uint STENCIL_BACK_FUNC_ATI = 0x8800;
        public const uint STENCIL_BACK_FAIL_ATI = 0x8801;
        public const uint STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;
        public const uint STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;
        public const uint ATI_shader_texture_lod = 1;
        public const uint ATI_text_fragment_shader = 1;
        public const uint TEXT_FRAGMENT_SHADER_ATI = 0x8200;
        public const uint ATI_texture_compression_3dc = 1;
        public const uint COMPRESSED_LUMINANCE_ALPHA_3DC_ATI = 0x8837;
        public const uint ATI_texture_env_combine3 = 1;
        public const uint MODULATE_ADD_ATI = 0x8744;
        public const uint MODULATE_SIGNED_ADD_ATI = 0x8745;
        public const uint MODULATE_SUBTRACT_ATI = 0x8746;
        public const uint ATI_texture_float = 1;
        public const uint RGBA_FLOAT32_ATI = 0x8814;
        public const uint RGB_FLOAT32_ATI = 0x8815;
        public const uint ALPHA_FLOAT32_ATI = 0x8816;
        public const uint INTENSITY_FLOAT32_ATI = 0x8817;
        public const uint LUMINANCE_FLOAT32_ATI = 0x8818;
        public const uint LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819;
        public const uint RGBA_FLOAT16_ATI = 0x881A;
        public const uint RGB_FLOAT16_ATI = 0x881B;
        public const uint ALPHA_FLOAT16_ATI = 0x881C;
        public const uint INTENSITY_FLOAT16_ATI = 0x881D;
        public const uint LUMINANCE_FLOAT16_ATI = 0x881E;
        public const uint LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F;
        public const uint ATI_texture_mirror_once = 1;
        public const uint MIRROR_CLAMP_ATI = 0x8742;
        public const uint MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
        public const uint ATI_vertex_array_object = 1;
        public const uint STATIC_ATI = 0x8760;
        public const uint DYNAMIC_ATI = 0x8761;
        public const uint PRESERVE_ATI = 0x8762;
        public const uint DISCARD_ATI = 0x8763;
        public const uint OBJECT_BUFFER_SIZE_ATI = 0x8764;
        public const uint OBJECT_BUFFER_USAGE_ATI = 0x8765;
        public const uint ARRAY_OBJECT_BUFFER_ATI = 0x8766;
        public const uint ARRAY_OBJECT_OFFSET_ATI = 0x8767;
        public const uint ATI_vertex_attrib_array_object = 1;
        public const uint ATI_vertex_streams = 1;
        public const uint MAX_VERTEX_STREAMS_ATI = 0x876B;
        public const uint VERTEX_SOURCE_ATI = 0x876C;
        public const uint VERTEX_STREAM0_ATI = 0x876D;
        public const uint VERTEX_STREAM1_ATI = 0x876E;
        public const uint VERTEX_STREAM2_ATI = 0x876F;
        public const uint VERTEX_STREAM3_ATI = 0x8770;
        public const uint VERTEX_STREAM4_ATI = 0x8771;
        public const uint VERTEX_STREAM5_ATI = 0x8772;
        public const uint VERTEX_STREAM6_ATI = 0x8773;
        public const uint VERTEX_STREAM7_ATI = 0x8774;
        public const uint EGL_KHR_context_flush_control = 1;
        public const uint EGL_NV_robustness_video_memory_purge = 1;
        public const uint EGL_GENERATE_RESET_ON_VIDEO_MEMORY_PURGE_NV = 0x334C;
        public const uint PURGED_CONTEXT_RESET_NV = 0x92BB;
        public const uint EXT_422_pixels = 1;
        public const uint _422_EXT = 0x80CC;
        public const uint _422_REV_EXT = 0x80CD;
        public const uint _422_AVERAGE_EXT = 0x80CE;
        public const uint _422_REV_AVERAGE_EXT = 0x80CF;
        public const uint EXT_Cg_shader = 1;
        public const uint CG_VERTEX_SHADER_EXT = 0x890E;
        public const uint CG_FRAGMENT_SHADER_EXT = 0x890F;
        public const uint EXT_EGL_image_array = 1;
        public const uint EXT_YUV_target = 1;
        public const uint SAMPLER_EXTERNAL_2D_Y2Y_EXT = 0x8BE7;
        public const uint EXT_abgr = 1;
        public const uint ABGR_EXT = 0x8000;
        public const uint EXT_base_instance = 1;
        public const uint EXT_bgra = 1;
        public const uint BGR_EXT = 0x80E0;
        public const uint EXT_bindable_uniform = 1;
        public const uint MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
        public const uint MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
        public const uint MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
        public const uint MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
        public const uint UNIFORM_BUFFER_EXT = 0x8DEE;
        public const uint UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;
        public const uint EXT_blend_color = 1;
        public const uint CONSTANT_COLOR_EXT = 0x8001;
        public const uint ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
        public const uint CONSTANT_ALPHA_EXT = 0x8003;
        public const uint ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
        public const uint BLEND_COLOR_EXT = 0x8005;
        public const uint EXT_blend_equation_separate = 1;
        public const uint BLEND_EQUATION_RGB_EXT = 0x8009;
        public const uint BLEND_EQUATION_ALPHA_EXT = 0x883D;
        public const uint EXT_blend_func_extended = 1;
        public const uint SRC_ALPHA_SATURATE_EXT = 0x0308;
        public const uint SRC1_ALPHA_EXT = 0x8589;
        public const uint SRC1_COLOR_EXT = 0x88F9;
        public const uint ONE_MINUS_SRC1_COLOR_EXT = 0x88FA;
        public const uint ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB;
        public const uint MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC;
        public const uint LOCATION_INDEX_EXT = 0x930F;
        public const uint EXT_blend_func_separate = 1;
        public const uint BLEND_DST_RGB_EXT = 0x80C8;
        public const uint BLEND_SRC_RGB_EXT = 0x80C9;
        public const uint BLEND_DST_ALPHA_EXT = 0x80CA;
        public const uint BLEND_SRC_ALPHA_EXT = 0x80CB;
        public const uint EXT_blend_logic_op = 1;
        public const uint EXT_blend_minmax = 1;
        public const uint FUNC_ADD_EXT = 0x8006;
        public const uint MIN_EXT = 0x8007;
        public const uint MAX_EXT = 0x8008;
        public const uint BLEND_EQUATION_EXT = 0x8009;
        public const uint EXT_blend_subtract = 1;
        public const uint FUNC_SUBTRACT_EXT = 0x800A;
        public const uint FUNC_REVERSE_SUBTRACT_EXT = 0x800B;
        public const uint EXT_buffer_storage = 1;
        public const uint MAP_PERSISTENT_BIT_EXT = 0x0040;
        public const uint MAP_COHERENT_BIT_EXT = 0x0080;
        public const uint DYNAMIC_STORAGE_BIT_EXT = 0x0100;
        public const uint CLIENT_STORAGE_BIT_EXT = 0x0200;
        public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000;
        public const uint BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F;
        public const uint BUFFER_STORAGE_FLAGS_EXT = 0x8220;
        public const uint EXT_clear_texture = 1;
        public const uint EXT_clip_cull_distance = 1;
        public const uint MAX_CLIP_DISTANCES_EXT = 0x0D32;
        public const uint CLIP_DISTANCE0_EXT = 0x3000;
        public const uint CLIP_DISTANCE1_EXT = 0x3001;
        public const uint CLIP_DISTANCE2_EXT = 0x3002;
        public const uint CLIP_DISTANCE3_EXT = 0x3003;
        public const uint CLIP_DISTANCE4_EXT = 0x3004;
        public const uint CLIP_DISTANCE5_EXT = 0x3005;
        public const uint CLIP_DISTANCE6_EXT = 0x3006;
        public const uint CLIP_DISTANCE7_EXT = 0x3007;
        public const uint MAX_CULL_DISTANCES_EXT = 0x82F9;
        public const uint MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT = 0x82FA;
        public const uint EXT_clip_volume_hint = 1;
        public const uint CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0;
        public const uint EXT_cmyka = 1;
        public const uint CMYK_EXT = 0x800C;
        public const uint CMYKA_EXT = 0x800D;
        public const uint PACK_CMYK_HINT_EXT = 0x800E;
        public const uint UNPACK_CMYK_HINT_EXT = 0x800F;
        public const uint EXT_color_buffer_float = 1;
        public const uint EXT_color_buffer_half_float = 1;
        public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;
        public const uint R16F_EXT = 0x822D;
        public const uint RG16F_EXT = 0x822F;
        public const uint RGBA16F_EXT = 0x881A;
        public const uint RGB16F_EXT = 0x881B;
        public const uint UNSIGNED_NORMALIZED_EXT = 0x8C17;
        public const uint EXT_color_subtable = 1;
        public const uint EXT_compiled_vertex_array = 1;
        public const uint ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
        public const uint ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
        public const uint EXT_compressed_ETC1_RGB8_sub_texture = 1;
        public const uint EXT_conservative_depth = 1;
        public const uint EXT_convolution = 1;
        public const uint CONVOLUTION_1D_EXT = 0x8010;
        public const uint CONVOLUTION_2D_EXT = 0x8011;
        public const uint SEPARABLE_2D_EXT = 0x8012;
        public const uint CONVOLUTION_BORDER_MODE_EXT = 0x8013;
        public const uint CONVOLUTION_FILTER_SCALE_EXT = 0x8014;
        public const uint CONVOLUTION_FILTER_BIAS_EXT = 0x8015;
        public const uint REDUCE_EXT = 0x8016;
        public const uint CONVOLUTION_FORMAT_EXT = 0x8017;
        public const uint CONVOLUTION_WIDTH_EXT = 0x8018;
        public const uint CONVOLUTION_HEIGHT_EXT = 0x8019;
        public const uint MAX_CONVOLUTION_WIDTH_EXT = 0x801A;
        public const uint MAX_CONVOLUTION_HEIGHT_EXT = 0x801B;
        public const uint POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;
        public const uint POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;
        public const uint POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;
        public const uint POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;
        public const uint POST_CONVOLUTION_RED_BIAS_EXT = 0x8020;
        public const uint POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;
        public const uint POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;
        public const uint POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;
        public const uint EXT_coordinate_frame = 1;
        public const uint TANGENT_ARRAY_EXT = 0x8439;
        public const uint BINORMAL_ARRAY_EXT = 0x843A;
        public const uint CURRENT_TANGENT_EXT = 0x843B;
        public const uint CURRENT_BINORMAL_EXT = 0x843C;
        public const uint TANGENT_ARRAY_TYPE_EXT = 0x843E;
        public const uint TANGENT_ARRAY_STRIDE_EXT = 0x843F;
        public const uint BINORMAL_ARRAY_TYPE_EXT = 0x8440;
        public const uint BINORMAL_ARRAY_STRIDE_EXT = 0x8441;
        public const uint TANGENT_ARRAY_POINTER_EXT = 0x8442;
        public const uint BINORMAL_ARRAY_POINTER_EXT = 0x8443;
        public const uint MAP1_TANGENT_EXT = 0x8444;
        public const uint MAP2_TANGENT_EXT = 0x8445;
        public const uint MAP1_BINORMAL_EXT = 0x8446;
        public const uint MAP2_BINORMAL_EXT = 0x8447;
        public const uint EXT_copy_image = 1;
        public const uint EXT_copy_texture = 1;
        public const uint EXT_cull_vertex = 1;
        public const uint CULL_VERTEX_EXT = 0x81AA;
        public const uint CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;
        public const uint CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;
        public const uint EXT_debug_label = 1;
        public const uint PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;
        public const uint PROGRAM_OBJECT_EXT = 0x8B40;
        public const uint SHADER_OBJECT_EXT = 0x8B48;
        public const uint BUFFER_OBJECT_EXT = 0x9151;
        public const uint QUERY_OBJECT_EXT = 0x9153;
        public const uint VERTEX_ARRAY_OBJECT_EXT = 0x9154;
        public const uint EXT_debug_marker = 1;
        public const uint EXT_depth_bounds_test = 1;
        public const uint DEPTH_BOUNDS_TEST_EXT = 0x8890;
        public const uint DEPTH_BOUNDS_EXT = 0x8891;
        public const uint EXT_direct_state_access = 1;
        public const uint PROGRAM_MATRIX_EXT = 0x8E2D;
        public const uint TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
        public const uint PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;
        public const uint EXT_discard_framebuffer = 1;
        public const uint COLOR_EXT = 0x1800;
        public const uint DEPTH_EXT = 0x1801;
        public const uint STENCIL_EXT = 0x1802;
        public const uint EXT_draw_buffers = 1;
        public const uint MAX_DRAW_BUFFERS_EXT = 0x8824;
        public const uint DRAW_BUFFER0_EXT = 0x8825;
        public const uint DRAW_BUFFER1_EXT = 0x8826;
        public const uint DRAW_BUFFER2_EXT = 0x8827;
        public const uint DRAW_BUFFER3_EXT = 0x8828;
        public const uint DRAW_BUFFER4_EXT = 0x8829;
        public const uint DRAW_BUFFER5_EXT = 0x882A;
        public const uint DRAW_BUFFER6_EXT = 0x882B;
        public const uint DRAW_BUFFER7_EXT = 0x882C;
        public const uint DRAW_BUFFER8_EXT = 0x882D;
        public const uint DRAW_BUFFER9_EXT = 0x882E;
        public const uint DRAW_BUFFER10_EXT = 0x882F;
        public const uint DRAW_BUFFER11_EXT = 0x8830;
        public const uint DRAW_BUFFER12_EXT = 0x8831;
        public const uint DRAW_BUFFER13_EXT = 0x8832;
        public const uint DRAW_BUFFER14_EXT = 0x8833;
        public const uint DRAW_BUFFER15_EXT = 0x8834;
        public const uint MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF;
        public const uint COLOR_ATTACHMENT0_EXT = 0x8CE0;
        public const uint COLOR_ATTACHMENT1_EXT = 0x8CE1;
        public const uint COLOR_ATTACHMENT2_EXT = 0x8CE2;
        public const uint COLOR_ATTACHMENT3_EXT = 0x8CE3;
        public const uint COLOR_ATTACHMENT4_EXT = 0x8CE4;
        public const uint COLOR_ATTACHMENT5_EXT = 0x8CE5;
        public const uint COLOR_ATTACHMENT6_EXT = 0x8CE6;
        public const uint COLOR_ATTACHMENT7_EXT = 0x8CE7;
        public const uint COLOR_ATTACHMENT8_EXT = 0x8CE8;
        public const uint COLOR_ATTACHMENT9_EXT = 0x8CE9;
        public const uint COLOR_ATTACHMENT10_EXT = 0x8CEA;
        public const uint COLOR_ATTACHMENT11_EXT = 0x8CEB;
        public const uint COLOR_ATTACHMENT12_EXT = 0x8CEC;
        public const uint COLOR_ATTACHMENT13_EXT = 0x8CED;
        public const uint COLOR_ATTACHMENT14_EXT = 0x8CEE;
        public const uint COLOR_ATTACHMENT15_EXT = 0x8CEF;
        public const uint EXT_draw_buffers2 = 1;
        public const uint EXT_draw_buffers_indexed = 1;
        public const uint EXT_draw_elements_base_vertex = 1;
        public const uint EXT_draw_instanced = 1;
        public const uint EXT_draw_range_elements = 1;
        public const uint MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
        public const uint MAX_ELEMENTS_INDICES_EXT = 0x80E9;
        public const uint EXT_external_buffer = 1;
        public const uint EXT_float_blend = 1;
        public const uint EXT_fog_coord = 1;
        public const uint FOG_COORDINATE_SOURCE_EXT = 0x8450;
        public const uint FOG_COORDINATE_EXT = 0x8451;
        public const uint FRAGMENT_DEPTH_EXT = 0x8452;
        public const uint CURRENT_FOG_COORDINATE_EXT = 0x8453;
        public const uint FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
        public const uint FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
        public const uint FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
        public const uint FOG_COORDINATE_ARRAY_EXT = 0x8457;
        public const uint EXT_frag_depth = 1;
        public const uint EXT_fragment_lighting = 1;
        public const uint FRAGMENT_LIGHTING_EXT = 0x8400;
        public const uint FRAGMENT_COLOR_MATERIAL_EXT = 0x8401;
        public const uint FRAGMENT_COLOR_MATERIAL_FACE_EXT = 0x8402;
        public const uint FRAGMENT_COLOR_MATERIAL_PARAMETER_EXT = 0x8403;
        public const uint MAX_FRAGMENT_LIGHTS_EXT = 0x8404;
        public const uint MAX_ACTIVE_LIGHTS_EXT = 0x8405;
        public const uint CURRENT_RASTER_NORMAL_EXT = 0x8406;
        public const uint LIGHT_ENV_MODE_EXT = 0x8407;
        public const uint FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_EXT = 0x8408;
        public const uint FRAGMENT_LIGHT_MODEL_TWO_SIDE_EXT = 0x8409;
        public const uint FRAGMENT_LIGHT_MODEL_AMBIENT_EXT = 0x840A;
        public const uint FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_EXT = 0x840B;
        public const uint FRAGMENT_LIGHT0_EXT = 0x840C;
        public const uint FRAGMENT_LIGHT7_EXT = 0x8413;
        public const uint EXT_framebuffer_blit = 1;
        public const uint DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
        public const uint READ_FRAMEBUFFER_EXT = 0x8CA8;
        public const uint DRAW_FRAMEBUFFER_EXT = 0x8CA9;
        public const uint READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;
        public const uint EXT_framebuffer_multisample = 1;
        public const uint RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
        public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
        public const uint MAX_SAMPLES_EXT = 0x8D57;
        public const uint EXT_framebuffer_multisample_blit_scaled = 1;
        public const uint SCALED_RESOLVE_FASTEST_EXT = 0x90BA;
        public const uint SCALED_RESOLVE_NICEST_EXT = 0x90BB;
        public const uint EXT_framebuffer_object = 1;
        public const uint INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506;
        public const uint MAX_RENDERBUFFER_SIZE_EXT = 0x84E8;
        public const uint FRAMEBUFFER_BINDING_EXT = 0x8CA6;
        public const uint RENDERBUFFER_BINDING_EXT = 0x8CA7;
        public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0;
        public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;
        public const uint FRAMEBUFFER_COMPLETE_EXT = 0x8CD5;
        public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;
        public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;
        public const uint FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;
        public const uint FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;
        public const uint FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;
        public const uint FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;
        public const uint FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD;
        public const uint DEPTH_ATTACHMENT_EXT = 0x8D00;
        public const uint STENCIL_ATTACHMENT_EXT = 0x8D20;
        public const uint FRAMEBUFFER_EXT = 0x8D40;
        public const uint RENDERBUFFER_EXT = 0x8D41;
        public const uint RENDERBUFFER_WIDTH_EXT = 0x8D42;
        public const uint RENDERBUFFER_HEIGHT_EXT = 0x8D43;
        public const uint RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44;
        public const uint STENCIL_INDEX1_EXT = 0x8D46;
        public const uint STENCIL_INDEX4_EXT = 0x8D47;
        public const uint STENCIL_INDEX8_EXT = 0x8D48;
        public const uint STENCIL_INDEX16_EXT = 0x8D49;
        public const uint RENDERBUFFER_RED_SIZE_EXT = 0x8D50;
        public const uint RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51;
        public const uint RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52;
        public const uint RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53;
        public const uint RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54;
        public const uint RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55;
        public const uint EXT_framebuffer_sRGB = 1;
        public const uint FRAMEBUFFER_SRGB_EXT = 0x8DB9;
        public const uint FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA;
        public const uint EXT_geometry_point_size = 1;
        public const uint GEOMETRY_SHADER_BIT_EXT = 0x00000004;
        public const uint LINES_ADJACENCY_EXT = 0xA;
        public const uint LINE_STRIP_ADJACENCY_EXT = 0xB;
        public const uint TRIANGLES_ADJACENCY_EXT = 0xC;
        public const uint TRIANGLE_STRIP_ADJACENCY_EXT = 0xD;
        public const uint LAYER_PROVOKING_VERTEX_EXT = 0x825E;
        public const uint UNDEFINED_VERTEX_EXT = 0x8260;
        public const uint GEOMETRY_SHADER_INVOCATIONS_EXT = 0x887F;
        public const uint GEOMETRY_LINKED_VERTICES_OUT_EXT = 0x8916;
        public const uint GEOMETRY_LINKED_INPUT_TYPE_EXT = 0x8917;
        public const uint GEOMETRY_LINKED_OUTPUT_TYPE_EXT = 0x8918;
        public const uint MAX_GEOMETRY_UNIFORM_BLOCKS_EXT = 0x8A2C;
        public const uint MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8A32;
        public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
        public const uint PRIMITIVES_GENERATED_EXT = 0x8C87;
        public const uint FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;
        public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
        public const uint GEOMETRY_SHADER_EXT = 0x8DD9;
        public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;
        public const uint MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;
        public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;
        public const uint FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;
        public const uint LAST_VERTEX_CONVENTION_EXT = 0x8E4E;
        public const uint MAX_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x8E5A;
        public const uint MAX_GEOMETRY_IMAGE_UNIFORMS_EXT = 0x90CD;
        public const uint MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT = 0x90D7;
        public const uint MAX_GEOMETRY_INPUT_COMPONENTS_EXT = 0x9123;
        public const uint MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT = 0x9124;
        public const uint MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CF;
        public const uint MAX_GEOMETRY_ATOMIC_COUNTERS_EXT = 0x92D5;
        public const uint REFERENCED_BY_GEOMETRY_SHADER_EXT = 0x9309;
        public const uint FRAMEBUFFER_DEFAULT_LAYERS_EXT = 0x9312;
        public const uint MAX_FRAMEBUFFER_LAYERS_EXT = 0x9317;
        public const uint EXT_geometry_shader = 1;
        public const uint EXT_geometry_shader4 = 1;
        public const uint PROGRAM_POINT_SIZE_EXT = 0x8642;
        public const uint MAX_VARYING_COMPONENTS_EXT = 0x8B4B;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
        public const uint FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
        public const uint GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;
        public const uint GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;
        public const uint GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;
        public const uint MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;
        public const uint MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;
        public const uint EXT_gpu_program_parameters = 1;
        public const uint EXT_gpu_shader4 = 1;
        public const uint VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD;
        public const uint SAMPLER_1D_ARRAY_EXT = 0x8DC0;
        public const uint SAMPLER_2D_ARRAY_EXT = 0x8DC1;
        public const uint SAMPLER_BUFFER_EXT = 0x8DC2;
        public const uint SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3;
        public const uint SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4;
        public const uint SAMPLER_CUBE_SHADOW_EXT = 0x8DC5;
        public const uint UNSIGNED_INT_VEC2_EXT = 0x8DC6;
        public const uint UNSIGNED_INT_VEC3_EXT = 0x8DC7;
        public const uint UNSIGNED_INT_VEC4_EXT = 0x8DC8;
        public const uint INT_SAMPLER_1D_EXT = 0x8DC9;
        public const uint INT_SAMPLER_2D_EXT = 0x8DCA;
        public const uint INT_SAMPLER_3D_EXT = 0x8DCB;
        public const uint INT_SAMPLER_CUBE_EXT = 0x8DCC;
        public const uint INT_SAMPLER_2D_RECT_EXT = 0x8DCD;
        public const uint INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE;
        public const uint INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF;
        public const uint INT_SAMPLER_BUFFER_EXT = 0x8DD0;
        public const uint UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1;
        public const uint UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2;
        public const uint UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3;
        public const uint UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4;
        public const uint UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;
        public const uint UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;
        public const uint UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;
        public const uint UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;
        public const uint EXT_gpu_shader5 = 1;
        public const uint EXT_histogram = 1;
        public const uint HISTOGRAM_EXT = 0x8024;
        public const uint PROXY_HISTOGRAM_EXT = 0x8025;
        public const uint HISTOGRAM_WIDTH_EXT = 0x8026;
        public const uint HISTOGRAM_FORMAT_EXT = 0x8027;
        public const uint HISTOGRAM_RED_SIZE_EXT = 0x8028;
        public const uint HISTOGRAM_GREEN_SIZE_EXT = 0x8029;
        public const uint HISTOGRAM_BLUE_SIZE_EXT = 0x802A;
        public const uint HISTOGRAM_ALPHA_SIZE_EXT = 0x802B;
        public const uint HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C;
        public const uint HISTOGRAM_SINK_EXT = 0x802D;
        public const uint MINMAX_EXT = 0x802E;
        public const uint MINMAX_FORMAT_EXT = 0x802F;
        public const uint MINMAX_SINK_EXT = 0x8030;
        public const uint EXT_index_array_formats = 1;
        public const uint EXT_index_func = 1;
        public const uint EXT_index_material = 1;
        public const uint EXT_index_texture = 1;
        public const uint EXT_instanced_arrays = 1;
        public const uint VERTEX_ATTRIB_ARRAY_DIVISOR_EXT = 0x88FE;
        public const uint EXT_light_texture = 1;
        public const uint FRAGMENT_MATERIAL_EXT = 0x8349;
        public const uint FRAGMENT_NORMAL_EXT = 0x834A;
        public const uint FRAGMENT_COLOR_EXT = 0x834C;
        public const uint ATTENUATION_EXT = 0x834D;
        public const uint SHADOW_ATTENUATION_EXT = 0x834E;
        public const uint TEXTURE_APPLICATION_MODE_EXT = 0x834F;
        public const uint TEXTURE_LIGHT_EXT = 0x8350;
        public const uint TEXTURE_MATERIAL_FACE_EXT = 0x8351;
        public const uint TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
        public const uint EXT_map_buffer_range = 1;
        public const uint MAP_READ_BIT_EXT = 0x0001;
        public const uint MAP_WRITE_BIT_EXT = 0x0002;
        public const uint MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;
        public const uint MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;
        public const uint MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;
        public const uint MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;
        public const uint EXT_memory_object = 1;
        public const uint UUID_SIZE_EXT = 16;
        public const uint TEXTURE_TILING_EXT = 0x9580;
        public const uint DEDICATED_MEMORY_OBJECT_EXT = 0x9581;
        public const uint NUM_TILING_TYPES_EXT = 0x9582;
        public const uint TILING_TYPES_EXT = 0x9583;
        public const uint OPTIMAL_TILING_EXT = 0x9584;
        public const uint LINEAR_TILING_EXT = 0x9585;
        public const uint LAYOUT_GENERAL_EXT = 0x958D;
        public const uint LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E;
        public const uint LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F;
        public const uint LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590;
        public const uint LAYOUT_SHADER_READ_ONLY_EXT = 0x9591;
        public const uint LAYOUT_TRANSFER_SRC_EXT = 0x9592;
        public const uint LAYOUT_TRANSFER_DST_EXT = 0x9593;
        public const uint NUM_DEVICE_UUIDS_EXT = 0x9596;
        public const uint DEVICE_UUID_EXT = 0x9597;
        public const uint DRIVER_UUID_EXT = 0x9598;
        public const uint PROTECTED_MEMORY_OBJECT_EXT = 0x959B;
        public const uint EXT_memory_object_fd = 1;
        public const uint HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586;
        public const uint EXT_memory_object_win32 = 1;
        public const uint LUID_SIZE_EXT = 8;
        public const uint HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587;
        public const uint HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588;
        public const uint HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589;
        public const uint HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A;
        public const uint HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B;
        public const uint HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C;
        public const uint HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594;
        public const uint D3D12_FENCE_VALUE_EXT = 0x9595;
        public const uint DEVICE_LUID_EXT = 0x9599;
        public const uint DEVICE_NODE_MASK_EXT = 0x959A;
        public const uint EXT_misc_attribute = 1;
        public const uint EXT_multi_draw_arrays = 1;
        public const uint EXT_multi_draw_indirect = 1;
        public const uint EXT_multiple_textures = 1;
        public const uint EXT_multisample = 1;
        public const uint MULTISAMPLE_EXT = 0x809D;
        public const uint SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;
        public const uint SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
        public const uint SAMPLE_MASK_EXT = 0x80A0;
        public const uint _1PASS_EXT = 0x80A1;
        public const uint _2PASS_0_EXT = 0x80A2;
        public const uint _2PASS_1_EXT = 0x80A3;
        public const uint _4PASS_0_EXT = 0x80A4;
        public const uint _4PASS_1_EXT = 0x80A5;
        public const uint _4PASS_2_EXT = 0x80A6;
        public const uint _4PASS_3_EXT = 0x80A7;
        public const uint SAMPLE_BUFFERS_EXT = 0x80A8;
        public const uint SAMPLES_EXT = 0x80A9;
        public const uint SAMPLE_MASK_VALUE_EXT = 0x80AA;
        public const uint SAMPLE_MASK_INVERT_EXT = 0x80AB;
        public const uint SAMPLE_PATTERN_EXT = 0x80AC;
        public const uint MULTISAMPLE_BIT_EXT = 0x20000000;
        public const uint EXT_multisample_compatibility = 1;
        public const uint EXT_multisampled_render_to_texture = 1;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;
        public const uint EXT_multisampled_render_to_texture2 = 1;
        public const uint EXT_multiview_draw_buffers = 1;
        public const uint DRAW_BUFFER_EXT = 0x0C01;
        public const uint READ_BUFFER_EXT = 0x0C02;
        public const uint COLOR_ATTACHMENT_EXT = 0x90F0;
        public const uint MULTIVIEW_EXT = 0x90F1;
        public const uint MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;
        public const uint EXT_packed_depth_stencil = 1;
        public const uint DEPTH_STENCIL_EXT = 0x84F9;
        public const uint UNSIGNED_INT_24_8_EXT = 0x84FA;
        public const uint DEPTH24_STENCIL8_EXT = 0x88F0;
        public const uint TEXTURE_STENCIL_SIZE_EXT = 0x88F1;
        public const uint EXT_packed_float = 1;
        public const uint R11F_G11F_B10F_EXT = 0x8C3A;
        public const uint UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
        public const uint RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C;
        public const uint EXT_packed_pixels = 1;
        public const uint UNSIGNED_BYTE_3_3_2_EXT = 0x8032;
        public const uint UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033;
        public const uint UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034;
        public const uint UNSIGNED_INT_8_8_8_8_EXT = 0x8035;
        public const uint UNSIGNED_INT_10_10_10_2_EXT = 0x8036;
        public const uint EXT_paletted_texture = 1;
        public const uint COLOR_TABLE_FORMAT_EXT = 0x80D8;
        public const uint COLOR_TABLE_WIDTH_EXT = 0x80D9;
        public const uint COLOR_TABLE_RED_SIZE_EXT = 0x80DA;
        public const uint COLOR_TABLE_GREEN_SIZE_EXT = 0x80DB;
        public const uint COLOR_TABLE_BLUE_SIZE_EXT = 0x80DC;
        public const uint COLOR_TABLE_ALPHA_SIZE_EXT = 0x80DD;
        public const uint COLOR_TABLE_LUMINANCE_SIZE_EXT = 0x80DE;
        public const uint COLOR_TABLE_INTENSITY_SIZE_EXT = 0x80DF;
        public const uint TEXTURE_INDEX_SIZE_EXT = 0x80ED;
        public const uint EXT_pixel_buffer_object = 1;
        public const uint PIXEL_PACK_BUFFER_EXT = 0x88EB;
        public const uint PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
        public const uint PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
        public const uint PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;
        public const uint EXT_pixel_transform = 1;
        public const uint PIXEL_TRANSFORM_2D_EXT = 0x8330;
        public const uint PIXEL_MAG_FILTER_EXT = 0x8331;
        public const uint PIXEL_MIN_FILTER_EXT = 0x8332;
        public const uint PIXEL_CUBIC_WEIGHT_EXT = 0x8333;
        public const uint CUBIC_EXT = 0x8334;
        public const uint AVERAGE_EXT = 0x8335;
        public const uint PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
        public const uint MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
        public const uint PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;
        public const uint EXT_pixel_transform_color_table = 1;
        public const uint EXT_point_parameters = 1;
        public const uint POINT_SIZE_MIN_EXT = 0x8126;
        public const uint POINT_SIZE_MAX_EXT = 0x8127;
        public const uint POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128;
        public const uint DISTANCE_ATTENUATION_EXT = 0x8129;
        public const uint EXT_polygon_offset = 1;
        public const uint POLYGON_OFFSET_EXT = 0x8037;
        public const uint POLYGON_OFFSET_FACTOR_EXT = 0x8038;
        public const uint POLYGON_OFFSET_BIAS_EXT = 0x8039;
        public const uint EXT_polygon_offset_clamp = 1;
        public const uint POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;
        public const uint EXT_post_depth_coverage = 1;
        public const uint EXT_provoking_vertex = 1;
        public const uint QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
        public const uint PROVOKING_VERTEX_EXT = 0x8E4F;
        public const uint EXT_pvrtc_sRGB = 1;
        public const uint COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54;
        public const uint COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55;
        public const uint COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56;
        public const uint COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57;
        public const uint EXT_raster_multisample = 1;
        public const uint COLOR_SAMPLES_NV = 0x8E20;
        public const uint RASTER_MULTISAMPLE_EXT = 0x9327;
        public const uint RASTER_SAMPLES_EXT = 0x9328;
        public const uint MAX_RASTER_SAMPLES_EXT = 0x9329;
        public const uint RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
        public const uint MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
        public const uint EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
        public const uint DEPTH_SAMPLES_NV = 0x932D;
        public const uint STENCIL_SAMPLES_NV = 0x932E;
        public const uint MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;
        public const uint MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;
        public const uint COVERAGE_MODULATION_TABLE_NV = 0x9331;
        public const uint COVERAGE_MODULATION_NV = 0x9332;
        public const uint COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;
        public const uint EXT_read_format_bgra = 1;
        public const uint UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365;
        public const uint UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366;
        public const uint EXT_render_snorm = 1;
        public const uint R16_SNORM_EXT = 0x8F98;
        public const uint RG16_SNORM_EXT = 0x8F99;
        public const uint RGBA16_SNORM_EXT = 0x8F9B;
        public const uint EXT_rescale_normal = 1;
        public const uint RESCALE_NORMAL_EXT = 0x803A;
        public const uint EXT_sRGB = 1;
        public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210;
        public const uint SRGB_EXT = 0x8C40;
        public const uint SRGB_ALPHA_EXT = 0x8C42;
        public const uint SRGB8_ALPHA8_EXT = 0x8C43;
        public const uint EXT_sRGB_write_control = 1;
        public const uint EXT_scene_marker = 1;
        public const uint EXT_secondary_color = 1;
        public const uint COLOR_SUM_EXT = 0x8458;
        public const uint CURRENT_SECONDARY_COLOR_EXT = 0x8459;
        public const uint SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
        public const uint SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
        public const uint SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
        public const uint SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
        public const uint SECONDARY_COLOR_ARRAY_EXT = 0x845E;
        public const uint EXT_semaphore = 1;
        public const uint EXT_semaphore_fd = 1;
        public const uint EXT_semaphore_win32 = 1;
        public const uint EXT_separate_shader_objects = 1;
        public const uint ACTIVE_PROGRAM_EXT = 0x8B8D;
        public const uint EXT_separate_specular_color = 1;
        public const uint LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8;
        public const uint SINGLE_COLOR_EXT = 0x81F9;
        public const uint SEPARATE_SPECULAR_COLOR_EXT = 0x81FA;
        public const uint EXT_shader_framebuffer_fetch = 1;
        public const uint FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;
        public const uint EXT_shader_group_vote = 1;
        public const uint EXT_shader_image_load_formatted = 1;
        public const uint EXT_shader_image_load_store = 1;
        public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
        public const uint ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
        public const uint UNIFORM_BARRIER_BIT_EXT = 0x00000004;
        public const uint TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
        public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
        public const uint COMMAND_BARRIER_BIT_EXT = 0x00000040;
        public const uint PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
        public const uint TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
        public const uint BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
        public const uint FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
        public const uint TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
        public const uint ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
        public const uint MAX_IMAGE_UNITS_EXT = 0x8F38;
        public const uint MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
        public const uint IMAGE_BINDING_NAME_EXT = 0x8F3A;
        public const uint IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
        public const uint IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
        public const uint IMAGE_BINDING_LAYER_EXT = 0x8F3D;
        public const uint IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
        public const uint IMAGE_1D_EXT = 0x904C;
        public const uint IMAGE_2D_EXT = 0x904D;
        public const uint IMAGE_3D_EXT = 0x904E;
        public const uint IMAGE_2D_RECT_EXT = 0x904F;
        public const uint IMAGE_CUBE_EXT = 0x9050;
        public const uint IMAGE_BUFFER_EXT = 0x9051;
        public const uint IMAGE_1D_ARRAY_EXT = 0x9052;
        public const uint IMAGE_2D_ARRAY_EXT = 0x9053;
        public const uint IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
        public const uint IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
        public const uint IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
        public const uint INT_IMAGE_1D_EXT = 0x9057;
        public const uint INT_IMAGE_2D_EXT = 0x9058;
        public const uint INT_IMAGE_3D_EXT = 0x9059;
        public const uint INT_IMAGE_2D_RECT_EXT = 0x905A;
        public const uint INT_IMAGE_CUBE_EXT = 0x905B;
        public const uint INT_IMAGE_BUFFER_EXT = 0x905C;
        public const uint INT_IMAGE_1D_ARRAY_EXT = 0x905D;
        public const uint INT_IMAGE_2D_ARRAY_EXT = 0x905E;
        public const uint INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
        public const uint INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
        public const uint INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
        public const uint UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
        public const uint UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
        public const uint UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
        public const uint UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
        public const uint UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
        public const uint UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
        public const uint UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
        public const uint UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
        public const uint UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
        public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
        public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
        public const uint MAX_IMAGE_SAMPLES_EXT = 0x906D;
        public const uint IMAGE_BINDING_FORMAT_EXT = 0x906E;
        public const uint ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;
        public const uint EXT_shader_implicit_conversions = 1;
        public const uint EXT_shader_integer_mix = 1;
        public const uint EXT_shader_io_blocks = 1;
        public const uint EXT_shader_non_constant_global_initializers = 1;
        public const uint EXT_shader_pixel_local_storage = 1;
        public const uint MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT = 0x8F63;
        public const uint SHADER_PIXEL_LOCAL_STORAGE_EXT = 0x8F64;
        public const uint MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT = 0x8F67;
        public const uint EXT_shader_pixel_local_storage2 = 1;
        public const uint MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;
        public const uint MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;
        public const uint FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;
        public const uint EXT_shader_texture_lod = 1;
        public const uint EXT_shadow_funcs = 1;
        public const uint EXT_shadow_samplers = 1;
        public const uint TEXTURE_COMPARE_MODE_EXT = 0x884C;
        public const uint TEXTURE_COMPARE_FUNC_EXT = 0x884D;
        public const uint COMPARE_REF_TO_TEXTURE_EXT = 0x884E;
        public const uint SAMPLER_2D_SHADOW_EXT = 0x8B62;
        public const uint EXT_shared_texture_palette = 1;
        public const uint SHARED_TEXTURE_PALETTE_EXT = 0x81FB;
        public const uint EXT_sparse_texture = 1;
        public const uint TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009;
        public const uint VIRTUAL_PAGE_SIZE_X_EXT = 0x9195;
        public const uint VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196;
        public const uint VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197;
        public const uint MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198;
        public const uint MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199;
        public const uint MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A;
        public const uint TEXTURE_SPARSE_EXT = 0x91A6;
        public const uint VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7;
        public const uint NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8;
        public const uint SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9;
        public const uint NUM_SPARSE_LEVELS_EXT = 0x91AA;
        public const uint EXT_sparse_texture2 = 1;
        public const uint EXT_stencil_clear_tag = 1;
        public const uint STENCIL_TAG_BITS_EXT = 0x88F2;
        public const uint STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;
        public const uint EXT_stencil_two_side = 1;
        public const uint STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
        public const uint ACTIVE_STENCIL_FACE_EXT = 0x8911;
        public const uint EXT_stencil_wrap = 1;
        public const uint INCR_WRAP_EXT = 0x8507;
        public const uint DECR_WRAP_EXT = 0x8508;
        public const uint EXT_subtexture = 1;
        public const uint EXT_texture = 1;
        public const uint ALPHA4_EXT = 0x803B;
        public const uint ALPHA8_EXT = 0x803C;
        public const uint ALPHA12_EXT = 0x803D;
        public const uint ALPHA16_EXT = 0x803E;
        public const uint LUMINANCE4_EXT = 0x803F;
        public const uint LUMINANCE8_EXT = 0x8040;
        public const uint LUMINANCE12_EXT = 0x8041;
        public const uint LUMINANCE16_EXT = 0x8042;
        public const uint LUMINANCE4_ALPHA4_EXT = 0x8043;
        public const uint LUMINANCE6_ALPHA2_EXT = 0x8044;
        public const uint LUMINANCE8_ALPHA8_EXT = 0x8045;
        public const uint LUMINANCE12_ALPHA4_EXT = 0x8046;
        public const uint LUMINANCE12_ALPHA12_EXT = 0x8047;
        public const uint LUMINANCE16_ALPHA16_EXT = 0x8048;
        public const uint INTENSITY_EXT = 0x8049;
        public const uint INTENSITY4_EXT = 0x804A;
        public const uint INTENSITY8_EXT = 0x804B;
        public const uint INTENSITY12_EXT = 0x804C;
        public const uint INTENSITY16_EXT = 0x804D;
        public const uint RGB2_EXT = 0x804E;
        public const uint RGB4_EXT = 0x804F;
        public const uint RGB5_EXT = 0x8050;
        public const uint RGB8_EXT = 0x8051;
        public const uint RGB10_EXT = 0x8052;
        public const uint RGB12_EXT = 0x8053;
        public const uint RGB16_EXT = 0x8054;
        public const uint RGBA2_EXT = 0x8055;
        public const uint RGBA4_EXT = 0x8056;
        public const uint RGB5_A1_EXT = 0x8057;
        public const uint RGBA8_EXT = 0x8058;
        public const uint RGB10_A2_EXT = 0x8059;
        public const uint RGBA12_EXT = 0x805A;
        public const uint RGBA16_EXT = 0x805B;
        public const uint TEXTURE_RED_SIZE_EXT = 0x805C;
        public const uint TEXTURE_GREEN_SIZE_EXT = 0x805D;
        public const uint TEXTURE_BLUE_SIZE_EXT = 0x805E;
        public const uint TEXTURE_ALPHA_SIZE_EXT = 0x805F;
        public const uint TEXTURE_LUMINANCE_SIZE_EXT = 0x8060;
        public const uint TEXTURE_INTENSITY_SIZE_EXT = 0x8061;
        public const uint REPLACE_EXT = 0x8062;
        public const uint PROXY_TEXTURE_1D_EXT = 0x8063;
        public const uint PROXY_TEXTURE_2D_EXT = 0x8064;
        public const uint EXT_texture3D = 1;
        public const uint PACK_SKIP_IMAGES_EXT = 0x806B;
        public const uint PACK_IMAGE_HEIGHT_EXT = 0x806C;
        public const uint UNPACK_SKIP_IMAGES_EXT = 0x806D;
        public const uint UNPACK_IMAGE_HEIGHT_EXT = 0x806E;
        public const uint TEXTURE_3D_EXT = 0x806F;
        public const uint PROXY_TEXTURE_3D_EXT = 0x8070;
        public const uint TEXTURE_DEPTH_EXT = 0x8071;
        public const uint TEXTURE_WRAP_R_EXT = 0x8072;
        public const uint MAX_3D_TEXTURE_SIZE_EXT = 0x8073;
        public const uint EXT_texture_array = 1;
        public const uint COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
        public const uint MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
        public const uint TEXTURE_1D_ARRAY_EXT = 0x8C18;
        public const uint PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;
        public const uint TEXTURE_2D_ARRAY_EXT = 0x8C1A;
        public const uint PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;
        public const uint TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
        public const uint TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;
        public const uint EXT_texture_buffer_object = 1;
        public const uint TEXTURE_BUFFER_EXT = 0x8C2A;
        public const uint MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
        public const uint TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
        public const uint TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
        public const uint TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;
        public const uint EXT_texture_compression_astc_decode_mode = 1;
        public const uint TEXTURE_ASTC_DECODE_PRECISION_EXT = 0x8F69;
        public const uint EXT_texture_compression_astc_decode_mode_rgb9e5 = 1;
        public const uint EXT_texture_compression_bptc = 1;
        public const uint COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;
        public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;
        public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;
        public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;
        public const uint EXT_texture_compression_dxt1 = 1;
        public const uint EXT_texture_compression_latc = 1;
        public const uint COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
        public const uint COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
        public const uint COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
        public const uint COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;
        public const uint EXT_texture_compression_rgtc = 1;
        public const uint COMPRESSED_RED_RGTC1_EXT = 0x8DBB;
        public const uint COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
        public const uint COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
        public const uint COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
        public const uint EXT_texture_compression_s3tc = 1;
        public const uint COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
        public const uint COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
        public const uint COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
        public const uint COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
        public const uint EXT_texture_cube_map = 1;
        public const uint NORMAL_MAP_EXT = 0x8511;
        public const uint REFLECTION_MAP_EXT = 0x8512;
        public const uint TEXTURE_CUBE_MAP_EXT = 0x8513;
        public const uint TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
        public const uint PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B;
        public const uint MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;
        public const uint EXT_texture_cube_map_array = 1;
        public const uint TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009;
        public const uint TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;
        public const uint SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;
        public const uint SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;
        public const uint INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;
        public const uint UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;
        public const uint EXT_texture_edge_clamp = 1;
        public const uint CLAMP_TO_EDGE_EXT = 0x812F;
        public const uint EXT_texture_env = 1;
        public const uint EXT_texture_env_add = 1;
        public const uint EXT_texture_env_combine = 1;
        public const uint COMBINE_EXT = 0x8570;
        public const uint COMBINE_RGB_EXT = 0x8571;
        public const uint COMBINE_ALPHA_EXT = 0x8572;
        public const uint RGB_SCALE_EXT = 0x8573;
        public const uint ADD_SIGNED_EXT = 0x8574;
        public const uint INTERPOLATE_EXT = 0x8575;
        public const uint CONSTANT_EXT = 0x8576;
        public const uint PRIMARY_COLOR_EXT = 0x8577;
        public const uint PREVIOUS_EXT = 0x8578;
        public const uint SOURCE0_RGB_EXT = 0x8580;
        public const uint SOURCE1_RGB_EXT = 0x8581;
        public const uint SOURCE2_RGB_EXT = 0x8582;
        public const uint SOURCE0_ALPHA_EXT = 0x8588;
        public const uint SOURCE1_ALPHA_EXT = 0x8589;
        public const uint SOURCE2_ALPHA_EXT = 0x858A;
        public const uint OPERAND0_RGB_EXT = 0x8590;
        public const uint OPERAND1_RGB_EXT = 0x8591;
        public const uint OPERAND2_RGB_EXT = 0x8592;
        public const uint OPERAND0_ALPHA_EXT = 0x8598;
        public const uint OPERAND1_ALPHA_EXT = 0x8599;
        public const uint OPERAND2_ALPHA_EXT = 0x859A;
        public const uint EXT_texture_env_dot3 = 1;
        public const uint DOT3_RGB_EXT = 0x8740;
        public const uint DOT3_RGBA_EXT = 0x8741;
        public const uint EXT_texture_filter_anisotropic = 1;
        public const uint TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
        public const uint MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
        public const uint EXT_texture_filter_minmax = 1;
        public const uint TEXTURE_REDUCTION_MODE_EXT = 0x9366;
        public const uint WEIGHTED_AVERAGE_EXT = 0x9367;
        public const uint EXT_texture_format_BGRA8888 = 1;
        public const uint EXT_texture_integer = 1;
        public const uint RGBA32UI_EXT = 0x8D70;
        public const uint RGB32UI_EXT = 0x8D71;
        public const uint ALPHA32UI_EXT = 0x8D72;
        public const uint INTENSITY32UI_EXT = 0x8D73;
        public const uint LUMINANCE32UI_EXT = 0x8D74;
        public const uint LUMINANCE_ALPHA32UI_EXT = 0x8D75;
        public const uint RGBA16UI_EXT = 0x8D76;
        public const uint RGB16UI_EXT = 0x8D77;
        public const uint ALPHA16UI_EXT = 0x8D78;
        public const uint INTENSITY16UI_EXT = 0x8D79;
        public const uint LUMINANCE16UI_EXT = 0x8D7A;
        public const uint LUMINANCE_ALPHA16UI_EXT = 0x8D7B;
        public const uint RGBA8UI_EXT = 0x8D7C;
        public const uint RGB8UI_EXT = 0x8D7D;
        public const uint ALPHA8UI_EXT = 0x8D7E;
        public const uint INTENSITY8UI_EXT = 0x8D7F;
        public const uint LUMINANCE8UI_EXT = 0x8D80;
        public const uint LUMINANCE_ALPHA8UI_EXT = 0x8D81;
        public const uint RGBA32I_EXT = 0x8D82;
        public const uint RGB32I_EXT = 0x8D83;
        public const uint ALPHA32I_EXT = 0x8D84;
        public const uint INTENSITY32I_EXT = 0x8D85;
        public const uint LUMINANCE32I_EXT = 0x8D86;
        public const uint LUMINANCE_ALPHA32I_EXT = 0x8D87;
        public const uint RGBA16I_EXT = 0x8D88;
        public const uint RGB16I_EXT = 0x8D89;
        public const uint ALPHA16I_EXT = 0x8D8A;
        public const uint INTENSITY16I_EXT = 0x8D8B;
        public const uint LUMINANCE16I_EXT = 0x8D8C;
        public const uint LUMINANCE_ALPHA16I_EXT = 0x8D8D;
        public const uint RGBA8I_EXT = 0x8D8E;
        public const uint RGB8I_EXT = 0x8D8F;
        public const uint ALPHA8I_EXT = 0x8D90;
        public const uint INTENSITY8I_EXT = 0x8D91;
        public const uint LUMINANCE8I_EXT = 0x8D92;
        public const uint LUMINANCE_ALPHA8I_EXT = 0x8D93;
        public const uint RED_INTEGER_EXT = 0x8D94;
        public const uint GREEN_INTEGER_EXT = 0x8D95;
        public const uint BLUE_INTEGER_EXT = 0x8D96;
        public const uint ALPHA_INTEGER_EXT = 0x8D97;
        public const uint RGB_INTEGER_EXT = 0x8D98;
        public const uint RGBA_INTEGER_EXT = 0x8D99;
        public const uint BGR_INTEGER_EXT = 0x8D9A;
        public const uint BGRA_INTEGER_EXT = 0x8D9B;
        public const uint LUMINANCE_INTEGER_EXT = 0x8D9C;
        public const uint LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D;
        public const uint RGBA_INTEGER_MODE_EXT = 0x8D9E;
        public const uint EXT_texture_lod_bias = 1;
        public const uint MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
        public const uint TEXTURE_FILTER_CONTROL_EXT = 0x8500;
        public const uint TEXTURE_LOD_BIAS_EXT = 0x8501;
        public const uint EXT_texture_mirror_clamp = 1;
        public const uint MIRROR_CLAMP_EXT = 0x8742;
        public const uint MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
        public const uint MIRROR_CLAMP_TO_BORDER_EXT = 0x8912;
        public const uint EXT_texture_norm16 = 1;
        public const uint R16_EXT = 0x822A;
        public const uint RG16_EXT = 0x822C;
        public const uint RGB16_SNORM_EXT = 0x8F9A;
        public const uint EXT_texture_object = 1;
        public const uint TEXTURE_PRIORITY_EXT = 0x8066;
        public const uint TEXTURE_RESIDENT_EXT = 0x8067;
        public const uint TEXTURE_1D_BINDING_EXT = 0x8068;
        public const uint TEXTURE_2D_BINDING_EXT = 0x8069;
        public const uint TEXTURE_3D_BINDING_EXT = 0x806A;
        public const uint EXT_texture_perturb_normal = 1;
        public const uint PERTURB_EXT = 0x85AE;
        public const uint TEXTURE_NORMAL_EXT = 0x85AF;
        public const uint EXT_texture_rectangle = 1;
        public const uint TEXTURE_RECTANGLE_EXT = 0x84F5;
        public const uint TEXTURE_BINDING_RECTANGLE_EXT = 0x84F6;
        public const uint PROXY_TEXTURE_RECTANGLE_EXT = 0x84F7;
        public const uint MAX_RECTANGLE_TEXTURE_SIZE_EXT = 0x84F8;
        public const uint EXT_texture_rg = 1;
        public const uint RED_EXT = 0x1903;
        public const uint RG_EXT = 0x8227;
        public const uint R8_EXT = 0x8229;
        public const uint RG8_EXT = 0x822B;
        public const uint EXT_texture_sRGB = 1;
        public const uint SRGB8_EXT = 0x8C41;
        public const uint SLUMINANCE_ALPHA_EXT = 0x8C44;
        public const uint SLUMINANCE8_ALPHA8_EXT = 0x8C45;
        public const uint SLUMINANCE_EXT = 0x8C46;
        public const uint SLUMINANCE8_EXT = 0x8C47;
        public const uint COMPRESSED_SRGB_EXT = 0x8C48;
        public const uint COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;
        public const uint COMPRESSED_SLUMINANCE_EXT = 0x8C4A;
        public const uint COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
        public const uint COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
        public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
        public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
        public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
        public const uint EXT_texture_sRGB_R8 = 1;
        public const uint SR8_EXT = 0x8FBD;
        public const uint EXT_texture_sRGB_RG8 = 1;
        public const uint SRG8_EXT = 0x8FBE;
        public const uint EXT_texture_sRGB_decode = 1;
        public const uint TEXTURE_SRGB_DECODE_EXT = 0x8A48;
        public const uint DECODE_EXT = 0x8A49;
        public const uint SKIP_DECODE_EXT = 0x8A4A;
        public const uint EXT_texture_shared_exponent = 1;
        public const uint RGB9_E5_EXT = 0x8C3D;
        public const uint UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E;
        public const uint TEXTURE_SHARED_SIZE_EXT = 0x8C3F;
        public const uint EXT_texture_snorm = 1;
        public const uint ALPHA_SNORM = 0x9010;
        public const uint LUMINANCE_SNORM = 0x9011;
        public const uint LUMINANCE_ALPHA_SNORM = 0x9012;
        public const uint INTENSITY_SNORM = 0x9013;
        public const uint ALPHA8_SNORM = 0x9014;
        public const uint LUMINANCE8_SNORM = 0x9015;
        public const uint LUMINANCE8_ALPHA8_SNORM = 0x9016;
        public const uint INTENSITY8_SNORM = 0x9017;
        public const uint ALPHA16_SNORM = 0x9018;
        public const uint LUMINANCE16_SNORM = 0x9019;
        public const uint LUMINANCE16_ALPHA16_SNORM = 0x901A;
        public const uint INTENSITY16_SNORM = 0x901B;
        public const uint EXT_texture_storage = 1;
        public const uint R32F_EXT = 0x822E;
        public const uint RG32F_EXT = 0x8230;
        public const uint RGBA32F_EXT = 0x8814;
        public const uint RGB32F_EXT = 0x8815;
        public const uint ALPHA32F_EXT = 0x8816;
        public const uint LUMINANCE32F_EXT = 0x8818;
        public const uint LUMINANCE_ALPHA32F_EXT = 0x8819;
        public const uint ALPHA16F_EXT = 0x881C;
        public const uint LUMINANCE16F_EXT = 0x881E;
        public const uint LUMINANCE_ALPHA16F_EXT = 0x881F;
        public const uint TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F;
        public const uint EXT_texture_swizzle = 1;
        public const uint TEXTURE_SWIZZLE_R_EXT = 0x8E42;
        public const uint TEXTURE_SWIZZLE_G_EXT = 0x8E43;
        public const uint TEXTURE_SWIZZLE_B_EXT = 0x8E44;
        public const uint TEXTURE_SWIZZLE_A_EXT = 0x8E45;
        public const uint TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;
        public const uint EXT_texture_type_2_10_10_10_REV = 1;
        public const uint UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368;
        public const uint EXT_texture_view = 1;
        public const uint TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB;
        public const uint TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC;
        public const uint TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD;
        public const uint TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE;
        public const uint EXT_timer_query = 1;
        public const uint TIME_ELAPSED_EXT = 0x88BF;
        public const uint EXT_transform_feedback = 1;
        public const uint TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;
        public const uint TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;
        public const uint TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;
        public const uint TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;
        public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;
        public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;
        public const uint RASTERIZER_DISCARD_EXT = 0x8C89;
        public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;
        public const uint INTERLEAVED_ATTRIBS_EXT = 0x8C8C;
        public const uint SEPARATE_ATTRIBS_EXT = 0x8C8D;
        public const uint TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E;
        public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;
        public const uint EXT_unpack_subimage = 1;
        public const uint UNPACK_ROW_LENGTH_EXT = 0x0CF2;
        public const uint UNPACK_SKIP_ROWS_EXT = 0x0CF3;
        public const uint UNPACK_SKIP_PIXELS_EXT = 0x0CF4;
        public const uint EXT_vertex_array = 1;
        public const uint DOUBLE_EXT = 0x140A;
        public const uint VERTEX_ARRAY_EXT = 0x8074;
        public const uint NORMAL_ARRAY_EXT = 0x8075;
        public const uint COLOR_ARRAY_EXT = 0x8076;
        public const uint INDEX_ARRAY_EXT = 0x8077;
        public const uint TEXTURE_COORD_ARRAY_EXT = 0x8078;
        public const uint EDGE_FLAG_ARRAY_EXT = 0x8079;
        public const uint VERTEX_ARRAY_SIZE_EXT = 0x807A;
        public const uint VERTEX_ARRAY_TYPE_EXT = 0x807B;
        public const uint VERTEX_ARRAY_STRIDE_EXT = 0x807C;
        public const uint VERTEX_ARRAY_COUNT_EXT = 0x807D;
        public const uint NORMAL_ARRAY_TYPE_EXT = 0x807E;
        public const uint NORMAL_ARRAY_STRIDE_EXT = 0x807F;
        public const uint NORMAL_ARRAY_COUNT_EXT = 0x8080;
        public const uint COLOR_ARRAY_SIZE_EXT = 0x8081;
        public const uint COLOR_ARRAY_TYPE_EXT = 0x8082;
        public const uint COLOR_ARRAY_STRIDE_EXT = 0x8083;
        public const uint COLOR_ARRAY_COUNT_EXT = 0x8084;
        public const uint INDEX_ARRAY_TYPE_EXT = 0x8085;
        public const uint INDEX_ARRAY_STRIDE_EXT = 0x8086;
        public const uint INDEX_ARRAY_COUNT_EXT = 0x8087;
        public const uint TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088;
        public const uint TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089;
        public const uint TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;
        public const uint TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B;
        public const uint EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C;
        public const uint EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D;
        public const uint VERTEX_ARRAY_POINTER_EXT = 0x808E;
        public const uint NORMAL_ARRAY_POINTER_EXT = 0x808F;
        public const uint COLOR_ARRAY_POINTER_EXT = 0x8090;
        public const uint INDEX_ARRAY_POINTER_EXT = 0x8091;
        public const uint TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092;
        public const uint EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093;
        public const uint EXT_vertex_array_bgra = 1;
        public const uint EXT_vertex_array_setXXX = 1;
        public const uint EXT_vertex_attrib_64bit = 1;
        public const uint DOUBLE_MAT2_EXT = 0x8F46;
        public const uint DOUBLE_MAT3_EXT = 0x8F47;
        public const uint DOUBLE_MAT4_EXT = 0x8F48;
        public const uint DOUBLE_MAT2x3_EXT = 0x8F49;
        public const uint DOUBLE_MAT2x4_EXT = 0x8F4A;
        public const uint DOUBLE_MAT3x2_EXT = 0x8F4B;
        public const uint DOUBLE_MAT3x4_EXT = 0x8F4C;
        public const uint DOUBLE_MAT4x2_EXT = 0x8F4D;
        public const uint DOUBLE_MAT4x3_EXT = 0x8F4E;
        public const uint DOUBLE_VEC2_EXT = 0x8FFC;
        public const uint DOUBLE_VEC3_EXT = 0x8FFD;
        public const uint DOUBLE_VEC4_EXT = 0x8FFE;
        public const uint EXT_vertex_shader = 1;
        public const uint VERTEX_SHADER_EXT = 0x8780;
        public const uint VERTEX_SHADER_BINDING_EXT = 0x8781;
        public const uint OP_INDEX_EXT = 0x8782;
        public const uint OP_NEGATE_EXT = 0x8783;
        public const uint OP_DOT3_EXT = 0x8784;
        public const uint OP_DOT4_EXT = 0x8785;
        public const uint OP_MUL_EXT = 0x8786;
        public const uint OP_ADD_EXT = 0x8787;
        public const uint OP_MADD_EXT = 0x8788;
        public const uint OP_FRAC_EXT = 0x8789;
        public const uint OP_MAX_EXT = 0x878A;
        public const uint OP_MIN_EXT = 0x878B;
        public const uint OP_SET_GE_EXT = 0x878C;
        public const uint OP_SET_LT_EXT = 0x878D;
        public const uint OP_CLAMP_EXT = 0x878E;
        public const uint OP_FLOOR_EXT = 0x878F;
        public const uint OP_ROUND_EXT = 0x8790;
        public const uint OP_EXP_BASE_2_EXT = 0x8791;
        public const uint OP_LOG_BASE_2_EXT = 0x8792;
        public const uint OP_POWER_EXT = 0x8793;
        public const uint OP_RECIP_EXT = 0x8794;
        public const uint OP_RECIP_SQRT_EXT = 0x8795;
        public const uint OP_SUB_EXT = 0x8796;
        public const uint OP_CROSS_PRODUCT_EXT = 0x8797;
        public const uint OP_MULTIPLY_MATRIX_EXT = 0x8798;
        public const uint OP_MOV_EXT = 0x8799;
        public const uint OUTPUT_VERTEX_EXT = 0x879A;
        public const uint OUTPUT_COLOR0_EXT = 0x879B;
        public const uint OUTPUT_COLOR1_EXT = 0x879C;
        public const uint OUTPUT_TEXTURE_COORD0_EXT = 0x879D;
        public const uint OUTPUT_TEXTURE_COORD1_EXT = 0x879E;
        public const uint OUTPUT_TEXTURE_COORD2_EXT = 0x879F;
        public const uint OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;
        public const uint OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;
        public const uint OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;
        public const uint OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;
        public const uint OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;
        public const uint OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;
        public const uint OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;
        public const uint OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;
        public const uint OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;
        public const uint OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;
        public const uint OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;
        public const uint OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;
        public const uint OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;
        public const uint OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;
        public const uint OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;
        public const uint OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;
        public const uint OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;
        public const uint OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;
        public const uint OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;
        public const uint OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;
        public const uint OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;
        public const uint OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;
        public const uint OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;
        public const uint OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;
        public const uint OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;
        public const uint OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;
        public const uint OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;
        public const uint OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;
        public const uint OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;
        public const uint OUTPUT_FOG_EXT = 0x87BD;
        public const uint SCALAR_EXT = 0x87BE;
        public const uint VECTOR_EXT = 0x87BF;
        public const uint MATRIX_EXT = 0x87C0;
        public const uint VARIANT_EXT = 0x87C1;
        public const uint INVARIANT_EXT = 0x87C2;
        public const uint LOCAL_CONSTANT_EXT = 0x87C3;
        public const uint LOCAL_EXT = 0x87C4;
        public const uint MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
        public const uint MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
        public const uint MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
        public const uint MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
        public const uint MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;
        public const uint MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
        public const uint MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
        public const uint MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CC;
        public const uint MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CD;
        public const uint MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
        public const uint VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
        public const uint VERTEX_SHADER_VARIANTS_EXT = 0x87D0;
        public const uint VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;
        public const uint VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
        public const uint VERTEX_SHADER_LOCALS_EXT = 0x87D3;
        public const uint VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;
        public const uint X_EXT = 0x87D5;
        public const uint Y_EXT = 0x87D6;
        public const uint Z_EXT = 0x87D7;
        public const uint W_EXT = 0x87D8;
        public const uint NEGATIVE_X_EXT = 0x87D9;
        public const uint NEGATIVE_Y_EXT = 0x87DA;
        public const uint NEGATIVE_Z_EXT = 0x87DB;
        public const uint NEGATIVE_W_EXT = 0x87DC;
        public const uint ZERO_EXT = 0x87DD;
        public const uint ONE_EXT = 0x87DE;
        public const uint NEGATIVE_ONE_EXT = 0x87DF;
        public const uint NORMALIZED_RANGE_EXT = 0x87E0;
        public const uint FULL_RANGE_EXT = 0x87E1;
        public const uint CURRENT_VERTEX_EXT = 0x87E2;
        public const uint MVP_MATRIX_EXT = 0x87E3;
        public const uint VARIANT_VALUE_EXT = 0x87E4;
        public const uint VARIANT_DATATYPE_EXT = 0x87E5;
        public const uint VARIANT_ARRAY_STRIDE_EXT = 0x87E6;
        public const uint VARIANT_ARRAY_TYPE_EXT = 0x87E7;
        public const uint VARIANT_ARRAY_EXT = 0x87E8;
        public const uint VARIANT_ARRAY_POINTER_EXT = 0x87E9;
        public const uint INVARIANT_VALUE_EXT = 0x87EA;
        public const uint INVARIANT_DATATYPE_EXT = 0x87EB;
        public const uint LOCAL_CONSTANT_VALUE_EXT = 0x87EC;
        public const uint LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;
        public const uint EXT_vertex_weighting = 1;
        public const uint MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;
        public const uint MODELVIEW0_MATRIX_EXT = 0x0BA6;
        public const uint MODELVIEW0_EXT = 0x1700;
        public const uint MODELVIEW1_STACK_DEPTH_EXT = 0x8502;
        public const uint MODELVIEW1_MATRIX_EXT = 0x8506;
        public const uint VERTEX_WEIGHTING_EXT = 0x8509;
        public const uint MODELVIEW1_EXT = 0x850A;
        public const uint CURRENT_VERTEX_WEIGHT_EXT = 0x850B;
        public const uint VERTEX_WEIGHT_ARRAY_EXT = 0x850C;
        public const uint VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;
        public const uint VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;
        public const uint VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
        public const uint VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;
        public const uint EXT_win32_keyed_mutex = 1;
        public const uint EXT_window_rectangles = 1;
        public const uint INCLUSIVE_EXT = 0x8F10;
        public const uint EXCLUSIVE_EXT = 0x8F11;
        public const uint WINDOW_RECTANGLE_EXT = 0x8F12;
        public const uint WINDOW_RECTANGLE_MODE_EXT = 0x8F13;
        public const uint MAX_WINDOW_RECTANGLES_EXT = 0x8F14;
        public const uint NUM_WINDOW_RECTANGLES_EXT = 0x8F15;
        public const uint EXT_x11_sync_object = 1;
        public const uint SYNC_X11_FENCE_EXT = 0x90E1;
        public const uint GREMEDY_frame_terminator = 1;
        public const uint GREMEDY_string_marker = 1;
        public const uint HP_convolution_border_modes = 1;
        public const uint HP_image_transform = 1;
        public const uint HP_occlusion_test = 1;
        public const uint HP_texture_lighting = 1;
        public const uint IBM_cull_vertex = 1;
        public const uint CULL_VERTEX_IBM = 103050;
        public const uint IBM_multimode_draw_arrays = 1;
        public const uint IBM_rasterpos_clip = 1;
        public const uint RASTER_POSITION_UNCLIPPED_IBM = 103010;
        public const uint IBM_static_data = 1;
        public const uint ALL_STATIC_DATA_IBM = 103060;
        public const uint STATIC_VERTEX_ARRAY_IBM = 103061;
        public const uint IBM_texture_mirrored_repeat = 1;
        public const uint MIRRORED_REPEAT_IBM = 0x8370;
        public const uint IBM_vertex_array_lists = 1;
        public const uint VERTEX_ARRAY_LIST_IBM = 103070;
        public const uint NORMAL_ARRAY_LIST_IBM = 103071;
        public const uint COLOR_ARRAY_LIST_IBM = 103072;
        public const uint INDEX_ARRAY_LIST_IBM = 103073;
        public const uint TEXTURE_COORD_ARRAY_LIST_IBM = 103074;
        public const uint EDGE_FLAG_ARRAY_LIST_IBM = 103075;
        public const uint FOG_COORDINATE_ARRAY_LIST_IBM = 103076;
        public const uint SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;
        public const uint VERTEX_ARRAY_LIST_STRIDE_IBM = 103080;
        public const uint NORMAL_ARRAY_LIST_STRIDE_IBM = 103081;
        public const uint COLOR_ARRAY_LIST_STRIDE_IBM = 103082;
        public const uint INDEX_ARRAY_LIST_STRIDE_IBM = 103083;
        public const uint TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;
        public const uint EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;
        public const uint FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;
        public const uint SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;
        public const uint INGR_color_clamp = 1;
        public const uint RED_MIN_CLAMP_INGR = 0x8560;
        public const uint GREEN_MIN_CLAMP_INGR = 0x8561;
        public const uint BLUE_MIN_CLAMP_INGR = 0x8562;
        public const uint ALPHA_MIN_CLAMP_INGR = 0x8563;
        public const uint RED_MAX_CLAMP_INGR = 0x8564;
        public const uint GREEN_MAX_CLAMP_INGR = 0x8565;
        public const uint BLUE_MAX_CLAMP_INGR = 0x8566;
        public const uint ALPHA_MAX_CLAMP_INGR = 0x8567;
        public const uint INGR_interlace_read = 1;
        public const uint INTERLACE_READ_INGR = 0x8568;
        public const uint INTEL_conservative_rasterization = 1;
        public const uint CONSERVATIVE_RASTERIZATION_INTEL = 0x83FE;
        public const uint INTEL_fragment_shader_ordering = 1;
        public const uint INTEL_framebuffer_CMAA = 1;
        public const uint INTEL_map_texture = 1;
        public const uint LAYOUT_DEFAULT_INTEL = 0;
        public const uint LAYOUT_LINEAR_INTEL = 1;
        public const uint LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;
        public const uint TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;
        public const uint INTEL_parallel_arrays = 1;
        public const uint PARALLEL_ARRAYS_INTEL = 0x83F4;
        public const uint VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;
        public const uint NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;
        public const uint COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;
        public const uint TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;
        public const uint INTEL_performance_query = 1;
        public const uint PERFQUERY_SINGLE_CONTEXT_INTEL = 0x0000;
        public const uint PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x0001;
        public const uint PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;
        public const uint PERFQUERY_FLUSH_INTEL = 0x83FA;
        public const uint PERFQUERY_WAIT_INTEL = 0x83FB;
        public const uint PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;
        public const uint PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;
        public const uint PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;
        public const uint PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;
        public const uint PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;
        public const uint PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;
        public const uint PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;
        public const uint PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;
        public const uint PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;
        public const uint PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;
        public const uint PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;
        public const uint PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;
        public const uint PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;
        public const uint PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;
        public const uint PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;
        public const uint INTEL_texture_scissor = 1;
        public const uint KHR_blend_equation_advanced = 1;
        public const uint BLEND_ADVANCED_COHERENT_KHR = 0x9285;
        public const uint MULTIPLY_KHR = 0x9294;
        public const uint SCREEN_KHR = 0x9295;
        public const uint OVERLAY_KHR = 0x9296;
        public const uint DARKEN_KHR = 0x9297;
        public const uint LIGHTEN_KHR = 0x9298;
        public const uint COLORDODGE_KHR = 0x9299;
        public const uint COLORBURN_KHR = 0x929A;
        public const uint HARDLIGHT_KHR = 0x929B;
        public const uint SOFTLIGHT_KHR = 0x929C;
        public const uint DIFFERENCE_KHR = 0x929E;
        public const uint EXCLUSION_KHR = 0x92A0;
        public const uint HSL_HUE_KHR = 0x92AD;
        public const uint HSL_SATURATION_KHR = 0x92AE;
        public const uint HSL_COLOR_KHR = 0x92AF;
        public const uint HSL_LUMINOSITY_KHR = 0x92B0;
        public const uint KHR_blend_equation_advanced_coherent = 1;
        public const uint KHR_context_flush_control = 1;
        public const uint KHR_debug = 1;
        public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
        public const uint DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
        public const uint DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        public const uint DEBUG_CALLBACK_FUNCTION = 0x8244;
        public const uint DEBUG_CALLBACK_USER_PARAM = 0x8245;
        public const uint DEBUG_SOURCE_API = 0x8246;
        public const uint DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
        public const uint DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
        public const uint DEBUG_SOURCE_THIRD_PARTY = 0x8249;
        public const uint DEBUG_SOURCE_APPLICATION = 0x824A;
        public const uint DEBUG_SOURCE_OTHER = 0x824B;
        public const uint DEBUG_TYPE_ERROR = 0x824C;
        public const uint DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
        public const uint DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
        public const uint DEBUG_TYPE_PORTABILITY = 0x824F;
        public const uint DEBUG_TYPE_PERFORMANCE = 0x8250;
        public const uint DEBUG_TYPE_OTHER = 0x8251;
        public const uint DEBUG_TYPE_MARKER = 0x8268;
        public const uint DEBUG_TYPE_PUSH_GROUP = 0x8269;
        public const uint DEBUG_TYPE_POP_GROUP = 0x826A;
        public const uint DEBUG_SEVERITY_NOTIFICATION = 0x826B;
        public const uint MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
        public const uint DEBUG_GROUP_STACK_DEPTH = 0x826D;
        public const uint BUFFER = 0x82E0;
        public const uint SHADER = 0x82E1;
        public const uint PROGRAM = 0x82E2;
        public const uint QUERY = 0x82E3;
        public const uint PROGRAM_PIPELINE = 0x82E4;
        public const uint SAMPLER = 0x82E6;
        public const uint DISPLAY_LIST = 0x82E7;
        public const uint MAX_LABEL_LENGTH = 0x82E8;
        public const uint MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
        public const uint MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
        public const uint DEBUG_LOGGED_MESSAGES = 0x9145;
        public const uint DEBUG_SEVERITY_HIGH = 0x9146;
        public const uint DEBUG_SEVERITY_MEDIUM = 0x9147;
        public const uint DEBUG_SEVERITY_LOW = 0x9148;
        public const uint DEBUG_OUTPUT = 0x92E0;
        public const uint KHR_no_error = 1;
        public const uint CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008;
        public const uint KHR_parallel_shader_compile = 1;
        public const uint MAX_SHADER_COMPILER_THREADS_KHR = 0x91B0;
        public const uint COMPLETION_STATUS_KHR = 0x91B1;
        public const uint KHR_robust_buffer_access_behavior = 1;
        public const uint KHR_robustness = 1;
        public const uint CONTEXT_LOST = 0x0507;
        public const uint LOSE_CONTEXT_ON_RESET = 0x8252;
        public const uint GUILTY_CONTEXT_RESET = 0x8253;
        public const uint INNOCENT_CONTEXT_RESET = 0x8254;
        public const uint UNKNOWN_CONTEXT_RESET = 0x8255;
        public const uint RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const uint NO_RESET_NOTIFICATION = 0x8261;
        public const uint CONTEXT_ROBUST_ACCESS = 0x90F3;
        public const uint KHR_texture_compression_astc_hdr = 1;
        public const uint COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;
        public const uint COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;
        public const uint COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;
        public const uint COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;
        public const uint COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;
        public const uint COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;
        public const uint COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;
        public const uint COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;
        public const uint COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;
        public const uint COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;
        public const uint COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;
        public const uint COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;
        public const uint COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;
        public const uint COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;
        public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;
        public const uint KHR_texture_compression_astc_ldr = 1;
        public const uint KHR_texture_compression_astc_sliced_3d = 1;
        public const uint KTX_buffer_region = 1;
        public const uint KTX_FRONT_REGION = 0x0;
        public const uint KTX_BACK_REGION = 0x1;
        public const uint KTX_Z_REGION = 0x2;
        public const uint KTX_STENCIL_REGION = 0x3;
        public const uint MESAX_texture_stack = 1;
        public const uint TEXTURE_1D_STACK_MESAX = 0x8759;
        public const uint TEXTURE_2D_STACK_MESAX = 0x875A;
        public const uint PROXY_TEXTURE_1D_STACK_MESAX = 0x875B;
        public const uint PROXY_TEXTURE_2D_STACK_MESAX = 0x875C;
        public const uint TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
        public const uint TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;
        public const uint MESA_pack_invert = 1;
        public const uint PACK_INVERT_MESA = 0x8758;
        public const uint MESA_resize_buffers = 1;
        public const uint MESA_shader_integer_functions = 1;
        public const uint MESA_window_pos = 1;
        public const uint MESA_ycbcr_texture = 1;
        public const uint UNSIGNED_SHORT_8_8_MESA = 0x85BA;
        public const uint UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
        public const uint YCBCR_MESA = 0x8757;
        public const uint NVX_blend_equation_advanced_multi_draw_buffers = 1;
        public const uint NVX_conditional_render = 1;
        public const uint NVX_gpu_memory_info = 1;
        public const uint GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047;
        public const uint GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048;
        public const uint GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049;
        public const uint GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A;
        public const uint GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B;
        public const uint NVX_linked_gpu_multicast = 1;
        public const uint LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800;
        public const uint MAX_LGPU_GPUS_NVX = 0x92BA;
        public const uint NV_3dvision_settings = 1;
        public const uint _3DVISION_STEREO_NV = 0x90F4;
        public const uint STEREO_SEPARATION_NV = 0x90F5;
        public const uint STEREO_CONVERGENCE_NV = 0x90F6;
        public const uint STEREO_CUTOFF_NV = 0x90F7;
        public const uint STEREO_PROJECTION_NV = 0x90F8;
        public const uint STEREO_PROJECTION_PERSPECTIVE_NV = 0x90F9;
        public const uint STEREO_PROJECTION_ORTHO_NV = 0x90FA;
        public const uint NV_EGL_stream_consumer_external = 1;
        public const uint TEXTURE_EXTERNAL_OES = 0x8D65;
        public const uint SAMPLER_EXTERNAL_OES = 0x8D66;
        public const uint TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;
        public const uint REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;
        public const uint NV_alpha_to_coverage_dither_control = 1;
        public const uint ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF;
        public const uint ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D;
        public const uint ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E;
        public const uint ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F;
        public const uint NV_bgr = 1;
        public const uint BGR_NV = 0x80E0;
        public const uint NV_bindless_multi_draw_indirect = 1;
        public const uint NV_bindless_multi_draw_indirect_count = 1;
        public const uint NV_bindless_texture = 1;
        public const uint NV_blend_equation_advanced = 1;
        public const uint XOR_NV = 0x1506;
        public const uint RED_NV = 0x1903;
        public const uint GREEN_NV = 0x1904;
        public const uint BLUE_NV = 0x1905;
        public const uint BLEND_PREMULTIPLIED_SRC_NV = 0x9280;
        public const uint BLEND_OVERLAP_NV = 0x9281;
        public const uint UNCORRELATED_NV = 0x9282;
        public const uint DISJOINT_NV = 0x9283;
        public const uint CONJOINT_NV = 0x9284;
        public const uint BLEND_ADVANCED_COHERENT_NV = 0x9285;
        public const uint SRC_NV = 0x9286;
        public const uint DST_NV = 0x9287;
        public const uint SRC_OVER_NV = 0x9288;
        public const uint DST_OVER_NV = 0x9289;
        public const uint SRC_IN_NV = 0x928A;
        public const uint DST_IN_NV = 0x928B;
        public const uint SRC_OUT_NV = 0x928C;
        public const uint DST_OUT_NV = 0x928D;
        public const uint SRC_ATOP_NV = 0x928E;
        public const uint DST_ATOP_NV = 0x928F;
        public const uint PLUS_NV = 0x9291;
        public const uint PLUS_DARKER_NV = 0x9292;
        public const uint MULTIPLY_NV = 0x9294;
        public const uint SCREEN_NV = 0x9295;
        public const uint OVERLAY_NV = 0x9296;
        public const uint DARKEN_NV = 0x9297;
        public const uint LIGHTEN_NV = 0x9298;
        public const uint COLORDODGE_NV = 0x9299;
        public const uint COLORBURN_NV = 0x929A;
        public const uint HARDLIGHT_NV = 0x929B;
        public const uint SOFTLIGHT_NV = 0x929C;
        public const uint DIFFERENCE_NV = 0x929E;
        public const uint MINUS_NV = 0x929F;
        public const uint EXCLUSION_NV = 0x92A0;
        public const uint CONTRAST_NV = 0x92A1;
        public const uint INVERT_RGB_NV = 0x92A3;
        public const uint LINEARDODGE_NV = 0x92A4;
        public const uint LINEARBURN_NV = 0x92A5;
        public const uint VIVIDLIGHT_NV = 0x92A6;
        public const uint LINEARLIGHT_NV = 0x92A7;
        public const uint PINLIGHT_NV = 0x92A8;
        public const uint HARDMIX_NV = 0x92A9;
        public const uint HSL_HUE_NV = 0x92AD;
        public const uint HSL_SATURATION_NV = 0x92AE;
        public const uint HSL_COLOR_NV = 0x92AF;
        public const uint HSL_LUMINOSITY_NV = 0x92B0;
        public const uint PLUS_CLAMPED_NV = 0x92B1;
        public const uint PLUS_CLAMPED_ALPHA_NV = 0x92B2;
        public const uint MINUS_CLAMPED_NV = 0x92B3;
        public const uint INVERT_OVG_NV = 0x92B4;
        public const uint NV_blend_equation_advanced_coherent = 1;
        public const uint NV_blend_minmax_factor = 1;
        public const uint NV_blend_square = 1;
        public const uint NV_clip_space_w_scaling = 1;
        public const uint VIEWPORT_POSITION_W_SCALE_NV = 0x937C;
        public const uint VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D;
        public const uint VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E;
        public const uint NV_command_list = 1;
        public const uint TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;
        public const uint NOP_COMMAND_NV = 0x0001;
        public const uint DRAW_ELEMENTS_COMMAND_NV = 0x0002;
        public const uint DRAW_ARRAYS_COMMAND_NV = 0x0003;
        public const uint DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;
        public const uint DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;
        public const uint DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;
        public const uint DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;
        public const uint ELEMENT_ADDRESS_COMMAND_NV = 0x0008;
        public const uint ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;
        public const uint UNIFORM_ADDRESS_COMMAND_NV = 0x000a;
        public const uint BLEND_COLOR_COMMAND_NV = 0x000b;
        public const uint STENCIL_REF_COMMAND_NV = 0x000c;
        public const uint LINE_WIDTH_COMMAND_NV = 0x000d;
        public const uint POLYGON_OFFSET_COMMAND_NV = 0x000e;
        public const uint ALPHA_REF_COMMAND_NV = 0x000f;
        public const uint VIEWPORT_COMMAND_NV = 0x0010;
        public const uint SCISSOR_COMMAND_NV = 0x0011;
        public const uint FRONT_FACE_COMMAND_NV = 0x0012;
        public const uint NV_compute_program5 = 1;
        public const uint COMPUTE_PROGRAM_NV = 0x90FB;
        public const uint COMPUTE_PROGRAM_PARAMETER_BUFFER_NV = 0x90FC;
        public const uint NV_conditional_render = 1;
        public const uint QUERY_WAIT_NV = 0x8E13;
        public const uint QUERY_NO_WAIT_NV = 0x8E14;
        public const uint QUERY_BY_REGION_WAIT_NV = 0x8E15;
        public const uint QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;
        public const uint NV_conservative_raster = 1;
        public const uint CONSERVATIVE_RASTERIZATION_NV = 0x9346;
        public const uint SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;
        public const uint SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;
        public const uint MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;
        public const uint NV_conservative_raster_dilate = 1;
        public const uint CONSERVATIVE_RASTER_DILATE_NV = 0x9379;
        public const uint CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;
        public const uint CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;
        public const uint NV_conservative_raster_pre_snap_triangles = 1;
        public const uint CONSERVATIVE_RASTER_MODE_NV = 0x954D;
        public const uint CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E;
        public const uint CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F;
        public const uint NV_copy_buffer = 1;
        public const uint COPY_READ_BUFFER_NV = 0x8F36;
        public const uint COPY_WRITE_BUFFER_NV = 0x8F37;
        public const uint NV_copy_depth_to_color = 1;
        public const uint DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
        public const uint DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
        public const uint NV_copy_image = 1;
        public const uint NV_deep_texture3D = 1;
        public const uint MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0;
        public const uint MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1;
        public const uint NV_depth_buffer_float = 1;
        public const uint DEPTH_COMPONENT32F_NV = 0x8DAB;
        public const uint DEPTH32F_STENCIL8_NV = 0x8DAC;
        public const uint FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;
        public const uint DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;
        public const uint NV_depth_clamp = 1;
        public const uint DEPTH_CLAMP_NV = 0x864F;
        public const uint NV_depth_range_unclamped = 1;
        public const uint SAMPLE_COUNT_BITS_NV = 0x8864;
        public const uint CURRENT_SAMPLE_COUNT_QUERY_NV = 0x8865;
        public const uint QUERY_RESULT_NV = 0x8866;
        public const uint QUERY_RESULT_AVAILABLE_NV = 0x8867;
        public const uint SAMPLE_COUNT_NV = 0x8914;
        public const uint NV_draw_buffers = 1;
        public const uint MAX_DRAW_BUFFERS_NV = 0x8824;
        public const uint DRAW_BUFFER0_NV = 0x8825;
        public const uint DRAW_BUFFER1_NV = 0x8826;
        public const uint DRAW_BUFFER2_NV = 0x8827;
        public const uint DRAW_BUFFER3_NV = 0x8828;
        public const uint DRAW_BUFFER4_NV = 0x8829;
        public const uint DRAW_BUFFER5_NV = 0x882A;
        public const uint DRAW_BUFFER6_NV = 0x882B;
        public const uint DRAW_BUFFER7_NV = 0x882C;
        public const uint DRAW_BUFFER8_NV = 0x882D;
        public const uint DRAW_BUFFER9_NV = 0x882E;
        public const uint DRAW_BUFFER10_NV = 0x882F;
        public const uint DRAW_BUFFER11_NV = 0x8830;
        public const uint DRAW_BUFFER12_NV = 0x8831;
        public const uint DRAW_BUFFER13_NV = 0x8832;
        public const uint DRAW_BUFFER14_NV = 0x8833;
        public const uint DRAW_BUFFER15_NV = 0x8834;
        public const uint COLOR_ATTACHMENT0_NV = 0x8CE0;
        public const uint COLOR_ATTACHMENT1_NV = 0x8CE1;
        public const uint COLOR_ATTACHMENT2_NV = 0x8CE2;
        public const uint COLOR_ATTACHMENT3_NV = 0x8CE3;
        public const uint COLOR_ATTACHMENT4_NV = 0x8CE4;
        public const uint COLOR_ATTACHMENT5_NV = 0x8CE5;
        public const uint COLOR_ATTACHMENT6_NV = 0x8CE6;
        public const uint COLOR_ATTACHMENT7_NV = 0x8CE7;
        public const uint COLOR_ATTACHMENT8_NV = 0x8CE8;
        public const uint COLOR_ATTACHMENT9_NV = 0x8CE9;
        public const uint COLOR_ATTACHMENT10_NV = 0x8CEA;
        public const uint COLOR_ATTACHMENT11_NV = 0x8CEB;
        public const uint COLOR_ATTACHMENT12_NV = 0x8CEC;
        public const uint COLOR_ATTACHMENT13_NV = 0x8CED;
        public const uint COLOR_ATTACHMENT14_NV = 0x8CEE;
        public const uint COLOR_ATTACHMENT15_NV = 0x8CEF;
        public const uint NV_draw_instanced = 1;
        public const uint NV_draw_texture = 1;
        public const uint NV_draw_vulkan_image = 1;
        public const uint NV_evaluators = 1;
        public const uint EVAL_2D_NV = 0x86C0;
        public const uint EVAL_TRIANGULAR_2D_NV = 0x86C1;
        public const uint MAP_TESSELLATION_NV = 0x86C2;
        public const uint MAP_ATTRIB_U_ORDER_NV = 0x86C3;
        public const uint MAP_ATTRIB_V_ORDER_NV = 0x86C4;
        public const uint EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;
        public const uint EVAL_VERTEX_ATTRIB0_NV = 0x86C6;
        public const uint EVAL_VERTEX_ATTRIB1_NV = 0x86C7;
        public const uint EVAL_VERTEX_ATTRIB2_NV = 0x86C8;
        public const uint EVAL_VERTEX_ATTRIB3_NV = 0x86C9;
        public const uint EVAL_VERTEX_ATTRIB4_NV = 0x86CA;
        public const uint EVAL_VERTEX_ATTRIB5_NV = 0x86CB;
        public const uint EVAL_VERTEX_ATTRIB6_NV = 0x86CC;
        public const uint EVAL_VERTEX_ATTRIB7_NV = 0x86CD;
        public const uint EVAL_VERTEX_ATTRIB8_NV = 0x86CE;
        public const uint EVAL_VERTEX_ATTRIB9_NV = 0x86CF;
        public const uint EVAL_VERTEX_ATTRIB10_NV = 0x86D0;
        public const uint EVAL_VERTEX_ATTRIB11_NV = 0x86D1;
        public const uint EVAL_VERTEX_ATTRIB12_NV = 0x86D2;
        public const uint EVAL_VERTEX_ATTRIB13_NV = 0x86D3;
        public const uint EVAL_VERTEX_ATTRIB14_NV = 0x86D4;
        public const uint EVAL_VERTEX_ATTRIB15_NV = 0x86D5;
        public const uint MAX_MAP_TESSELLATION_NV = 0x86D6;
        public const uint MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7;
        public const uint NV_explicit_attrib_location = 1;
        public const uint NV_explicit_multisample = 1;
        public const uint SAMPLE_POSITION_NV = 0x8E50;
        public const uint SAMPLE_MASK_NV = 0x8E51;
        public const uint SAMPLE_MASK_VALUE_NV = 0x8E52;
        public const uint TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;
        public const uint TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;
        public const uint TEXTURE_RENDERBUFFER_NV = 0x8E55;
        public const uint SAMPLER_RENDERBUFFER_NV = 0x8E56;
        public const uint INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;
        public const uint UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;
        public const uint MAX_SAMPLE_MASK_WORDS_NV = 0x8E59;
        public const uint NV_fbo_color_attachments = 1;
        public const uint MAX_COLOR_ATTACHMENTS_NV = 0x8CDF;
        public const uint NV_fence = 1;
        public const uint ALL_COMPLETED_NV = 0x84F2;
        public const uint FENCE_STATUS_NV = 0x84F3;
        public const uint FENCE_CONDITION_NV = 0x84F4;
        public const uint NV_fill_rectangle = 1;
        public const uint FILL_RECTANGLE_NV = 0x933C;
        public const uint NV_float_buffer = 1;
        public const uint FLOAT_R_NV = 0x8880;
        public const uint FLOAT_RG_NV = 0x8881;
        public const uint FLOAT_RGB_NV = 0x8882;
        public const uint FLOAT_RGBA_NV = 0x8883;
        public const uint FLOAT_R16_NV = 0x8884;
        public const uint FLOAT_R32_NV = 0x8885;
        public const uint FLOAT_RG16_NV = 0x8886;
        public const uint FLOAT_RG32_NV = 0x8887;
        public const uint FLOAT_RGB16_NV = 0x8888;
        public const uint FLOAT_RGB32_NV = 0x8889;
        public const uint FLOAT_RGBA16_NV = 0x888A;
        public const uint FLOAT_RGBA32_NV = 0x888B;
        public const uint TEXTURE_FLOAT_COMPONENTS_NV = 0x888C;
        public const uint FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D;
        public const uint FLOAT_RGBA_MODE_NV = 0x888E;
        public const uint NV_fog_distance = 1;
        public const uint FOG_DISTANCE_MODE_NV = 0x855A;
        public const uint EYE_RADIAL_NV = 0x855B;
        public const uint EYE_PLANE_ABSOLUTE_NV = 0x855C;
        public const uint NV_fragment_coverage_to_color = 1;
        public const uint FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;
        public const uint FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;
        public const uint NV_fragment_program = 1;
        public const uint MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
        public const uint FRAGMENT_PROGRAM_NV = 0x8870;
        public const uint MAX_TEXTURE_COORDS_NV = 0x8871;
        public const uint MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872;
        public const uint FRAGMENT_PROGRAM_BINDING_NV = 0x8873;
        public const uint PROGRAM_ERROR_STRING_NV = 0x8874;
        public const uint NV_fragment_program2 = 1;
        public const uint MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
        public const uint MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
        public const uint MAX_PROGRAM_IF_DEPTH_NV = 0x88F6;
        public const uint MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7;
        public const uint MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8;
        public const uint NV_fragment_program4 = 1;
        public const uint NV_fragment_program_option = 1;
        public const uint NV_fragment_shader_interlock = 1;
        public const uint NV_framebuffer_blit = 1;
        public const uint DRAW_FRAMEBUFFER_BINDING_NV = 0x8CA6;
        public const uint READ_FRAMEBUFFER_NV = 0x8CA8;
        public const uint DRAW_FRAMEBUFFER_NV = 0x8CA9;
        public const uint READ_FRAMEBUFFER_BINDING_NV = 0x8CAA;
        public const uint NV_framebuffer_mixed_samples = 1;
        public const uint NV_framebuffer_multisample = 1;
        public const uint RENDERBUFFER_SAMPLES_NV = 0x8CAB;
        public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV = 0x8D56;
        public const uint MAX_SAMPLES_NV = 0x8D57;
        public const uint NV_framebuffer_multisample_coverage = 1;
        public const uint RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;
        public const uint RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;
        public const uint MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;
        public const uint MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;
        public const uint NV_generate_mipmap_sRGB = 1;
        public const uint NV_geometry_program4 = 1;
        public const uint GEOMETRY_PROGRAM_NV = 0x8C26;
        public const uint MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;
        public const uint MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;
        public const uint NV_geometry_shader4 = 1;
        public const uint NV_geometry_shader_passthrough = 1;
        public const uint NV_gpu_multicast = 1;
        public const uint PER_GPU_STORAGE_BIT_NV = 0x0800;
        public const uint MULTICAST_GPUS_NV = 0x92BA;
        public const uint PER_GPU_STORAGE_NV = 0x9548;
        public const uint MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9549;
        public const uint RENDER_GPU_MASK_NV = 0x9558;
        public const uint NV_gpu_program4 = 1;
        public const uint MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904;
        public const uint MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905;
        public const uint PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;
        public const uint PROGRAM_RESULT_COMPONENTS_NV = 0x8907;
        public const uint MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;
        public const uint MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;
        public const uint MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;
        public const uint MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;
        public const uint NV_gpu_program5 = 1;
        public const uint MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
        public const uint MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
        public const uint MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
        public const uint FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
        public const uint MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
        public const uint MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
        public const uint NV_gpu_program5_mem_extended = 1;
        public const uint NV_gpu_program_fp64 = 1;
        public const uint NV_gpu_shader5 = 1;
        public const uint INT64_NV = 0x140E;
        public const uint UNSIGNED_INT64_NV = 0x140F;
        public const uint INT8_NV = 0x8FE0;
        public const uint INT8_VEC2_NV = 0x8FE1;
        public const uint INT8_VEC3_NV = 0x8FE2;
        public const uint INT8_VEC4_NV = 0x8FE3;
        public const uint INT16_NV = 0x8FE4;
        public const uint INT16_VEC2_NV = 0x8FE5;
        public const uint INT16_VEC3_NV = 0x8FE6;
        public const uint INT16_VEC4_NV = 0x8FE7;
        public const uint INT64_VEC2_NV = 0x8FE9;
        public const uint INT64_VEC3_NV = 0x8FEA;
        public const uint INT64_VEC4_NV = 0x8FEB;
        public const uint UNSIGNED_INT8_NV = 0x8FEC;
        public const uint UNSIGNED_INT8_VEC2_NV = 0x8FED;
        public const uint UNSIGNED_INT8_VEC3_NV = 0x8FEE;
        public const uint UNSIGNED_INT8_VEC4_NV = 0x8FEF;
        public const uint UNSIGNED_INT16_NV = 0x8FF0;
        public const uint UNSIGNED_INT16_VEC2_NV = 0x8FF1;
        public const uint UNSIGNED_INT16_VEC3_NV = 0x8FF2;
        public const uint UNSIGNED_INT16_VEC4_NV = 0x8FF3;
        public const uint UNSIGNED_INT64_VEC2_NV = 0x8FF5;
        public const uint UNSIGNED_INT64_VEC3_NV = 0x8FF6;
        public const uint UNSIGNED_INT64_VEC4_NV = 0x8FF7;
        public const uint NV_half_float = 1;
        public const uint HALF_FLOAT_NV = 0x140B;
        public const uint NV_image_formats = 1;
        public const uint NV_instanced_arrays = 1;
        public const uint VERTEX_ATTRIB_ARRAY_DIVISOR_NV = 0x88FE;
        public const uint NV_internalformat_sample_query = 1;
        public const uint MULTISAMPLES_NV = 0x9371;
        public const uint SUPERSAMPLE_SCALE_X_NV = 0x9372;
        public const uint SUPERSAMPLE_SCALE_Y_NV = 0x9373;
        public const uint CONFORMANT_NV = 0x9374;
        public const uint NV_light_max_exponent = 1;
        public const uint MAX_SHININESS_NV = 0x8504;
        public const uint MAX_SPOT_EXPONENT_NV = 0x8505;
        public const uint NV_multisample_coverage = 1;
        public const uint NV_multisample_filter_hint = 1;
        public const uint MULTISAMPLE_FILTER_HINT_NV = 0x8534;
        public const uint NV_non_square_matrices = 1;
        public const uint FLOAT_MAT2x3_NV = 0x8B65;
        public const uint FLOAT_MAT2x4_NV = 0x8B66;
        public const uint FLOAT_MAT3x2_NV = 0x8B67;
        public const uint FLOAT_MAT3x4_NV = 0x8B68;
        public const uint FLOAT_MAT4x2_NV = 0x8B69;
        public const uint FLOAT_MAT4x3_NV = 0x8B6A;
        public const uint NV_occlusion_query = 1;
        public const uint PIXEL_COUNTER_BITS_NV = 0x8864;
        public const uint CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;
        public const uint PIXEL_COUNT_NV = 0x8866;
        public const uint PIXEL_COUNT_AVAILABLE_NV = 0x8867;
        public const uint NV_pack_subimage = 1;
        public const uint PACK_ROW_LENGTH_NV = 0x0D02;
        public const uint PACK_SKIP_ROWS_NV = 0x0D03;
        public const uint PACK_SKIP_PIXELS_NV = 0x0D04;
        public const uint NV_packed_depth_stencil = 1;
        public const uint DEPTH_STENCIL_NV = 0x84F9;
        public const uint UNSIGNED_INT_24_8_NV = 0x84FA;
        public const uint NV_packed_float = 1;
        public const uint R11F_G11F_B10F_NV = 0x8C3A;
        public const uint UNSIGNED_INT_10F_11F_11F_REV_NV = 0x8C3B;
        public const uint NV_packed_float_linear = 1;
        public const uint NV_parameter_buffer_object = 1;
        public const uint MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
        public const uint MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
        public const uint VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
        public const uint GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
        public const uint FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;
        public const uint NV_parameter_buffer_object2 = 1;
        public const uint NV_path_rendering = 1;
        public const uint CLOSE_PATH_NV = 0x00;
        public const uint BOLD_BIT_NV = 0x01;
        public const uint GLYPH_WIDTH_BIT_NV = 0x01;
        public const uint GLYPH_HEIGHT_BIT_NV = 0x02;
        public const uint ITALIC_BIT_NV = 0x02;
        public const uint MOVE_TO_NV = 0x02;
        public const uint RELATIVE_MOVE_TO_NV = 0x03;
        public const uint GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;
        public const uint LINE_TO_NV = 0x04;
        public const uint RELATIVE_LINE_TO_NV = 0x05;
        public const uint HORIZONTAL_LINE_TO_NV = 0x06;
        public const uint RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;
        public const uint GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;
        public const uint VERTICAL_LINE_TO_NV = 0x08;
        public const uint RELATIVE_VERTICAL_LINE_TO_NV = 0x09;
        public const uint QUADRATIC_CURVE_TO_NV = 0x0A;
        public const uint RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;
        public const uint CUBIC_CURVE_TO_NV = 0x0C;
        public const uint RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;
        public const uint SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;
        public const uint RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;
        public const uint GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;
        public const uint SMOOTH_CUBIC_CURVE_TO_NV = 0x10;
        public const uint RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;
        public const uint SMALL_CCW_ARC_TO_NV = 0x12;
        public const uint RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;
        public const uint SMALL_CW_ARC_TO_NV = 0x14;
        public const uint RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;
        public const uint LARGE_CCW_ARC_TO_NV = 0x16;
        public const uint RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;
        public const uint LARGE_CW_ARC_TO_NV = 0x18;
        public const uint RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;
        public const uint CONIC_CURVE_TO_NV = 0x1A;
        public const uint RELATIVE_CONIC_CURVE_TO_NV = 0x1B;
        public const uint GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;
        public const uint GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;
        public const uint GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;
        public const uint ROUNDED_RECT_NV = 0xE8;
        public const uint RELATIVE_ROUNDED_RECT_NV = 0xE9;
        public const uint ROUNDED_RECT2_NV = 0xEA;
        public const uint RELATIVE_ROUNDED_RECT2_NV = 0xEB;
        public const uint ROUNDED_RECT4_NV = 0xEC;
        public const uint RELATIVE_ROUNDED_RECT4_NV = 0xED;
        public const uint ROUNDED_RECT8_NV = 0xEE;
        public const uint RELATIVE_ROUNDED_RECT8_NV = 0xEF;
        public const uint RESTART_PATH_NV = 0xF0;
        public const uint DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;
        public const uint DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;
        public const uint RECT_NV = 0xF6;
        public const uint RELATIVE_RECT_NV = 0xF7;
        public const uint CIRCULAR_CCW_ARC_TO_NV = 0xF8;
        public const uint CIRCULAR_CW_ARC_TO_NV = 0xFA;
        public const uint CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;
        public const uint ARC_TO_NV = 0xFE;
        public const uint RELATIVE_ARC_TO_NV = 0xFF;
        public const uint GLYPH_HAS_KERNING_BIT_NV = 0x100;
        public const uint PRIMARY_COLOR_NV = 0x852C;
        public const uint SECONDARY_COLOR_NV = 0x852D;
        public const uint PATH_FORMAT_SVG_NV = 0x9070;
        public const uint PATH_FORMAT_PS_NV = 0x9071;
        public const uint STANDARD_FONT_NAME_NV = 0x9072;
        public const uint SYSTEM_FONT_NAME_NV = 0x9073;
        public const uint FILE_NAME_NV = 0x9074;
        public const uint PATH_STROKE_WIDTH_NV = 0x9075;
        public const uint PATH_END_CAPS_NV = 0x9076;
        public const uint PATH_INITIAL_END_CAP_NV = 0x9077;
        public const uint PATH_TERMINAL_END_CAP_NV = 0x9078;
        public const uint PATH_JOIN_STYLE_NV = 0x9079;
        public const uint PATH_MITER_LIMIT_NV = 0x907A;
        public const uint PATH_DASH_CAPS_NV = 0x907B;
        public const uint PATH_INITIAL_DASH_CAP_NV = 0x907C;
        public const uint PATH_TERMINAL_DASH_CAP_NV = 0x907D;
        public const uint PATH_DASH_OFFSET_NV = 0x907E;
        public const uint PATH_CLIENT_LENGTH_NV = 0x907F;
        public const uint PATH_FILL_MODE_NV = 0x9080;
        public const uint PATH_FILL_MASK_NV = 0x9081;
        public const uint PATH_FILL_COVER_MODE_NV = 0x9082;
        public const uint PATH_STROKE_COVER_MODE_NV = 0x9083;
        public const uint PATH_STROKE_MASK_NV = 0x9084;
        public const uint PATH_STROKE_BOUND_NV = 0x9086;
        public const uint COUNT_UP_NV = 0x9088;
        public const uint COUNT_DOWN_NV = 0x9089;
        public const uint PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;
        public const uint CONVEX_HULL_NV = 0x908B;
        public const uint BOUNDING_BOX_NV = 0x908D;
        public const uint TRANSLATE_X_NV = 0x908E;
        public const uint TRANSLATE_Y_NV = 0x908F;
        public const uint TRANSLATE_2D_NV = 0x9090;
        public const uint TRANSLATE_3D_NV = 0x9091;
        public const uint AFFINE_2D_NV = 0x9092;
        public const uint AFFINE_3D_NV = 0x9094;
        public const uint TRANSPOSE_AFFINE_2D_NV = 0x9096;
        public const uint TRANSPOSE_AFFINE_3D_NV = 0x9098;
        public const uint UTF8_NV = 0x909A;
        public const uint UTF16_NV = 0x909B;
        public const uint BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;
        public const uint PATH_COMMAND_COUNT_NV = 0x909D;
        public const uint PATH_COORD_COUNT_NV = 0x909E;
        public const uint PATH_DASH_ARRAY_COUNT_NV = 0x909F;
        public const uint PATH_COMPUTED_LENGTH_NV = 0x90A0;
        public const uint PATH_FILL_BOUNDING_BOX_NV = 0x90A1;
        public const uint PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;
        public const uint SQUARE_NV = 0x90A3;
        public const uint ROUND_NV = 0x90A4;
        public const uint TRIANGULAR_NV = 0x90A5;
        public const uint BEVEL_NV = 0x90A6;
        public const uint MITER_REVERT_NV = 0x90A7;
        public const uint MITER_TRUNCATE_NV = 0x90A8;
        public const uint SKIP_MISSING_GLYPH_NV = 0x90A9;
        public const uint USE_MISSING_GLYPH_NV = 0x90AA;
        public const uint PATH_ERROR_POSITION_NV = 0x90AB;
        public const uint PATH_FOG_GEN_MODE_NV = 0x90AC;
        public const uint ACCUM_ADJACENT_PAIRS_NV = 0x90AD;
        public const uint ADJACENT_PAIRS_NV = 0x90AE;
        public const uint FIRST_TO_REST_NV = 0x90AF;
        public const uint PATH_GEN_MODE_NV = 0x90B0;
        public const uint PATH_GEN_COEFF_NV = 0x90B1;
        public const uint PATH_GEN_COLOR_FORMAT_NV = 0x90B2;
        public const uint PATH_GEN_COMPONENTS_NV = 0x90B3;
        public const uint PATH_DASH_OFFSET_RESET_NV = 0x90B4;
        public const uint MOVE_TO_RESETS_NV = 0x90B5;
        public const uint MOVE_TO_CONTINUES_NV = 0x90B6;
        public const uint PATH_STENCIL_FUNC_NV = 0x90B7;
        public const uint PATH_STENCIL_REF_NV = 0x90B8;
        public const uint PATH_STENCIL_VALUE_MASK_NV = 0x90B9;
        public const uint PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;
        public const uint PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;
        public const uint PATH_COVER_DEPTH_FUNC_NV = 0x90BF;
        public const uint FONT_GLYPHS_AVAILABLE_NV = 0x9368;
        public const uint FONT_TARGET_UNAVAILABLE_NV = 0x9369;
        public const uint FONT_UNAVAILABLE_NV = 0x936A;
        public const uint FONT_UNINTELLIGIBLE_NV = 0x936B;
        public const uint STANDARD_FONT_FORMAT_NV = 0x936C;
        public const uint FRAGMENT_INPUT_NV = 0x936D;
        public const uint FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000;
        public const uint FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000;
        public const uint FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000;
        public const uint FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000;
        public const uint FONT_UNITS_PER_EM_BIT_NV = 0x00100000;
        public const uint FONT_ASCENDER_BIT_NV = 0x00200000;
        public const uint FONT_DESCENDER_BIT_NV = 0x00400000;
        public const uint FONT_HEIGHT_BIT_NV = 0x00800000;
        public const uint FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000;
        public const uint FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000;
        public const uint FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000;
        public const uint FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000;
        public const uint FONT_HAS_KERNING_BIT_NV = 0x10000000;
        public const uint FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000;
        public const uint NV_path_rendering_shared_edge = 1;
        public const uint SHARED_EDGE_NV = 0xC0;
        public const uint NV_pixel_buffer_object = 1;
        public const uint PIXEL_PACK_BUFFER_NV = 0x88EB;
        public const uint PIXEL_UNPACK_BUFFER_NV = 0x88EC;
        public const uint PIXEL_PACK_BUFFER_BINDING_NV = 0x88ED;
        public const uint PIXEL_UNPACK_BUFFER_BINDING_NV = 0x88EF;
        public const uint NV_pixel_data_range = 1;
        public const uint WRITE_PIXEL_DATA_RANGE_NV = 0x8878;
        public const uint READ_PIXEL_DATA_RANGE_NV = 0x8879;
        public const uint WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
        public const uint READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
        public const uint WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
        public const uint READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;
        public const uint NV_platform_binary = 1;
        public const uint NVIDIA_PLATFORM_BINARY_NV = 0x890B;
        public const uint NV_point_sprite = 1;
        public const uint POINT_SPRITE_NV = 0x8861;
        public const uint COORD_REPLACE_NV = 0x8862;
        public const uint POINT_SPRITE_R_MODE_NV = 0x8863;
        public const uint NV_polygon_mode = 1;
        public const uint POLYGON_MODE_NV = 0x0B40;
        public const uint POINT_NV = 0x1B00;
        public const uint LINE_NV = 0x1B01;
        public const uint FILL_NV = 0x1B02;
        public const uint POLYGON_OFFSET_POINT_NV = 0x2A01;
        public const uint POLYGON_OFFSET_LINE_NV = 0x2A02;
        public const uint NV_present_video = 1;
        public const uint FRAME_NV = 0x8E26;
        public const uint FIELDS_NV = 0x8E27;
        public const uint CURRENT_TIME_NV = 0x8E28;
        public const uint NUM_FILL_STREAMS_NV = 0x8E29;
        public const uint PRESENT_TIME_NV = 0x8E2A;
        public const uint PRESENT_DURATION_NV = 0x8E2B;
        public const uint NV_primitive_restart = 1;
        public const uint PRIMITIVE_RESTART_NV = 0x8558;
        public const uint PRIMITIVE_RESTART_INDEX_NV = 0x8559;
        public const uint NV_read_depth = 1;
        public const uint NV_read_depth_stencil = 1;
        public const uint NV_read_stencil = 1;
        public const uint NV_register_combiners = 1;
        public const uint REGISTER_COMBINERS_NV = 0x8522;
        public const uint VARIABLE_A_NV = 0x8523;
        public const uint VARIABLE_B_NV = 0x8524;
        public const uint VARIABLE_C_NV = 0x8525;
        public const uint VARIABLE_D_NV = 0x8526;
        public const uint VARIABLE_E_NV = 0x8527;
        public const uint VARIABLE_F_NV = 0x8528;
        public const uint VARIABLE_G_NV = 0x8529;
        public const uint CONSTANT_COLOR0_NV = 0x852A;
        public const uint CONSTANT_COLOR1_NV = 0x852B;
        public const uint SPARE0_NV = 0x852E;
        public const uint SPARE1_NV = 0x852F;
        public const uint DISCARD_NV = 0x8530;
        public const uint E_TIMES_F_NV = 0x8531;
        public const uint SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
        public const uint UNSIGNED_IDENTITY_NV = 0x8536;
        public const uint UNSIGNED_INVERT_NV = 0x8537;
        public const uint EXPAND_NORMAL_NV = 0x8538;
        public const uint EXPAND_NEGATE_NV = 0x8539;
        public const uint HALF_BIAS_NORMAL_NV = 0x853A;
        public const uint HALF_BIAS_NEGATE_NV = 0x853B;
        public const uint SIGNED_IDENTITY_NV = 0x853C;
        public const uint SIGNED_NEGATE_NV = 0x853D;
        public const uint SCALE_BY_TWO_NV = 0x853E;
        public const uint SCALE_BY_FOUR_NV = 0x853F;
        public const uint SCALE_BY_ONE_HALF_NV = 0x8540;
        public const uint BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541;
        public const uint COMBINER_INPUT_NV = 0x8542;
        public const uint COMBINER_MAPPING_NV = 0x8543;
        public const uint COMBINER_COMPONENT_USAGE_NV = 0x8544;
        public const uint COMBINER_AB_DOT_PRODUCT_NV = 0x8545;
        public const uint COMBINER_CD_DOT_PRODUCT_NV = 0x8546;
        public const uint COMBINER_MUX_SUM_NV = 0x8547;
        public const uint COMBINER_SCALE_NV = 0x8548;
        public const uint COMBINER_BIAS_NV = 0x8549;
        public const uint COMBINER_AB_OUTPUT_NV = 0x854A;
        public const uint COMBINER_CD_OUTPUT_NV = 0x854B;
        public const uint COMBINER_SUM_OUTPUT_NV = 0x854C;
        public const uint MAX_GENERAL_COMBINERS_NV = 0x854D;
        public const uint NUM_GENERAL_COMBINERS_NV = 0x854E;
        public const uint COLOR_SUM_CLAMP_NV = 0x854F;
        public const uint COMBINER0_NV = 0x8550;
        public const uint COMBINER1_NV = 0x8551;
        public const uint COMBINER2_NV = 0x8552;
        public const uint COMBINER3_NV = 0x8553;
        public const uint COMBINER4_NV = 0x8554;
        public const uint COMBINER5_NV = 0x8555;
        public const uint COMBINER6_NV = 0x8556;
        public const uint COMBINER7_NV = 0x8557;
        public const uint NV_register_combiners2 = 1;
        public const uint PER_STAGE_CONSTANTS_NV = 0x8535;
        public const uint NV_robustness_video_memory_purge = 1;
        public const uint NV_sRGB_formats = 1;
        public const uint ETC1_SRGB8_NV = 0x88EE;
        public const uint SRGB8_NV = 0x8C41;
        public const uint SLUMINANCE_ALPHA_NV = 0x8C44;
        public const uint SLUMINANCE8_ALPHA8_NV = 0x8C45;
        public const uint SLUMINANCE_NV = 0x8C46;
        public const uint SLUMINANCE8_NV = 0x8C47;
        public const uint COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C;
        public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D;
        public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E;
        public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F;
        public const uint NV_sample_locations = 1;
        public const uint SAMPLE_LOCATION_NV = 0x8E50;
        public const uint SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D;
        public const uint SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E;
        public const uint SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F;
        public const uint PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340;
        public const uint PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341;
        public const uint FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342;
        public const uint FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343;
        public const uint NV_sample_mask_override_coverage = 1;
        public const uint NV_shader_atomic_counters = 1;
        public const uint NV_shader_atomic_float = 1;
        public const uint NV_shader_atomic_float64 = 1;
        public const uint NV_shader_atomic_fp16_vector = 1;
        public const uint NV_shader_atomic_int64 = 1;
        public const uint NV_shader_buffer_load = 1;
        public const uint BUFFER_GPU_ADDRESS_NV = 0x8F1D;
        public const uint GPU_ADDRESS_NV = 0x8F34;
        public const uint MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;
        public const uint NV_shader_noperspective_interpolation = 1;
        public const uint NV_shader_storage_buffer_object = 1;
        public const uint NV_shader_thread_group = 1;
        public const uint WARP_SIZE_NV = 0x9339;
        public const uint WARPS_PER_SM_NV = 0x933A;
        public const uint SM_COUNT_NV = 0x933B;
        public const uint NV_shader_thread_shuffle = 1;
        public const uint NV_shadow_samplers_array = 1;
        public const uint SAMPLER_2D_ARRAY_SHADOW_NV = 0x8DC4;
        public const uint NV_shadow_samplers_cube = 1;
        public const uint SAMPLER_CUBE_SHADOW_NV = 0x8DC5;
        public const uint NV_stereo_view_rendering = 1;
        public const uint NV_tessellation_program5 = 1;
        public const uint MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;
        public const uint TESS_CONTROL_PROGRAM_NV = 0x891E;
        public const uint TESS_EVALUATION_PROGRAM_NV = 0x891F;
        public const uint TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
        public const uint TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;
        public const uint NV_texgen_emboss = 1;
        public const uint EMBOSS_LIGHT_NV = 0x855D;
        public const uint EMBOSS_CONSTANT_NV = 0x855E;
        public const uint EMBOSS_MAP_NV = 0x855F;
        public const uint NV_texgen_reflection = 1;
        public const uint NORMAL_MAP_NV = 0x8511;
        public const uint REFLECTION_MAP_NV = 0x8512;
        public const uint NV_texture_array = 1;
        public const uint UNPACK_SKIP_IMAGES_NV = 0x806D;
        public const uint UNPACK_IMAGE_HEIGHT_NV = 0x806E;
        public const uint MAX_ARRAY_TEXTURE_LAYERS_NV = 0x88FF;
        public const uint TEXTURE_2D_ARRAY_NV = 0x8C1A;
        public const uint TEXTURE_BINDING_2D_ARRAY_NV = 0x8C1D;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_NV = 0x8CD4;
        public const uint SAMPLER_2D_ARRAY_NV = 0x8DC1;
        public const uint NV_texture_barrier = 1;
        public const uint NV_texture_border_clamp = 1;
        public const uint TEXTURE_BORDER_COLOR_NV = 0x1004;
        public const uint CLAMP_TO_BORDER_NV = 0x812D;
        public const uint NV_texture_compression_latc = 1;
        public const uint COMPRESSED_LUMINANCE_LATC1_NV = 0x8C70;
        public const uint COMPRESSED_SIGNED_LUMINANCE_LATC1_NV = 0x8C71;
        public const uint COMPRESSED_LUMINANCE_ALPHA_LATC2_NV = 0x8C72;
        public const uint COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_NV = 0x8C73;
        public const uint NV_texture_compression_s3tc = 1;
        public const uint COMPRESSED_RGB_S3TC_DXT1_NV = 0x83F0;
        public const uint COMPRESSED_RGBA_S3TC_DXT1_NV = 0x83F1;
        public const uint COMPRESSED_RGBA_S3TC_DXT3_NV = 0x83F2;
        public const uint COMPRESSED_RGBA_S3TC_DXT5_NV = 0x83F3;
        public const uint NV_texture_compression_s3tc_update = 1;
        public const uint NV_texture_compression_vtc = 1;
        public const uint NV_texture_env_combine4 = 1;
        public const uint COMBINE4_NV = 0x8503;
        public const uint SOURCE3_RGB_NV = 0x8583;
        public const uint SOURCE3_ALPHA_NV = 0x858B;
        public const uint OPERAND3_RGB_NV = 0x8593;
        public const uint OPERAND3_ALPHA_NV = 0x859B;
        public const uint NV_texture_expand_normal = 1;
        public const uint TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;
        public const uint NV_texture_multisample = 1;
        public const uint TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;
        public const uint TEXTURE_COLOR_SAMPLES_NV = 0x9046;
        public const uint NV_texture_npot_2D_mipmap = 1;
        public const uint NV_texture_rectangle = 1;
        public const uint TEXTURE_RECTANGLE_NV = 0x84F5;
        public const uint TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
        public const uint PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;
        public const uint MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
        public const uint NV_texture_rectangle_compressed = 1;
        public const uint NV_texture_shader = 1;
        public const uint OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;
        public const uint OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
        public const uint DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
        public const uint RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
        public const uint UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;
        public const uint UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;
        public const uint DSDT_MAG_INTENSITY_NV = 0x86DC;
        public const uint SHADER_CONSISTENT_NV = 0x86DD;
        public const uint TEXTURE_SHADER_NV = 0x86DE;
        public const uint SHADER_OPERATION_NV = 0x86DF;
        public const uint CULL_MODES_NV = 0x86E0;
        public const uint OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1;
        public const uint OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
        public const uint OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2;
        public const uint OFFSET_TEXTURE_SCALE_NV = 0x86E2;
        public const uint OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3;
        public const uint OFFSET_TEXTURE_BIAS_NV = 0x86E3;
        public const uint PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;
        public const uint CONST_EYE_NV = 0x86E5;
        public const uint PASS_THROUGH_NV = 0x86E6;
        public const uint CULL_FRAGMENT_NV = 0x86E7;
        public const uint OFFSET_TEXTURE_2D_NV = 0x86E8;
        public const uint DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;
        public const uint DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;
        public const uint DOT_PRODUCT_NV = 0x86EC;
        public const uint DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;
        public const uint DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;
        public const uint DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
        public const uint DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
        public const uint DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
        public const uint DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
        public const uint HILO_NV = 0x86F4;
        public const uint DSDT_NV = 0x86F5;
        public const uint DSDT_MAG_NV = 0x86F6;
        public const uint DSDT_MAG_VIB_NV = 0x86F7;
        public const uint HILO16_NV = 0x86F8;
        public const uint SIGNED_HILO_NV = 0x86F9;
        public const uint SIGNED_HILO16_NV = 0x86FA;
        public const uint SIGNED_RGBA_NV = 0x86FB;
        public const uint SIGNED_RGBA8_NV = 0x86FC;
        public const uint SIGNED_RGB_NV = 0x86FE;
        public const uint SIGNED_RGB8_NV = 0x86FF;
        public const uint SIGNED_LUMINANCE_NV = 0x8701;
        public const uint SIGNED_LUMINANCE8_NV = 0x8702;
        public const uint SIGNED_LUMINANCE_ALPHA_NV = 0x8703;
        public const uint SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;
        public const uint SIGNED_ALPHA_NV = 0x8705;
        public const uint SIGNED_ALPHA8_NV = 0x8706;
        public const uint SIGNED_INTENSITY_NV = 0x8707;
        public const uint SIGNED_INTENSITY8_NV = 0x8708;
        public const uint DSDT8_NV = 0x8709;
        public const uint DSDT8_MAG8_NV = 0x870A;
        public const uint DSDT8_MAG8_INTENSITY8_NV = 0x870B;
        public const uint SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;
        public const uint SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
        public const uint HI_SCALE_NV = 0x870E;
        public const uint LO_SCALE_NV = 0x870F;
        public const uint DS_SCALE_NV = 0x8710;
        public const uint DT_SCALE_NV = 0x8711;
        public const uint MAGNITUDE_SCALE_NV = 0x8712;
        public const uint VIBRANCE_SCALE_NV = 0x8713;
        public const uint HI_BIAS_NV = 0x8714;
        public const uint LO_BIAS_NV = 0x8715;
        public const uint DS_BIAS_NV = 0x8716;
        public const uint DT_BIAS_NV = 0x8717;
        public const uint MAGNITUDE_BIAS_NV = 0x8718;
        public const uint VIBRANCE_BIAS_NV = 0x8719;
        public const uint TEXTURE_BORDER_VALUES_NV = 0x871A;
        public const uint TEXTURE_HI_SIZE_NV = 0x871B;
        public const uint TEXTURE_LO_SIZE_NV = 0x871C;
        public const uint TEXTURE_DS_SIZE_NV = 0x871D;
        public const uint TEXTURE_DT_SIZE_NV = 0x871E;
        public const uint TEXTURE_MAG_SIZE_NV = 0x871F;
        public const uint NV_texture_shader2 = 1;
        public const uint DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF;
        public const uint NV_texture_shader3 = 1;
        public const uint OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;
        public const uint OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;
        public const uint OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;
        public const uint OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;
        public const uint OFFSET_HILO_TEXTURE_2D_NV = 0x8854;
        public const uint OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;
        public const uint OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;
        public const uint OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;
        public const uint DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858;
        public const uint DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859;
        public const uint DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;
        public const uint DOT_PRODUCT_PASS_THROUGH_NV = 0x885B;
        public const uint DOT_PRODUCT_TEXTURE_1D_NV = 0x885C;
        public const uint DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;
        public const uint HILO8_NV = 0x885E;
        public const uint SIGNED_HILO8_NV = 0x885F;
        public const uint FORCE_BLUE_TO_ONE_NV = 0x8860;
        public const uint NV_transform_feedback = 1;
        public const uint BACK_PRIMARY_COLOR_NV = 0x8C77;
        public const uint BACK_SECONDARY_COLOR_NV = 0x8C78;
        public const uint TEXTURE_COORD_NV = 0x8C79;
        public const uint CLIP_DISTANCE_NV = 0x8C7A;
        public const uint VERTEX_ID_NV = 0x8C7B;
        public const uint PRIMITIVE_ID_NV = 0x8C7C;
        public const uint GENERIC_ATTRIB_NV = 0x8C7D;
        public const uint TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E;
        public const uint TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80;
        public const uint ACTIVE_VARYINGS_NV = 0x8C81;
        public const uint ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82;
        public const uint TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83;
        public const uint TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84;
        public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85;
        public const uint TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86;
        public const uint PRIMITIVES_GENERATED_NV = 0x8C87;
        public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88;
        public const uint RASTERIZER_DISCARD_NV = 0x8C89;
        public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B;
        public const uint INTERLEAVED_ATTRIBS_NV = 0x8C8C;
        public const uint SEPARATE_ATTRIBS_NV = 0x8C8D;
        public const uint TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E;
        public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F;
        public const uint NV_transform_feedback2 = 1;
        public const uint TRANSFORM_FEEDBACK_NV = 0x8E22;
        public const uint TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
        public const uint TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
        public const uint TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;
        public const uint NV_uniform_buffer_unified_memory = 1;
        public const uint UNIFORM_BUFFER_UNIFIED_NV = 0x936E;
        public const uint UNIFORM_BUFFER_ADDRESS_NV = 0x936F;
        public const uint UNIFORM_BUFFER_LENGTH_NV = 0x9370;
        public const uint NV_vdpau_interop = 1;
        public const uint SURFACE_STATE_NV = 0x86EB;
        public const uint SURFACE_REGISTERED_NV = 0x86FD;
        public const uint SURFACE_MAPPED_NV = 0x8700;
        public const uint WRITE_DISCARD_NV = 0x88BE;
        public const uint NV_vertex_array_range = 1;
        public const uint VERTEX_ARRAY_RANGE_NV = 0x851D;
        public const uint VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
        public const uint VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
        public const uint MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
        public const uint VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
        public const uint NV_vertex_array_range2 = 1;
        public const uint VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;
        public const uint NV_vertex_attrib_integer_64bit = 1;
        public const uint NV_vertex_buffer_unified_memory = 1;
        public const uint VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;
        public const uint ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;
        public const uint VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;
        public const uint VERTEX_ARRAY_ADDRESS_NV = 0x8F21;
        public const uint NORMAL_ARRAY_ADDRESS_NV = 0x8F22;
        public const uint COLOR_ARRAY_ADDRESS_NV = 0x8F23;
        public const uint INDEX_ARRAY_ADDRESS_NV = 0x8F24;
        public const uint TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;
        public const uint EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;
        public const uint SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;
        public const uint FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;
        public const uint ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;
        public const uint VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;
        public const uint VERTEX_ARRAY_LENGTH_NV = 0x8F2B;
        public const uint NORMAL_ARRAY_LENGTH_NV = 0x8F2C;
        public const uint COLOR_ARRAY_LENGTH_NV = 0x8F2D;
        public const uint INDEX_ARRAY_LENGTH_NV = 0x8F2E;
        public const uint TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;
        public const uint EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;
        public const uint SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;
        public const uint FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;
        public const uint ELEMENT_ARRAY_LENGTH_NV = 0x8F33;
        public const uint DRAW_INDIRECT_UNIFIED_NV = 0x8F40;
        public const uint DRAW_INDIRECT_ADDRESS_NV = 0x8F41;
        public const uint DRAW_INDIRECT_LENGTH_NV = 0x8F42;
        public const uint NV_vertex_program = 1;
        public const uint VERTEX_PROGRAM_NV = 0x8620;
        public const uint VERTEX_STATE_PROGRAM_NV = 0x8621;
        public const uint ATTRIB_ARRAY_SIZE_NV = 0x8623;
        public const uint ATTRIB_ARRAY_STRIDE_NV = 0x8624;
        public const uint ATTRIB_ARRAY_TYPE_NV = 0x8625;
        public const uint CURRENT_ATTRIB_NV = 0x8626;
        public const uint PROGRAM_LENGTH_NV = 0x8627;
        public const uint PROGRAM_STRING_NV = 0x8628;
        public const uint MODELVIEW_PROJECTION_NV = 0x8629;
        public const uint IDENTITY_NV = 0x862A;
        public const uint INVERSE_NV = 0x862B;
        public const uint TRANSPOSE_NV = 0x862C;
        public const uint INVERSE_TRANSPOSE_NV = 0x862D;
        public const uint MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
        public const uint MAX_TRACK_MATRICES_NV = 0x862F;
        public const uint MATRIX0_NV = 0x8630;
        public const uint MATRIX1_NV = 0x8631;
        public const uint MATRIX2_NV = 0x8632;
        public const uint MATRIX3_NV = 0x8633;
        public const uint MATRIX4_NV = 0x8634;
        public const uint MATRIX5_NV = 0x8635;
        public const uint MATRIX6_NV = 0x8636;
        public const uint MATRIX7_NV = 0x8637;
        public const uint CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640;
        public const uint CURRENT_MATRIX_NV = 0x8641;
        public const uint VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642;
        public const uint VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643;
        public const uint PROGRAM_PARAMETER_NV = 0x8644;
        public const uint ATTRIB_ARRAY_POINTER_NV = 0x8645;
        public const uint PROGRAM_TARGET_NV = 0x8646;
        public const uint PROGRAM_RESIDENT_NV = 0x8647;
        public const uint TRACK_MATRIX_NV = 0x8648;
        public const uint TRACK_MATRIX_TRANSFORM_NV = 0x8649;
        public const uint VERTEX_PROGRAM_BINDING_NV = 0x864A;
        public const uint PROGRAM_ERROR_POSITION_NV = 0x864B;
        public const uint VERTEX_ATTRIB_ARRAY0_NV = 0x8650;
        public const uint VERTEX_ATTRIB_ARRAY1_NV = 0x8651;
        public const uint VERTEX_ATTRIB_ARRAY2_NV = 0x8652;
        public const uint VERTEX_ATTRIB_ARRAY3_NV = 0x8653;
        public const uint VERTEX_ATTRIB_ARRAY4_NV = 0x8654;
        public const uint VERTEX_ATTRIB_ARRAY5_NV = 0x8655;
        public const uint VERTEX_ATTRIB_ARRAY6_NV = 0x8656;
        public const uint VERTEX_ATTRIB_ARRAY7_NV = 0x8657;
        public const uint VERTEX_ATTRIB_ARRAY8_NV = 0x8658;
        public const uint VERTEX_ATTRIB_ARRAY9_NV = 0x8659;
        public const uint VERTEX_ATTRIB_ARRAY10_NV = 0x865A;
        public const uint VERTEX_ATTRIB_ARRAY11_NV = 0x865B;
        public const uint VERTEX_ATTRIB_ARRAY12_NV = 0x865C;
        public const uint VERTEX_ATTRIB_ARRAY13_NV = 0x865D;
        public const uint VERTEX_ATTRIB_ARRAY14_NV = 0x865E;
        public const uint VERTEX_ATTRIB_ARRAY15_NV = 0x865F;
        public const uint MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;
        public const uint MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;
        public const uint MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;
        public const uint MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;
        public const uint MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;
        public const uint MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;
        public const uint MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;
        public const uint MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;
        public const uint MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;
        public const uint MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;
        public const uint MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;
        public const uint MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;
        public const uint MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;
        public const uint MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;
        public const uint MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;
        public const uint MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;
        public const uint MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;
        public const uint MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;
        public const uint MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;
        public const uint MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;
        public const uint MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;
        public const uint MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;
        public const uint MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;
        public const uint MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;
        public const uint MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;
        public const uint MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;
        public const uint MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;
        public const uint MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;
        public const uint MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;
        public const uint MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;
        public const uint MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;
        public const uint MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;
        public const uint NV_vertex_program1_1 = 1;
        public const uint NV_vertex_program2 = 1;
        public const uint NV_vertex_program2_option = 1;
        public const uint NV_vertex_program3 = 1;
        public const uint NV_vertex_program4 = 1;
        public const uint VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD;
        public const uint NV_video_capture = 1;
        public const uint VIDEO_BUFFER_NV = 0x9020;
        public const uint VIDEO_BUFFER_BINDING_NV = 0x9021;
        public const uint FIELD_UPPER_NV = 0x9022;
        public const uint FIELD_LOWER_NV = 0x9023;
        public const uint NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;
        public const uint NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;
        public const uint VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;
        public const uint LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;
        public const uint VIDEO_BUFFER_PITCH_NV = 0x9028;
        public const uint VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;
        public const uint VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;
        public const uint VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;
        public const uint VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;
        public const uint VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;
        public const uint PARTIAL_SUCCESS_NV = 0x902E;
        public const uint SUCCESS_NV = 0x902F;
        public const uint FAILURE_NV = 0x9030;
        public const uint YCBYCR8_422_NV = 0x9031;
        public const uint YCBAYCR8A_4224_NV = 0x9032;
        public const uint Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;
        public const uint Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;
        public const uint Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;
        public const uint Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;
        public const uint Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;
        public const uint VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;
        public const uint VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;
        public const uint VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;
        public const uint VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;
        public const uint VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;
        public const uint NV_viewport_array = 1;
        public const uint MAX_VIEWPORTS_NV = 0x825B;
        public const uint VIEWPORT_SUBPIXEL_BITS_NV = 0x825C;
        public const uint VIEWPORT_BOUNDS_RANGE_NV = 0x825D;
        public const uint VIEWPORT_INDEX_PROVOKING_VERTEX_NV = 0x825F;
        public const uint NV_viewport_array2 = 1;
        public const uint NV_viewport_swizzle = 1;
        public const uint VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350;
        public const uint VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351;
        public const uint VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352;
        public const uint VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353;
        public const uint VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354;
        public const uint VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355;
        public const uint VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356;
        public const uint VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357;
        public const uint VIEWPORT_SWIZZLE_X_NV = 0x9358;
        public const uint VIEWPORT_SWIZZLE_Y_NV = 0x9359;
        public const uint VIEWPORT_SWIZZLE_Z_NV = 0x935A;
        public const uint VIEWPORT_SWIZZLE_W_NV = 0x935B;
        public const uint OES_byte_coordinates = 1;
        public const uint OML_interlace = 1;
        public const uint INTERLACE_OML = 0x8980;
        public const uint INTERLACE_READ_OML = 0x8981;
        public const uint OML_resample = 1;
        public const uint PACK_RESAMPLE_OML = 0x8984;
        public const uint UNPACK_RESAMPLE_OML = 0x8985;
        public const uint RESAMPLE_REPLICATE_OML = 0x8986;
        public const uint RESAMPLE_ZERO_FILL_OML = 0x8987;
        public const uint RESAMPLE_AVERAGE_OML = 0x8988;
        public const uint RESAMPLE_DECIMATE_OML = 0x8989;
        public const uint OML_subsample = 1;
        public const uint FORMAT_SUBSAMPLE_24_24_OML = 0x8982;
        public const uint FORMAT_SUBSAMPLE_244_244_OML = 0x8983;
        public const uint OVR_multiview = 1;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;
        public const uint MAX_VIEWS_OVR = 0x9631;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;
        public const uint FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;
        public const uint OVR_multiview2 = 1;
        public const uint OVR_multiview_multisampled_render_to_texture = 1;
        public const uint PGI_misc_hints = 1;
        public const uint PREFER_DOUBLEBUFFER_HINT_PGI = 107000;
        public const uint CONSERVE_MEMORY_HINT_PGI = 107005;
        public const uint RECLAIM_MEMORY_HINT_PGI = 107006;
        public const uint NATIVE_GRAPHICS_HANDLE_PGI = 107010;
        public const uint NATIVE_GRAPHICS_BEGIN_HINT_PGI = 107011;
        public const uint NATIVE_GRAPHICS_END_HINT_PGI = 107012;
        public const uint ALWAYS_FAST_HINT_PGI = 107020;
        public const uint ALWAYS_SOFT_HINT_PGI = 107021;
        public const uint ALLOW_DRAW_OBJ_HINT_PGI = 107022;
        public const uint ALLOW_DRAW_WIN_HINT_PGI = 107023;
        public const uint ALLOW_DRAW_FRG_HINT_PGI = 107024;
        public const uint ALLOW_DRAW_MEM_HINT_PGI = 107025;
        public const uint STRICT_DEPTHFUNC_HINT_PGI = 107030;
        public const uint STRICT_LIGHTING_HINT_PGI = 107031;
        public const uint STRICT_SCISSOR_HINT_PGI = 107032;
        public const uint FULL_STIPPLE_HINT_PGI = 107033;
        public const uint CLIP_NEAR_HINT_PGI = 107040;
        public const uint CLIP_FAR_HINT_PGI = 107041;
        public const uint WIDE_LINE_HINT_PGI = 107042;
        public const uint BACK_NORMALS_HINT_PGI = 107043;
        public const uint PGI_vertex_hints = 1;
        public const uint VERTEX23_BIT_PGI = 0x00000004;
        public const uint VERTEX4_BIT_PGI = 0x00000008;
        public const uint COLOR3_BIT_PGI = 0x00010000;
        public const uint COLOR4_BIT_PGI = 0x00020000;
        public const uint EDGEFLAG_BIT_PGI = 0x00040000;
        public const uint INDEX_BIT_PGI = 0x00080000;
        public const uint MAT_AMBIENT_BIT_PGI = 0x00100000;
        public const uint VERTEX_DATA_HINT_PGI = 107050;
        public const uint VERTEX_CONSISTENT_HINT_PGI = 107051;
        public const uint MATERIAL_SIDE_HINT_PGI = 107052;
        public const uint MAX_VERTEX_HINT_PGI = 107053;
        public const uint MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000;
        public const uint MAT_DIFFUSE_BIT_PGI = 0x00400000;
        public const uint MAT_EMISSION_BIT_PGI = 0x00800000;
        public const uint MAT_COLOR_INDEXES_BIT_PGI = 0x01000000;
        public const uint MAT_SHININESS_BIT_PGI = 0x02000000;
        public const uint MAT_SPECULAR_BIT_PGI = 0x04000000;
        public const uint NORMAL_BIT_PGI = 0x08000000;
        public const uint TEXCOORD1_BIT_PGI = 0x10000000;
        public const uint TEXCOORD2_BIT_PGI = 0x20000000;
        public const uint TEXCOORD3_BIT_PGI = 0x40000000;
        public const uint TEXCOORD4_BIT_PGI = 0x80000000;
        public const uint QCOM_alpha_test = 1;
        public const uint ALPHA_TEST_QCOM = 0x0BC0;
        public const uint ALPHA_TEST_FUNC_QCOM = 0x0BC1;
        public const uint ALPHA_TEST_REF_QCOM = 0x0BC2;
        public const uint QCOM_binning_control = 1;
        public const uint BINNING_CONTROL_HINT_QCOM = 0x8FB0;
        public const uint CPU_OPTIMIZED_QCOM = 0x8FB1;
        public const uint GPU_OPTIMIZED_QCOM = 0x8FB2;
        public const uint RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;
        public const uint QCOM_driver_control = 1;
        public const uint QCOM_extended_get = 1;
        public const uint TEXTURE_WIDTH_QCOM = 0x8BD2;
        public const uint TEXTURE_HEIGHT_QCOM = 0x8BD3;
        public const uint TEXTURE_DEPTH_QCOM = 0x8BD4;
        public const uint TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5;
        public const uint TEXTURE_FORMAT_QCOM = 0x8BD6;
        public const uint TEXTURE_TYPE_QCOM = 0x8BD7;
        public const uint TEXTURE_IMAGE_VALID_QCOM = 0x8BD8;
        public const uint TEXTURE_NUM_LEVELS_QCOM = 0x8BD9;
        public const uint TEXTURE_TARGET_QCOM = 0x8BDA;
        public const uint TEXTURE_OBJECT_VALID_QCOM = 0x8BDB;
        public const uint STATE_RESTORE = 0x8BDC;
        public const uint QCOM_extended_get2 = 1;
        public const uint QCOM_framebuffer_foveated = 1;
        public const uint FOVEATION_ENABLE_BIT_QCOM = 0x1;
        public const uint FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x2;
        public const uint QCOM_perfmon_global_mode = 1;
        public const uint PERFMON_GLOBAL_MODE_QCOM = 0x8FA0;
        public const uint QCOM_shader_framebuffer_fetch_noncoherent = 1;
        public const uint FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2;
        public const uint QCOM_tiled_rendering = 1;
        public const uint COLOR_BUFFER_BIT0_QCOM = 0x00000001;
        public const uint COLOR_BUFFER_BIT1_QCOM = 0x00000002;
        public const uint COLOR_BUFFER_BIT2_QCOM = 0x00000004;
        public const uint COLOR_BUFFER_BIT3_QCOM = 0x00000008;
        public const uint COLOR_BUFFER_BIT4_QCOM = 0x00000010;
        public const uint COLOR_BUFFER_BIT5_QCOM = 0x00000020;
        public const uint COLOR_BUFFER_BIT6_QCOM = 0x00000040;
        public const uint COLOR_BUFFER_BIT7_QCOM = 0x00000080;
        public const uint DEPTH_BUFFER_BIT0_QCOM = 0x00000100;
        public const uint DEPTH_BUFFER_BIT1_QCOM = 0x00000200;
        public const uint DEPTH_BUFFER_BIT2_QCOM = 0x00000400;
        public const uint DEPTH_BUFFER_BIT3_QCOM = 0x00000800;
        public const uint DEPTH_BUFFER_BIT4_QCOM = 0x00001000;
        public const uint DEPTH_BUFFER_BIT5_QCOM = 0x00002000;
        public const uint DEPTH_BUFFER_BIT6_QCOM = 0x00004000;
        public const uint DEPTH_BUFFER_BIT7_QCOM = 0x00008000;
        public const uint STENCIL_BUFFER_BIT0_QCOM = 0x00010000;
        public const uint STENCIL_BUFFER_BIT1_QCOM = 0x00020000;
        public const uint STENCIL_BUFFER_BIT2_QCOM = 0x00040000;
        public const uint STENCIL_BUFFER_BIT3_QCOM = 0x00080000;
        public const uint STENCIL_BUFFER_BIT4_QCOM = 0x00100000;
        public const uint STENCIL_BUFFER_BIT5_QCOM = 0x00200000;
        public const uint STENCIL_BUFFER_BIT6_QCOM = 0x00400000;
        public const uint STENCIL_BUFFER_BIT7_QCOM = 0x00800000;
        public const uint MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000;
        public const uint MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000;
        public const uint MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000;
        public const uint MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000;
        public const uint MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000;
        public const uint MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000;
        public const uint MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000;
        public const uint MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000;
        public const uint QCOM_writeonly_rendering = 1;
        public const uint WRITEONLY_RENDERING_QCOM = 0x8823;
        public const uint REGAL_ES1_0_compatibility = 1;
        public const uint REGAL_ES1_1_compatibility = 1;
        public const uint REGAL_enable = 1;
        public const uint ERROR_REGAL = 0x9322;
        public const uint DEBUG_REGAL = 0x9323;
        public const uint LOG_REGAL = 0x9324;
        public const uint EMULATION_REGAL = 0x9325;
        public const uint DRIVER_REGAL = 0x9326;
        public const uint MISSING_REGAL = 0x9360;
        public const uint TRACE_REGAL = 0x9361;
        public const uint CACHE_REGAL = 0x9362;
        public const uint CODE_REGAL = 0x9363;
        public const uint STATISTICS_REGAL = 0x9364;
        public const uint REGAL_error_string = 1;
        public const uint REGAL_extension_query = 1;
        public const uint REGAL_log = 1;
        public const uint LOG_ERROR_REGAL = 0x9319;
        public const uint LOG_WARNING_REGAL = 0x931A;
        public const uint LOG_INFO_REGAL = 0x931B;
        public const uint LOG_APP_REGAL = 0x931C;
        public const uint LOG_DRIVER_REGAL = 0x931D;
        public const uint LOG_INTERNAL_REGAL = 0x931E;
        public const uint LOG_DEBUG_REGAL = 0x931F;
        public const uint LOG_STATUS_REGAL = 0x9320;
        public const uint LOG_HTTP_REGAL = 0x9321;
        public const uint REGAL_proc_address = 1;
        public const uint REND_screen_coordinates = 1;
        public const uint SCREEN_COORDINATES_REND = 0x8490;
        public const uint INVERTED_SCREEN_W_REND = 0x8491;
        public const uint S3_s3tc = 1;
        public const uint RGB_S3TC = 0x83A0;
        public const uint RGB4_S3TC = 0x83A1;
        public const uint RGBA_S3TC = 0x83A2;
        public const uint RGBA4_S3TC = 0x83A3;
        public const uint RGBA_DXT5_S3TC = 0x83A4;
        public const uint RGBA4_DXT5_S3TC = 0x83A5;
        public const uint SGIS_clip_band_hint = 1;
        public const uint SGIS_color_range = 1;
        public const uint EXTENDED_RANGE_SGIS = 0x85A5;
        public const uint MIN_RED_SGIS = 0x85A6;
        public const uint MAX_RED_SGIS = 0x85A7;
        public const uint MIN_GREEN_SGIS = 0x85A8;
        public const uint MAX_GREEN_SGIS = 0x85A9;
        public const uint MIN_BLUE_SGIS = 0x85AA;
        public const uint MAX_BLUE_SGIS = 0x85AB;
        public const uint MIN_ALPHA_SGIS = 0x85AC;
        public const uint MAX_ALPHA_SGIS = 0x85AD;
        public const uint SGIS_detail_texture = 1;
        public const uint SGIS_fog_function = 1;
        public const uint SGIS_generate_mipmap = 1;
        public const uint GENERATE_MIPMAP_SGIS = 0x8191;
        public const uint GENERATE_MIPMAP_HINT_SGIS = 0x8192;
        public const uint SGIS_line_texgen = 1;
        public const uint SGIS_multisample = 1;
        public const uint MULTISAMPLE_SGIS = 0x809D;
        public const uint SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E;
        public const uint SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F;
        public const uint SAMPLE_MASK_SGIS = 0x80A0;
        public const uint _1PASS_SGIS = 0x80A1;
        public const uint _2PASS_0_SGIS = 0x80A2;
        public const uint _2PASS_1_SGIS = 0x80A3;
        public const uint _4PASS_0_SGIS = 0x80A4;
        public const uint _4PASS_1_SGIS = 0x80A5;
        public const uint _4PASS_2_SGIS = 0x80A6;
        public const uint _4PASS_3_SGIS = 0x80A7;
        public const uint SAMPLE_BUFFERS_SGIS = 0x80A8;
        public const uint SAMPLES_SGIS = 0x80A9;
        public const uint SAMPLE_MASK_VALUE_SGIS = 0x80AA;
        public const uint SAMPLE_MASK_INVERT_SGIS = 0x80AB;
        public const uint SAMPLE_PATTERN_SGIS = 0x80AC;
        public const uint SGIS_multitexture = 1;
        public const uint SELECTED_TEXTURE_SGIS = 0x83C0;
        public const uint SELECTED_TEXTURE_COORD_SET_SGIS = 0x83C1;
        public const uint SELECTED_TEXTURE_TRANSFORM_SGIS = 0x83C2;
        public const uint MAX_TEXTURES_SGIS = 0x83C3;
        public const uint MAX_TEXTURE_COORD_SETS_SGIS = 0x83C4;
        public const uint TEXTURE_COORD_SET_INTERLEAVE_FACTOR_SGIS = 0x83C5;
        public const uint TEXTURE_ENV_COORD_SET_SGIS = 0x83C6;
        public const uint TEXTURE0_SGIS = 0x83C7;
        public const uint TEXTURE1_SGIS = 0x83C8;
        public const uint TEXTURE2_SGIS = 0x83C9;
        public const uint TEXTURE3_SGIS = 0x83CA;
        public const uint SGIS_pixel_texture = 1;
        public const uint SGIS_point_line_texgen = 1;
        public const uint EYE_DISTANCE_TO_POINT_SGIS = 0x81F0;
        public const uint OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1;
        public const uint EYE_DISTANCE_TO_LINE_SGIS = 0x81F2;
        public const uint OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3;
        public const uint EYE_POINT_SGIS = 0x81F4;
        public const uint OBJECT_POINT_SGIS = 0x81F5;
        public const uint EYE_LINE_SGIS = 0x81F6;
        public const uint OBJECT_LINE_SGIS = 0x81F7;
        public const uint SGIS_shared_multisample = 1;
        public const uint SGIS_sharpen_texture = 1;
        public const uint SGIS_texture4D = 1;
        public const uint SGIS_texture_border_clamp = 1;
        public const uint CLAMP_TO_BORDER_SGIS = 0x812D;
        public const uint SGIS_texture_edge_clamp = 1;
        public const uint CLAMP_TO_EDGE_SGIS = 0x812F;
        public const uint SGIS_texture_filter4 = 1;
        public const uint SGIS_texture_lod = 1;
        public const uint TEXTURE_MIN_LOD_SGIS = 0x813A;
        public const uint TEXTURE_MAX_LOD_SGIS = 0x813B;
        public const uint TEXTURE_BASE_LEVEL_SGIS = 0x813C;
        public const uint TEXTURE_MAX_LEVEL_SGIS = 0x813D;
        public const uint SGIS_texture_select = 1;
        public const uint SGIX_async = 1;
        public const uint ASYNC_MARKER_SGIX = 0x8329;
        public const uint SGIX_async_histogram = 1;
        public const uint ASYNC_HISTOGRAM_SGIX = 0x832C;
        public const uint MAX_ASYNC_HISTOGRAM_SGIX = 0x832D;
        public const uint SGIX_async_pixel = 1;
        public const uint ASYNC_TEX_IMAGE_SGIX = 0x835C;
        public const uint ASYNC_DRAW_PIXELS_SGIX = 0x835D;
        public const uint ASYNC_READ_PIXELS_SGIX = 0x835E;
        public const uint MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F;
        public const uint MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360;
        public const uint MAX_ASYNC_READ_PIXELS_SGIX = 0x8361;
        public const uint SGIX_bali_g_instruments = 1;
        public const uint BALI_NUM_TRIS_CULLED_INSTRUMENT = 0x6080;
        public const uint BALI_NUM_PRIMS_CLIPPED_INSTRUMENT = 0x6081;
        public const uint BALI_NUM_PRIMS_REJECT_INSTRUMENT = 0x6082;
        public const uint BALI_NUM_PRIMS_CLIP_RESULT_INSTRUMENT = 0x6083;
        public const uint SGIX_bali_r_instruments = 1;
        public const uint BALI_FRAGMENTS_GENERATED_INSTRUMENT = 0x6090;
        public const uint BALI_DEPTH_PASS_INSTRUMENT = 0x6091;
        public const uint BALI_R_CHIP_COUNT = 0x6092;
        public const uint SGIX_bali_timer_instruments = 1;
        public const uint SGIX_blend_alpha_minmax = 1;
        public const uint ALPHA_MIN_SGIX = 0x8320;
        public const uint ALPHA_MAX_SGIX = 0x8321;
        public const uint SGIX_blend_cadd = 1;
        public const uint FUNC_COMPLEX_ADD_EXT = 0x601C;
        public const uint SGIX_blend_cmultiply = 1;
        public const uint FUNC_COMPLEX_MULTIPLY_EXT = 0x601B;
        public const uint SGIX_calligraphic_fragment = 1;
        public const uint SGIX_clipmap = 1;
        public const uint SGIX_color_matrix_accuracy = 1;
        public const uint COLOR_MATRIX_HINT = 0x8317;
        public const uint SGIX_color_table_index_mode = 1;
        public const uint SGIX_complex_polar = 1;
        public const uint SGIX_convolution_accuracy = 1;
        public const uint CONVOLUTION_HINT_SGIX = 0x8316;
        public const uint SGIX_cube_map = 1;
        public const uint ENV_MAP_SGIX = 0x8340;
        public const uint CUBE_MAP_SGIX = 0x8341;
        public const uint CUBE_MAP_ZP_SGIX = 0x8342;
        public const uint CUBE_MAP_ZN_SGIX = 0x8343;
        public const uint CUBE_MAP_XN_SGIX = 0x8344;
        public const uint CUBE_MAP_XP_SGIX = 0x8345;
        public const uint CUBE_MAP_YN_SGIX = 0x8346;
        public const uint CUBE_MAP_YP_SGIX = 0x8347;
        public const uint CUBE_MAP_BINDING_SGIX = 0x8348;
        public const uint SGIX_cylinder_texgen = 1;
        public const uint SGIX_datapipe = 1;
        public const uint GEOMETRY_BIT = 0x1;
        public const uint IMAGE_BIT = 0x2;
        public const uint SGIX_decimation = 1;
        public const uint SGIX_depth_pass_instrument = 1;
        public const uint DEPTH_PASS_INSTRUMENT_SGIX = 0x8310;
        public const uint DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX = 0x8311;
        public const uint DEPTH_PASS_INSTRUMENT_MAX_SGIX = 0x8312;
        public const uint SGIX_depth_texture = 1;
        public const uint DEPTH_COMPONENT16_SGIX = 0x81A5;
        public const uint DEPTH_COMPONENT24_SGIX = 0x81A6;
        public const uint DEPTH_COMPONENT32_SGIX = 0x81A7;
        public const uint SGIX_dvc = 1;
        public const uint SGIX_flush_raster = 1;
        public const uint SGIX_fog_blend = 1;
        public const uint FOG_BLEND_ALPHA_SGIX = 0x81FE;
        public const uint FOG_BLEND_COLOR_SGIX = 0x81FF;
        public const uint SGIX_fog_factor_to_alpha = 1;
        public const uint SGIX_fog_layers = 1;
        public const uint FOG_TYPE_SGIX = 0x8323;
        public const uint UNIFORM_SGIX = 0x8324;
        public const uint LAYERED_SGIX = 0x8325;
        public const uint FOG_GROUND_PLANE_SGIX = 0x8326;
        public const uint FOG_LAYERS_POINTS_SGIX = 0x8327;
        public const uint MAX_FOG_LAYERS_POINTS_SGIX = 0x8328;
        public const uint SGIX_fog_offset = 1;
        public const uint FOG_OFFSET_SGIX = 0x8198;
        public const uint FOG_OFFSET_VALUE_SGIX = 0x8199;
        public const uint SGIX_fog_patchy = 1;
        public const uint SGIX_fog_scale = 1;
        public const uint FOG_SCALE_SGIX = 0x81FC;
        public const uint FOG_SCALE_VALUE_SGIX = 0x81FD;
        public const uint SGIX_fog_texture = 1;
        public const uint SGIX_fragment_lighting_space = 1;
        public const uint EYE_SPACE_SGIX = 0x8436;
        public const uint TANGENT_SPACE_SGIX = 0x8437;
        public const uint OBJECT_SPACE_SGIX = 0x8438;
        public const uint FRAGMENT_LIGHT_SPACE_SGIX = 0x843D;
        public const uint SGIX_fragment_specular_lighting = 1;
        public const uint SGIX_fragments_instrument = 1;
        public const uint FRAGMENTS_INSTRUMENT_SGIX = 0x8313;
        public const uint FRAGMENTS_INSTRUMENT_COUNTERS_SGIX = 0x8314;
        public const uint FRAGMENTS_INSTRUMENT_MAX_SGIX = 0x8315;
        public const uint SGIX_framezoom = 1;
        public const uint SGIX_icc_texture = 1;
        public const uint RGB_ICC_SGIX = 0x8460;
        public const uint RGBA_ICC_SGIX = 0x8461;
        public const uint ALPHA_ICC_SGIX = 0x8462;
        public const uint LUMINANCE_ICC_SGIX = 0x8463;
        public const uint INTENSITY_ICC_SGIX = 0x8464;
        public const uint LUMINANCE_ALPHA_ICC_SGIX = 0x8465;
        public const uint R5_G6_B5_ICC_SGIX = 0x8466;
        public const uint R5_G6_B5_A8_ICC_SGIX = 0x8467;
        public const uint ALPHA16_ICC_SGIX = 0x8468;
        public const uint LUMINANCE16_ICC_SGIX = 0x8469;
        public const uint INTENSITY16_ICC_SGIX = 0x846A;
        public const uint LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B;
        public const uint SGIX_igloo_interface = 1;
        public const uint IGLOO_FULLSCREEN_SGIX = 0x819E;
        public const uint IGLOO_VIEWPORT_OFFSET_SGIX = 0x819F;
        public const uint IGLOO_SWAPTMESH_SGIX = 0x81A0;
        public const uint IGLOO_COLORNORMAL_SGIX = 0x81A1;
        public const uint IGLOO_IRISGL_MODE_SGIX = 0x81A2;
        public const uint IGLOO_LMC_COLOR_SGIX = 0x81A3;
        public const uint IGLOO_TMESHMODE_SGIX = 0x81A4;
        public const uint LIGHT31 = 0xBEAD;
        public const uint SGIX_image_compression = 1;
        public const uint SGIX_impact_pixel_texture = 1;
        public const uint SGIX_instrument_error = 1;
        public const uint SGIX_interlace = 1;
        public const uint INTERLACE_SGIX = 0x8094;
        public const uint SGIX_ir_instrument1 = 1;
        public const uint SGIX_line_quality_hint = 1;
        public const uint LINE_QUALITY_HINT_SGIX = 0x835B;
        public const uint SGIX_list_priority = 1;
        public const uint SGIX_mpeg1 = 1;
        public const uint SGIX_mpeg2 = 1;
        public const uint SGIX_nonlinear_lighting_pervertex = 1;
        public const uint SGIX_nurbs_eval = 1;
        public const uint MAP1_VERTEX_3_NURBS_SGIX = 0x81CB;
        public const uint MAP1_VERTEX_4_NURBS_SGIX = 0x81CC;
        public const uint MAP1_INDEX_NURBS_SGIX = 0x81CD;
        public const uint MAP1_COLOR_4_NURBS_SGIX = 0x81CE;
        public const uint MAP1_NORMAL_NURBS_SGIX = 0x81CF;
        public const uint MAP1_TEXTURE_COORD_1_NURBS_SGIX = 0x81E0;
        public const uint MAP1_TEXTURE_COORD_2_NURBS_SGIX = 0x81E1;
        public const uint MAP1_TEXTURE_COORD_3_NURBS_SGIX = 0x81E2;
        public const uint MAP1_TEXTURE_COORD_4_NURBS_SGIX = 0x81E3;
        public const uint MAP2_VERTEX_3_NURBS_SGIX = 0x81E4;
        public const uint MAP2_VERTEX_4_NURBS_SGIX = 0x81E5;
        public const uint MAP2_INDEX_NURBS_SGIX = 0x81E6;
        public const uint MAP2_COLOR_4_NURBS_SGIX = 0x81E7;
        public const uint MAP2_NORMAL_NURBS_SGIX = 0x81E8;
        public const uint MAP2_TEXTURE_COORD_1_NURBS_SGIX = 0x81E9;
        public const uint MAP2_TEXTURE_COORD_2_NURBS_SGIX = 0x81EA;
        public const uint MAP2_TEXTURE_COORD_3_NURBS_SGIX = 0x81EB;
        public const uint MAP2_TEXTURE_COORD_4_NURBS_SGIX = 0x81EC;
        public const uint NURBS_KNOT_COUNT_SGIX = 0x81ED;
        public const uint NURBS_KNOT_VECTOR_SGIX = 0x81EE;
        public const uint SGIX_occlusion_instrument = 1;
        public const uint OCCLUSION_INSTRUMENT_SGIX = 0x6060;
        public const uint SGIX_packed_6bytes = 1;
        public const uint SGIX_pixel_texture = 1;
        public const uint SGIX_pixel_texture_bits = 1;
        public const uint SGIX_pixel_texture_lod = 1;
        public const uint SGIX_pixel_tiles = 1;
        public const uint SGIX_polynomial_ffd = 1;
        public const uint TEXTURE_DEFORMATION_BIT_SGIX = 0x1;
        public const uint GEOMETRY_DEFORMATION_BIT_SGIX = 0x2;
        public const uint SGIX_quad_mesh = 1;
        public const uint SGIX_reference_plane = 1;
        public const uint SGIX_resample = 1;
        public const uint PACK_RESAMPLE_SGIX = 0x842E;
        public const uint UNPACK_RESAMPLE_SGIX = 0x842F;
        public const uint RESAMPLE_DECIMATE_SGIX = 0x8430;
        public const uint RESAMPLE_REPLICATE_SGIX = 0x8433;
        public const uint RESAMPLE_ZERO_FILL_SGIX = 0x8434;
        public const uint SGIX_scalebias_hint = 1;
        public const uint SCALEBIAS_HINT_SGIX = 0x8322;
        public const uint SGIX_shadow = 1;
        public const uint TEXTURE_COMPARE_SGIX = 0x819A;
        public const uint TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;
        public const uint TEXTURE_LEQUAL_R_SGIX = 0x819C;
        public const uint TEXTURE_GEQUAL_R_SGIX = 0x819D;
        public const uint SGIX_shadow_ambient = 1;
        public const uint SHADOW_AMBIENT_SGIX = 0x80BF;
        public const uint SGIX_slim = 1;
        public const uint PACK_MAX_COMPRESSED_SIZE_SGIX = 0x831B;
        public const uint SLIM8U_SGIX = 0x831D;
        public const uint SLIM10U_SGIX = 0x831E;
        public const uint SLIM12S_SGIX = 0x831F;
        public const uint SGIX_spotlight_cutoff = 1;
        public const uint SPOT_CUTOFF_DELTA_SGIX = 0x8193;
        public const uint SGIX_sprite = 1;
        public const uint SGIX_subdiv_patch = 1;
        public const uint SGIX_subsample = 1;
        public const uint PACK_SUBSAMPLE_RATE_SGIX = 0x85A0;
        public const uint UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1;
        public const uint PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2;
        public const uint PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3;
        public const uint PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4;
        public const uint SGIX_tag_sample_buffer = 1;
        public const uint SGIX_texture_add_env = 1;
        public const uint SGIX_texture_coordinate_clamp = 1;
        public const uint TEXTURE_MAX_CLAMP_S_SGIX = 0x8369;
        public const uint TEXTURE_MAX_CLAMP_T_SGIX = 0x836A;
        public const uint TEXTURE_MAX_CLAMP_R_SGIX = 0x836B;
        public const uint SGIX_texture_lod_bias = 1;
        public const uint SGIX_texture_mipmap_anisotropic = 1;
        public const uint TEXTURE_MIPMAP_ANISOTROPY_SGIX = 0x832E;
        public const uint MAX_MIPMAP_ANISOTROPY_SGIX = 0x832F;
        public const uint SGIX_texture_multi_buffer = 1;
        public const uint TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E;
        public const uint SGIX_texture_phase = 1;
        public const uint PHASE_SGIX = 0x832A;
        public const uint SGIX_texture_range = 1;
        public const uint RGB_SIGNED_SGIX = 0x85E0;
        public const uint RGBA_SIGNED_SGIX = 0x85E1;
        public const uint ALPHA_SIGNED_SGIX = 0x85E2;
        public const uint LUMINANCE_SIGNED_SGIX = 0x85E3;
        public const uint INTENSITY_SIGNED_SGIX = 0x85E4;
        public const uint LUMINANCE_ALPHA_SIGNED_SGIX = 0x85E5;
        public const uint RGB16_SIGNED_SGIX = 0x85E6;
        public const uint RGBA16_SIGNED_SGIX = 0x85E7;
        public const uint ALPHA16_SIGNED_SGIX = 0x85E8;
        public const uint LUMINANCE16_SIGNED_SGIX = 0x85E9;
        public const uint INTENSITY16_SIGNED_SGIX = 0x85EA;
        public const uint LUMINANCE16_ALPHA16_SIGNED_SGIX = 0x85EB;
        public const uint RGB_EXTENDED_RANGE_SGIX = 0x85EC;
        public const uint RGBA_EXTENDED_RANGE_SGIX = 0x85ED;
        public const uint ALPHA_EXTENDED_RANGE_SGIX = 0x85EE;
        public const uint LUMINANCE_EXTENDED_RANGE_SGIX = 0x85EF;
        public const uint INTENSITY_EXTENDED_RANGE_SGIX = 0x85F0;
        public const uint LUMINANCE_ALPHA_EXTENDED_RANGE_SGIX = 0x85F1;
        public const uint RGB16_EXTENDED_RANGE_SGIX = 0x85F2;
        public const uint RGBA16_EXTENDED_RANGE_SGIX = 0x85F3;
        public const uint ALPHA16_EXTENDED_RANGE_SGIX = 0x85F4;
        public const uint LUMINANCE16_EXTENDED_RANGE_SGIX = 0x85F5;
        public const uint INTENSITY16_EXTENDED_RANGE_SGIX = 0x85F6;
        public const uint LUMINANCE16_ALPHA16_EXTENDED_RANGE_SGIX = 0x85F7;
        public const uint MIN_LUMINANCE_SGIS = 0x85F8;
        public const uint MAX_LUMINANCE_SGIS = 0x85F9;
        public const uint MIN_INTENSITY_SGIS = 0x85FA;
        public const uint MAX_INTENSITY_SGIS = 0x85FB;
        public const uint SGIX_texture_scale_bias = 1;
        public const uint POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179;
        public const uint POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;
        public const uint POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;
        public const uint POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;
        public const uint SGIX_texture_supersample = 1;
        public const uint SGIX_vector_ops = 1;
        public const uint SGIX_vertex_array_object = 1;
        public const uint SGIX_vertex_preclip = 1;
        public const uint VERTEX_PRECLIP_SGIX = 0x83EE;
        public const uint VERTEX_PRECLIP_HINT_SGIX = 0x83EF;
        public const uint SGIX_vertex_preclip_hint = 1;
        public const uint SGIX_ycrcb = 1;
        public const uint SGIX_ycrcb_subsample = 1;
        public const uint SGIX_ycrcba = 1;
        public const uint YCRCB_SGIX = 0x8318;
        public const uint YCRCBA_SGIX = 0x8319;
        public const uint SGI_color_matrix = 1;
        public const uint COLOR_MATRIX_SGI = 0x80B1;
        public const uint COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2;
        public const uint MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3;
        public const uint POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4;
        public const uint POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5;
        public const uint POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6;
        public const uint POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7;
        public const uint POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8;
        public const uint POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9;
        public const uint POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA;
        public const uint POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB;
        public const uint SGI_color_table = 1;
        public const uint COLOR_TABLE_SGI = 0x80D0;
        public const uint POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1;
        public const uint POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2;
        public const uint PROXY_COLOR_TABLE_SGI = 0x80D3;
        public const uint PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4;
        public const uint PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5;
        public const uint COLOR_TABLE_SCALE_SGI = 0x80D6;
        public const uint COLOR_TABLE_BIAS_SGI = 0x80D7;
        public const uint COLOR_TABLE_FORMAT_SGI = 0x80D8;
        public const uint COLOR_TABLE_WIDTH_SGI = 0x80D9;
        public const uint COLOR_TABLE_RED_SIZE_SGI = 0x80DA;
        public const uint COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB;
        public const uint COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC;
        public const uint COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD;
        public const uint COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE;
        public const uint COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF;
        public const uint SGI_complex = 1;
        public const uint SGI_complex_type = 1;
        public const uint COMPLEX_UNSIGNED_BYTE_SGI = 0x81BD;
        public const uint COMPLEX_BYTE_SGI = 0x81BE;
        public const uint COMPLEX_UNSIGNED_SHORT_SGI = 0x81BF;
        public const uint COMPLEX_SHORT_SGI = 0x81C0;
        public const uint COMPLEX_UNSIGNED_INT_SGI = 0x81C1;
        public const uint COMPLEX_INT_SGI = 0x81C2;
        public const uint COMPLEX_FLOAT_SGI = 0x81C3;
        public const uint SGI_fft = 1;
        public const uint PIXEL_TRANSFORM_OPERATOR_SGI = 0x81C4;
        public const uint CONVOLUTION_SGI = 0x81C5;
        public const uint FFT_1D_SGI = 0x81C6;
        public const uint PIXEL_TRANSFORM_SGI = 0x81C7;
        public const uint MAX_FFT_WIDTH_SGI = 0x81C8;
        public const uint SGI_texture_color_table = 1;
        public const uint TEXTURE_COLOR_TABLE_SGI = 0x80BC;
        public const uint PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD;
        public const uint SUNX_constant_data = 1;
        public const uint UNPACK_CONSTANT_DATA_SUNX = 0x81D5;
        public const uint TEXTURE_CONSTANT_DATA_SUNX = 0x81D6;
        public const uint SUN_convolution_border_modes = 1;
        public const uint WRAP_BORDER_SUN = 0x81D4;
        public const uint SUN_global_alpha = 1;
        public const uint GLOBAL_ALPHA_SUN = 0x81D9;
        public const uint GLOBAL_ALPHA_FACTOR_SUN = 0x81DA;
        public const uint SUN_mesh_array = 1;
        public const uint QUAD_MESH_SUN = 0x8614;
        public const uint TRIANGLE_MESH_SUN = 0x8615;
        public const uint SUN_read_video_pixels = 1;
        public const uint SUN_slice_accum = 1;
        public const uint SLICE_ACCUM_SUN = 0x85CC;
        public const uint SUN_triangle_list = 1;
        public const uint RESTART_SUN = 0x01;
        public const uint REPLACE_MIDDLE_SUN = 0x02;
        public const uint REPLACE_OLDEST_SUN = 0x03;
        public const uint TRIANGLE_LIST_SUN = 0x81D7;
        public const uint REPLACEMENT_CODE_SUN = 0x81D8;
        public const uint REPLACEMENT_CODE_ARRAY_SUN = 0x85C0;
        public const uint REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1;
        public const uint REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2;
        public const uint REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3;
        public const uint R1UI_V3F_SUN = 0x85C4;
        public const uint R1UI_C4UB_V3F_SUN = 0x85C5;
        public const uint R1UI_C3F_V3F_SUN = 0x85C6;
        public const uint R1UI_N3F_V3F_SUN = 0x85C7;
        public const uint R1UI_C4F_N3F_V3F_SUN = 0x85C8;
        public const uint R1UI_T2F_V3F_SUN = 0x85C9;
        public const uint R1UI_T2F_N3F_V3F_SUN = 0x85CA;
        public const uint R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB;
        public const uint SUN_vertex = 1;
        public const uint WIN_phong_shading = 1;
        public const uint PHONG_WIN = 0x80EA;
        public const uint PHONG_HINT_WIN = 0x80EB;
        public const uint WIN_scene_markerXXX = 1;
        public const uint WIN_specular_fog = 1;
        public const uint FOG_SPECULAR_TEXTURE_WIN = 0x80EC;
        public const uint WIN_swap_hint = 1;

        #endregion // Constants
        #region GL11

        [DllImport("opengl32.dll", EntryPoint = "glAccum", CallingConvention = CallingConvention.StdCall)]
        public static extern void Accum(uint op, float value);
        [DllImport("opengl32.dll", EntryPoint = "glAlphaFunc", CallingConvention = CallingConvention.StdCall)]
        public static extern void AlphaFunc(uint func, float @ref);
        [DllImport("opengl32.dll", EntryPoint = "glAreTexturesResident", CallingConvention = CallingConvention.StdCall)]
        public static extern byte AreTexturesResident(int n, uint[] textures, byte[] residences);
        [DllImport("opengl32.dll", EntryPoint = "glArrayElement", CallingConvention = CallingConvention.StdCall)]
        public static extern void ArrayElement(int i);
        [DllImport("opengl32.dll", EntryPoint = "glBegin", CallingConvention = CallingConvention.StdCall)]
        public static extern void Begin(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glBindTexture", CallingConvention = CallingConvention.StdCall)]
        public static extern void BindTexture(uint target, uint texture);
        [DllImport("opengl32.dll", EntryPoint = "glBitmap", CallingConvention = CallingConvention.StdCall)]
        public static extern void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc", CallingConvention = CallingConvention.StdCall)]
        public static extern void BlendFunc(uint sfactor, uint dfactor);
        [DllImport("opengl32.dll", EntryPoint = "glCallList", CallingConvention = CallingConvention.StdCall)]
        public static extern void CallList(uint list);
        [DllImport("opengl32.dll", EntryPoint = "glCallLists", CallingConvention = CallingConvention.StdCall)]
        public static extern void CallLists(int n, uint type, IntPtr lists);
        [DllImport("opengl32.dll", EntryPoint = "glClear", CallingConvention = CallingConvention.StdCall)]
        public static extern void Clear(uint mask);
        [DllImport("opengl32.dll", EntryPoint = "glClearAccum", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearAccum(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll", EntryPoint = "glClearColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearColor(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll", EntryPoint = "glClearDepth", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearDepth(double depth);
        [DllImport("opengl32.dll", EntryPoint = "glClearIndex", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearIndex(float c);
        [DllImport("opengl32.dll", EntryPoint = "glClearStencil", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearStencil(int s);
        [DllImport("opengl32.dll", EntryPoint = "glClipPlane", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClipPlane(uint plane, double[] equation);
        [DllImport("opengl32.dll", EntryPoint = "glColor3b", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3b(sbyte red, sbyte green, sbyte blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3bv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3bv(sbyte[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3d(double red, double green, double blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3f(float red, float green, float blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3i", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3i(int red, int green, int blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3s", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3s(short red, short green, short blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3ub", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3ub(byte red, byte green, byte blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3ubv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3ubv(byte[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3ui", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3ui(uint red, uint green, uint blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3uiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3uiv(uint[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor3us", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3us(ushort red, ushort green, ushort blue);
        [DllImport("opengl32.dll", EntryPoint = "glColor3usv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color3usv(ushort[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4b", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4bv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4bv(sbyte[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4d(double red, double green, double blue, double alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4f(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4i", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4i(int red, int green, int blue, int alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4s", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4s(short red, short green, short blue, short alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4ub", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4ubv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4ubv(byte[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4ui", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4ui(uint red, uint green, uint blue, uint alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4uiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4uiv(uint[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColor4us", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4us(ushort red, ushort green, ushort blue, ushort alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColor4usv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Color4usv(ushort[] v);
        [DllImport("opengl32.dll", EntryPoint = "glColorMask", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorMask(byte red, byte green, byte blue, byte alpha);
        [DllImport("opengl32.dll", EntryPoint = "glColorMaterial", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorMaterial(uint face, uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glColorPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorPointer(int size, uint type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glCopyPixels", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyPixels(int x, int y, int width, int height, uint type);
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage1D", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border);
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage2D", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage1D", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage2D", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport("opengl32.dll", EntryPoint = "glCullFace", CallingConvention = CallingConvention.StdCall)]
        public static extern void CullFace(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glDeleteLists", CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteLists(uint list, int range);
        [DllImport("opengl32.dll", EntryPoint = "glDeleteTextures", CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteTextures(int n, uint[] textures);
        public static void DeleteTexture(uint texture)
        {
            DeleteTextures(1, new uint[] { texture });
        }
        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc", CallingConvention = CallingConvention.StdCall)]
        public static extern void DepthFunc(uint func);
        [DllImport("opengl32.dll", EntryPoint = "glDepthMask", CallingConvention = CallingConvention.StdCall)]
        public static extern void DepthMask(byte flag);
        [DllImport("opengl32.dll", EntryPoint = "glDepthRange", CallingConvention = CallingConvention.StdCall)]
        public static extern void DepthRange(double zNear, double zFar);
        [DllImport("opengl32.dll", EntryPoint = "glDisable", CallingConvention = CallingConvention.StdCall)]
        public static extern void Disable(uint cap);
        [DllImport("opengl32.dll", EntryPoint = "glDisableClientState", CallingConvention = CallingConvention.StdCall)]
        public static extern void DisableClientState(uint array);
        [DllImport("opengl32.dll", EntryPoint = "glDrawArrays", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawArrays(uint mode, int first, int count);
        [DllImport("opengl32.dll", EntryPoint = "glDrawBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawBuffer(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glDrawElements", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawElements(uint mode, int count, uint type, IntPtr indices);
        [DllImport("opengl32.dll", EntryPoint = "glDrawPixels", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawPixels(int width, int height, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlag", CallingConvention = CallingConvention.StdCall)]
        public static extern void EdgeFlag(byte flag);
        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern void EdgeFlagPointer(int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagv", CallingConvention = CallingConvention.StdCall)]
        public static extern void EdgeFlagv(byte[] flag);
        [DllImport("opengl32.dll", EntryPoint = "glEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern void Enable(uint cap);
        [DllImport("opengl32.dll", EntryPoint = "glEnableClientState", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableClientState(uint array);
        [DllImport("opengl32.dll", EntryPoint = "glEnd", CallingConvention = CallingConvention.StdCall)]
        public static extern void End();
        [DllImport("opengl32.dll", EntryPoint = "glEndList", CallingConvention = CallingConvention.StdCall)]
        public static extern void EndList();
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1d", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord1d(double u);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord1dv(double[] u);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1f", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord1f(float u);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord1fv(float[] u);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2d", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord2d(double u, double v);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord2dv(double[] u);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2f", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord2f(float u, float v);
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalCoord2fv(float[] u);
        [DllImport("opengl32.dll", EntryPoint = "glEvalMesh1", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalMesh1(uint mode, int i1, int i2);
        [DllImport("opengl32.dll", EntryPoint = "glEvalMesh2", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalMesh2(uint mode, int i1, int i2, int j1, int j2);
        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint1", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalPoint1(int i);
        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint2", CallingConvention = CallingConvention.StdCall)]
        public static extern void EvalPoint2(int i, int j);
        [DllImport("opengl32.dll", EntryPoint = "glFeedbackBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern void FeedbackBuffer(int size, uint type, float[] buffer);
        [DllImport("opengl32.dll", EntryPoint = "glFinish", CallingConvention = CallingConvention.StdCall)]
        public static extern void Finish();
        [DllImport("opengl32.dll", EntryPoint = "glFlush", CallingConvention = CallingConvention.StdCall)]
        public static extern void Flush();
        [DllImport("opengl32.dll", EntryPoint = "glFogf", CallingConvention = CallingConvention.StdCall)]
        public static extern void Fogf(uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glFogfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Fogfv(uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glFogi", CallingConvention = CallingConvention.StdCall)]
        public static extern void Fogi(uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glFogiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Fogiv(uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glFrontFace", CallingConvention = CallingConvention.StdCall)]
        public static extern void FrontFace(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glFrustum", CallingConvention = CallingConvention.StdCall)]
        public static extern void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport("opengl32.dll", EntryPoint = "glGenLists", CallingConvention = CallingConvention.StdCall)]
        public static extern uint GenLists(int range);
        [DllImport("opengl32.dll", EntryPoint = "glGenTextures", CallingConvention = CallingConvention.StdCall)]
        public static extern void GenTextures(int n, uint[] textures);
        public static uint GenTexture()
        {
            uint[] tex = { 0 };
            GenTextures(1, tex);
            return tex[0];
        }
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleanv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetBooleanv(uint pname, byte[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetClipPlane", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetClipPlane(uint plane, double[] equation);
        [DllImport("opengl32.dll", EntryPoint = "glGetDoublev", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetDoublev(uint pname, double[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetError", CallingConvention = CallingConvention.StdCall)]
        public static extern uint GetError();
        [DllImport("opengl32.dll", EntryPoint = "glGetFloatv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetFloatv(uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetIntegerv(uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetLightfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLightfv(uint light, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetLightiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLightiv(uint light, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetMapdv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMapdv(uint target, uint query, double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glGetMapfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMapfv(uint target, uint query, float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glGetMapiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMapiv(uint target, uint query, int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glGetMaterialfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMaterialfv(uint face, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetMaterialiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMaterialiv(uint face, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPixelMapfv(uint map, float[] values);
        [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapuiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPixelMapuiv(uint map, uint[] values);
        [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapusv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPixelMapusv(uint map, ushort[] values);
        [DllImport("opengl32.dll", EntryPoint = "glGetPointerv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPointerv(uint pname, IntPtr[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetPolygonStipple", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPolygonStipple(byte[] mask);
        [DllImport("opengl32.dll", EntryPoint = "glGetString", CallingConvention = CallingConvention.StdCall)]
        public static extern byte[] GetString(uint name);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexEnvfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexEnvfv(uint target, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexEnviv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexEnviv(uint target, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexGendv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexGendv(uint coord, uint pname, double[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexGenfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexGenfv(uint coord, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexGeniv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexGeniv(uint coord, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexImage", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameterfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameteriv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexParameterfv(uint target, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameteriv", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTexParameteriv(uint target, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glHint", CallingConvention = CallingConvention.StdCall)]
        public static extern void Hint(uint target, uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glIndexMask", CallingConvention = CallingConvention.StdCall)]
        public static extern void IndexMask(uint mask);
        [DllImport("opengl32.dll", EntryPoint = "glIndexPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern void IndexPointer(uint type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glIndexd", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexd(double c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexdv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexdv(double[] c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexf", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexf(float c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexfv(float[] c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexi", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexi(int c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexiv(int[] c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexs", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexs(short c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexsv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexsv(short[] c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexub", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexub(byte c);
        [DllImport("opengl32.dll", EntryPoint = "glIndexubv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Indexubv(byte[] c);
        [DllImport("opengl32.dll", EntryPoint = "glInitNames", CallingConvention = CallingConvention.StdCall)]
        public static extern void InitNames();
        [DllImport("opengl32.dll", EntryPoint = "interleavedArrays", CallingConvention = CallingConvention.StdCall)]
        public static extern void InterleavedArrays(uint format, int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabled", CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsEnabled(uint cap);
        [DllImport("opengl32.dll", EntryPoint = "glIsList", CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsList(uint list);
        [DllImport("opengl32.dll", EntryPoint = "glIsTexture", CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsTexture(uint texture);
        [DllImport("opengl32.dll", EntryPoint = "glLightModelf", CallingConvention = CallingConvention.StdCall)]
        public static extern void LightModelf(uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glLightModelfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void LightModelfv(uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glLightModeli", CallingConvention = CallingConvention.StdCall)]
        public static extern void LightModeli(uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glLightModeliv", CallingConvention = CallingConvention.StdCall)]
        public static extern void LightModeliv(uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glLightf", CallingConvention = CallingConvention.StdCall)]
        public static extern void Lightf(uint light, uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glLightfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Lightfv(uint light, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glLighti", CallingConvention = CallingConvention.StdCall)]
        public static extern void Lighti(uint light, uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glLightiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Lightiv(uint light, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glLineStipple", CallingConvention = CallingConvention.StdCall)]
        public static extern void LineStipple(int factor, ushort pattern);
        [DllImport("opengl32.dll", EntryPoint = "glLineWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern void LineWidth(float width);
        [DllImport("opengl32.dll", EntryPoint = "glListBase", CallingConvention = CallingConvention.StdCall)]
        public static extern void ListBase(uint @base);
        [DllImport("opengl32.dll", EntryPoint = "glLoadIdentity", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadIdentity();
        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixd", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadMatrixd(double[] m);
        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixf", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadMatrixf(float[] m);
        [DllImport("opengl32.dll", EntryPoint = "glLoadName", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadName(uint name);
        [DllImport("opengl32.dll", EntryPoint = "glLogicOp", CallingConvention = CallingConvention.StdCall)]
        public static extern void LogicOp(uint opcode);
        [DllImport("opengl32.dll", EntryPoint = "glMap1d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Map1d(uint target, double u1, double u2, int stride, int order, double[] points);
        [DllImport("opengl32.dll", EntryPoint = "glMap1f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Map1f(uint target, float u1, float u2, int stride, int order, float[] points);
        [DllImport("opengl32.dll", EntryPoint = "glMap2d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Map2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
        [DllImport("opengl32.dll", EntryPoint = "glMap2f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Map2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1d", CallingConvention = CallingConvention.StdCall)]
        public static extern void MapGrid1d(int un, double u1, double u2);
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1f", CallingConvention = CallingConvention.StdCall)]
        public static extern void MapGrid1f(int un, float u1, float u2);
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2d", CallingConvention = CallingConvention.StdCall)]
        public static extern void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2f", CallingConvention = CallingConvention.StdCall)]
        public static extern void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
        [DllImport("opengl32.dll", EntryPoint = "glMaterialf", CallingConvention = CallingConvention.StdCall)]
        public static extern void Materialf(uint face, uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glMaterialfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Materialfv(uint face, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glMateriali", CallingConvention = CallingConvention.StdCall)]
        public static extern void Materiali(uint face, uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glMaterialiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Materialiv(uint face, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glMatrixMode", CallingConvention = CallingConvention.StdCall)]
        public static extern void MatrixMode(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixd", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultMatrixd(double[] m);
        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixf", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultMatrixf(float[] m);
        [DllImport("opengl32.dll", EntryPoint = "glNewList", CallingConvention = CallingConvention.StdCall)]
        public static extern void NewList(uint list, uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3b", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3b(sbyte nx, sbyte ny, sbyte nz);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3bv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3bv(sbyte[] v);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3d(double nx, double ny, double nz);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3f(float nx, float ny, float nz);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3i", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3i(int nx, int ny, int nz);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3s", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3s(short nx, short ny, short nz);
        [DllImport("opengl32.dll", EntryPoint = "glNormal3sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Normal3sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glNormalPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern void NormalPointer(uint type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glOrtho", CallingConvention = CallingConvention.StdCall)]
        public static extern void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport("opengl32.dll", EntryPoint = "glPassThrough", CallingConvention = CallingConvention.StdCall)]
        public static extern void PassThrough(float token);
        [DllImport("opengl32.dll", EntryPoint = "glPixelMapfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelMapfv(uint map, int mapsize, float[] values);
        [DllImport("opengl32.dll", EntryPoint = "glPixelMapuiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelMapuiv(uint map, int mapsize, uint[] values);
        [DllImport("opengl32.dll", EntryPoint = "glPixelMapusv", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelMapusv(uint map, int mapsize, ushort[] values);
        [DllImport("opengl32.dll", EntryPoint = "glPixelStoref", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelStoref(uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelStorei(uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferf", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelTransferf(uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferi", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelTransferi(uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glPixelZoom", CallingConvention = CallingConvention.StdCall)]
        public static extern void PixelZoom(float xfactor, float yfactor);
        [DllImport("opengl32.dll", EntryPoint = "glPointSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void PointSize(float size);
        [DllImport("opengl32.dll", EntryPoint = "glPolygonMode", CallingConvention = CallingConvention.StdCall)]
        public static extern void PolygonMode(uint face, uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffset", CallingConvention = CallingConvention.StdCall)]
        public static extern void PolygonOffset(float factor, float units);
        [DllImport("opengl32.dll", EntryPoint = "glPolygonStipple", CallingConvention = CallingConvention.StdCall)]
        public static extern void PolygonStipple(byte[] mask);
        [DllImport("opengl32.dll", EntryPoint = "glPopAttrib", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopAttrib();
        [DllImport("opengl32.dll", EntryPoint = "glPopClientAttrib", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopClientAttrib();
        [DllImport("opengl32.dll", EntryPoint = "glPopMatrix", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopMatrix();
        [DllImport("opengl32.dll", EntryPoint = "glPopName", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopName();
        [DllImport("opengl32.dll", EntryPoint = "glPrioritizeTextures", CallingConvention = CallingConvention.StdCall)]
        public static extern void PrioritizeTextures(int n, uint[] textures, float[] priorities);
        [DllImport("opengl32.dll", EntryPoint = "glPushAttrib", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushAttrib(uint mask);
        [DllImport("opengl32.dll", EntryPoint = "glPushClientAttrib", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushClientAttrib(uint mask);
        [DllImport("opengl32.dll", EntryPoint = "glPushMatrix", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushMatrix();
        [DllImport("opengl32.dll", EntryPoint = "glPushName", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushName(uint name);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2d", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2d(double x, double y);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2f", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2f(float x, float y);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2i", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2i(int x, int y);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2s", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2s(short x, short y);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos2sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3d", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3d(double x, double y, double z);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3f", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3f(float x, float y, float z);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3i", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3i(int x, int y, int z);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3s", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3s(short x, short y, short z);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos3sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4d", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4d(double x, double y, double z, double w);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4f", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4f(float x, float y, float z, float w);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4i", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4i(int x, int y, int z, int w);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4s", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4s(short x, short y, short z, short w);
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void RasterPos4sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glReadBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReadBuffer(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glReadPixels", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glRectd", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rectd(double x1, double y1, double x2, double y2);
        [DllImport("opengl32.dll", EntryPoint = "glRectdv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rectdv(double[] v1, double[] v2);
        [DllImport("opengl32.dll", EntryPoint = "glRectf", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rectf(float x1, float y1, float x2, float y2);
        [DllImport("opengl32.dll", EntryPoint = "glRectfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rectfv(float[] v1, float[] v2);
        [DllImport("opengl32.dll", EntryPoint = "glRecti", CallingConvention = CallingConvention.StdCall)]
        public static extern void Recti(int x1, int y1, int x2, int y2);
        [DllImport("opengl32.dll", EntryPoint = "glRectiv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rectiv(int[] v1, int[] v2);
        [DllImport("opengl32.dll", EntryPoint = "glRects", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rects(short x1, short y1, short x2, short y2);
        [DllImport("opengl32.dll", EntryPoint = "glRectsv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rectsv(short[] v1, short[] v2);
        [DllImport("opengl32.dll", EntryPoint = "glRenderMode", CallingConvention = CallingConvention.StdCall)]
        public static extern int RenderMode(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glRotated", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rotated(double angle, double x, double y, double z);
        [DllImport("opengl32.dll", EntryPoint = "glRotatef", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rotatef(float angle, float x, float y, float z);
        [DllImport("opengl32.dll", EntryPoint = "glScaled", CallingConvention = CallingConvention.StdCall)]
        public static extern void Scaled(double x, double y, double z);
        [DllImport("opengl32.dll", EntryPoint = "glScalef", CallingConvention = CallingConvention.StdCall)]
        public static extern void Scalef(float x, float y, float z);
        [DllImport("opengl32.dll", EntryPoint = "glScissor", CallingConvention = CallingConvention.StdCall)]
        public static extern void Scissor(int x, int y, int width, int height);
        [DllImport("opengl32.dll", EntryPoint = "glSelectBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern void SelectBuffer(int size, IntPtr buffer);
        [DllImport("opengl32.dll", EntryPoint = "glShadeModel", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShadeModel(uint mode);
        [DllImport("opengl32.dll", EntryPoint = "glStencilFunc", CallingConvention = CallingConvention.StdCall)]
        public static extern void StencilFunc(uint func, int @ref, uint mask);
        [DllImport("opengl32.dll", EntryPoint = "glStencilMask", CallingConvention = CallingConvention.StdCall)]
        public static extern void StencilMask(uint mask);
        [DllImport("opengl32.dll", EntryPoint = "glStencilOp", CallingConvention = CallingConvention.StdCall)]
        public static extern void StencilOp(uint fail, uint zfail, uint zpass);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1d", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1d(double s);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1f", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1f(float s);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1i", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1i(int s);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1s", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1s(short s);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord1sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2d", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2d(double s, double t);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2f", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2f(float s, float t);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2i", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2i(int s, int t);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2s", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2s(short s, short t);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord2sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3d", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3d(double s, double t, double r);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3f", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3f(float s, float t, float r);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3i", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3i(int s, int t, int r);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3s", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3s(short s, short t, short r);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord3sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4d", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4d(double s, double t, double r, double q);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4f", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4f(float s, float t, float r, float q);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4i", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4i(int s, int t, int r, int q);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4s", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4s(short s, short t, short r, short q);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoord4sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoordPointer(int size, uint type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvf", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexEnvf(uint target, uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexEnvfv(uint target, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvi", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexEnvi(uint target, uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glTexEnviv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexEnviv(uint target, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexGend", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexGend(uint coord, uint pname, double param);
        [DllImport("opengl32.dll", EntryPoint = "glTexGendv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexGendv(uint coord, uint pname, double[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexGenf", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexGenf(uint coord, uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glTexGenfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexGenfv(uint coord, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexGeni", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexGeni(uint coord, uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glTexGeniv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexGeniv(uint coord, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexImage1D", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glTexImage2D", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterf", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexParameterf(uint target, uint pname, float param);
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterfv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexParameterfv(uint target, uint pname, float[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteri", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexParameteri(uint target, uint pname, int param);
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteriv", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexParameteriv(uint target, uint pname, int[] @params);
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage1D", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage2D", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
        [DllImport("opengl32.dll", EntryPoint = "glTranslated", CallingConvention = CallingConvention.StdCall)]
        public static extern void Translated(double x, double y, double z);
        [DllImport("opengl32.dll", EntryPoint = "glTranslatef", CallingConvention = CallingConvention.StdCall)]
        public static extern void Translatef(float x, float y, float z);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2d(double x, double y);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2f(float x, float y);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2i", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2i(int x, int y);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2s", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2s(short x, short y);
        [DllImport("opengl32.dll", EntryPoint = "glVertex2sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex2sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3d(double x, double y, double z);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3f(float x, float y, float z);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3i", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3i(int x, int y, int z);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3s", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3s(short x, short y, short z);
        [DllImport("opengl32.dll", EntryPoint = "glVertex3sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex3sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4d", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4d(double x, double y, double z, double w);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4dv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4dv(double[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4f", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4f(float x, float y, float z, float w);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4fv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4fv(float[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4i", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4i(int x, int y, int z, int w);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4iv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4iv(int[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4s", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4s(short x, short y, short z, short w);
        [DllImport("opengl32.dll", EntryPoint = "glVertex4sv", CallingConvention = CallingConvention.StdCall)]
        public static extern void Vertex4sv(short[] v);
        [DllImport("opengl32.dll", EntryPoint = "glVertexPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern void VertexPointer(int size, uint type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll", EntryPoint = "glViewport", CallingConvention = CallingConvention.StdCall)]
        public static extern void Viewport(int x, int y, int width, int height);

        #endregion // GL11
        #region GL12

        private delegate void copyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        private delegate void drawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices);
        private delegate void texImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
        private delegate void texSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
        public static void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            getDelegate<copyTexSubImage3D>("glCopyTexSubImage3D")(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        public static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices)
        {
            getDelegate<drawRangeElements>("glDrawRangeElements")(mode, start, end, count, type, indices);
        }
        public static void TexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels)
        {
            getDelegate<texImage3D>("glTexImage3D")(target, level, internalFormat, width, height, depth, border, format, type, pixels);
        }
        public static void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
        {
            getDelegate<texSubImage3D>("glTexSubImage3D")(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        #endregion // GL12
        #region GL13

        private delegate void activeTexture(uint texture);
        private delegate void clientActiveTexture(uint texture);
        private delegate void compressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
        private delegate void compressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
        private delegate void compressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        private delegate void compressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
        private delegate void compressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
        private delegate void compressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
        private delegate void getCompressedTexImage(uint target, int lod, IntPtr img);
        private delegate void loadTransposeMatrixd(double[] m);
        private delegate void loadTransposeMatrixf(float[] m);
        private delegate void multTransposeMatrixd(double[] m);
        private delegate void multTransposeMatrixf(float[] m);
        private delegate void multiTexCoord1d(uint target, double s);
        private delegate void multiTexCoord1dv(uint target, double[] v);
        private delegate void multiTexCoord1f(uint target, float s);
        private delegate void multiTexCoord1fv(uint target, float[] v);
        private delegate void multiTexCoord1i(uint target, int s);
        private delegate void multiTexCoord1iv(uint target, int[] v);
        private delegate void multiTexCoord1s(uint target, short s);
        private delegate void multiTexCoord1sv(uint target, short[] v);
        private delegate void multiTexCoord2d(uint target, double s, double t);
        private delegate void multiTexCoord2dv(uint target, double[] v);
        private delegate void multiTexCoord2f(uint target, float s, float t);
        private delegate void multiTexCoord2fv(uint target, float[] v);
        private delegate void multiTexCoord2i(uint target, int s, int t);
        private delegate void multiTexCoord2iv(uint target, int[] v);
        private delegate void multiTexCoord2s(uint target, short s, short t);
        private delegate void multiTexCoord2sv(uint target, short[] v);
        private delegate void multiTexCoord3d(uint target, double s, double t, double r);
        private delegate void multiTexCoord3dv(uint target, double[] v);
        private delegate void multiTexCoord3f(uint target, float s, float t, float r);
        private delegate void multiTexCoord3fv(uint target, float[] v);
        private delegate void multiTexCoord3i(uint target, int s, int t, int r);
        private delegate void multiTexCoord3iv(uint target, int[] v);
        private delegate void multiTexCoord3s(uint target, short s, short t, short r);
        private delegate void multiTexCoord3sv(uint target, short[] v);
        private delegate void multiTexCoord4d(uint target, double s, double t, double r, double q);
        private delegate void multiTexCoord4dv(uint target, double[] v);
        private delegate void multiTexCoord4f(uint target, float s, float t, float r, float q);
        private delegate void multiTexCoord4fv(uint target, float[]v);
        private delegate void multiTexCoord4i(uint target, int s, int t, int r, int q);
        private delegate void multiTexCoord4iv(uint target, int[] v);
        private delegate void multiTexCoord4s(uint target, short s, short t, short r, short q);
        private delegate void multiTexCoord4sv(uint target, short[] v);
        private delegate void sampleCoverage(float value, byte invert);
        public static void ActiveTexture(uint texture)
        {
            getDelegate<activeTexture>("glActiveTexture")(texture);
        }
        public static void ClientActiveTexture(uint texture)
        {
            getDelegate<clientActiveTexture>("glClientActiveTexture")(texture);
        }
        public static void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data)
        {
            getDelegate<compressedTexImage1D>("glCompressedTexImage1D")(target, level, internalformat, width, border, imageSize, data);
        }
        public static void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            getDelegate<compressedTexImage2D>("glCompressedTexImage2D")(target, level, internalformat, width, height, border, imageSize, data);
        }
        public static void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            getDelegate<compressedTexImage3D>("glCompressedTexImage3D")(target, level, internalformat, width, height, depth, border, imageSize, data);
        }
        public static void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
        {
            getDelegate<compressedTexSubImage1D>("glCompressedTexSubImage1D")(target, level, xoffset, width, format, imageSize, data);
        }
        public static void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
        {
            getDelegate<compressedTexSubImage2D>("glCompressedTexSubImage2D")(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        public static void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
        {
            getDelegate<compressedTexSubImage3D>("glCompressedTexSubImage3D")(target, level, xoffset, yoffset, zoffset, width, height, depth,  format, imageSize, data);
        }
        public static void GetCompressedTexImage(uint target, int lod, IntPtr img)
        {
            getDelegate<getCompressedTexImage>("glGetCompressedTexImage")(target, lod, img);
        }
        public static void LoadTransposeMatrixd(double[] m)
        {
            getDelegate<loadTransposeMatrixd>("glLoadTransposeMatrixd")(m);
        }
        public static void LoadTransposeMatrixf(float[] m)
        {
            getDelegate<loadTransposeMatrixf>("glLoadTransposeMatrixf")(m);
        }
        public static void MultTransposeMatrixd(double[] m)
        {
            getDelegate<multTransposeMatrixd>("glMultTransposeMatrixd")(m);
        }
        public static void MultTransposeMatrixf(float[] m)
        {
            getDelegate<multTransposeMatrixf>("glMultTransposeMatrixf")(m);
        }
        public static void MultiTexCoord1d(uint target, double s)
        {
            getDelegate<multiTexCoord1d>("glMultiTexCoord1d")(target, s);
        }
        public static void MultiTexCoord1dv(uint target, double[] v)
        {
            getDelegate<multiTexCoord1dv>("glMultiTexCoord1dv")(target, v);
        }
        public static void MultiTexCoord1f(uint target, float s)
        {
            getDelegate<multiTexCoord1f>("glMultiTexCoord1f")(target, s);
        }
        public static void MultiTexCoord1fv(uint target, float[] v)
        {
            getDelegate<multiTexCoord1fv>("glMultiTexCoord1fv")(target, v);
        }
        public static void MultiTexCoord1i(uint target, int s)
        {
            getDelegate<multiTexCoord1i>("glMultiTexCoord1i")(target, s);
        }
        public static void MultiTexCoord1iv(uint target, int[] v)
        {
            getDelegate<multiTexCoord1iv>("glMultiTexCoord1iv")(target, v);
        }
        public static void MultiTexCoord1s(uint target, short s)
        {
            getDelegate<multiTexCoord1s>("glMultiTexCoord1s")(target, s);
        }
        public static void MultiTexCoord1sv(uint target, short[] v)
        {
            getDelegate<multiTexCoord1sv>("glMultiTexCoord1sv")(target, v);
        }
        public static void MultiTexCoord2d(uint target, double s, double t)
        {
            getDelegate<multiTexCoord2d>("glMultiTexCoord2d")(target, s, t);
        }
        public static void MultiTexCoord2dv(uint target, double[] v)
        {
            getDelegate<multiTexCoord2dv>("glMultiTexCoord2dv")(target, v);
        }
        public static void MultiTexCoord2f(uint target, float s, float t)
        {
            getDelegate<multiTexCoord2f>("glMultiTexCoord2f")(target, s, t);
        }
        public static void MultiTexCoord2fv(uint target, float[] v)
        {
            getDelegate<multiTexCoord2fv>("glMultiTexCoord2fv")(target, v);
        }
        public static void MultiTexCoord2i(uint target, int s, int t)
        {
            getDelegate<multiTexCoord2i>("glMultiTexCoord2i")(target, s, t);
        }
        public static void MultiTexCoord2iv(uint target, int[] v)
        {
            getDelegate<multiTexCoord2iv>("glMultiTexCoord2iv")(target, v);
        }
        public static void MultiTexCoord2s(uint target, short s, short t)
        {
            getDelegate<multiTexCoord2s>("glMultiTexCoord2s")(target, s, t);
        }
        public static void MultiTexCoord2sv(uint target, short[] v)
        {
            getDelegate<multiTexCoord2sv>("glMultiTexCoord2sv")(target, v);
        }
        public static void MultiTexCoord3d(uint target, double s, double t, double r)
        {
            getDelegate<multiTexCoord3d>("glMultiTexCoord3d")(target, s, t, r);
        }
        public static void MultiTexCoord3dv(uint target, double[] v)
        {
            getDelegate<multiTexCoord3dv>("glMultiTexCoord3dv")(target, v);
        }
        public static void MultiTexCoord3f(uint target, float s, float t, float r)
        {
            getDelegate<multiTexCoord3f>("glMultiTexCoord3f")(target, s, t, r);
        }
        public static void MultiTexCoord3fv(uint target, float[] v)
        {
            getDelegate<multiTexCoord3fv>("glMultiTexCoord3fv")(target, v);
        }
        public static void MultiTexCoord3i(uint target, int s, int t, int r)
        {
            getDelegate<multiTexCoord3i>("glMultiTexCoord3i")(target, s, t, r);
        }
        public static void MultiTexCoord3iv(uint target, int[] v)
        {
            getDelegate<multiTexCoord3iv>("glMultiTexCoord3iv")(target, v);
        }
        public static void MultiTexCoord3s(uint target, short s, short t, short r)
        {
            getDelegate<multiTexCoord3s>("glMultiTexCoord3s")(target, s, t, r);
        }
        public static void MultiTexCoord3sv(uint target, short[] v)
        {
            getDelegate<multiTexCoord3sv>("glMultiTexCoord3sv")(target, v);
        }
        public static void MultiTexCoord4d(uint target, double s, double t, double r, double q)
        {
            getDelegate<multiTexCoord4d>("glMultiTexCoord4d")(target, s, t, r, q);
        }
        public static void MultiTexCoord4dv(uint target, double[] v)
        {
            getDelegate<multiTexCoord4dv>("glMultiTexCoord4dv")(target, v);
        }
        public static void MultiTexCoord4f(uint target, float s, float t, float r, float q)
        {
            getDelegate<multiTexCoord4f>("glMultiTexCoord4f")(target, s, t, r, q);
        }
        public static void MultiTexCoord4fv(uint target, float[] v)
        {
            getDelegate<multiTexCoord4fv>("glMultiTexCoord4fv")(target, v);
        }
        public static void MultiTexCoord4i(uint target, int s, int t, int r, int q)
        {
            getDelegate<multiTexCoord4i>("glMultiTexCoord4i")(target, s, t, r, q);
        }
        public static void MultiTexCoord4iv(uint target, int[] v)
        {
            getDelegate<multiTexCoord4iv>("glMultiTexCoord4iv")(target, v);
        }
        public static void MultiTexCoord4s(uint target, short s, short t, short r, short q)
        {
            getDelegate<multiTexCoord4s>("glMultiTexCoord4s")(target, s, t, r, q);
        }
        public static void MultiTexCoord4sv(uint target, short[] v)
        {
            getDelegate<multiTexCoord4sv>("glMultiTexCoord4sv")(target, v);
        }
        public static void SampleCoverage(float value, byte invert)
        {
            getDelegate<sampleCoverage>("glSampleCoverage")(value, invert);
        }
        public static void SampleCoverage(float value, bool invert)
        {
            SampleCoverage(value, invert ? TRUE : FALSE);
        }

        #endregion // GL13
        #region GL14

        private delegate void blendColor(float red, float green, float blue, float alpha);
        private delegate void blendEquation(uint mode);
        private delegate void blendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
        private delegate void fogCoordPointer(uint type, int stride, IntPtr pointer);
        private delegate void fogCoordd(double coord);
        private delegate void fogCoorddv(double[] coord);
        private delegate void fogCoordf(float coord);
        private delegate void fogCoordfv(float[] coord);
        private delegate void multiDrawArrays(uint mode, int[] first, int[] count, int drawcount);
        private delegate void multiDrawElements(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount);
        private delegate void pointParameterf(uint pname, float param);
        private delegate void pointParameterfv(uint pname, float[] @params);
        private delegate void pointParameteri(uint pname, int param);
        private delegate void pointParameteriv(uint pname, int[] @params);
        private delegate void secondaryColor3b(sbyte red, sbyte green, sbyte blue);
        private delegate void secondaryColor3bv(sbyte[] v);
        private delegate void secondaryColor3d(double red, double green, double blue);
        private delegate void secondaryColor3dv(double[] v);
        private delegate void secondaryColor3f(float red, float green, float blue);
        private delegate void secondaryColor3fv(float[] v);
        private delegate void secondaryColor3i(int red, int green, int blue);
        private delegate void secondaryColor3iv(int[] v);
        private delegate void secondaryColor3s(short red, short green, short blue);
        private delegate void secondaryColor3sv(short[] v);
        private delegate void secondaryColor3ub(byte red, byte green, byte blue);
        private delegate void secondaryColor3ubv(byte[] v);
        private delegate void secondaryColor3ui(uint red, uint green, uint blue);
        private delegate void secondaryColor3uiv(uint[] v);
        private delegate void secondaryColor3us(ushort red, ushort green, ushort blue);
        private delegate void secondaryColor3usv(ushort[] v);
        private delegate void secondaryColorPointer(int size, uint type, int stride, IntPtr pointer);
        private delegate void windowPos2d(double x, double y);
        private delegate void windowPos2dv(double[] p);
        private delegate void windowPos2f(float x, float y);
        private delegate void windowPos2fv(float[] p);
        private delegate void windowPos2i(int x, int y);
        private delegate void windowPos2iv(int[] p);
        private delegate void windowPos2s(short x, short y);
        private delegate void windowPos2sv(short[] p);
        private delegate void windowPos3d(double x, double y, double z);
        private delegate void windowPos3dv(double[] p);
        private delegate void windowPos3f(float x, float y, float z);
        private delegate void windowPos3fv(float[] p);
        private delegate void windowPos3i(int x, int y, int z);
        private delegate void windowPos3iv(int[] p);
        private delegate void windowPos3s(short x, short y, short z);
        private delegate void windowPos3sv(short[] p);
        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            getDelegate<blendColor>("glBlendColor")(red, green, blue, alpha);
        }
        public static void BlendEquation(uint mode)
        {
            getDelegate<blendEquation>("glBlendEquation")(mode);
        }
        public static void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
        {
            getDelegate<blendFuncSeparate>("glBlendFuncSeparate")(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        public static void FogCoordPointer(uint type, int stride, IntPtr pointer)
        {
            getDelegate<fogCoordPointer>("glFogCoordPointer")(type, stride, pointer);
        }
        public static void FogCoordd(double coord)
        {
            getDelegate<fogCoordd>("glFogCoordd")(coord);
        }
        public static void FogCoorddv(double[] coord)
        {
            getDelegate<fogCoorddv>("glFogCoorddv")(coord);
        }
        public static void FogCoordf(float coord)
        {
            getDelegate<fogCoordf>("glFogCoordf")(coord);
        }
        public static void FogCoordfv(float[] coord)
        {
            getDelegate<fogCoordfv>("glFogCoordfv")(coord);
        }
        public static void MultiDrawArrays(uint mode, int[] first, int[] count, int drawcount)
        {
            getDelegate<multiDrawArrays>("glMultiDrawArrays")(mode, first, count, drawcount);
        }
        public static void MultiDrawElements(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount)
        {
            getDelegate<multiDrawElements>("glMultiDrawElements")(mode, count, type, indices, drawcount);
        }
        public static void PointParameterf(uint pname, float param)
        {
            getDelegate<pointParameterf>("glPointParameterf")(pname, param);
        }
        public static void PointParameterfv(uint pname, float[] @params)
        {
            getDelegate<pointParameterfv>("glPointParameterfv")(pname, @params);
        }
        public static void PointParameteri(uint pname, int param)
        {
            getDelegate<pointParameteri>("glPointParameteri")(pname, param);
        }
        public static void PointParameteriv(uint pname, int[] @params)
        {
            getDelegate<pointParameteriv>("glPointParameteriv")(pname, @params);
        }
        public static void SecondaryColor3b(sbyte red, sbyte green, sbyte blue)
        {
            getDelegate<secondaryColor3b>("glSecondaryColor3b")(red, green, blue);
        }
        public static void SecondaryColor3bv(sbyte[] v)
        {
            getDelegate<secondaryColor3bv>("glSecondaryColor3bv")(v);
        }
        public static void SecondaryColor3d(double red, double green, double blue)
        {
            getDelegate<secondaryColor3d>("glSecondaryColor3d")(red, green, blue);
        }
        public static void SecondaryColor3dv(double[] v)
        {
            getDelegate<secondaryColor3dv>("glSecondaryColor3dv")(v);
        }
        public static void SecondaryColor3f(float red, float green, float blue)
        {
            getDelegate<secondaryColor3f>("glSecondaryColor3f")(red, green, blue);
        }
        public static void SecondaryColor3fv(float[] v)
        {
            getDelegate<secondaryColor3fv>("glSecondaryColor3fv")(v);
        }
        public static void SecondaryColor3i(int red, int green, int blue)
        {
            getDelegate<secondaryColor3i>("glSecondaryColor3i")(red, green, blue);
        }
        public static void SecondaryColor3iv(int[] v)
        {
            getDelegate<secondaryColor3iv>("glSecondaryColor3iv")(v);
        }
        public static void SecondaryColor3s(short red, short green, short blue)
        {
            getDelegate<secondaryColor3s>("glSecondaryColor3s")(red, green, blue);
        }
        public static void SecondaryColor3sv(short[] v)
        {
            getDelegate<secondaryColor3sv>("glSecondaryColor3sv")(v);
        }
        public static void SecondaryColor3ub(byte red, byte green, byte blue)
        {
            getDelegate<secondaryColor3ub>("glSecondaryColor3ub")(red, green, blue);
        }
        public static void SecondaryColor3ubv(byte[] v)
        {
            getDelegate<secondaryColor3ubv>("glSecondaryColor3ubv")(v);
        }
        public static void SecondaryColor3ui(uint red, uint green, uint blue)
        {
            getDelegate<secondaryColor3ui>("glSecondaryColor3ui")(red, green, blue);
        }
        public static void SecondaryColor3uiv(uint[] v)
        {
            getDelegate<secondaryColor3uiv>("glSecondaryColor3uiv")(v);
        }
        public static void SecondaryColor3us(ushort red, ushort green, ushort blue)
        {
            getDelegate<secondaryColor3us>("glSecondaryColor3us")(red, green, blue);
        }
        public static void SecondaryColor3usv(ushort[] v)
        {
            getDelegate<secondaryColor3usv>("glSecondaryColor3usv")(v);
        }
        public static void SecondaryColorPointer(int size, uint type, int stride, IntPtr pointer)
        {
            getDelegate<secondaryColorPointer>("glSecondaryColorPointer")(size, type, stride, pointer);
        }
        public static void WindowPos2d(double x, double y)
        {
            getDelegate<windowPos2d>("glWindowPos2d")(x, y);
        }
        public static void WindowPos2dv(double[] p)
        {
            getDelegate<windowPos2dv>("glWindowPos2dv")(p);
        }
        public static void WindowPos2f(float x, float y)
        {
            getDelegate<windowPos2f>("glWindowPos2f")(x, y);
        }
        public static void WindowPos2fv(float[] p)
        {
            getDelegate<windowPos2fv>("glWindowPos2fv")(p);
        }
        public static void WindowPos2i(int x, int y)
        {
            getDelegate<windowPos2i>("glWindowPos2i")(x, y);
        }
        public static void WindowPos2iv(int[] p)
        {
            getDelegate<windowPos2iv>("glWindowPos2iv")(p);
        }
        public static void WindowPos2s(short x, short y)
        {
            getDelegate<windowPos2s>("glWindowPos2s")(x, y);
        }
        public static void WindowPos2sv(short[] p)
        {
            getDelegate<windowPos2sv>("glWindowPos2sv")(p);
        }
        public static void WindowPos3d(double x, double y, double z)
        {
            getDelegate<windowPos3d>("glWindowPos3d")(x, y, z);
        }
        public static void WindowPos3dv(double[] p)
        {
            getDelegate<windowPos3dv>("glWindowPos3dv")(p);
        }
        public static void WindowPos3f(float x, float y, float z)
        {
            getDelegate<windowPos3f>("glWindowPos3f")(x, y, z);
        }
        public static void WindowPos3fv(float[] p)
        {
            getDelegate<windowPos3fv>("glWindowPos3fv")(p);
        }
        public static void WindowPos3i(int x, int y, int z)
        {
            getDelegate<windowPos3i>("glWindowPos3i")(x, y, z);
        }
        public static void WindowPos3iv(int[] p)
        {
            getDelegate<windowPos3iv>("glWindowPos3iv")(p);
        }
        public static void WindowPos3s(short x, short y, short z)
        {
            getDelegate<windowPos3s>("glWindowPos3s")(x, y, z);
        }
        public static void WindowPos3sv(short[] p)
        {
            getDelegate<windowPos3sv>("glWindowPos3sv")(p);
        }

        #endregion // GL14
        #region GL15

        private delegate void beginQuery(uint target, uint id);
        private delegate void bindBuffer(uint target, uint buffer);
        private delegate void bufferData(uint target, long size, IntPtr data, uint usage);
        private delegate void bufferSubData(uint target, long offset, long size, IntPtr data);
        private delegate void deleteBuffers(int n, uint[] buffers);
        private delegate void deleteQueries(int n, uint[] ids);
        private delegate void endQuery(uint target);
        private delegate void genBuffers(int n, uint[] buffers);
        private delegate void genQueries(int n, uint[] ids);
        private delegate void getBufferParameteriv(uint target, uint pname, int[] @params);
        private delegate void getBufferPointerv(uint target, uint pname, IntPtr[] @params);
        private delegate void getBufferSubData(uint target, long offset, long size, IntPtr data);
        private delegate void getQueryObjectiv(uint id, uint pname, int[] @params);
        private delegate void getQueryObjectuiv(uint id, uint pname, uint[] @params);
        private delegate void getQueryiv(uint target, uint pname, int[] @params);
        private delegate byte isBuffer(uint buffer);
        private delegate byte isQuery(uint id);
        private delegate IntPtr mapBuffer(uint target, uint access);
        private delegate byte unmapBuffer(uint target);
        public static void BeginQuery(uint target, uint id)
        {
            getDelegate<beginQuery>("glBeginQuery")(target, id);
        }
        public static void BindBuffer(uint target, uint buffer)
        {
            getDelegate<bindBuffer>("glBindBuffer")(target, buffer);
        }
        public static void BufferData(uint target, long size, IntPtr data, uint usage)
        {
            getDelegate<bufferData>("glBufferData")(target, size, data, usage);
        }
        public static void BufferSubData(uint target, long offset, long size, IntPtr data)
        {
            getDelegate<bufferSubData>("glBufferSubData")(target, offset, size, data);
        }
        public static void DeleteBuffers(int n, uint[] buffers)
        {
            getDelegate<deleteBuffers>("glDeleteBuffers")(n, buffers);
        }
        public static void DeleteQueries(int n, uint[] ids)
        {
            getDelegate<deleteQueries>("glDeleteQueries")(n, ids);
        }
        public static void EndQuery(uint target)
        {
            getDelegate<endQuery>("glEndQuery")(target);
        }
        public static void GenBuffers(int n, uint[] buffers)
        {
            getDelegate<genBuffers>("glGenBuffers")(n, buffers);
        }
        public static void GenQueries(int n, uint[] ids)
        {
            getDelegate<genQueries>("glGenQueries")(n, ids);
        }
        public static void GetBufferParameteriv(uint target, uint pname, int[] @params)
        {
            getDelegate<getBufferParameteriv>("glGetBufferParameteriv")(target, pname, @params);
        }
        public static void GetBufferPointerv(uint target, uint pname, IntPtr[] @params)
        {
            getDelegate<getBufferPointerv>("glGetBufferPointerv")(target, pname, @params);
        }
        public static void GetBufferSubData(uint target, long offset, long size, IntPtr data)
        {
            getDelegate<getBufferSubData>("glGetBufferSubData")(target, offset, size, data);
        }
        public static void GetQueryObjectiv(uint id, uint pname, int[] @params)
        {
            getDelegate<getQueryObjectiv>("glGetQueryObjectiv")(id, pname, @params);
        }
        public static void GetQueryObjectuiv(uint id, uint pname, uint[] @params)
        {
            getDelegate<getQueryObjectuiv>("glGetQueryObjectuiv")(id, pname, @params);
        }
        public static void GetQueryiv(uint target, uint pname, int[] @params)
        {
            getDelegate<getQueryiv>("glGetQueryiv")(target, pname, @params);
        }
        public static bool IsBuffer(uint buffer)
        {
            return getDelegate<isBuffer>("glIsBuffer")(buffer) == TRUE;
        }
        public static bool IsQuery(uint id)
        {
            return getDelegate<isQuery>("glIsQuery")(id) == TRUE;
        }
        public static IntPtr MapBuffer(uint target, uint access)
        {
            return getDelegate<mapBuffer>("glMapBuffer")(target, access);
        }
        public static bool UnmapBuffer(uint target)
        {
            return getDelegate<unmapBuffer>("glUnmapBuffer")(target) == TRUE;
        }

        #endregion // GL15
    }
}
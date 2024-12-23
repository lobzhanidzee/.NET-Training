namespace StaticMethods;

public static class ReturningMethods
{
    public static int ReturnInt() => -1234567;

    public static uint ReturnUnsignedInt() => 1234567u;

    public static long ReturnLong() => -987654321L;

    public static ulong ReturnUnsignedLong() => 987654321uL;

    public static float ReturnFloat() => 1234.567f;

    public static double ReturnDouble() => -9876.54321;

    public static decimal ReturnDecimal() => -123456789.987654321m;

    public static string ReturnString() => "Hello, world!";

    public static char ReturnChar() => 'A';

    public static byte ReturnByte() => 0xAB;

    public static bool ReturnBool() => true;
}

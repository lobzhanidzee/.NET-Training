namespace StaticMethods;

public static class PassthroughMethods
{
    public static int ReturnInt(int intParameter) => intParameter;

    public static uint ReturnUnsignedInt(uint uintParameter) => uintParameter;

    public static long ReturnLong(long longParameter) => longParameter;

    public static ulong ReturnUnsignedLong(ulong ulongParameter) => ulongParameter;

    public static float ReturnFloat(float floatParameter) => floatParameter;

    public static double ReturnDouble(double doubleParameter) => doubleParameter;

    public static decimal ReturnDecimal(decimal decimalParameter) => decimalParameter;

    public static string ReturnString(string stringParameter) => stringParameter;

    public static char ReturnChar(char charParameter) => charParameter;

    public static byte ReturnByte(byte byteParameter) => byteParameter;

    public static bool ReturnBool(bool boolParameter) => boolParameter;
}

namespace WorkingWithArrays;

public static class CreatingArray
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
    public static int[] CreateEmptyArrayOfIntegers()
    {
        return new int[0];
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
    public static bool[] CreateEmptyArrayOfBooleans()
    {
        bool[] array = { };
        return array;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
    public static string[] CreateEmptyArrayOfStrings()
    {
        return new string[] { };
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
    public static char[] CreateEmptyArrayOfCharacters()
    {
        return new char[] { };
    }

    public static double[] CreateEmptyArrayOfDoubles()
    {
        return Array.Empty<double>();
    }

    public static float[] CreateEmptyArrayOfFloats()
    {
        return Array.Empty<float>();
    }

    public static decimal[] CreateEmptyArrayOfDecimals()
    {
        return Array.Empty<decimal>();
    }

    public static int[] CreateArrayOfTenIntegersWithDefaultValues()
    {
        return new int[10];
    }

    public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
    {
        return new bool[20];
    }

    public static string[] CreateArrayOfFiveEmptyStrings()
    {
        return new string[] { string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };

    }

    public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
    {
        return new char[15];
    }

    public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
    {
        return new double[18];
    }

    public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
    {
        return new float[100];
    }

    public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
    {
        return new decimal[1000];
    }

    public static int[] CreateIntArrayWithOneElement()
    {
        return new[] { 123456 };
    }

    public static int[] CreateIntArrayWithTwoElements()
    {
        return new[] { 1111111, 9999999 };
    }

    public static int[] CreateIntArrayWithTenElements()
    {
        return new[] { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
    }

    public static bool[] CreateBoolArrayWithOneElement()
    {
        return new[] { true };
    }

    public static bool[] CreateBoolArrayWithFiveElements()
    {
        return new[] { true, false, true, false, true };
    }

    public static bool[] CreateBoolArrayWithSevenElements()
    {
        return new[] { false, true, true, false, true, true, false };
    }

    public static string[] CreateStringArrayWithOneElement()
    {
        return new[] { "one" };
    }

    public static string[] CreateStringArrayWithThreeElements()
    {
        return new[] { "one", "two", "three" };
    }

    public static string[] CreateStringArrayWithSixElements()
    {
        return new[] { "one", "two", "three", "four", "five", "six" };
    }

    public static char[] CreateCharArrayWithOneElement()
    {
        return new[] { 'a' };
    }

    public static char[] CreateCharArrayWithThreeElements()
    {

        return new[] { 'a', 'b', 'c' };
    }

    public static char[] CreateCharArrayWithNineElements()
    {
        return new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
    }

    public static double[] CreateDoubleArrayWithOneElement()
    {
        return new[] { 1.12d };
    }

    public static double[] CreateDoubleWithFiveElements()
    {
        return new[] { 1.12d, 2.23d, 3.34d, 4.45d, 5.56d };
    }

    public static double[] CreateDoubleWithNineElements()
    {
        return new[] { 1.12d, 2.23d, 3.34d, 4.45d, 5.56d, 6.67d, 7.78d, 8.89d, 9.91d };
    }

    public static float[] CreateFloatArrayWithOneElement()
    {
        return new[] { 123_456_789.123456f };
    }

    public static float[] CreateFloatWithThreeElements()
    {
        return new[] { 1_000_000.123456f, 2_223_334_444.123456f, 9_999.999999f };
    }

    public static float[] CreateFloatWithFiveElements()
    {
        return new[] { 1.0123f, 20.012345f, 300.01234567f, 4_000.01234567f, 500_000.01234567f };
    }

    public static decimal[] CreateDecimalArrayWithOneElement()
    {
        return new[] { 10_000.123456m };
    }

    public static decimal[] CreateDecimalWithFiveElements()
    {
        return new[] { 1_000.1234m, 100_000.2345m, 100_000.3456m, 1_000_000.456789m, 10_000_000.5678901m };
    }

    public static decimal[] CreateDecimalWithNineElements()
    {
        return new[] { 10.122112m, 200.233223m, 3000.344334m, 40000.455445m, 500000.566556m, 6000000.677667m, 70000000.788778m, 800000000.899889m, 9000000000.911991m };
    }
}

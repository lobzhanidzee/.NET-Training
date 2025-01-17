namespace WorkingWithArrays;

public static class UsingIndexerForAccessingArrayElement
{
    public static int GetFirstArrayElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[0];
    }

    public static bool GetFirstArrayElement(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static string GetFirstArrayElement(string[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[0];
    }

    public static char GetFirstArrayElement(char[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[0];
    }

    public static double GetFirstArrayElement(double[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[0];
    }

    public static float GetFirstArrayElement(float[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[0];
    }

    public static int GetSecondArrayElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[1];
    }

    public static bool GetSecondArrayElement(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[1];
    }

    public static int GetThirdArrayElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[2];
    }

    public static int GetLastElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static bool GetLastElement(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[array.Length - 1];
    }

    public static string GetLastElement(string[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static char GetLastElement(char[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static double GetLastElement(double[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static float GetLastElement(float[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static decimal GetLastElement(decimal[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^1];
    }

    public static int GetNextToLastElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static bool GetNextToLastElement(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static string GetNextToLastElement(string[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static char GetNextToLastElement(char[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static double GetNextToLastElement(double[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static float GetNextToLastElement(float[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static decimal GetNextToLastElement(decimal[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^2];
    }

    public static int GetNthArrayElement(int[] array, int n)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[n - 1];
    }

    public static bool GetNthArrayElement(bool[] array, int n)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[n - 1];
    }

    public static bool GetSixthArrayElement(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[5];
    }

    public static string GetForthArrayElement(string[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[3];
    }

    public static char GetSeventhArrayElement(char[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[6];
    }

    public static double GetSeventhArrayElement(double[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[6];
    }

    public static float GetNinthArrayElement(float[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[8];
    }

    public static decimal GetThirdElementFromEnd(decimal[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^3];
    }

    public static decimal GetFourthElementFromEnd(decimal[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[^4];
    }
}

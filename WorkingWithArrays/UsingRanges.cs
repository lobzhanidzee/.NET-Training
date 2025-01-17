namespace WorkingWithArrays;

public static class UsingRanges
{
    public static int[] GetArrayWithAllElements(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[..];
    }

    public static int[] GetArrayWithoutFirstElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[1..^0];
    }

    public static int[] GetArrayWithoutTwoFirstElements(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[2..^0];
    }

    public static int[] GetArrayWithoutThreeFirstElements(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[3..^0];
    }

    public static int[] GetArrayWithoutLastElement(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[..^1];
    }

    public static int[] GetArrayWithoutTwoLastElements(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[..^2];
    }

    public static int[] GetArrayWithoutThreeLastElements(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[..^3];
    }

    public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[1..^1];
    }

    public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[2..^2];
    }

    public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        return array[3..^3];
    }
}

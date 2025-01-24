namespace Strings;

public static class CreatingStrings
{
    /// <summary>
    /// Returns a new string that contains a specified string.
    /// </summary>
    public static string ReturnNewString(string str)
    {
        return new string(str);
    }

    /// <summary>
    /// Returns a new string that contains a specified character repeated a specified number of times.
    /// </summary>
    public static string ReturnStringWithRepeatedChars(char c, int count)
    {
        return new string(c, count);
    }

    /// <summary>
    /// Returns a new string that contains a specified character array.
    /// </summary>
    public static string ReturnStringFromCharArray(char[] c)
    {
        return new string(c);
    }

    /// <summary>
    /// Returns a new string that contains a part of a specified character array.
    /// </summary>
    public static string ReturnStringFromCharArray(char[] c, int startIndex, int length)
    {
        return new string(c, startIndex, length);
    }
}

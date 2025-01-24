namespace Strings;
public static class JoiningStrings
{
    /// <summary>
    /// Concatenates an array of strings, using the comma character between each member.
    /// </summary>
    public static string GetCommaSeparatedString(string[] values)
    {
        return string.Join(',', values);
    }

    /// <summary>
    /// Concatenates an array of strings, using the colon character between each member.
    /// </summary>
    public static string GetColonSeparatedString(string[] values)
    {
        return string.Join(':', values);
    }

    /// <summary>
    /// Concatenates an array of strings without the first array element, using the comma between each member.
    /// </summary>
    public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
    {
        ArgumentNullException.ThrowIfNull(values);
        return string.Join(',', values[1..]);
    }

    /// <summary>
    /// Concatenates an array of strings without the first and the last array elements, using the hyphen between each member.
    /// </summary>
    public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
    {
        ArgumentNullException.ThrowIfNull(values);
        return string.Join('-', values[1..^1]);
    }

    /// <summary>
    /// Concatenates an array of strings, using the plus sign between each member.
    /// </summary>
    public static string GetPlusSeparatedString(IEnumerable<string> values)
    {
        return string.Join('+', values);
    }

    /// <summary>
    /// Concatenates an array of strings, using the backslash sign between each member.
    /// </summary>
    public static string GetBackslashSeparatedString(IEnumerable<object> values)
    {
        return string.Join('\\', values);
    }

    /// <summary>
    /// Concatenates an array of strings, using the separator string between each member.
    /// </summary>
    public static string GetStringSeparatedString(object[] values)
    {
        return string.Join("], [", values);
    }

    /// <summary>
    /// Concatenates an array of strings, using the separator string between each member.
    /// </summary>
    public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
    {
        ArgumentNullException.ThrowIfNull(values);
        return string.Join(separator, values[^3..]);
    }
}

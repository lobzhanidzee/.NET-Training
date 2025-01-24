namespace Strings;

public static class Concatenation
{
    /// <summary>
    /// Concatenates two specified instances of <see cref="string"/>.
    /// </summary>
    public static string ConcatenateTwoStrings1(string s1, string s2)
    {
        return s1 + s2;
    }

    /// <summary>
    /// Concatenates three specified instances of <see cref="string"/>.
    /// </summary>
    public static string ConcatenateThreeStrings1(string s1, string s2, string s3)
    {
        return s1 + s2 + s3;
    }

    /// <summary>
    /// Concatenates four specified instances of <see cref="string"/>.
    /// </summary>
    public static string ConcatenateFourStrings1(string s1, string s2, string s3, string s4)
    {
        return s1 + s2 + s3 + s4;
    }

    /// <summary>
    /// Concatenates two specified instances of <see cref="string"/>.
    /// </summary>
    public static string ConcatenateTwoStrings2(string s1, string s2)
    {
        return string.Concat(s1, s2);
    }

    /// <summary>
    /// Concatenates three specified instances of <see cref="string"/>.
    /// </summary>
    public static string ConcatenateThreeStrings2(string s1, string s2, string s3)
    {
        return string.Concat(s1, s2, s3);
    }

    /// <summary>
    /// Concatenates four specified instances of <see cref="string"/>.
    /// </summary>
    public static string ConcatenateFourStrings2(string s1, string s2, string s3, string s4)
    {
        return string.Concat(s1, s2, s3, s4);
    }

    /// <summary>
    /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
    /// </summary>
    public static string ConcatenateStrings(IEnumerable<string> strings)
    {
        return string.Concat(strings);
    }

    /// <summary>
    /// Concatenates the string representations of three specified objects.
    /// </summary>
    public static string ConcatenateValues(string str, int intValue, long longValue)
    {
        return string.Concat(str, intValue, longValue);
    }

    /// <summary>
    /// Concatenates the string representations of four specified objects.
    /// </summary>
    public static string ConcatenateValues(short shortValue, float floatValue, bool boolValue, double doubleValue)
    {
        return string.Concat(shortValue, floatValue, boolValue, doubleValue);
    }

    /// <summary>
    /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
    /// </summary>
    public static string ConcatenateValues(IEnumerable<object> values)
    {
        return string.Concat(values);
    }
}

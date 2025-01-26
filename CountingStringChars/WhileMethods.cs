namespace CountingStringChars;
public static class WhileMethods
{
    /// <summary>
    /// Returns a number of white space characters in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of white space characters in a string.</returns>
    public static int GetSpaceCount(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        int count = 0, i = 0;
        while (i < str.Length)
        {
            if (char.IsWhiteSpace(str[i]))
            {
                count++;
            }

            i++;
        }

        return count;
    }

    /// <summary>
    /// Returns a number of punctuation marks in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of punctuation marks in a string.</returns>
    public static int GetPunctuationCount(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        int count = 0, i = 0;

        while (i < str.Length)
        {
            if (char.IsPunctuation(str[i]))
            {
                count++;
            }

            i++;
        }

        return count;
    }

    /// <summary>
    /// Returns a number of white space characters in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of white space characters in a string.</returns>
    public static int GetSpaceCountRecursive(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int result = GetSpaceCountRecursive(str[1..]) + (char.IsWhiteSpace(str[0]) ? 1 : 0);

        return result;
    }

    /// <summary>
    /// Returns a number of punctuation marks in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of punctuation marks in a string.</returns>
    public static int GetPunctuationCountRecursive(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        bool isPunctuation = char.IsPunctuation(str[0]);
        int currentIncrement = isPunctuation ? 1 : 0;
        int result = GetPunctuationCountRecursive(str[1..]) + currentIncrement;

        return result;
    }
}

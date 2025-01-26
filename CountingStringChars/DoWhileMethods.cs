namespace CountingStringChars;

public static class DoWhileMethods
{
    /// <summary>
    /// Returns a number of digits in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of digits in a string.</returns>
    public static int GetDigitCount(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        int count = 0, i = 0;

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        do
        {
            if (char.IsDigit(str[i]))
            {
                count++;
            }

            i++;
        }
        while (i < str.Length);

        return count;
    }

    /// <summary>
    /// Returns a number of letters in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of letters in a string.</returns>
    public static int GetLetterCount(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        int count = 0, i = 0;

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        do
        {
            if (char.IsLetter(str[i]))
            {
                count++;
            }

            i++;
        }
        while (i < str.Length);

        return count;
    }

    /// <summary>
    /// Returns a number of digits in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of digits in a string.</returns>
    public static int GetDigitCountRecursive(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        return GetDigitCountRecursive(str, str.Length, 0);
    }

    /// <summary>
    /// Returns a number of letters in a string.
    /// </summary>
    /// <param name="str">A <see cref="string"/> to search.</param>
    /// <returns>A number of letters in a string.</returns>
    public static int GetLetterCountRecursive(string? str)
    {
        ArgumentNullException.ThrowIfNull(str);

        return GetLetterCountRecursive(str, str.Length, 0);
    }

    private static int GetDigitCountRecursive(string str, int charsLeft, int counter)
    {
        if (charsLeft > 0)
        {
            return GetDigitCountRecursive(str, charsLeft - 1, char.IsDigit(str[^charsLeft]) ? counter + 1 : counter);
        }

        return counter;
    }

    private static int GetLetterCountRecursive(string str, int charsLeft, int counter)
    {
        if (charsLeft > 0)
        {
            return GetLetterCountRecursive(str, charsLeft - 1, char.IsLetter(str[^charsLeft]) ? counter + 1 : counter);
        }

        return counter;
    }
}

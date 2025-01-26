namespace LookingForChars;

public static class CharsCounter
{
    /// <summary>
    /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
    /// </summary>
    /// <param name="str">String to search.</param>
    /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
    /// <returns>The number of occurrences of all characters.</returns>
    public static int GetCharsCount(string? str, char[]? chars)
    {
        ArgumentNullException.ThrowIfNull(str);
        ArgumentNullException.ThrowIfNull(chars);

        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                if (str[i].Equals(chars[j]))
                {
                    count++;
                }
            }
        }

        return count;
    }

    /// <summary>
    /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
    /// </summary>
    /// <param name="str">String to search.</param>
    /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
    /// <param name="startIndex">A zero-based starting index of the search.</param>
    /// <param name="endIndex">A zero-based ending index of the search.</param>
    /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
    public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex)
    {
        ArgumentNullException.ThrowIfNull(str);
        ArgumentNullException.ThrowIfNull(chars);
        ArgumentNullException.ThrowIfNull(startIndex);
        ArgumentNullException.ThrowIfNull(endIndex);

        ArgumentOutOfRangeException.ThrowIfNegative(endIndex);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(endIndex, str.Length - 1);
        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex, endIndex);

        int count = 0, i = startIndex;

        while (i <= endIndex)
        {
            int j = 0;
            while (j < chars.Length)
            {
                if (str[i].Equals(chars[j]))
                {
                    count++;
                }

                j++;
            }

            i++;
        }

        return count;
    }

    /// <summary>
    /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
    /// </summary>
    /// <param name="str">String to search.</param>
    /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
    /// <param name="startIndex">A zero-based starting index of the search.</param>
    /// <param name="endIndex">A zero-based ending index of the search.</param>
    /// <param name="limit">A maximum number of characters to search.</param>
    /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
    public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex, int limit)
    {
        ArgumentNullException.ThrowIfNull(str);
        ArgumentNullException.ThrowIfNull(chars);
        ArgumentNullException.ThrowIfNull(startIndex);
        ArgumentNullException.ThrowIfNull(endIndex);
        ArgumentNullException.ThrowIfNull(limit);

        ArgumentOutOfRangeException.ThrowIfNegative(endIndex);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(endIndex, str.Length - 1);
        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex, endIndex);
        ArgumentOutOfRangeException.ThrowIfNegative(limit);

        int count = 0, i = startIndex;

        do
        {
            int j = 0;
            do
            {
                if (str[i].Equals(chars[j]))
                {
                    count++;
                    limit--;
                }

                j++;
            }
            while (j < chars.Length && limit > 0);
            i++;
        }
        while (i <= endIndex && limit > 0);

        return count;
    }
}

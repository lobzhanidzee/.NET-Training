namespace CountingArrayElements;

public static class WhileMethods
{
    /// <summary>
    /// Searches an array of strings for empty elements, and returns the number of occurrences of empty strings.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of empty strings.</returns>
    public static int GetEmptyStringCount(string[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        int i = 0, count = 0;

        while (i < arrayToSearch.Length)
        {
            if (string.IsNullOrEmpty(arrayToSearch[i]))
            {
                count++;
            }

            i++;
        }

        return count;
    }

    /// <summary>
    /// Searches an array of long integers for elements with minimum and maximum values, and returns the number of occurrences of long integers with minimum and maximum values.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of long integers with minimum and maximum values.</returns>
    public static int GetMinOrMaxLongCount(long[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        int i = 0, count = 0;

        while (i < arrayToSearch.Length)
        {
            if (arrayToSearch[i] == long.MinValue || arrayToSearch[i] == long.MaxValue)
            {
                count++;
            }

            i++;
        }

        return count;
    }

    /// <summary>
    /// Searches an array of objects for null elements, and returns the number of occurrences of null values.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of null values.</returns>
    public static int GetNullObjectCount(object[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        int i = 0, count = 0;

        while (i < arrayToSearch.Length)
        {
            if (arrayToSearch[i] is null)
            {
                count++;
            }

            i++;
        }

        return count;
    }

    /// <summary>
    /// Searches an array of strings for empty elements, and returns the number of occurrences of empty strings.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of empty strings.</returns>
    public static int GetEmptyStringCountRecursive(string[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        if (arrayToSearch.Length == 0)
        {
            return 0;
        }

        int currentIncrement = string.IsNullOrEmpty(arrayToSearch[^1]) ? 1 : 0;
        string[] newArrayToSearch = arrayToSearch[..^1];
        return GetEmptyStringCountRecursive(newArrayToSearch) + currentIncrement;
    }

    /// <summary>
    /// Searches an array of long integers for elements with minimum and maximum values, and returns the number of occurrences of long integers with minimum and maximum values.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of long integers with minimum and maximum values.</returns>
    public static int GetMinOrMaxLongCountRecursive(long[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        if (arrayToSearch.Length == 0)
        {
            return 0;
        }

        long currentElement = arrayToSearch[0];
        int currentIncrement = (currentElement == long.MinValue || currentElement == long.MaxValue) ? 1 : 0;
        long[] newArrayToSearch = arrayToSearch[1..];
        return GetMinOrMaxLongCountRecursive(newArrayToSearch) + currentIncrement;
    }

    /// <summary>
    /// Searches an array of objects for null elements, and returns the number of occurrences of null values.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of null values.</returns>
    public static int GetNullObjectCountRecursive(object[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        return GetNullObjectCountRecursive(arrayToSearch, 0);
    }

    private static int GetNullObjectCountRecursive(object[] arrayToSearch, int accumulator)
    {
        if (arrayToSearch.Length == 0)
        {
            return accumulator;
        }

        if (arrayToSearch[0] is null)
        {
            accumulator++;
        }

        object[] newArrayToSearch = arrayToSearch[1..];
        return GetNullObjectCountRecursive(newArrayToSearch, accumulator);
    }
}

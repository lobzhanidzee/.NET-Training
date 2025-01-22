namespace CountingArrayElements;

public static class ForMethods
{
    /// <summary>
    /// Searches an array of integers for negative elements, and returns the number of occurrences of negative integers.
    /// </summary>
    /// <param name="arrayToSearch">A <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of negative integers.</returns>
    public static int GetNegativeIntegerCount(int[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        int count = 0;

        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if (arrayToSearch[i] < 0)
            {
                count++;
            }
        }

        return count;
    }

    /// <summary>
    /// Searches an array of single-precision floating-point numbers for even elements, and returns the number of occurrences of even numbers.
    /// </summary>
    /// <param name="arrayToSearch">A <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of even numbers.</returns>
    public static int GetEvenNumberCount(float[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        int count = 0;

        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if (arrayToSearch[i] % 2 is 0)
            {
                count++;
            }
        }

        return count;
    }

    /// <summary>
    /// Searches an array of bytes for elements with enabled bits in high nibble, and returns the number of occurrences of bytes with enabled bits in high nibble.
    /// </summary>
    /// <param name="arrayToSearch">A <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of bytes with enabled bits in high nibble.</returns>
    public static int GetByteWithBitsInHighNibbleCount(byte[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        int count = 0;

        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if ((arrayToSearch[i] & 0xF0) > 0)
            {
                count++;
            }
        }

        return count;
    }

    /// <summary>
    /// Searches an array of integers for negative elements, and returns the number of occurrences of negative integers.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of negative integers.</returns>
    public static int GetNegativeIntegerCountRecursive(int[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        return GetNegativeIntegerCountRecursive(arrayToSearch, 0);
    }

    /// <summary>
    /// Searches an array of single-precision floating-point numbers for even elements, and returns the number of occurrences of even numbers.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of even numbers.</returns>
    public static int GetEvenNumberCountRecursive(float[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        if (arrayToSearch.Length == 0)
        {
            return 0;
        }

        int currentIncrement = arrayToSearch[0] % 2 is 0 ? 1 : 0;
        return GetEvenNumberCountRecursive(arrayToSearch[1..]) + currentIncrement;
    }

    /// <summary>
    /// Searches an array of bytes for elements with enabled bits in high nibble, and returns the number of occurrences of bytes with enabled bits in high nibble.
    /// </summary>
    /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
    /// <returns>The number of occurrences of bytes with enabled bits in high nibble.</returns>
    public static int GetByteWithBitsInHighNibbleCountRecursive(byte[]? arrayToSearch)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        return GetByteWithBitsInHighNibbleCountRecursive(arrayToSearch, arrayToSearch.Length - 1, 0);
    }

    private static int GetNegativeIntegerCountRecursive(int[] arrayToSearch, int index)
    {
        if (index >= arrayToSearch.Length)
        {
            return 0;
        }

        int currentIncrement = arrayToSearch[index] < 0 ? 1 : 0;
        return GetNegativeIntegerCountRecursive(arrayToSearch, index + 1) + currentIncrement;
    }

    private static int GetByteWithBitsInHighNibbleCountRecursive(byte[] arrayToSearch, int index, int accumulator)
    {
        if (index < 0)
        {
            return accumulator;
        }

        int currentAccumulator = (arrayToSearch[index] & 0xF0) > 0 ? accumulator + 1 : accumulator;
        return GetByteWithBitsInHighNibbleCountRecursive(arrayToSearch, index - 1, currentAccumulator);
    }
}

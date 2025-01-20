namespace LookingForArrayElements;

public static class DecimalCounter
{
    /// <summary>
    /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
    /// </summary>
    /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
    /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
    /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
    public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);
        ArgumentNullException.ThrowIfNull(ranges);

        foreach (decimal[]? range in ranges)
        {
            ArgumentNullException.ThrowIfNull(range);

            if (range.Length == 0)
            {
                return 2;
            }

            if (range.Length != 2)
            {
                throw new ArgumentException("Each range must have exactly 2 elements.");
            }
        }

        int result = 0;

        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            for (int j = 0; j < ranges.Length; j++)
            {
                if (arrayToSearch[i] >= ranges[j]?[0] && arrayToSearch[i] <= ranges[j]?[1])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }

    /// <summary>
    /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
    /// </summary>
    /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
    /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
    public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);
        ArgumentNullException.ThrowIfNull(ranges);

        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfNegative(count);


        foreach (decimal[]? range in ranges)
        {
            ArgumentNullException.ThrowIfNull(range);

            if (range.Length == 0)
            {
                return 1;
            }

            if (range.Length != 2)
            {
                throw new ArgumentException("Each range must have exactly 2 elements.");
            }
        }

        int lastPosition = startIndex + count;

        if (lastPosition > arrayToSearch.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex), "error");
        }

        int result = 0;

        for (int i = startIndex; i < lastPosition; i++)
        {
            for (int j = 0; j < ranges.Length; j++)
            {
                if (arrayToSearch[i] >= ranges[j]?[0] && arrayToSearch[i] <= ranges[j]?[1])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}

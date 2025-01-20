namespace LookingForArrayElements;

public static class FloatCounter
{
    /// <summary>
    /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
    /// </summary>
    /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
    /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
    /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
    /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
    public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);
        ArgumentNullException.ThrowIfNull(rangeStart);
        ArgumentNullException.ThrowIfNull(rangeEnd);

        if (rangeStart.Length == 0 || rangeEnd.Length == 0)
        {
            return 0;
        }

        if (rangeStart.Length != rangeEnd.Length)
        {
            throw new ArgumentException("Different number of elements");
        }

        if (rangeStart[0] > rangeEnd[0])
        {
            throw new ArgumentException("rangeStart is more than rangeEnd");
        }

        int sum = 0;
        if (rangeStart.Length == 1 && rangeEnd.Length == 1)
        {
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }

        if (rangeStart.Length == 2)
        {
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] == rangeStart[j] || arrayToSearch[i] == rangeEnd[j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }

        if (rangeStart.Length == 3)
        {
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }


        return sum;
    }

    /// <summary>
    /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
    /// </summary>
    /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
    /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
    /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
    public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);
        ArgumentNullException.ThrowIfNull(rangeStart);
        ArgumentNullException.ThrowIfNull(rangeEnd);
        ArgumentOutOfRangeException.ThrowIfLessThan(count, 0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex, arrayToSearch.Length);
        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);


        if (rangeStart.Length == 0 || rangeEnd.Length == 0)
        {
            return 0;
        }

        if (rangeStart.Length != rangeEnd.Length)
        {
            throw new ArgumentException("Different number of elements");
        }

        if (rangeStart[0] > rangeEnd[0])
        {
            throw new ArgumentException("rangeStart is more than rangeEnd");
        }

        int sum = 0;
        int lastIndex = startIndex + count;

        if (rangeStart.Length == 1 && rangeEnd.Length == 1)
        {
            for (int i = startIndex; i < lastIndex; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }

        if (rangeStart.Length == 2)
        {
            for (int i = startIndex; i < lastIndex; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] == rangeStart[j] || arrayToSearch[i] == rangeEnd[j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }

        if (rangeStart.Length == 3)
        {
            for (int i = startIndex; i < lastIndex; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }

        return sum;
    }
}

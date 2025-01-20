namespace LookingForArrayElements;

public static class IntegersCounter
{
    /// <summary>
    /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements.
    /// </summary>
    /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
    /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
    /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
    public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor)
    {
        int sum = 0;

        ArgumentNullException.ThrowIfNull(arrayToSearch);

        ArgumentNullException.ThrowIfNull(elementsToSearchFor);

        for (int i = 0; i < elementsToSearchFor.Length; i++)
        {
            for (int j = 0; j < arrayToSearch.Length; j++)
            {
                if (elementsToSearchFor[i] == arrayToSearch[j])
                {
                    sum++;
                }
            }
        }

        return sum;
    }

    /// <summary>
    /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements withing the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
    /// </summary>
    /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
    /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
    public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor, int startIndex, int count)
    {
        ArgumentNullException.ThrowIfNull(arrayToSearch);

        ArgumentNullException.ThrowIfNull(elementsToSearchFor);

        ArgumentOutOfRangeException.ThrowIfNegative(count);

        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);

        ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex, arrayToSearch.Length);

        int sum = 0;

        int lastPosition = startIndex + count;
        while (startIndex < lastPosition)
        {
            int j = 0;
            while (j < elementsToSearchFor.Length)
            {
                if (arrayToSearch[startIndex] == elementsToSearchFor[j])
                {
                    sum++;
                }
                j++;
            }
            startIndex++;
        }

        return sum;
    }
}

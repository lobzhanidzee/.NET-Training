namespace FilterByPredicate;

/// <summary>
/// Contains sz-array extension method.
/// </summary>
public static class ArrayExtension
{
    /// <summary>
    /// Returns new array of elements that contain elements that correspond given predicate only.
    /// </summary>
    /// <param name="source">Source array.</param>
    /// <param name="predicate">Predicate.</param>
    /// <returns>Array of elements that correspond given predicate only.</returns>
    /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
    /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
    /// <exception cref="ArgumentNullException">Thrown when predicate is null.</exception>
    public static int[] Select(this int[]? source, IPredicate? predicate)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(predicate);

        if (source.Length == 0)
        {
            throw new ArgumentException("Array is empty", nameof(source));
        }

        int[] result = [];
        foreach (var item in source!.Where(item => predicate.IsMatch(item)))
        {
            result = result.Append(item).ToArray();
        }

        return result;
    }
}

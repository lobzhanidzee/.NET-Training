namespace FilterByPredicate;

/// <summary>
/// Presents predicate.
/// </summary>
public interface IPredicate
{
    /// <summary>
    /// Presents function-predicate for integer.
    /// </summary>
    /// <param name="number">Integer to be matching.</param>
    /// <returns>Result of matching.</returns>
    bool IsMatch(int number);
}

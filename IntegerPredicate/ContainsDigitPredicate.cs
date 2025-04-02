using GenericMethods.Interfaces;

namespace IntegerPredicate;

/// <summary>
/// Predicate class for the integer type.
/// </summary>
public class ContainsDigitPredicate : IPredicate<int>
{
    /// <summary>
    /// Gets or sets digit in the integer number.
    /// </summary>
    public int Digit
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    /// <summary>
    /// Determines if a number contains a given digit.
    /// </summary>
    /// <param name="obj">The integer value.</param>
    /// <returns>true if integer value contains given digit; otherwise, false.</returns>
    public bool IsMatch(int obj)
    {
        throw new NotImplementedException();
    }
}

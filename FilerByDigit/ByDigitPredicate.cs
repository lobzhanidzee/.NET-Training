using System.Globalization;
using FilterByPredicate;

namespace FilterByDigit;

/// <summary>
/// Predicate that determines the presence of some digit in integer.
/// </summary>
public class ByDigitPredicate : IPredicate
{
    /// <summary>
    /// Gets or sets a digit.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when Digit more than 9 or less than 0.</exception>
    public int Digit
    {
        get;
        set;
    }

    /// <inheritdoc/>
    public bool IsMatch(int number)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(this.Digit);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(this.Digit, 9);

        string num = number.ToString(CultureInfo.InvariantCulture);

        foreach (char item in num)
        {
            int digitNumber = item - '0';
            if (digitNumber == this.Digit)
            {
                return true;
            }
        }

        return false;
    }
}

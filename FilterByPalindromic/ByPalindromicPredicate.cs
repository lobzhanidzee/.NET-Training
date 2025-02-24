using System.Globalization;
using FilterByPredicate;

namespace FilterByPalindromic;

/// <summary>
/// Palindrome predicate.
/// </summary>
public class ByPalindromicPredicate : IPredicate
{
    /// <inheritdoc/>
    public bool IsMatch(int number)
    {
        string num = number.ToString(CultureInfo.InvariantCulture);

        int right = num.Length - 1;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] != num[right])
            {
                return false;
            }

            if (i >= right)
            {
                return true;
            }

            right--;
        }

        return true;
    }
}

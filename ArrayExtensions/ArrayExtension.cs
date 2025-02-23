using System.Globalization;

namespace ArrayExtensions;

/// <summary>
/// Class of the additional operations with array.
/// </summary>
public static class ArrayExtension
{
    /// <summary>
    /// Returns new array of elements that contain expected digit from source array.
    /// </summary>
    /// <param name="source">Source array.</param>
    /// <param name="digit">Expected digit.</param>
    /// <returns>Array of elements that contain expected digit.</returns>
    /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
    /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when digit value is out of range (0..9).</exception>
    /// <example>
    /// {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17}  => { 7, 70, 17 } for digit = 7.
    /// </example>
    public static int[] FilterByDigit(this int[]? source, int digit)
    {
        ArgumentNullException.ThrowIfNull(source);

        ArgumentOutOfRangeException.ThrowIfNegative(digit);

        if (source.Length == 0)
        {
            throw new ArgumentException("Array is empty", nameof(source));
        }

        int[] result = [];

        foreach (var item in source!)
        {
            if (IsMatch(item))
            {
                result = result.Append(item).ToArray();
            }
        }

        bool IsMatch(int value)
        {
            string num = value.ToString(CultureInfo.InvariantCulture);

            foreach (char item in num)
            {
                if (item == digit)
                {
                    return true;
                }
            }

            return false;
        }

        return result;
    }

    /// <summary>
    /// Returns new array that contains only palindromic numbers from source array.
    /// </summary>
    /// <param name="source">Source array.</param>
    /// <returns>Array of elements that are palindromic numbers.</returns>
    /// <exception cref="ArgumentNullException">Throw when array is null.</exception>
    /// <exception cref="ArgumentException">Throw when array is empty.</exception>
    /// <example>
    /// {12345, 1111111112, 987654, 56, 1111111, -1111, 1, 1233321, 70, 15, 123454321}  => { 1111111, 123321, 123454321 }
    /// {56, -1111111112, 987654, 56, 890, -1111, 543, 1233}  => {  }.
    /// </example>
    public static int[] FilterByPalindromic(this int[]? source)
    {
        int[] palidromeNumbers = [];
        foreach (int item in source!)
        {
            if (IsMatch(item))
            {
                palidromeNumbers = palidromeNumbers.Append(item).ToArray();
            }
        }

        bool IsMatch(int value)
        {
            string number = value.ToString(CultureInfo.InvariantCulture);

            int right = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != number[right])
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

        return palidromeNumbers;
    }
}

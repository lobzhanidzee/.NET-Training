namespace LeapYear;

public static class Year
{
    /// <summary>
    /// Returns true if a specified <paramref name="year"/> is a leap year.
    /// </summary>
    /// <param name="year">A year to test.</param>
    /// <returns>True if a specified <paramref name="year"/> is a leap year; otherwise false.</returns>
    public static bool IsLeapYear(int year)
    {
        bool result = false;

        if (year % 4 == 0)
        {
            result = true;

            if (year % 400 != 0 && year % 100 == 0)
            {
                result = false;
            }
        }

        return result;
    }
}

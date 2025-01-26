namespace GettingCharIndex;

public static class WhileMethods
{
    public static int GetIndexOfChar(string? str, char value)
    {
        ArgumentNullException.ThrowIfNull(str);

        int i = 0, result = -1;

        while (i < str.Length)
        {
            if (str[i] == value)
            {
                result = i;
                break;
            }

            i++;
        }

        return result;
    }

    public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
    {
        ArgumentNullException.ThrowIfNull(str);
        ArgumentNullException.ThrowIfNull(value);
        ArgumentNullException.ThrowIfNull(startIndex);

        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex, str.Length);

        int i = startIndex, result = -1;

        while (i < str.Length && count > 0)
        {
            if (str[i] == value)
            {
                result = i;
                break;
            }

            i++;
            count--;
        }

        return result;
    }

    public static int GetLastIndexOfChar(string? str, char value)
    {
        ArgumentNullException.ThrowIfNull(str);

        int currentCharIndex = str.Length - 1;
        while (currentCharIndex >= 0)
        {
            char currentChar = str[currentCharIndex];
            if (currentChar == value)
            {
                return currentCharIndex;
            }

            currentCharIndex--;
        }

        return -1;
    }

    public static int GetLastIndexOfChar(string? str, char value, int startIndex, int count)
    {
        ArgumentNullException.ThrowIfNull(str);

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
        }

        if (startIndex > str.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
        }

        if (startIndex + count > str.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
        }

        int currentCharIndex = startIndex + count - 1;
        while (currentCharIndex >= startIndex)
        {
            char currentChar = str[currentCharIndex];
            if (currentChar == value)
            {
                return currentCharIndex;
            }

            currentCharIndex--;
        }

        return -1;
    }
}

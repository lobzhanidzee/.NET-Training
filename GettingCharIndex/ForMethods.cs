namespace GettingCharIndex;
public static class ForMethods
{
    public static int GetIndexOfChar(string? str, char value)
    {
        ArgumentNullException.ThrowIfNull(str);

        int i = 0, result = -1;

        for (; i < str.Length; i++)
        {
            if (str[i] == value)
            {
                result = i;
                break;
            }
        }

        return result;
    }

    public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
    {
        ArgumentNullException.ThrowIfNull(str);
        ArgumentNullException.ThrowIfNull(startIndex);
        ArgumentNullException.ThrowIfNull(count);

        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex, str.Length);

        int i = startIndex, result = -1;

        for (; i < str.Length && count > 0; i++)
        {
            if (str[i] == value)
            {
                result = i;
                break;
            }

            count--;
        }

        return result;
    }

    public static int GetLastIndexOfChar(string? str, char value)
    {
        ArgumentNullException.ThrowIfNull(str);

        for (int currentCharIndex = str.Length - 1; currentCharIndex >= 0; currentCharIndex--)
        {
            char currentChar = str[currentCharIndex];
            if (currentChar == value)
            {
                return currentCharIndex;
            }
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

        for (int currentCharIndex = startIndex + count - 1; currentCharIndex >= startIndex; currentCharIndex--)
        {
            char currentChar = str[currentCharIndex];
            if (currentChar == value)
            {
                return currentCharIndex;
            }
        }

        return -1;
    }
}

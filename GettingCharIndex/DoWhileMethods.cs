namespace GettingCharIndex;

public static class DoWhileMethods
{
    public static int GetIndexOfChar(string? str, char value)
    {
        ArgumentNullException.ThrowIfNull(str);

        int i = 0, result = -1;

        if (str.Length == 0)
        {
            return result;
        }

        do
        {
            if (str[i] == value)
            {
                result = i;
                break;
            }

            i++;
        }
        while (i < str.Length);

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

        if (str.Length == 0)
        {
            return result;
        }

        do
        {
            if (str[i] == value)
            {
                result = i;
                break;
            }

            i++;
            count--;
        }
        while (i < str.Length && count > 0);

        return result;
    }

    public static int GetLastIndexOfChar(string? str, char value)
    {
        ArgumentNullException.ThrowIfNull(str);

        int currentCharIndex = str.Length - 1;
        if (currentCharIndex < 0)
        {
            return -1;
        }

        do
        {
            char currentChar = str[currentCharIndex];
            if (currentChar == value)
            {
                return currentCharIndex;
            }

            currentCharIndex--;
        }
        while (currentCharIndex >= 0);

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
        if (currentCharIndex < 0)
        {
            return -1;
        }

        do
        {
            char currentChar = str[currentCharIndex];
            if (currentChar == value)
            {
                return currentCharIndex;
            }

            currentCharIndex--;
        }
        while (currentCharIndex >= startIndex);

        return -1;
    }
}

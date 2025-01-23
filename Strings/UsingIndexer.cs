namespace Strings;
public static class UsingIndexer
{
    /// <summary>
    /// Gets the first character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetFirstChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[0];
    }

    /// <summary>
    /// Gets the second character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetSecondChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[1];
    }

    /// <summary>
    /// Gets the third character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetThirdChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[2];
    }

    /// <summary>
    /// Gets the last character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetLastChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[^1];
    }

    /// <summary>
    /// Gets the next to last character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetNextToLastChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[^2];
    }

    /// <summary>
    /// Gets the third character from the end of the <paramref name="str"/> string.
    /// </summary>
    public static char GetThirdCharFromEnd(string str)
    {
        return str[^3];
    }

    /// <summary>
    /// Gets the n-th character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetNthChar(string str, int n)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[n - 1];
    }

    /// <summary>
    /// Gets the n-th character from the end of the <paramref name="str"/> string.
    /// </summary>
    public static char GetNthCharFromEnd(string str, int n)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[^n];
    }

    /// <summary>
    /// Gets the last character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetLastCharUsingLength(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        int lastCharacter = str.Length - 1;
        return str[lastCharacter];
    }

    /// <summary>
    /// Gets the next to last character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetNextToLastCharUsingLength(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        int lastCharacter = str.Length - 2;
        return str[lastCharacter];
    }

    /// <summary>
    /// Gets the fifth character from the end of the <paramref name="str"/> string.
    /// </summary>
    public static char GetFifthCharFromEndUsingLength(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        int lastCharacter = str.Length - 5;
        return str[lastCharacter];
    }

    /// <summary>
    /// Gets the n-th character of the <paramref name="str"/> string.
    /// </summary>
    public static char GetNthCharFromEndUsingLength(string str, int n)
    {
        ArgumentNullException.ThrowIfNull(str);
        int lastCharacter = str.Length - n;
        return str[lastCharacter];
    }

    /// <summary>
    /// Gets special code characters from <paramref name="serialNumber"/>.
    /// </summary>
    public static void GetSpecialCodes(string serialNumber, out char expectedCode1, out char expectedCode2, out char expectedCode3)
    {
        ArgumentNullException.ThrowIfNull(serialNumber);

        if (serialNumber.Length == 11)
        {
            expectedCode1 = serialNumber[1];
            expectedCode2 = serialNumber[3];
            expectedCode3 = serialNumber[^4];
        }
        else if (serialNumber.Length == 12)
        {
            expectedCode1 = serialNumber[1];
            expectedCode2 = serialNumber[4];
            expectedCode3 = serialNumber[^4];
        }
        else
        {
            expectedCode1 = serialNumber[1];
            expectedCode2 = serialNumber[5];
            expectedCode3 = serialNumber[^4];
        }
    }
}

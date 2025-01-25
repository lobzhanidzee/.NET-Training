namespace Strings;

public static class UsingRanges
{
    /// <summary>
    /// Gets a string with all characters of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithAllChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(0);
    }

    /// <summary>
    /// Gets a string without first character of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutFirstChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(1);
    }

    /// <summary>
    /// Gets a string without two first character of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutTwoFirstChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(2);
    }

    /// <summary>
    /// Gets a string without three first character of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutThreeFirstChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(3);
    }

    /// <summary>
    /// Gets a string without a last character of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutLastChar(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(0, str.Length - 1);
    }

    /// <summary>
    /// Gets a string without a two last characters of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutTwoLastChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(0, str.Length - 2);
    }

    /// <summary>
    /// Gets a string without a three last characters of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutThreeLastChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Substring(0, str.Length - 3);
    }

    /// <summary>
    /// Gets a string without the first and the last characters of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutFirstAndLastChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[1..^1];
    }

    /// <summary>
    /// Gets a string without the first two and the last two characters of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutTwoFirstAndTwoLastChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[2..^2];
    }

    /// <summary>
    /// Gets a string without the first three and the last three characters of the <paramref name="str"/> string.
    /// </summary>
    public static string GetStringWithoutThreeFirstAndThreeLastChars(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str[3..^3];
    }

    /// <summary>
    /// Gets details of the production code.
    /// </summary>
    public static void GetProductionCodeDetails(string productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode)
    {
        ArgumentNullException.ThrowIfNull(productionCode);

        regionCode = productionCode.Substring(0, 1);
        locationCode = productionCode.Substring(3, 2);
        dateCode = productionCode.Substring(7, 3);
        factoryCode = productionCode.Substring(productionCode.Length - 4);
    }

    /// <summary>
    /// Gets details of the production code.
    /// </summary>
    public static void GetSerialNumberDetails(string serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode)
    {
        ArgumentNullException.ThrowIfNull(serialNumber);

        if (serialNumber.Length == 13)
        {
            countryCode = serialNumber.Substring(4, 1);
            manufacturerCode = serialNumber.Substring(5, 2);
            factoryCode = serialNumber.Substring(serialNumber.Length - 5, 4);
            stationCode = serialNumber.Substring(serialNumber.Length - 1);
        }
        else if (serialNumber.Length == 12)
        {
            countryCode = serialNumber.Substring(3, 1);
            manufacturerCode = serialNumber.Substring(4, 2);
            factoryCode = serialNumber.Substring(serialNumber.Length - 5, 4);
            stationCode = serialNumber.Substring(serialNumber.Length - 1);
        }
        else
        {
            countryCode = serialNumber.Substring(2, 1);
            manufacturerCode = serialNumber.Substring(3, 2);
            factoryCode = serialNumber.Substring(serialNumber.Length - 5, 4);
            stationCode = serialNumber.Substring(serialNumber.Length - 1);
        }
    }
}

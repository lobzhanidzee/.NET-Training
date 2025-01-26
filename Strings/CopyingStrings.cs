namespace Strings;

public static class CopyingStrings
{
    /// <summary>
    /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
    /// </summary>
    public static string CopyOneChar(string source, string destination)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);

        char[] destinationArray = destination.ToCharArray();
        source.CopyTo(0, destinationArray, 4, source.Length);
        return new string(destinationArray);
    }

    /// <summary>
    /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
    /// </summary>
    public static string CopyThreeChars(string source, string destination)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);

        char[] destinationArray = destination.ToCharArray();
        source.CopyTo(0, destinationArray, 0, 3);
        return new string(destinationArray);
    }

    /// <summary>
    /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
    /// </summary>
    public static string CopyFiveChars(string source, string destination)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);

        char[] destinationArray = destination.ToCharArray();
        source.CopyTo(0, destinationArray, 4, 5);
        return new string(destinationArray);
    }

    /// <summary>
    /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
    /// </summary>
    public static string CopySixChars(string source, string destination)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);

        char[] destinationArray = destination.ToCharArray();
        source.CopyTo(2, destinationArray, 5, 6);
        return new string(destinationArray);
    }

    /// <summary>
    /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
    /// </summary>
    public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
    {
        ArgumentNullException.ThrowIfNull(template);
        ArgumentNullException.ThrowIfNull(regionCode);
        ArgumentNullException.ThrowIfNull(locationCode);
        ArgumentNullException.ThrowIfNull(dateCode);
        ArgumentNullException.ThrowIfNull(factoryCode);

        char[] destinationArray = template.ToCharArray();
        regionCode.CopyTo(1, destinationArray, 0, 1);
        locationCode.CopyTo(4, destinationArray, 3, 2);
        dateCode.CopyTo(3, destinationArray, 7, 3);
        factoryCode.CopyTo(2, destinationArray, 12, 4);

        return new string(destinationArray);
    }
}

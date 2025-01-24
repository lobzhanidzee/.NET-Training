namespace Strings;
public static class SplittingStrings
{
    /// <summary>
    /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
    /// </summary>
    public static string[] SplitCommaSeparatedString(string str)
    {
        ArgumentNullException.ThrowIfNull(str);
        return str.Split(',');
    }

    /// <summary>
    /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
    /// </summary>
    public static string[] SplitColonSeparatedString(string str)
    {
        // TODO #7-2. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
    /// </summary>
    public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
    {
        // TODO #7-3. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
    /// </summary>
    public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
    {
        // TODO #7-4. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits a hyphen-separated string into substrings that are based on the hyphen character, and return an array whose elements contain the substrings.
    /// </summary>
    public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
    {
        // TODO #7-5. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits a separated string that is separated with colon and comma characters into substrings, and return an array whose elements contain the substrings.
    /// </summary>
    public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
    {
        // TODO #7-6. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits a sentence into substrings, and return an array whose elements contain only words.
    /// </summary>
    public static string[] GetOnlyWords(string str)
    {
        // TODO #7-7. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits a CSV (comma-separated values) string into substrings that are based on the comma character, and return an array of the CSV line elements.
    /// </summary>
    public static string[] GetDataFromCsvLine(string str)
    {
        // TODO #7-8. Analyze unit tests for the method, and add the method implementation.
        throw new NotImplementedException();
    }
}

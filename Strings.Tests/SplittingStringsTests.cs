using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests;

[TestFixture]
public sealed class SplittingStringsTests
{
    [TestCase("abc", ExpectedResult = new string[] { "abc" })]
    [TestCase("abc,bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc,bcd,cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    public string[] SplitCommaSeparatedString_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.SplitCommaSeparatedString(str);
    }

    [TestCase("abc", ExpectedResult = new string[] { "abc" })]
    [TestCase("abc:bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc:bcd:cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    public string[] SplitColonSeparatedString_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.SplitColonSeparatedString(str);
    }

    [TestCase("abc", ExpectedResult = new string[] { "abc" })]
    [TestCase("abc,bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc,bcd,cde", ExpectedResult = new string[] { "abc", "bcd,cde" })]
    public string[] SplitCommaSeparatedStringMaxTwoElements_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.SplitCommaSeparatedStringMaxTwoElements(str);
    }

    [TestCase("abc", ExpectedResult = new string[] { "abc" })]
    [TestCase("abc:bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc:bcd:cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc::bcd:cde", ExpectedResult = new string[] { "abc", "", "bcd:cde" })]
    [TestCase("abc::bcd::cde", ExpectedResult = new string[] { "abc", "", "bcd::cde" })]
    [TestCase("abc:bcd:cde:def", ExpectedResult = new string[] { "abc", "bcd", "cde:def" })]
    public string[] SplitColonSeparatedStringMaxThreeElements_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.SplitColonSeparatedStringMaxThreeElements(str);
    }

    [TestCase("abc", ExpectedResult = new string[] { "abc" })]
    [TestCase("abc-bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc-bcd-cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc--bcd-cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc--bcd--cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc-bcd-cde-def", ExpectedResult = new string[] { "abc", "bcd", "cde-def" })]
    public string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(str);
    }

    [TestCase("abc", ExpectedResult = new string[] { "abc" })]
    [TestCase("abc:bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc,bcd", ExpectedResult = new string[] { "abc", "bcd" })]
    [TestCase("abc:bcd,cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc:,bcd,:cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc::bcd,,cde", ExpectedResult = new string[] { "abc", "bcd", "cde" })]
    [TestCase("abc:bcd,cde:def", ExpectedResult = new string[] { "abc", "bcd", "cde", "def" })]
    [TestCase("abc:bcd,cde:def,efg:fgh", ExpectedResult = new string[] { "abc", "bcd", "cde", "def,efg:fgh" })]
    public string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(str);
    }

    [TestCase("Words with punctuation: extract only words, skip all punctuation marks.\tAlso - skip all spaces and tab characters!", ExpectedResult = new string[] { "Words", "with", "punctuation", "extract", "only", "words", "skip", "all", "punctuation", "marks", "Also", "skip", "all", "spaces", "and", "tab", "characters" })]
    public string[] GetOnlyWords_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return SplittingStrings.GetOnlyWords(str);
    }

    [TestCase("123, 45.67, abc,89.01, def,23", ExpectedResult = new string[] { "123", "45.67", "abc", "89.01", "def", "23" })]
    public string[] GetDataFromCsvLine_StrIsValid_ReturnResult(string str)
    {
        // Act
        return SplittingStrings.GetDataFromCsvLine(str);
    }
}

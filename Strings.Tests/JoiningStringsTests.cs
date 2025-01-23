using System.Globalization;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests;

[TestFixture]
public sealed class JoiningStringsTests
{
    private static readonly object[][] GetCommaSeparatedStringData =
    [
        new object[]
        {
            Array.Empty<string>(),
            string.Empty,
        },
        new object[]
        {
            new string[] { "abc" },
            "abc",
        },
        new object[]
        {
            new string[] { "abc", "bcd" },
            "abc,bcd",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde" },
            "abc,bcd,cde",
        },
    ];

    private static readonly object[][] GetColonSeparatedStringData =
    [
        new object[]
        {
            Array.Empty<string>(),
            string.Empty,
        },
        new object[]
        {
            new string[] { "abc" },
            "abc",
        },
        new object[]
        {
            new string[] { "abc", "bcd" },
            "abc:bcd",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde" },
            "abc:bcd:cde",
        },
    ];

    private static readonly object[][] GetCommaSeparatedStringWithoutFirstElementData =
    [
        new object[]
        {
            new string[] { "abc", "bcd" },
            "bcd",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde" },
            "bcd,cde",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde", "def" },
            "bcd,cde,def",
        },
    ];

    private static readonly object[][] GetHyphenSeparatedStringWithoutFirstAndLastElementsData =
    [
        new object[]
        {
            new string[] { "abc", "bcd" },
            string.Empty,
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde" },
            "bcd",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde", "def" },
            "bcd-cde",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde", "def", "efh" },
            "bcd-cde-def",
        },
    ];

    private static readonly object[][] GetPlusSeparatedStringData =
    [
        new object[]
        {
            Array.Empty<string>(),
            string.Empty,
        },
        new object[]
        {
            new string[] { "abc" },
            "abc",
        },
        new object[]
        {
            new string[] { "abc", "bcd" },
            "abc+bcd",
        },
        new object[]
        {
            new string[] { "abc", "bcd", "cde" },
            "abc+bcd+cde",
        },
    ];

    private static readonly object[][] GetBackslashSeparatedStringData =
    [
        new object[]
        {
            Array.Empty<object>(),
            string.Empty,
        },
        new object[]
        {
            new object[] { "abc" },
            "abc",
        },
        new object[]
        {
            new object[] { true, long.MinValue, "abc", int.MaxValue, "bcd", 1.1f, float.MinValue, false, },
            "True\\-9223372036854775808\\abc\\2147483647\\bcd\\1.1\\-3.4028235E+38\\False",
        },
    ];

    private static readonly object[][] GetStringSeparatedStringData =
    [
        new object[]
        {
            new object[] { true, ushort.MinValue, true },
            "True], [0], [True",
        },
        new object[]
        {
            new object[] { long.MinValue, false, float.MaxValue },
            "-9223372036854775808], [False], [3.4028235E+38",
        },
        new object[]
        {
            new object[] { byte.MinValue, int.MaxValue, double.MinValue },
            "0], [2147483647], [-1.7976931348623157E+308",
        },
    ];

    private static readonly object[][] GetStringSeparatedStringForLastThreeElementsData =
    [
        new object[]
        {
            "::",
            new string[] { "abc", "bcd", "cde" },
            "abc::bcd::cde",
        },
        new object[]
        {
            "+++",
            new string[] { "abc", "bcd", "cde", "def" },
            "bcd+++cde+++def",
        },
        new object[]
        {
            "ABC",
            new string[] { "abc", "bcd", "cde", "def", "efg" },
            "cdeABCdefABCefg",
        },
    ];

    [TestCaseSource(nameof(GetCommaSeparatedStringData))]
    public void GetCommaSeparatedString_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        string[] values = (string[])data[0];
        string expectedResult = (string)data[1];

        // Act
        string actualResult = JoiningStrings.GetCommaSeparatedString(values);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetColonSeparatedStringData))]
    public void GetColonSeparatedString_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        string[] values = (string[])data[0];
        string expectedResult = (string)data[1];

        // Act
        string actualResult = JoiningStrings.GetColonSeparatedString(values);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetCommaSeparatedStringWithoutFirstElementData))]
    public void GetCommaSeparatedStringWithoutFirstElement_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        string[] values = (string[])data[0];
        string expectedResult = (string)data[1];

        // Act
        string actualResult = JoiningStrings.GetCommaSeparatedStringWithoutFirstElement(values);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetHyphenSeparatedStringWithoutFirstAndLastElementsData))]
    public void GetHyphenSeparatedStringWithoutFirstAndLastElements_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        string[] values = (string[])data[0];
        string expectedResult = (string)data[1];

        // Act
        string actualResult = JoiningStrings.GetHyphenSeparatedStringWithoutFirstAndLastElements(values);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetPlusSeparatedStringData))]
    public void GetPlusSeparatedString_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        IEnumerable<string> values = (IEnumerable<string>)data[0];
        string expectedResult = (string)data[1];

        // Act
        string actualResult = JoiningStrings.GetPlusSeparatedString(values);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetBackslashSeparatedStringData))]
    public void GetBackslashSeparatedString_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        IEnumerable<object> values = (IEnumerable<object>)data[0];
        string expectedResult = (string)data[1];

        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        // Act
        string actualResult = JoiningStrings.GetBackslashSeparatedString(values);

        // Tear down
        CultureInfo.CurrentCulture = currentCulture;

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetStringSeparatedStringData))]
    public void GetStringSeparatedString_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        object[] values = (object[])data[0];
        string expectedResult = (string)data[1];

        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        // Act
        string actualResult = JoiningStrings.GetStringSeparatedString(values);

        // Tear down
        CultureInfo.CurrentCulture = currentCulture;

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCaseSource(nameof(GetStringSeparatedStringForLastThreeElementsData))]
    public void GetStringSeparatedStringForLastThreeElements_ValuesAreValid_ReturnsResult(object[] data)
    {
        // Arrange
        string separator = (string)data[0];
        string[] values = (string[])data[1];
        string expectedResult = (string)data[2];

        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        // Act
        string actualResult = JoiningStrings.GetStringSeparatedStringForLastThreeElements(separator, values);

        // Tear down
        CultureInfo.CurrentCulture = currentCulture;

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}

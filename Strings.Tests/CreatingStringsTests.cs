using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests;

[TestFixture]
public sealed class CreatingStringsTests
{
    [TestCase("", ExpectedResult = "")]
    [TestCase("abc", ExpectedResult = "abc")]
    [TestCase("ABCDEF", ExpectedResult = "ABCDEF")]
    public string ReturnNewString_ParametersAreValid_ReturnsResult(string str)
    {
        // Act
        return CreatingStrings.ReturnNewString(str);
    }

    [TestCase('a', 0, ExpectedResult = "")]
    [TestCase('a', 1, ExpectedResult = "a")]
    [TestCase('b', 2, ExpectedResult = "bb")]
    [TestCase('c', 3, ExpectedResult = "ccc")]
    public string GetStringWithRepeatedChars_ParametersAreValid_ReturnsResult(char c, int count)
    {
        // Act
        return CreatingStrings.ReturnStringWithRepeatedChars(c, count);
    }

    [TestCase(new char[0], ExpectedResult = "")]
    [TestCase(new char[] { 'a' }, ExpectedResult = "a")]
    [TestCase(new char[] { 'a', 'b' }, ExpectedResult = "ab")]
    [TestCase(new char[] { 'a', 'b', 'c' }, ExpectedResult = "abc")]
    public string GetStringFromCharArray_ParametersAreValid_ReturnsResult(char[] value)
    {
        // Act
        return CreatingStrings.ReturnStringFromCharArray(value);
    }

    [TestCase(new char[] { 'a', 'b', 'c' }, 0, 1, ExpectedResult = "a")]
    [TestCase(new char[] { 'a', 'b', 'c' }, 0, 2, ExpectedResult = "ab")]
    [TestCase(new char[] { 'a', 'b', 'c' }, 0, 3, ExpectedResult = "abc")]
    [TestCase(new char[] { 'a', 'b', 'c' }, 1, 1, ExpectedResult = "b")]
    [TestCase(new char[] { 'a', 'b', 'c' }, 1, 2, ExpectedResult = "bc")]
    [TestCase(new char[] { 'a', 'b', 'c' }, 2, 1, ExpectedResult = "c")]
    public string GetStringFromCharArray_ParametersAreValid_ReturnsResult(char[] value, int startIndex, int length)
    {
        // Act
        return CreatingStrings.ReturnStringFromCharArray(value, startIndex, length);
    }
}

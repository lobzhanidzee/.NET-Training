using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests;

[TestFixture]
public sealed class UsingIndexerTests
{
    [TestCase("Abcdefghijk", ExpectedResult = 'A')]
    [TestCase("0123456789", ExpectedResult = '0')]
    public char GetFirstChar_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetFirstChar(str);
    }

    [TestCase("aBcdefghijk", ExpectedResult = 'B')]
    [TestCase("0123456789", ExpectedResult = '1')]
    public char GetSecondChar_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetSecondChar(str);
    }

    [TestCase("abCdefghijk", ExpectedResult = 'C')]
    [TestCase("0123456789", ExpectedResult = '2')]
    public char GetThirdChar_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetThirdChar(str);
    }

    [TestCase("abCdefghijK", ExpectedResult = 'K')]
    [TestCase("0123456789", ExpectedResult = '9')]
    public char GetLastChar_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetLastChar(str);
    }

    [TestCase("abcdefghiJk", ExpectedResult = 'J')]
    [TestCase("0123456789", ExpectedResult = '8')]
    public char GetNextToLastChar_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetNextToLastChar(str);
    }

    [TestCase("abcdefghIjk", ExpectedResult = 'I')]
    [TestCase("0123456789", ExpectedResult = '7')]
    public char GetThirdCharFromEnd_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetThirdCharFromEnd(str);
    }

    [TestCase("Abcdefghijk", 1, ExpectedResult = 'A')]
    [TestCase("0123456789", 2, ExpectedResult = '1')]
    [TestCase("abCdefghijk", 3, ExpectedResult = 'C')]
    [TestCase("0123456789", 4, ExpectedResult = '3')]
    public char GetNthChar_ParameterIsValid_ReturnsResult(string str, int n)
    {
        // Act
        return UsingIndexer.GetNthChar(str, n);
    }

    [TestCase("abcdefghijK", 1, ExpectedResult = 'K')]
    [TestCase("0123456789", 2, ExpectedResult = '8')]
    [TestCase("abCdefghIjk", 3, ExpectedResult = 'I')]
    [TestCase("0123456789", 4, ExpectedResult = '6')]
    public char GetNthCharFromEnd_ParameterIsValid_ReturnsResult(string str, int n)
    {
        // Act
        return UsingIndexer.GetNthCharFromEnd(str, n);
    }

    [TestCase("abCdefghijK", ExpectedResult = 'K')]
    [TestCase("0123456789", ExpectedResult = '9')]
    public char GetLastCharUsingLength_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetLastCharUsingLength(str);
    }

    [TestCase("abcdefghiJk", ExpectedResult = 'J')]
    [TestCase("0123456789", ExpectedResult = '8')]
    public char GetNextToLastCharUsingLength_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetNextToLastCharUsingLength(str);
    }

    [TestCase("abcdefGhijk", ExpectedResult = 'G')]
    [TestCase("0123456789", ExpectedResult = '5')]
    public char GetFifthCharFromEndUsingLength_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingIndexer.GetFifthCharFromEndUsingLength(str);
    }

    [TestCase("abcdefghijK", 1, ExpectedResult = 'K')]
    [TestCase("0123456789", 2, ExpectedResult = '8')]
    [TestCase("abCdefghIjk", 3, ExpectedResult = 'I')]
    [TestCase("0123456789", 4, ExpectedResult = '6')]
    public char GetNthCharFromEndUsingLength_ParameterIsValid_ReturnsResult(string str, int n)
    {
        // Act
        return UsingIndexer.GetNthCharFromEndUsingLength(str, n);
    }

    [TestCase("07K4M1DZ-BZ", '7', '4', 'Z')]
    [TestCase("19K06M1DI-AZ", '9', '6', 'I')]
    [TestCase("31K008M1DJ-KZ", '1', '8', 'J')]
    public void GetSpecialCodes(string serialNumber, char expectedCode1, char expectedCode2, char expectedCode3)
    {
        // Act
        UsingIndexer.GetSpecialCodes(serialNumber, out char code1, out char code2, out char code3);

        // Assert
        Assert.That(expectedCode1, Is.EqualTo(code1));
        Assert.That(expectedCode2, Is.EqualTo(code2));
        Assert.That(expectedCode3, Is.EqualTo(code3));
    }
}

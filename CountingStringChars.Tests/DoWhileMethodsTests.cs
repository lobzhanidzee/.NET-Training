using NUnit.Framework;

namespace CountingStringChars.Tests;

[TestFixture]
public sealed class DoWhileMethodsTests
{
    [Test]
    public void GetNumbersCount_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetDigitCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase(" a b ", ExpectedResult = 0)]
    [TestCase("a1b", ExpectedResult = 1)]
    [TestCase(" a 1 b ", ExpectedResult = 1)]
    [TestCase(" 1 a 2 b 3 ", ExpectedResult = 3)]
    [TestCase("1a2b3c4", ExpectedResult = 4)]
    [TestCase(" 1 a 2 b 3 c 4 ", ExpectedResult = 4)]
    public int GetNumbersCount_ParametersAreValid_ReturnsCharsCount(string str)
    {
        // Act
        return DoWhileMethods.GetDigitCount(str);
    }

    [Test]
    public void GetNumbersCountRecursive_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetDigitCountRecursive(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase(" a b ", ExpectedResult = 0)]
    [TestCase("a1b", ExpectedResult = 1)]
    [TestCase(" a 1 b ", ExpectedResult = 1)]
    [TestCase(" 1 a 2 b 3 ", ExpectedResult = 3)]
    [TestCase("1a2b3c4", ExpectedResult = 4)]
    [TestCase(" 1 a 2 b 3 c 4 ", ExpectedResult = 4)]
    public int GetNumbersCountRecursive_ParametersAreValid_ReturnsCharsCount(string str)
    {
        // Act
        return DoWhileMethods.GetDigitCountRecursive(str);
    }

    [Test]
    public void GetLetterCount_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetLetterCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase(" a ", ExpectedResult = 1)]
    [TestCase("12a34", ExpectedResult = 1)]
    [TestCase("^a_b$", ExpectedResult = 2)]
    [TestCase("12345a@b#c$d e67890", ExpectedResult = 5)]
    public int GetLetterCount_ParametersAreValid_ReturnsCharsCount(string str)
    {
        // Act
        return DoWhileMethods.GetLetterCount(str);
    }

    [Test]
    public void GetLetterCountRecursive_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetLetterCountRecursive(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase(" a ", ExpectedResult = 1)]
    [TestCase("12a34", ExpectedResult = 1)]
    [TestCase("^a_b$", ExpectedResult = 2)]
    [TestCase("12345a@b#c$d e67890", ExpectedResult = 5)]
    public int GetLetterCountRecursive_ParametersAreValid_ReturnsCharsCount(string str)
    {
        // Act
        return DoWhileMethods.GetLetterCountRecursive(str);
    }
}

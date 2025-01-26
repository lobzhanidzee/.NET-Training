using NUnit.Framework;

namespace CountingStringChars.Tests;

[TestFixture]
public sealed class WhileMethodsTests
{
    [Test]
    public void GetSpaceCount_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => WhileMethods.GetSpaceCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase("abc", ExpectedResult = 0)]
    [TestCase("a b", ExpectedResult = 1)]
    [TestCase(" a b", ExpectedResult = 2)]
    [TestCase("a b ", ExpectedResult = 2)]
    [TestCase(" a b ", ExpectedResult = 3)]
    [TestCase("a b c", ExpectedResult = 2)]
    [TestCase(" a b c ", ExpectedResult = 4)]
    public int GetSpaceCount_ParameterIsValid_ReturnsCharsCount(string str)
    {
        // Act
        return WhileMethods.GetSpaceCount(str);
    }

    [Test]
    public void GetSpaceCountRecursive_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => WhileMethods.GetSpaceCountRecursive(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase("abc", ExpectedResult = 0)]
    [TestCase("a b", ExpectedResult = 1)]
    [TestCase(" a b", ExpectedResult = 2)]
    [TestCase("a b ", ExpectedResult = 2)]
    [TestCase(" a b ", ExpectedResult = 3)]
    [TestCase("a b c", ExpectedResult = 2)]
    [TestCase(" a b c ", ExpectedResult = 4)]
    public int GetSpaceCountRecursive_ParameterIsValid_ReturnsCharsCount(string str)
    {
        // Act
        return WhileMethods.GetSpaceCountRecursive(str);
    }

    [Test]
    public void GetPunctuationCount_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => WhileMethods.GetPunctuationCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase(">a<", ExpectedResult = 0)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase("abc", ExpectedResult = 0)]
    [TestCase("a,b", ExpectedResult = 1)]
    [TestCase(",a.b", ExpectedResult = 2)]
    [TestCase("a:b,", ExpectedResult = 2)]
    [TestCase(":a,b.", ExpectedResult = 3)]
    [TestCase("a[b]c", ExpectedResult = 2)]
    [TestCase("/a&b`c\\", ExpectedResult = 3)]
    public int GetPunctuationCount_ParameterIsValid_ReturnsCharsCount(string str)
    {
        // Act
        return WhileMethods.GetPunctuationCount(str);
    }

    [Test]
    public void GetPunctuationCountRecursive_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => WhileMethods.GetPunctuationCountRecursive(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase(">a<", ExpectedResult = 0)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase("abc", ExpectedResult = 0)]
    [TestCase("a,b", ExpectedResult = 1)]
    [TestCase(",a.b", ExpectedResult = 2)]
    [TestCase("a:b,", ExpectedResult = 2)]
    [TestCase(":a,b.", ExpectedResult = 3)]
    [TestCase("a[b]c", ExpectedResult = 2)]
    [TestCase("/a&b`c\\", ExpectedResult = 3)]
    public int GetPunctuationCountRecursive_ParameterIsValid_ReturnsCharsCount(string str)
    {
        // Act
        return WhileMethods.GetPunctuationCountRecursive(str);
    }
}

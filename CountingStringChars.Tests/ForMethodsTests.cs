using NUnit.Framework;

namespace CountingStringChars.Tests;

[TestFixture]
public sealed class ForMethodsTests
{
    [Test]
    public void GetCharCount_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => ForMethods.GetCharCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase("ab", ExpectedResult = 2)]
    [TestCase("abc", ExpectedResult = 3)]
    public int GetCharCount_ParameterIsValid_ReturnsCharsCount(string str)
    {
        // Act
        return ForMethods.GetCharCount(str);
    }

    [Test]
    public void GetCharCountRecursive_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => ForMethods.GetCharCountRecursive(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase("ab", ExpectedResult = 2)]
    [TestCase("abc", ExpectedResult = 3)]
    public int GetCharCountRecursive_ParameterIsValid_ReturnsCharsCount(string str)
    {
        // Act
        return ForMethods.GetCharCountRecursive(str);
    }

    [Test]
    public void GetUpperCharsCount_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => ForMethods.GetUpperCharCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase("A", ExpectedResult = 1)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase("Ab", ExpectedResult = 1)]
    [TestCase("aB", ExpectedResult = 1)]
    [TestCase("AB", ExpectedResult = 2)]
    [TestCase("abc", ExpectedResult = 0)]
    [TestCase("Abc", ExpectedResult = 1)]
    [TestCase("aBc", ExpectedResult = 1)]
    [TestCase("abC", ExpectedResult = 1)]
    [TestCase("ABc", ExpectedResult = 2)]
    [TestCase("aBC", ExpectedResult = 2)]
    [TestCase("ABC", ExpectedResult = 3)]
    public int GetUpperCharsCount_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return ForMethods.GetUpperCharCount(str);
    }

    [Test]
    public void GetUpperCharCountRecursive_StrIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => ForMethods.GetUpperCharCountRecursive(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 0)]
    [TestCase("A", ExpectedResult = 1)]
    [TestCase("ab", ExpectedResult = 0)]
    [TestCase("Ab", ExpectedResult = 1)]
    [TestCase("aB", ExpectedResult = 1)]
    [TestCase("AB", ExpectedResult = 2)]
    [TestCase("abc", ExpectedResult = 0)]
    [TestCase("Abc", ExpectedResult = 1)]
    [TestCase("aBc", ExpectedResult = 1)]
    [TestCase("abC", ExpectedResult = 1)]
    [TestCase("ABc", ExpectedResult = 2)]
    [TestCase("aBC", ExpectedResult = 2)]
    [TestCase("ABC", ExpectedResult = 3)]
    public int GetUpperCharCountRecursive_ParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return ForMethods.GetUpperCharCountRecursive(str);
    }
}

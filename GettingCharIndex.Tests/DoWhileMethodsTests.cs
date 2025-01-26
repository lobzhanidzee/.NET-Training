using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace GettingCharIndex.Tests;
[TestFixture]
public sealed class DoWhileMethodsTests
{
    [Test]
    public void GetIndexOfChar_NullString_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetIndexOfChar(null, 'a'));
    }

    [TestCase("", 'a', ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', ExpectedResult = 0)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'c', ExpectedResult = 2)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'x', ExpectedResult = 23)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'y', ExpectedResult = 24)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', ExpectedResult = 25)]
    [TestCase("abcefghijklmnoprstquvwxyzabcefghijklmnoprstquvwxyz", 'd', ExpectedResult = -1)]
    public int GetIndexOfChar_NonEmptyString_ReturnsPosition(string str, char value)
    {
        // Act
        return DoWhileMethods.GetIndexOfChar(str, value);
    }

    [Test]
    public void GetIndexOfCharStartIndexCount_NullString_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetIndexOfChar(null, 'a', 0, 0));
    }

    [Test]
    public void GetIndexOfCharStartIndexCount_StartIndexLessZero_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => DoWhileMethods.GetIndexOfChar(string.Empty, 'a', -1, 0));
    }

    [Test]
    public void GetIndexOfCharStartIndexCount_StartIndexGreaterStringLength_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => DoWhileMethods.GetIndexOfChar(string.Empty, 'a', 1, 0));
    }

    [Test]
    public void GetIndexOfCharStartIndexCount_CountLessZero_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => DoWhileMethods.GetIndexOfChar(string.Empty, 'a', 0, -1));
    }

    [TestCase("", 'a', 0, 0, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 0, 52, ExpectedResult = 0)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 0, 26, ExpectedResult = 0)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 1, 51, ExpectedResult = 26)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 1, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 1, 26, ExpectedResult = 26)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 27, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 0, 52, ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 0, 28, ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 0, 26, ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 1, 26, ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 1, 25, ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 2, 26, ExpectedResult = 27)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 2, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 0, 52, ExpectedResult = 25)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 0, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 0, 26, ExpectedResult = 25)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 26, 26, ExpectedResult = 51)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 26, 25, ExpectedResult = -1)]
    [TestCase("abcefghijklmnoprstquvwxyzabcefghijklmnoprstquvwxyz", 'd', 0, 50, ExpectedResult = -1)]
    public int GetIndexOfChar_NonEmptyString_ReturnsPosition2(string str, char value, int startIndex, int count)
    {
        // Act
        return DoWhileMethods.GetIndexOfChar(str, value, startIndex, count);
    }

    [Test]
    public void GetLastIndexOfChar_NullString_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetLastIndexOfChar(null, 'a'));
    }

    [TestCase("", 'a', ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', ExpectedResult = 26)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', ExpectedResult = 27)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'c', ExpectedResult = 28)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'x', ExpectedResult = 49)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'y', ExpectedResult = 50)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', ExpectedResult = 51)]
    [TestCase("abcefghijklmnoprstquvwxyzabcefghijklmnoprstquvwxyz", 'd', ExpectedResult = -1)]
    public int GetLastIndexOfChar_NonEmptyString_ReturnsPosition(string str, char value)
    {
        // Act
        return DoWhileMethods.GetLastIndexOfChar(str, value);
    }

    [Test]
    public void GetLastIndexOfCharStartIndexCount_NullString_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetLastIndexOfChar(null, 'a', 0, 0));
    }

    [Test]
    public void GetLastIndexOfCharStartIndexCount_StartIndexLessZero_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => DoWhileMethods.GetLastIndexOfChar(string.Empty, 'a', -1, 0));
    }

    [Test]
    public void GetLastIndexOfCharStartIndexCount_StartIndexGreaterStringLength_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => DoWhileMethods.GetLastIndexOfChar(string.Empty, 'a', 1, 0));
    }

    [Test]
    public void GetLastIndexOfCharStartIndexCount_CountLessZero_ThrowsException()
    {
        // Act
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => DoWhileMethods.GetLastIndexOfChar(string.Empty, 'a', 0, -1));
    }

    [TestCase("", 'a', 0, 0, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 0, 52, ExpectedResult = 26)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 0, 27, ExpectedResult = 26)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 0, 26, ExpectedResult = 0)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 1, 26, ExpectedResult = 26)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 1, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', 27, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 0, 52, ExpectedResult = 27)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 0, 28, ExpectedResult = 27)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 0, 26, ExpectedResult = 1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 2, 27, ExpectedResult = 27)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 2, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', 28, 24, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 0, 52, ExpectedResult = 51)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 0, 51, ExpectedResult = 25)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 0, 25, ExpectedResult = -1)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 26, 26, ExpectedResult = 51)]
    [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', 26, 25, ExpectedResult = -1)]
    [TestCase("abcefghijklmnoprstquvwxyzabcefghijklmnoprstquvwxyz", 'd', 0, 50, ExpectedResult = -1)]
    public int GetLastIndexOfCharStartIndexCount_NonEmptyString_ReturnsPosition(string str, char value, int startIndex, int count)
    {
        // Act
        return DoWhileMethods.GetLastIndexOfChar(str, value, startIndex, count);
    }
}

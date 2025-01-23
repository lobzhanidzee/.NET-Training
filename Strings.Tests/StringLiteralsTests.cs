using NUnit.Framework;

// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo
namespace Strings.Tests;

[TestFixture]
public sealed class StringLiteralsTests
{
    [Test]
    public void ReturnAbcStringLiteral()
    {
        // Act
        string actualResult = StringLiterals.ReturnAbcStringLiteral();

        // Assert
        Assert.That("abc", Is.EqualTo(actualResult));
    }

    [Test]
    public void ReturnAbcdefStringLiteral()
    {
        // Act
        string actualResult = StringLiterals.ReturnAbcdefStringLiteral();

        // Assert
        Assert.That("ABCDEF", Is.EqualTo(actualResult));
    }

    [Test]
    public void ReturnEmptyString()
    {
        // Act
        string result = StringLiterals.ReturnEmptyString();

        // Assert
        Assert.That(string.Empty, Is.EqualTo(result));
    }

    [Test]
    public void ReturnFilePathStringLiteral1()
    {
        // Act
        string actualResult = StringLiterals.ReturnFilePathStringLiteral1();

        // Assert
        Assert.That("c:\\documents\\files\\myfile0234.txt", Is.EqualTo(actualResult));
    }

    [Test]
    public void ReturnFilePathStringLiteral2()
    {
        // Act
        string actualResult = StringLiterals.ReturnFilePathStringLiteral2();

        // Assert
        Assert.That("c:\\users\\myuser\\documents\\my-video-file.avi", Is.EqualTo(actualResult));
    }

    [Test]
    public void ReturnFilePathVerbatimStringLiteral1()
    {
        // Act
        string actualResult = StringLiterals.ReturnFilePathVerbatimStringLiteral1();

        // Assert
        Assert.That(@"c:\documents\files\datafile0582.txt", Is.EqualTo(actualResult));
    }

    [Test]
    public void ReturnFilePathVerbatimStringLiteral2()
    {
        // Act
        string actualResult = StringLiterals.ReturnFilePathVerbatimStringLiteral2();

        // Assert
        Assert.That(@"c:\users\myuser\documents\my-audio-file.mp3", Is.EqualTo(actualResult));
    }
}

// ReSharper disable IdentifierTypo
global using NUnit.Framework;

namespace StaticMethods.Tests;

[TestFixture]
public class ReturningMethodsTests
{
    [Test]
    public void ReturnInt_ReturnsInteger()
    {
        // Act
        int actualResult = ReturningMethods.ReturnInt();

        // Assert
        Assert.That(actualResult, Is.EqualTo(-1234567));
    }

    [Test]
    public void ReturnUnsignedInt_ReturnsUnsignedInteger()
    {
        // Act
        uint actualResult = ReturningMethods.ReturnUnsignedInt();

        // Assert
        Assert.That(actualResult, Is.EqualTo(1234567u));
    }

    [Test]
    public void ReturnLong_ReturnsLongInteger()
    {
        // Act
        long actualResult = ReturningMethods.ReturnLong();

        // Assert
        Assert.That(actualResult, Is.EqualTo(-987654321L));
    }

    [Test]
    public void ReturnUnsignedLong_ReturnsUnsignedLongInteger()
    {
        // Act
        ulong actualResult = ReturningMethods.ReturnUnsignedLong();

        // Assert
        Assert.That(actualResult, Is.EqualTo(987654321uL));
    }

    [Test]
    public void ReturnFloat_ReturnsFloat()
    {
        // Act
        float actualResult = ReturningMethods.ReturnFloat();

        // Assert
        Assert.That(actualResult, Is.EqualTo(1234.567f));
    }

    [Test]
    public void ReturnDouble_ReturnsDouble()
    {
        // Act
        double actualResult = ReturningMethods.ReturnDouble();

        // Assert
        Assert.That(actualResult, Is.EqualTo(-9876.54321));
    }

    [Test]
    public void ReturnDecimal_ReturnsDecimal()
    {
        // Act
        decimal actualResult = ReturningMethods.ReturnDecimal();

        // Assert
        Assert.That(actualResult, Is.EqualTo(-123456789.987654321m));
    }

    [Test]
    public void ReturnString_ReturnsString()
    {
        // Act
        string actualResult = ReturningMethods.ReturnString();

        // Assert
        Assert.That(actualResult, Is.EqualTo("Hello, world!"));
    }

    [Test]
    public void ReturnChar_ReturnsChar()
    {
        // Act
        char actualResult = ReturningMethods.ReturnChar();

        // Assert
        Assert.That(actualResult, Is.EqualTo('A'));
    }

    [Test]
    public void ReturnByte_ReturnsByte()
    {
        // Act
        byte actualResult = ReturningMethods.ReturnByte();

        // Assert
        Assert.That(actualResult, Is.EqualTo(0xAB));
    }

    [Test]
    public void ReturnBool_ReturnsBool()
    {
        // Act
        bool actualResult = ReturningMethods.ReturnBool();

        // Assert
        Assert.That(actualResult, Is.EqualTo(true));
    }
}

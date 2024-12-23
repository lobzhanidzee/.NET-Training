using NUnit.Framework;

namespace CompilerErrors.Tests;

[TestFixture]
public class CompilerErrorsTests
{
    [Test]
    public void CS0103_MyMethod_ReturnsInteger()
    {
        // Act
        int actualResult = CS0103.MyClass.MyMethod();

        // Assert
        Assert.That(actualResult, Is.EqualTo(534_947_886));
    }

    [Test]
    public void CS0117_MyMethod_ReturnsInteger()
    {
        // Act
        long actualResult = CS0117.MyClass.MyMethod();

        // Assert
        Assert.That(actualResult, Is.EqualTo(49_023_471L));
    }

    [Test]
    public void CS1501_MyMethod_ReturnsInteger()
    {
        // Act
        int actualResult = CS1501.MyClass.MyMethod();

        // Assert
        Assert.That(actualResult, Is.EqualTo(1_785_394));
    }

    [Test]
    public void CS1739_MyMethod_ReturnsInteger()
    {
        // Act
        int actualResult = CS1739.MyClass.MyMethod();

        // Assert
        Assert.That(actualResult, Is.EqualTo(9_389_572));
    }

    [Test]
    public void CS7036_MyMethod_ReturnsInteger()
    {
        // Act
        int actualResult = CS7036.MyClass.MyMethod();

        // Assert
        Assert.That(actualResult, Is.EqualTo(5_689_375));
    }
}

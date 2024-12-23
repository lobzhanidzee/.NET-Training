global using NUnit.Framework;

namespace Bools.Tests;

[TestFixture]
public class BooleansTests
{
    [Test]
    public void ReturnTrue()
    {
        // Act
        var actualResult = Booleans.ReturnTrue();

        // Assert
        Assert.That(actualResult, Is.True);
    }

    [Test]
    public void ReturnFalse()
    {
        // Act
        var actualResult = Booleans.ReturnFalse();

        // Assert
        Assert.That(actualResult, Is.False);
    }
}

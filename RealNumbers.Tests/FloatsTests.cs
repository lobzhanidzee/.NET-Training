global using NUnit.Framework;

namespace RealNumbers.Tests;

[TestFixture]
public class FloatsTests
{
    [Test]
    public void ReturnFloat31_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat31();

        // Assert
        Assert.That(result, Is.EqualTo(0.0f));
    }

    [Test]
    public void ReturnFloat32_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat32();

        // Assert
        Assert.That(result, Is.EqualTo(1.01f));
    }

    [Test]
    public void ReturnFloat33_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat33();

        // Assert
        Assert.That(result, Is.EqualTo(-0.01f));
    }

    [Test]
    public void ReturnFloat34_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat34();

        // Assert
        Assert.That(result, Is.EqualTo(1_048_294_829_438_549_029_840_452_834.109_492_298_482f));
    }

    [Test]
    public void ReturnFloat35_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat35();

        // Assert
        Assert.That(result, Is.EqualTo(-30_492_996_837_502_378_502_387_459_850_243.942_692_284_652_825f));
    }

    [Test]
    public void ReturnFloat36_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat36();

        // Assert
        Assert.That(result, Is.EqualTo(-0.000_000_000_000_000_000_000_000_000_000_000_000_000_123f));
    }

    [Test]
    public void ReturnFloat37_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat37();

        // Assert
        Assert.That(result, Is.EqualTo(-1.23E-40f));
    }

    [Test]
    public void ReturnFloat38_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat38();

        // Assert
        Assert.That(result, Is.EqualTo(1.04829482E+27f));
    }

    [Test]
    public void ReturnFloat39_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat39();

        // Assert
        Assert.That(result, Is.EqualTo(-3.04929971E+31f));
    }

    [Test]
    public void ReturnFloat310_ReturnsFloat()
    {
        // Act
        float result = Floats.ReturnFloat310();

        // Assert
        Assert.That(result, Is.EqualTo(0.7f));
    }
}

using NUnit.Framework;

namespace TollCalculator.Tests;

[TestFixture]
public class TaxiTests
{
    [TestCase(1, 0)]
    [TestCase(2.5, 1)]
    [TestCase(2.5, 2)]
    [TestCase(3, 3)]
    public void Taxi_ConstructorWithParameters_ReturnNewCarObject(decimal baseToll, int passengers)
    {
        var taxi = new Taxi(baseToll, passengers);
        Assert.That(taxi.BaseToll == baseToll);
        Assert.That(taxi.Passengers == passengers);
    }

    [TestCase(-1)]
    [TestCase(-2.5)]
    public void Taxi_ConstructorWithParameters_BaseTollIsLessThanZero_ThrowsArgumentOutOfRangeException(
        decimal baseToll)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new Taxi(baseToll, default);
            });
    }

    [TestCase(-10)]
    [TestCase(-4)]
    public void Taxi_ConstructorWithParameters_PassengersIsLessThanZero_ThrowsArgumentOutOfRangeException(
        int passengers)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new Taxi(default, passengers);
            });
    }
}

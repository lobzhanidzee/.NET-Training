using NUnit.Framework;

namespace TollCalculator.Tests;

[TestFixture]
public class BusTests
{
    [TestCase(1, 10, 0)]
    [TestCase(2.5, 20, 1)]
    [TestCase(2.5, 30, 2)]
    [TestCase(3, 40, 13)]
    public void Bus_ConstructorWithParameters_ReturnNewCarObject(decimal baseToll, int capacity, int passengers)
    {
        var bus = new Bus(baseToll, capacity, passengers);
        Assert.That(bus.BaseToll == baseToll);
        Assert.That(bus.Capacity == capacity);
        Assert.That(bus.Passengers == passengers);
    }

    [TestCase(-1)]
    [TestCase(-2.5)]
    public void Bus_ConstructorWithParameters_BaseTollIsLessThanZero_ThrowsArgumentOutOfRangeException(decimal baseToll)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new Bus(baseToll, 1, default);
            });
    }

    [TestCase(-10)]
    [TestCase(0)]
    public void Bus_ConstructorWithParameters_CapacityIsLessThanOrEqualsZero_ThrowsArgumentOutOfRangeException(
        int capacity)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new Bus(default, capacity, default);
            });
    }

    [TestCase(-10)]
    [TestCase(-1)]
    public void Bus_ConstructorWithParameters_PassengersIsLessThanZero_ThrowsArgumentOutOfRangeException(int passengers)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new Bus(default, 1, passengers);
            });
    }
}

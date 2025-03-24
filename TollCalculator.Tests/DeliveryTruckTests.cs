using NUnit.Framework;

namespace TollCalculator.Tests;

[TestFixture]
public class DeliveryTruckTests
{
    [TestCase(10, 1000)]
    [TestCase(10, 5000)]
    public void DeliveryTruck_ConstructorWithParameters_ReturnNewCarObject(decimal baseToll, int grossWeightClass)
    {
        var deliveryTruck = new DeliveryTruck(baseToll, grossWeightClass);
        Assert.That(deliveryTruck.BaseToll == baseToll);
        Assert.That(deliveryTruck.GrossWeightClass == grossWeightClass);
    }

    [TestCase(-1)]
    [TestCase(-2.5)]
    public void Car_ConstructorWithParameters_BaseTollIsLessThanZero_ThrowsArgumentOutOfRangeException(decimal baseToll)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new DeliveryTruck(baseToll, 1000);
            });
    }

    [TestCase(-10)]
    [TestCase(0)]
    public void Car_ConstructorWithParameters_PassengersIsLessThanOrEqualsZero_ThrowsArgumentOutOfRangeException(
        int grossWeightClass)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () =>
            {
                _ = new DeliveryTruck(default, grossWeightClass);
            });
    }
}

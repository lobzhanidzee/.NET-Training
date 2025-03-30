using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace TollCalculator.Tests;

public class VehicleTests
{
    [Test]
    public void Calculate_Method_Invocation_Test()
    {
        var mock = new Mock<Vehicle>();

        _ = mock.Protected().Setup<decimal>("Calculate");

        Vehicle vehicle = mock.Object;

        _ = vehicle.CalculateToll(default, default);

        mock.Protected().Verify("Calculate", Times.Once());
    }

    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForMoqTests))]
    public decimal Calculate_For_Vehicle_Class_Test(decimal baseToll, DateTime dateTime, TrafficDirection direction)
    {
        var mock = new Mock<Vehicle>();

        _ = mock.Protected().Setup<decimal>("Calculate").Returns(baseToll);

        Vehicle vehicle = mock.Object;

        return vehicle.CalculateToll(dateTime, direction);
    }

    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForCalculateToll))]
    public decimal CalculateToll(Vehicle vehicle, DateTime dateTime, TrafficDirection direction) =>
        vehicle.CalculateToll(dateTime, direction);
}

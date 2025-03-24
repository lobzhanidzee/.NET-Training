using NUnit.Framework;

namespace TollCalculator.Tests;

public static class TestCasesSource
{
    public static IEnumerable<TestCaseData> TestCasesForCalculateToll
    {
        get
        {
            yield return new TestCaseData(
                new Taxi(3.5m, 0),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(6m);
            yield return new TestCaseData(
                new Taxi(3.5m, 1),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(5.25m);
            yield return new TestCaseData(
                new Taxi(3.5m, 2),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(4.5m);
            yield return new TestCaseData(
                new Taxi(3.5m, 3),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(3.75m);
            yield return new TestCaseData(
                new Taxi(3.5m, 0),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(8m);
            yield return new TestCaseData(
                new Taxi(3.5m, 1),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(7m);
            yield return new TestCaseData(
                new Taxi(3.5m, 2),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(6m);
            yield return new TestCaseData(
                new Taxi(3.5m, 3),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(5m);
            yield return new TestCaseData(
                new Taxi(3.5m, 0),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(4m);
            yield return new TestCaseData(
                new Taxi(3.5m, 1),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(3.5m);
            yield return new TestCaseData(
                new Taxi(3.5m, 2),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(3m);
            yield return new TestCaseData(
                new Taxi(3.5m, 3),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(2.5m);
            yield return new TestCaseData(
                new Taxi(3.5m, 0),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(4m);
            yield return new TestCaseData(
                new Taxi(3.5m, 1),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(3.5m);
            yield return new TestCaseData(
                new Taxi(3.5m, 2),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(3m);
            yield return new TestCaseData(
                new Taxi(3.5m, 3),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(2.5m);

            yield return new TestCaseData(
                new Bus(5m, 40, 4),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(10.5m);
            yield return new TestCaseData(
                new Bus(5m, 40, 10),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(10.5m);
            yield return new TestCaseData(
                new Bus(5m, 40, 38),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(6m);
            yield return new TestCaseData(
                new Bus(5m, 40, 20),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(7.5m);
            yield return new TestCaseData(
                new Bus(5m, 40, 4),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(14m);
            yield return new TestCaseData(
                new Bus(5m, 40, 10),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(14m);
            yield return new TestCaseData(
                new Bus(5m, 40, 38),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(8m);
            yield return new TestCaseData(
                new Bus(5m, 40, 20),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(10m);
            yield return new TestCaseData(
                new Bus(5m, 40, 4),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(7m);
            yield return new TestCaseData(
                new Bus(5m, 40, 10),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(7m);
            yield return new TestCaseData(
                new Bus(5m, 40, 38),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(4m);
            yield return new TestCaseData(
                new Bus(5m, 40, 20),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(5m);
            yield return new TestCaseData(
                new Bus(5m, 40, 4),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(7m);
            yield return new TestCaseData(
                new Bus(5m, 40, 10),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(7m);
            yield return new TestCaseData(
                new Bus(5m, 40, 38),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(4m);
            yield return new TestCaseData(
                new Bus(5m, 40, 20),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(5m);

            yield return new TestCaseData(
                new DeliveryTruck(10m, 2500),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(12m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 3500),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(15m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 6000),
                new DateTime(2022, 12, 12, 15, 0, 0),
                TrafficDirection.Inbound).Returns(22.5m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 2500),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(16m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 3500),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(20m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 6000),
                new DateTime(2022, 12, 12, 9, 0, 0),
                TrafficDirection.Inbound).Returns(30m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 2500),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(8m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 3500),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(10m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 6000),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Inbound).Returns(15m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 2500),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(8m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 3500),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(10m);
            yield return new TestCaseData(
                new DeliveryTruck(10m, 6000),
                new DateTime(2022, 12, 11, 9, 0, 0),
                TrafficDirection.Outbound).Returns(15m);
        }
    }

    public static IEnumerable<TestCaseData> TestCasesForMoqTests
    {
        get
        {
            yield return new TestCaseData(2m, new DateTime(2022, 12, 12, 14, 0, 0), TrafficDirection.Inbound).Returns(
                3m);
            yield return new TestCaseData(3.5m, new DateTime(2022, 12, 12, 14, 0, 0), TrafficDirection.Inbound).Returns(
                5.25m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 12, 14, 0, 0), TrafficDirection.Inbound).Returns(
                7.5m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 12, 14, 0, 0), TrafficDirection.Inbound).Returns(
                15m);
            yield return new TestCaseData(
                2m,
                new DateTime(2022, 12, 12, 7, 0, 0),
                TrafficDirection.Inbound).Returns(4m);
            yield return new TestCaseData(3.5m, new DateTime(2022, 12, 12, 7, 0, 0), TrafficDirection.Inbound).Returns(
                7m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 12, 7, 0, 0), TrafficDirection.Inbound).Returns(
                10m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 12, 7, 0, 0), TrafficDirection.Inbound).Returns(
                20m);
            yield return new TestCaseData(2m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Outbound).Returns(
                4m);
            yield return new TestCaseData(
                3.5m,
                new DateTime(2022, 12, 12, 19, 0, 0),
                TrafficDirection.Outbound).Returns(7m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Outbound).Returns(
                10m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Outbound).Returns(
                20m);
            yield return new TestCaseData(2m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Inbound).Returns(
                2m);
            yield return new TestCaseData(3.5m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Inbound).Returns(
                3.5m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Inbound).Returns(
                5m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 12, 19, 0, 0), TrafficDirection.Inbound).Returns(
                10m);
            yield return new TestCaseData(2m, new DateTime(2022, 12, 11, 19, 0, 0), TrafficDirection.Inbound).Returns(
                2m);
            yield return new TestCaseData(3.5m, new DateTime(2022, 12, 11, 19, 0, 0), TrafficDirection.Inbound).Returns(
                3.5m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 11, 19, 0, 0), TrafficDirection.Inbound).Returns(
                5m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 11, 19, 0, 0), TrafficDirection.Inbound).Returns(
                10m);
            yield return new TestCaseData(2m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Inbound).Returns(
                1.5m);
            yield return new TestCaseData(3.5m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Inbound).Returns(
                2.625m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Inbound).Returns(
                3.75m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Inbound).Returns(
                7.5m);
            yield return new TestCaseData(2m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Outbound).Returns(
                1.5m);
            yield return new TestCaseData(
                3.5m,
                new DateTime(2022, 12, 12, 23, 0, 0),
                TrafficDirection.Outbound).Returns(2.625m);
            yield return new TestCaseData(5m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Outbound).Returns(
                3.75m);
            yield return new TestCaseData(10m, new DateTime(2022, 12, 12, 23, 0, 0), TrafficDirection.Outbound).Returns(
                7.5m);
        }
    }
}

using NUnit.Framework;

namespace TimeStruct.Tests;

[TestFixture]
public class TimeTests
{
    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForToString))]
    public void ToStringTests(Time time, string str)
    {
        Assert.That(str, Is.EqualTo(time.ToString()));
    }

    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForToStringThroughObject))]
    public void ToStringThroughObjectTests(object time)
    {
        Assert.That("TimeStruct.Time", Is.EqualTo(time.ToString()));
    }

    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForMinutesProperty))]
    public void MinutesPropertyGetTests(Time time, int minutes)
    {
        Assert.That(minutes, Is.EqualTo(time.Minutes));
    }

    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForHoursProperty))]
    public void HoursPropertyGetTests(Time time, int hour)
    {
        Assert.That(hour, Is.EqualTo(time.Hours));
    }

    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForTwoParametersCtor))]
    public void CtorWithTwoParametersTests(Time time, int hour, int minutes)
    {
        Assert.Multiple(
            () =>
            {
                Assert.That(hour, Is.EqualTo(time.Hours));
                Assert.That(minutes, Is.EqualTo(time.Minutes));
            });
    }

    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForOneParameterCtor))]
    public void CtorWithOneParameterTests(Time time, int hour, int minutes)
    {
        Assert.Multiple(
            () =>
            {
                Assert.That(hour, Is.EqualTo(time.Hours));
                Assert.That(minutes, Is.EqualTo(time.Minutes));
            });
    }

    [Test]
    [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForTwoParametersCtor))]
    public void DeconstructTests(Time time, int expectedHours, int expectedMinutes)
    {
        var (hours, minutes) = time;

        Assert.Multiple(
            () =>
            {
                Assert.That(expectedHours, Is.EqualTo(hours));
                Assert.That(expectedMinutes, Is.EqualTo(minutes));
            });
    }

    [Test]
    public void Time_ReadonlyHours_StructShouldBeImmutable()
    {
        var time = new Time(1, 15);

        Assert.Throws<ArgumentException>(
            () =>
            {
                var hoursProperty = typeof(Time).GetProperty("Hours") !;
                hoursProperty.SetValue(time, 2);
            });
    }

    [Test]
    public void Time_ReadonlyMinutes_StructShouldBeImmutable()
    {
        var time = new Time(1, 15);

        Assert.Throws<ArgumentException>(
            () =>
            {
                var minutesProperty = typeof(Time).GetProperty("Minutes") !;
                minutesProperty.SetValue(time, 30);
            });
    }
}

using NUnit.Framework;

namespace LeapYear.Tests;

[TestFixture]
public class YearTests
{
    [TestCase(2015)]
    [TestCase(1970)]
    [TestCase(2100)]
    [TestCase(1800)]
    [TestCase(1234)]
    public void IsLeapYear_ReturnFalse(int year)
    {
        bool actualResult = Year.IsLeapYear(year);

        Assert.That(actualResult, Is.False);
    }

    [TestCase(1996)]
    [TestCase(2000)]
    [TestCase(2020)]
    [TestCase(2008)]
    public void IsLeapYear_ReturnTrue(int year)
    {
        bool actualResult = Year.IsLeapYear(year);

        Assert.That(actualResult, Is.True);
    }
}

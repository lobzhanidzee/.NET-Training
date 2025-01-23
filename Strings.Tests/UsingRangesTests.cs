using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests;
[TestFixture]
public sealed class UsingRangesTests
{
    [TestCase("", ExpectedResult = "")]
    [TestCase("abcdefghijk", ExpectedResult = "abcdefghijk")]
    public string GetStringWithAllChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithAllChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "bcdefghijk")]
    public string GetStringWithoutFirstChar_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutFirstChar(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "cdefghijk")]
    public string GetStringWithoutTwoFirstChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutTwoFirstChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "defghijk")]
    public string GetStringWithoutThreeFirstChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutThreeFirstChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "abcdefghij")]
    public string GetStringWithoutLastChar_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutLastChar(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "abcdefghi")]
    public string GetStringWithoutTwoLastChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutTwoLastChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "abcdefgh")]
    public string GetStringWithoutThreeLastChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutThreeLastChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "bcdefghij")]
    public string GetStringWithoutFirstAndLastChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutFirstAndLastChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "cdefghi")]
    public string GetStringWithoutTwoFirstAndTwoLastChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutTwoFirstAndTwoLastChars(str);
    }

    [TestCase("abcdefghijk", ExpectedResult = "defgh")]
    public string GetStringWithoutThreeFirstAndThreeLastChars_StrIsValid_ReturnsResult(string str)
    {
        // Act
        return UsingRanges.GetStringWithoutThreeFirstAndThreeLastChars(str);
    }

    [TestCase("9M431Z0DDQLL75Q2", "9", "31", "DDQ", "75Q2")]
    [TestCase("1912784DKF007384", "1", "27", "DKF", "7384")]
    public void GetProductionCodeDetails_ParametersAreValid_ReturnsResult(string productionCode, string expectedRegionCode, string expectedLocationCode, string expectedDateCode, string expectedFactoryCode)
    {
        // Act
        UsingRanges.GetProductionCodeDetails(productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode);

        // Assert
        Assert.That(expectedRegionCode, Is.EqualTo(regionCode));
        Assert.That(expectedLocationCode, Is.EqualTo(locationCode));
        Assert.That(expectedDateCode, Is.EqualTo(dateCode));
        Assert.That(expectedFactoryCode, Is.EqualTo(factoryCode));
    }

    [TestCase("P2W12P1937A", "W", "12", "1937", "A")]
    [TestCase("P02K13P8732D", "K", "13", "8732", "D")]
    [TestCase("P002Z14P3573B", "Z", "14", "3573", "B")]
    public void GetSerialNumberDetails(string serialNumber, string expectedCountryCode, string expectedManufacturerCode, string expectedFactoryCode, string expectedStationCode)
    {
        // Act
        UsingRanges.GetSerialNumberDetails(serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode);

        // Assert
        Assert.That(expectedCountryCode, Is.EqualTo(countryCode));
        Assert.That(expectedManufacturerCode, Is.EqualTo(manufacturerCode));
        Assert.That(expectedFactoryCode, Is.EqualTo(factoryCode));
        Assert.That(expectedStationCode, Is.EqualTo(stationCode));
    }
}

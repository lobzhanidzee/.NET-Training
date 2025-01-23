using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace Strings.Tests;

[TestFixture]
public sealed class CopyingStringsTests
{
    [TestCase("1", "CODE*", ExpectedResult = "CODE1")]
    [TestCase("U", "CODE*", ExpectedResult = "CODEU")]
    public string CopyOneChar_ParametersAreValid_ReturnsResult(string source, string destination)
    {
        // Act
        return CopyingStrings.CopyOneChar(source, destination);
    }

    [TestCase("123", "***-PRODUCTION-CODE", ExpectedResult = "123-PRODUCTION-CODE")]
    [TestCase("UXC", "***-PRODUCTION-CODE", ExpectedResult = "UXC-PRODUCTION-CODE")]
    public string CopyThreeChars_ParametersAreValid_ReturnsResult(string source, string destination)
    {
        // Act
        return CopyingStrings.CopyThreeChars(source, destination);
    }

    [TestCase("12345", "CODE*****MACX", ExpectedResult = "CODE12345MACX")]
    [TestCase("UXCWK", "CODE*****MACX", ExpectedResult = "CODEUXCWKMACX")]
    public string CopyFiveChars_ParametersAreValid_ReturnsResult(string source, string destination)
    {
        // Act
        return CopyingStrings.CopyFiveChars(source, destination);
    }

    [TestCase("MLK12345ZX", "PCODE******MACX", ExpectedResult = "PCODEK12345MACX")]
    [TestCase("MLKUXCWKZX", "PCODE******MACX", ExpectedResult = "PCODEKUXCWKMACX")]
    public string CopySixChars_ParametersAreValid_ReturnsResult(string source, string destination)
    {
        // Act
        return CopyingStrings.CopySixChars(source, destination);
    }

    [TestCase("*M4**Z0***LL****", "090", "kk853197", "IQIDDQD", "0775Q2T", ExpectedResult = "9M431Z0DDQLL75Q2")]
    [TestCase("*91**84***00****", "911", "96872740", "QRIDKFA", "8573840", ExpectedResult = "1912784DKF007384")]
    public string GetProductionCode_ParametersAreValid_ReturnsResult(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
    {
        // Act
        return CopyingStrings.GetProductionCode(template, regionCode, locationCode, dateCode, factoryCode);
    }
}

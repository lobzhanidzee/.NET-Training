using NUnit.Framework;

namespace Strings.Tests;

[TestFixture]
public sealed class ManipulationsTests
{
    [TestCase("", ExpectedResult = "Hello, !")]
    [TestCase("Joe", ExpectedResult = "Hello, Joe!")]
    [TestCase("Jim", ExpectedResult = "Hello, Jim!")]
    public string GetHelloGreeting1_ReturnsResult(string name)
    {
        return Manipulations.GetHelloGreeting1(name);
    }

    [TestCase("", "", ExpectedResult = ", !")]
    [TestCase("Hello", "Joe", ExpectedResult = "Hello, JOE!")]
    [TestCase("Hi", "Jim", ExpectedResult = "Hi, JIM!")]
    public string GetGreeting1_ReturnsResult(string greeting, string name)
    {
        return Manipulations.GetGreeting1(greeting, name);
    }

    [TestCase("", ExpectedResult = "Hello, !")]
    [TestCase(" Joe ", ExpectedResult = "Hello, Joe!")]
    [TestCase("    Jim    ", ExpectedResult = "Hello, Jim!")]
    public string GetHelloGreeting2_ReturnsResult(string name)
    {
        return Manipulations.GetHelloGreeting2(name);
    }

    [TestCase("", "", ExpectedResult = ", !")]
    [TestCase("   Hello   ", " JoE ", ExpectedResult = "Hello, joe!")]
    [TestCase("  Hi  ", "     jIm      ", ExpectedResult = "Hi, jim!")]
    public string GetGreeting2_ReturnsResult(string greeting, string name)
    {
        return Manipulations.GetGreeting2(greeting, name);
    }

    [TestCase("Hello, {name}!", "", ExpectedResult = "Hello, !")]
    [TestCase("Hello, {name}!", "Joe", ExpectedResult = "Hello, Joe!")]
    [TestCase("Hello, {name}!", "Jim", ExpectedResult = "Hello, Jim!")]
    [TestCase("Hi, {name}!", "Joe", ExpectedResult = "Hi, Joe!")]
    [TestCase("Hi, {name}!", "Jim", ExpectedResult = "Hi, Jim!")]
    public string GetHelloGreeting3_ReturnsResult(string template, string name)
    {
        return Manipulations.GetHelloGreeting3(template, name);
    }

    [TestCase("{greeting}, {name}!", "", "", ExpectedResult = ", !")]
    [TestCase("{greeting}, {name}!", "Hello", "Joe", ExpectedResult = "hello, JOE!")]
    [TestCase("{greeting}, {name}!", "Hi", "Jim", ExpectedResult = "hi, JIM!")]
    [TestCase("{name}! {greeting}!", "Hello", "Joe", ExpectedResult = "JOE! hello!")]
    [TestCase("{name}! {greeting}!", "Hi", "Jim", ExpectedResult = "JIM! hi!")]
    public string GetGreeting3_ReturnsResult(string template, string greeting, string name)
    {
        return Manipulations.GetGreeting3(template, greeting, name);
    }

    [TestCase("MX9000KLDX", ExpectedResult = "MX9KLDX")]
    [TestCase("KZ4000XLAM", ExpectedResult = "KZ4XLAM")]
    [TestCase("DJW000SDHE", ExpectedResult = "DJWSDHE")]
    public string GetRefinedCode_ReturnsResult(string code)
    {
        return Manipulations.GetRefinedCode(code);
    }

    [TestCase("04-05-2010", ExpectedResult = "04052010")]
    [TestCase("12-09-2022", ExpectedResult = "12092022")]
    [TestCase("30-11-1994", ExpectedResult = "30111994")]
    public string GetRefinedDate_ReturnsResult(string date)
    {
        return Manipulations.GetRefinedDate(date);
    }
}

// ReSharper disable StringLiteralTypo
using System.Globalization;
using NUnit.Framework;

namespace Strings.Tests;
[TestFixture]
public sealed class InterpolationTests
{
    [TestCase("", ExpectedResult = "Hello, !")]
    [TestCase("Joe", ExpectedResult = "Hello, Joe!")]
    [TestCase("Jim", ExpectedResult = "Hello, Jim!")]
    public string GetHelloGreeting_ReturnsResult(string name)
    {
        return Interpolation.GetHelloGreeting(name);
    }

    [TestCase("", "", ExpectedResult = ", !")]
    [TestCase("Hello", "Joe", ExpectedResult = "Hello, Joe!")]
    [TestCase("Hi", "Jim", ExpectedResult = "Hi, Jim!")]
    public string GetGreeting_ReturnsResult(string greeting, string name)
    {
        return Interpolation.GetGreeting(greeting, name);
    }

    [TestCase(1, ExpectedResult = "The square number of 1 is 1.")]
    [TestCase(2, ExpectedResult = "The square number of 2 is 4.")]
    [TestCase(3, ExpectedResult = "The square number of 3 is 9.")]
    public string GetSquareNumber_ReturnsResult(int i)
    {
        return Interpolation.GetSquareNumber(i);
    }

    [TestCase(12.34, 1, 1, ExpectedResult = "The price of all items is 12.34.")]
    [TestCase(12.34, 1, 0.5, ExpectedResult = "The price of all items is 6.17.")]
    [TestCase(12.34, 2, 1, ExpectedResult = "The price of all items is 24.68.")]
    [TestCase(12.34, 2, 0.5, ExpectedResult = "The price of all items is 12.34.")]
    [TestCase(26.71, 10, 0.7, ExpectedResult = "The price of all items is 186.97.")]
    public string GetTotalPrice_ReturnsResult(double price, int items, double discount)
    {
        var currentCulture = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        var result = Interpolation.GetTotalPrice(price, items, discount);

        CultureInfo.CurrentCulture = currentCulture;
        return result;
    }

    [TestCase(new int[] { }, ExpectedResult = "The sequence is {}.")]
    [TestCase(new[] { 1 }, ExpectedResult = "The sequence is {1}.")]
    [TestCase(new[] { 1, 2 }, ExpectedResult = "The sequence is {1,2}.")]
    [TestCase(new[] { 1, 2, 3 }, ExpectedResult = "The sequence is {1,2,3}.")]
    public string GetSequenceOfNumbers_ReturnsResult(int[] numbers)
    {
        return Interpolation.GetSequenceOfNumbers(numbers);
    }

    [TestCase("", ExpectedResult = "The sequence length is 0.")]
    [TestCase("1", ExpectedResult = "The sequence length is 1.")]
    [TestCase("1,2", ExpectedResult = "The sequence length is 2.")]
    [TestCase("1,2,3", ExpectedResult = "The sequence length is 3.")]
    public string GetSequenceOfNumbersLength_ReturnsResult(string sequence)
    {
        return Interpolation.GetSequenceOfNumbersLength(sequence);
    }

    [TestCase("", "", "", ExpectedResult = @"c:\users\\Documents\.")]
    [TestCase("myuser", "", "", ExpectedResult = @"c:\users\myuser\Documents\.")]
    [TestCase("myuser", "myfilename", "", ExpectedResult = @"c:\users\myuser\Documents\myfilename.")]
    [TestCase("myuser", "myfilename", "txt", ExpectedResult = @"c:\users\myuser\Documents\myfilename.txt")]
    [TestCase("joedoe", "document-02072022", "doc", ExpectedResult = @"c:\users\joedoe\Documents\document-02072022.doc")]
    public string GetDocumentPath_ReturnsFilePath(string username, string filename, string extension)
    {
        return Interpolation.GetDocumentPath(username, filename, extension);
    }

    [TestCase("", "", "", "", ExpectedResult = @"\\\users\\.")]
    [TestCase("DESKTOP4923", "joe", "mydocument", "txt", ExpectedResult = @"\\DESKTOP4923\users\joe\mydocument.txt")]
    [TestCase("AZURE-WM-0394", "Susie", "Birthday party", "avi", ExpectedResult = @"\\AZURE-WM-0394\users\Susie\Birthday party.avi")]
    public string GetNetworkPath_ReturnsNetworkPath(string workstation, string userFolder, string filename, string extension)
    {
        return Interpolation.GetNetworkPath(workstation, userFolder, filename, extension);
    }
}

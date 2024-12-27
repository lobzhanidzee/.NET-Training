using NUnit.Framework;

namespace IfStatements.Tests;

[TestFixture]
public class Task11Tests
{
    [TestCase(true, true, 0, ExpectedResult = 1)]
    [TestCase(true, true, 1, ExpectedResult = 1)]
    [TestCase(true, true, 2, ExpectedResult = 2)]
    [TestCase(true, true, 3, ExpectedResult = 3)]
    [TestCase(true, true, 4, ExpectedResult = 8)]
    [TestCase(true, true, 5, ExpectedResult = 10)]
    [TestCase(true, true, 6, ExpectedResult = 12)]
    [TestCase(true, true, 7, ExpectedResult = 14)]
    [TestCase(true, true, 8, ExpectedResult = 8)]
    [TestCase(true, true, 9, ExpectedResult = 9)]
    [TestCase(true, true, 10, ExpectedResult = 10)]
    [TestCase(true, true, -1, ExpectedResult = -1)]
    [TestCase(true, true, -2, ExpectedResult = -2)]
    [TestCase(true, true, -3, ExpectedResult = -3)]
    [TestCase(true, true, -4, ExpectedResult = -4)]
    [TestCase(true, true, -5, ExpectedResult = -15)]
    [TestCase(true, true, -6, ExpectedResult = -18)]
    [TestCase(true, true, -7, ExpectedResult = -21)]
    [TestCase(true, true, -8, ExpectedResult = -24)]
    [TestCase(true, true, -9, ExpectedResult = -9)]
    [TestCase(true, true, -10, ExpectedResult = -10)]
    [TestCase(true, false, 0, ExpectedResult = -1)]
    [TestCase(true, false, 1, ExpectedResult = 1)]
    [TestCase(true, false, 2, ExpectedResult = 2)]
    [TestCase(true, false, 3, ExpectedResult = 3)]
    [TestCase(true, false, 4, ExpectedResult = 2)]
    [TestCase(true, false, 5, ExpectedResult = 0)]
    [TestCase(true, false, 6, ExpectedResult = -2)]
    [TestCase(true, false, 7, ExpectedResult = -4)]
    [TestCase(true, false, 8, ExpectedResult = 8)]
    [TestCase(true, false, 9, ExpectedResult = 9)]
    [TestCase(true, false, 10, ExpectedResult = 10)]
    [TestCase(true, false, -1, ExpectedResult = -1)]
    [TestCase(true, false, -2, ExpectedResult = -2)]
    [TestCase(true, false, -3, ExpectedResult = 1)]
    [TestCase(true, false, -4, ExpectedResult = -2)]
    [TestCase(true, false, -5, ExpectedResult = -5)]
    [TestCase(true, false, -6, ExpectedResult = -8)]
    [TestCase(true, false, -7, ExpectedResult = -7)]
    [TestCase(true, false, -8, ExpectedResult = -8)]
    [TestCase(true, false, -9, ExpectedResult = -9)]
    [TestCase(true, false, -10, ExpectedResult = -10)]
    [TestCase(false, true, 0, ExpectedResult = 1)]
    [TestCase(false, true, 1, ExpectedResult = 0)]
    [TestCase(false, true, 2, ExpectedResult = -4)]
    [TestCase(false, true, 3, ExpectedResult = -18)]
    [TestCase(false, true, 4, ExpectedResult = -48)]
    [TestCase(false, true, 5, ExpectedResult = 5)]
    [TestCase(false, true, 6, ExpectedResult = 6)]
    [TestCase(false, true, 7, ExpectedResult = 7)]
    [TestCase(false, true, 8, ExpectedResult = -56)]
    [TestCase(false, true, 9, ExpectedResult = -72)]
    [TestCase(false, true, 10, ExpectedResult = -90)]
    [TestCase(false, true, -1, ExpectedResult = 2)]
    [TestCase(false, true, -2, ExpectedResult = 12)]
    [TestCase(false, true, -3, ExpectedResult = 36)]
    [TestCase(false, true, -4, ExpectedResult = -4)]
    [TestCase(false, true, -5, ExpectedResult = -5)]
    [TestCase(false, true, -6, ExpectedResult = -6)]
    [TestCase(false, true, -7, ExpectedResult = -7)]
    [TestCase(false, true, -8, ExpectedResult = -8)]
    [TestCase(false, true, -9, ExpectedResult = -90)]
    [TestCase(false, true, -10, ExpectedResult = -110)]
    [TestCase(false, false, 0, ExpectedResult = 1)]
    [TestCase(false, false, 1, ExpectedResult = 0)]
    [TestCase(false, false, 2, ExpectedResult = 4)]
    [TestCase(false, false, 3, ExpectedResult = 3)]
    [TestCase(false, false, 4, ExpectedResult = 4)]
    [TestCase(false, false, 5, ExpectedResult = 5)]
    [TestCase(false, false, 6, ExpectedResult = 6)]
    [TestCase(false, false, 7, ExpectedResult = 7)]
    [TestCase(false, false, 8, ExpectedResult = -504)]
    [TestCase(false, false, 9, ExpectedResult = -720)]
    [TestCase(false, false, 10, ExpectedResult = -990)]
    [TestCase(false, false, -1, ExpectedResult = -2)]
    [TestCase(false, false, -2, ExpectedResult = -12)]
    [TestCase(false, false, -3, ExpectedResult = -36)]
    [TestCase(false, false, -4, ExpectedResult = -4)]
    [TestCase(false, false, -5, ExpectedResult = -5)]
    [TestCase(false, false, -6, ExpectedResult = -6)]
    [TestCase(false, false, -7, ExpectedResult = 336)]
    [TestCase(false, false, -8, ExpectedResult = 504)]
    [TestCase(false, false, -9, ExpectedResult = 720)]
    [TestCase(false, false, -10, ExpectedResult = 990)]
    public int DoSomething_ReturnsBool(bool b1, bool b2, int i)
    {
        return Task11.DoSomething(b1, b2, i);
    }
}

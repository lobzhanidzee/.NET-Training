using NUnit.Framework;
using static NextBiggerTask.NumberExtension;

namespace NextBiggerTask.Tests
{
    public class NumberExtensionTests
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(124121133, ExpectedResult = 124121313)]
        public int? NextBiggerThan_NextBiggerNumberExists(int number)
        {
            return NextBiggerThan(number);
        }

        [TestCase(10, ExpectedResult = -1)]
        [TestCase(int.MaxValue, ExpectedResult = -1)]
        [TestCase(2, ExpectedResult = -1)]
        [TestCase(2000, ExpectedResult = -1)]
        [TestCase(111111111, ExpectedResult = -1)]
        public int? NextBiggerThan_NextBiggerNumberDoesNotExist(int number)
        {
            return NextBiggerThan(number);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(int.MinValue)]
        public void NextBiggerThan_WithNegativeNumber_ThrowArgumentException(int number)
        {
            _ = Assert.Throws<ArgumentException>(() => NextBiggerThan(number), message: $"Value of {nameof(number)} cannot be less zero.");
        }
    }
}

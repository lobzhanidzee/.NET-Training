using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class DoWhileMethodsTests
    {
        private static readonly object[][] GetZeroDecimalCountData =
        {
            new object[] { new[] { 1.1m }, 0 },
            new object[] { new[] { decimal.Zero }, 1 },
            new object[] { new[] { decimal.Zero, 1.1m }, 1 },
            new object[] { new[] { decimal.Zero, decimal.Zero }, 2 },
            new object[] { new[] { 1.1m, decimal.Zero, 2.2m, decimal.Zero, 3.3m }, 2 },
            new object[] { new[] { decimal.Zero, 1.1m, decimal.Zero, 2.2m, 3.3m, decimal.Zero, decimal.Zero }, 4 },
        };

        [Test]
        public void GetFalseValueCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetFalseValueCount(null));
        }

        [TestCase(new[] { false, true, true, false, false, false, true, false }, ExpectedResult = 5)]
        [TestCase(new[] { true, true, true, true, true, true, true, true }, ExpectedResult = 0)]
        [TestCase(new[] { false, true, true, true, true, true, true, false }, ExpectedResult = 2)]
        [TestCase(new[] { false, false, true, true, true, false, false, true }, ExpectedResult = 4)]
        [TestCase(new[] { false, true, false, false, true, true, true, false, false, true, true, false, false, false, true, false }, ExpectedResult = 9)]
        public int GetFalseValueCount_ParametersAreValid_ReturnResult(bool[] arrayToSearch)
        {
            // Act
            return DoWhileMethods.GetFalseValueCount(arrayToSearch);
        }

        [Test]
        public void GetFalseValueCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetFalseValueCountRecursive(null));
        }

        [TestCase(new[] { false, true, true, false, false, false, true, false }, ExpectedResult = 5)]
        [TestCase(new[] { true, true, true, true, true, true, true, true }, ExpectedResult = 0)]
        [TestCase(new[] { false, true, true, true, true, true, true, false }, ExpectedResult = 2)]
        [TestCase(new[] { false, false, true, true, true, false, false, true }, ExpectedResult = 4)]
        [TestCase(new[] { false, true, false, false, true, true, true, false, false, true, true, false, false, false, true, false }, ExpectedResult = 9)]
        public int GetFalseValueCountRecursive_ParametersAreValid_ReturnResult(bool[] arrayToSearch)
        {
            // Act
            return DoWhileMethods.GetFalseValueCountRecursive(arrayToSearch);
        }

        [Test]
        public void GetZeroDecimalCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetZeroDecimalCount(null));
        }

        [TestCaseSource(nameof(GetZeroDecimalCountData))]
        public void GetZeroDecimalCount_ParametersAreValid_ReturnResult(decimal[] arrayToSearch, int expectedResult)
        {
            // Act
            int actualResult = DoWhileMethods.GetZeroDecimalCount(arrayToSearch);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void GetZeroDecimalCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetZeroDecimalCountRecursive(null));
        }

        [TestCaseSource(nameof(GetZeroDecimalCountData))]
        public void GetZeroDecimalCountRecursive_ParametersAreValid_ReturnResult(decimal[] arrayToSearch, int expectedResult)
        {
            // Act
            int actualResult = DoWhileMethods.GetZeroDecimalCountRecursive(arrayToSearch);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void GetRoundedToEvenCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetRoundedToEvenCount(null));
        }

        [TestCase(new[] { 0.45 }, ExpectedResult = 1)]
        [TestCase(new[] { 1.45 }, ExpectedResult = 0)]
        [TestCase(new[] { 1.5 }, ExpectedResult = 1)]
        [TestCase(new[] { 0.45, 1.45, 1.5, 2.0, 3.2, 3.5 }, ExpectedResult = 4)]
        [TestCase(new[] { 0.1, 0.16 }, ExpectedResult = 2)]
        [TestCase(new[] { 3.26, 5.46, 6.66, 8.86 }, ExpectedResult = 0)]
        [TestCase(new[] { double.MinValue, 0.22, 0.33, 0.44, 0.55, 0.66, 0.77, 0.88, 0.99 }, ExpectedResult = 4)]
        [TestCase(new[] { 0.1, double.MaxValue, 0.2, 0.3, 0.4, 0.5, double.MaxValue, 0.6, 0.7, 0.8, 0.9 }, ExpectedResult = 7)]
        public int GetRoundedToEvenCount_ParametersAreValid_ReturnResult(double[] arrayToSearch)
        {
            // Act
            return DoWhileMethods.GetRoundedToEvenCount(arrayToSearch);
        }

        [Test]
        public void GetRoundedToEvenCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetRoundedToEvenCountRecursive(null));
        }

        [TestCase(new[] { 0.45 }, ExpectedResult = 1)]
        [TestCase(new[] { 1.45 }, ExpectedResult = 0)]
        [TestCase(new[] { 1.5 }, ExpectedResult = 1)]
        [TestCase(new[] { 0.45, 1.45, 1.5, 2.0, 3.2, 3.5 }, ExpectedResult = 4)]
        [TestCase(new[] { 0.1, 0.16 }, ExpectedResult = 2)]
        [TestCase(new[] { 3.26, 5.46, 6.66, 8.86 }, ExpectedResult = 0)]
        [TestCase(new[] { double.MinValue, 0.22, 0.33, 0.44, 0.55, 0.66, 0.77, 0.88, 0.99 }, ExpectedResult = 4)]
        [TestCase(new[] { 0.1, double.MaxValue, 0.2, 0.3, 0.4, 0.5, double.MaxValue, 0.6, 0.7, 0.8, 0.9 }, ExpectedResult = 7)]
        public int GetRoundedToEvenCountRecursive_ParametersAreValid_ReturnResult(double[] arrayToSearch)
        {
            // Act
            return DoWhileMethods.GetRoundedToEvenCountRecursive(arrayToSearch);
        }
    }
}

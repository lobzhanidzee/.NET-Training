using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class WhileMethodsTests
    {
        private static readonly object[][] GetEmptyStringCountData =
        {
            new object[] { new[] { string.Empty, "abc", string.Empty, "def", string.Empty, "ghi", string.Empty }, 4 },
            new object[] { new[] { string.Empty, string.Empty, string.Empty }, 3 },
            new object[] { new[] { "ab", "cd", "ef", "gh", "ij", "kl", "mn" }, 0 },
            new object[] { new[] { "ab", string.Empty, "cd", "ef", "gh", "ij", "kl", "mn", string.Empty }, 2 },
        };

        private static readonly object[][] GetNullObjectCountData =
        {
            new object[] { new[] { null, new object(), new object(), null, null, new object(), null }, 4 },
            new object[] { new[] { new object(), new object(), new object(), new object() }, 0 },
            new object[] { new object?[] { null, null, null, null, null }, 5 },
            new object[] { new[] { new object(), new object(), null, new object(), new object() }, 1 },
        };

        [Test]
        public void GetEmptyStringCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            _ = Assert.Throws<ArgumentNullException>(() => WhileMethods.GetEmptyStringCount(null));
        }

        [TestCaseSource(nameof(GetEmptyStringCountData))]
        public void GetEmptyStringCount_ParametersAreValid_ReturnsResult(string[] arrayToSearch, int expectedResult)
        {
            // Act
            int actualResult = WhileMethods.GetEmptyStringCount(arrayToSearch);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void GetEmptyStringCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            _ = Assert.Throws<ArgumentNullException>(() => WhileMethods.GetEmptyStringCountRecursive(null));
        }

        [TestCaseSource(nameof(GetEmptyStringCountData))]
        public void GetEmptyStringCountRecursive_ArrayOfStrings1_ReturnsResult(string[] arrayToSearch, int expectedResult)
        {
            // Act
            int actualResult = WhileMethods.GetEmptyStringCountRecursive(arrayToSearch);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void GetMinOrMaxLongCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            _ = Assert.Throws<ArgumentNullException>(() => WhileMethods.GetMinOrMaxLongCount(null));
        }

        [TestCase(new long[] { 0, 1, long.MaxValue, 3, long.MaxValue, 4, long.MinValue, 5, long.MinValue, 6 }, ExpectedResult = 4)]
        [TestCase(new long[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, ExpectedResult = 0)]
        [TestCase(new long[] { long.MinValue, long.MaxValue, long.MinValue, long.MaxValue, long.MinValue }, ExpectedResult = 5)]
        [TestCase(new long[] { long.MinValue, 0, 1, 2, 3, 4, 5, 6, 7, 8, long.MaxValue }, ExpectedResult = 2)]
        public int GetMinOrMaxLongCount_ParametersAreValid_ReturnsResult(long[] arrayToSearch)
        {
            // Act
            return WhileMethods.GetMinOrMaxLongCount(arrayToSearch);
        }

        [Test]
        public void GetMinOrMaxLongCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            _ = Assert.Throws<ArgumentNullException>(() => WhileMethods.GetMinOrMaxLongCountRecursive(null));
        }

        [TestCase(new long[] { 0, 1, long.MaxValue, 3, long.MaxValue, 4, long.MinValue, 5, long.MinValue, 6 }, ExpectedResult = 4)]
        [TestCase(new long[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, ExpectedResult = 0)]
        [TestCase(new long[] { long.MinValue, long.MaxValue, long.MinValue, long.MaxValue, long.MinValue }, ExpectedResult = 5)]
        [TestCase(new long[] { long.MinValue, 0, 1, 2, 3, 4, 5, 6, 7, 8, long.MaxValue }, ExpectedResult = 2)]
        public int GetMinOrMaxLongCountRecursive_ParametersAreValid_ReturnsResult(long[] arrayToSearch)
        {
            // Act
            return WhileMethods.GetMinOrMaxLongCountRecursive(arrayToSearch);
        }

        [Test]
        public void GetNullObjectCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            _ = Assert.Throws<ArgumentNullException>(() => WhileMethods.GetNullObjectCount(null));
        }

        [TestCaseSource(nameof(GetNullObjectCountData))]
        [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "data parameter should not be null.")]
        public void GetNullObjectCount_ParametersAreValid_ReturnsResult(object[] data)
        {
            // Arrange
            object[] arrayToSearch = (object[])data[0];
            int expectedResult = (int)data[1];

            // Act
            int actualResult = WhileMethods.GetNullObjectCount(arrayToSearch);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void GetNullObjectCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            _ = Assert.Throws<ArgumentNullException>(() => WhileMethods.GetNullObjectCountRecursive(null));
        }

        [TestCaseSource(nameof(GetNullObjectCountData))]
        [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "data parameter should not be null.")]
        public void GetNullObjectCountRecursive_ParametersAreValid_ReturnsResult(object[] data)
        {
            // Arrange
            object[] arrayToSearch = (object[])data[0];
            int expectedResult = (int)data[1];

            // Act
            int actualResult = WhileMethods.GetNullObjectCountRecursive(arrayToSearch);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}

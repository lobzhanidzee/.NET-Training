using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class ForMethodsTests
    {
        [Test]
        public void GetNegativeIntegerCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetNegativeIntegerCount(null));
        }

        [TestCase(new[] { -1, 1, -1, 2, -2, -3, 3, 4, 5, 6, -6, 0 }, ExpectedResult = 5)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = 0)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -6 }, ExpectedResult = 6)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, 0 }, ExpectedResult = 10)]
        public int GetNegativeIntegerCount_ParametersAreValid_ReturnsResult(int[] arrayToSearch)
        {
            // Act
            return ForMethods.GetNegativeIntegerCount(arrayToSearch);
        }

        [Test]
        public void GetNegativeIntegerCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetNegativeIntegerCountRecursive(null));
        }

        [TestCase(new[] { -1, 1, -1, 2, -2, -3, 3, 4, 5, 6, -6, 0 }, ExpectedResult = 5)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = 0)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -6 }, ExpectedResult = 6)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, 0 }, ExpectedResult = 10)]
        public int GetNegativeIntegerCountRecursive_ParametersAreValid_ReturnsResult(int[] arrayToSearch)
        {
            // Act
            return ForMethods.GetNegativeIntegerCountRecursive(arrayToSearch);
        }

        [Test]
        public void GetEvenNumberCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetEvenNumberCount(null));
        }

        [TestCase(new[] { -9f, -8f, -7f, -6f, -5f, -4f, -3f, -2f, -1f, 0, 1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f }, ExpectedResult = 9)]
        [TestCase(new[] { -9f, -7f, -5f, -3f, -1f, 1f, 3f, 5f, 7f, 9f }, ExpectedResult = 0)]
        [TestCase(new[] { -9f, -7f, -5f, -3f, -1f, 0, 1f, 3f, 5f, 7f, 9f }, ExpectedResult = 1)]
        [TestCase(new[] { -6f, -4f, -2f, 0, 2f, 4f, 6f }, ExpectedResult = 7)]
        public int GetEvenNumberCount_ParametersAreValid_ReturnsResult(float[] arrayToSearch)
        {
            // Act
            return ForMethods.GetEvenNumberCount(arrayToSearch);
        }

        [Test]
        public void GetEvenNumberCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetEvenNumberCountRecursive(null));
        }

        [TestCase(new[] { -9f, -8f, -7f, -6f, -5f, -4f, -3f, -2f, -1f, 0, 1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f }, ExpectedResult = 9)]
        [TestCase(new[] { -9f, -7f, -5f, -3f, -1f, 1f, 3f, 5f, 7f, 9f }, ExpectedResult = 0)]
        [TestCase(new[] { -9f, -7f, -5f, -3f, -1f, 0, 1f, 3f, 5f, 7f, 9f }, ExpectedResult = 1)]
        [TestCase(new[] { -6f, -4f, -2f, 0, 2f, 4f, 6f }, ExpectedResult = 7)]
        public int GetEvenNumberCountRecursive_ParametersAreValid_ReturnsResult(float[] arrayToSearch)
        {
            // Act
            return ForMethods.GetEvenNumberCountRecursive(arrayToSearch);
        }

        [Test]
        public void GetByteWithBitsInHighNibbleCount_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetByteWithBitsInHighNibbleCount(null));
        }

        [TestCase(new byte[] { 0xF1, 0x0F, 0x1F, 0x01, 0x40, 0x04 }, ExpectedResult = 3)]
        [TestCase(new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05 }, ExpectedResult = 0)]
        [TestCase(new byte[] { 0x1F, 0x2F, 0x3F, 0x4F }, ExpectedResult = 4)]
        public int GetByteWithBitsInHighNibbleCount_ParametersAreValid_ReturnsResult(byte[] arrayToSearch)
        {
            // Act
            return ForMethods.GetByteWithBitsInHighNibbleCount(arrayToSearch);
        }

        [Test]
        public void GetByteWithBitsInHighNibbleCountRecursive_ArrayToSearchParameterIsNull_ThrowsArgumentNullException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetByteWithBitsInHighNibbleCountRecursive(null));
        }

        [TestCase(new byte[] { 0xF1, 0x0F, 0x1F, 0x01, 0x40, 0x04 }, ExpectedResult = 3)]
        [TestCase(new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05 }, ExpectedResult = 0)]
        [TestCase(new byte[] { 0x1F, 0x2F, 0x3F, 0x4F }, ExpectedResult = 4)]
        public int GetByteWithBitsInHighNibbleCountRecursive_ParametersAreValid_ReturnsResult(byte[] arrayToSearch)
        {
            // Act
            return ForMethods.GetByteWithBitsInHighNibbleCountRecursive(arrayToSearch);
        }
    }
}

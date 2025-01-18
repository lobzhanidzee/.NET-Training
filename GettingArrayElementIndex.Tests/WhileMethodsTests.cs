using NUnit.Framework;
using static GettingArrayElementIndex.WhileMethods;

// ReSharper disable StringLiteralTypo
namespace GettingArrayElementIndex.Tests
{
    [TestFixture]
    public sealed class WhileMethodsTests
    {
        [Test]
        public void GetIndexOf_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0));
        }

        [TestCase(new ushort[0], (ushort)0, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)0, ExpectedResult = 0)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)1, ExpectedResult = 1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)2, ExpectedResult = 2)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)3, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, (ushort)9, ExpectedResult = 9)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)4, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition(ushort[] arrayToSearch, ushort value)
        {
            // Act
            return GetIndexOf(arrayToSearch, value);
        }

        [Test]
        public void GetIndexOf_StartIndexCount_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0, 0, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_StartIndexLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ushort>(), 0, -1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_StartIndexGreaterArrayLength_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ushort>(), 0, 1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_CountLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ushort>(), 0, 0, -1));
        }

        [TestCase(new ushort[0], (ushort)0, 0, 0, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 0, 9, ExpectedResult = 0)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 0, 14, ExpectedResult = 0)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 1, 8, ExpectedResult = 7)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 1, 4, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 7, 1, ExpectedResult = 7)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 9, 5, ExpectedResult = 11)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 0, 9, ExpectedResult = 1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 0, 14, ExpectedResult = 1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 1, 8, ExpectedResult = 1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 1, 4, ExpectedResult = 1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 2, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 6, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 4, 1, ExpectedResult = 4)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 9, 5, ExpectedResult = 12)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 0, 9, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 0, 14, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 1, 8, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 1, 4, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 2, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 6, 1, ExpectedResult = 6)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 4, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 9, 5, ExpectedResult = 10)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)4, 0, 7, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition2(ushort[] arrayToSearch, ushort value, int startIndex, int count)
        {
            // Act
            return GetIndexOf(arrayToSearch, value, startIndex, count);
        }

        [Test]
        public void GetLastIndexOf_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetLastIndexOf(null, 0));
        }

        [TestCase(new ushort[0], (ushort)0, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)0, ExpectedResult = 0)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)1, ExpectedResult = 4)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)2, ExpectedResult = 5)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)3, ExpectedResult = 6)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, (ushort)9, ExpectedResult = 9)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)4, ExpectedResult = -1)]
        public int GetLastIndexOf_NonEmptyArray_ReturnsPosition(ushort[] arrayToSearch, ushort value)
        {
            // Act
            return GetLastIndexOf(arrayToSearch, value);
        }

        [Test]
        public void GetLastIndexOf_StartIndexCount_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetLastIndexOf(null, 0, 0, 0));
        }

        [Test]
        public void GetLastIndexOf_StartIndexCount_StartIndexLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetLastIndexOf(Array.Empty<ushort>(), 0, -1, 0));
        }

        [Test]
        public void GetLastIndexOf_StartIndexCount_StartIndexGreaterArrayLength_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetLastIndexOf(Array.Empty<ushort>(), 0, 1, 0));
        }

        [Test]
        public void GetLastIndexOf_StartIndexCount_CountLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetLastIndexOf(Array.Empty<ushort>(), 0, 0, -1));
        }

        [TestCase(new ushort[0], (ushort)0, 0, 0, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 0, 9, ExpectedResult = 7)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 0, 14, ExpectedResult = 11)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 1, 8, ExpectedResult = 7)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 1, 4, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 7, 1, ExpectedResult = 7)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)0, 9, 5, ExpectedResult = 11)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 0, 9, ExpectedResult = 8)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 0, 14, ExpectedResult = 12)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 1, 8, ExpectedResult = 8)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 1, 4, ExpectedResult = 4)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 2, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 6, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 4, 1, ExpectedResult = 4)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)1, 9, 5, ExpectedResult = 12)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 0, 9, ExpectedResult = 6)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 0, 14, ExpectedResult = 10)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 1, 8, ExpectedResult = 6)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 1, 4, ExpectedResult = 3)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 2, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 6, 1, ExpectedResult = 6)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 4, 1, ExpectedResult = -1)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, (ushort)3, 9, 5, ExpectedResult = 10)]
        [TestCase(new ushort[] { 0, 1, 2, 3, 1, 2, 3 }, (ushort)4, 0, 7, ExpectedResult = -1)]
        public int GetLastIndexOf_StartIndexCount_NonEmptyArray_ReturnsPosition(ushort[] arrayToSearch, ushort value, int startIndex, int count)
        {
            // Act
            return GetLastIndexOf(arrayToSearch, value,  startIndex, count);
        }
    }
}

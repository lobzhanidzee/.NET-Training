using NUnit.Framework;
using static GettingArrayElementIndex.DoWhileMethods;

// ReSharper disable StringLiteralTypo
namespace GettingArrayElementIndex.Tests
{
    [TestFixture]
    public sealed class DoWhileMethodsTests
    {
        [Test]
        public void GetIndexOf_NullArray_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => GetIndexOf(null, 0));
        }

        [TestCase(new ulong[0], 0ul, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 0ul, ExpectedResult = 0)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 1ul, ExpectedResult = 1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 2ul, ExpectedResult = 2)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 3ul, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9ul, ExpectedResult = 9)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 4ul, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition(ulong[] arrayToSearch, ulong value)
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
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ulong>(), 0, -1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_StartIndexGreaterArrayLength_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ulong>(), 0, 1, 0));
        }

        [Test]
        public void GetIndexOf_StartIndexCount_CountLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetIndexOf(Array.Empty<ulong>(), 0, 0, -1));
        }

        [TestCase(new ulong[0], 0ul, 0, 0, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 0, 9, ExpectedResult = 0)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 0, 14, ExpectedResult = 0)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 1, 8, ExpectedResult = 7)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 1, 4, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 7, 1, ExpectedResult = 7)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 9, 5, ExpectedResult = 11)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 0, 9, ExpectedResult = 1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 0, 14, ExpectedResult = 1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 1, 8, ExpectedResult = 1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 1, 4, ExpectedResult = 1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 2, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 6, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 4, 1, ExpectedResult = 4)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 9, 5, ExpectedResult = 12)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 0, 9, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 0, 14, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 1, 8, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 1, 4, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 2, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 6, 1, ExpectedResult = 6)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 4, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 9, 5, ExpectedResult = 10)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 4ul, 0, 7, ExpectedResult = -1)]
        public int GetIndexOf_NonEmptyArray_ReturnsPosition2(ulong[] arrayToSearch, ulong value, int startIndex, int count)
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

        [TestCase(new ulong[0], 0ul, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 0ul, ExpectedResult = 0)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 1ul, ExpectedResult = 4)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 2ul, ExpectedResult = 5)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 3ul, ExpectedResult = 6)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9ul, ExpectedResult = 9)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 4ul, ExpectedResult = -1)]
        public int GetLastIndexOf_NonEmptyArray_ReturnsPosition(ulong[] arrayToSearch, ulong value)
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
            Assert.Throws<ArgumentOutOfRangeException>(() => GetLastIndexOf(Array.Empty<ulong>(), 0, -1, 0));
        }

        [Test]
        public void GetLastIndexOf_StartIndexCount_StartIndexGreaterArrayLength_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetLastIndexOf(Array.Empty<ulong>(), 0, 1, 0));
        }

        [Test]
        public void GetLastIndexOf_StartIndexCount_CountLessZero_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => GetLastIndexOf(Array.Empty<ulong>(), 0, 0, -1));
        }

        [TestCase(new ulong[0], 0ul, 0, 0, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 0, 9, ExpectedResult = 7)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 0, 14, ExpectedResult = 11)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 1, 8, ExpectedResult = 7)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 1, 4, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 7, 1, ExpectedResult = 7)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 0ul, 9, 5, ExpectedResult = 11)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 0, 9, ExpectedResult = 8)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 0, 14, ExpectedResult = 12)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 1, 8, ExpectedResult = 8)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 1, 4, ExpectedResult = 4)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 2, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 6, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 4, 1, ExpectedResult = 4)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 1ul, 9, 5, ExpectedResult = 12)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 0, 9, ExpectedResult = 6)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 0, 14, ExpectedResult = 10)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 1, 8, ExpectedResult = 6)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 1, 4, ExpectedResult = 3)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 2, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 6, 1, ExpectedResult = 6)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 4, 1, ExpectedResult = -1)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 }, 3ul, 9, 5, ExpectedResult = 10)]
        [TestCase(new ulong[] { 0, 1, 2, 3, 1, 2, 3 }, 4ul, 0, 7, ExpectedResult = -1)]
        public int GetLastIndexOf_StartIndexCount_NonEmptyArray_ReturnsPosition(ulong[] arrayToSearch, ulong value, int startIndex, int count)
        {
            // Act
            return GetLastIndexOf(arrayToSearch, value, startIndex, count);
        }
    }
}

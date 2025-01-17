using NUnit.Framework;

namespace WorkingWithArrays.Tests
{
    [TestFixture]
    public sealed class UsingRangesTests
    {
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1 }, ExpectedResult = new[] { 1 })]
        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new[] { 1, 2, 3 })]
        public int[] GetArrayWithAllElements_ReturnArrayWithAllElements(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithAllElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { 1 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1, 2 }, ExpectedResult = new[] { 2 })]
        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new[] { 2, 3 })]
        public int[] GetArrayWithoutFirstElement_ReturnArrayWithoutFirstElement(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithoutFirstElement(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { 1, 2 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new[] { 3 })]
        [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = new[] { 3, 4 })]
        public int[] GetArrayWithoutTwoFirstElements_ReturnArrayWithoutTwoFirstElements(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithoutTwoFirstElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = new[] { 4 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ExpectedResult = new[] { 4, 5 })]
        public int[] GetArrayWithoutThreeFirstElements_ReturnArrayWithoutThreeFirstElements(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithoutThreeFirstElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { 1 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1, 2 }, ExpectedResult = new[] { 1 })]
        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new[] { 1, 2 })]
        public int[] GetArrayWithoutLastElement_ReturnArrayWithoutLastElement(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithoutLastElement(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { 1, 2 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = new[] { 1, 2 })]
        public int[] GetArrayWithoutTwoLastElements_ReturnArrayWithoutTwoLastElements(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithoutTwoLastElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ExpectedResult = new[] { 1, 2 })]
        public int[] GetArrayWithoutThreeLastElements_ReturnArrayWithoutThreeLastElements(int[] array)
        {
            // Act
            int[] result = UsingRanges.GetArrayWithoutThreeLastElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { false, false }, ExpectedResult = new bool[] { })]
        [TestCase(new[] { false, true, false }, ExpectedResult = new[] { true })]
        [TestCase(new[] { false, true, true, false }, ExpectedResult = new[] { true, true })]
        public bool[] GetArrayWithoutFirstAndLastElements_ReturnArrayWithoutFirstAndLastElements(bool[] array)
        {
            // Act
            bool[] result = UsingRanges.GetArrayWithoutFirstAndLastElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { false, false, false, false }, ExpectedResult = new bool[] { })]
        [TestCase(new[] { false, false, true, false, false }, ExpectedResult = new[] { true })]
        [TestCase(new[] { false, false, true, true, false, false }, ExpectedResult = new[] { true, true })]
        public bool[] GetArrayWithoutTwoFirstAndTwoLastElements_GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            // Act
            bool[] result = UsingRanges.GetArrayWithoutTwoFirstAndTwoLastElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }

        [TestCase(new[] { false, false, false, false, false, false }, ExpectedResult = new bool[] { })]
        [TestCase(new[] { false, false, false, true, false, false, false }, ExpectedResult = new[] { true })]
        [TestCase(new[] { false, false, false, true, true, false, false, false }, ExpectedResult = new[] { true, true })]
        public bool[] GetArrayWithoutThreeFirstAndThreeLastElements_GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            // Act
            bool[] result = UsingRanges.GetArrayWithoutThreeFirstAndThreeLastElements(array);

            // Assert
            Assert.That(result, !Is.SameAs(array));
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using Comparators;
using DoubleTransformer;
using GenericMethods.Interfaces;
using IntegerPredicate;
using NUnit.Framework;

namespace GenericMethods.Tests.NUnitTests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        private static IEnumerable<TestCaseData> FilterTestCases
        {
            get
            {
                yield return new TestCaseData(
                        new ContainsDigitPredicate { Digit = 0 },
                        new[] { 2212332, 1405644, -1236674 })
                    .Returns(new[] { 1405644 });
                yield return new TestCaseData(
                        new ContainsDigitPredicate { Digit = 7 },
                        new[] { -27, 173, 371132, 7556, 7243, 10017, int.MinValue, int.MaxValue })
                    .Returns(new[] { -27, 173, 371132, 7556, 7243, 10017, int.MinValue, int.MaxValue });
                yield return new TestCaseData(
                    new ContainsDigitPredicate { Digit = 0 },
                    new[] { int.MinValue, int.MinValue, int.MinValue, int.MaxValue, int.MaxValue })
                    .Returns(Array.Empty<int>());
                yield return new TestCaseData(
                        new ContainsDigitPredicate { Digit = 2 },
                        new[] { -123, 123, 2202, 3333, 4444, 55055, 0, -7, 5402, 9, 0, -150, 287 })
                    .Returns(new[] { -123, 123, 2202, 5402, 287 });
            }
        }

        private static IEnumerable<TestCaseData> TransformerTestCases
        {
            get
            {
                yield return new TestCaseData(
                        new GetIeee754Format(),
                        new[] { 122.625, -255.255, 255.255, 4294967295.012, -451387.2345, 0.2345E-12 })
                    .Returns(new[]
                    {
                        "0100000001011110101010000000000000000000000000000000000000000000",
                        "1100000001101111111010000010100011110101110000101000111101011100",
                        "0100000001101111111010000010100011110101110000101000111101011100",
                        "0100000111101111111111111111111111111111111000000110001001001110",
                        "1100000100011011100011001110110011110000001000001100010010011100",
                        "0011110101010000100000000110000001011111000011101110100001011011",
                    });
                yield return new TestCaseData(
                        new GetIeee754Format(),
                        new[]
                        {
                            double.PositiveInfinity, 0.0, double.NegativeInfinity, -0.0, double.Epsilon, double.NaN,
                        })
                    .Returns(new[]
                    {
                        "0111111111110000000000000000000000000000000000000000000000000000",
                        "0000000000000000000000000000000000000000000000000000000000000000",
                        "1111111111110000000000000000000000000000000000000000000000000000",
                        "1000000000000000000000000000000000000000000000000000000000000000",
                        "0000000000000000000000000000000000000000000000000000000000000001",
                        "1111111111111000000000000000000000000000000000000000000000000000",
                    });
            }
        }

        private static IEnumerable<TestCaseData> SortByTestCases
        {
            get
            {
                yield return new TestCaseData(
                        new StringByLengthComparer(),
                        new[] { "Beg", null, "Life", "I", "i", "I", null, "To" })
                    .Returns(new[] { null, null, "I", "i", "I", "To", "Beg", "Life" });
                yield return new TestCaseData(
                        new StringByLengthComparer(),
                        new[] { null, "Longer", "Longest", "Short", null, null })
                    .Returns(new[] { null, null, null, "Short", "Longer", "Longest" });
            }
        }

        [TestCaseSource(nameof(TransformerTestCases))]
        public string[] TransformerTests(ITransformer<double, string> transformer, double[] source) =>
            source.Transform(transformer);

        [TestCaseSource(nameof(SortByTestCases))]
        public string[] SortByTests(IComparer<string> comparer, string[] source) => source.SortBy(comparer);

        [TestCaseSource(nameof(FilterTestCases))]
        public int[] FilterByTests(IPredicate<int> predicate, int[] source) => source.Filter(predicate);
    }
}

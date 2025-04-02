using Comparators;
using NUnit.Framework;

namespace GenericMethods.Tests.NUnitTests;

[TestFixture(
    new[] { "Beg", null, "Life", "I", "i", "I", null, "To", },
    new[] { null, null, "I", "i", "I", "To", "Beg", "Life" },
    TypeArgs = new Type[] { typeof(string) })]
[TestFixture(
    new[] { 0, 12, -12, 34, 0, 2, -567, 12, -12, 89, int.MaxValue, -1000, },
    new[] { 0, 0, 2, 12, -12, 12, -12, 34, 89, -567, -1000, int.MaxValue, },
    TypeArgs = new Type[] { typeof(int) })]
[TestFixture(
    new[] { 0, 12, -12, 34, 0, 2, -567, 12, -12, 89, int.MinValue, -1000, },
    new[] { 0, 0, 2, 12, -12, 12, -12, 34, 89, -567, -1000, int.MinValue, },
    TypeArgs = new Type[] { typeof(int) })]

public class ArrayExtensionSortByTestFixture<T>
{
    private readonly T[] source;
    private readonly T[] expected;
    private readonly IComparer<T> comparer;

    public ArrayExtensionSortByTestFixture(T[] source, T[] expected)
        => (this.expected, this.source, this.comparer) = (expected, source, ComparerCreator(typeof(T)));

    [Test]
    public void SortByTest() => Assert.That(this.expected, Is.EqualTo(this.source.SortBy(this.comparer)));

    private static IComparer<T> ComparerCreator(Type type)
    {
        if (type == typeof(string))
        {
            return (IComparer<T>)new StringByLengthComparer();
        }

        if (type == typeof(int))
        {
            return (IComparer<T>)new IntegerByAbsComparer();
        }

        return null!;
    }
}

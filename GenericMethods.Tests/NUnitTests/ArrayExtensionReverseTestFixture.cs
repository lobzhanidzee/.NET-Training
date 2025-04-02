using NUnit.Framework;

namespace GenericMethods.Tests.NUnitTests;

[TestFixture(
    new[] { "Beg", null, "Life", "I", "i", "I", null, "To" },
    new[] { "To", null, "I", "i", "I", "Life", null, "Beg" },
    TypeArgs = new Type[] { typeof(string) })]
[TestFixture(
    new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
    new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
    TypeArgs = new Type[] { typeof(int) })]
public class ArrayExtensionReverseTestFixture<T>
{
    private readonly T[] source;
    private readonly T[] expected;

    public ArrayExtensionReverseTestFixture(T[] source, T[] expected) => (this.expected, this.source) = (expected, source);

    [Test]
    public void ReverseTest() => Assert.That(this.expected, Is.EqualTo(this.source.Reverse()));
}

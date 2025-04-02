using NUnit.Framework;

namespace GenericMethods.Tests.NUnitTests;

[TestFixture(
    new object[] { 12, 3, 4, true, "12", "2", 13.56, "6", null!, 17.901, false },
    new int[] { 12, 3, 4 },
    TypeArgs = [typeof(int)])]
[TestFixture(
    new object[] { 12, null!, 3, 4, true, "12", "2", 13.56, "6", 17.901, false },
    new string[] { "12", "2", "6" },
    TypeArgs = [typeof(string)])]
[TestFixture(
    new object[] { 12, -123.543, 3, null!, 4, true, "12", "2", 13.56, "6", 17.901, false },
    new double[] { -123.543, 13.56, 17.901 },
    TypeArgs = [typeof(double)])]
[TestFixture(
    new object[] { -123.543, 12, 3, 4, true, "12", "2", null!, 13.56, "6", 17.901, false },
    new bool[] { true, false },
    TypeArgs = [typeof(bool)])]
[TestFixture(
    new object[] { 's', -123.543, '\n', 12, 3, 4, true, "12", "2", null!, 13.56, "6", 17.901, false },
    new char[] { 's', '\n' },
    TypeArgs = new Type[] { typeof(char) })]
internal class ArrayExtensionTypeOfTestFixture<T>(object[] source, T[] expected)
{
    [Test]
    public void TypeOfTest()
    {
        Assert.That(expected, Is.EqualTo(source.TypeOf<T>()));
    }
}

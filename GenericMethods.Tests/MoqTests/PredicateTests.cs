using GenericMethods.Interfaces;
using IntegerPredicate;
using Moq;
using NUnit.Framework;

namespace GenericMethods.Tests.MoqTests;

[TestFixture]
public class PredicateTests
{
    [TestCase(55)]
    [TestCase(551)]
    [TestCase(-12551)]
    [TestCase(-90551)]
    public void IsMatchTests_Return_True(int value)
    {
        var mockPredicate = new Mock<IPredicate<int>>();

        mockPredicate
            .Setup(p => p.IsMatch(It.Is<int>(i => new ContainsDigitPredicate { Digit = 5 }.IsMatch(i))))
            .Returns(true);

        IPredicate<int> predicate = mockPredicate.Object;

        Assert.That(predicate.IsMatch(value));

        mockPredicate.Verify(p => p.IsMatch(It.IsAny<int>()), Times.Exactly(1));
    }

    [TestCase(109)]
    [TestCase(67632)]
    [TestCase(-120943)]
    [TestCase(-2113)]
    [TestCase(int.MinValue)]
    public void IsMatchTests_Return_False(int value)
    {
        Mock<IPredicate<int>> mockPredicate = new Mock<IPredicate<int>>();

        mockPredicate
            .Setup(p => p.IsMatch(It.Is<int>(i => new ContainsDigitPredicate { Digit = 5 }.IsMatch(i))))
            .Returns(true);

        IPredicate<int> predicate = mockPredicate.Object;

        Assert.That(!predicate.IsMatch(value));

        mockPredicate.Verify(p => p.IsMatch(It.IsAny<int>()), Times.Exactly(1));
    }

    [Test]
    public void FilterTests()
    {
        var source = new[] { 12, 35, -65, 543, 23 };

        var expected = new[] { 35, -65, 543 };

        Mock<IPredicate<int>> mockPredicate = new Mock<IPredicate<int>>();

        mockPredicate
            .Setup(p => p.IsMatch(It.Is<int>(i => new ContainsDigitPredicate { Digit = 5 }.IsMatch(i))))
            .Returns(true);

        IPredicate<int> predicate = mockPredicate.Object;

        var actual = source.Filter(predicate);

        Assert.That(expected, Is.EqualTo(actual));

        mockPredicate.Verify(p => p.IsMatch(It.IsAny<int>()), Times.Exactly(source.Length));
    }
}

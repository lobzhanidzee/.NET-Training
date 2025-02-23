using FilterByPredicate;
using Moq;
using NUnit.Framework;

namespace FilterByPredicates.Tests;

[TestFixture]
public class IPredicateTests
{
    [TestCase(10)]
    [TestCase(100)]
    public void VerifyBehaviorTests(int count)
    {
        var mock = new Mock<IPredicate>();

        _ = mock.Setup(i => i.IsMatch(It.Is<int>(i => i % 2 == 0))).Returns(It.IsAny<bool>());

        IPredicate predicate = mock.Object;

        var source = Enumerable.Range(1, count).ToArray();

        _ = source.Select(predicate);

        mock.Verify(p => p.IsMatch(It.IsAny<int>()), Times.Exactly(count));
    }

    [TestCase(100)]
    [TestCase(1000)]
    public void VerifyStateTests(int count)
    {
        var mock = new Mock<IPredicate>();

        _ = mock.Setup(i => i.IsMatch(It.Is<int>(i => i % 2 == 0))).Returns(true);

        var predicate = mock.Object;
        var source = Enumerable.Range(1, count).ToArray();

        var expected = source.Where(i => i % 2 == 0).ToArray();

        int[] actual = source.Select(predicate);

        Assert.That(expected, Is.EqualTo(actual));
    }
}

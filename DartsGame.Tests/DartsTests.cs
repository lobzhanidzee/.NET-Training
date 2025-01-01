using NUnit.Framework;

namespace DartsGame.Tests;

[TestFixture]
public class DartsTests
{
    [Test]
    public void GetScore_DartLandsOutsideTheTarget_Return_0()
    {
        Assert.That(Darts.GetScore(-9, 9), Is.EqualTo(0));
    }

    [Test]
    public void GetScore_DartLandsJustInTheBorderOfTheTarget_Return_1()
    {
        Assert.That(Darts.GetScore(0, 10), Is.EqualTo(1));
    }

    [Test]
    public void GetScore_DartLandsInTheOuterCircle_Return_4()
    {
        Assert.That(Darts.GetScore(4, 4), Is.EqualTo(1));
    }

    [Test]
    public void GetScore_DartLandsRightInTheBorderBetweenOuterAndMiddleCircles_Return_5()
    {
        Assert.That(Darts.GetScore(5, 0), Is.EqualTo(5));
    }

    [Test]
    public void GetScore_DartLandsInTheMiddleCircle_Return_5()
    {
        Assert.That(Darts.GetScore(0.8, -0.8), Is.EqualTo(5));
    }

    [Test]
    public void GetScore_DartLandsInTheBorderBetweenMiddleAndInnerCircles_Return_10()
    {
        Assert.That(Darts.GetScore(0, -1), Is.EqualTo(10));
    }

    [Test]
    public void GetScore_DartLandsInTheInnerCircle_Return_10()
    {
        Assert.That(Darts.GetScore(-0.1, -0.1), Is.EqualTo(10));
    }
}

using AntiCheater;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class ISequenceGeneratorTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    [Test]
    public void FibonacciSequenceGenerator_Should_Generate_Correct_Sequence()
    {
        var mock = new Mock<ISequenceGenerator<int>>();
        mock.SetupSequence(m => m.Next)
            .Returns(1)
            .Returns(1)
            .Returns(2)
            .Returns(3)
            .Returns(5)
            .Returns(8);

        var expected = new List<int>
        {
            1,
            1,
            2,
            3,
            5,
            8
        };
        var actual = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            actual.Add(mock.Object.Next);
        }

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void SecondSequenceGenerator_Should_Generate_Correct_Sequence()
    {
        var mock = new Mock<ISequenceGenerator<int>>();
        mock.SetupSequence(m => m.Next)
            .Returns(4)
            .Returns(8)
            .Returns(16)
            .Returns(32)
            .Returns(64)
            .Returns(128);

        var expected = new List<int>
        {
            4,
            8,
            16,
            32,
            64,
            128
        };
        var actual = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            actual.Add(mock.Object.Next);
        }

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void ThirdSequenceGenerator_Should_Generate_Correct_Sequence()
    {
        var mock = new Mock<ISequenceGenerator<double>>();
        mock.SetupSequence(m => m.Next)
            .Returns(2.5)
            .Returns(3.3)
            .Returns(4.05757575757576)
            .Returns(4.87086926018965)
            .Returns(5.70389834408211)
            .Returns(6.55785277425587);

        var expected = new List<double>
        {
            2.5,
            3.3,
            4.05757575757576,
            4.87086926018965,
            5.70389834408211,
            6.55785277425587
        };
        var actual = new List<double>();

        for (int i = 0; i < 6; i++)
        {
            actual.Add(mock.Object.Next);
        }

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void DelegateSequenceGenerator_Should_Generate_Correct_Sequence()
    {
        var mock = new Mock<ISequenceGenerator<int>>();
        mock.SetupSequence(m => m.Next)
            .Returns(2)
            .Returns(3)
            .Returns(5)
            .Returns(8)
            .Returns(13)
            .Returns(21);

        var expected = new List<int>
        {
            2,
            3,
            5,
            8,
            13,
            21
        };
        var actual = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            actual.Add(mock.Object.Next);
        }

        CollectionAssert.AreEqual(expected, actual);
    }
}

using AntiCheater;
using NUnit.Framework;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class DelegateSequenceGeneratorTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    [TestCase(10, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
    public void GetNext_Should_Advance_Generator_In_Delegate_Fibonacci_Sequence(int count, int[] expected)
    {
        var previous = 1;
        var current = 1;
        var delegateGenerator = new DelegateSequenceGenerator<int>(previous, current, (prev, curr) => prev + curr);
        var list = new List<int>(count) { delegateGenerator.Previous, delegateGenerator.Current };

        for (int i = 1; i <= count - 2; i++)
        {
            list.Add(delegateGenerator.Next);
        }

        Assert.That(expected, Is.EqualTo(list.ToArray()));
        Assert.That(delegateGenerator.Count == count);
    }

    [TestCase(10, new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 })]
    public void GetNext_Should_Advance_Generator_In_Delegate_Second_Sequence(int count, int[] expected)
    {
        var previous = 1;
        var current = 2;
        var delegateGenerator = new DelegateSequenceGenerator<int>(
            previous,
            current,
            (prev, curr) => (6 * curr) - (8 * prev));
        var list = new List<int>(count) { delegateGenerator.Previous, delegateGenerator.Current };

        for (int i = 1; i <= count - 2; i++)
        {
            list.Add(delegateGenerator.Next);
        }

        Assert.That(expected, Is.EqualTo(list.ToArray()));
        Assert.That(delegateGenerator.Count == count);
    }

    [TestCase(
        10,
        new double[]
        {
            1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137
        })]
    public void GetNext_Should_Advance_Generator_In_Delegate_Third_Sequence(int count, double[] expected)
    {
        var previous = 1.0;
        var current = 2.0;
        var delegateGenerator = new DelegateSequenceGenerator<double>(
            previous,
            current,
            (prev, curr) => curr + (prev / curr));
        var list = new List<double>(count) { delegateGenerator.Previous, delegateGenerator.Current };

        for (int i = 1; i <= count - 2; i++)
        {
            list.Add(delegateGenerator.Next);
        }

        Assert.That(expected, Is.EqualTo(list.ToArray()).Within(0.000001));
        Assert.That(delegateGenerator.Count == count);
    }
}

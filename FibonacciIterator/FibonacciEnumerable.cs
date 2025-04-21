using System.Collections;

namespace FibonacciIterator;

/// <summary>
/// Represents an enumerable object to iterate over the Fibonacci sequence numbers.
/// </summary>
public sealed class FibonacciEnumerable : IEnumerable<int>
{
    private readonly int[] fibonachiList;

    public FibonacciEnumerable(int count = int.MaxValue, int skipCount = 0)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        ArgumentOutOfRangeException.ThrowIfNegative(skipCount);

        int[] result = new int[count];

        for (int i = 0; i < result.Length; i++)
        {
            if (i >= 3)
            {
                result[i] = result[i - 1] + result[i - 2];
                continue;
            }

            int prevOne = i - 1;
            int prevTwo = i - 2;

            result[i] = (i < 2) ? i : prevOne + prevTwo;
        }

        this.fibonachiList = new int[count > skipCount ? count - skipCount : skipCount - count];

        for (int i = skipCount, j = 0; i < count; i++, j++)
        {
            this.fibonachiList[j] = result[i];
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new FibonacciEnumerator(this.fibonachiList);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

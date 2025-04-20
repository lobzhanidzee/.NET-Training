using System.Collections;

namespace FibonacciIterator;

/// <summary>
/// Represents an enumerable object to iterate over the Fibonacci sequence numbers.
/// </summary>
public sealed class FibonacciEnumerable : IEnumerable<int>
{
    private int[] fibonachiList;

    // TODO Implement an enumerable to iterate over the Fibonacci sequence numbers.
    public FibonacciEnumerable(int count = int.MaxValue, int skipCount = 0)
    {
        this.fibonachiList = new int[count];
        for (int i = skipCount == 0 ? 0 : skipCount - 1, j = 0; i < count; i++, j++)
        {
            this.fibonachiList[j] = i;

            //yield return (i < 2) ? i : (i - 1) + (i - 2);
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (int number in this.fibonachiList)
        {
            yield return number;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

using System.Collections;

namespace FibonacciIterator;

/// <summary>
/// Represents an enumerable object to iterate over the Fibonacci sequence numbers.
/// </summary>
/// /// <typeparam name="T">The type of elements in the Fibonacci sequence.</typeparam>
public sealed class FibonacciEnumerable : IEnumerable<int>
{
    private int[] fibonachiList;

    // TODO Implement an enumerable to iterate over the Fibonacci sequence numbers.
    public FibonacciEnumerable(int count = int.MaxValue, int skipCount = 0)
    {
        //ArgumentNullException.ThrowIfNull(fibonachiList);

        //for (int i = skipCount == 0 ? 0 : skipCount - 1; i < count; i++)
        //{

        //    //yield return (i < 2) ? i : (i - 1) + (i - 2);
        //}
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

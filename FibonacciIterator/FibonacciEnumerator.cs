using System.Collections;

namespace FibonacciIterator;

/// <summary>
/// Represents an enumerator object to iterate over the Fibonacci sequence numbers.
/// </summary>
public sealed class FibonacciEnumerator : IEnumerator<int>
{
    private readonly int[] numbers;

    private int position = -1;

    public FibonacciEnumerator(int[] numbers)
    {
        this.numbers = numbers;
    }

    public int Current
    {
        get
        {
            if (this.position < 0 || this.position >= this.numbers.Length)
            {
                throw new InvalidOperationException();
            }

            return this.numbers[this.position];
        }
    }

    object IEnumerator.Current => this.Current;

    public void Dispose()
    {
    }

    public bool MoveNext() => ++this.position < this.numbers.Length;

    public void Reset()
    {
        this.position = -1;
    }
}

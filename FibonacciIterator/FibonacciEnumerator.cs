using System.Collections;

namespace FibonacciIterator;

/// <summary>
/// Represents an enumerator object to iterate over the Fibonacci sequence numbers.
/// </summary>
public sealed class FibonacciEnumerator : IEnumerator<int>
{
    private readonly int count;
    private readonly int skipCount;
    private int current;
    private int previous;
    private int position;

    public FibonacciEnumerator(int count, int skipCount)
    {
        this.count = count;
        this.skipCount = skipCount;
        this.current = 0;
        this.previous = 1;
        this.position = 0;
    }

    public int Current
    {
        get
        {
            if (this.position == -1 || this.position == 0 || this.position > this.count)
            {
                throw new InvalidOperationException();
            }

            return this.current;
        }
    }

    object IEnumerator.Current => this.Current;

    public void Dispose()
    {
        // No resources to dispose.
    }

    public bool MoveNext()
    {
        if (this.position >= this.count)
        {
            return false;
        }

        if (this.position < this.skipCount)
        {
            while (this.position < this.skipCount)
            {
                int temp = this.current + this.previous;
                this.previous = this.current;
                this.current = temp;
                this.position++;
            }

            return this.MoveNext();
        }

        if (this.position == this.skipCount)
        {
            this.position++;
            return true;
        }

        if (this.current <= int.MaxValue - this.previous)
        {
            int temp = this.current + this.previous;
            this.previous = this.current;
            this.current = temp;
        }
        else
        {
            return false;
        }

        this.position++;
        return true;
    }

    public void Reset()
    {
        this.current = 0;
        this.previous = 1;
        this.position = 0;
    }
}

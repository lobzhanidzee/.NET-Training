using System.Collections;

namespace FibonacciIterator;

/// <summary>
/// Represents an enumerator object to iterate over the Fibonacci sequence numbers.
/// </summary>
public sealed class FibonacciEnumerator : IEnumerator
{
    public FibonacciEnumerable _numbers;

    private int position = -1;

    public object Current => throw new NotImplementedException();
    //{
    //    get
    //    {
    //        try
    //        {
    //            return _numbers;
    //        }
    //        catch (IndexOutOfRangeException)
    //        {
    //            throw new InvalidOperationException();
    //        }
    //    }
    //}

    object IEnumerator.Current => this.Current;

    // TODO Implement an enumerator to iterate over the Fibonacci sequence numbers.

    public void Dispose()
    {
        // The method is empty, because there are no additional resources to dispose.
        // See "Notes to Implementers" - https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1?view=net-6.0#notes-to-implementers
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}

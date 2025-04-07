using System.Collections;

namespace CustomGenericStack;

/// <summary>
/// Represents extendable last-in-first-out (LIFO) collection of the specified type T.
/// Internally it is implemented as an array, so Push can be O(n). Pop is O(1).
/// </summary>
/// <typeparam name="T">Specifies the type of elements in the stack.</typeparam>
public class GenericStack<T> : IEnumerable<T>
{
    private IEnumerable<T> items;
    private int count;
    private int version;

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericStack{T}"/> class.
    /// </summary>
    public GenericStack()
    {
        this.count = 0;
        this.items = Array.Empty<T>();
        this.version = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericStack{T}"/> class.
    /// </summary>
    /// <param name="capacity">The initial number of elements of stack.</param>
    public GenericStack(int capacity)
    {
        this.count = capacity;
        this.version = 0;
        this.items = new T[this.count];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericStack{T}"/> class that contains eleCustomGenericStack
    /// from the specified collection and has sufficient capacity to accommodate the  number of elements copied.
    /// </summary>
    /// <param name="collection">The collection to copy elements from.</param>
    public GenericStack(IEnumerable<T>? collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        this.count = collection.Count();
        this.version = 0;
        this.items = collection;
    }

    /// <summary>
    /// Gets the number of elements contained in the stack.
    /// </summary>
    public int Count => this.count;

    /// <summary>
    /// Removes and returns the object at the top of the stack.
    /// </summary>
    /// <returns>The object removed from the top of the stack.</returns>
    public T Pop()
    {
        if (this.count == 0)
        {
            throw new InvalidOperationException("Cannot pop from an empty stack.");
        }

        T resultValue = this.items.ElementAt(this.count - 1);

        T[] result = new T[this.count];
        int counter = 0;

        foreach (var arrItem in this.items)
        {
            result[counter] = arrItem;
            counter++;
        }

        this.count--;
        this.version++;

        T[] finalResult = new T[this.count];

        for (var i = 0; i < finalResult.Length; i++)
        {
            finalResult[i] = result[i];
        }

        this.items = finalResult;

        return resultValue;
    }

    /// <summary>
    /// Returns the object at the top of the stack without removing it.
    /// </summary>
    /// <returns>The object at the top of the stack.</returns>
    public T Peek()
    {
        if (this.count == 0)
        {
            throw new InvalidOperationException("Cannot pop from an empty stack.");
        }

        T resultValue = this.items.ElementAt(this.count - 1);

        return resultValue;
    }

    /// <summary>
    /// Inserts an object at the top of the stack.
    /// </summary>
    /// <param name="item">The object to push onto the stack.
    /// The value can be null for reference types.</param>
    public void Push(T item)
    {
        this.count++;
        this.version++;

        T[] result = new T[this.count];
        int counter = 0;

        foreach (var arrItem in this.items)
        {
            result[counter] = arrItem;
            counter++;
        }

        result[counter] = item;

        this.items = result;
    }

    /// <summary>
    /// Copies the elements of stack to a new array.
    /// </summary>
    /// <returns>A new array containing copies of the elements of the stack.</returns>
    public T[] ToArray()
    {
        T[] result = new T[this.count];
        int counter = this.count - 1;

        foreach (var item in this.items)
        {
            result[counter] = item;
            counter--;
        }

        return result;
    }

    /// <summary>
    /// Determines whether an element is in the stack.
    /// </summary>
    /// <param name="item">The object to locate in the stack. The value can be null for reference types.</param>
    /// <returns>Return true if item is found in the stack; otherwise, false.</returns>
    public bool Contains(T item)
    {
        return this.items.Contains(item, EqualityComparer<T>.Default);
    }

    /// <summary>
    /// Removes all objects from the stack.
    /// </summary>
    public void Clear()
    {
        this.count = 0;

        T[] result = new T[this.count];
        this.items = result;
    }

    /// <summary>
    /// Returns an enumerator for the stack.
    /// </summary>
    /// <returns>Return Enumerator object for the stack.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return new GenericStackEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private sealed class GenericStackEnumerator : IEnumerator<T>, IDisposable
    {
        private readonly GenericStack<T> stack;
        private readonly int version;
        private int index;
        private T current;

        public GenericStackEnumerator(GenericStack<T> stack)
        {
            this.stack = stack;
            this.version = stack.version;
            this.index = stack.count;
            this.current = default!;
        }

        public T Current
        {
            get
            {
                if (this.index < 0 || this.index >= this.stack.count)
                {
                    throw new InvalidOperationException();
                }

                return this.current;
            }
        }

        object IEnumerator.Current => this.Current!;

        public bool MoveNext()
        {
            if (this.version != this.stack.version)
            {
                throw new InvalidOperationException("GenericStack cannot be changed during iteration.");
            }

            if (--this.index < 0)
            {
                return false;
            }

            this.current = this.stack.items.ElementAt(this.index);
            return true;
        }

        public void Reset()
        {
            if (this.version != this.stack.version)
            {
                throw new InvalidOperationException("GenericStack cannot be changed during iteration.");
            }

            this.index = this.stack.count;
            this.current = default!;
        }

        public void Dispose()
        {
        }
    }
}

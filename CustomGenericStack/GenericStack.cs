using System.Collections;

namespace CustomGenericStack;

/// <summary>
/// Represents extendable last-in-first-out (LIFO) collection of the specified type T.
/// Internally it is implemented as an array, so Push can be O(n). Pop is O(1).
/// </summary>
/// <typeparam name="T">Specifies the type of elements in the stack.</typeparam>
public class GenericStack<T> : IEnumerable<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GenericStack{T}"/> class.
    /// </summary>
    public GenericStack()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericStack{T}"/> class.
    /// </summary>
    /// <param name="capacity">The initial number of elements of stack.</param>
    public GenericStack(int capacity)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericStack{T}"/> class that contains eleCustomGenericStack
    /// from the specified collection and has sufficient capacity to accommodate the  number of elements copied.
    /// </summary>
    /// <param name="collection">The collection to copy elements from.</param>
    public GenericStack(IEnumerable<T>? collection)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the number of elements contained in the stack.
    /// </summary>
    public int Count => throw new NotImplementedException();

    /// <summary>
    /// Removes and returns the object at the top of the stack.
    /// </summary>
    /// <returns>The object removed from the top of the stack.</returns>
    public T Pop()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the object at the top of the stack without removing it.
    /// </summary>
    /// <returns>The object at the top of the stack.</returns>
    public T Peek()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Inserts an object at the top of the stack.
    /// </summary>
    /// <param name="item">The object to push onto the stack.
    /// The value can be null for reference types.</param>
    public void Push(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Copies the elements of stack to a new array.
    /// </summary>
    /// <returns>A new array containing copies of the elements of the stack.</returns>
    public T[] ToArray()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Determines whether an element is in the stack.
    /// </summary>
    /// <param name="item">The object to locate in the stack. The value can be null for reference types.</param>
    /// <returns>Return true if item is found in the stack; otherwise, false.</returns>
    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes all objects from the stack.
    /// </summary>
    public void Clear()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns an enumerator for the stack.
    /// </summary>
    /// <returns>Return Enumerator object for the stack.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

namespace GenericMethods.Interfaces;

/// <summary>
/// Defines a generalized transformation an object from one type to another type.
/// </summary>
/// <typeparam name="TSource">The type of object that is to be converted. This type parameter is contravariant. </typeparam>
/// <typeparam name="TResult">The type the input object is to be converted to. This type parameter is covariant. </typeparam>
public interface ITransformer<in TSource, out TResult>
{
    /// <summary>
    /// Represents a method that converts an object from one type to another type.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <returns>The TResult that represents the converted TSource.</returns>
    TResult Transform(TSource obj);
}

namespace GenericMethods.Interfaces;

/// <summary>
/// Defines a generalized predicate an object.
/// </summary>
/// <typeparam name="T">The type of the object to compare against the criteria. This type parameter is contravariant.</typeparam>
public interface IPredicate<in T>
{
    /// <summary>
    /// Represents the method that defines a set of criteria and determines whether the specified object meets those criteria.
    /// </summary>
    /// <param name="obj">The object to compare against the criteria.</param>
    /// <returns>true if obj meets the criteria defined within the method; otherwise, false.</returns>
    bool IsMatch(T obj);
}

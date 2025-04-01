using TypeConversions.TypesForConversions;

namespace TypeConversions;

public static class ExplicitReferenceConversions
{
    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Circle"/> type by using 'cast expression' syntax.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="object"/> type to <see cref="Circle"/> type.</returns>
    public static Circle? CastExpressionFromObjectToCircle(object @object)
    {
        try
        {
            return (Circle)@object;
        }
        catch (InvalidCastException)
        {
            return null;
        }
    }

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Square"/> type by using 'cast expression' syntax.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
    public static Square? CastExpressionFromObjectToSquare(object @object)
    {
        try
        {
            return (Square)@object;
        }
        catch (InvalidCastException)
        {
            return null;
        }
    }

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Shape"/> type by using 'cast expression' syntax.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Shape"/> object or null when unable to cast <see cref="object"/> type to <see cref="Shape"/> type.</returns>
    public static Shape? CastExpressionFromObjectToShape(object @object) => (Shape)@object;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'cast expression' syntax.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> object.</param>
    /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Circle"/> type.</returns>
    public static Circle? CastExpressionShapeToCircle(Shape shape)
    {
        try
        {
            return (Circle)shape;
        }
        catch (InvalidCastException)
        {
            return null;
        }
    }

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Square"/> type by using 'cast expression' syntax.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Square"/> type.</returns>
    public static Square? CastExpressionFromShapeToSquare(Shape shape)
    {
        try
        {
            return (Square)shape;
        }
        catch (InvalidCastException)
        {
            return null;
        }
    }

    /// <summary>
    /// Performs an explicit conversion <see cref="IColorable"/> type to <see cref="Square"/> type by using 'cast expression' syntax.
    /// </summary>
    /// <param name="colorable"><see cref="IColorable"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Square"/> type.</returns>
    public static Square? CastExpressionFromIColorableToSquare(IColorable colorable) => (Square?)colorable;

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Shape"/> type by using 'as operator' syntax.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Shape"/> object or null when unable to cast <see cref="object"/> type to <see cref="Shape"/> type.</returns>
    public static Shape? AsOperatorFromObjectToShape(object @object) => @object as Shape;

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Square"/> type by using 'as operator' syntax.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
    public static Square? AsOperatorFromObjectToSquare(object @object) => @object as Square;

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Circle"/> type by using 'as operator' syntax.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="object"/> type to <see cref="Circle"/> type.</returns>
    public static Circle? AsOperatorFromObjectToCircle(object @object) => @object as Circle;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Square"/> type by using 'as operator' syntax.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
    public static Square? AsOperatorFromShapeToSquare(Shape shape) => shape as Square;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'as operator' syntax.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> object.</param>
    /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Circle"/> type.</returns>
    public static Circle? AsOperatorFromShapeToCircle(Shape shape) => shape as Circle;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'as operator' syntax.
    /// </summary>
    /// <param name="colorable"><see cref="IColorable"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Square"/> type.</returns>
    public static Square? AsOperatorFromIColorableToSquare(IColorable colorable) => colorable as Square;

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Shape"/> type by using 'pattern matching'.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Shape"/> object or null when unable to cast <see cref="object"/> type to <see cref="Shape"/> type.</returns>
    public static Shape? PatternMatchingFromObjectToShape(object @object) => @object is Shape shape ? shape : null;

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Square"/> type by using 'pattern matching'.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
    public static Square? PatternMatchingFromObjectToSquare(object @object) => @object is Square square ? square : null;

    /// <summary>
    /// Performs an explicit conversion <see cref="object"/> type to <see cref="Circle"/> type by using 'pattern matching'.
    /// </summary>
    /// <param name="object"><see cref="object"/> object.</param>
    /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="object"/> type to <see cref="Circle"/> type.</returns>
    public static Circle? PatternMatchingFromObjectToCircle(object @object) => @object is Circle circle ? circle : null;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Square"/> type by using 'pattern matching'.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
    public static Square? PatternMatchingFromShapeToSquare(Shape shape) => shape is Square square ? square : null;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'pattern matching'.
    /// </summary>
    /// <param name="shape"><see cref="Shape"/> object.</param>
    /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Circle"/> type.</returns>
    public static Circle? PatternMatchingFromShapeToCircle(Shape shape) => shape is Circle circle ? circle : null;

    /// <summary>
    /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'pattern matching'.
    /// </summary>
    /// <param name="colorable"><see cref="IColorable"/> object.</param>
    /// <returns><see cref="Square"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Square"/> type.</returns>
    public static Square? PatternMatchingFromIColorableToSquare(IColorable colorable) => colorable is Square square ? square : null;
}

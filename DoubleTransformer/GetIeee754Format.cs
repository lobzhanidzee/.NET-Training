using GenericMethods.Interfaces;

namespace DoubleTransformer;

/// <summary>
/// Transformer class for double.
/// </summary>
public class GetIeee754Format : ITransformer<double, string>
{
    /// <summary>
    /// Transform double value to IEEE754 format <see cref="https://www.wikiwand.com/en/IEEE_754"/> in the string form.
    /// </summary>
    /// <param name="obj">The double value.</param>
    /// <returns>The IEEE754 format in the string form.</returns>
    public string Transform(double obj)
    {
        long bits = BitConverter.DoubleToInt64Bits(obj);
        return Convert.ToString(bits, 2).PadLeft(64, '0');
    }
}

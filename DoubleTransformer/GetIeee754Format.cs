using GenericMethods.Interfaces;

namespace DoubleTransformer;

/// <summary>
/// Transformer class for double.
/// </summary>
public class GetIeee754Format : ITransformer<double, string>
{
    private struct DoubleUnion
    {
        public double DoubleValue;

        public ulong ULongValue;
    }

    /// <summary>
    /// Transform double value to IEEE754 format <see cref="https://www.wikiwand.com/en/IEEE_754"/> in the string form.
    /// </summary>
    /// <param name="obj">The double value.</param>
    /// <returns>The IEEE754 format in the string form.</returns>
    public string Transform(double obj)
    {
        DoubleUnion union = new DoubleUnion { DoubleValue = obj };
        ulong bits = union.ULongValue;
        return Convert.ToString((long)bits, 2).PadLeft(64, '0');
    }
}

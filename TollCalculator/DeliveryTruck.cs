namespace TollCalculator;

/// <summary>
/// Represents a delivery truck class.
/// </summary>
public class DeliveryTruck : Vehicle
{
    private readonly int grossWeightClass;

    /// <summary>
    /// Initializes a new instance of the <see cref="DeliveryTruck"/> class with
    /// the specified <paramref name="baseToll"/> and <paramref name="grossWeightClass"/>.
    /// </summary>
    /// <param name="baseToll">A baseToll of this <see cref="DeliveryTruck"/> class.</param>
    /// <param name="grossWeightClass">A grossWeightClass of this <see cref="DeliveryTruck"/> class.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="baseToll"/>less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="grossWeightClass"/>less than zero.</exception>
    public DeliveryTruck(decimal baseToll, int grossWeightClass)
        : base(baseToll)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(baseToll);
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(grossWeightClass, 0);

        this.grossWeightClass = grossWeightClass;
    }

    /// <summary>
    /// Gets a gross weight class.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/>less than zero.</exception>
    public int GrossWeightClass { get => this.grossWeightClass; }

    /// <summary>
    /// Calculates the base toll that relies only on the delivery truck type.
    /// ----------------------------------------------
    /// Weight class        Extra or discount
    /// ----------------------------------------------
    /// over 5000 lbs       extra $5.00
    /// under 3000 lbs      $2.00 discount.
    /// </summary>
    /// <returns>The base toll of delivery truck.</returns>
    protected override decimal Calculate()
    {
        if (this.grossWeightClass > 5000)
        {
            return this.BaseToll + 5m;
        }
        else if (this.grossWeightClass < 3000)
        {
            return this.BaseToll - 2;
        }
        else
        {
            return this.BaseToll;
        }
    }
}

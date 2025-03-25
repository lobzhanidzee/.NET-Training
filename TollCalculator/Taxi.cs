namespace TollCalculator;

/// <summary>
/// Represents a taxi class.
/// </summary>
public class Taxi : Vehicle
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Taxi"/> class with the specified <paramref name="baseToll"/> and <paramref name="passengers"/>.
    /// </summary>
    /// <param name="baseToll">A baseToll of this <see cref="Taxi"/> class.</param>
    /// <param name="passengers">A passengers of this <see cref="Taxi"/> class.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="baseToll"/>less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="passengers"/>less than zero.</exception>
    public Taxi(decimal baseToll, int passengers)
    {
        this.Passengers = passengers;
    }

    /// <summary>
    /// Gets or sets a passengers.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/>less than zero.</exception>
    public int Passengers
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    /// <summary>
    /// Calculates the base toll that relies only on the car type.
    /// ----------------------------------------------
    /// Passengers count        Extra or discount
    /// ----------------------------------------------
    /// 0                       extra $0.50
    /// 2                       $0.50 discount
    /// 3 and more              $1.00 discount.
    /// </summary>
    /// <returns>The base toll of car.</returns>
    protected override decimal Calculate() => throw new NotImplementedException();
}

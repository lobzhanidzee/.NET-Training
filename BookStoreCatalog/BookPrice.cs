namespace BookStoreCatalog;

public class BookPrice
{
    private decimal amount;
    private string currency;

    public BookPrice()
        : this(0, "USD")
    {
    }

    public BookPrice(decimal amount, string currency)
    {
        ThrowExceptionIfAmountIsNotValid(amount, nameof(amount));
        this.amount = amount;

        ThrowExceptionIfCurrencyIsNotValid(currency, nameof(currency));
        this.currency = currency;
    }

    public decimal Amount { get => this.amount; set { this.amount = value; } }

    public string Currency { get => this.currency; set { this.currency = value; } }

    public override string ToString()
    {
        return $"{this.amount:2N} {this.currency}";
    }

    private static void ThrowExceptionIfAmountIsNotValid(decimal amount, string parameterName)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount must be more that zero", parameterName);
        }
    }

    private static void ThrowExceptionIfCurrencyIsNotValid(string currency, string parameterName)
    {
        ArgumentNullException.ThrowIfNull(currency);

        if (currency.Length != 3 && currency.All(char.IsLetter))
        {
            throw new ArgumentException("Currency must be 3 letters", parameterName);
        }
    }
}

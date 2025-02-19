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
        ArgumentNullException.ThrowIfNull(currency);
        ThrowExceptionIfAmountIsNotValid(amount, nameof(amount));
        this.amount = amount;

        ThrowExceptionIfCurrencyIsNotValid(currency, nameof(currency));
        this.currency = currency;
    }

    public decimal Amount
    {
        get => this.amount; set
        {
            ThrowExceptionIfAmountIsNotValid(value, nameof(value));
            this.amount = value;
        }
    }

    public string Currency
    {
        get => this.currency; set
        {
            ArgumentNullException.ThrowIfNull(value);
            ThrowExceptionIfCurrencyIsNotValid(value, nameof(value));
            this.currency = value;
        }
    }

    public override string ToString()
    {
        return $"{this.amount:N2} {this.currency}";
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
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3 || !currency.All(char.IsLetter))
        {
            throw new ArgumentException(currency, parameterName);
        }
    }
}

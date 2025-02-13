namespace BookStoreCatalog;

/// <summary>
/// Represents the an item in a book store.
/// </summary>
public class BookStoreItem
{
    private BookPublication publication;
    private BookPrice price;
    private int amount;

    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isniCode"/>, <paramref name="title"/>, <paramref name="publisher"/>, <paramref name="published"/>, <paramref name="bookBinding"/>, <paramref name="bookBinding"/>, <paramref name="isbn"/>, <paramref name="priceAmount"/>, <paramref name="priceCurrency"/> and <paramref name="amount"/>.
    /// </summary>
    public BookStoreItem(string authorName, string isniCode, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, decimal priceAmount, string priceCurrency, int amount)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="publication"/>, <paramref name="price"/> and <paramref name="amount"/>.
    /// </summary>
    public BookStoreItem(BookPublication publication, BookPrice price, int amount)
    {
    }

    /// <summary>
    /// Gets or sets a <see cref="BookPublication"/>.
    /// </summary>
    public BookPublication Publication { get => this.publication; set => this.publication = value; }

    /// <summary>
    /// Gets or sets a <see cref="BookPrice"/>.
    /// </summary>
    public BookPrice Price { get => this.price; set => this.price = value; }

    /// <summary>
    /// Gets or sets an amount of books in the store's stock.
    /// </summary>
    public int Amount { get => this.amount; set => this.amount = value; }

    /// <summary>
    /// Returns the string that represents a current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return "base.ToString()";
    }
}

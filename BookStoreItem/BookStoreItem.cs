namespace BookStoreItem;

/// <summary>
/// Represents an item in a book store.
/// </summary>
public class BookStoreItem
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="isbn">A book ISBN.</param>
    private readonly string authorName;
    private readonly string? isni;
    private readonly bool hasIsni;

    private decimal price;
    private string? currency;
    private int amount;

    public BookStoreItem(string authorName, string title, string publisher, string isbn)
    {
        this.authorName = authorName;
        this.Title = title;
        this.Publisher = publisher;
        this.Isbn = isbn;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isni"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="isni">A book author's ISNI.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="isbn">A book ISBN.</param>
    public BookStoreItem(string authorName, string isni, string title, string publisher, string isbn)
    {
        this.authorName = authorName;
        this.isni = isni;
        this.Title = title;
        this.Publisher = publisher;
        this.Isbn = isbn;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>, <paramref name="published"/>, <paramref name="bookBinding"/>, <paramref name="price"/>, <paramref name="currency"/> and <paramref name="amount"/>.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="isbn">A book ISBN.</param>
    /// <param name="published">A book publishing date.</param>
    /// <param name="bookBinding">A book binding type.</param>
    /// <param name="price">An amount of money that a book costs.</param>
    /// <param name="currency">A price currency.</param>
    /// <param name="amount">An amount of books in the store's stock.</param>
    public BookStoreItem(string authorName, string title, string publisher, string isbn, DateTime? published, string bookBinding, decimal price, string currency, int amount)
    {
        this.authorName = authorName;
        this.Title = title;
        this.Publisher = publisher;
        this.Isbn = isbn;
        this.Published = published;
        this.BookBinding = bookBinding;
        this.price = price;
        this.currency = currency;
        this.amount = amount;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isni"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>, <paramref name="published"/>, <paramref name="bookBinding"/>, <paramref name="price"/>, <paramref name="currency"/> and <paramref name="amount"/>.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="isni">A book author's ISNI.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="isbn">A book ISBN.</param>
    /// <param name="published">A book publishing date.</param>
    /// <param name="bookBinding">A book binding type.</param>
    /// <param name="price">An amount of money that a book costs.</param>
    /// <param name="currency">A price currency.</param>
    /// <param name="amount">An amount of books in the store's stock.</param>
    public BookStoreItem(string authorName, string isni, string title, string publisher, string isbn, DateTime? published, string bookBinding, decimal price, string currency, int amount)
    {
        this.authorName = authorName;
        this.isni = isni;
        this.Title = title;
        this.Publisher = publisher;
        this.Isbn = isbn;
        this.Published = published;
        this.BookBinding = bookBinding;
        this.price = price;
        this.currency = currency;
        this.amount = amount;
    }

    /// <summary>
    /// Gets a book author's name.
    /// </summary>
    public string AuthorName { get => this.authorName; }

    /// <summary>
    /// Gets an International Standard Name Identifier (ISNI) that uniquely identifies a book author.
    /// </summary>
    public string? Isni { get => this.isni; }

    /// <summary>
    /// Gets a value indicating whether an author has an International Standard Name Identifier (ISNI).
    /// </summary>
    public bool HasIsni { get => this.hasIsni; }

    /// <summary>
    /// Gets a book title.
    /// </summary>
    public string Title { get; private set; }

    /// <summary>
    /// Gets a book publisher.
    /// </summary>
    public string Publisher { get; private set; }

    /// <summary>
    /// Gets a book International Standard Book Number (ISBN).
    /// </summary>
    public string Isbn { get; private set; }

    /// <summary>
    /// Gets or sets a book publishing date.
    /// </summary>
    public DateTime? Published { get; private set; }

    /// <summary>
    /// Gets or sets a book binding type.
    /// </summary>
    public string? BookBinding { get; private set; }

    /// <summary>
    /// Gets or sets an amount of money that a book costs.
    /// </summary>
    public decimal Price { get => this.price; set { this.price = value; } }

    /// <summary>
    /// Gets or sets a price currency.
    /// </summary>
    public string Currency { get => this.currency; set { this.currency = value; } }

    /// <summary>
    /// Gets or sets an amount of books in the store's stock.
    /// </summary>
    public int Amount { get => this.amount; set { this.amount = value; } }

    /// <summary>
    /// Gets a <see cref="Uri"/> to the contributor's page at the isni.org website.
    /// </summary>
    /// <returns>A <see cref="Uri"/> to the contributor's page at the isni.org website.</returns>
    public Uri GetIsniUri()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets an <see cref="Uri"/> to the publication page on the isbnsearch.org website.
    /// </summary>
    /// <returns>an <see cref="Uri"/> to the publication page on the isbnsearch.org website.</returns>
    public Uri GetIsbnSearchUri()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the string that represents a current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        throw new NotImplementedException();
    }

    private static bool ValidateIsni(string isni)
    {
        throw new NotImplementedException();
    }

    private static bool ValidateIsbnFormat(string isbn)
    {
        throw new NotImplementedException();
    }

    private static bool ValidateIsbnChecksum(string isbn)
    {
        throw new NotImplementedException();
    }

    private static void ThrowExceptionIfCurrencyIsNotValid(string currency, string parameterName)
    {
        throw new NotImplementedException();
    }
}

using System.Globalization;

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
    private string currency;
    private int amount;

    public BookStoreItem(string authorName, string title, string publisher, string isbn)
        : this(authorName, null, title, publisher, isbn)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isni"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="isni">A book author's ISNI.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="isbn">A book ISBN.</param>
    public BookStoreItem(string authorName, string? isni, string title, string publisher, string isbn)
        : this(authorName, isni, title, publisher, isbn: isbn, null, bookBinding: string.Empty, 0, "USD", 0)
    {
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
        : this(authorName, isni: null, title, publisher, isbn, published, bookBinding, price, currency, amount)
    {
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
    public BookStoreItem(string authorName, string? isni, string title, string publisher, string isbn, DateTime? published, string bookBinding, decimal price, string currency, int amount)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(authorName);
        ArgumentException.ThrowIfNullOrWhiteSpace(title);
        ArgumentException.ThrowIfNullOrWhiteSpace(publisher);

        if (isni != null && !ValidateIsni(isni))
        {
            throw new ArgumentException(isni, nameof(isni));
        }

        if (!ValidateIsbnFormat(isbn) || !ValidateIsbnChecksum(isbn))
        {
            throw new ArgumentException(isbn, nameof(isbn));
        }

        ThrowExceptionIfCurrencyIsNotValid(currency, nameof(currency));


        this.authorName = authorName;
        this.Title = title;
        this.Publisher = publisher;

        if (isni != null)
        {
            this.isni = isni;
            this.hasIsni = true;
        }
        else
        {
            this.isni = null;
            this.hasIsni = false;
        }

        this.isni = isni;
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
    public DateTime? Published { get; set; }

    /// <summary>
    /// Gets or sets a book binding type.
    /// </summary>
    public string? BookBinding { get; set; }

    /// <summary>
    /// Gets or sets an amount of money that a book costs.
    /// </summary>
    public decimal Price
    {
        get => this.price; set { this.price = value; }
    }

    /// <summary>
    /// Gets or sets a price currency.
    /// </summary>
    public string Currency
    {
        get => this.currency;
        set => this.currency = value;
    }

    /// <summary>
    /// Gets or sets an amount of books in the store's stock.
    /// </summary>
    public int Amount
    {
        get => this.amount;
        set
        {
            if (value > 0)
            {
                this.amount = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }

    /// <summary>
    /// Gets a <see cref="Uri"/> to the contributor's page at the isni.org website.
    /// </summary>
    /// <returns>A <see cref="Uri"/> to the contributor's page at the isni.org website.</returns>
    public Uri GetIsniUri()
    {
        if (string.IsNullOrEmpty(this.isni))
        {
            throw new InvalidOperationException(nameof(this.isni));
        }

        return new Uri($"https://isni.org/isni/{this.isni}");
    }

    /// <summary>
    /// Gets an <see cref="Uri"/> to the publication page on the isbnsearch.org website.
    /// </summary>
    /// <returns>an <see cref="Uri"/> to the publication page on the isbnsearch.org website.</returns>
    public Uri GetIsbnSearchUri()
    {
        return new Uri($"https://isbnsearch.org/isbn/{this.Isbn}");
    }

    /// <summary>
    /// Returns the string that represents a current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        string priceStr;
        if (this.Price < 1000)
        {
            priceStr = $"{this.Price:N2}".ToString().Replace(',', '.') + $" {this.Currency}";
        }
        else
        {
            priceStr = $"\"{this.Price.ToString("###_###_###.##", CultureInfo.InvariantCulture).Replace(',', '.').Replace('_', ',')} {this.Currency}\"";
        }

        if (this.hasIsni)
        {
            return $"{this.Title}, {this.AuthorName}, {this.Isni}, {priceStr}, {this.Amount}".ToString();
        }
        else
        {
            return $"{this.Title}, {this.AuthorName}, ISNI IS NOT SET, {priceStr}, {this.Amount}".ToString();
        }
    }

    private static bool ValidateIsni(string isni)
    {
        return isni.Length == 16 && (isni.All(char.IsDigit) || isni.All(x => x == 'X'));
    }

    private static bool ValidateIsbnFormat(string isbn)
    {
        ArgumentNullException.ThrowIfNull(isbn);

        return isbn.Length == 10 && (isbn.All(char.IsDigit) || isbn.All(x => x == 'X'));
    }

    private static bool ValidateIsbnChecksum(string isbn)
    {
        int checksum = 0, i, t = 0;

        for (i = 0; i < isbn.Length; ++i)
        {
            int isbnEl = isbn[i] - '0';
            t += isbnEl;
            checksum += t;
        }

        return checksum % 11 == 0;
    }

    private static void ThrowExceptionIfCurrencyIsNotValid(string currency, string parameterName)
    {
        ArgumentNullException.ThrowIfNull(currency);

        if (currency.Length != 3 || !currency.All(char.IsLetter))
        {
            throw new ArgumentException(currency, parameterName);
        }
    }
}

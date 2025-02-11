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
    private string? currency = "USD";
    private int amount;

    public BookStoreItem(string authorName, string title, string publisher, string isbn)
        : this(authorName, isni: null, title, publisher, isbn)
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
        : this(authorName, title, publisher, isbn, DateTime.Now, bookBinding: string.Empty, price: 0, "USD", 0)
    {
        ArgumentNullException.ThrowIfNull(isni);
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
        : this(authorName, isni: string.Empty, title, publisher, isbn, DateTime.Now, bookBinding, price, currency, amount)
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
        ArgumentNullException.ThrowIfNull(isni);
        ArgumentNullException.ThrowIfNull(isbn);

        ArgumentException.ThrowIfNullOrWhiteSpace(authorName);
        ArgumentException.ThrowIfNullOrWhiteSpace(title);
        ArgumentException.ThrowIfNullOrWhiteSpace(publisher);


        this.authorName = authorName;
        this.hasIsni = ValidateIsni(isni);
        this.isni = this.hasIsni ? isni : throw new ArgumentException("Invalid ISNI format.");
        this.Title = title;
        this.Publisher = publisher;
        this.Isbn = ValidateIsbnChecksum(isbn) ? isbn : throw new ArgumentException("error2");
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
    public decimal Price { get => this.price; set { this.price = value; } }

    /// <summary>
    /// Gets or sets a price currency.
    /// </summary>
    public string Currency
    {
        get => this.currency;
        set
        {
            if (value?.Length == 3)
            {
                foreach (var c in value)
                {
                    if (c.GetType() != typeof(int))
                    {
                        this.currency = value;
                    }
                }
            }
        }
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
            throw new InvalidOperationException("ISNI is not set.");
        }

        return new Uri($"https://isni.org/{this.isni}");
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
        string formattedPrice = $"{this.price:N2}";

        if (string.IsNullOrEmpty(this.isni))
        {
            return string.Join(", ", this.Title, this.authorName, $"\"{this.price}\"", this.currency, this.amount);
        }
        else
        {
            return string.Join(", ", this.Title, this.authorName, this.isni, $"\"{formattedPrice} {this.currency}\"", this.amount);
        }
    }

    private static bool ValidateIsni(string isni)
    {
        if (isni.Length != 16)
        {
            return false;
        }

        foreach (char x in isni)
        {
            if (!char.IsDigit(x) && x != 'X')
            {
                return false;
            }
        }

        return true;
    }

    private static bool ValidateIsbnFormat(string isbn)
    {
        return isbn.Length == 10;
    }

    private static bool ValidateIsbnChecksum(string isbn)
    {
        if (ValidateIsbnFormat(isbn))
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

        return false;
    }

    private static void ThrowExceptionIfCurrencyIsNotValid(ref string currency, string parameterName)
    {
        if (parameterName?.Length == 3)
        {
            foreach (var c in parameterName)
            {
                if (c.GetType() != typeof(int))
                {
                    currency = parameterName;
                }
            }
        }
    }
}

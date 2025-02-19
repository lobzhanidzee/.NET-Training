namespace BookStoreCatalog;

/// <summary>
/// Represents a book publication.
/// </summary>
public class BookPublication
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BookPublication"/> class with the specified publisher, publication date, kind of book binding and an International Standard Book Number.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="isni">A 16-digit ISNI code that uniquely identifies a book author.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="published">A book publication date.</param>
    /// <param name="bookBinding">A kind of book binding.</param>
    /// <param name="isbnCode">A 10-digit International Standard Book Number (ISBN) code assigned to a book publication.</param>
    /// <exception cref="ArgumentNullException"><paramref name="publisher"/> or <paramref name="bookNumber"/> or <paramref name="isbnCode"/> is null.</exception>
    /// <exception cref="ArgumentException"><paramref name="publisher"/> is empty or consists of white-space only characters.</exception>
    public BookPublication(string authorName, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode)
        : this(authorName, string.Empty, title, publisher, published, bookBinding, isbnCode)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookPublication"/> class with the specified publisher, publication date, kind of book binding and an International Standard Book Number.
    /// </summary>
    /// <param name="authorName">A book author's name.</param>
    /// <param name="isni">A 16-digit ISNI code that uniquely identifies a book author.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="published">A book publication date.</param>
    /// <param name="bookBinding">A kind of book binding.</param>
    /// <param name="isbnCode">A 10-digit International Standard Book Number (ISBN) code assigned to a book publication.</param>
    /// <exception cref="ArgumentNullException"><paramref name="publisher"/> or <paramref name="bookNumber"/> or <paramref name="code"/> is null.</exception>
    /// <exception cref="ArgumentException"><paramref name="publisher"/> is empty or consists of white-space only characters.</exception>
    public BookPublication(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode)
    {
        ArgumentNullException.ThrowIfNull(publisher);
        ArgumentNullException.ThrowIfNull(isbnCode);
        ArgumentNullException.ThrowIfNull(isniCode);
        ArgumentNullException.ThrowIfNull(title);

        ArgumentException.ThrowIfNullOrWhiteSpace(publisher, nameof(publisher));

        this.Author = new BookAuthor(authorName, isniCode);
        this.Title = title;
        this.Publisher = publisher;
        this.Published = published;
        this.BookBinding = bookBinding;
        this.Isbn = new BookNumber(isbnCode);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BookPublication"/> class with the specified publisher, publication date, kind of book binding and an International Standard Book Number.
    /// </summary>
    /// <param name="author">A book author.</param>
    /// <param name="title">A book title.</param>
    /// <param name="publisher">A book publisher.</param>
    /// <param name="published">A book publication date.</param>
    /// <param name="bookBinding">A kind of book binding.</param>
    /// <param name="isbn">An International Standard Book Number assigned to a book publication.</param>
    /// <exception cref="ArgumentNullException"><paramref name="publisher"/> or <paramref name="isbn"/> is null.</exception>
    /// <exception cref="ArgumentException"><paramref name="publisher"/> is empty or consists of white-space only characters.</exception>
    public BookPublication(BookAuthor author, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbn)
    {
        ArgumentNullException.ThrowIfNull(author);
        ArgumentNullException.ThrowIfNull(publisher);
        ArgumentNullException.ThrowIfNull(title);
        ArgumentNullException.ThrowIfNull(isbn);

        ArgumentException.ThrowIfNullOrWhiteSpace(publisher, nameof(publisher));

        this.Author = author;
        this.Title = title;
        this.Publisher = publisher;
        this.Published = published;
        this.BookBinding = bookBinding;
        this.Isbn = isbn;
    }

    /// <summary>
    /// Gets a book author.
    /// </summary>
    public BookAuthor? Author { get; init; }

    /// <summary>
    /// Gets a book title.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// Gets a book publisher.
    /// </summary>
    public string? Publisher { get; init; }

    /// <summary>
    /// Gets a book publishing date.
    /// </summary>
    public DateTime Published { get; init; }

    /// <summary>
    /// Gets a book binding kind.
    /// </summary>
    public BookBindingKind BookBinding { get; init; }

    /// <summary>
    /// Gets a book International Standard Book Number (ISBN).
    /// </summary>
    public BookNumber? Isbn { get; init; }

    /// <summary>
    /// Gets a publication date as a string.
    /// </summary>
    /// <returns>A publication date as a string.</returns>
    public string GetPublicationDateString()
    {
        return this.Published.ToShortDateString();
    }

    /// <summary>
    /// Returns the string that represents a current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"{this.Title} by {this.Author}";
    }
}

namespace BookStoreCatalog;

/// <summary>
/// Represents an International Standard Book Number (ISBN).
/// </summary>
public class BookNumber
{
    private readonly string code;

    /// <summary>
    /// Initializes a new instance of the <see cref="BookNumber"/> class with the specified 10-digit ISBN <paramref name="isbnCode"/>.
    /// </summary>
    /// <param name="isbnCode">A 10-digit ISBN code.</param>
    /// <exception cref="ArgumentNullException">a code argument is null.</exception>
    /// <exception cref="ArgumentException">a code argument is invalid or a code has wrong checksum.</exception>
    public BookNumber(string isbnCode)
    {
        ArgumentNullException.ThrowIfNull(isbnCode);

        if (ValidateChecksum(isbnCode) && ValidateCode(isbnCode))
        {
            this.code = isbnCode;
        }
        else
        {
            throw new ArgumentException("Invalid code", nameof(isbnCode));
        }
    }

    /// <summary>
    /// Gets a 10-digit ISBN code.
    /// </summary>
    public string Code { get => this.code; }

    /// <summary>
    /// Gets an <see cref="Uri"/> to the publication page on the isbnsearch.org website.
    /// </summary>
    /// <returns>an <see cref="Uri"/> to the publication page on the isbnsearch.org website.</returns>
    public Uri GetSearchUri()
    {
        return new Uri($"https://isbnsearch.org/isbn/{this.code}");
    }

    /// <summary>
    /// Returns the string that represents a current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return this.code;
    }

    private static bool ValidateCode(string? isbnCode)
    {
        ArgumentNullException.ThrowIfNull(isbnCode);

        return isbnCode.Length == 10 && (isbnCode.All(char.IsDigit) || isbnCode.All(x => x == 'X'));
    }

    private static bool ValidateChecksum(string isbnCode)
    {
        int checksum = 0, i, t = 0;

        for (i = 0; i < isbnCode.Length; ++i)
        {
            int isbnEl = isbnCode[i] - '0';
            t += isbnEl;
            checksum += t;
        }

        return checksum % 11 == 0;
    }
}

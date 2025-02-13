using System.Reflection;
using NUnit.Framework;

namespace BookStoreCatalog.Tests;

[TestFixture]
public class BookPublicationTests : TestBase
{
    private static readonly object[][] ConstructorData =
    [
        [
            new[]
            {
                typeof(string), typeof(string), typeof(string), typeof(DateTime), typeof(BookBindingKind),
                typeof(string),
            }
        ],
        [
            new[]
            {
                typeof(string), typeof(string), typeof(string), typeof(string), typeof(DateTime),
                typeof(BookBindingKind), typeof(string),
            }
        ],
        [
            new[]
            {
                typeof(BookAuthor), typeof(string), typeof(string), typeof(DateTime), typeof(BookBindingKind),
                typeof(BookNumber),
            }
        ]
    ];

    private static readonly object[][] BookPublicationParameterIsNullData =
    [
        [
            null!, "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", "authorName"
        ],
        [
            "Edgar Allan Poe", null!, "Doubleday", new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077",
            "title"
        ],
        [
            "Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", null!, new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", "publisher"
        ],
        [
            "Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, null!, "isbnCode"
        ]
    ];

    private static readonly object[][] BookPublicationWithIsniCodeParameterIsNullData =
    [
        [
            null!, "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", "authorName"
        ],
        [
            "Edgar Allan Poe", null!, "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", "isniCode"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", null!, "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", "title"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", null!,
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", "publisher"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, null!, "isbnCode"
        ]
    ];

    private static readonly object[][] BookPublicationWithBookAuthorParameterIsNullData =
    [
        [
            null!, "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, new BookNumber("0385074077"), "author"
        ],
        [
            new BookAuthor("Edgar Allan Poe"), null!, "Doubleday", new DateTime(1966, 11, 18), BookBindingKind.Hardcover,
            new BookNumber("0385074077"), "title"
        ],
        [
            new BookAuthor("Edgar Allan Poe"), "Complete Stories and Poems of Edgar Allan Poe", null!,
            new DateTime(1966, 11, 18), BookBindingKind.Unknown, new BookNumber("0385074077"), "publisher"
        ],
        [
            new BookAuthor("Edgar Allan Poe"), "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, null!, "isbn"
        ]
    ];

    private static readonly object[][] BookPublicationData =
    [
        [
            "Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077"
        ]
    ];

    private static readonly object[][] BookPublicationWithIsniCodeData =
    [
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077"
        ]
    ];

    private static readonly object[][] BookPublicationWithBookAuthorData =
    [
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, new BookNumber("0385074077")
        ]
    ];

    private static readonly object[][] GetPublicationDateStringData =
    [
        [
            "Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", "November, 1966"
        ]
    ];

    private static readonly object[][] ToStringData =
    [
        [
            "Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", "Complete Stories and Poems of Edgar Allan Poe by Edgar Allan Poe"
        ]
    ];

    [SetUp]
    public void SetUp()
    {
        this.ClassType = typeof(BookPublication);
    }

    [TestCaseSource(nameof(BookPublicationParameterIsNullData))]
    public void BookPublication_ParameterIsNull_ThrowsArgumentNullException(string authorName, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, string parameterName)
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookPublication(authorName: authorName, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo(parameterName));
                throw;
            }
        });
    }

    [TestCaseSource(nameof(BookPublicationWithIsniCodeParameterIsNullData))]
    public void BookPublication_WithIsniCode_ParameterIsNull_ThrowsArgumentNullException(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, string parameterName)
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookPublication(authorName: authorName, isniCode: isniCode, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo(parameterName));
                throw;
            }
        });
    }

    [TestCaseSource(nameof(BookPublicationWithBookAuthorParameterIsNullData))]
    public void BookPublication_WithBookAuthor_ParameterIsNull_ThrowsArgumentNullException(BookAuthor author, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbn, string parameterName)
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookPublication(author: author, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbn: isbn);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo(parameterName));
                throw;
            }
        });
    }

    [TestCaseSource(nameof(BookPublicationData))]
    public void BookPublication_ParametersAreValid_ThrowsArgumentNullException(string authorName, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode)
    {
        // Act
        var publication = new BookPublication(authorName: authorName, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);

        // Assert
        Assert.That(publication.Author.AuthorName, Is.EqualTo(authorName));
        Assert.That(publication.Author.HasIsni, Is.False);
        Assert.That(publication.Title, Is.EqualTo(title));
        Assert.That(publication.Publisher, Is.EqualTo(publisher));
        Assert.That(publication.Published, Is.EqualTo(published));
        Assert.That(publication.BookBinding, Is.EqualTo(bookBinding));
        Assert.That(publication.Isbn.Code, Is.EqualTo(isbnCode));
    }

    [TestCaseSource(nameof(BookPublicationWithIsniCodeData))]
    public void BookPublication_WithIsniCode_ParametersAreValid_ThrowsArgumentNullException(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode)
    {
        // Act
        var publication = new BookPublication(authorName: authorName, isniCode: isniCode, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);

        // Assert
        Assert.That(publication.Author.AuthorName, Is.EqualTo(authorName));
        Assert.That(publication.Author.HasIsni, Is.True);
        Assert.That(publication.Author.Isni.Code, Is.EqualTo(isniCode));
        Assert.That(publication.Title, Is.EqualTo(title));
        Assert.That(publication.Publisher, Is.EqualTo(publisher));
        Assert.That(publication.Published, Is.EqualTo(published));
        Assert.That(publication.BookBinding, Is.EqualTo(bookBinding));
        Assert.That(publication.Isbn.Code, Is.EqualTo(isbnCode));
    }

    [TestCaseSource(nameof(BookPublicationWithBookAuthorData))]
    public void BookPublication_WithBookAuthor_ParametersAreValid_ThrowsArgumentNullException(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbn)
    {
        // Act
        var publication = new BookPublication(new BookAuthor(authorName, isniCode), title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbn: isbn);

        // Assert
        Assert.That(publication.Author.AuthorName, Is.EqualTo(authorName));
        Assert.That(publication.Author.HasIsni, Is.True);
        Assert.That(publication.Author.Isni.Code, Is.EqualTo(isniCode));
        Assert.That(publication.Title, Is.EqualTo(title));
        Assert.That(publication.Publisher, Is.EqualTo(publisher));
        Assert.That(publication.Published, Is.EqualTo(published));
        Assert.That(publication.BookBinding, Is.EqualTo(bookBinding));
        Assert.That(publication.Isbn.Code, Is.EqualTo(isbn.Code));
    }

    [TestCaseSource(nameof(GetPublicationDateStringData))]
    public void GetPublicationDateString_ReturnsString(string authorName, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, string expectedResult)
    {
        // Arrange
        var publication = new BookPublication(authorName: authorName, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);

        // Act
        string actualResult = publication.GetPublicationDateString();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [TestCaseSource(nameof(ToStringData))]
    public void ToString_ReturnsString(string authorName, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, string expectedResult)
    {
        // Arrange
        var publication = new BookPublication(authorName: authorName, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);

        // Act
        string actualResult = publication.ToString();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void IsPublicClass()
    {
        this.AssertThatClassIsPublic(false);
    }

    [Test]
    public void InheritsObject()
    {
        this.AssertThatClassInheritsObject();
    }

    [Test]
    public void HasRequiredMembers()
    {
        Assert.That(0, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(6, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(3, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(6, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(14, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetEvents(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Length));
    }

    [TestCaseSource(nameof(ConstructorData))]
    public void HasPublicInstanceConstructor(Type[] parameterTypes)
    {
        this.AssertThatClassHasPublicConstructor(parameterTypes);
    }

    [TestCase("Author", typeof(BookAuthor))]
    [TestCase("Title", typeof(string))]
    [TestCase("Publisher", typeof(string))]
    [TestCase("Published", typeof(DateTime))]
    [TestCase("BookBinding", typeof(BookBindingKind))]
    [TestCase("Isbn", typeof(BookNumber))]
    public void HasPublicProperty(string propertyName, Type propertyType)
    {
        this.AssertThatClassHasProperty(propertyName, propertyType, true, true, true, true);
    }

    [TestCase("GetPublicationDateString", false, true, false, typeof(string))]
    [TestCase("ToString", false, true, true, typeof(string))]
    public void HasMethod(string methodName, bool isStatic, bool isPublic, bool isVirtual, Type returnType)
    {
        this.AssertThatClassHasMethod(methodName, isStatic, isPublic, isVirtual, returnType);
    }
}

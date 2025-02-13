using System.Reflection;
using NUnit.Framework;

namespace BookStoreCatalog.Tests;

[TestFixture]
public class BookStoreItemTests : TestBase
{
    private static readonly object[][] ConstructorData =
    [
        [
            new[]
            {
                typeof(string), typeof(string), typeof(string), typeof(string), typeof(DateTime),
                typeof(BookBindingKind), typeof(string), typeof(decimal), typeof(string), typeof(int),
            }
        ],
        [
            new[] { typeof(BookPublication), typeof(BookPrice), typeof(int) }
        ]
    ];

    private static readonly object[][] BookStoreItemWithAuthorNameParameterIsNullData =
    [
        [
            null!, "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3, "authorName"
        ],
        [
            "Edgar Allan Poe", null!, "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3, "isniCode"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", null!, "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3, "title"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", null!,
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3, "publisher"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, null!, 10.11m, "USD", 3, "isbnCode"
        ],
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", 10.11m, null!, 3, "currency"
        ]
    ];

    private static readonly object[][] BookStoreItemValidParametersData =
    [
        [
            "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
            new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3
        ]
    ];

    private static readonly object[][] ToStringData =
    [
        [
            "Complete Stories and Poems of Edgar Allan Poe by Edgar Allan Poe (ISNI:0000000121354025), 10.11 USD, 3",
            new object[]
            {
                "Edgar Allan Poe", "0000000121354025", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday",
                new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3,
            }
        ],
        [
            "Complete Stories and Poems of Edgar Allan Poe by Edgar Allan Poe, 123.12 EUR, 3",
            new object[]
            {
                new BookPublication("Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077"),
                new BookPrice(123.123m, "EUR"), 3,
            }
        ],
        [
            "Complete Stories and Poems of Edgar Allan Poe by Edgar Allan Poe, \"123,456,789.12 GDP\", 123456789",
            new object[]
            {
                new BookPublication("Edgar Allan Poe", "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18), BookBindingKind.Hardcover, "0385074077"),
                new BookPrice(123456789.123m, "GDP"), 123456789,
            }
        ]
    ];

    [SetUp]
    public void SetUp()
    {
        this.ClassType = typeof(BookStoreItem);
    }

    [TestCaseSource(nameof(BookStoreItemWithAuthorNameParameterIsNullData))]
    public void BookStoreItem_WithAuthorName_ParameterIsNull_ThrowsArgumentNullException(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, decimal priceAmount, string priceCurrency, int amount, string parameterName)
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                // Act
                _ = new BookStoreItem(authorName: authorName, isniCode: isniCode, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbn: isbnCode, priceAmount: priceAmount, priceCurrency: priceCurrency, amount: amount);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo(parameterName));
                throw;
            }
        });
    }

    [Test]
    public void BookStoreItem_PublicationIsNull_ThrowsArgumentNullException()
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                // Act
                _ = new BookStoreItem(publication: null!, price: new BookPrice(10.11m, "USD"), amount: 3);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("publication"));
                throw;
            }
        });
    }

    [Test]
    public void BookStoreItem_PriceIsNull_ThrowsArgumentNullException()
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                // Act
                _ = new BookStoreItem(
                    publication: new BookPublication(new BookAuthor("Edgar Allan Poe", "0000000121354025"), "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18), BookBindingKind.Hardcover, new BookNumber("0385074077")), price: null!, amount: 3);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("price"));
                throw;
            }
        });
    }

    [TestCase(-1)]
    [TestCase(-100)]
    public void BookStoreItem_AmountIsNotValid_ThrowsArgumentOutOfRangeException(int amount)
    {
        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            try
            {
                // Act
                _ = new BookStoreItem(
                    publication: new BookPublication(new BookAuthor("Edgar Allan Poe", "0000000121354025"),
                        "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
                        BookBindingKind.Hardcover, new BookNumber("0385074077")), price: new BookPrice(10.11m, "USD"),
                    amount: amount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("amount"));
                throw;
            }
        });
    }

    [Test]
    public void Publication_ValueIsNull_ThrowsArgumentNullException()
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() =>
        {
            var bookStoreItem = new BookStoreItem(authorName: "Edgar Allan Poe", isniCode: "0000000121354025",
                title: "Complete Stories and Poems of Edgar Allan Poe", publisher: "Doubleday",
                published: new DateTime(1966, 11, 18), bookBinding: BookBindingKind.Hardcover, isbn: "0385074077",
                priceAmount: 10.11m, priceCurrency: "USD", amount: 3);

            try
            {
                // Act
                bookStoreItem.Publication = null!;
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("value"));
                throw;
            }
        });
    }

    [Test]
    public void Price_PriceIsNull_ThrowsArgumentNullException()
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() =>
        {
            var bookStoreItem = new BookStoreItem("Edgar Allan Poe", "0000000121354025",
                "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
                BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3);

            try
            {
                // Act
                bookStoreItem.Price = null!;
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("value"));
                throw;
            }
        });
    }

    [TestCase(-10)]
    [TestCase(-100_000)]
    public void Amount_ValueIsNotValid_ThrowsArgumentOutOfRangeException(int amount)
    {
        // Arrange
        var bookStoreItem = new BookStoreItem("Edgar Allan Poe", "0000000121354025",
            "Complete Stories and Poems of Edgar Allan Poe", "Doubleday", new DateTime(1966, 11, 18),
            BookBindingKind.Hardcover, "0385074077", 10.11m, "USD", 3);

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            try
            {
                // Act
                bookStoreItem.Amount = amount;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("value"));
                throw;
            }
        });
    }

    [TestCaseSource(nameof(BookStoreItemValidParametersData))]
    public void BookStoreItem_WithAuthorName_ReturnsNewObject(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, decimal priceAmount, string priceCurrency, int amount)
    {
        // Act
        var bookStoreItem = new BookStoreItem(authorName: authorName, isniCode: isniCode, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbn: isbnCode, priceAmount: priceAmount, priceCurrency: priceCurrency, amount: amount);

        // Assert
        Assert.That(bookStoreItem.Publication, Is.Not.Null);
        Assert.That(bookStoreItem.Publication.Author.AuthorName, Is.EqualTo(authorName));
        Assert.That(bookStoreItem.Publication.Author.HasIsni, Is.True);
        Assert.That(bookStoreItem.Publication.Author.Isni.Code, Is.EqualTo(isniCode));
        Assert.That(bookStoreItem.Publication.Title, Is.EqualTo(title));
        Assert.That(bookStoreItem.Publication.Publisher, Is.EqualTo(publisher));
        Assert.That(bookStoreItem.Publication.Published, Is.EqualTo(published));
        Assert.That(bookStoreItem.Publication.BookBinding, Is.EqualTo(bookBinding));
        Assert.That(bookStoreItem.Publication.Isbn.Code, Is.EqualTo(isbnCode));
        Assert.That(bookStoreItem.Price, Is.Not.Null);
        Assert.That(bookStoreItem.Price.Amount, Is.EqualTo(priceAmount));
        Assert.That(bookStoreItem.Price.Currency, Is.EqualTo(priceCurrency));
        Assert.That(bookStoreItem.Amount, Is.EqualTo(amount));
    }

    [TestCaseSource(nameof(BookStoreItemValidParametersData))]
    public void BookStoreItem_WithAuthor_ReturnsNewObject(string authorName, string isniCode, string title,
        string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode, decimal priceAmount,
        string priceCurrency, int amount)
    {
        // Arrange
        var publication = new BookPublication(new BookAuthor(authorName, isniCode), title, publisher, published,
            bookBinding, new BookNumber(isbnCode));
        var price = new BookPrice(priceAmount, priceCurrency);

        // Act
        var bookStoreItem = new BookStoreItem(publication: publication, price: price, amount: amount);

        // Assert
        Assert.That(bookStoreItem.Publication, Is.Not.Null);
        Assert.That(bookStoreItem.Publication.Author.AuthorName, Is.EqualTo(publication.Author.AuthorName));
        Assert.That(bookStoreItem.Publication.Author.HasIsni, Is.True);
        Assert.That(bookStoreItem.Publication.Author.Isni.Code, Is.EqualTo(publication.Author.Isni.Code));
        Assert.That(bookStoreItem.Publication.Title, Is.EqualTo(publication.Title));
        Assert.That(bookStoreItem.Publication.Publisher, Is.EqualTo(publication.Publisher));
        Assert.That(bookStoreItem.Publication.Published, Is.EqualTo(publication.Published));
        Assert.That(bookStoreItem.Publication.BookBinding, Is.EqualTo(publication.BookBinding));
        Assert.That(bookStoreItem.Publication.Isbn.Code, Is.EqualTo(publication.Isbn.Code));
        Assert.That(bookStoreItem.Price, Is.Not.Null);
        Assert.That(bookStoreItem.Price.Amount, Is.EqualTo(price.Amount));
        Assert.That(bookStoreItem.Price.Currency, Is.EqualTo(price.Currency));
        Assert.That(bookStoreItem.Amount, Is.EqualTo(amount));
    }

    [TestCaseSource(nameof(ToStringData))]
    public void ToString_ReturnsString(string expectedString, object[] constructorParameters)
    {
        // Arrange
        var bookStoreItem = (BookStoreItem)Activator.CreateInstance(this.ClassType, constructorParameters)!;

        // Act
        string actualString = bookStoreItem.ToString();

        // Assert
        Assert.That(actualString, Is.EqualTo(expectedString));
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
        Assert.That(0,
            Is.EqualTo(this.ClassType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(3, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0,
            Is.EqualTo(this.ClassType
                .GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(2, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0,
            Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0,
            Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Length));
        Assert.That(3, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0,
            Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Length));
        Assert.That(0,
            Is.EqualTo(this.ClassType
                .GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(7,
            Is.EqualTo(this.ClassType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0,
            Is.EqualTo(this.ClassType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0,
            Is.EqualTo(this.ClassType
                .GetEvents(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Length));
    }

    [TestCase("publication", typeof(BookPublication), false)]
    [TestCase("price", typeof(BookPrice), false)]
    [TestCase("amount", typeof(int), false)]
    public void HasRequiredField(string fieldName, Type fieldType, bool isInitOnly)
    {
        this.AssertThatClassHasField(fieldName, fieldType, isInitOnly);
    }

    [TestCaseSource(nameof(ConstructorData))]
    public void HasPublicInstanceConstructor(Type[] parameterTypes)
    {
        this.AssertThatClassHasPublicConstructor(parameterTypes);
    }

    [TestCase("Publication", typeof(BookPublication))]
    [TestCase("Price", typeof(BookPrice))]
    [TestCase("Amount", typeof(int))]
    public void HasPublicProperty(string propertyName, Type propertyType)
    {
        this.AssertThatClassHasProperty(propertyName, propertyType, true, true, true, true);
    }

    [TestCase("ToString", false, true, true, typeof(string))]
    public void HasMethod(string methodName, bool isStatic, bool isPublic, bool isVirtual, Type returnType)
    {
        this.AssertThatClassHasMethod(methodName, isStatic, isPublic, isVirtual, returnType);
    }
}

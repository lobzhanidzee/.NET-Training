using System.Reflection;
using NUnit.Framework;

namespace BookStoreCatalog.Tests;

[TestFixture]
public class BookAuthorTests : TestBase
{
    private static readonly object[][] ConstructorData =
    [
        [
            new[] { typeof(string) }
        ],
        [
            new[] { typeof(string), typeof(string) }
        ],
        [
            new[] { typeof(string), typeof(NameIdentifier) }
        ]
    ];

    private static readonly object[][] BookAuthorNameAndIsniAreValidData =
    [
        ["Edgar Allan Poe", new NameIdentifier("0000000121354025")]
    ];

    private static readonly object[][] BookAuthorNameOrIsniIsNullData =
    [
        [null!, new NameIdentifier("0000000121354025"), "authorName"],
        ["Edgar Allan Poe", null!, "nameIdentifier"]
    ];

    private static readonly object[][] ToStringNameIdentifierData =
    [
        ["Edgar Allan Poe", new NameIdentifier("0000000121354025"), "Edgar Allan Poe (ISNI:0000000121354025)"]
    ];

    [SetUp]
    public void SetUp()
    {
        this.ClassType = typeof(BookAuthor);
    }

    [Test]
    public void BookAuthor_NameIsNull_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookAuthor(authorName: null!);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("authorName"));
                throw;
            }
        });
    }

    [TestCase(null, "0000000121354025", "authorName")]
    [TestCase("Edgar Allan Poe", null, "isniCode")]
    public void BookAuthor_NameOrIsniCodeIsNull_ThrowsArgumentNullException(string name, string isniCode,
        string parameterName)
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookAuthor(authorName: name, isniCode: isniCode);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo(parameterName));
                throw;
            }
        });
    }

    [TestCaseSource(nameof(BookAuthorNameOrIsniIsNullData))]
    public void BookAuthor_NameOrIsniIsNull_ThrowsArgumentNullException(string name, NameIdentifier nameIdentifier,
        string parameterName)
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookAuthor(authorName: name, nameIdentifier: nameIdentifier);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo(parameterName));
                throw;
            }
        });
    }

    [TestCase("Edgar Allan Poe")]
    public void BookAuthor_NameIsValid_ReturnsNameAndHasIsni(string name)
    {
        // Act
        var bookAuthor = new BookAuthor(name);

        // Assert
        Assert.That(bookAuthor.AuthorName, Is.EqualTo(name));
        Assert.That(bookAuthor.HasIsni, Is.False);
    }

    [TestCase("Edgar Allan Poe", "0000000121354025")]
    public void BookAuthor_NameAndIsniCodeAreValid_ReturnsNameAndHasIsni(string name, string isni)
    {
        // Act
        var bookAuthor = new BookAuthor(name, isni);

        // Assert
        Assert.That(bookAuthor.AuthorName, Is.EqualTo(name));
        Assert.That(bookAuthor.HasIsni, Is.True);
    }

    [TestCaseSource(nameof(BookAuthorNameAndIsniAreValidData))]
    public void BookAuthor_NameAndIsniAreValid_ReturnsNameAndHasIsni(string name, NameIdentifier nameIdentifier)
    {
        // Act
        var bookAuthor = new BookAuthor(name, nameIdentifier);

        // Assert
        Assert.That(bookAuthor.AuthorName, Is.EqualTo(name));
        Assert.That(bookAuthor.HasIsni, Is.True);
    }

    [TestCase("Edgar Allan Poe")]
    public void ToString_NameOnly_ReturnsString(string name)
    {
        // Arrange
        var bookAuthor = new BookAuthor(authorName: name);

        // Act
        var actualResult = bookAuthor.ToString();

        // Assert
        Assert.That(actualResult, Is.EqualTo(name));
    }

    [TestCase("Edgar Allan Poe", "0000000121354025", ExpectedResult = "Edgar Allan Poe (ISNI:0000000121354025)")]
    public string ToString_IsniCodeIsValid_ReturnsString(string name, string isniCode)
    {
        // Arrange
        var bookAuthor = new BookAuthor(authorName: name, isniCode: isniCode);

        // Act
        return bookAuthor.ToString();
    }

    [TestCaseSource(nameof(ToStringNameIdentifierData))]
    public void ToString_IsniIsValid_ReturnsFalse(string name, NameIdentifier nameIdentifier, string expectedResult)
    {
        // Arrange
        var bookAuthor = new BookAuthor(authorName: name, nameIdentifier: nameIdentifier);

        // Act
        var actualResult = bookAuthor.ToString();

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
        Assert.That(0,
            Is.EqualTo(this.ClassType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                .Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(3, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0,
            Is.EqualTo(this.ClassType
                .GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(3, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
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

        Assert.That(4,
            Is.EqualTo(this.ClassType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(3,
            Is.EqualTo(this.ClassType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0,
            Is.EqualTo(this.ClassType
                .GetEvents(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Length));
    }

    [TestCaseSource(nameof(ConstructorData))]
    public void HasPublicInstanceConstructor(Type[] parameterTypes)
    {
        this.AssertThatClassHasPublicConstructor(parameterTypes);
    }

    [TestCase("AuthorName", typeof(string))]
    [TestCase("HasIsni", typeof(bool))]
    [TestCase("Isni", typeof(NameIdentifier))]
    public void HasPublicProperty(string propertyName, Type propertyType)
    {
        this.AssertThatClassHasProperty(propertyName, propertyType, true, true, false, false);
    }

    [TestCase("ToString", false, true, true, typeof(string))]
    public void HasMethod(string methodName, bool isStatic, bool isPublic, bool isVirtual, Type returnType)
    {
        this.AssertThatClassHasMethod(methodName, isStatic, isPublic, isVirtual, returnType);
    }
}

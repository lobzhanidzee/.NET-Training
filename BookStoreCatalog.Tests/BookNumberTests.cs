using System.Reflection;
using NUnit.Framework;

namespace BookStoreCatalog.Tests;

[TestFixture]
public class BookNumberTests : TestBase
{
    private static readonly object[][] ConstructorData =
    [
        [
            new[] { typeof(string) }
        ]
    ];

    [SetUp]
    public void SetUp()
    {
        this.ClassType = typeof(BookNumber);
    }

    [Test]
    public void BookNumber_CodeIsNull_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new BookNumber(isbnCode: null!);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("isbnCode"));
                throw;
            }
        });
    }

    [TestCase("")]
    [TestCase("   ")]
    [TestCase("161729453")]
    [TestCase("16172945345")]
    public void BookNumber_CodeIsInvalid_ThrowsArgumentException(string code)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            try
            {
                _ = new BookNumber(isbnCode: code);
            }
            catch (ArgumentException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("isbnCode"));
                throw;
            }
        });
    }

    [TestCase("1617294534")]
    public void BookNumber_CodeHasWrongChecksum_ThrowsArgumentException(string code)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            try
            {
                _ = new BookNumber(isbnCode: code);
            }
            catch (ArgumentException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("isbnCode"));
                throw;
            }
        });
    }

    [TestCase("1617294535")]
    public void GetCode_CodeIsValid_ReturnsCode(string code)
    {
        // Arrange
        var bookNumber = new BookNumber(isbnCode: code);

        // Act
        string actualCode = bookNumber.Code;

        // Assert
        Assert.That(actualCode, Is.EqualTo(code));
    }

    [TestCase("1617294535", ExpectedResult = "https://isbnsearch.org/isbn/1617294535")]
    public string GetSearchUri_CodeIsValid_ReturnsUri(string expectedCode)
    {
        // Arrange
        var bookNumber = new BookNumber(isbnCode: expectedCode);

        // Act
        Uri actualUri = bookNumber.GetSearchUri();

        return actualUri.AbsoluteUri;
    }

    [TestCase("1617294535")]
    public void ToString_CodeIsValid_ReturnsString(string code)
    {
        // Arrange
        var bookNumber = new BookNumber(isbnCode: code);

        // Act
        string actualString = bookNumber.ToString();

        // Assert
        Assert.That(actualString, Is.EqualTo(code));
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
        Assert.That(1, Is.EqualTo(this.ClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(1, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(1, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(2, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(3, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetEvents(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Length));
    }

    [TestCase("code", typeof(string), true)]
    public void HasRequiredField(string fieldName, Type fieldType, bool isInitOnly)
    {
        this.AssertThatClassHasField(fieldName, fieldType, isInitOnly);
    }

    [TestCaseSource(nameof(ConstructorData))]
    public void HasPublicInstanceConstructor(Type[] parameterTypes)
    {
        this.AssertThatClassHasPublicConstructor(parameterTypes);
    }

    [TestCase("Code", typeof(string))]
    public void HasPublicProperty(string propertyName, Type propertyType)
    {
        this.AssertThatClassHasProperty(propertyName, propertyType, true, true, false, false);
    }

    [TestCase("GetSearchUri", false, true, false, typeof(Uri))]
    [TestCase("ToString", false, true, true, typeof(string))]
    [TestCase("ValidateCode", true, false, false, typeof(bool))]
    [TestCase("ValidateChecksum", true, false, false, typeof(bool))]
    public void HasMethod(string methodName, bool isStatic, bool isPublic, bool isVirtual, Type returnType)
    {
        this.AssertThatClassHasMethod(methodName, isStatic, isPublic, isVirtual, returnType);
    }
}

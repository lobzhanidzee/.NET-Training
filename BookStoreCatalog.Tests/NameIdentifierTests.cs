using System.Reflection;
using NUnit.Framework;

namespace BookStoreCatalog.Tests;

[TestFixture]
public class NameIdentifierTests : TestBase
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
        this.ClassType = typeof(NameIdentifier);
    }

    [Test]
    public void NameIdentifier_CodeIsNull_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            try
            {
                _ = new NameIdentifier(isniCode: null!);
            }
            catch (ArgumentNullException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("isniCode"));
                throw;
            }
        });
    }

    [TestCase("")]
    [TestCase("   ")]
    [TestCase("000000012135402")]
    [TestCase("00000001213540256")]
    public void NameIdentifier_CodeIsInvalid_ThrowsArgumentException(string code)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            try
            {
                _ = new NameIdentifier(isniCode: code);
            }
            catch (ArgumentException e)
            {
                Assert.That(e.ParamName, Is.EqualTo("isniCode"));
                throw;
            }
        });
    }

    [TestCase("0000000121354025")]
    public void GetCode_CodeIsValid_ReturnsCode(string code)
    {
        // Arrange
        var nameIdentifier = new NameIdentifier(isniCode: code);

        // Act
        string actualCode = nameIdentifier.Code;

        // Assert
        Assert.That(actualCode, Is.EqualTo(code));
    }

    [TestCase("0000000121354025", ExpectedResult = "http://www.isni.org/isni/0000000121354025")]
    public string GetUri_CodeIsValid_ReturnsUri(string expectedCode)
    {
        // Arrange
        var nameIdentifier = new NameIdentifier(isniCode: expectedCode);

        // Act
        Uri actualUri = nameIdentifier.GetUri();

        return actualUri.AbsoluteUri;
    }

    [TestCase("0000000121354025")]
    public void ToString_CodeIsValid_ReturnsString(string code)
    {
        // Arrange
        var nameIdentifier = new NameIdentifier(isniCode: code);

        // Act
        string actualString = nameIdentifier.ToString();

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
        Assert.That(1, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(4, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.ClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0, Is.EqualTo(this.ClassType.GetEvents(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Length));
    }

    [TestCaseSource(nameof(ConstructorData))]
    public void HasPublicInstanceConstructor(Type[] parameterTypes)
    {
        this.AssertThatClassHasPublicConstructor(parameterTypes);
    }

    [TestCase("Code", typeof(string))]
    public void HasPublicProperty(string propertyName, Type propertyType)
    {
        this.AssertThatClassHasProperty(propertyName, propertyType, true, true, true, true);
    }

    [TestCase("GetUri", false, true, false, typeof(Uri))]
    [TestCase("ToString", false, true, true, typeof(string))]
    [TestCase("ValidateCode", true, false, false, typeof(bool))]
    public void HasMethod(string methodName, bool isStatic, bool isPublic, bool isVirtual, Type returnType)
    {
        this.AssertThatClassHasMethod(methodName, isStatic, isPublic, isVirtual, returnType);
    }
}

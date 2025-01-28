using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleStaticClass4Tests
{
    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleStaticClass4")!;
    }

    [Test]
    public void IsClass()
    {
        Assert.That(this.classType.IsClass);
    }

    [Test]
    public void IsStaticClass()
    {
        Assert.That(this.classType.IsAbstract);
        Assert.That(this.classType.IsSealed);
    }

    [Test]
    public void IsPublic()
    {
        Assert.That(this.classType.IsPublic);
    }

    [Test]
    public void InheritsObject()
    {
        Assert.That(typeof(object), Is.EqualTo(this.classType.BaseType));
    }

    [Test]
    public void HasRequiredMembers()
    {
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Static | BindingFlags.Public).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetFields(BindingFlags.Static | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public).Length));
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Static | BindingFlags.NonPublic).Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(flags).Length));
    }

    [TestCase("intField", typeof(int), ExpectedResult = 212)]
    [TestCase("longField", typeof(long), ExpectedResult = -232)]
    [TestCase("floatField", typeof(float), ExpectedResult = 2.12F)]
    [TestCase("doubleField", typeof(double), ExpectedResult = 2.121)]
    [TestCase("charField", typeof(char), ExpectedResult = 'b')]
    [TestCase("booleanField", typeof(bool), ExpectedResult = true)]
    [TestCase("stringField", typeof(string), ExpectedResult = "def")]
    public object HasRequiredField(string fieldName, Type expectedType)
    {
        // Act
        var fieldInfo = this.classType.GetField(fieldName, BindingFlags.Static | BindingFlags.NonPublic);

        // Assert
        Assert.That(fieldInfo is not null);
        Assert.That(fieldInfo!.IsStatic);
        Assert.That(expectedType, Is.EqualTo(fieldInfo.FieldType));

        var value = fieldInfo.GetValue(null);
        return value!;
    }

    [Test]
    public void HasObjectField()
    {
        // Act
        var fieldInfo = this.classType.GetField("objectField", BindingFlags.Static | BindingFlags.NonPublic);

        // Assert
        Assert.That(fieldInfo is not null);
        Assert.That(fieldInfo!.IsStatic);
        Assert.That(typeof(object), Is.EqualTo(fieldInfo.FieldType));

        var result = fieldInfo.GetValue(null);
        Assert.That(result is not null);
        Assert.That(this.classType, Is.EqualTo(result));
    }

    [TestCase("GetInteger", typeof(int), ExpectedResult = 212)]
    [TestCase("GetLongInteger", typeof(long), ExpectedResult = -232)]
    [TestCase("GetFloat", typeof(float), ExpectedResult = 2.12F)]
    [TestCase("GetDouble", typeof(double), ExpectedResult = 2.121)]
    [TestCase("GetChar", typeof(char), ExpectedResult = 'b')]
    [TestCase("GetBoolean", typeof(bool), ExpectedResult = true)]
    [TestCase("GetString", typeof(string), ExpectedResult = "def")]
    public object HasRequiredMethod(string methodName, Type methodReturnType)
    {
        // Act
        var methodInfo = this.classType.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public);

        // Assert
        Assert.That(methodInfo is not null);
        Assert.That(methodInfo!.IsStatic);
        Assert.That(methodReturnType, Is.EqualTo(methodInfo.ReturnType));

        return methodInfo!.Invoke(null, Array.Empty<object>())!;
    }

    [Test]
    public void HasGetObjectMethod()
    {
        // Act
        var methodInfo = this.classType.GetMethod("GetObject", BindingFlags.Static | BindingFlags.Public);

        // Assert
        Assert.That(methodInfo is not null);
        Assert.That(methodInfo!.IsStatic);
        Assert.That(typeof(object), Is.EqualTo(methodInfo.ReturnType));

        var result = methodInfo.Invoke(null, Array.Empty<object>());
        Assert.That(result is not null);
        Assert.That(this.classType, Is.EqualTo(result));
    }
}

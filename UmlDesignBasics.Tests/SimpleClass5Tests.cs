using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass5Tests
{
    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass5")!;
    }

    [Test]
    public void IsClass()
    {
        Assert.That(this.classType.IsClass);
    }

    [Test]
    public void IsNotStaticClass()
    {
        Assert.That(!this.classType.IsAbstract);
        Assert.That(!this.classType.IsSealed);
    }

    [Test]
    public void InheritsObject()
    {
        Assert.That(typeof(object), Is.EqualTo(this.classType.BaseType));
    }

    [Test]
    public void HasRequiredMembers()
    {
        Assert.That(
            0,
            Is.EqualTo(this.classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(
            0,
            Is.EqualTo(this.classType.GetMethods(
                BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
        Assert.That(
            8,
            Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(
            0,
            Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                .Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(flags).Length));
    }

    [TestCase("intField", typeof(int))]
    [TestCase("longField", typeof(long))]
    [TestCase("floatField", typeof(float))]
    [TestCase("doubleField", typeof(double))]
    [TestCase("charField", typeof(char))]
    [TestCase("booleanField", typeof(bool))]
    [TestCase("stringField", typeof(string))]
    [TestCase("objectField", typeof(object))]
    public void HasRequiredField(string fieldName, Type expectedType)
    {
        var fieldInfo = this.classType.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

        Assert.That(fieldInfo is not null);
        Assert.That(expectedType, Is.EqualTo(fieldInfo!.FieldType));
        Assert.That(fieldInfo.FieldType == expectedType);
    }

    [TestCase("GetInteger", typeof(int), ExpectedResult = -216)]
    [TestCase("GetLong", typeof(long), ExpectedResult = -621)]
    [TestCase("GetFloat", typeof(float), ExpectedResult = -54.62F)]
    [TestCase("GetDouble", typeof(double), ExpectedResult = -62.054)]
    [TestCase("GetChar", typeof(char), ExpectedResult = 'd')]
    [TestCase("GetBoolean", typeof(bool), ExpectedResult = true)]
    [TestCase("GetString", typeof(string), ExpectedResult = "defabc")]
    [TestCase("GetObject", typeof(object), ExpectedResult = typeof(int))]
    public object HasGetMethod(string methodName, Type expectedReturnType)
    {
        var methodInfo = this.classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(methodInfo is not null);
        Assert.That(expectedReturnType, Is.EqualTo(methodInfo!.ReturnType));

        var instance = Activator.CreateInstance(this.classType);
        var result = methodInfo.Invoke(instance, Array.Empty<object>());
        Assert.That(result is not null);

        return result!;
    }
}

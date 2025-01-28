using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass8Tests
{
    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass8")!;
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
            Is.EqualTo(
                this.classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(
            0,
            Is.EqualTo(this.classType.GetMethods(
                BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
        Assert.That(
            16,
            Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(
            0,
            Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                .Length));

        Assert.That(
            0,
            Is.EqualTo(this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(
            0,
            Is.EqualTo(this.classType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
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

    [TestCase("IntValue", typeof(int), 754)]
    [TestCase("LongValue", typeof(long), 721)]
    [TestCase("FloatValue", typeof(float), -76.67F)]
    [TestCase("DoubleValue", typeof(double), 372.127)]
    [TestCase("CharValue", typeof(char), 'e')]
    [TestCase("BooleanValue", typeof(bool), true)]
    [TestCase("StringValue", typeof(string), "ghi")]
    [TestCase("ObjectValue", typeof(object), typeof(SimpleClass8Tests))]
    public void HasProperty(string propertyName, Type expectedPropertyType, object value)
    {
        var propertyInfo = this.classType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(propertyInfo is not null);
        Assert.That(expectedPropertyType, Is.EqualTo(propertyInfo!.PropertyType));

        var instance = Activator.CreateInstance(this.classType);
        propertyInfo.SetValue(instance, value);

        var actualValue = propertyInfo.GetValue(instance);

        Assert.That(actualValue is not null);
        Assert.That(value, Is.EqualTo(actualValue));
    }
}

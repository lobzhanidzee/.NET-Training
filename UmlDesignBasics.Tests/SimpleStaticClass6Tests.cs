using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleStaticClass6Tests
{
    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleStaticClass6")!;
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
        Assert.That(
            7,
            Is.EqualTo(this.classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(
            0,
            Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Length));

        Assert.That(
            1,
            Is.EqualTo(this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(
            0,
            Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetMethods(flags | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
    }

    [TestCase("IntType", ExpectedResult = typeof(int))]
    [TestCase("LongType", ExpectedResult = typeof(long))]
    [TestCase("FloatType", ExpectedResult = typeof(float))]
    [TestCase("DoubleType", ExpectedResult = typeof(double))]
    [TestCase("CharType", ExpectedResult = typeof(char))]
    [TestCase("BooleanType", ExpectedResult = typeof(bool))]
    [TestCase("StringType", ExpectedResult = typeof(string))]
    public object HasRequiredField(string fieldName)
    {
        // Act
        var fieldInfo = this.classType.GetField(fieldName, BindingFlags.Static | BindingFlags.Public);

        // Assert
        Assert.That(fieldInfo is not null);
        Assert.That(fieldInfo!.IsInitOnly);
        Assert.That(typeof(object), Is.EqualTo(fieldInfo.FieldType));

        var value = fieldInfo.GetValue(null);
        return value!;
    }
}

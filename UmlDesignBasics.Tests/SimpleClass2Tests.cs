using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass2Tests
{
    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass2")!;
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
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(4, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(4, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetMethods(flags | BindingFlags.DeclaredOnly).Length));
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(flags).Length));
    }

    [TestCase("IntField", typeof(int), true)]
    [TestCase("longField", typeof(long), false)]
    [TestCase("FloatField", typeof(float), true)]
    [TestCase("DoubleField", typeof(double), true)]
    [TestCase("charField", typeof(char), false)]
    [TestCase("BooleanField", typeof(bool), true)]
    [TestCase("stringField", typeof(string), false)]
    [TestCase("objectField", typeof(object), false)]
    public void HasRequiredField(string fieldName, Type expectedType, bool isPublic)
    {
        // Arrange
        BindingFlags flags = isPublic
            ? BindingFlags.Instance | BindingFlags.Public
            : BindingFlags.Instance | BindingFlags.NonPublic;

        // Act
        var fieldInfo = this.classType.GetField(fieldName, flags);

        // Assert
        Assert.That(fieldInfo is not null);
        Assert.That(!fieldInfo!.IsStatic);
        Assert.That(expectedType, Is.EqualTo(fieldInfo.FieldType));
    }
}

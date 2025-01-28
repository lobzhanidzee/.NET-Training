using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass16Tests
{
    private static readonly object[][] ConstructorData =
    [
        [
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char), typeof(bool), typeof(string), typeof(object) },
                new object[] { 0, 0L, 0.0F, 0.0, 'a', true, string.Empty, null! }
        ]
    ];

    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass16")!;
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
        Assert.That(8, Is.EqualTo(this.classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
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

    [TestCaseSource(nameof(ConstructorData))]
    public void HasConstructor(Type[] parameterTypes, object[] constructorArguments)
    {
        var constructorInfo = this.classType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, parameterTypes, null);
        Assert.That(constructorInfo is not null);

        var instance = constructorInfo!.Invoke(constructorArguments);
        //Assert.That(instance is not null);

        this.TestObjectProperty(instance, "IntValue", typeof(int), constructorArguments[0]);
        this.TestObjectProperty(instance, "LongValue", typeof(long), constructorArguments[1]);
        this.TestObjectProperty(instance, "FloatValue", typeof(float), constructorArguments[2]);
        this.TestObjectProperty(instance, "DoubleValue", typeof(double), constructorArguments[3]);
        this.TestObjectProperty(instance, "CharValue", typeof(char), constructorArguments[4]);
        this.TestObjectProperty(instance, "BooleanValue", typeof(bool), constructorArguments[5]);
        this.TestObjectProperty(instance, "StringValue", typeof(string), constructorArguments[6]);
        this.TestObjectProperty(instance, "ObjectValue", typeof(object), constructorArguments[7]);
    }

    [TestCase("IntValue", typeof(int), 0)]
    [TestCase("LongValue", typeof(long), 0L)]
    [TestCase("FloatValue", typeof(float), 0.0F)]
    [TestCase("DoubleValue", typeof(double), 0.0)]
    [TestCase("CharValue", typeof(char), 'a')]
    [TestCase("BooleanValue", typeof(bool), true)]
    [TestCase("StringValue", typeof(string), "")]
    [TestCase("ObjectValue", typeof(object), null)]
    public void HasProperty(string propertyName, Type expectedPropertyType, object expectedValue)
    {
        var propertyInfo = this.classType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(propertyInfo is not null);
        Assert.That(expectedPropertyType, Is.EqualTo(propertyInfo!.PropertyType));

        var instance = Activator.CreateInstance(this.classType, new object[] { 0, 0L, 0.0F, 0.0, 'a', true, string.Empty, null! });
        var actualValue = propertyInfo.GetValue(instance);

        Assert.That(expectedValue, Is.EqualTo(actualValue));
    }

    private void TestObjectProperty(object instance, string propertyName, Type propertyType, object expectedValue)
    {
        var propertyInfo = this.classType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
        Assert.That(propertyInfo is not null);
        Assert.That(propertyType, Is.EqualTo(propertyInfo!.PropertyType));
        Assert.That(propertyInfo.GetMethod!.IsPublic);

        var actualValue = propertyInfo.GetValue(instance);
        Assert.That(expectedValue, Is.EqualTo(actualValue));
    }
}

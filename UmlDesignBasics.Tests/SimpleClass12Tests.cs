using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass12Tests
{
    private static readonly object[][] Data =
    [
        new object[]
        {
            typeof(int),
            0,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(int),
            1,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 1 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(int),
            -1,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -1 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(long),
            0L,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(long),
            1L,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), 1L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(long),
            -1L,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -1L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(float),
            0F,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), 0F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(float),
            1.1F,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), 1.1F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(float),
            -1.1F,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -1.1F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(double),
            0.0,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(double),
            101.101,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), 101.101 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(double),
            -101.101,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -101.101 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(char),
            'a',
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(char),
            'b',
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'b' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(bool),
            true,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(bool),
            false,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(string),
            string.Empty,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), string.Empty },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(string),
            "abc",
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "abc" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(string),
            "abcdef",
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "abcdef" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(object),
            null,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            typeof(object),
            typeof(SimpleClass11Tests),
            new object[]
            {
                new object[] { "IntValue", typeof(int), -983 },
                new object[] { "LongValue", typeof(long), -985L },
                new object[] { "FloatValue", typeof(float), -984.983F },
                new object[] { "DoubleValue", typeof(double), -9238.9634 },
                new object[] { "CharValue", typeof(char), 'g' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "mnojkl" },
                new object[] { "ObjectValue", typeof(object), typeof(SimpleClass11Tests) },
            },
        }
    ];

    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly!.GetType("UmlDesignBasics.SimpleClass12")!;
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
        Assert.That(0, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
    }

    [TestCaseSource(nameof(Data))]
    public void HasConstructor(Type parameterType, object constructorParameter, object[] propertyValues)
    {
        var constructorInfo = this.classType.GetConstructor(new[] { parameterType });
        Assert.That(constructorInfo is not null);

        var instance = constructorInfo!.Invoke(new[] { constructorParameter });

        foreach (object[] propertyValue in propertyValues!)
        {
            string name = (string)propertyValue[0];
            Type type = (Type)propertyValue[1];
            object value = propertyValue[2];

            var propertyInfo = this.classType.GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
            Assert.That(propertyInfo is not null);
            Assert.That(type, Is.EqualTo(propertyInfo!.PropertyType));
            Assert.That(propertyInfo!.GetMethod!.IsPublic is true);
            Assert.That(propertyInfo!.SetMethod!.IsPrivate is true);

            var actualValue = propertyInfo.GetValue(instance);
            Assert.That(value, Is.EqualTo(actualValue));
        }
    }
}

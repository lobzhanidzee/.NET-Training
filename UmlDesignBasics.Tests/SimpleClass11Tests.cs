using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass11Tests
{
    private static readonly object[][] Data =
    [
        [
            typeof(int), 0,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 }, new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(int), 1,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 1 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(int), -1,
            new object[]
            {
                new object[] { "IntValue", typeof(int), -1 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(long), 0L,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(long), 1L,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), 1L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(long), -1L,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -1L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(float), 0F,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), 0F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(float), 1.1F,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), 1.1F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(float), -1.1F,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -1.1F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(double), 0.0,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(double), 101.101,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 101.101 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(double), -101.101,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), -101.101 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(char), 'a',
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(char), 'b',
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'b' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(bool), true,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(bool), false,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(string), string.Empty,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), string.Empty },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(string), "abc",
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "abc" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(string), "abcdef",
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "abcdef" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(object), null,
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), null! },
            }
        ],
        [
            typeof(object), typeof(SimpleClass11Tests),
            new object[]
            {
                new object[] { "IntValue", typeof(int), 8374 },
                new object[] { "LongValue", typeof(long), -8124L },
                new object[] { "FloatValue", typeof(float), -889.542F },
                new object[] { "DoubleValue", typeof(double), 89238.0809 },
                new object[] { "CharValue", typeof(char), 'f' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "jklmno" },
                new object[] { "ObjectValue", typeof(object), typeof(SimpleClass11Tests) },
            }
        ]
    ];

    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass11")!;
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
            Is.EqualTo(
                this.classType.GetMethods(
                        BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                    .Length));
        Assert.That(
            8,
            Is.EqualTo(
                this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Length));
        Assert.That(
            8,
            Is.EqualTo(
                this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                    .Length));

        Assert.That(
            0,
            Is.EqualTo(
                this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                    .Length));
        Assert.That(8, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(
            0,
            Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(
            0,
            Is.EqualTo(
                this.classType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                    .Length));
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

        var instance = constructorInfo!.Invoke([constructorParameter]);

        foreach (object[] propertyValue in propertyValues)
        {
            string name = (string)propertyValue[0];
            Type type = (Type)propertyValue[1];
            object value = propertyValue[2];

            var propertyInfo = this.classType.GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
            Assert.That(propertyInfo is not null);
            Assert.That(type, Is.EqualTo(propertyInfo!.PropertyType));
            Assert.That(propertyInfo.GetMethod!.IsPublic);
            Assert.That(propertyInfo.SetMethod!.IsPrivate);

            var actualValue = propertyInfo.GetValue(instance);
            Assert.That(value, Is.EqualTo(actualValue));
        }
    }
}

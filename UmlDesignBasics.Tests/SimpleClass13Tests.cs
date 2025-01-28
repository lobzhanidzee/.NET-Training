using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass13Tests
{
    private static readonly object[][] Data =
    [
        new object[]
        {
            Array.Empty<Type>(),
            Array.Empty<object>(),
            new object[]
            {
                new object[] { "IntValue", typeof(int), 1087 },
                new object[] { "LongValue", typeof(long), 10482L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int) },
            new object[] { 0 },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 10482L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int) },
            new object[] { -1 },
            new object[]
            {
                new object[] { "IntValue", typeof(int), -1 },
                new object[] { "LongValue", typeof(long), 10482L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int) },
            new object[] { 1 },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 1 },
                new object[] { "LongValue", typeof(long), 10482L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long) },
            new object[] { 0, 0L },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long) },
            new object[] { 0, 1L },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 1L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long) },
            new object[] { 0, -1L },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), -1L },
                new object[] { "FloatValue", typeof(float), -10387.05832F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float) },
            new object[] { 0, 0L, 0.0F },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float) },
            new object[] { 0, 0L, 1.1F },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 1.1F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float) },
            new object[] { 0, 0L, -1.1F },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), -1.1F },
                new object[] { "DoubleValue", typeof(double), -10382.73521 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double) },
            new object[] { 0, 0L, 0.0F, 0.0 },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double) },
            new object[] { 0, 0L, 0.0F, 1.1 },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 1.1 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double) },
            new object[] { 0, 0L, 0.0F, -1.1 },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), -1.1 },
                new object[] { "CharValue", typeof(char), 'h' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char) },
            new object[] { 0, 0L, 0.0F, 0.0, 'a' },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char) },
            new object[] { 0, 0L, 0.0F, 0.0, 'b' },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'b' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char), typeof(bool) },
            new object[] { 0, 0L, 0.0F, 0.0, 'a', false },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), false },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char), typeof(bool) },
            new object[] { 0, 0L, 0.0F, 0.0, 'a', true },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "ghimnojkl" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char), typeof(bool), typeof(string) },
            new object[] { 0, 0L, 0.0F, 0.0, 'a', true, string.Empty },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), string.Empty },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char), typeof(bool), typeof(string) },
            new object[] { 0, 0L, 0.0F, 0.0, 'a', true, "abc" },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "abc" },
                new object[] { "ObjectValue", typeof(object), null! },
            },
        },
        new object[]
        {
            new[] { typeof(int), typeof(long), typeof(float), typeof(double), typeof(char), typeof(bool), typeof(string), typeof(object) },
            new object[] { 0, 0L, 0.0F, 0.0, 'a', true, "abc", typeof(SimpleClass13Tests) },
            new object[]
            {
                new object[] { "IntValue", typeof(int), 0 },
                new object[] { "LongValue", typeof(long), 0L },
                new object[] { "FloatValue", typeof(float), 0.0F },
                new object[] { "DoubleValue", typeof(double), 0.0 },
                new object[] { "CharValue", typeof(char), 'a' },
                new object[] { "BooleanValue", typeof(bool), true },
                new object[] { "StringValue", typeof(string), "abc" },
                new object[] { "ObjectValue", typeof(object), typeof(SimpleClass13Tests) },
            },
        }
    ];

    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly!.GetType("UmlDesignBasics.SimpleClass13")!;
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
        Assert.That(9, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        Assert.That(0, Is.EqualTo(this.classType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length));
        Assert.That(8, Is.EqualTo(this.classType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
    }

    [TestCaseSource(nameof(Data))]
    public void HasConstructor(Type[] parameterTypes, object[] constructorParameters, object[] propertyValues)
    {
        var constructorInfo = this.classType.GetConstructor(parameterTypes);
        Assert.That(constructorInfo is not null);

        var instance = constructorInfo!.Invoke(constructorParameters);

        foreach (object[] propertyValue in propertyValues!)
        {
            string name = (string)propertyValue[0];
            Type type = (Type)propertyValue[1];
            object value = propertyValue[2];

            var propertyInfo = this.classType.GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
            Assert.That(propertyInfo is not null);
            Assert.That(type, Is.EqualTo(propertyInfo!.PropertyType));
            Assert.That(propertyInfo!.GetMethod!.IsPublic);
            Assert.That(propertyInfo!.SetMethod!.IsPrivate);

            var actualValue = propertyInfo.GetValue(instance);
            Assert.That(value, Is.EqualTo(actualValue));
        }
    }
}

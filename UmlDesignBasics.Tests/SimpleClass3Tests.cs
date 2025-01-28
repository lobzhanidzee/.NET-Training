using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass3Tests
{
    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass3")!;
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
                this.classType.GetMethods(
                        BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                    .Length));
        Assert.That(
            8,
            Is.EqualTo(
                this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Length));
        Assert.That(
            0,
            Is.EqualTo(
                this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                    .Length));

        var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        Assert.That(0, Is.EqualTo(this.classType.GetFields(flags).Length));
        Assert.That(1, Is.EqualTo(this.classType.GetConstructors(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetEvents(flags).Length));
        Assert.That(0, Is.EqualTo(this.classType.GetProperties(flags).Length));
    }

    [TestCase("GetInteger", typeof(int), ExpectedResult = int.MaxValue)]
    [TestCase("GetLong", typeof(long), ExpectedResult = long.MinValue)]
    [TestCase("GetFloat", typeof(float), ExpectedResult = float.Epsilon)]
    [TestCase("GetDouble", typeof(double), ExpectedResult = double.NaN)]
    [TestCase("GetChar", typeof(char), ExpectedResult = 'c')]
    [TestCase("GetBoolean", typeof(bool), ExpectedResult = true)]
    [TestCase("GetString", typeof(string), ExpectedResult = "abcdef")]
    public object HasRequiredMethod(string methodName, Type expectedReturnType)
    {
        var methodInfo = this.classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
        Assert.That(methodInfo is not null);
        Assert.That(expectedReturnType, Is.EqualTo(methodInfo!.ReturnType));

        var instance = Activator.CreateInstance(this.classType);
        var result = methodInfo.Invoke(instance, Array.Empty<object>());

        Assert.That(result is not null);
        return result!;
    }

    [Test]
    public void HasGetObjectMethod()
    {
        var methodInfo = this.classType.GetMethod("GetObject", BindingFlags.Instance | BindingFlags.Public);

        Assert.That(methodInfo is not null);
        Assert.That(!methodInfo!.IsStatic);
        Assert.That(typeof(object), Is.EqualTo(methodInfo.ReturnType));

        var instance = Activator.CreateInstance(this.classType);
        var result = methodInfo.Invoke(instance, Array.Empty<object>());

        Assert.That(result is not null);
        Assert.That(typeof(object), Is.EqualTo(result!.GetType()));
    }
}

using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleClass4Tests
{
    private static readonly object[][] Data =
    [
        ["GetInteger", "SetInteger", typeof(int), int.MaxValue],
        ["GetLong", "SetLong", typeof(long), long.MinValue],
        ["GetFloat", "SetFloat", typeof(float), float.Epsilon],
        ["GetDouble", "SetDouble", typeof(double), double.NaN],
        ["GetChar", "SetChar", typeof(char), 'A'],
        ["GetBoolean", "SetBoolean", typeof(bool), true],
        ["GetString", "SetString", typeof(string), "My String"],
        ["GetObject", "SetObject", typeof(object), new object()],
    ];

    private Type classType = null!;

    [SetUp]
    public void SetUp()
    {
        var assembly = typeof(CreatingSimpleClass2).Assembly;
        this.classType = assembly.GetType("UmlDesignBasics.SimpleClass4")!;
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
            16,
            Is.EqualTo(
                this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Length));
        Assert.That(
            0,
            Is.EqualTo(
                this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
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

    [TestCase("GetInteger", typeof(int))]
    [TestCase("GetLong", typeof(long))]
    [TestCase("GetFloat", typeof(float))]
    [TestCase("GetDouble", typeof(double))]
    [TestCase("GetChar", typeof(char))]
    [TestCase("GetBoolean", typeof(bool))]
    [TestCase("GetString", typeof(string))]
    [TestCase("GetObject", typeof(object))]
    public void HasGetMethod(string methodName, Type expectedReturnType)
    {
        var methodInfo = this.classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(methodInfo is not null);
        Assert.That(expectedReturnType, Is.EqualTo(methodInfo!.ReturnType));
    }

    [TestCase("SetInteger", typeof(int))]
    [TestCase("SetLong", typeof(long))]
    [TestCase("SetFloat", typeof(float))]
    [TestCase("SetDouble", typeof(double))]
    [TestCase("SetChar", typeof(char))]
    [TestCase("SetBoolean", typeof(bool))]
    [TestCase("SetString", typeof(string))]
    [TestCase("SetObject", typeof(object))]
    public void HasSetMethod(string methodName, Type expectedArgumentType)
    {
        var methodInfo = this.classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(methodInfo is not null);
        Assert.That(typeof(void), Is.EqualTo(methodInfo!.ReturnParameter?.ParameterType));

        var parameters = methodInfo.GetParameters();
        Assert.That(1, Is.EqualTo(parameters.Length));
        Assert.That(expectedArgumentType, Is.EqualTo(parameters[0].ParameterType));
    }

    [TestCaseSource(nameof(Data))]
    public void SetGet(string getMethodName, string setMethodName, Type expectedType, object expectedValue)
    {
        var setMethodInfo = this.classType.GetMethod(setMethodName, BindingFlags.Instance | BindingFlags.Public);
        var getMethodInfo = this.classType.GetMethod(getMethodName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(setMethodInfo is not null);
        var setMethodParameters = setMethodInfo!.GetParameters();
        Assert.That(1, Is.EqualTo(setMethodParameters.Length));
        Assert.That(expectedType, Is.EqualTo(setMethodParameters[0].ParameterType));
        Assert.That(getMethodInfo is not null);
        Assert.That(expectedType, Is.EqualTo(getMethodInfo!.ReturnType));

        var instance = Activator.CreateInstance(this.classType);
        _ = setMethodInfo.Invoke(instance, new object[] { expectedValue });
        var result = getMethodInfo.Invoke(instance, Array.Empty<object>());

        Assert.That(result is not null);
        Assert.That(expectedValue, Is.EqualTo(result));
    }
}

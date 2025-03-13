using System.Reflection;
using NUnit.Framework;

namespace WorkforceStructure.Tests;

internal static class TestHelper
{
    public static void AssertThatClassIsPublic(Type type, bool isSealed)
    {
        Assert.That(type.IsClass, Is.True);
        Assert.That(type.IsPublic, Is.True);
        Assert.That(type.IsAbstract, Is.False);
        Assert.That(type.IsSealed, isSealed ? Is.True : Is.False);
    }

    public static void AssertThatClassInheritsObject(Type derivedType, Type baseType)
    {
        Assert.That(derivedType.BaseType, Is.EqualTo(baseType));
    }

    public static void AssertThatFieldExists(Type classType, string fieldName, Type fieldType)
    {
        var fieldInfo = classType.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
        Assert.Multiple(
            () =>
        {
            Assert.That(fieldInfo, Is.Not.Null);
            Assert.That(fieldInfo!.FieldType, Is.EqualTo(fieldType));
        });
    }

    public static void AssertThatConstructorExists(Type type, params Type[] parameterTypes)
    {
        var constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, parameterTypes, null);
        Assert.That(constructorInfo, Is.Not.Null);
    }

    public static void AssertThatPropertyExists(Type classType, string propertyName, Type propertyType, bool canRead, bool canWrite)
    {
        var propertyInfo = classType.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
        Assert.Multiple(
            () =>
        {
            Assert.That(propertyInfo, Is.Not.Null);
            Assert.That(propertyInfo!.PropertyType, Is.EqualTo(propertyType));
            Assert.That(propertyInfo.CanRead, Is.EqualTo(canRead));
            Assert.That(propertyInfo.CanWrite, Is.EqualTo(canWrite));
        });
    }

    public static void AssertThatMethodExists(Type classType, string methodName, Type returnType, bool isVirtual, bool isAbstract, params Type[] parameterTypes)
    {
        var methodInfo = classType.GetMethod(methodName, parameterTypes);
        Assert.Multiple(
            () =>
        {
            Assert.That(methodInfo, Is.Not.Null);
            Assert.That(methodInfo!.ReturnType, Is.EqualTo(returnType));
            Assert.That(methodInfo.IsVirtual, Is.EqualTo(isVirtual));
            Assert.That(methodInfo.IsAbstract, Is.EqualTo(isAbstract));
            Assert.That(methodInfo.GetParameters().Select(p => p.ParameterType).ToArray(), Is.EqualTo(parameterTypes));
        });
    }
}

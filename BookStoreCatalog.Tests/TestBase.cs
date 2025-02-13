using System.Reflection;
using NUnit.Framework;

namespace BookStoreCatalog.Tests;

public class TestBase
{
    protected Type ClassType { get; set; } = default!;

    protected void AssertThatClassIsPublic(bool isSealed)
    {
        Assert.That(this.ClassType.IsClass, Is.True);
        Assert.That(this.ClassType.IsPublic, Is.True);
        Assert.That(this.ClassType.IsAbstract, Is.False);
        Assert.That(this.ClassType.IsSealed, isSealed ? Is.True : Is.False);
    }

    protected void AssertThatClassHasField(string fieldName, Type fieldType, bool isInitOnly)
    {
        var fieldInfo = this.ClassType.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

        // Assert
        Assert.That(fieldInfo, Is.Not.Null);
        Assert.That(fieldInfo!.FieldType, Is.EqualTo(fieldType));
        Assert.That(fieldInfo.IsInitOnly, isInitOnly ? Is.True : Is.False);
    }

    protected void AssertThatClassInheritsObject()
    {
        Assert.That(this.ClassType.BaseType, Is.EqualTo(typeof(object)));
    }

    protected void AssertThatClassHasPublicConstructor(Type[] parameterTypes)
    {
        var constructorInfo = this.ClassType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, parameterTypes, null);
        Assert.That(constructorInfo, Is.Not.Null);
    }

    protected PropertyInfo AssertThatClassHasProperty(string propertyName, Type expectedPropertyType, bool hasGet, bool isGetPublic, bool hasSet, bool isSetPublic)
    {
        var propertyInfo = this.ClassType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);

        Assert.That(propertyInfo, Is.Not.Null);
        Assert.That(propertyInfo!.PropertyType, Is.EqualTo(expectedPropertyType));

        if (hasGet)
        {
            Assert.That(propertyInfo.GetMethod!.IsPublic, isGetPublic ? Is.True : Is.False);
        }

        if (hasSet)
        {
            Assert.That(propertyInfo.SetMethod!.IsPublic, isSetPublic ? Is.True : Is.False);
        }

        return propertyInfo;
    }

    protected MethodInfo AssertThatClassHasMethod(string methodName, bool isStatic, bool isPublic, bool isVirtual, Type returnType)
    {
        var methodInfo = this.ClassType.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        Assert.That(methodInfo, Is.Not.Null);
        Assert.That(methodInfo!.IsStatic, isStatic ? Is.True : Is.False);
        Assert.That(methodInfo.IsPublic, isPublic ? Is.True : Is.False);
        Assert.That(methodInfo.IsVirtual, isVirtual ? Is.True : Is.False);
        Assert.That(methodInfo.ReturnType, Is.EqualTo(returnType));

        return methodInfo;
    }
}

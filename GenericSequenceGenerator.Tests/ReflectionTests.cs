using System.Collections;
using System.Collections.ObjectModel;
using NUnit.Framework;
using System.Reflection;
using AntiCheater;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class ReflectionTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    public static IEnumerable<Type> SequenceGeneratorTypes()
    {
        return new List<Type>
        {
            typeof(FibonacciSequenceGenerator),
            typeof(IntegerSequenceGenerator),
            typeof(DoubleSequenceGenerator),
            typeof(CharSequenceGenerator),
            typeof(SequenceGenerator<>)
        };
    }

    public static IEnumerable<Type> DerivedSequenceGenerators()
    {
        return new List<Type>
        {
            typeof(FibonacciSequenceGenerator),
            typeof(IntegerSequenceGenerator),
            typeof(DoubleSequenceGenerator),
            typeof(CharSequenceGenerator),
            typeof(DelegateSequenceGenerator<>),
        };
    }

    public static IEnumerable<Type> NotGenericSequenceGenerators()
    {
        return new List<Type>
        {
            typeof(FibonacciSequenceGenerator),
            typeof(IntegerSequenceGenerator),
            typeof(DoubleSequenceGenerator),
            typeof(CharSequenceGenerator),
        };
    }

    [Test]
    public void ISequenceGenerator_Should_Have_Required_Members()
    {
        var type = typeof(ISequenceGenerator<>);
        Assert.That(type.IsInterface, "ISequenceGenerator should be an interface.");
        Assert.That(type.IsGenericType, "ISequenceGenerator should be generic interface.");

        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var requiredProperties = new[] { "Previous", "Current", "Next" };

        foreach (var property in requiredProperties)
        {
            Assert.That(
                properties.Any(p => p.Name == property),
                $"Property '{property}' is missing in ISequenceGenerator.");
        }

        foreach (var property in properties)
        {
            Assert.That(property.CanRead, $"Property '{property.Name}' can read.");
            Assert.That(!property.CanWrite, $"Property '{property.Name}' cannot write.");
        }
    }

    [Test]
    public void SequenceGenerator_Should_Have_Required_Members()
    {
        var type = typeof(SequenceGenerator<>);
        Assert.That(type.IsAbstract, "SequenceGenerator should be an abstract class.");
        Assert.That(type.IsGenericType, "SequenceGenerator should be an generic class.");
        Assert.That(
            type.GetInterface("ISequenceGenerator`1"),
            Is.Not.Null,
            "SequenceGenerator should implement 'ISequenceGenerator`1' generic interface.");

        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var requiredProperties = new[] { "Previous", "Current", "Count", "Next" };

        foreach (var property in requiredProperties)
        {
            Assert.That(
                properties.Any(p => p.Name == property),
                $"Property '{property}' is missing in SequenceGenerator.");
        }

        foreach (var property in properties)
        {
            Assert.That(property.CanRead, $"Property '{property.Name}' can read.");

            if (property.Name == "Count")
            {
                Assert.That(property.CanWrite, $"Property '{property.Name}' can write.");
                Assert.That(
                    property.SetMethod!.IsPrivate,
                    $"Set accessor of the '{property.Name}' property should be private.");
            }
            else
            {
                Assert.That(!property.CanWrite, $"Property '{property.Name}' cannot write.");
            }
        }

        var method = type.GetMethod("GetNext", BindingFlags.NonPublic | BindingFlags.Instance);
        Assert.That(method, Is.Not.Null, "Abstract method 'GetNext' is missing in SequenceGenerator.");
        Assert.That(method!.IsAbstract, "Method 'GetNext' should be abstract.");
    }

    [TestCaseSource(nameof(NotGenericSequenceGenerators))]
    public void Integer_Double_Char_SequenceGenerator_Not_Generic(Type type)
    {
        Assert.That(!type.IsGenericType, $"{type.Name} is not generic.");
    }

    [TestCaseSource(nameof(DerivedSequenceGenerators))]
    public void AllDerivedClasses_Should_Implement_GetNext_Method(Type type)
    {
        var method = type.GetMethod("GetNext", BindingFlags.NonPublic | BindingFlags.Instance);

        Assert.That(method, Is.Not.Null, $"Method 'GetNext' is missing in {type.Name}.");
        Assert.That(!method!.IsAbstract, $"Method 'GetNext' should be implemented in {type.Name}.");
    }

    [Test]
    public void DelegateSequenceGenerator_Should_Have_Func_Parameter_In_Gtor()
    {
        var type = typeof(DelegateSequenceGenerator<int>);
        var constructor = type.GetConstructor([typeof(int), typeof(int), typeof(Func<int, int, int>)]);

        Assert.That(
            constructor,
            Is.Not.Null,
            "Constructor with Func<T, T, T> parameter is missing in DelegateSequenceGenerator.");
        _ = (DelegateSequenceGenerator<int>)constructor!.Invoke(
            new object[] { 0, 1, (Func<int, int, int>)((a, b) => a + b) });
    }

    [TestCaseSource(nameof(SequenceGeneratorTypes))]
    public void NoArrayOrGenericCollectionFields_In_SequenceGeneratorClassses(Type type)
    {
        AssertNoArrayOrGenericCollectionFields(type);
    }

    private static void AssertNoArrayOrGenericCollectionFields(Type type)
    {
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
        foreach (var field in fields)
        {
            Assert.That(
                !IsArrayOrGenericCollection(field.FieldType),
                $"Field of the type {type.Name} should not be an array or any generic collection type.");
        }
    }

    private static bool IsArrayOrGenericCollection(Type fieldType)
    {
        if (fieldType.IsArray)
        {
            return true;
        }

        if (fieldType.IsGenericType)
        {
            var genericTypeDefinition = fieldType.GetGenericTypeDefinition();
            if (genericTypeDefinition == typeof(List<>) ||
                genericTypeDefinition == typeof(Dictionary<,>) ||
                genericTypeDefinition == typeof(HashSet<>) ||
                genericTypeDefinition == typeof(Queue<>) ||
                genericTypeDefinition == typeof(Stack<>) ||
                genericTypeDefinition == typeof(LinkedList<>) ||
                genericTypeDefinition == typeof(Collection<>) ||
                genericTypeDefinition == typeof(ReadOnlyCollection<>) ||
                genericTypeDefinition == typeof(ReadOnlyDictionary<,>) ||
                genericTypeDefinition == typeof(ArrayList))
            {
                return true;
            }
        }

        return false;
    }
}

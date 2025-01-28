using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class CreatingSimpleClass16Tests
{
    [Test]
    public void CreateSimpleClass16WithDefaultValues_ReturnsNewObject()
    {
        object obj = CreatingSimpleClass16.CreateSimpleClass16WithDefaultValues();

        //Assert.That(obj is not null);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj!.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(-135914, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(138672L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(130124.58123F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(-130521.71531, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('k', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(false, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("stuvwx", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0L)]
    [TestCase(1L)]
    [TestCase(-1L)]
    public void CreateSimpleClass16_ReturnsNewObject(long longValue)
    {
        object obj = CreatingSimpleClass16.CreateSimpleClass16(longValue);

        //Assert.IsNotNull(obj);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(-135914, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(longValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(130124.58123F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(-130521.71531, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('k', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(false, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("stuvwx", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0.0F)]
    [TestCase(1.1F)]
    [TestCase(-1.1F)]
    public void CreateSimpleClass16_ReturnsNewObject(float floatValue)
    {
        object obj = CreatingSimpleClass16.CreateSimpleClass16(floatValue);

        //Assert.IsNotNull(obj);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(-135914, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(138672L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(floatValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(-130521.71531, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('k', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(false, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("stuvwx", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0, true)]
    [TestCase(1, true)]
    [TestCase(-1, true)]
    public void CreateSimpleClass16_ReturnsNewObject(int intValue, bool boolValue)
    {
        object obj = CreatingSimpleClass16.CreateSimpleClass16(intValue, boolValue);

        //Assert.IsNotNull(obj);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(intValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(138672L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(130124.58123F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(-130521.71531, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('k', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(boolValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("stuvwx", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0.0, 'a', "")]
    [TestCase(1.1, 'b', "abc")]
    [TestCase(-1.1, 'c', "abcdef")]
    public void CreateSimpleClass16_ReturnsNewObject(double doubleValue, char charValue, string stringValue)
    {
        object obj = CreatingSimpleClass16.CreateSimpleClass16(doubleValue, charValue, stringValue);

        //Assert.IsNotNull(obj);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(-135914, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(138672L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(130124.58123F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(doubleValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That(charValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(false, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That(stringValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }
}

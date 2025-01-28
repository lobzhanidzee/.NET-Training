using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class SimpleCreatingSimpleClass15Tests
{
    [Test]
    public void CreateSimpleClass15WithDefaultValues_ReturnsNewObject()
    {
        object obj = CreatingSimpleClass15.CreateSimpleClass15WithDefaultValues();

        //Assert.That(obj is not null);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj!.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(12354, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(-12134L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(-12846.973F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(12923.6374, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('j', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(true, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("pqrmno", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0)]
    [TestCase(1)]
    [TestCase(-1)]
    public void CreateSimpleClass15_ReturnsNewObject(int intValue)
    {
        object obj = CreatingSimpleClass15.CreateSimpleClass15(intValue);

        //Assert.That(obj is not null);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj!.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(intValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(-12134L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(-12846.973F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(12923.6374, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('j', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(true, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("pqrmno", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0.0)]
    [TestCase(1.1)]
    [TestCase(-1.1)]
    public void CreateSimpleClass15_ReturnsNewObject(double doubleValue)
    {
        object obj = CreatingSimpleClass15.CreateSimpleClass15(doubleValue);

        //Assert.That(obj is not null);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj!.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(12354, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(-12134L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(-12846.973F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(doubleValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('j', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(true, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("pqrmno", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0L, 'a')]
    [TestCase(1L, 'b')]
    [TestCase(-1L, 'c')]
    public void CreateSimpleClass15_ReturnsNewObject(long longValue, char charValue)
    {
        object obj = CreatingSimpleClass15.CreateSimpleClass15(longValue, charValue);

        //Assert.That(obj is not null);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj!.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(12354, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(longValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(-12846.973F, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(12923.6374, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That(charValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(true, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("pqrmno", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(null!, Is.EqualTo(property!.GetValue(obj)));
    }

    [TestCase(0.0F, true, null)]
    [TestCase(1.1F, true, typeof(CreatingSimpleClass15))]
    [TestCase(-1.1F, true, typeof(CreatingSimpleClass15))]
    public void CreateSimpleClass15_ReturnsNewObject(float floatValue, bool boolValue, object objectValue)
    {
        object obj = CreatingSimpleClass15.CreateSimpleClass15(floatValue, boolValue, objectValue);

        //Assert.That(obj is not null);

        var flags = BindingFlags.Instance | BindingFlags.Public;

        var property = obj!.GetType().GetProperty("IntValue", flags);
        Assert.That(property is not null);
        Assert.That(12354, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("LongValue", flags);
        Assert.That(property is not null);
        Assert.That(-12134L, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("FloatValue", flags);
        Assert.That(property is not null);
        Assert.That(floatValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("DoubleValue", flags);
        Assert.That(property is not null);
        Assert.That(12923.6374, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("CharValue", flags);
        Assert.That(property is not null);
        Assert.That('j', Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("BooleanValue", flags);
        Assert.That(property is not null);
        Assert.That(boolValue, Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("StringValue", flags);
        Assert.That(property is not null);
        Assert.That("pqrmno", Is.EqualTo(property!.GetValue(obj)));

        property = obj.GetType().GetProperty("ObjectValue", flags);
        Assert.That(property is not null);
        Assert.That(objectValue, Is.EqualTo(property!.GetValue(obj)));
    }
}

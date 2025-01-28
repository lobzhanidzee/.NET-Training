using System.Reflection;
using NUnit.Framework;

namespace UmlDesignBasics.Tests;

[TestFixture]
public class CreatingSimpleClass2Tests
{
    [Test]
    public void CreateSimpleClass2_ReturnsNewObject()
    {
        var simpleClass = CreatingSimpleClass2.CreateSimpleClass2();

        //Assert.That(simpleClass is not null);

        var field = simpleClass!.GetType().GetField("IntField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(-331, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("FloatField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(13.13F, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("DoubleField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(-31.31, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("BooleanField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(true, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("longField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(long), Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("charField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(char), Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("stringField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(string), Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("objectField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(object), Is.EqualTo(field!.GetValue(simpleClass)));
    }

    [Test]
    public void CreateSimpleClass2ObjectInitializer_ReturnsNewObject()
    {
        var simpleClass = CreatingSimpleClass2.CreateSimpleClass2ObjectInitializer();

        //sAssert.That(simpleClass is not null);

        var field = simpleClass.GetType().GetField("IntField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(432, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("FloatField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(-42.31F, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("DoubleField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(43.12, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("BooleanField", BindingFlags.Instance | BindingFlags.Public);
        Assert.That(field is not null);
        Assert.That(false, Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("longField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(long), Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("charField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(char), Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("stringField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(string), Is.EqualTo(field!.GetValue(simpleClass)));

        field = simpleClass.GetType().GetField("objectField", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.That(field is not null);
        Assert.That(default(object), Is.EqualTo(field!.GetValue(simpleClass)));
    }
}

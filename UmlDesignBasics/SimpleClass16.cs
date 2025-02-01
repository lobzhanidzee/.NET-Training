namespace UmlDesignBasics;

public class SimpleClass16
{
    public const int DefaultIntValue = -135914;
    public const long DefaultLongValue = 138672;
    public const float DefaultFloatValue = 130124.58123f;
    public const double DefaultDoubleValue = -130521.71531;
    public const char DefaultCharValue = 'k';
    public const bool DefaultBooleanValue = false;
    public const string DefaultStringValue = "stuvwx";
    public const object DefaultObjectValue = null;

    private readonly int intField;
    private readonly long longField;
    private readonly float floatField;
    private readonly double doubleField;
    private readonly char charField;
    private readonly bool booleanField;
    private readonly string stringField;
    private readonly object objectField;

    public SimpleClass16(int intValue = DefaultIntValue, long longValue = DefaultLongValue, float floatValue = DefaultFloatValue, double doubleValue = DefaultDoubleValue, char charValue = DefaultCharValue, bool booleanValue = DefaultBooleanValue, string stringValue = DefaultStringValue, object objectValue = DefaultObjectValue)
    {
        this.intField = intValue;
        this.longField = longValue;
        this.floatField = floatValue;
        this.doubleField = doubleValue;
        this.charField = charValue;
        this.booleanField = booleanValue;
        this.stringField = stringValue;
        this.objectField = objectValue;
    }

    public int IntValue => this.intField;

    public long LongValue => this.longField;

    public float FloatValue => this.floatField;

    public double DoubleValue => this.doubleField;

    public char CharValue => this.charField;

    public bool BooleanValue => this.booleanField;

    public string StringValue => this.stringField;

    public object ObjectValue => this.objectField;
}

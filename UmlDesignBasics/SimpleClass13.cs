namespace UmlDesignBasics;
public class SimpleClass13
{
    public SimpleClass13()
    {
        this.IntValue = 1087;
        this.LongValue = 10482;
        this.FloatValue = -10387.05832F;
        this.DoubleValue = -10382.73521;
        this.CharValue = 'h';
        this.BooleanValue = false;
        this.StringValue = "ghimnojkl";
        this.ObjectValue = null;
    }

    public SimpleClass13(int intValue)
        : this()
    {
        this.IntValue = intValue;
    }

    public SimpleClass13(int intValue, long longValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
    }

    public SimpleClass13(int intValue, long longValue, float floatValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
        this.FloatValue = floatValue;
    }

    public SimpleClass13(int intValue, long longValue, float floatValue, double doubleValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
        this.FloatValue = floatValue;
        this.DoubleValue = doubleValue;
    }

    public SimpleClass13(int intValue, long longValue, float floatValue, double doubleValue, char charValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
        this.FloatValue = floatValue;
        this.DoubleValue = doubleValue;
        this.CharValue = charValue;
    }

    public SimpleClass13(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool booleanValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
        this.FloatValue = floatValue;
        this.DoubleValue = doubleValue;
        this.CharValue = charValue;
        this.BooleanValue = booleanValue;
    }

    public SimpleClass13(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool booleanValue, string stringValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
        this.FloatValue = floatValue;
        this.DoubleValue = doubleValue;
        this.CharValue = charValue;
        this.BooleanValue = booleanValue;
        this.StringValue = stringValue;
    }

    public SimpleClass13(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue, string stringValue, object objectValue)
        : this()
    {
        this.IntValue = intValue;
        this.LongValue = longValue;
        this.FloatValue = floatValue;
        this.DoubleValue = doubleValue;
        this.CharValue = charValue;
        this.BooleanValue = boolValue;
        this.StringValue = stringValue;
        this.ObjectValue = objectValue;
    }

    public int IntValue { get; private set; }

    public long LongValue { get; private set; }

    public float FloatValue { get; private set; }

    public double DoubleValue { get; private set; }

    public char CharValue { get; private set; }

    public bool BooleanValue { get; private set; }

    public string StringValue { get; private set; }

    public object ObjectValue { get; private set; }
}

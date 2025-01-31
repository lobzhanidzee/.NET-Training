namespace UmlDesignBasics;
public class SimpleClass14
{
    private SimpleClass14(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue, string stringValue, object objectValue)
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

    public static SimpleClass14 Create()
    {
        return Create(-1132);
    }

    public static SimpleClass14 Create(int intValue)
    {
        return Create(intValue, -11537);
    }

    public static SimpleClass14 Create(int intValue, long longValue)
    {
        return Create(intValue, longValue, 11369.321F);
    }

    public static SimpleClass14 Create(int intValue, long longValue, float floatValue)
    {
        return Create(intValue, longValue, floatValue, 11867.3854);
    }

    public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue)
    {
        return Create(intValue, longValue, floatValue, doubleValue, 'i');
    }

    public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue)
    {
        return Create(intValue, longValue, floatValue, doubleValue, charValue, true);
    }

    public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool booleanValue)
    {
        return Create(intValue, longValue, floatValue, doubleValue, charValue, booleanValue, "pqr");
    }

    public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool booleanValue, string stringValue)
    {
        return Create(intValue, longValue, floatValue, doubleValue, charValue, booleanValue, stringValue, null);
    }

    public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool booleanValue, string stringValue, object objectValue)
    {
        return new SimpleClass14(intValue, longValue, floatValue, doubleValue, charValue, booleanValue, stringValue, objectValue);
    }
}

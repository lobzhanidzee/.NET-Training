namespace UmlDesignBasics;

public class SimpleClass11
{
    public SimpleClass11(int intValue)
    {
        this.IntValue = intValue;
        this.LongValue = -8124;
        this.FloatValue = -889.542F;
        this.DoubleValue = 89238.0809;
        this.CharValue = 'f';
        this.BooleanValue = false;
        this.StringValue = "jklmno";
        this.ObjectValue = null;
    }

    public SimpleClass11(long longValue)
    {
        this.LongValue = longValue;
        this.IntValue = 8374;
        this.FloatValue = -889.542F;
        this.DoubleValue = 89238.0809;
        this.CharValue = 'f';
        this.BooleanValue = false;
        this.StringValue = "jklmno";
        this.ObjectValue = null;
    }

    public SimpleClass11(float floatValue)
    {
        this.FloatValue = floatValue;
        this.LongValue = -8124;
        this.IntValue = 8374;
        this.DoubleValue = 89238.0809;
        this.CharValue = 'f';
        this.BooleanValue = false;
        this.StringValue = "jklmno";
        this.ObjectValue = null;
    }

    public SimpleClass11(double doubleValue)
    {
        this.DoubleValue = doubleValue;
        this.FloatValue = -889.542F;
        this.LongValue = -8124;
        this.IntValue = 8374;
        this.CharValue = 'f';
        this.BooleanValue = false;
        this.StringValue = "jklmno";
        this.ObjectValue = null;
    }

    public SimpleClass11(char charValue)
    {
        this.CharValue = charValue;
        this.DoubleValue = 89238.0809;
        this.FloatValue = -889.542F;
        this.LongValue = -8124;
        this.IntValue = 8374;
        this.DoubleValue = 89238.0809;
        this.BooleanValue = false;
        this.StringValue = "jklmno";
        this.ObjectValue = null;
    }

    public SimpleClass11(bool booleanValue)
    {
        this.BooleanValue = booleanValue;
        this.DoubleValue = 89238.0809;
        this.FloatValue = -889.542F;
        this.LongValue = -8124;
        this.IntValue = 8374;
        this.DoubleValue = 89238.0809;
        this.CharValue = 'f';
        this.StringValue = "jklmno";
        this.ObjectValue = null;
    }

    public SimpleClass11(string stringValue)
    {
        this.StringValue = stringValue;
        this.DoubleValue = 89238.0809;
        this.FloatValue = -889.542F;
        this.LongValue = -8124;
        this.IntValue = 8374;
        this.DoubleValue = 89238.0809;
        this.CharValue = 'f';
        this.BooleanValue = false;
        this.ObjectValue = null;
    }

    public SimpleClass11(object objectValue)
    {
        this.ObjectValue = objectValue;
        this.DoubleValue = 89238.0809;
        this.FloatValue = -889.542F;
        this.LongValue = -8124;
        this.IntValue = 8374;
        this.DoubleValue = 89238.0809;
        this.CharValue = 'f';
        this.BooleanValue = false;
        this.StringValue = "jklmno";
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

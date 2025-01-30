namespace UmlDesignBasics;
public class SimpleClass8
{
    private int intField;
    private long longField;
    private float floatField;
    private double doubleField;
    private char charField;
    private bool booleanField;
    private string stringField = null!;
    private object objectField = null!;

    public int IntValue { get => this.intField; set => this.intField = value; }

    public long LongValue { get => this.longField; set => this.longField = value; }

    public float FloatValue { get => this.floatField; set => this.floatField = value; }

    public double DoubleValue { get => this.doubleField; set => this.doubleField = value; }

    public char CharValue { get => this.charField; set => this.charField = value; }

    public bool BooleanValue { get => this.booleanField; set => this.booleanField = value; }

    public string StringValue { get => this.stringField; set => this.stringField = value; }

    public object ObjectValue { get => this.objectField; set => this.objectField = value; }
}

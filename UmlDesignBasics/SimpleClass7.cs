namespace UmlDesignBasics;
public class SimpleClass7
{
    private readonly int intField;
    private readonly long longField;
    private readonly float floatField;
    private readonly double doubleField;
    private readonly char charField;
    private readonly bool booleanField;
    private readonly string stringField;
    private readonly object objectField;

    public SimpleClass7(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue, string stringValue, object objectValue)
    {
        this.intField = intValue;
        this.longField = longValue;
        this.floatField = floatValue;
        this.doubleField = doubleValue;
        this.charField = charValue;
        this.booleanField = boolValue;
        this.stringField = stringValue;
        this.objectField = objectValue;
    }

    public int GetInteger()
    {
        return this.intField;
    }

    public long GetLong()
    {
        return this.longField;
    }

    public float GetFloat()
    {
        return this.floatField;
    }

    public double GetDouble()
    {
        return this.doubleField;
    }

    public char GetChar()
    {
        return this.charField;
    }

    public bool GetBoolean()
    {
        return this.booleanField;
    }

    public string GetString()
    {
        return this.stringField;
    }

    public object GetObject()
    {
        return this.objectField;
    }
}

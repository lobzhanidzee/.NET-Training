namespace UmlDesignBasics;

public class SimpleClass5
{
    private readonly int intField = -216;
    private readonly long longField = -621;
    private readonly float floatField = -54.62f;
    private readonly double doubleField = -62.054d;
    private readonly char charField = 'd';
    private readonly bool booleanField = true;
    private readonly string stringField = "defabc";
    private readonly object objectField = typeof(int);

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

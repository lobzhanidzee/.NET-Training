namespace UmlDesignBasics;
public class SimpleClass6
{
    private readonly int intField;
    private readonly long longField;
    private readonly float floatField;
    private readonly double doubleField;
    private readonly char charField;
    private readonly bool booleanField;
    private readonly string stringField;
    private readonly object objectField;

    public SimpleClass6()
    {
        this.intField = 754;
        this.longField = 721;
        this.floatField = -76.67f;
        this.doubleField = 372.127;
        this.charField = 'e';
        this.booleanField = true;
        this.stringField = "ghi";
        this.objectField = typeof(float);
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

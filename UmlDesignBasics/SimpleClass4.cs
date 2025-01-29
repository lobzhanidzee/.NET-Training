namespace UmlDesignBasics;

public class SimpleClass4
{
    private int intField;
    private long longField;
    private float floatField;
    private double doubleField;
    private char charField;
    private bool booleanField;
    private string stringField = null!;
    private object objectField = null!;

    public int GetInteger()
    {
        return this.intField;
    }

    public void SetInteger(int value)
    {
        this.intField = value;
    }

    public long GetLong()
    {
        return this.longField;
    }

    public void SetLong(long value)
    {
        this.longField = value;
    }

    public float GetFloat()
    {
        return this.floatField;
    }

    public void SetFloat(float value)
    {
        this.floatField = value;
    }

    public double GetDouble()
    {
        return this.doubleField;
    }

    public void SetDouble(double value)
    {
        this.doubleField = value;
    }

    public char GetChar()
    {
        return this.charField;
    }

    public void SetChar(char value)
    {
        this.charField = value;
    }

    public bool GetBoolean()
    {
        return this.booleanField;
    }

    public void SetBoolean(bool value)
    {
        this.booleanField = value;
    }

    public string GetString()
    {
        return this.stringField;
    }

    public void SetString(string value)
    {
        this.stringField = value;
    }

    public object GetObject()
    {
        return this.objectField;
    }

    public void SetObject(object value)
    {
        this.objectField = value;
    }
}

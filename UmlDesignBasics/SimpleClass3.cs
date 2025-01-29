namespace UmlDesignBasics;

public class SimpleClass3()
{
    public int GetInteger()
    {
        return int.MaxValue;
    }

    public long GetLong()
    {
        return long.MinValue;
    }

    public float GetFloat()
    {
        return float.Epsilon;
    }

    public double GetDouble()
    {
        return double.NaN;
    }

    public char GetChar()
    {
        return 'c';
    }

    public bool GetBoolean()
    {
        return true;
    }

    public string GetString()
    {
        return "abcdef";
    }

    public object GetObject()
    {
        return new object();
    }
}

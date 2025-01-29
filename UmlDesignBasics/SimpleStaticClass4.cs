namespace UmlDesignBasics;

public static class SimpleStaticClass4
{
    private static int intField = 212;
    private static long longField = -232;
    private static float floatField = 2.12f;
    private static double doubleField = 2.121d;
    private static char charField = 'b';
    private static bool booleanField = true;
    private static string stringField = "def";
    private static object objectField = typeof(SimpleStaticClass4);

    public static int GetInteger() => intField;

    public static long GetLongInteger() => longField;

    public static float GetFloat() => floatField;

    public static double GetDouble() => doubleField;

    public static char GetChar() => charField;

    public static bool GetBoolean() => booleanField;

    public static string GetString() => stringField;

    public static object GetObject() => objectField;
}

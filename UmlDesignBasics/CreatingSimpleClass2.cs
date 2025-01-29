namespace UmlDesignBasics;

public static class CreatingSimpleClass2
{
    public static object CreateSimpleClass2()
    {
        SimpleClass2 simpleClass = new SimpleClass2();
        simpleClass.IntField = -331;
        simpleClass.FloatField = 13.13f;
        simpleClass.DoubleField = -31.31d;
        simpleClass.BooleanField = true;

        return simpleClass;
    }

    public static object CreateSimpleClass2ObjectInitializer()
    {
        return new SimpleClass2
        {
            IntField = 432,
            FloatField = -42.31f,
            DoubleField = 43.12,
            BooleanField = false,
        };
    }
}

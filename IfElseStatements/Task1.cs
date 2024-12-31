namespace IfElseStatements;

public static class Task1
{
    public static int DoSomething(bool b)
    {
        int result;

        if (b)
        {
            result = 123;
        }
        else
        {
            result = -123;
        }

        return result;
    }
}

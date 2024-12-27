namespace IfStatements;

public static class Task6
{
    public static int DoSomething(int i)
    {
        int result = i;

        if (i < 0 && i >= -3)
        {
            result = i + (2 * i);
        }
        else if (i > 0 && i <= 3)
        {
            result = i - (i * i);
        }

        return result;
    }
}

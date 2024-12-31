namespace IfElseStatements;

public static class Task7
{
    public static int DoSomething(bool b, int i)
    {
        int result = 0;

        if (b)
        {
            if (i < -5 || i >= 5)
            {
                result = i + 10;
            }
            else if (i >= -5 && i < 5)
            {
                result = 10 - (i * i);
            }
        }
        else if (!b)
        {
            if (i <= -7 || i > 4)
            {
                result = i - 100;
            }
            else if (i > -7 && i <= 4)
            {
                result = 10 - i;
            }
        }

        return result;
    }
}

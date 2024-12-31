namespace IfElseStatements;

public static class Task3
{
    public static int DoSomething1(bool b, int i)
    {
        int result = 0;

        if (b)
        {
            if (i <= -6)
            {
                result = i - 10;
            }

            if (i > -6)
            {
                result = i + 1;
            }
        }

        if (!b)
        {
            if (i < 8)
            {
                result = i - 1;
            }

            if (i >= 8)
            {
                result = i + 10;
            }
        }

        return result;
    }

    public static int DoSomething2(bool b, int i)
    {
        int result;

        if (b)
        {
            if (i <= -6)
            {
                result = i - 10;
            }
            else
            {
                result = i + 1;
            }
        }
        else
        {
            if (i < 8)
            {
                result = i - 1;
            }
            else
            {
                result = i + 10;
            }
        }

        return result;
    }
}

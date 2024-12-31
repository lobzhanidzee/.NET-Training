namespace IfElseStatements;

public static class Task4
{
    public static int DoSomething(bool b1, bool b2, bool b3, bool b4)
    {
        int result;

        if (!b1)
        {
            if (!b2 || !b3)
            {
                if (!b4)
                {
                    result = 5;
                    if (b3)
                    {
                        result = 6;
                    }
                }
                else
                {
                    result = 8;
                    if (b3)
                    {
                        result = 7;
                    }

                    if (b2)
                    {
                        result = 5;
                    }
                }
            }
            else
            {
                result = 6;
            }
        }
        else
        {
            if (!b2 || b4)
            {
                if (!b3)
                {
                    result = 1;
                    if (!b4)
                    {
                        result = 2;
                    }
                }
                else
                {
                    result = 1;
                    if (!b2)
                    {
                        result = 4;
                    }

                    if (!b4)
                    {
                        result = 3;
                    }
                }
            }
            else
            {
                result = 2;
            }
        }

        return result;
    }
}

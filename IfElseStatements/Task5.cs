namespace IfElseStatements;

public static class Task5
{
    public static int DoSomething1(bool b1, bool b2, bool b3, bool b4)
    {
        int result = 0;

        if (b1)
        {
            if (b2)
            {
                result = 1;
            }
            else
            {
                if (b3)
                {
                    result = 2;
                }
                else
                {
                    if (b4)
                    {
                        result = 3;
                    }
                }
            }
        }
        else
        {
            if (b3)
            {
                if (!b4)
                {
                    if (b2)
                    {
                        result = 4;
                    }
                    else
                    {
                        result = 5;
                    }
                }
                else
                {
                    if (!b2)
                    {
                        result = 6;
                    }
                    else
                    {
                        result = 7;
                    }
                }
            }
            else
            {
                if (b2)
                {
                    if (!b4)
                    {
                        result = 8;
                    }
                    else
                    {
                        result = 9;
                    }
                }
                else
                {
                    if (b4)
                    {
                        result = 10;
                    }
                    else
                    {
                        result = 11;
                    }
                }
            }
        }

        return result;
    }

    public static int DoSomething2(bool b1, bool b2, bool b3, bool b4)
    {
        int result = 0;

        if (b1 && b2)
        {
            result = 1;
        }
        else if (b1 && b3)
        {
            result = 2;
        }
        else if (b1 && b4)
        {
            result = 3;
        }
        else if (!b1 && b3 && !b4 && b2)
        {
            result = 4;
        }
        else if (!b1 && b3 && !b4 && !b2)
        {
            result = 5;
        }
        else if (!b1 && b3 && b4 && !b2)
        {
            result = 6;
        }
        else if (!b1 && b3 && b4 && b2)
        {
            result = 7;
        }
        else if (!b1 && !b3 && b2 && !b4)
        {
            result = 8;
        }
        else if (!b1 && !b3 && b2 && b4)
        {
            result = 9;
        }
        else if (!b1 && !b3 && !b2 && b4)
        {
            result = 10;
        }
        else if (!b1 && !b3 && !b2 && !b4)
        {
            result = 11;
        }

        return result;
    }
}

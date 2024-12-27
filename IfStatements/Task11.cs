namespace IfStatements;

public static class Task11
{
    public static int DoSomething(bool b1, bool b2, int i)
    {
        if (b1 && b2 && i == 0)
        {
            return 1;
        }
        else if (b1 && !b2 && i == 0)
        {
            return -1;
        }
        else if (b1 && b2 && i >= 4 && i < 8)
        {
            return i * 2;
        }
        else if (b1 && !b2 && i > 3 && i <= 7)
        {
            return 10 - (i * 2);
        }
        else if (b1 && b2 && i < -4 && i >= -8)
        {
            return i * 3;
        }
        else if (b1 && !b2 && i <= -3 && i > -7)
        {
            return 10 + (i * 3);
        }
        else if (!b1 && i == 0)
        {
            return 1;
        }
        else if (!b1 && b2 && (i < -8 || i >= 8))
        {
            return i - (i * i);
        }
        else if (!b1 && !b2 && (i <= -7 || i > 7))
        {
            return i - (i * i * i);
        }
        else if (!b1 && b2 && i != 0 && i > -4 && i <= 4)
        {
            return (i * i) - (i * i * i);
        }
        else if (!b1 && !b2 && i != 0 && i >= -3 && i < 3)
        {
            return (i * i * i) - (i * i);
        }

        return i;
    }
}

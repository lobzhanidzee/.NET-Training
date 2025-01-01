namespace DartsGame;

public static class Darts
{
    public static int GetScore(double x, double y)
    {
        double result = Math.Abs(x) + Math.Abs(y);

        if (result >= -1 && result <= 1)
        {
            return 10;
        }
        else if (result >= -5 && result <= 5)
        {
            return 5;
        }
        else if (result >= -10 && result <= 10)
        {
            return 1;
        }

        return 0;
    }
}

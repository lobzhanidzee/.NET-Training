namespace WhilePractice;

public static class Task5
{
    public static double GetSequenceProduct(int n)
    {
        double sum = 1, i = 1;

        while (i <= n)
        {
            sum *= 1d + (1d / (i * i));
            i++;
        }

        return sum;
    }
}

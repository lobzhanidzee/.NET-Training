namespace WhilePractice;

public static class Task3
{
    public static double SumSequenceElements(int n)
    {
        double sum = 0d, i = 1d;

        while (i <= n)
        {
            double temp = i * i * i * i * i;
            sum += 1d / temp;
            i++;
        }

        return sum;
    }
}

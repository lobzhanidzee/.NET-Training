namespace WhilePractice;

public static class Task4
{
    public static double SumSequenceElements(int n)
    {
        double sum = 0, i = 1;

        while (i <= n)
        {
            double temp = ((2 * i) + 1) * ((2 * i) + 1);
            sum += 1 / temp;
            i++;
        }

        return sum;
    }
}

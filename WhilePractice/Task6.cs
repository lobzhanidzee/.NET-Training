namespace WhilePractice;

public static class Task6
{
    public static double SumSequenceElements(int n)
    {
        double sum = 0, i = 1;

        while (i <= n)
        {
            double temp = i % 2 == 0 ? 1 : -1;

            sum += temp / ((2 * i) + 1);
            i++;
        }

        return sum;
    }
}

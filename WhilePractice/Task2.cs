namespace WhilePractice;

public static class Task2
{
    public static double SumSequenceElements(int n)
    {
        double sum = 0;
        int i = 1;

        while (i <= n)
        {
            double term = -1.0 / (i * (i + 1d));
            if ((i + 1) % 2 == 0)
            {
                term = -term;
            }

            sum += term;
            i++;
        }

        return sum;
    }
}

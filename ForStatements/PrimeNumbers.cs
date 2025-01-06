namespace ForStatements;

public static class PrimeNumbers
{
    public static bool IsPrimeNumber(uint n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static ulong SumDigitsOfPrimeNumbers(int start, int end)
    {
        ulong sum = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrimeNumber((uint)i))
            {
                int number = i;
                while (number > 0)
                {
                    sum += (ulong)(number % 10);
                    number /= 10;
                }
            }
        }

        return sum;
    }
}

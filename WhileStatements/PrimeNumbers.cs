namespace WhileStatements;

public static class PrimeNumbers
{
    public static bool IsPrimeNumber(uint n)
    {
        if (n <= 1)
        {
            return false;
        }

        uint i = 2;
        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0)
            {
                return false;
            }

            i++;
        }

        return true;
    }

    public static uint GetLastPrimeNumber(uint n)
    {
        uint i = n;
        while (i > 1)
        {
            if (IsPrimeNumber(i))
            {
                return i;
            }

            i--;
        }

        return 0;
    }

    public static uint SumLastPrimeNumbers(uint n, uint count)
    {
        uint sum = 0;
        uint found = 0;
        uint i = n;
        while (i > 1 && found < count)
        {
            if (IsPrimeNumber(i))
            {
                sum += i;
                found++;
            }

            i--;
        }

        return sum;
    }
}

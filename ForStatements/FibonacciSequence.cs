namespace ForStatements;

public static class FibonacciSequence
{
    public static int GetFibonacciNumber(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0, b = 1, result = 1;

        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }

    public static ulong GetProductOfFibonacciNumberDigits(ulong n)
    {
        if (n <= 1)
        {
            return n;
        }

        ulong a = 0, b = 1, result = 1;

        for (ulong i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        ulong sum = 1;

        for (; result > 0; result /= 10)
        {
            sum *= result % 10;
        }

        return sum;
    }
}

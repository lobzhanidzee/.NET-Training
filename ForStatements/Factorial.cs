namespace ForStatements;

public static class Factorial
{
    public static int GetFactorial(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    public static int SumFactorialDigits(int n)
    {
        int product = 1;

        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }

        int sum = 0;

        for (; product > 0; product /= 10)
        {
            sum += product % 10;
        }

        return sum;
    }
}

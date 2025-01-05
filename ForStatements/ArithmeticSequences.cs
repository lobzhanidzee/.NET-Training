namespace ForStatements;

public static class ArithmeticSequences
{
    public static int SumArithmeticSequenceTerms1(int a, int n)
    {
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += a + i;
        }

        return sum;
    }

    public static int SumArithmeticSequenceTerms2(int n)
    {
        const int firstTerm = 47;
        const int commonDifference = 13;

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += firstTerm + (i * commonDifference);
        }

        return sum;
    }

    public static int SumArithmeticSequenceTerms3(int a, int n)
    {
        const int commonDiference = 5;

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += a + (i * commonDiference);
        }

        return sum;
    }
}

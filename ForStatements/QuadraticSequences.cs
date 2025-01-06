namespace ForStatements;

public static class QuadraticSequences
{
    public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
    {
        long term = 0;
        int i = 1;

        for (; term <= maxTerm; term = (a * i * i) + (b * i) + c)
        {
            i++;
        }

        return (uint)(i - 1);
    }

    public static ulong GetQuadraticSequenceTermsProduct1(uint count)
    {
        long term = 1;

        const int a = 7;
        const int b = 4;
        const int c = 2;

        for (int i = 1; i <= count; i++)
        {
            term *= (a * i * i) + (b * i) + c;
        }

        return (ulong)term;
    }

    public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
    {
        long term = 1;

        long max = startN + count;

        for (; startN < max; startN++)
        {
            term *= (a * startN * startN) + (b * startN) + c;
        }

        return (ulong)term;
    }
}

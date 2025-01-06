namespace ForStatements;

public static class GeometricSequences
{
    public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
    {
        uint product = 1;
        for (int i = 0; i < n; i++)
        {
            uint rpow = 1;

            for (int j = 0; j < i; j++)
            {
                rpow *= r;
            }

            product *= a * rpow;
        }

        return product;
    }

    public static ulong SumGeometricSequenceTerms(uint n)
    {
        const int firstTerm = 5;
        const int commonRatio = 3;

        uint product = 0;
        for (int i = 0; i < n; i++)
        {
            uint rpow = 1;

            for (int j = 0; j < i; j++)
            {
                rpow *= commonRatio;
            }

            product += firstTerm * rpow;
        }

        return product;
    }

    public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
    {
        ulong term = a;
        ulong i = 0;

        for (; term <= maxTerm;)
        {
            i++;
            uint rpow = 1;
            for (ulong j = 0; j < i; j++)
            {
                rpow *= r;
            }

            term = a * rpow;
        }

        return i;
    }

    public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
    {
        ulong count = 0;
        ulong term = a;

        for (uint i = 0; i < n; i++)
        {
            if (term >= minTerm)
            {
                count++;
            }

            term *= r;
        }

        return count;
    }
}

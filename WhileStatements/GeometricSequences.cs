namespace WhileStatements;

public static class GeometricSequences
{
    public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
    {
        uint sum = 0, i = 0;

        while (i < n)
        {
            uint j = 0, rpow = 1;

            while (j < i)
            {
                rpow *= r;
                j++;
            }

            sum += a * rpow;
            i++;
        }

        return sum;
    }

    public static uint SumGeometricSequenceTerms2(uint n)
    {
        const uint a = 13;
        const uint r = 3;
        uint sum = 0, i = 0;

        while (i < n)
        {
            uint j = 0, rpow = 1;

            while (j < i)
            {
                rpow *= r;
                j++;
            }

            sum += a * rpow;
            i++;
        }

        return sum;
    }

    public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
    {
        uint count = 0;
        uint term = a;

        while (term <= maxTerm)
        {
            count++;
            term *= r;
        }

        return count;
    }

    public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
    {
        uint count = 0;
        uint term = a;
        uint i = 0;

        while (i < n)
        {
            if (term >= minTerm)
            {
                count++;
            }

            term *= r;
            i++;
        }

        return count;
    }
}

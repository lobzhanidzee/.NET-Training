using System.Runtime.InteropServices;

namespace Exceptions
{
    public static class ThrowingArgumentNull
    {
        public static bool CheckParameterAndThrowException1(object o)
        {
            if (o is null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            return true;
        }

        public static bool CheckParametersAndThrowException2(object o1, object o2)
        {
            if (o1 is null)
            {
                throw new ArgumentNullException(nameof(o1));
            }
            else if (o2 is null)
            {
                throw new ArgumentNullException(nameof(o2));
            }

            return true;
        }

        public static int CheckParametersAndThrowException3(int[] integers, long[] longs, float[] floats)
        {
            if (integers is null)
            {
                throw new ArgumentNullException(nameof(integers));
            }
            else if (longs is null)
            {
                throw new ArgumentNullException(nameof(longs));
            }
            else if (floats is null)
            {
                throw new ArgumentNullException(nameof(floats));
            }

            return integers.Length + longs.Length + floats.Length;
        }

        public static int CheckParameterAndThrowException4(string s)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            return s.Length;
        }

        public static int CheckParametersAndThrowException5(string s1, string s2)
        {
            if (s1 is null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            else if (s2 is null)
            {
                throw new ArgumentNullException(nameof(s2));
            }

            return s1.Length + s2.Length;
        }

        public static int CheckParametersAndThrowException6(string s, int[] integers, string[] strings)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            else if (integers is null)
            {
                throw new ArgumentNullException(nameof(integers));
            }
            else if (strings is null)
            {
                throw new ArgumentNullException(nameof(strings));
            }

            return s.Length + integers.Length + strings.Length;
        }

        public static int CheckParameterAndThrowException7(int[] integers)
        {
            int integersCount;

            integersCount = (integers ?? throw new ArgumentNullException(nameof(integers))).Length;

            return integersCount;
        }

        public static int CheckParametersAndThrowException8(int[] integers, string s)
        {
            int integersCount, stringLength;

            if (integers is null)
            {
                throw new ArgumentNullException(nameof(integers));
            }
            else if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            integersCount = integers.Length;
            stringLength = s.Length;

            return integersCount + stringLength;
        }

        public static int CheckParametersAndThrowException9(float[] floats, string s1, double[] doubles, string s2)
        {
            int floatsCount, s1Length, doublesCount, s2Length;

            if (floats is null)
            {
                throw new ArgumentNullException(nameof(floats));
            }
            else if (s1 is null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            else if (doubles is null)
            {
                throw new ArgumentNullException(nameof(doubles));
            }
            else if (s2 is null)
            {
                throw new ArgumentNullException(nameof(s2));
            }

            floatsCount = floats.Length;
            doublesCount = doubles.Length;
            s1Length = s1.Length;
            s2Length = s2.Length;

            return floatsCount + s1Length + doublesCount + s2Length;
        }
    }
}

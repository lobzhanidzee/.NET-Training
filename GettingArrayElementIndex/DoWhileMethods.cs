namespace GettingArrayElementIndex
{
    public static class DoWhileMethods
    {
        public static int GetIndexOf(ulong[]? arrayToSearch, ulong value)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            int i = 0;

            if (arrayToSearch.Length == 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }
            while (i < arrayToSearch.Length);

            return -1;
        }

        public static int GetIndexOf(ulong[]? arrayToSearch, ulong value, int startIndex, int count)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastIndex = startIndex + count;
            if (lastIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            if (arrayToSearch.Length == 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[startIndex] == value)
                {
                    return startIndex;
                }

                startIndex++;
            }
            while (startIndex < lastIndex);

            return -1;
        }

        public static int GetLastIndexOf(ulong[]? arrayToSearch, ulong value)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            int i = arrayToSearch.Length - 1;
            if (i < 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }
            while (--i >= 0);

            return -1;
        }

        public static int GetLastIndexOf(ulong[]? arrayToSearch, ulong value, int startIndex, int count)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastIndex = startIndex + count;
            if (lastIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int i = lastIndex - 1;
            if (i < 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }
            while (--i >= startIndex);

            return -1;
        }
    }
}

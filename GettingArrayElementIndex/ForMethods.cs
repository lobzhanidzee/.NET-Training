namespace GettingArrayElementIndex
{
    public static class ForMethods
    {
        public static int GetIndexOf(uint[]? arrayToSearch, uint value)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetIndexOf(uint[]? arrayToSearch, uint value, int startIndex, int count)
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

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            for (int i = startIndex; i < startIndex + count; i++)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetLastIndexOf(uint[]? arrayToSearch, uint value)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            for (int i = arrayToSearch.Length - 1; i >= 0; i--)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetLastIndexOf(uint[]? arrayToSearch, uint value, int startIndex, int count)
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

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            for (int i = startIndex + count - 1; i >= startIndex; i--)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

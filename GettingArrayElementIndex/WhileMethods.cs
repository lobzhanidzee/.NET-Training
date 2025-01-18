namespace GettingArrayElementIndex
{
    public static class WhileMethods
    {
        public static int GetIndexOf(ushort[]? arrayToSearch, ushort value)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            int i = 0;
            while (i < arrayToSearch.Length)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetIndexOf(ushort[]? arrayToSearch, ushort value, int startIndex, int count)
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

            int lastPosition = startIndex + count;
            if (lastPosition > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            while (startIndex < lastPosition)
            {
                if (arrayToSearch[startIndex] == value)
                {
                    return startIndex;
                }

                startIndex++;
            }

            return -1;
        }

        public static int GetLastIndexOf(ushort[]? arrayToSearch, ushort value)
        {
            ArgumentNullException.ThrowIfNull(arrayToSearch);

            int i = arrayToSearch.Length - 1;
            while (i >= 0)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i--;
            }

            return -1;
        }

        public static int GetLastIndexOf(ushort[]? arrayToSearch, ushort value, int startIndex, int count)
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

            int lastPosition = startIndex + count;
            if (lastPosition > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int i = lastPosition - 1;
            while (i >= startIndex)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i--;
            }

            return -1;
        }
    }
}

using System;

namespace ErpNet.Fiscal.Print.Drivers
{
    public static class Helpers
    {
        public static T[] Slice<T>(this T[] arr, uint indexFrom, uint indexTo)
        {
            if (indexFrom > indexTo)
            {
                throw new ArgumentOutOfRangeException("indexFrom is bigger than indexTo!");
            }

            uint length = indexTo - indexFrom;
            T[] result = new T[length];
            Array.Copy(arr, indexFrom, result, 0, length);

            return result;
        }

        public static string WithMaxLength(this string text, int maxLength)
        {
            if (text.Length <= maxLength)
            {
                return text;
            }

            return text.Substring(0, maxLength);
        }
    }
}

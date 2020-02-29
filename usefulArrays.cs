using System;
using System.Linq;
using System.Collections.Generic;

namespace isXander
{
    public static class Arrays
    {
        public static T[] RemoveAt<T>(this T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

            return dest;
        }

        public static int RandomIndexOf<T>(ICollection<T> arr, T element)
        {
            var indexes = arr.Select((x, i) => new { Element = x, Index = i })
                .Where(x => element.Equals(x.Element))
                .Select(x => x.Index)
                .ToList();

            if (indexes.Count == 0) // there is no matching elements
            {
                return -1;
            }

            var rand = new Random();
            var randomIndex = rand.Next(0, indexes.Count);

            return indexes[randomIndex];
        }

        public static T[] ClearArray<T>(this T[] arr)
        {
            T[] clearedArray = new T[0];
            return clearedArray;
        }

        public static int[] Append(this int[] arr, int value)
        {
            int[] newValue = arr;
            newValue = newValue.Concat(new[] { value }).ToArray();
            return newValue;
        }

        public static string[] Append(this string[] arr, string value)
        {
            string[] newValue = arr;
            newValue = newValue.Concat(new[] { value }).ToArray();

            return newValue;
        }
    }
}

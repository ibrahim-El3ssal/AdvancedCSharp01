using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal class Helper
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T FindMaxInList<T>(List<T> items) where T : IComparable<T>
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("list cannot be null");

            T max = items[0];
            foreach (var item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}

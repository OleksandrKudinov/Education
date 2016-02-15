using System;
using System.Collections.Generic;
using System.Linq;

namespace Education.Core.Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static IEnumerable<T> Bubble<T, TParam>(this IEnumerable<T> data, Func<T, TParam> extractor) where TParam : IComparable
        {
            var array = data.ToArray();

            int max = array.Length;
            
            TParam param1, param2;
            T tmp;
            
            while (max != 0)
            {
                max--;
                for (int i = 0; i < max; i++)
                {
                    param1 = extractor(array[i]);
                    param2 = extractor(array[i + 1]);

                    if (param1.CompareTo(param2) > 0)
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }

            return array;
        }
    }
}

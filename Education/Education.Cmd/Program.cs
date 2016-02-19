using System;
using System.Collections.Generic;
using Education.Core.DataStuctures;

namespace Education.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var pq = new PriorityQueue<int, int>();

            pq.Insert(new KeyValuePair<int, int>(0, 0));
            pq.Insert(new KeyValuePair<int, int>(1, 1));
            pq.Insert(new KeyValuePair<int, int>(4, 5));
            pq.Insert(new KeyValuePair<int, int>(1, 1));
            pq.Insert(new KeyValuePair<int, int>(3, 3));
            pq.Insert(new KeyValuePair<int, int>(2, 2));
            pq.Insert(new KeyValuePair<int, int>(5, 5));
            pq.Insert(new KeyValuePair<int, int>(4, 4));

            KeyValuePair<int, int> pair;

            for (var i = 0; i < 10; i++)
            {
                if (pq.TryExtractMinimum(out pair))
                {
                    Console.WriteLine("key: {0}, value: {1}", pair.Key, pair.Value);
                }
                else
                {
                    Console.WriteLine("Not extracted");
                }
            }

            Console.ReadLine();
        }
    }
}

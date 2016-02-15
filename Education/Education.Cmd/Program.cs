using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.Core.Algorithms.Sorting;

namespace Education.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {5, 2, 7, 4, 9, 1, 0, 6, 3, 8};
            var ordered = array.Bubble(x=>x);

            foreach (var value in ordered)
            {
                Console.Write("{0}, ",value);
            }

            Console.ReadLine();
        }
    }
}

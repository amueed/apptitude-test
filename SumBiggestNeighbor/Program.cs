using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBiggestNeighbor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            int[] arr = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };

            int prev = arr[0];
            int max = 1;
            int count = 1;
            //find biggest repeated combo
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == prev) max++;
                }
            }

            Console.WriteLine("Max Repeated: {0}", max);
        }
    }
}
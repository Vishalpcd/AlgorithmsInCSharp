using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInC_
{
    public static class Helper
    {
        public static void PrintBefore(int[] arr)
        {
            Console.WriteLine("=================Array before sorting =======================");
            foreach (int i in arr)
            {
                Console.Write(" " + i + " ");
            }
            Console.WriteLine();
        }
        public static void PrintAfter(int[] sortedArray)
        {
            Console.WriteLine("=================Array After sorting =======================");
            foreach (int i in sortedArray)
            {
                Console.Write(" " + i + " ");
            }
            Console.WriteLine();

        }


        public static void PrintCurrentArray(int[] sortedArray)
        {
            foreach (int i in sortedArray)
            {
                Console.Write(" " + i + " ");
                
            }
            Console.WriteLine();

        }
    }
}

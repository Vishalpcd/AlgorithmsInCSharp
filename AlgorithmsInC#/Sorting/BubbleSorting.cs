﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInC_.Sorting
{
    /// <summary>
    /// In Bubble sort algorithm, we compare each element with its adjacent element repeatedly and swap them if they are not in the correct order.
    /// This process we do it until all the elements are sorted in the correct order.
    /// </summary>
    public static class BubbleSorting
    {

        public static int[] SortTheArray(int[] arValue)
        {
            arValue = GenerateRandomArray(arValue.Length);
            int length=arValue.Length;
            
            //loop to repeat the sorting for loop until this loop ends
            //#repetition for loop
            for (int repeatationValue = length - 1; repeatationValue > 1; repeatationValue--)
            {
                //#sorting loop
                for (int eleIndex = 0; eleIndex <repeatationValue; eleIndex++)
                {
                    if (arValue[eleIndex] > arValue[eleIndex + 1])
                    {
                        //swapping it through tuples
                        (int lowerValue, int upperValue) = (arValue[eleIndex + 1], arValue[eleIndex]);
                        arValue[eleIndex] = lowerValue;
                        arValue[eleIndex + 1] = upperValue;
                    }
                }
            }

            return arValue;
        }

        static int[] GenerateRandomArray(int size)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(size); // Generate random numbers up to 1000
            }
            return arr;
        }

    }
}

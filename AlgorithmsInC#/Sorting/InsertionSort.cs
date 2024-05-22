using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInC_.Sorting
{
    /// <summary>
    /// In Insertion sort algorithm we compare previous element with the current element. If element is less than previous element then swap the value and check with the next previous value.
    /// In case if they are equal or current value is greater than previous value then it means it is already sorted so no need to check other previous values
    /// </summary>
    public static class InsertionSort
    {
        public static int[] SortTheArray(int[] arr)
        {
            for(int i=1;i<arr.Length;i++)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (arr[j+1] < arr[j])
                    {
                        (arr[j+1], arr[j]) = (arr[j], arr[j+1]);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return arr;
        }
    }
}

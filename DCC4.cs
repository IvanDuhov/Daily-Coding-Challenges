using System;

namespace DCC
{
    class Program
    {
        /*
         This problem was asked by Sumo Logic.

         Given an unsorted array, in which all elements are distinct, find a "peak" element in O(log N) time.

         An element is considered a peak if it is greater than both its left and right neighbors. 
         It is guaranteed that the first and last elements are lower than all others.
        */

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 20, 4, 1, 0 };

            Console.WriteLine(FindPeak(arr));
        }

        static int FindPeak(int[] array)
        {
            return SearchPeak(array, 0, array.Length);
        }

        static int SearchPeak(int[] array, int low, int high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] > array[mid + 1] && array[mid - 1] < array[mid])
            {
                return array[mid];
            }
            else if (array[mid] < array[mid - 1])
            {
                return SearchPeak(array, low, mid);
            }
            else
            {
                return SearchPeak(array, mid, high);
            }
        }
    }
}

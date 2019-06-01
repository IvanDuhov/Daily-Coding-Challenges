using System;
using System.Collections.Generic;

namespace DCC
{
    class Program
    {
        /*
        This problem was asked by Glassdoor.

        An imminent hurricane threatens the coastal town of Codeville. If at most two people can fit in a rescue boat, and the maximum weight limit 
        for a given boat is k, determine how many boats will be needed to save everyone.

        For example, given a population with weights [100, 200, 150, 80] and a boat limit of 200, the smallest number of boats required will be three.
        */

        static void Main(string[] args)
        {
            // Array with the given weights and the an variable for the boat limit
            int[] weights = { 100, 10, 200, 150, 80, 75, 125, 5 };
            uint boatLimit = 200;

            // An array, in which will be stored the positions of the weights, which already have been carried away.
            int[] bannedPos = new int[weights.Length]; ArrNegative(bannedPos);

            // Variable for the final result and an index for the array with the banned positions
            int res = 0; int banIndex = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < weights.Length; j++)
                {
                    if (sum + weights[j] <= boatLimit && !InArray(bannedPos, j))
                    {
                        sum += weights[j];
                        bannedPos[banIndex] = j;
                        banIndex++;
                    }
                    else if (sum == 200)
                    {
                        break;
                    }
                }

                if (sum != 0)
                {
                    res++;
                }
            }

            Console.WriteLine(res);
        }

        // Checking if the given item is in the array
        public static bool InArray(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        // Setting all array items to -1
        public static void ArrNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
        }

    }
}

using System;
using System.Collections.Generic;

namespace DCC
{
    class Program
    {
        /*
        This problem was asked by Amazon.

        Given a string, find the length of the smallest window that contains every distinct character.
        Characters may appear more than once in the window.

        For example, given "jiujitsu", you should return 5, corresponding to the final five letters.       */

        static void Main(string[] args)
        {
            // Transferring the given string into an array
            string n = "jiujitsu";
            string[] word = stringToArray(n);

            // Variable for holding the longest string window
            int res = 0;

            for (int i = 0; i < word.Length; i++)
            {
                // Variable for counting the length of every window
                // Array holding the already passed letters
                int tempRes = 0;
                string[] bannedLetters = new string[word.Length]; int banIndex = 0;

                for (int j = i; j < word.Length - 1; j++)
                {
                    if (!InArray(bannedLetters, word[j]))
                    {
                        bannedLetters[banIndex] = word[j];
                        banIndex++;
                        tempRes++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempRes > res)
                {
                    res = tempRes;
                }
            }

            Console.WriteLine(res);
        }

        // Checking if the given item is in the array
        public static bool InArray(string[] arr, string item)
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

        public static string[] stringToArray(string word)
        {
            string[] res = new string[word.Length];

            for (int i = 0; i < word.Length - 1; i++)
            {
                res[i] = word[i].ToString();
            }

            return res;
        }

    }
}

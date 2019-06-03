using System;

namespace DCC
{
    class Program
    {
        /*
        This problem was asked by Salesforce.

        The number 6174 is known as Kaprekar's contant, after the mathematician who discovered an associated property:
        for all four-digit numbers with at least two distinct digits, repeatedly applying a simple procedure eventually
        results in this value. The procedure is as follows:

        For a given input x, create two new numbers that consist of the digits in x in ascending and descending order.
        Subtract the smaller number from the larger number.
        For example, this algorithm terminates in three steps when starting from 1234:

        4321 - 1234 = 3087
        8730 - 0378 = 8352
        8532 - 2358 = 6174
        Write a function that returns how many steps this will take for a given input N.
        */

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 1;

            int ascending = AscendingNumber(n);
            int descending = DescendingNumber(n);

            int substracted = descending - ascending;

            Console.WriteLine("{0} - {1} = {2}", descending, ascending, substracted);

            while (substracted != 6174)
            {
                ascending = AscendingNumber(substracted);
                descending = DescendingNumber(substracted);

                substracted = descending - ascending;

                Console.WriteLine("{0} - {1} = {2}", descending, ascending, substracted);

                res++;
            }

            Console.WriteLine(res);
        }

        public static int DescendingNumber(int n)
        {
            int count = 0;
            int temp = n;

            // Finding the length of the given number
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }

            // Creating an array for each digit
            int[] digits = new int[count];
            count = 0;

            while (n != 0)
            {
                digits[count] = n % 10;
                count++;
                n /= 10;
            }

            // Sorting the array sorted in descending way
            Array.Sort(digits);
            Array.Reverse(digits);

            int result = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                result += digits[i] * (int)Math.Pow(10, digits.Length - i - 1);
            }

            return result;
        }

        public static int AscendingNumber(int n)
        {
            int count = 0;
            int temp = n;

            // Finding the length of the given number
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }

            // Creating an array for each digit
            int[] digits = new int[count];
            count = 0;

            // Filling the array with the digits
            while (n != 0)
            {
                digits[count] = n % 10;
                count++;
                n /= 10;
            }

            // Making the array sorted in ascending way
            Array.Sort(digits);

            int result = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                result += digits[i] * (int)Math.Pow(10, digits.Length - i - 1);
            }

            return result;
        }
    }
}

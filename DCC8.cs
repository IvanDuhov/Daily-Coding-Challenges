using System;

namespace ProjectEuler
{
    class DCC
    {
        /*
        This problem was asked by Google.

        A regular number in mathematics is defined as one which evenly divides some power of 60.
        Equivalently, we can say that a regular number is one whose only prime divisors are 2, 3, and 5.

        These numbers have had many applications, from helping ancient Babylonians keep time to tuning
        instruments according to the diatonic scale.

        Given an integer N, write a program that returns, in order, the first N regular numbers.
        */

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (IsRegularNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsRegularNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if ((num % i == 0) && IsPrime(i))
                {
                    if (i > 5)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i / 2 < number; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }

            return true;
        }
    }
}

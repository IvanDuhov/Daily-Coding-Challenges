using System;

namespace DCC
{
    class DCC
    {
        /*
        This problem was asked by LinkedIn.

        You are given a string consisting of the letters x and y, such as xyxxxyxyy. In addition, you have an 
        operation called flip, which changes a single x to y or vice versa.

        Determine how many times you would need to apply this operation to ensure that all x's come before all y's.
        In the preceding example, it suffices to flip the second and sixth characters, so you should return 2.
        */

        public static void Main()
        {
            string str = Console.ReadLine();
            byte neededFlips = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'y' && GetTheRestOfTheString(str, i, str.Length).Contains("x"))
                {
                    str = Flip(str, i);
                    neededFlips++;
                }
            }

            Console.WriteLine(neededFlips);
            Console.WriteLine(str);
        }

        public static string GetTheRestOfTheString(string str, int start, int end)
        {
            string res = "";
            for (int i = start; i < end; i++)
            {
                res += str[i].ToString();
            }

            return res;
        }

        public static string Flip(string str, int index)
        {
            string res = "";
            string replace;

            if (str[index] == 'x')
            {
                replace = "y";
            }
            else
            {
                replace = "x";
            }


            for (int i = 0; i < str.Length; i++)
            {
                if (i == index)
                {
                    res += replace;
                }
                else
                {
                    res += str[i];
                }
            }

            return res;
        }
    }
}

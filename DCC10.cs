using System;

namespace DCC
{
    class DCC
    {
        /*
        This problem was asked by Jane Street.

        Given integers M and N, write a program that counts how many positive integer pairs (a, b) satisfy the following conditions:

        a + b = M
        a XOR b = N
        */

        public static void Main()
        {
            uint m = uint.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());

            uint count = 0;

            for (int a = 0; a < m + n; a++)
            {
                for (int b = 0; b < n + m; b++)
                {
                    int c = a ^ b;
                    if (a + b == m && c == n)
                    {
                        Console.WriteLine("{0} xor {1} = {2}", a, b, c);
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}

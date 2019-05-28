using System;

namespace ProjectEuler
{
    class DCC3
    {
        /*
         * Good morning! Here's your coding interview problem for today.

            This problem was asked by Google.

            In linear algebra, a Toeplitz matrix is one in which the elements on any given diagonal from top left to
            bottom right are identical.

            Here is an example:

            1 2 3 4 8
            5 1 2 3 4
            4 5 1 2 3
            7 4 5 1 2
            Write a program to determine whether a given input is a Toeplitz matrix.


        */
        static void Main(string[] args)
        {
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            MatrixInput(matrix, n, m);
            Console.WriteLine(IsToeplitz(matrix, n, m));

        }

        public static void MatrixInput(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Matrix [{0},{1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        public static bool IsToeplitz(int[,] matrix, int n, int m)
        {
            int targetTile;
            targetTile = 0;

            for (int i = 0; i < n - 1; i++)
            {
                bool IsToe = false;
                int DiagonalValue = matrix[targetTile, targetTile];
                int indexNN, indexMM;
                indexMM = indexNN = targetTile;

                while (!IsToe)
                {
                    if (matrix[indexNN, indexMM] == DiagonalValue)
                    {
                        if (indexNN < n - 1 && indexMM < m - 1)
                        {
                            indexNN++;
                            indexMM++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                targetTile++;
            }

            return true;
        }

    }
}
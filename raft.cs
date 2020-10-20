using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] ints = input.Split(' ').Select(int.Parse).ToArray();

            int n = ints[0];
            int k = ints[1];

            string goatsWeightStr = Console.ReadLine();
            List<int> goatsWeight = goatsWeightStr.Split(' ').Select(int.Parse).ToList();

            int capacity = goatsWeight.Max();

            goatsWeight.Sort();
            goatsWeight.Reverse();

            bool successfullPassage = false;
            int count = 0;

            while (!successfullPassage)
            {
                count = 0;
                goatsWeight.Clear();
                goatsWeight = goatsWeightStr.Split(' ').Select(int.Parse).ToList();
                goatsWeight.Sort();
                goatsWeight.Reverse();

                while (count <= k)
                {
                    int currentWeight = 0;

                    for (int i = 0; i < goatsWeight.Count; i++)
                    {
                        goatsWeight.Sort();
                        goatsWeight.Reverse();

                        if (currentWeight >= capacity)
                        {
                            currentWeight = 0;
                            break;
                        }
                        else if (currentWeight <= capacity)
                        {
                            currentWeight += goatsWeight[i];
                            goatsWeight.Remove(goatsWeight[i]);
                        }

                    }
                    count++;

                    if (goatsWeight.Count == 0)
                    {
                        successfullPassage = true;
                    }
                }

                capacity++;
            }
            Console.WriteLine(capacity);
        }


    }
}

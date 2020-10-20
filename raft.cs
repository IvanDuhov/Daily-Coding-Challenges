using System;
using System.Collections.Generic;
using System.Linq;

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
                goatsWeight = goatsWeightStr.Split(' ').Select(int.Parse).ToList();

                goatsWeight.Sort();
                goatsWeight.Reverse();

                for (int i = 0; i < k; i++)
                {
                    int currentWeight = 0;
                    List<int> removedGoats = new List<int>();

                    for (int j = 0; j < goatsWeight.Count; j++)
                    {

                        if (currentWeight >= capacity)
                        {
                            break;
                        }
                        else
                        {
                            if (currentWeight + goatsWeight[j] <= capacity)
                            {
                                currentWeight += goatsWeight[j];
                                removedGoats.Add(goatsWeight[j]);
                            }
                        }
                    }

                    foreach (var item in removedGoats)
                    {
                        goatsWeight.Remove(item);
                    }
                }

                if (goatsWeight.Count == 0)
                {
                    successfullPassage = true;
                }

                capacity++;
            }

            Console.WriteLine(capacity - 1);
        }
    }
}

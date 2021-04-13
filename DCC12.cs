using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    /// <summary>
    /// This problem was asked by Amazon.
    /// Given a string s and an integer k, break up the string into multiple lines such that each line has a length of k or less.You must break it up so that words don't break across lines. Each line has to have the maximum possible amount of words. If there's no way to break the text up, then return null.
    ///You can assume that there are no spaces at the ends of the string and that there is exactly one space between each word.
    //For example, given the string "the quick brown fox jumps over the lazy dog" and k = 10, you should return: ["the quick", "brown fox", "jumps over", "the lazy", "dog"]. No string in the list has a length of more than 10.
    /// </summary>
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int limit = int.Parse(Console.ReadLine());

        List<string> words = s.Split(' ').ToList();

        while (words.Count != 0)
        {
            int sum = 0;
            List<string> calculatedWords = new List<string>();
            string res = "";

            for (int i = 0; i < words.Count; i++)
            {
                if (sum + words[i].Length <= limit)
                {
                    calculatedWords.Add(words[i]);
                    res += words[i] + " ";
                    sum += words[i].Length;

                    if (calculatedWords.Count > 0)
                    {
                        sum++;
                    }
                }
                else break;
            }

            Console.WriteLine(res);

            foreach (var word in calculatedWords)
            {
                words.Remove(word);
            }
        }
    }
}

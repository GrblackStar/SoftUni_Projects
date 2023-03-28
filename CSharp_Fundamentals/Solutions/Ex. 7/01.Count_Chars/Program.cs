using System;
using System.Collections.Generic;

namespace _01.Count_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                // first check if the char is an empty string -> ' ' -> continue
                // than check if the char exists in the dictionary
                    // if it exists -> increase count
                    // if it doesn't -> add and increase count
                if (c == ' ')
                {
                    continue;
                }
                if (charDictionary.ContainsKey(c))
                {
                    charDictionary[c]++;
                }
                else
                {
                    charDictionary.Add(c, 1);
                }

            }

            foreach(var item in charDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

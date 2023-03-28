using System;
using System.Text;

namespace _06.Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // replaces any sequence of the same letter with a single corresponding letter.
            // aaaaabbbbbcdddeeeedssaa
            // abcdedsa


            // another solution is to make it without the bulder
            // in the loop just print the first char and if the current is different 
            // with Write, not WriteLine

            string input = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                if(i == 0)
                {
                    stringBuilder.Append(input[i]);
                }
                
                if (i >= 1)
                {
                    if (input[i] != input[i - 1])
                    {
                        stringBuilder.Append(input[i]);
                    }
                }
            }

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}

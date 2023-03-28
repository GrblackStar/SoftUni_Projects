using System;
using System.Text;

namespace _04.Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that returns an encrypted version of the same text.
            // Encrypt the text by shifting each character with three positions forward.
            // For example, A would be replaced by D, B would become E and so on.
            // Print the encrypted text.

            // Programming is cool!	
            // Surjudpplqj#lv#frro$

            string input = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i];
                stringBuilder.Append((char)(current + 3));
            }

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}

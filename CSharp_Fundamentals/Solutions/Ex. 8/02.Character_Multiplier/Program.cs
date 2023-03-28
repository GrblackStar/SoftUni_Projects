using System;

namespace _02.Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a method that takes two strings as arguments and returns the sum of their character codes multiplied. 
            // Multiply str1[0] with str2[0] and add to the total sum.
            // Then continue with the next two characters.
            // If one of the strings is longer than the other,
            // add the remaining character codes to the total sum without multiplication.

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            GetStringSum(input[0], input[1]);

        }

        private static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestString = stringOne;
            if (longestString.Length < stringTwo.Length)
            {
                longestString = stringTwo;
            }

            for (int i = minLength; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }



            Console.WriteLine(sum);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.+)?\>(?<numbers>\d{3})\|(?<lowerCaseLetters>[a-z]{3})\|(?<upperCaseLetters>[A-Z]{3})\|(?<symbols>[^\<\>]{3})\<\1";
            Regex regex = new Regex(pattern);

            StringBuilder stringBuilder = new StringBuilder();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                if(stringBuilder.Length > 0)
                {
                    stringBuilder.Clear();
                }

                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Try another password!");
                }

                if (match.Success)
                {
                    //Console.WriteLine("valid match  ========> success");
                    string numberGroup = match.Groups["numbers"].Value;
                    string lowecaseGroup = match.Groups["lowerCaseLetters"].Value;
                    string uppercaseGroup = match.Groups["upperCaseLetters"].Value;
                    string symbolsGroup = match.Groups["symbols"].Value;

                    stringBuilder.Append(numberGroup);
                    stringBuilder.Append(lowecaseGroup);
                    stringBuilder.Append(uppercaseGroup);
                    stringBuilder.Append(symbolsGroup);

                    Console.WriteLine($"Password: {stringBuilder}");

                }




            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // On the first line, you will be given a list of participants separated by ", ".
            // On the next few lines, until you receive a line "end of the race",
            // you will be given some info which will be some alphanumeric characters.
            // In between them, you could have some extra characters which you should ignore.
            // For example: "G!32e%o7r#32g$235@!2e".
            // The letters are the name of the person and the sum of the digits is the distance he ran.
            // So here we have George who ran 29 km.
            // Store the information about the person only if the list of racers contains the name of the person.
            // If you receive the same person more than once, just add the distance to his old distance.
            // At the end print the top 3 racers in the format:
            // 1st place: {first racer}
            // 2nd place: { second racer}
            // 3rd place: { third racer}



            // pattern name:
            string namePattern = @"([A-Za-z]+)";
            Regex nameRegex = new Regex(namePattern);

            // pattern numbers:
            string numbersPattern = @"(?<numbers>\d*)";
            Regex numbersRegex = new Regex(numbersPattern);


            // putting the first input names in the dictionary:
            string[] inputNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> participants = new Dictionary<string, int>();
            foreach (string inputName in inputNames)
            {
                participants.Add(inputName, 0);
            }

           // reading the next line that need to be matched:
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                // match for the names:
                MatchCollection nameMatch = nameRegex.Matches(input);
                StringBuilder stringBuilderNames = new StringBuilder();

                foreach (Match m in nameMatch)
                {
                    stringBuilderNames.Append(m.Value);
                }
                // getting the names:
                string name = stringBuilderNames.ToString();


                // check if the dictionary contains the name and than match the other things
                // check dictionary:
                if (participants.ContainsKey(name))
                {
                    // match the numbers
                    MatchCollection numberMatch = numbersRegex.Matches(input);
                    StringBuilder stringBuilderNumbers = new StringBuilder();

                    foreach (Match m in numberMatch)
                    {
                        stringBuilderNumbers.Append(m.Value);
                    }
                    string number = stringBuilderNumbers.ToString();


                    // calculate the miles:
                    int sum = 0;
                    for(int i = 0; i < number.Length; i++)
                    {
                        if (number[i] >= 0)
                        {
                            sum += number[i];
                        }
                        
                    }

                    participants[name] += sum;

                }

            }


           
            int count = 0;
            foreach (var person in participants.OrderByDescending(x => x.Value))
            {
                count++;
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {person.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {person.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {person.Key}");
                    break;
                }

            }

        }
    }
}

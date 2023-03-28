using System;
using System.Collections.Generic;

namespace _01.Valid_Username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reads user names on a single line (joined by ", ") and prints all valid usernames:
            // A valid username
            // has length between 3 and 16 characters
            // contains only letters, numbers, hyphens and underscores

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validNames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                bool validFlag = true;

                // going through each word:
                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    //going through each letter
                    for (int j = 0; j < input[i].Length; j++)
                    {
                        char current = input[i][j];

                        if (!(current == '-' || current == '_' || char.IsLetter(current) || char.IsDigit(current)))
                        {
                            // invalid
                            validFlag = false;
                            break;
                        }


                    }

                    if (!validFlag)
                    {
                        continue;
                    }


                    validNames.Add(input[i]);


                }





            }

            if (validNames.Count > 0)
            {
                foreach (string name in validNames)
                {
                    Console.WriteLine(name);
                }

                //Console.WriteLine(String.Join(Environment.NewLine, validNames));

            }




        }
    }
}

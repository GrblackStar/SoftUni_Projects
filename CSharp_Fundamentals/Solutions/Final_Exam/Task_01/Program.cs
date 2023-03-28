using System;
using System.Text;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringInput = new StringBuilder(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                if (commandArgs[0] == "Translate")
                {
                    char replaceChar = char.Parse(commandArgs[1]);
                    char replacement = char.Parse(commandArgs[2]);

                    for (int i  = 0; i < stringInput.Length; i++)
                    {
                        stringInput.Replace(replaceChar, replacement);
                    }

                    Console.WriteLine(stringInput.ToString());

                }
                else if (commandArgs[0] == "Includes")
                {
                    string substring = commandArgs[1];
                    if (stringInput.ToString().Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }





                }
                else if (commandArgs[0] == "Start")
                {
                    string substring = commandArgs[1];
                    if(stringInput.ToString().StartsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }





                }
                else if (commandArgs[0] == "Lowercase")
                {
                    //stringInput.ToString().ToLower();
                    //Console.WriteLine(stringInput.ToString());

                    string forLower = stringInput.ToString();
                    forLower = forLower.ToLower();

                    stringInput.Remove(0, stringInput.Length);
                    stringInput.Append(forLower);
                    Console.WriteLine(stringInput.ToString());

                }
                else if (commandArgs[0] == "FindIndex")
                {
                    char lastOccur = char.Parse(commandArgs[1]);
                    Console.WriteLine(stringInput.ToString().LastIndexOf(lastOccur));

                }
                else if (commandArgs[0] == "Remove")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    stringInput.Remove(startIndex, count);
                    Console.WriteLine(stringInput.ToString());

                }


            }




        }
    }
}

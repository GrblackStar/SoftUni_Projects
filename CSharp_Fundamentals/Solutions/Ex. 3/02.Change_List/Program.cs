using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = null;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArguments[0] == "Delete")
                {
                    int deleteValue = int.Parse(commandArguments[1]);

                    for(int i = integersList.Count - 1; i >= 0; i--)
                    {
                        if (integersList[i] == deleteValue)
                        {
                            integersList.Remove(deleteValue);
                        }
                    }

                }
                else if (commandArguments[0] == "Insert")
                {
                    int deleteValue = int.Parse(commandArguments[1]);
                    int deleteIndex = int.Parse((commandArguments[2]));

                    integersList.Insert(deleteIndex, deleteValue);

                }


            }


            Console.WriteLine(string.Join(" ", integersList));

        }
    }
}

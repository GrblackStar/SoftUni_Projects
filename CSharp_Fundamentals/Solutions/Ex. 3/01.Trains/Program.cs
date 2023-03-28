using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Trains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> initialWagonPeople = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = null;
            while((command = Console.ReadLine()) !="end")
            {
                string[] commandArguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // if the array has more than one element, that means we reseave an ADD
                // if the length is 1 -> we recieve passengers:

                if(commandArguments.Length == 2)
                {
                    // adding a wagon with people
                    int wagonToAdd = int.Parse(commandArguments[1]);
                    initialWagonPeople.Add(wagonToAdd);

                }
                else if (commandArguments.Length == 1)
                {
                    // just adding passengers
                    // need to chech if all passengers can be fit in one wagon
                    // in a loop
                    // if they can, we add them and break from the loop
                    // WHAT HAPPENS IF THEY CANNOT BE ALL FITTET IN ONE WAGON
                    // can have a flag that tells me if they are added
                    int peopleToAdd = int.Parse(commandArguments[0]);

                    for(int i = 0; i < initialWagonPeople.Count; i++)
                    {
                        if((initialWagonPeople[i] + peopleToAdd) <= maxCapacity)
                        {
                            initialWagonPeople[i] += peopleToAdd;
                            break;
                        }
                    }


                }



            }

            Console.WriteLine(string.Join(" ", initialWagonPeople));

        }
    }
}

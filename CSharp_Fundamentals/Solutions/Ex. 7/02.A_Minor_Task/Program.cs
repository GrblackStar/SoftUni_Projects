using System;
using System.Collections.Generic;

namespace _02.A_Minor_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will be given a sequence of strings, each on a new line.
            // Every odd line on the console is representing a resource and every even - quantity.
            // Your task is to collect the resources and print them each on a new line.
            // Print the resources and their quantities in the following format:
            // "{resource} –> {quantity}"



            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                //if(!resources.ContainsKey(input))
                //{
                //    resources[input] = 0;
                //}
                //resources[input] += quantity;

                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;
                }
                else
                {
                    resources.Add(input, quantity);
                }
            }

            foreach(var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

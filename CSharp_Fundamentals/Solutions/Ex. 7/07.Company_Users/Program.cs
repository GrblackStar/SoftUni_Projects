using System;
using System.Collections.Generic;

namespace _07.Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will be receiving a company name and an employee's id, until you receive the "End" command.
            // Add each employee to the given company
            // a company cannot have two employees with the same id.
            // print the company's name and each employee's id in the following format:
            //       {companyName}
            //           -- { id1}
            //           -- { id2}
            //           -- { idN}

            Dictionary<string, List<string>> companiesDictionary = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = commandArgs[0];
                string employeeId = commandArgs[1];

                if (!companiesDictionary.ContainsKey(companyName))
                {
                    companiesDictionary[companyName] = new List<string>();
                }

                if (!companiesDictionary[companyName].Contains(employeeId))
                {
                    companiesDictionary[companyName].Add(employeeId);
                }
                

            }

            foreach(var item in companiesDictionary)
            {
                Console.WriteLine(item.Key);
                foreach(string employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }


        }
    }
}

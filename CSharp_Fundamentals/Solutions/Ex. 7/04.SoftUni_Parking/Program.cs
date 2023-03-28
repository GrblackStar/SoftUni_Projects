using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _04.SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registries = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // "register {username} {licensePlateNumber}":
                    // one car per user
                    // if a user tries to register another license plate, using the same username, the system should print:
                        // "ERROR: already registered with plate number {licensePlateNumber}"
                    // If the aforementioned checks passes successfully, the plate can be registered
                        // "{username} registered {licensePlateNumber} successfully"

                // "unregister {username}":
                    // If the user is not present in the database  =>  "ERROR: user {username} not found"
                    // If the aforementioned check passes successfully  =>  "{username} unregistered successfully"

                
                string input = Console.ReadLine();
                string[] commandArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string username = commandArgs[1];

                if (commandArgs[0] == "register")
                {
                    string licensePlateNumber = commandArgs[2];

                    if (!registries.ContainsKey(username))
                    {
                        registries[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        string registeredPlate = registries[username];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlate}");
                    }



                }
                else if (commandArgs[0] == "unregister")
                {
                    if (!registries.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registries.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }

            }



            foreach (var item in registries)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }


        }
    }
}

using System;
using System.Linq;

namespace _02.Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] route = Console.ReadLine()
                .Split("||")
                .ToArray();

            int fuelAmount = int.Parse(Console.ReadLine());
            int startAmmunition = int.Parse(Console.ReadLine());

            // for every command from the first line:
            for (int i = 0; i < route.Length; i++)
            {
                // i need to seperate every element into subelements:
                // than check their length
                // than check their first string:
                string[] commands = route[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();



                // travel, enemy, repair
                if (commands.Length == 2)
                {
                    if (commands[0] == "Travel")
                    {
                        int ligthYears = int.Parse(commands[1]);
                        fuelAmount -= ligthYears;

                        if (fuelAmount < 0)
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"The spaceship travelled {ligthYears} light-years.");
                        }

                    }
                    else if (commands[0] == "Enemy")
                    {
                        int enemyArmor = int.Parse(commands[1]);
                        if (startAmmunition >= enemyArmor)  // fight
                        {
                            startAmmunition -= enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                        }
                        else if ((startAmmunition < enemyArmor) && (fuelAmount - (enemyArmor * 2) >= 0))   // run
                        {
                            fuelAmount -= enemyArmor * 2;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }





                    }
                    else if (commands[0] == "Repair")
                    {
                        int additions = int.Parse(commands[1]);

                        fuelAmount += additions;
                        startAmmunition += additions * 2;

                        Console.WriteLine($"Ammunitions added: {(additions)*2}.");
                        Console.WriteLine($"Fuel added: {additions}.");
                    }
                }
                else if(commands.Length == 1  && commands[0] == "Titan")  // titan
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }



            }






        }
    }
}

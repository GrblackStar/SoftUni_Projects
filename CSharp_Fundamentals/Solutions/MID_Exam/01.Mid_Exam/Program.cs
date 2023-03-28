using System;

namespace _01.Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            decimal groupEnergy = decimal.Parse(Console.ReadLine());
            decimal waterDayOnePerson = decimal.Parse(Console.ReadLine());
            decimal foodDayOnePerson = decimal.Parse(Console.ReadLine());

            decimal totalWater = daysOfAdventure * waterDayOnePerson * playersCount;
            decimal totalFood = daysOfAdventure * playersCount * foodDayOnePerson;

            decimal currentFood = totalFood;


            for (int i = 1; i <= daysOfAdventure; i++)
            {
                decimal energyLossPerDay = decimal.Parse(Console.ReadLine());

                groupEnergy -= energyLossPerDay;

                if (groupEnergy > 0)
                {
                    if (i % 2 == 0)
                    {
                        groupEnergy = groupEnergy + groupEnergy * 0.05m;
                        totalWater = totalWater - totalWater * 0.3m;
                    }

                    if (i % 3 == 0)
                    {
                        groupEnergy = groupEnergy + groupEnergy * 0.1m;

                        totalFood = totalFood - (totalFood / playersCount);

                    }
                }
                



               else if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                    return;
                }
            }


            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");

        }
    }
}

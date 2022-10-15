using System;

namespace Basics_Exam
{
    internal class Program
    {
        static void Moon()
        {
            double velocity = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            int distance = 768800;

            double time = Math.Ceiling(distance / velocity);
            int totoalTime = (int)time + 3;

            int totalFuel = (int)((fuel * distance) / 100);

            Console.WriteLine(totoalTime);
            Console.WriteLine(totalFuel);
        }
        static void BeerAndChips()
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beer = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double beerPrice = beer * 1.2;
            int chipsPrice = (int)(Math.Ceiling((0.45 * beerPrice) * chips));


            double total = beerPrice + chipsPrice;

            if (budget >= total)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - total):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(total - budget):f2} more leva!");
            }
        }
        static void CatLife()
        {
            string breed = Console.ReadLine();
            char sex = char.Parse(Console.ReadLine());

            int humanMonths;
            int catMonths;

            switch (breed)
            {
                case "British Shorthair":
                    if (sex == 'm')
                    {
                        humanMonths = 13 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");

                    }
                    else if (sex == 'f')
                    {
                        humanMonths = 14 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");
                    }
                    break;
                case "Siamese":
                    if (sex == 'm')
                    {
                        humanMonths = 15 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");

                    }
                    else if (sex == 'f')
                    {
                        humanMonths = 16 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");
                    }
                    break;
                case "Persian":
                    if (sex == 'm')
                    {
                        humanMonths = 14 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");

                    }
                    else if (sex == 'f')
                    {
                        humanMonths = 15 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");
                    }
                    break;
                case "Ragdoll":
                    if (sex == 'm')
                    {
                        humanMonths = 16 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");

                    }
                    else if (sex == 'f')
                    {
                        humanMonths = 17 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");
                    }
                    break;
                case "American Shorthair":
                    if (sex == 'm')
                    {
                        humanMonths = 12 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");

                    }
                    else if (sex == 'f')
                    {
                        humanMonths = 13 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");
                    }
                    break;
                case "Siberian":
                    if (sex == 'm')
                    {
                        humanMonths = 11 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");

                    }
                    else if (sex == 'f')
                    {
                        humanMonths = 12 * 12;
                        catMonths = (int)(Math.Floor(humanMonths * 1.0 / 6));
                        Console.WriteLine($"{catMonths} cat months");
                    }
                    break;
                default:
                    Console.WriteLine($"{breed} is invalid cat!");
                    break;

            }
        }
        static void GiftsFromSanta()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    if (i != s)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        static void ChristmasGifts()
        {
            int age;

            int children = 0;
            int adults = 0;

            string command;
            while ((command = Console.ReadLine()) != "Christmas")
            {
                age = int.Parse(command);

                if (age <= 16)
                {
                    children++;
                }
                else
                {
                    adults++;
                }
            }

            int childrenMoney = children * 5;
            int adultMoney = adults * 15;

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {children}");
            Console.WriteLine($"Money for toys: {childrenMoney}");
            Console.WriteLine($"Money for sweaters: {adultMoney}");
        }
        static void GoldMine()
        {
            int locations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= locations; i++)
            {
                double estimated = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());

                double goldPerLocation = 0.00;
                int finalDays = days;

                for (int j = 1; j <= days; j++)
                {
                    double goldForTheDay = double.Parse(Console.ReadLine());
                    goldPerLocation += goldForTheDay;
                }

                double averagePerDay = goldPerLocation / finalDays;


                if (averagePerDay >= estimated)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averagePerDay:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {(estimated - averagePerDay):f2} gold.");
                }

            }
        }


        static void Main(string[] args)
        {
            //Moon();
            //BeerAndChips();
            //CatLife();
            //GiftsFromSanta();
            //ChristmasGifts();
            //GoldMine();
        }
    }
}

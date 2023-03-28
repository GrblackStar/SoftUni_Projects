using System;

namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumInputCoins = 0;
            string inputString;


            while ((inputString = Console.ReadLine()) != "Start")
            {
                if ((double.Parse(inputString)) == 0.1
                    || (double.Parse(inputString)) == 0.2
                    || (double.Parse(inputString)) == 0.5
                    || (double.Parse(inputString)) == 1
                    || (double.Parse(inputString)) == 2)
                {
                    sumInputCoins += double.Parse(inputString);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputString}");
                }
            }

            while ((inputString = Console.ReadLine()) != "End")
            {
                if (inputString == "Nuts")
                {
                    if((sumInputCoins - 2.0) < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased nuts");
                        sumInputCoins -= 2.0;
                    }
                }
                else if (inputString == "Water")
                {
                    if ((sumInputCoins - 0.7) < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased water");
                        sumInputCoins -= 0.7;
                    }
                }
                else if (inputString == "Crisps")
                {
                    if ((sumInputCoins - 1.5) < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased crisps");
                        sumInputCoins -= 1.5;
                    }
                }
                else if (inputString == "Soda")
                {
                    if ((sumInputCoins - 0.8) < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                        sumInputCoins -= 0.8;
                    }
                }
                else if (inputString == "Coke")
                {
                    if ((sumInputCoins - 1.0) < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased coke");
                        sumInputCoins -= 1.0;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }


            Console.WriteLine($"Change: {sumInputCoins:F2}");

        }
    }
}

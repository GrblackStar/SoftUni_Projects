using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calculate the total cost of different types of furniture.
            // ">>{furniture name}<<{price}!{quantity}"

            List<string> furniture = new List<string>();
            double totalPrice = 0;

            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);

            string input;
            while((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(furnitureName);
                    totalPrice += pricePerUnit * quantity;
                }

            }



            Console.WriteLine($"Bought furniture:");
            foreach (string furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");



        }
    }
}

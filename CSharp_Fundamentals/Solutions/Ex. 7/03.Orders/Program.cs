using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Each product has a name, a price and a quantity
            // If the product doesn't exist yet, add it with its starting quantity
            // If you receive a product, which already exists, increase its quantity by the input quantity
            // and if its price is different, replace the price as well.

            
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productsTotalPrices = new Dictionary<string, double>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] product = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string productName = product[0];
                double productPrice = double.Parse(product[1]);
                int productQuantity = int.Parse(product[2]);

                if (productsPrices.ContainsKey(productName))
                {
                    //products[productName] += productPrice * productQuantity;
                    productsQuantity[productName] += productQuantity;
                    if (productsPrices[productName] != productPrice)
                    {
                        productsPrices[productName] = productPrice;
                    }
                    productsTotalPrices[productName] = (productsQuantity[productName]) * productPrice;
                }
                else
                {
                    //products.Add(productName, (productPrice * productQuantity));
                    productsPrices.Add(productName, productPrice);
                    productsQuantity.Add(productName, productQuantity);
                    productsTotalPrices.Add(productName, productQuantity * productPrice);
                }
            }

            foreach (var item in productsTotalPrices)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value):F2}");
            }


        }
    }
}

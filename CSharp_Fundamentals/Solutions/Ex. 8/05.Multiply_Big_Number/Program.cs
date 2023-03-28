using System;
using System.Text;

namespace _05.Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You are given two lines – the first one can be a really big number (0 to 10^50).
            // The second one will be a single-digit number (0 to 9).
            // Your task is to display the product of these numbers.
            // Note: do not use the BigInteger class.

            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            //creates us an empty stryng that we need to append qith the result
            StringBuilder stringBuilder = new StringBuilder();

            int reminder = 0;

            // if one of the numbers is 0  =>  the output is 0
            if (input == "0"  ||  multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            // reversing the input:
            for (int i = input.Length - 1; i >= 0; i--)     // 23 -> 32
            {
                // getting the current char to string:
                int currentDigit = int.Parse(input[i].ToString());
                int product = currentDigit * multiplier + reminder; 

                // for the product: 3 * 2 + 0  =>  6
                // on thenext go: 2 * 2 + 0  =>  4
                // in the stringBuilder we insert: 4, 6

                // REMINDER LOGIC:  product(6) % 10  =>  0
                // if the multiplication result is greater than 10, the reminder will be added on the next itteration

                // to get the next digit
                int result = product % 10;   // 32 % 10  =>  2
                // in the next iteration we are goin to have the next digit -> 2
                reminder = product / 10;
                //inserting the result at the first index   =>   reversing again
                stringBuilder.Insert(0, result);
            }


            if (reminder > 0)
            {
                stringBuilder.Insert(0, reminder);
            }

            Console.WriteLine(stringBuilder.ToString());


        }
    }
}

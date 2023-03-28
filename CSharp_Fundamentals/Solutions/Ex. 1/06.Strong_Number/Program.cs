using System;

namespace _06.Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int totalSum = 0;

            int inputNumberCopy = inputNumber;
            
            while (inputNumberCopy > 0)
            {
                int lastDigit = inputNumberCopy % 10;
                totalSum += SumOfFactoriel(lastDigit);
                inputNumberCopy /= 10;
            }

            if(totalSum == inputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


            // 145 -> 1! + 4! + 5!

        }


        static int SumOfFactoriel(int inputNumber)
        {
            int factoriel = 1;


            for (int i = 1; i <= inputNumber; i++)
            {
                factoriel = factoriel * i;
                
            }
            return factoriel;

        }

    }
}

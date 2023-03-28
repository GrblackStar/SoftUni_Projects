using System;

namespace _08.Triangle_Of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for(int i = 1; i <= inputNumber; i++) // rows
            {
                for (int j = 1; j <= i; j++) // cols
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

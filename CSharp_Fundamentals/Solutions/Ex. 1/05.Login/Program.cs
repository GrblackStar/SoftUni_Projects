using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] charPassword = username.ToCharArray();
            Array.Reverse(charPassword);
            string password = new string(charPassword);


            int numOfTries = 0;

            string inputPassword = null;
            while((inputPassword = Console.ReadLine()) != password)
            {
                
                numOfTries++;

                if(numOfTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}

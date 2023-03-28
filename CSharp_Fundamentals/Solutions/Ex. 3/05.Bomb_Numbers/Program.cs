/*using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] bombArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int bombNumber = int.Parse(bombArray[0]);
            int power = int.Parse(bombArray[1]);

            int sumRmainingList = 0;

            for(int i = 0; i < initialList.Count; i++)
            {
                int index = initialList.IndexOf(bombNumber);
                int startIndex = index - power;
                int endIndex = index + power;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > initialList.Count -1)
                {
                    endIndex = initialList.Count - 1;
                }


                for (int j = endIndex; j >= startIndex; j--)
                {
                    initialList.RemoveAt(j);
                }

                Console.WriteLine(string.Join(" ", initialList));
                //initialList.Remove(bombNumber);

            }
            
           

            Console.WriteLine(string.Join(" ", initialList));
        }
    }
}

*/








using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine() // 1 2 2 4 2 2 2 9
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombArgs = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int bombValue = bombArgs[0];
            int power = bombArgs[1];

            int bombIndex = numbers.IndexOf(bombValue);
            int startingIndex = bombIndex - power;
            int sum = 0;

            int numbersToRemove = 1 + 2 * power;
            if (power >= 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bombValue)
                    {
                        startingIndex = i - power;
                        if (startingIndex >= 0)
                        {
                            for (int j = 1; j <= numbersToRemove; j++)
                            {
                                if (startingIndex > numbers.Count - 1)
                                {
                                    break;
                                }
                                else
                                {
                                    numbers.RemoveAt(startingIndex);
                                }
                            }
                            i--;
                        }
                        else
                        {
                            break;
                        }
                    }


                }
                foreach (var item in numbers)
                {
                    sum += item;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
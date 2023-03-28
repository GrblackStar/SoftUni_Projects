using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOFPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceBeforeDiscount = 0;
            double totalPrice = 0;

            if(typeOfGroup == "Students")
            {
                if(dayOfWeek == "Friday")
                {
                    priceBeforeDiscount = numOFPeople * 8.45;
                }
                else if(dayOfWeek == "Saturday")
                {
                    priceBeforeDiscount = numOFPeople * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceBeforeDiscount = numOFPeople * 10.46;
                }



                if(numOFPeople >= 30)
                {
                    totalPrice = priceBeforeDiscount - (priceBeforeDiscount * 0.15);
                }
                else
                {
                    totalPrice = priceBeforeDiscount;
                }


            }
            else if(typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    priceBeforeDiscount = numOFPeople * 10.9;
                    if (numOFPeople >= 100)
                    {
                        totalPrice = priceBeforeDiscount - (10 * 10.9);
                    }
                    else
                    {
                        totalPrice = priceBeforeDiscount;
                    }

                }
                else if (dayOfWeek == "Saturday")
                {
                    priceBeforeDiscount = numOFPeople * 15.6;
                    if (numOFPeople >= 100)
                    {
                        totalPrice = priceBeforeDiscount - (10 * 15.6);
                    }
                    else
                    {
                        totalPrice = priceBeforeDiscount;
                    }

                }
                else if (dayOfWeek == "Sunday")
                {
                    priceBeforeDiscount = numOFPeople * 16;
                    if (numOFPeople >= 100)
                    {
                        totalPrice = priceBeforeDiscount - (10 * 16);
                    }
                    else
                    {
                        totalPrice = priceBeforeDiscount;
                    }

                }


            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    priceBeforeDiscount = numOFPeople * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceBeforeDiscount = numOFPeople * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceBeforeDiscount = numOFPeople * 22.5;
                }



                if (numOFPeople >= 10  &&  numOFPeople <= 20)
                {
                    totalPrice = priceBeforeDiscount - (priceBeforeDiscount * 0.05);
                }
                else
                {
                    totalPrice = priceBeforeDiscount;
                }


            }




            Console.WriteLine($"Total price: {totalPrice:F2}");


        }
    }
}

using System;

namespace CSharp_Basics
{
    internal class Program
    {
        static void HelloSoftUni()
        {
            Console.WriteLine("Hello SoftUni!");
        }
        static void Nums1to10()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
        }
        static void RectangleArea()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
        }
        static void InchToCm()
        {
            double a = double.Parse(Console.ReadLine());
            double b = a * 2.54;

            Console.WriteLine(b);
        }
        static void GreetingByName()
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
        static void ConcatenateData()
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {lastName}, a {age}-years old person from {town}.");
        }
        static void ProjectsCreation()
        {
            string name = Console.ReadLine();
            int projectsNum = int.Parse(Console.ReadLine());
            int hours = projectsNum * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projectsNum} project/s.");
        }
        static void PetShop()
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            Console.WriteLine((dogFood * 2.5) + (catFood * 4) + " lv.");
        }
        static void YardGreenind()
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
        static void UsdToBng()
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            Console.WriteLine(bgn);
        }
        static void RadiansToDegrees()
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
        static void DepositCalculator()
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double finalPrice = (double)(deposit + months * ((deposit * (percentage) / 100) / 12));

            Console.WriteLine(finalPrice);
        }
        static void VacationBooksList()
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerMinute = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursPerDay = (pages / pagesPerMinute) / days;

            Console.WriteLine(hoursPerDay);
        }
        static void SuppiesForSchool()
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liquid = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());



            Console.WriteLine(((pens * 5.8) + (markers * 7.2) + (liquid * 1.2)) - (((pens * 5.8) + (markers * 7.2) + (liquid * 1.2)) * (discount / 100)));

        }
        static void Repainting()
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());


            double allNylon = (nylon + 2) * 1.5;
            double allPaint = (paint + 0.1 * paint) * 14.5;
            double allThinner = (thinner * 5);

            double beforePrice = ((nylon + 2) * 1.5) + ((paint + 0.1 * paint) * 14.5) + (thinner * 5) + 0.4;
            double peoplePrice = (beforePrice * 0.3) * hours;

            Console.WriteLine(peoplePrice + beforePrice);
        }
        static void FoodDelivery()
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggies = int.Parse(Console.ReadLine());

            double foodPrice = (chicken * 10.35) + (fish * 12.4) + (veggies * 8.15);
            double wholePrice = foodPrice + (foodPrice * 0.2) + 2.5;

            Console.WriteLine(wholePrice);
        }
        static void BasketballEquipment()
        {
            int yearlyPayment = int.Parse(Console.ReadLine());


            double shoes = yearlyPayment - (yearlyPayment * 0.4);
            double clothes = shoes - (shoes * 0.2);
            double ball = clothes / 4;
            double accesories = ball / 5;


            Console.WriteLine(yearlyPayment + shoes + clothes + ball + accesories);
        }
        static void FishTank()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());


            double volume = (lenght * width * height) * 0.001;
            double water = volume * (1 - (percentage / 100));



            Console.WriteLine(water);
        }
        static void ExellentResult()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {

                Console.WriteLine("Excellent!");
            }
        }
        static void GreaterNumber()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else if (b >= a)
            {
                Console.WriteLine(b);
            }
        }
        static void EvenOrOdd()
        {
            int num = int.Parse(Console.ReadLine());

            if ((num % 2) == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        static void PasswordGuess()
        {
            //int num = int.Parse(Console.ReadLine());
            string password = "s3cr3t!P@ssw0rd";
            string input = Console.ReadLine();

            if (password == input)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
        static void Number100To200()
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }

            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
        static void SpeedInfo()
        {
            double speed = double.Parse(Console.ReadLine());



            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if ((speed > 10) && (speed <= 50))
            {
                Console.WriteLine("average");
            }
            else if ((speed > 50) && (speed <= 150))
            {
                Console.WriteLine("fast");
            }
            else if ((speed > 150) && (speed <= 1000))
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
        static void AreaOfFigures()
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (side * side));
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", side1 * side2);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", radius * radius * Math.PI);
            }
            else if (figure == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (side1 * side2) / 2);
            }
        }
        static void SumSeconds()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int total = first + second + third;

            int minutes = total / 60;
            int seconds = total % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
        static void BonusScore()
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;


            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }

            if ((number % 2) == 0)
            {
                bonus = bonus + 1;
            }

            if ((number % 10) == 5)
            {
                bonus = bonus + 2;
            }


            Console.WriteLine(bonus);
            Console.WriteLine(bonus + number);
        }
        static void TimePlusMinutes()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newHour = 0;
            int newMinutes = 0;

            if (minutes < 45)
            {
                newMinutes = minutes + 15;
                newHour = hour;
                Console.WriteLine(newHour + ":" + newMinutes);
            }
            else if (minutes >= 45 && minutes <= 59)
            {
                newMinutes = minutes + 15 - 60;
                newHour = hour + 1;
                if (newHour > 23)
                {
                    newHour = 0;
                }
                if (newMinutes < 10)
                {
                    Console.WriteLine(newHour + ":0" + newMinutes);
                }
                else
                {
                    Console.WriteLine(newHour + ":" + newMinutes);
                }

            }
        }
        static void ToyShop()
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());


            int allToys = puzzles + dolls + bears + minions + trucks;
            double price = (puzzles * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);


            double total = 0;
            double rent = 0;

            if (allToys >= 50)
            {
                total = price - (price * 0.25);
            }
            else
            {
                total = price;
            }


            rent = total * 0.1;
            double profit = total - rent;

            if (profit >= vacationPrice)
            {
                Console.WriteLine($"Yes! {(profit - vacationPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vacationPrice - profit):F2} lv needed.");
            }
        }
        static void GodzillaVSKong()
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double clothesPrice = actors * clothes;

            if (actors > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.1);
            }

            double total = decorPrice + clothesPrice;

            if (total <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - total):F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(total - budget):F2} leva more.");
            }
        }
        static void WorldSwimmingRecord()
        {
            double worldRecordSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double totalTime = (distance * timePerMeter) + ((Math.Floor(distance / 15)) * 12.5);

            if (totalTime > worldRecordSeconds)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - worldRecordSeconds):F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(totalTime):F2} seconds.");
            }
        }
        static void Shopping()
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double priceVideo = videoCards * 250;
            double priceProcessor = processors * priceVideo * 0.35;
            double priceRam = ram * priceVideo * 0.1;

            double total = priceVideo + priceProcessor + priceRam;

            if (videoCards > processors)
            {
                total = total - (total * 0.15);
            }

            if (total <= budget)
            {
                Console.WriteLine($"You have {(budget - total):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(total - budget):F2} leva more!");
            }
        }
        static void LunchBreak()
        {
            string movieName = Console.ReadLine();
            int movieDuration = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double eatingTime = lunchBreak / 8;
            double relaxTime = lunchBreak / 4;
            double timeLeft = lunchBreak - eatingTime - relaxTime;

            if (timeLeft >= movieDuration)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {(Math.Ceiling(timeLeft) - movieDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {(movieDuration + 1 - Math.Ceiling(timeLeft))} more minutes.");
            }
        }
        static void DayOfWeek()
        {
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void WeekendOrWorkday()
        {
            string dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void AnimalType()
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
        static void PersonalTitles()
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());


            if (sex == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (sex == 'm')
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
        static void SmallShop()
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());


            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(quantity * 0.45);
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(quantity * 0.7);
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(quantity * 1.1);
                }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(quantity * 1.6);
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.5);
                }
                else if (town == "Varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
        static void NumberInRange()
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 100 && num >= -100 && num != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void WorkingHours()
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour <= 18 && hour >= 10 && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
        static void CinemaTicket()
        {
            string dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "Monday":
                    Console.WriteLine(12);
                    break;
                case "Tuesday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                    Console.WriteLine(14);
                    break;
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Saturday":
                    Console.WriteLine(16);
                    break;
                case "Sunday":
                    Console.WriteLine(16);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void FruitOrVegetable()
        {
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "pepper":
                case "cucumber":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
        static void InvalidNumber()
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 200 && num >= 100 || num == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        static void FriutShop()
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    price = quantity * 2.5;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "apple")
                {
                    price = quantity * 1.2;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "orange")
                {
                    price = quantity * 0.85;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "grapefruit")
                {
                    price = quantity * 1.45;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "kiwi")
                {
                    price = quantity * 2.7;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "pineapple")
                {
                    price = quantity * 5.5;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "grapes")
                {
                    price = quantity * 3.85;
                    Console.WriteLine($"{(price):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    price = quantity * 2.7;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "apple")
                {
                    price = quantity * 1.25;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "orange")
                {
                    price = quantity * 0.9;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "grapefruit")
                {
                    price = quantity * 1.6;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "kiwi")
                {
                    price = quantity * 3;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "pineapple")
                {
                    price = quantity * 5.6;
                    Console.WriteLine($"{(price):F2}");
                }
                else if (product == "grapes")
                {
                    price = quantity * 4.2;
                    Console.WriteLine($"{(price):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        static void TradeCommissions()
        {
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double commition = 0;


            if (quantity >= 0 && quantity <= 500)
            {
                if (town == "Sofia")
                {
                    commition = quantity * 0.05;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Plovdiv")
                {
                    commition = quantity * 0.055;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Varna")
                {
                    commition = quantity * 0.045;
                    Console.WriteLine($"{(commition):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }


            }
            else if (quantity > 500 && quantity <= 1000)
            {
                if (town == "Sofia")
                {
                    commition = quantity * 0.07;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Plovdiv")
                {
                    commition = quantity * 0.08;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Varna")
                {
                    commition = quantity * 0.075;
                    Console.WriteLine($"{(commition):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }


            }
            else if (quantity > 1000 && quantity <= 10000)
            {
                if (town == "Sofia")
                {
                    commition = quantity * 0.08;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Plovdiv")
                {
                    commition = quantity * 0.12;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Varna")
                {
                    commition = quantity * 0.1;
                    Console.WriteLine($"{(commition):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }


            }
            else if (quantity > 10000)
            {
                if (town == "Sofia")
                {
                    commition = quantity * 0.12;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Plovdiv")
                {
                    commition = quantity * 0.145;
                    Console.WriteLine($"{(commition):F2}");
                }
                else if (town == "Varna")
                {
                    commition = quantity * 0.13;
                    Console.WriteLine($"{(commition):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
        static void Nums1to100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void NumsNto1()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Nums1toNStep()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        static void PowerOfTwo()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
        static void CharacterSequence()
        {
            string inputText = Console.ReadLine();

            for (int i = 0; i <= (inputText.Length - 1); i++)
            {
                Console.WriteLine(inputText[i]);
            }
        }
        static void VowelsSum()
        {
            string inputText = Console.ReadLine();
            char letter;
            int sum = 0;

            for (int i = 0; i <= (inputText.Length - 1); i++)
            {
                letter = inputText[i];

                if (letter == 'a')
                {
                    sum = sum + 1;
                }
                else if (letter == 'e')
                {
                    sum = sum + 2;
                }
                else if (letter == 'i')
                {
                    sum = sum + 3;
                }
                else if (letter == 'o')
                {
                    sum = sum + 4;
                }
                else if (letter == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
        static void SumNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
        static void NumberSequence()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);
        }
        static void LeftAbdRightSum()
        {

            int n = int.Parse(Console.ReadLine());
            int leftNum = 0;
            int rightNum = 0;
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                leftNum = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + leftNum;
            }
            for (int i = (n + 1); i <= (2 * n); i++)
            {
                rightNum = int.Parse(Console.ReadLine());
                sumRight = sumRight + rightNum;
            }


            if (sumLeft == sumRight)
            {
                Console.WriteLine("Yes, sum = " + sumLeft);
            }
            else
            {
                if (sumLeft > sumRight)
                {
                    Console.WriteLine("No, diff = " + (sumLeft - sumRight));
                }
                else
                {
                    Console.WriteLine("No, diff = " + (sumRight - sumLeft));
                }
            }
        }
        static void OddEvenSum()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }


            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumOdd);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + (Math.Abs((sumEven - sumOdd))));
            }
        }
        static void NumsEndingIn7()
        {
            for (int i = 1; i <= 1000; i++)
            {

                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void HalfSumElement()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumNums = sum - max;
            if (max == sumNums)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumNums);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
        static void Histogram()
        {
            int n = int.Parse(Console.ReadLine());
            int p1nums = 0;
            int p2nums = 0;
            int p3nums = 0;
            int p4nums = 0;
            int p5nums = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1nums++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2nums++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3nums++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4nums++;
                }
                else if (num >= 800)
                {
                    p5nums++;
                }
            }

            double p1 = ((double)p1nums / n) * 100;
            double p2 = ((double)p2nums / n) * 100;
            double p3 = ((double)p3nums / n) * 100;
            double p4 = ((double)p4nums / n) * 100;
            double p5 = ((double)p5nums / n) * 100;


            Console.WriteLine($"{(p1):F2}%");
            Console.WriteLine($"{(p2):F2}%");
            Console.WriteLine($"{(p3):F2}%");
            Console.WriteLine($"{(p4):F2}%");
            Console.WriteLine($"{(p5):F2}%");

        }
        static void CleverLily()
        {
            int age = int.Parse(Console.ReadLine());
            double washMashine = double.Parse(Console.ReadLine());
            int toySinglePrice = int.Parse(Console.ReadLine());

            double piggyBank = 0;
            double cashGift = 10;

            int toysNum = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    piggyBank += cashGift;
                    piggyBank--;
                    cashGift += 10;
                }
                else
                {
                    toysNum++;
                }
            }

            int totalFromToys = toysNum * toySinglePrice;
            double totalForMashine = totalFromToys + piggyBank;

            if (totalForMashine >= washMashine)
            {
                double change = totalForMashine - washMashine;
                Console.WriteLine($"Yes! {change:f2}");
            }
            else
            {
                double insufficient = washMashine - totalForMashine;
                Console.WriteLine($"No! {insufficient:f2}");
            }
        }
        static void Salary()
        {
            int openTabsNum = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= openTabsNum; i++)
            {
                string websiteName = Console.ReadLine();

                switch (websiteName)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }

                if (salary <= 0)
                {
                    break;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary}");
            }
        }
        static void Oscars()
        {
            string actorName = Console.ReadLine();
            double lastYearsPoints = double.Parse(Console.ReadLine());
            int juryMembersNum = int.Parse(Console.ReadLine());

            double finalPoints = lastYearsPoints;

            for (int i = 1; i <= juryMembersNum; i++)
            {
                string juryMemName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                double totalMemberPoints = juryMemName.Length * points / 2;
                finalPoints += totalMemberPoints;

                if (finalPoints > 1250.5)
                {
                    break;
                }
            }

            if (finalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {finalPoints:f1}!");
            }
            else
            {
                double insufficient = 1250.5 - finalPoints;
                Console.WriteLine($"Sorry, {actorName} you need {insufficient:f1} more!");
            }
        }
        static void TrekkingMania()
        {
            int groupsNum = int.Parse(Console.ReadLine());

            int goingToMusala = 0;
            int goingToMontblanc = 0;
            int goingToKilimandjaro = 0;
            int goingToK2 = 0;
            int goingToEverest = 0;

            int allPeople = 0;

            for (int i = 1; i <= groupsNum; i++)
            {
                int peopleInGroupNum = int.Parse(Console.ReadLine());
                allPeople += peopleInGroupNum;

                if (peopleInGroupNum >= 1 && peopleInGroupNum <= 5)
                {
                    goingToMusala += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 6 && peopleInGroupNum <= 12)
                {
                    goingToMontblanc += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 13 && peopleInGroupNum <= 25)
                {
                    goingToKilimandjaro += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 26 && peopleInGroupNum <= 40)
                {
                    goingToK2 += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 41 && peopleInGroupNum <= 1000)
                {
                    goingToEverest += peopleInGroupNum;
                }

            }


            double percentageMusala = (goingToMusala / (allPeople * 1.0)) * 100.00;
            Console.WriteLine($"{percentageMusala:f2}%");

            double percentageMontblank = (goingToMontblanc / (allPeople * 1.0)) * 100.00;
            Console.WriteLine($"{percentageMontblank:f2}%");

            double percentageKilimandjaro = (goingToKilimandjaro / (allPeople * 1.0)) * 100.00;
            Console.WriteLine($"{percentageKilimandjaro:f2}%");

            double percentageK = (goingToK2 / (allPeople * 1.0)) * 100.00;
            Console.WriteLine($"{percentageK:f2}%");

            double percentageEverest = (goingToEverest / (allPeople * 1.0)) * 100.00;
            Console.WriteLine($"{percentageEverest:f2}%");

        }
        static void TennisRankList()
        {
            int tournamentsNum = int.Parse(Console.ReadLine());
            int initianlPoints = int.Parse(Console.ReadLine());

            int thisYearsPoints = 0;
            int winsCounter = 0;

            for (int i = 1; i <= tournamentsNum; i++)
            {
                string position = Console.ReadLine();
                switch (position)
                {
                    case "W":
                        thisYearsPoints += 2000;
                        winsCounter++;
                        break;
                    case "F":
                        thisYearsPoints += 1200;
                        break;
                    case "SF":
                        thisYearsPoints += 720;
                        break;
                }
            }

            int finalPoints = initianlPoints + thisYearsPoints;
            Console.WriteLine($"Final points: {finalPoints}");

            double average = Math.Floor(thisYearsPoints / (tournamentsNum * 1.0));
            Console.WriteLine($"Average points: {average}");

            double percentage = (winsCounter / (tournamentsNum * 1.0)) * 100.00;
            Console.WriteLine($"{percentage:f2}%");
        }
        static void ReadText()
        {
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(command);
            }
        }
        static void password()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password)
            {

            }
            Console.WriteLine($"Welcome {username}!");
        }
        static void SumNubers()
        {
            int desiredSum = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (sum >= desiredSum)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
        static void Sequence2kplus1()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = (num * 2) + 1;
            }
        }
        static void AccountBalance()
        {
            double sum = 0;
            string command;

            while ((command = Console.ReadLine()) != "NoMoreMoney")
            {
                double moneyToIncrease = double.Parse(command);
                if (moneyToIncrease < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += moneyToIncrease;
                Console.WriteLine($"Increase: {moneyToIncrease:f2}");

            }
            Console.WriteLine($"Total: {sum:f2}");
        }
        static void Graduation()
        {
            string name = Console.ReadLine();

            double totalGrades = 0;
            int currClass = 1;
            int repeatCnt = 0;
            while (currClass <= 12)
            {
                double currClassGrade = double.Parse(Console.ReadLine());
                totalGrades += currClassGrade;

                //If the grade is under 4 we repeat the same class
                if (currClassGrade < 4)
                {
                    repeatCnt++;
                    if (repeatCnt > 1)
                    {
                        //If we repeat the same class more than once we are expelled
                        break;
                    }

                    continue;
                }

                //If the grade is higher than 4 I go into the next class
                currClass++;
            }

            //If we repeat a class more than once we are expelled
            if (repeatCnt > 1)
            {
                Console.WriteLine($"{name} has been excluded at {currClass} grade");
            }
            else
            {
                double averageGrade = totalGrades / (currClass - 1 + repeatCnt);
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
        static void NumberPyramid()
        {
            // practice_6 Напишете програма, която чете цяло число n, въведено от потребителя, и отпечатва пирамида от числа като в примерите:
            // input: 7
            //output: 1
            //        2 3
            //        4 5 6
            //        7

            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;

                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
        static void EqualSUmEvenOddPosition()
        {
            //Напишете програма, която чете от конзолата две шестцифрени цели числа в диапазона от 100000 до 300000.
            //Винаги първото въведено число ще бъде по малко от второто. На конзолата да се отпечатат на 1 ред разделени
            //с интервал всички числа, които се намират между двете, прочетени от конзолата числа и отговарят на следното условие:
            //сумата от цифрите на четни и нечетни позиции да са равни. Ако няма числа, отговарящи на условието на конзолата не се извежда резултат.
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                string current = i.ToString();
                int oddsum = 0;
                int evensum = 0;


                for (int j = 0; j < current.Length; j++)
                {
                    int currDigit = int.Parse(current[j].ToString());
                    if (j % 2 == 0)
                    {
                        evensum += currDigit;
                    }
                    else
                    {
                        oddsum += currDigit;
                    }
                }

                if (oddsum == evensum)
                {
                    Console.Write(i + " ");
                }

            }
        }
        static void SumPrimeNonPrime()
        {
            string input;
            int primeSum = 0;
            int notPrimeSum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int inputNum = int.Parse(input);
                if (inputNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool flag = true;

                for (int divider = 2; divider < inputNum; divider++)
                {
                    // example: num = 6:
                    // num / 2 != 0 ->  nonprime flag = true;  nonprimeSum += num
                    // num / 3 != 0 ->  nonprime flag = true;  nonprimeSum += num
                    // num / 4 != 0 ->  nonprime flag = true;  nonprimeSum += num
                    // num / 5 != 0 ->  nonprime flag = true;  nonprimeSum += num

                    if (inputNum % divider == 0)
                    {
                        notPrimeSum += inputNum;
                        flag = false;
                        break;
                    }

                }

                if (flag)
                {
                    primeSum += inputNum;
                }

            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
        }



        static void Main(string[] args)
        {
            //HelloSoftUni();
            //Nums1to10();
            //RectangleArea();
            //InchToCm();
            //GreetingByName();
            // ...
        }
    }
}

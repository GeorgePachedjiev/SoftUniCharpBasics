using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            double prize = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday"
                || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        prize = 2.50;
                        break;
                    case "apple":
                        prize = 1.20;
                        break;
                    case "orange":
                        prize = 0.85;
                        break;
                    case "grapefruit":
                        prize = 1.45;
                        break;
                    case "kiwi":
                        prize = 2.70;
                        break;
                    case "pineapple":
                        prize = 5.50;
                        break;
                    case "grapes":
                        prize = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }

            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        prize = 2.70;
                        break;
                    case "apple":
                        prize = 1.25;
                        break;
                    case "orange":
                        prize = 0.90;
                        break;
                    case "grapefruit":
                        prize = 1.60;
                        break;
                    case "kiwi":
                        prize = 3.00;
                        break;
                    case "pineapple":
                        prize = 5.60;
                        break;
                    case "grapes":
                        prize = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            double total = prize * kolichestvo;
            if (total != 0)
            {
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}

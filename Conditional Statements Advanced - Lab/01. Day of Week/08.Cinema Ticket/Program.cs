using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма която чете ден от седмицата(текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:
            //Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
            //12       12        14      14          12     16          16
            //Примерен вход и изход
            //вход изход       вход изход       вход изход
            //Monday  12       Friday  12       Sunday  16

            string dayOfWeek = Console.ReadLine();
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;

                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;

                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}

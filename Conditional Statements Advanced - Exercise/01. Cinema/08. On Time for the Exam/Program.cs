using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examHourstransf = examHours * 60;
            int examMinutesTransf = examHourstransf + examMinutes;

            int arrivalHourstransf = arrivalHours * 60;
            int arrivalMinutesTransf = arrivalHourstransf + arrivalMinutes;

            int difference = Math.Abs(arrivalMinutesTransf - examMinutesTransf);
            int differenceHours = difference / 60;
            int differenceMinutes = difference % 60;

            string reslut = string.Empty;

            if (arrivalMinutesTransf > examMinutesTransf)
            {
                Console.WriteLine("Late");

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start"); ;
                }
                else
                {
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:00} hours after the start"); ;
                }
            }
            else if (arrivalMinutesTransf == examMinutesTransf)
            {
                Console.WriteLine("On time");
            }
            else if (examMinutesTransf > arrivalMinutesTransf)
            {
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:00} hours before the start");
                }

            }
        }
    }
}

using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinutes = int.Parse(Console.ReadLine());

            examMinutes += examHour * 60;
            arrivingMinutes += arrivingHour * 60;

            string onTime = "";
            int timeDifference = 0;
            int minuteDifference = 0;
            int hourDifference = 0;

            if (examMinutes < arrivingMinutes)
            {
                onTime = "Late";
                timeDifference = arrivingMinutes - examMinutes;
                hourDifference = timeDifference / 60;
                minuteDifference = timeDifference % 60;
                
                Console.WriteLine(onTime);

                if (timeDifference >= 60)
                { 
                    Console.WriteLine($"{hourDifference}:{minuteDifference:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minuteDifference} minutes after the start");
                }
            }
            else
            {
                timeDifference = examMinutes - arrivingMinutes;
                hourDifference = timeDifference / 60;
                minuteDifference = timeDifference % 60;
                
                if (timeDifference <= 30)
                {
                    onTime = "On time";
                    Console.WriteLine(onTime);

                    if (timeDifference != 0)
                    {
                        Console.WriteLine($"{minuteDifference} minutes before the start");
                    }
                }
                else
                {
                    onTime = "Early";
                    Console.WriteLine(onTime);

                    if (timeDifference < 60)
                    {
                        Console.WriteLine($"{minuteDifference} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourDifference}:{minuteDifference:d2} hours before the start");
                    }
                }
            }
        }
    }
}

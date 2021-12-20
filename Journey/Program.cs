using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double expenses = 0;
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    place = "Camp";
                    expenses = budget * 0.3;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    expenses = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    place = "Camp";
                    expenses = budget * 0.4;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    expenses = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                expenses = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {expenses:f2}");
        }
    }
}

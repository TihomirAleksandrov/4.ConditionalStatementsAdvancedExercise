using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;
            double income = 0;

            if (projectionType == "Premiere")
            {
                price = 12.00;
            }
            else if (projectionType == "Normal")
            {
                price = 7.50;
            }
            else if (projectionType == "Discount")
            {
                price = 5;
            }

            income = price * (rows * columns);

            Console.WriteLine($"{income:f2} leva");
        }
    }
}

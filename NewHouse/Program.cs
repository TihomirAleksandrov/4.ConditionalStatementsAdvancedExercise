using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int amountOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double discount = 0;
            double totalPrice = 0;

            if (flower == "Roses")
            {
                if (amountOfFlowers > 80)
                {
                    discount = 0.1;
                }

                totalPrice = (amountOfFlowers * 5) - ((amountOfFlowers * 5) * discount);
            }
            else if (flower == "Dahlias")
            {
                if (amountOfFlowers > 90)
                {
                    discount = 0.15;
                }

                totalPrice = (amountOfFlowers * 3.8) - ((amountOfFlowers * 3.8) * discount);
            }
            else if (flower == "Tulips")
            {
                if (amountOfFlowers > 80)
                {
                    discount = 0.15;
                }

                totalPrice = (amountOfFlowers * 2.8) - ((amountOfFlowers * 2.8) * discount);
            }
            else if (flower == "Narcissus")
            {
                if (amountOfFlowers < 120)
                {
                    discount = 0.15;
                }

                totalPrice = (amountOfFlowers * 3) + ((amountOfFlowers * 3) * discount);
            }
            else if (flower == "Gladiolus")
            {
                if (amountOfFlowers < 80)
                {
                    discount = 0.2;
                }

                totalPrice = (amountOfFlowers * 2.5) + ((amountOfFlowers * 2.5) * discount);
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {amountOfFlowers} {flower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}

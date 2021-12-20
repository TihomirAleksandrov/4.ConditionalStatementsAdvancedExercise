using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());

            double discount = 0;
            double boatRent = 0;
            double secondaryDiscount = 0;
            double discountedPrice = 0;
            double totalPrice = 0;

            if (season == "Spring")
            {
                boatRent = 3000;

                if (numberOfFishermen <= 6)
                {
                    discount = 0.1;
                    discountedPrice = boatRent - (boatRent * discount);
                }
                else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
                {
                    discount = 0.15;
                    discountedPrice = boatRent - (boatRent * discount);
                }
                else
                {
                    discount = 0.25;
                    discountedPrice = boatRent - (boatRent * discount);
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200;

                if (numberOfFishermen <= 6)
                {
                    discount = 0.1;
                    discountedPrice = boatRent - (boatRent * discount);
                }
                else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
                {
                    discount = 0.15;
                    discountedPrice = boatRent - (boatRent * discount);
                }
                else
                {
                    discount = 0.25;
                    discountedPrice = boatRent - (boatRent * discount);
                }
            }
            else if (season == "Winter")
            {
                boatRent = 2600;

                if (numberOfFishermen <= 6)
                {
                    discount = 0.1;
                    discountedPrice = boatRent - (boatRent * discount);
                }
                else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
                {
                    discount = 0.15;
                    discountedPrice = boatRent - (boatRent * discount);
                }
                else
                {
                    discount = 0.25;
                    discountedPrice = boatRent - (boatRent * discount);
                }
            }

            if (season != "Autumn" && numberOfFishermen % 2 == 0)
            {
                secondaryDiscount = 0.05;
            }

            totalPrice = discountedPrice - (discountedPrice * secondaryDiscount);

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}

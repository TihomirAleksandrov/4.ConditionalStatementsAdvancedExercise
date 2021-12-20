using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfOvernights = int.Parse(Console.ReadLine());

            double discountStudio = 0;
            double discountApartment = 0;

            double studioPrice = 0;
            double apartmentrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentrice = 65;

                if (numberOfOvernights > 7 && numberOfOvernights <= 14)
                {
                    discountStudio = 0.05;
                }
                else if (numberOfOvernights > 14)
                {
                    discountStudio = 0.3;
                    discountApartment = 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentrice = 68.70;

                if (numberOfOvernights > 14)
                {
                    discountStudio = 0.2;
                    discountApartment = 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentrice = 77;

                if (numberOfOvernights > 14)
                {
                    discountApartment = 0.1;
                }
            }

            double costApartment = numberOfOvernights * apartmentrice;
            double costStudio = numberOfOvernights * studioPrice;

            double totalCostApartment = costApartment - (costApartment * discountApartment);
            double totalCostStudio = costStudio - (costStudio * discountStudio);

            Console.WriteLine($"Apartment: {totalCostApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalCostStudio:f2} lv.");
        }
    }
}

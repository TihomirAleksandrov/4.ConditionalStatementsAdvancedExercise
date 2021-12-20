using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double singleRoomPrice = 18.00;
            double apartmentPrice = 25.00;
            double presidentApartmentPrice = 35.00;

            double totalPrice = 0;
            days -= 1;

            if (days < 10)
            {
                if (roomType == "room for one person")
                {
                    totalPrice = days * singleRoomPrice;
                }
                else if (roomType == "apartment")
                {
                    totalPrice = days * apartmentPrice;
                    totalPrice -= (totalPrice * 0.3);
                }
                else if (roomType == "president apartment")
                {
                    totalPrice = days * presidentApartmentPrice;
                    totalPrice -= (totalPrice * 0.1);
                }
            }
            else if (days >= 10 && days <= 15)
            {
                if (roomType == "room for one person")
                {
                    totalPrice = days * singleRoomPrice;
                }
                else if (roomType == "apartment")
                {
                    totalPrice = days * apartmentPrice;
                    totalPrice -= (totalPrice * 0.35);
                }
                else if (roomType == "president apartment")
                {
                    totalPrice = days * presidentApartmentPrice;
                    totalPrice -= (totalPrice * 0.15);
                }
            }
            else
            {
                if (roomType == "room for one person")
                {
                    totalPrice = days * singleRoomPrice;
                }
                else if (roomType == "apartment")
                {
                    totalPrice = days * apartmentPrice;
                    totalPrice -= (totalPrice * 0.5);
                }
                else if (roomType == "president apartment")
                {
                    totalPrice = days * presidentApartmentPrice;
                    totalPrice -= (totalPrice * 0.2);
                }
            }

            if (rating == "positive")
            {
                totalPrice += (totalPrice * 0.25);
            }
            else if (rating == "negative")
            {
                totalPrice -= (totalPrice * 0.1);
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}

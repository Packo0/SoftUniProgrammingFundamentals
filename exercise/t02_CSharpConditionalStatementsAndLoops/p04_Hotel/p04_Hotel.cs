using System;

namespace p04_Hotel
{
    class p04_Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    break;
            }
                        
            //discounts
            if (nights > 7 && (month == "May" || month == "October"))
            {
                studioPrice *= 0.95;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doublePrice *= 0.90;
            }
            else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suitePrice *= 0.85;
            }

            double studioRoom = nights * studioPrice;
            double doubleRoom = nights * doublePrice;
            double suiteRoom = nights * suitePrice;

            if (nights > 7 && (month == "September" || month == "October"))
            {
                studioRoom -= studioPrice;
            }

            Console.WriteLine($"Studio: {studioRoom:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suiteRoom:F2} lv.");
        }
    }
}

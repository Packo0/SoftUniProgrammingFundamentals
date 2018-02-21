using System;

namespace p01_DayOfWeek
{
    class p01_DayOfWeek
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (1 <= day && day <= 7)
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

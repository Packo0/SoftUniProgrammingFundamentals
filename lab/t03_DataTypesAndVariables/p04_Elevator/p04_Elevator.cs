using System;

namespace p04_Elevator
{
    class p04_Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(numberOfPeople / (double)capacity);

            Console.WriteLine(courses);
        }
    }
}

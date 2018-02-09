using System;

namespace p05_FibonacciNumbers
{
    class p05_FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fibonacci(n);
            Console.WriteLine(result);
        }

        static int Fibonacci(int number)
        {
            int sum = 1;
            int previous = 1;
            int current = 1;

            for (int i = 0; i < number - 1; i++)
            {
                sum = previous + current;
                current = previous;
                previous = sum;
            }

            return sum;
        }
    }
}

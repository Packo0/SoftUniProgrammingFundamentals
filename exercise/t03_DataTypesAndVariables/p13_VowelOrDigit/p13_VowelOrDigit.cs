using System;

namespace p13_VowelOrDigit
{
    class p13_VowelOrDigit
    {
        static void Main(string[] args)
        {
            char ch= char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;

                case 'a':
                case 'o':
                case 'e':
                case 'i':
                case 'u':
                case 'y':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}

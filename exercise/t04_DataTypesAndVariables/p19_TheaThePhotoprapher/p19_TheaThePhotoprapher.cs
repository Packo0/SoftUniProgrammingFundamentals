using System;

namespace p19_TheaThePhotoprapher
{
    class p19_TheaThePhotoprapher
    {
        static void Main(string[] args)
        {
            ulong pictures = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong filterFactor = ulong.Parse(Console.ReadLine());
            ulong uploadedTime = ulong.Parse(Console.ReadLine());

            ulong filteredPictures = (ulong)Math.Ceiling(pictures * filterFactor / 100.0);

            ulong totalPictureTime = pictures * filterTime;

            double uploadTime = filteredPictures * uploadedTime;

            double totalTimeSeconds = totalPictureTime + uploadTime;

            TimeSpan timeResult = TimeSpan.FromSeconds(totalTimeSeconds);

            string formatResult = @"d\:hh\:mm\:ss";

            Console.WriteLine(timeResult.ToString(formatResult));
        }
    }
}

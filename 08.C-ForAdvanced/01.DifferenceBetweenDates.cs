using System;

    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan result = secondDate - firstDate;
            Console.WriteLine(result.Days);
        }
    }


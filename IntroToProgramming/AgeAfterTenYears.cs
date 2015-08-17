using System;

    class AgeAfter10Y
    {
        static void Main()
        {
            DateTime birthDay = DateTime.Parse(Console.ReadLine());                                     // This is the input where you enter your birthday
            Console.WriteLine("Now: " + (DateTime.Now.Year - birthDay.Year) + ".");                     // Here the program calculates and prints on the console how old are you now.
            Console.WriteLine("After 10 years: "+ (DateTime.Now.Year - birthDay.Year + 10) + ".");      // In this part of the code the program calculates and prints on the console how old you would be after 10 years.
        }
    }


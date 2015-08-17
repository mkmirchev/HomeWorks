using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight in kg. : ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the moon will be " + weight * 0.17 + ".");
        } 
    }


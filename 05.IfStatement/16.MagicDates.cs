using System;
using System.Globalization;
using System.Threading;

    class MagicDates
    {
        static void Main()
        {   
            // Initialize the input parameters
            int startUp = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());

            // Declare some needed variables
            DateTime startDate = new DateTime(startUp, 1, 1);
            DateTime endDate = new DateTime(end, 12, 31);
            int count = 0;

            // Making the logic, that calculates the magicWeight
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                int firstDigit = i.Day / 10;
                int secondDigit = i.Day % 10;
                int thirdDigit = i.Month / 10;
                int fourthDigit = i.Month % 10;
                int fifthDigit = (i.Year / 1000) % 10;
                int sixthDigit = (i.Year / 100) % 10;
                int seventhDigit = (i.Year / 10) % 10;
                int eighthDigit = (i.Year / 1) % 10;
                int[] digits = { firstDigit, secondDigit, thirdDigit, fourthDigit, fifthDigit, sixthDigit, seventhDigit, eighthDigit };
                int dateWeight = 0;
                for (int position = 0; position < digits.Length; position++)
                {
                    for (int index = position + 1; index < digits.Length; index++)
                    {
                        dateWeight = dateWeight + (digits[position] * digits[index]);
                    }
                }
                if (dateWeight == magicWeight)
                {
                    Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", i.Day, i.Month, i.Year);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }


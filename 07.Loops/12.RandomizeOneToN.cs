using System;


    class RandomizeOneToN
    {
        static void Main()
        {
        Console.Title = "Randomize the Numbers 1…N"; //Changing the title of the console.

        Console.Write("Please, enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());

        int[] randomArray = new int[n];
        for (int i = 0; i < n; )
        {
            randomArray[i] = ++i;
        }

        Random getRandom = new Random();
        int temp = 0;
        for (int firstRandom, secondRandom, i = 0; i < n; i++)
        {
            firstRandom = getRandom.Next(0, n);
            secondRandom = getRandom.Next(0, n);
            temp = randomArray[firstRandom];          
            randomArray[firstRandom] = randomArray[secondRandom];
            randomArray[secondRandom] = temp;
        }

        Console.WriteLine(string.Join(" ", randomArray));

        Console.ReadKey(); // Keeping the console opened.
            
            
        }
    }


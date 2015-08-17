using System;

    class PlayWIthIntDoubStr
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
            int choise = int.Parse(Console.ReadLine());           
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Please enter an int:");
                    int inputint = int.Parse(Console.ReadLine());
                    Console.WriteLine(inputint+1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double:");
                    double inputdbl = double.Parse(Console.ReadLine());
                    Console.WriteLine(inputdbl+1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string inputstr = Console.ReadLine();
                    Console.WriteLine(inputstr+"*");
                    break;
                default:                   
                    break;
            }           
        }
    }


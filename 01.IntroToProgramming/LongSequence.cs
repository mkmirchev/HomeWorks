using System;

    class LongSequence
    {
        static void Main()
        {            
            int signChanger = -1;                           // This value change the sign of the numbers for every spin of the loop (for)
            int currentNumber = 2;                          // This is the first printed value.
            for (int i = 3; i < 1003; i++)                  // (For) loop which makes 1000 spins to print all the values needed
            {
                Console.Write("{0} ,", currentNumber);      // Here i print the starting value and than all other values of the list
                currentNumber = i * signChanger;            
                signChanger = signChanger * (-1);
            }            
        }
    }


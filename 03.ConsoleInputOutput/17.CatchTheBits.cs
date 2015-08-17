using System;

class CatchTheBits
{
    static void Main()
    {
        // Initialize the Input data
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;
        int outputBits = 0;
        int outputBitsCount = 0;
        // Do a loop to obtain the inputed numbers
        for (int i = 0; i < n; i++)
        { 
            int num = int.Parse(Console.ReadLine());
            // Walk around every bit of the number and checking if it is 1 1+step .... from left to right
            for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                if ((index % step == 1) || (step == 1 && index > 0))
                {
                    int bitValue = (num >> bitIndex) & 1;
                    outputBits = outputBits << 1;
                    outputBits = outputBits | bitValue;
                    outputBitsCount++;
                    if (outputBitsCount == 8)
                    {
                        // We have (1 byte)
                        Console.WriteLine(outputBits);
                        outputBits = 0;
                        outputBitsCount = 0;
                    }
                }
                index++;
            }
        }

        if (outputBitsCount > 0)
        {
            // Add trailing zeroes
            outputBits = outputBits << (8 - outputBitsCount);
            Console.WriteLine(outputBits);
        }
    }
}


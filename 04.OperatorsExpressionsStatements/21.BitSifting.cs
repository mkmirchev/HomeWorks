using System;

class BitSifting
{
    static void Main()
    {
        UInt64 bitsToSieve = UInt64.Parse(Console.ReadLine());
        byte numOfSieves = byte.Parse(Console.ReadLine());
        UInt64 trySieving = 0;
        UInt64 result = 0;
        UInt64 bitResult = 0;
        int count = 0;
        if (numOfSieves > 0)
        {
            for (int i = 0; i < numOfSieves; i++)
            {
                UInt64 sieve = UInt64.Parse(Console.ReadLine());
                UInt64 mask = 0;
                // 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000
                for (int index = 63; index >= 0; index--)
                {
                    trySieving = (bitsToSieve << 63 - index >> 63);
                    mask = (sieve << 63 - index >> 63);

                    //Console.WriteLine("|{0,2}|{1,1}|{2,1}|", index, trySieving, mask); // -> prints the pits at positions
                    if (trySieving == 1 && mask == 0)
                    {
                        bitResult = bitResult | trySieving << index;

                    }
                }
                bitsToSieve = bitResult;
                bitResult = 0;
            }
            for (int roll = 63; roll >= 0; roll--)
            {
                result = (bitsToSieve << 63 - roll >> 63);
                if (result == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        else if (numOfSieves == 0)
        {
            for (int roll = 63; roll >= 0; roll--)
            {
                result = (bitsToSieve << 63 - roll >> 63);
                if (result == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        
    }
}


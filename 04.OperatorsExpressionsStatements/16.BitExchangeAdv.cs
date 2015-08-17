using System;

    class BitExchangeAdv
    {
        static void Main()
        {
            Int64 n = Int64.Parse(Console.ReadLine());
            Int32 p = Int32.Parse(Console.ReadLine());
            Int32 q = Int32.Parse(Console.ReadLine());
            Int32 k = Int32.Parse(Console.ReadLine());
            // 00000000 00000000 00000000 00000000 
            if (q+k>=32||p+k>=32||p>=33||p<=-1||q>=33||q<=-1)
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Abs(p - q) < k)
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                Int32 posOne = p < q ? p : q;
                Int32 posTwo = p < q ? q : p;
                Int64 fisrtBitRow = (n << (32 - k - posOne)) >> (32 - k) & ~((~1) << (k - 1));
                Int64 secondBitRow = (n << (32 - k - posTwo)) >> (32 - k) & ~((~1) << (k - 1));
                Int32 mask = (~1) << k-1;                           // 11111111 11111111 11111111 11111000 
                mask = (~mask) << (Math.Abs(posTwo-k-posOne));      // 00000000 00011100 00000000 00000000             
                mask = (~mask) << k;                                // 11111111 00011111 11111111 11111000
                mask = (~mask) << posOne;                           // 00000111 00000000 00000000 00111000
                
                // Console.WriteLine(mask);  // Prints the mask
                n = n & (~mask);
                n = n | fisrtBitRow << posTwo;
                n = n | secondBitRow << posOne;                               
                Console.WriteLine(n);
            }
        }
    }


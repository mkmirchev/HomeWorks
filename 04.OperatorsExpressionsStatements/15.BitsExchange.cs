using System;

    class BitsExchange
    {

        static void Main()
        {
            Int64 n = Int64.Parse(Console.ReadLine());
            
            Int64 firstBits = n << 26 >> 29 & ~((~1) << 2);
            Int64 secondBits = n << 5 >> 29 & ~((~1) << 2);            
            Int32 mask = 1 << 3;                                        // 00000000 00000000 00000000 00001000
            mask = (~mask) << 18;                                       // 11111111 11011100 00000000 00000000  
            mask = (~mask) << 3;                                        // 00000001 00011111 11111111 11111000 
            mask = (~mask) << 3;                                        // 11110111 00000000 00000000 00111000            
            mask = mask << 4 >>4;                                       // 00000111 00000000 00000000 00111000                                                 
            // Console.WriteLine(mask);   //Checking mask -------------->> 00000111 00000000 00000000 00111000                                                             
            n = n & (~mask);
            //Console.WriteLine(n);       //Checked that bits 3,4,5,24,25,26 are cleared
            n = n | firstBits << 24;
            n = n | secondBits << 3;
            Console.WriteLine(n);
                      
           
        }
    }



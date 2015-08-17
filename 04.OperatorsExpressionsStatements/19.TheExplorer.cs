using System;


    class TheExplorer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2 + 1;
            int border = 0;           
            char diamond = '*';
            char space = '-';
            // first row
            Console.Write(new string(space, mid - 1));
            Console.Write(new string(diamond, 1));
            Console.Write(new string(space, mid - 1));
            Console.WriteLine();
            // increase elements
            for (int i = 0; i < mid-1; i++)
            {
                
                    Console.Write(new string(space, mid - 2 - border));
                    Console.Write(new string(diamond, 1));
                    Console.Write(new string(space, 1 + 2 * border));
                    Console.Write(new string(diamond, 1));
                    Console.Write(new string(space, mid - 2 - border));
                    Console.WriteLine();
                    border++;                                                                                            
            }
            border-=2;
            //decrease elements
            for (int i = 0; i < mid-2; i++)
            {
                    Console.Write(new string(space, mid-2-border));
                    Console.Write(new string(diamond,1));
                    Console.Write(new string(space, 1+2*border));
                    Console.Write(new string(diamond, 1));
                    Console.Write(new string(space, mid - 2 - border));
                    Console.WriteLine();
                    border--; 
            }
            //Last row
            Console.Write(new string(space, mid - 1));
            Console.Write(new string(diamond, 1));
            Console.Write(new string(space, mid - 1));
            Console.WriteLine();

        }
    }


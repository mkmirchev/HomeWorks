using System;

    class Fibonacci
    {
        static void Main()
        {
            // initialize the input data and some varialbes needed to create fibonacci array
            int n = int.Parse(Console.ReadLine());
            int zero = 0;
            int a = 1;
            int b = 1;
            int c = 0;
            // implement some logic to handle the output
            if (n == 1)
            {
                Console.WriteLine("0");  
            }
            else if (n == 2)
            {
                Console.WriteLine("0 1"); 
            }
            else if (n==3)
            {
                Console.WriteLine("0 1 1"); 
            }
            else
            {
                Console.Write("0 1 1 ");
                for (int i = 1; i <= n-3; i++)
                {   
                    c = a + b;
                    Console.Write("{0} ",c);

                    zero = a;
                    a = b;
                    b = c;
                }
            }
        }
    }


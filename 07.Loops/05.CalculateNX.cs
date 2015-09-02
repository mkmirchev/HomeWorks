using System;

    class CalculateNX
    {
        
        static void Main()
        {
            // Initialize the input data
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double ans = 1;
            for (int i = 0; i < n; i++)
            {
                ans = ans + (double)(Fact(i) / Div(x,i));              
            }

            Console.WriteLine(ans);
        }
        // Method for calculating the dividor
        private static double Div(int x,int i)
        {
            int divide = x;
            int a = x;
            for (int index = 0; index < i; index++)
            {
                a = a * divide;
            }
            return a;
        }
        // Method for calculating the divident
        private static double Fact(int i)
        {
            int factoriel = 1;
            for (int index = 1; index <= i; index++)
            {
                factoriel += factoriel * index;
            }
            return factoriel;
        }      
    }


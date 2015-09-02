using System;


    class CalcNK
    {
        private static double Fact(int i)
        {
            int factoriel = 1;
            for (int index = 1; index < i; index++)
            {
                factoriel += factoriel * index;
            }
            return factoriel;
        }

        static void Main()
        {
        
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double result = Fact(n) / Fact(k);
            Console.WriteLine(result);
        }
    }


using System;

    class NumbersAsWords
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int hundreds = (a / 100)-1 ;
            string[] validHundreds = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int tens = (a % 100)/ 10;
            string[] validTeens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int ones = (a%10) ;
            string[] validOnes = { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] exceptions = { "ten", "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            if (a<10)
            {
                Console.WriteLine(validOnes[ones]);
            }
            else if (a>=10 && a <20)
            {
                Console.WriteLine(exceptions[ones]);
            }
            else if (a>=20 && a<=99)
            {
                if (a%10==0)
                {
                    Console.WriteLine(validTeens[tens-1]);   
                }
                else
                {
                    Console.WriteLine(validTeens[tens - 1] + " " + validOnes[ones]);   
                }
                
            }
            else if (a>=100 && a<1000)
            {
                if (a%100==0)
                {
                    Console.WriteLine(validHundreds[hundreds] + " hundred");
                }
                else if (a%100 >10 && a%100<20)
                {
                    Console.WriteLine(validHundreds[hundreds] + " hundred and " + exceptions[ones]);
                }
                else if ((a / 10) % 10 == 0)
                {
                    Console.WriteLine(validHundreds[hundreds] + " hundred and " + validOnes[ones]);
                }
                else if (a%10 == 0)
                {
                    Console.WriteLine(validHundreds[hundreds] + " hundred and " + validTeens[tens - 1]);
                }
                else
                {
                    Console.WriteLine(validHundreds[hundreds] + " hundred and " + validTeens[tens - 1] + " " + validOnes[ones]);
                }
            }
            //Main();
        }
    }


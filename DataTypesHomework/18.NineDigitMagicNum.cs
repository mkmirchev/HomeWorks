using System;

    class NineDigitMagicNum
    {
        static void Main()
        {
            // Initialize the input data
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            // Finding the magic numbers abc def ghi, where  
            // using digit from 1 to 7;
            // ghi-def = def-abc = diff 
            // abc ≤ def ≤ ghi. 
            int abc=0;
            int def=0;
            int ghi=0;
            bool numbers = false;
            for (int a = 1; a <= 7; a++)
            {
                for (int b = 1; b <= 7; b++)
                {
                    for (int c = 1; c <= 7; c++)
                    {
                        for (int d = 1; d <= 7; d++)
                        {
                            for (int e = 1; e <= 7; e++)
                            {
                                for (int f = 1; f <= 7; f++)
                                {
                                    for (int g = 1; g <= 7; g++)
                                    {
                                        for (int h = 1; h <= +7; h++)
                                        {
                                            for (int i = 1; i <= 7; i++)
                                            {       
                                                    abc = a  * 100+b  * 10+c;
                                                    def = d * 100+e * 10+f;
                                                    ghi = g * 100 + h * 10 + i;
                                                    
                                                if (ghi-def==diff && def-abc == diff) 
                                                {

                                                    if ( a + b + c + d + e + f + g + h + i==sum)
                                                    {
                                                        if (abc<=def&&def<=ghi)
                                                        {
                                                            Console.WriteLine(abc+""+def+""+ghi);
                                                            numbers = true;
                                                        }
                                                       
                                                    }
                                                }
                                                abc = 0;
                                                def = 0;
                                                ghi = 0;
                                               
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (numbers==false)
            {
                Console.WriteLine("No"); 
            }

            //Printing the output data

            
           
        }
    }


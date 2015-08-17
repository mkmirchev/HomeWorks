using System;

    class BitsUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            byte border = 0;
           
            

            for (int i = 0; i < n; i++)
            {   
                byte input = byte.Parse(Console.ReadLine());
                for (int index = 7; index >= 0; index-- )               
                {
                    if ((i == 0 && index == 6)||(i == 0 && index == 6 - step))
                    {

                        input = (byte)(input | (1 << index));
                        if (step<=4)
                        {
                            step += step;
                        }
                        
                    }
                    else if ((i > 0 && (index == (step%7))))
                    {
                        input = (byte)(input | (1 << index-1));
                        border++;
                        if (border > 1 || (border == 0 && step <= 7))
                        {
                            step += step;
                        } 
                    }
                   
                }
                 Console.WriteLine(input);
               
            }
        }
    }


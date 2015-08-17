using System;

    class Sunglases
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char space = ' ';
            char bridge = '|';
            char lens = '/';
            char frames = '*';           
                            
                for (int i = 0; i < n; i++)
              {
                if (i==0||i==n-1)
                {
                    Console.Write(new string(frames, 2 * n));
                    Console.Write(new string(space, n));
                    Console.Write(new string(frames, 2 * n));
                    Console.WriteLine();
                    
                }
                if (i>=0&&i<n-2)
                {
                    
                                            
              Console.Write(new string(frames, 1));
              Console.Write(new string(lens, 2*n-2));
              Console.Write(new string(frames, 1));                 
              if (i == n/2-1)
              {
              Console.Write(new string(bridge, n));
              }
              else
              {
                  Console.Write(new string(space, n));
              }                   
              Console.Write(new string(frames, 1));
              Console.Write(new string(lens, 2 * n - 2));
              Console.Write(new string(frames, 1));
              Console.WriteLine();
              
              }
                
                }
              
        }
    }


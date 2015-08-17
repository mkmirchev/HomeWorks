using System;
class ZeroSubset
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split(' ');
        double a = double.Parse(userInput[0]);
        double b = double.Parse(userInput[1]);
        double c = double.Parse(userInput[2]);
        double d = double.Parse(userInput[3]);
        double e = double.Parse(userInput[4]);
        bool isResult = false;

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            isResult = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            isResult = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            isResult = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            isResult = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            isResult = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            isResult = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            isResult = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            isResult = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            isResult = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            isResult = true;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            isResult = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            isResult = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            isResult = true;
        }
        if(a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            isResult = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            isResult = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            isResult = true;
        }             
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            isResult = true;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            isResult = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            isResult = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            isResult = true;
        }      
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            isResult = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            isResult = true;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            isResult = true;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            isResult = true;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            isResult = true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            isResult = true;
        }
        if (isResult == false)
        {
            Console.WriteLine("no zero subset");
        }                        
    }
}

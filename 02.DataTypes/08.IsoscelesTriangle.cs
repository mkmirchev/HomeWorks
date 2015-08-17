using System;
using System.Text;      // Using System.Text to be able to change the encoding type.

    class IsoscelesTriangle
    {
        static void Main()
        {
            char copyRights = '\u00A9';                  // Declade the character
            Console.OutputEncoding = Encoding.UTF8;      // Change the encoding to UTF-8
            // Printing the triangle
            Console.WriteLine("   "+ copyRights+"   ");
            Console.WriteLine("  " + copyRights + " " + copyRights + "  ");
            Console.WriteLine(" " + copyRights + "   " + copyRights + " ");
            Console.WriteLine(copyRights + " " + copyRights + " " + copyRights + " " + copyRights);


        }
    }


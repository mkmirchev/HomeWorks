using System;

    class MatrixOfPalindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputData = input.Split(' ');
            int row = Convert.ToInt32(inputData[0]);
            int col = Convert.ToInt32(inputData[1]);
            char start = 'a';
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0}{1}{2} ",(char)(start + i),(char)(start + j + i),(char)(start + i));
                }
                Console.WriteLine();
            }
        }
    }


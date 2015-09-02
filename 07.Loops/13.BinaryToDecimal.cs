using System;

    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] arr = new string[input.Length];
            int counter = 0;
            for (int i = input.Length-1; i >= 0; i--)
            {
                arr[counter] = Convert.ToString(input[i]);
                counter++;

            }
            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            int binNum = 0;
            int test = 1;
            if (Convert.ToInt32(arr[0]) == 1)
            {
                binNum = 1;
            }
            //Console.WriteLine(Convert.ToInt32(arr[0]) + " * " + binNum);
            for (int i = 1; i < input.Length; i++)
            {
                for (int index = 0; index < i; index++)
                {
                    test *= 2;
                }
                binNum += (Convert.ToInt32(arr[i]) * test);
                //Console.WriteLine(Convert.ToInt32(arr[i]) + " * " + test);
                test = 1;
            }
            Console.WriteLine(binNum);
            
        }
    }


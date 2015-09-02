using System;

    class SpiralMatrix
    {
        static void Main()
        {
            // Initialize the input data
            int n = int.Parse(Console.ReadLine());
            int[,] matrixN = new int[n, n];
            int row = 0;
            int col = 0;
            int maxRotations = n * n;
            // Insert a direction variable
            string direction = "right";
            // Set a range of the input data
            if (1 <= n && n <= 20)
            {
                for (int i = 1; i <= maxRotations; i++)
                {
                    if (direction == "right" && (col > (n - 1) || matrixN[row,col] != 0))
                    {
                        direction = "down";
                        col--;
                        row++;
                    }
                    if (direction == "down" && (row > (n - 1) || matrixN[row,col] != 0))
                    {
                        direction = "left";
                        row--;
                        col--;
                    }
                    if (direction == "left" && (col < 0 || matrixN[row,col] != 0))
                    {
                        direction = "up";
                        col++;
                        row--; ;
                    }
                    if (direction == "up" && (row < 0 || matrixN[row, col] != 0))
                    {
                        direction = "right";
                        row++;
                        col++; 
                    }
                    matrixN[row , col] = i;
                    if (direction == "right")
                    {
                        col++;
                    }
                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "left")
                    {
                        col--;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                   
                }
                // Printing the matrix
                for (int printRow = 0; printRow < n; printRow++)
                {
                    for (int printCol = 0; printCol < n; printCol++)
                    {
                        Console.Write("{0,4}",matrixN[printRow,printCol]);
                    }
                    Console.WriteLine();
                }
               
            }
            // Set case when input data is out of the range
            else
            {
                Console.WriteLine("Enter a positive integer in the interval 1 <= n <= 20.");
                Main();
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class1
    {
        public static void Main2()
        {
            //2d array accept from user
            int[,] matrix = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Please enter value for matrix[" + row + "," + col + "] :");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

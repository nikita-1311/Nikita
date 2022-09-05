using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class3
    {
        public static void Main()
        {
            //multiplication of matrix
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] result = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Please enter value for matrix1[" + row + "," + col + "] :");
                    matrix1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Please enter value for matrix2[" + row + "," + col + "] :");
                    matrix2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Multiplication of two matrix= ");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    result[row, col] = matrix1[row, col] * matrix2[row, col];
                    Console.Write(result[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

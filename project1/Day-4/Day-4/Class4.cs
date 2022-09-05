using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class4
    {
        public static void Main()
        {
            //transpose of matrix
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            Console.Write("Enter elements in the matrix :\n");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("element - [{0}],[{1}] : ", row, col);
                    matrix1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe matrix before transpose is :\n");
            for (int row = 0; row < 2; row++)
            {
                Console.Write("\n");
                for (int col = 0; col < 2; col++)
                    Console.Write("{0}\t", matrix1[row, col]);
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {

                    matrix2[col, row] = matrix1[row, col];
                }
            }
            Console.Write("\n\nThe Transpose of a matrix is : ");
            for (int row = 0; row < 2; row++)
            {
                Console.Write("\n");
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("{0}\t", matrix2[row, col]);
                }
            }
            Console.Write("\n\n");
        }
    }
}

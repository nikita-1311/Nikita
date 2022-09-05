using System;

namespace Day_4
{
    class Program
    {
        static void Main1(string[] args)
        {
            //2d array
            int[,] matrix = new int[2, 2] { { 3, 4 }, { 7, 8 } };
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<2;col++)
                {
                    Console.Write(matrix[row,col]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}

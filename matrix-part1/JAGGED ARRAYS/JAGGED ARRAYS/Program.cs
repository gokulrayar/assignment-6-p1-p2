using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JAGGED_ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1-jagged Arrays
            //int[][] matrix = new int[3][];  //declaration
            //matrix[0] = new int[4]; //first row
            //matrix[1] = new int[2]; // 2 row
            //matrix[2] = new int[3]; // 3rd row

            //Console.ReadKey();
            //Task 2 - display
            //  double[,] matrix = {
            //    {1.1, 1.2, 1.3},
            //    {2.1, 2.2, 2.3},
            //    {3.1, 3.2, 3.3}
            //  };
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //            Console.Write(matrix[i, j] + " ");
            //        }
            //        Console.WriteLine();  // Move to the next line for the next row
            //    }

            // access
            //TASK 3
            // modify 3rd element

            int[,] matrix = new int[,]
            {
                {1,2,3 },
                {11,22,23 },
                {10,20,30 }


            };
            matrix[1, 2] = 15;
            


        }

    }

    }


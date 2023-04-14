using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CalculateDiagonal();
            Console.ReadLine();
        }
        public static void CalculateDiagonal()
        {
            Random random = new Random();
            int[][] array = new int[5][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[5];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(1, 10);
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }


            int diagonalsum = 0;
            int firstsum = 0;
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (i == j)
                    {
                        diagonalsum += array[i][j];
                    }
                    if (i == array[i].Length - 1)
                    {
                        firstsum += array[i][j];
                    }
                    result = diagonalsum + firstsum;
                   
                }
            }


            Console.WriteLine($"Diagonal summa : {diagonalsum}");
            Console.WriteLine($"Last summa : {firstsum}");
            Console.WriteLine($"Result : {result} ");

        
            Random random2 = new Random();
            int[][] array2 = new int[5][];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new int[5];
                for (int j = 0; j < array2[i].Length; j++)
                {
                    array2[i][j] = random2.Next(1, 10);
                    Console.Write($"{array2[i][j]} ");
                }
                Console.WriteLine();
            }


            int diagonalsum2 = 0;
            int lastsum = 0;
            int result2 = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2[i].Length; j++)
                {
                    if (i + j == array2.Length - 1)
                    {
                        diagonalsum2 += array2[i][j];
                    }
                    if (i == 0)
                    {
                        lastsum += array2[i][j];
                    }    
                    result2 = diagonalsum2 + lastsum;
                }
            }

            Console.WriteLine($"Diagonal summa : {diagonalsum2}");
            Console.WriteLine($"Last summa : {lastsum}");
            Console.WriteLine($"Result : {result2}");


            bool result3 = false;

            if (result2 < result)
            {
                result3 = true;
            }
            else
            {
                result3 = false;
            }

            Console.WriteLine($"{result3}");
        }
    }
}
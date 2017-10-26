using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_dopLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int step;
            do
            {
                try
                {
                    Console.WriteLine("Введите размерность матрицы");
                    n = Int32.Parse(Console.ReadLine());
                    break;
                } catch { }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Введите степень");
                    step = Int32.Parse(Console.ReadLine());
                    break;
                } catch { }
            } while (true);
            int[,] matrix = new int[n, n];
            int[,] resMatrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(10);
                    resMatrix[i, j] = matrix[i, j];
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < step - 1; i++)
            {
                resMatrix = Multiplication(matrix, resMatrix);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", resMatrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
    }
}

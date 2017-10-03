using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Введите размеры матрицы M и N:\nM = ");
            m = Int32.Parse(Console.ReadLine());

            Console.Write("N = ");
            n = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(10, 99);
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            if (matrix.Rank < n)
            {
                Console.WriteLine("Матрица вироджена");
            } else
            {
                Console.WriteLine("Матрица не вироджена");
            }
            

                    Console.WriteLine("Транспонированная матрица:");
            int[,] transpMatrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transpMatrix[i, j] = matrix[j, i];
                    Console.Write("{0} ", transpMatrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

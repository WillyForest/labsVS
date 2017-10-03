using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 5;
            int[,] testArray = new int[a, b];
            Random randVar = new Random();
            Console.WriteLine("Размерность массива: {0} \nКоличество элементов массива: {1}\nМассив: ", 
                testArray.Rank, testArray.Length);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    testArray[i, j] = randVar.Next(10, 99);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(testArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

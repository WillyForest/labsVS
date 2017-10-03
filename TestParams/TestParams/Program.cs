using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите размерность массива:");
            a = Int32.Parse(Console.ReadLine());

            int[] testArray = new int[a];
            Console.WriteLine("Введите элементы массива.");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Array[{0}]", i);
                testArray[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(summa(testArray));
            Console.ReadLine();
        }

        private static int summa(int[] array)
        {
            int summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summa += array[i];
            }
            return summa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите размерность массива:");
            a = Int32.Parse(Console.ReadLine());

            int[] testArray = new int[a];
            Console.WriteLine("Введите элементы массива.");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Array[{0}]", i);
                testArray[i] = Int32.Parse(Console.ReadLine());
            }
            Array ClonedArray = (Array) testArray.Clone();
            Console.WriteLine(ClonedArray);
            for (int i = 0; i < ClonedArray.GetLength(0); i++)
            {
                Console.WriteLine(ClonedArray.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}

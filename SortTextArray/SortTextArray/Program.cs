using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTextArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите размерность массива:");
            a = Int32.Parse(Console.ReadLine());

            String[] testArray = new string[a];
            Console.WriteLine("Введите элементы массива.");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Array[{0}]", i);
                testArray[i] = Console.ReadLine();
            }
            Array.Sort(testArray);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(testArray[i]);
            }
            Console.ReadLine();
        }
        
    }
}

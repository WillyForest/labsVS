using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 9 };
            Array.ForEach<int>(arr, WriteMe);
            Console.WriteLine();

            int [] newArr = Array.FindAll<int>(arr, condition);
            Array.ForEach<int>(newArr, WriteMe);

            Console.ReadKey();
        }

        private static bool condition(int obj)
        {
            return obj % 2 == 0;
           
        }

        private static void WriteMe(int obj)
        {
            Console.Write("{0} ", obj);
        }
    }
}

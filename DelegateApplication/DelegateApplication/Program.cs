using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 9 };
            WriteMe(arr);
            WriteMe(Condition(arr));
            Console.ReadKey();
        }
        public static void WriteMe(Array arr)
        {
            Console.WriteLine("Массив:");
            foreach (int elem in arr)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();
        }
        public static int[] Condition(Array arr)
        {
            ArrayList elems = new ArrayList();
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    elems.Add(num);
            }
            int[] newArr = new int[elems.ToArray().Length];
            for (int i = 0; i < newArr.Length; i++)
                newArr[i] = Int32.Parse(elems[i].ToString());
            return newArr;
        }
    }
}

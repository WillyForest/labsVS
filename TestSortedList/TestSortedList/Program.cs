using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList myList = new SortedList();
            myList.Add("Zack", "1");
            myList.Add("Den", "2");
            myList.Add("Alex", "3");
            myList.Add("John", "4");
            myList.Add("Elhm", "5");
            myList.Add("Lamar", "6");

            Console.WriteLine("Введите номер элемента:");
            int index = Int32.Parse(Console.ReadLine());
            Console.WriteLine(myList.GetByIndex(index));
            Console.WriteLine("Введите ключ элемента:");
            String key = Console.ReadLine();
            Console.WriteLine(myList[key]);
            Console.ReadLine();
        }
    }
}

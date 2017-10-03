using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> openWith =
            new Dictionary<string, int>();

            openWith.Add("1", 1);
            openWith.Add("2", 2);
            openWith.Add("3", 3);
            openWith.Add("4", 4);
            openWith.Add("5", 5);
            openWith.Add("6", 6);
            openWith.Add("7", 7);
            openWith.Add("8", 8);
            openWith.Add("9", 9);
            openWith.Add("0", 0);
            Console.WriteLine("Введите цифру:");
            int value;
            if (openWith.TryGetValue(Console.ReadLine(), out value))
            {
                Console.WriteLine("Value = {0}.", value);
            }
            Console.ReadLine();
        }
    }
}

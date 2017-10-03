using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };
            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }
}

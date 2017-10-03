using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericApple
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            Console.WriteLine(a.GetNumber());
            Apple a1 = new Apple();
            Console.WriteLine(a1.GetNumber());
            Apple a2 = new Apple();
            Console.WriteLine(a2.GetNumber());
            Console.ReadKey();
        }
    }
}

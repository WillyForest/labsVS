using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            foreach (Object obj in myStack)
                Console.WriteLine("{0}", obj);
            
            Console.WriteLine(myStack.Peek());
            Console.ReadLine();
        }
    }
}

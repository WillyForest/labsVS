using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число.");
            string s = Console.ReadLine();

            int i = Int32.Parse(s);
            int i2 = Convert.ToInt32(s);
            Console.WriteLine("i={0} i2={1}", i, i2);
            Console.WriteLine("1. Проверим, находится ли число в промежутке от -10 до 10.");
            if (i<10 && i > -10)
            {
                Console.WriteLine("Да, число в этом промежутке.");
            }
            else
            {
                Console.WriteLine("Нет, число не в этом промежутке.");
            }
            int fiboNum1 = 0;
            int fiboNum2 = 1;
            int fiboNum = 0;
            Console.WriteLine("2. Числа Фибоначчи: ");
            for (int j = 0; j < 10; j++)
            {
                fiboNum = fiboNum1 + fiboNum2;
                fiboNum1 = fiboNum2;
                fiboNum2 = fiboNum;
                Console.Write("{0}, ", fiboNum2);
            }
            Console.Write("...\n");
            Console.WriteLine("3. Выведем строку, в зависимости от введенного значения (1, 2 или другое).");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Вы ввели 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели 2");
                    break;
                default:
                    Console.WriteLine("Вы ввели не 1 или 2");
                    break;
            }
            Console.WriteLine("4. Цикличное приложение.");
            string goAgain = "";
            do
            {
                Console.WriteLine("Введите имя.");
                string name = Console.ReadLine();
                Console.WriteLine("Здраствуй, {0}", name);
                do
                {
                    Console.WriteLine("Продолжить работу? (да, нет)");
                    goAgain = Console.ReadLine();
                }
                while (goAgain != "да" && goAgain != "нет");
            }
            while (goAgain == "да");



            Console.ReadLine();
        }
    }
}

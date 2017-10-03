using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterDigit2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
            Console.Clear();
            Console.WriteLine("1 - '+'");
            Console.WriteLine("2 - '-'");
            Console.WriteLine("3 - '/'");
            Console.WriteLine("4 - '*'");
            Console.WriteLine("5 - 'Возвести в степень'");
            Console.WriteLine("6 - 'Извлечь корень'");
            Console.WriteLine("7 - 'Выход'");
            int a, b;
                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Введите a:");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите b:");
                        b = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Результат = {0}", a + b);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите a:");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите b:");
                        b = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Результат = {0}", a - b);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите a:");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите b:");
                        b = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Результат = {0}", a / b);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Введите a:");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите b:");
                        b = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Результат = {0}", a * b);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Введите a:");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите b:");
                        b = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Результат = {0}", Math.Pow(a, b));
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Введите a:");
                        a = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Введите b:");
                        b = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Результат = {0}", Math.Pow(a, 1.0/b));
                        Console.ReadLine();
                        break;
                    case 7:
                        return;
                    default:
                        break;
                
                }
            } while (true);

        }
    }
}

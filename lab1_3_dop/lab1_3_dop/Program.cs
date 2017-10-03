using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = Int32.Parse(Console.ReadLine());
            String[] strs = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0} строку:", i+1);
                strs[i] = Console.ReadLine();
            }
            Console.WriteLine("Введите количество символов");
            int limit = Int32.Parse(Console.ReadLine());

            String[] newStrs = new string[n];
            for (int i = 0; i < n; i+=3)
            {
                newStrs[i] = strs[i] + strs[i + 1];
                newStrs[i + 2] = strs[i + 2];
                if (newStrs[i].Length > limit)
                {
                    String symbols = "";
                    try
                    {
                        int j = limit;
                        while (true)
                        {
                            symbols += newStrs[i][j];
                            j++;
                        }
                    } catch {}
                    newStrs[i + 2] = newStrs[i+2] + "" + symbols;
                }
            }
            for (int i = 0; i < n; i += 3)
            {
                int j = 0;
                String str = "";
                while (j < limit)
                {
                    str += newStrs[i][j];
                    j++;
                }
                newStrs[i] = str;
               
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(newStrs[i]);
            }
            Console.ReadKey();


        }
    }
}

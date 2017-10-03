using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericApple
{
    class Apple
    {
        // номер первого создаваемого объекта класса
        static int number = 1;
        // номер по порядку создаваемого объекта класса
        private int muNumber = 0;
        // конструктор класса
        public Apple()
        {
            this.muNumber = number;
            number++;
        }
        //метод вывода на экран номера объекта класса
        public string GetNumber()
        {
            return String.Format("Яблоко номер {0}", this.muNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            dieselEngine diesEng = new dieselEngine("Дизельный двигатель Mx35mod");
            diesEng.setNumOfCylinders(4);
            diesEng.setTypeOfFuel("ДП");
            diesEng.setVolume(1.2);
            diesEng.setTorque(500);
            diesEng.setPowerful(12);
            diesEng.setFuelConsumption(6.6);
            diesEng.Display();

            benzineEngine benzEng = new benzineEngine("Бензиновый двигатель D2000");
            benzEng.setNumOfCylinders(8);
            benzEng.setTypeOfFuel("A-95");
            benzEng.setVolume(3.1);
            benzEng.setTorque(600);
            benzEng.setPowerful(14);
            benzEng.setFuelConsumption(10.6);
            benzEng.Display();

            //reactiveEngine reactEng = new reactiveEngine("Реактивный двигатель ROP258-24");
            reactiveEngine reactEng = new reactiveEngine("Реактивный двигатель ROP258-24", -1, 1400, 125, 4860, "Gazoline", -1);
            reactEng.Display();
            Console.ReadKey();
        }
    }
}

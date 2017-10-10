using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_engine
{
    class Engine
    {
        private string model;
        private int numOfCylinders;
        private int powerful;
        private double volume;
        private double fuelConsumption;
        private string typeOfFuel;
        private int torque;
        public string pref;

        public Engine(string model)
        {
            this.model = model;
            this.typeOfFuel = "Не указано";
        }
        public Engine(string model, int numofCylinders, int powerful, double volume, double fuelConsumption, 
            string typeOfFuel, int torque)
        {
            this.model = model;
            this.typeOfFuel = typeOfFuel;
            this.numOfCylinders = numofCylinders;
            this.powerful = powerful;
            this.volume = volume;
            this.fuelConsumption = fuelConsumption;
            this.torque = torque;
        }
        public void setTypeOfFuel(string typeOfFuel)
        {
            this.typeOfFuel = typeOfFuel;
        }
        public void setTorque(int torque)
        {
            this.torque = torque;
        }
        public void setNumOfCylinders(int numOfCylinders)
        {
            this.numOfCylinders = numOfCylinders;
        }
        public void setVolume(double volume)
        {
            this.volume = volume;
        }
        public void setFuelConsumption(double fuelConsumption)
        {
            this.fuelConsumption = fuelConsumption;
        }
        public void setPowerful(int powerful)
        {
            this.powerful = powerful;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public void Display()
        {
            string indefinite = "Не указано";
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine(model);

            if (this.numOfCylinders == 0)
                Console.WriteLine("Количество цилиндров: {0};", indefinite);
            else
                if (this.numOfCylinders == -1)
                    Console.WriteLine("Циллиндры не предусмотрены конструкцией");
                else
                    Console.WriteLine("Количество цилиндров: {0};", this.numOfCylinders);

            if (this.volume == 0)
                Console.WriteLine("Объем двигателя: {0};", indefinite);
            else
                Console.WriteLine("Объем двигателя: {0} л;", this.volume);

            if (this.powerful == 0)
                Console.WriteLine("Мощность двигателя: {0};", indefinite);
            else
                Console.WriteLine("Мощность двигателя: {0} КВт;", this.powerful);

            Console.WriteLine("Тип топлива: {0};", this.typeOfFuel);

            if (this.fuelConsumption == 0)
                Console.WriteLine("Расход топлива: {0}", indefinite);
            else
                Console.WriteLine("Расход топлива: {0} л/100 км", this.fuelConsumption);

            if (this.torque == 0)
                Console.WriteLine("Крутящий момент: {0};", indefinite);
            else
                if (this.torque == -1)
                    Console.WriteLine("Крутящий момент в данном двигателе не является характеристикой.");
                else
                    Console.WriteLine("Крутящий момент: {0};", this.torque);
            Console.WriteLine(pref);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();



        }
    }
}

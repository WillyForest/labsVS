using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если вы хотите ввести данные вручную - нажмите 1.");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Введите характеристики дизельного двигателя.");
                Console.WriteLine("Введите название двигателя, модель");
                string model = Console.ReadLine();
                DiezelEngine dEng = new DiezelEngine(model);
                iDelete iDel = dEng;
                int err = 0;
                Console.WriteLine("Введите количество цилиндров:");
                int numOfCylinders = 0;
                int powerful = 0;
                double volume = 0;
                double fuelConsumption = 0;
                string typeOfFuel = "";
                int torque = 0;
                string pref = "";
                do
                {
                    err = 0;
                    try
                    {
                        numOfCylinders = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                Console.WriteLine("Введите мощность (кВт):");
                do
                {
                    err = 0;
                    try
                    {
                        powerful = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                Console.WriteLine("Введите объем двигателя:");
                do
                {
                    err = 0;
                    try
                    {
                        volume = Double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                
                Console.WriteLine("Введите расход топлива (л/100 км):");
                do
                {
                    err = 0;
                    try
                    {
                        fuelConsumption = Double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                Console.WriteLine("Введите тип топлива:");
                do
                {
                    err = 0;
                    try
                    {
                        typeOfFuel = Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                Console.WriteLine("Введите крутящий момент:");
                do
                {
                    err = 0;
                    try
                    {
                        torque = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                
                Console.WriteLine("Введите преимущества такого типа двигателя:");
                do
                {
                    err = 0;
                    try
                    {
                        pref = Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Попробуйте еще раз");
                        err = 1;
                    }
                } while (err == 1);
                
                dEng.initializeMe(numOfCylinders, powerful, volume, fuelConsumption, typeOfFuel, torque,
                    pref);
                dEng.writeMe();
                iDel.Delete();

                Console.WriteLine("Остальное введем автоматически");

                BensinEngine bEng = new BensinEngine("Бензиновый двигатель D2000");
                iDel = bEng;
                bEng.initializeMe(8, 14, 3.1, 10.6, "A-95", 600, "Двигатель отличается большей мощностью за счет эффективного использования ресурсов.");
                bEng.writeMe();
                iDel.Delete();

                ReactiveEngine rEng = new ReactiveEngine("Реактивный двигатель ROP258-24");
                iDel = rEng;
                rEng.initializeMe(-1, 1400, 125, 4860, "Gazoline", -1, "Двигатель отличается своей большой мощностью и расходом топлива, \nпреимущественно используется в ракетостроении.");
                rEng.writeMe();
                iDel.Delete();
            }
            else
            {
                Console.WriteLine("Данные вводятся автоматически.");
                DiezelEngine dEng = new DiezelEngine("Дизельный двигатель Mx40i", 4, 12, 1.2, 6.6, "ДТ", 500);
                iDelete iDel = dEng;
                dEng.writeMe();
                iDel.Delete();

                BensinEngine bEng = new BensinEngine("Бензиновый двигатель D2000", 8, 14, 3.1, 10.6, "A-95", 600);
                iDel = bEng;
                bEng.writeMe();
                iDel.Delete();

                ReactiveEngine rEng = new ReactiveEngine("Реактивный двигатель ROP258-24", -1, 1400, 125, 4860, "Gazoline", -1);
                iDel = rEng;
                rEng.writeMe();
                iDel.Delete();
            }
            Console.ReadKey();
        }
    }
    public abstract class Engine 
    {
        public abstract void initializeMe(int numofCylinders, int powerful, double volume, 
            double fuelConsumption, string typeOfFuel, int torque, string pref);
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
        public Engine(string model, int numofCylinders, int powerful, double volume, 
            double fuelConsumption, string typeOfFuel, int torque)
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
        public void setPref(string pref)
        {
            this.pref = pref;
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
        public void writeMe()
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
    public class DiezelEngine : Engine, iDelete
    {
        public DiezelEngine(string model) : base(model)
        {
            this.pref = "Двигатель отличается экономностью расхода топлива.";
        }
        public DiezelEngine(string model, int numofCylinders, int powerful, double volume, 
            double fuelConsumption, string typeOfFuel, int torque) : base(model, numofCylinders, powerful, volume, fuelConsumption, typeOfFuel, torque)
        {
            this.pref = "Двигатель отличается экономностью расхода топлива.";
        }
        public void Delete()
        {

        }

        public override void initializeMe(int numofCylinders, int powerful, double volume, 
            double fuelConsumption, string typeOfFuel, int torque, string pref)
        {
            setTypeOfFuel(typeOfFuel);
            setNumOfCylinders(numofCylinders);
            setPowerful(powerful);
            setVolume(volume);
            setFuelConsumption(fuelConsumption);
            setTorque(torque);
            setPref(pref);
        }

    }
    public class BensinEngine : Engine, iDelete
    {
        public BensinEngine(string model) : base(model)
        {
            this.pref = "Двигатель отличается большей мощностью за счет эффективного использования ресурсов.";
        }
        public BensinEngine(string model, int numofCylinders, int powerful, double volume, 
            double fuelConsumption, string typeOfFuel, int torque) : base(model, numofCylinders, powerful, volume, fuelConsumption, typeOfFuel, torque)
        {
            this.pref = "Двигатель отличается большей мощностью за счет эффективного использования ресурсов.";
        }
        public void Delete()
        {

        }

        public override void initializeMe(int numofCylinders, int powerful, double volume,
            double fuelConsumption, string typeOfFuel, int torque, string pref)
        {
            
        }

    }
    public class ReactiveEngine : Engine, iDelete
    {
        public ReactiveEngine(string model) : base(model)
        {
            this.pref = "Двигатель отличается своей большой мощностью и расходом топлива, \nпреимущественно используется в ракетостроении.";
        }
        public ReactiveEngine(string model, int numofCylinders, int powerful, double volume, 
            double fuelConsumption, string typeOfFuel, int torque) : base(model, numofCylinders, powerful, volume, fuelConsumption, typeOfFuel, torque)
        {
            this.pref = "Двигатель отличается своей большой мощностью и расходом топлива, \nпреимущественно используется в ракетостроении.";
        }
        public void Delete()
        {

        }

        public override void initializeMe(int numofCylinders, int powerful, double volume,
            double fuelConsumption, string typeOfFuel, int torque, string pref)
        {
            
        }

    }
    public interface iDelete
    {
        void Delete();
    }
}

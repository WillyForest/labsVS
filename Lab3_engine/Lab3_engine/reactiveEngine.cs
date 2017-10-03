using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_engine
{
    class reactiveEngine : Engine
    {
        public reactiveEngine(string model) : base(model)
        {
            this.pref = "Двигатель отличается своей большой мощностью и расходом топлива, \nпреимущественно используется в ракетостроении.";
        }
        public reactiveEngine(string model, int numofCylinders, int powerful, double volume, double fuelConsumption, string typeOfFuel, int torque) : base(model, numofCylinders, powerful, volume, fuelConsumption, typeOfFuel, torque)
        {
            this.pref = "Двигатель отличается своей большой мощностью и расходом топлива, \nпреимущественно используется в ракетостроении.";
        }
    }
}

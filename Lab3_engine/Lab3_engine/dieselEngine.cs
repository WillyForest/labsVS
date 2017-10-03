using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_engine
{
    class dieselEngine : Engine
    {
        public dieselEngine(string model) : base(model)
        {
            this.pref = "Двигатель отличается экономностью расхода топлива.";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_engine
{
    class benzineEngine : Engine
    {
        public benzineEngine(string model) : base(model)
        {
            this.pref = "Двигатель отличается большей мощностью за счет эффективного использования ресурсов.";
        }
    }
}

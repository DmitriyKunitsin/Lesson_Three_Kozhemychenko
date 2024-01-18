using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Car
    {
        public string ModelName { get; set; }
        public string ManufacturerName { get; set; }
        public double FuelConsumption { get; set; } // 2,0 - 80,0
        public int Weight { get; set; } // 100 - 5000

        public override string ToString()
        {
            return ModelName;
        }
    }
}

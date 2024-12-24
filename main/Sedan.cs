using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Sedan : Car
    {
        int TrunkCapacity { get; set; }
        public Sedan(int trunkCapacity, string model, string licensePlate) : base(model, licensePlate)
        {
            TrunkCapacity = trunkCapacity;
        }
        public override string TypeOfFuel()
        {
            return "Бензин";
        }
        public override string GetCarType()
        {
            return "Седан";
        }
    }
}

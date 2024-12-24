using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Truck : Car
    {
        int LoadCapacity { get; set; }
        public Truck(int loadCapacity, string model, string licensePlate): base(model, licensePlate)
        {
            LoadCapacity = loadCapacity;
        }
        public override string TypeOfFuel()
        {
            return "Дизель";
        }
        public override string GetCarType()
        {
            return "Грузовик";
        }
    }
}

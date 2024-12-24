using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    abstract class Car
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public abstract string TypeOfFuel();
        public abstract string GetCarType();
        public Car(string model, string licensePlate)
        {
            Model = model;
            LicensePlate = licensePlate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Trip
    {
        public Driver Driver {  get; set; }
        public Car Car { get; set; }
        public DateTime TripDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DisplayTripInfo()
        {
            return $"Водитель - {Driver.Name}. Дата поездки - {TripDate.ToString().Split()[0]}. Продолжительность - {EndDate - StartDate}. Тип транспортного средства - {Car.GetCarType()}. Тип топлива - {Car.TypeOfFuel()}";
        }
    }
}

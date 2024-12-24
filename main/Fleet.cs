using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Fleet
    {
        private List<Car> Cars = new List<Car>();
        private List<Trip> Trips = new List<Trip>();
        public List<Driver> Drivers = new List<Driver>();
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RegisterDriver(Driver driver) 
        {
            Drivers.Add(driver);
        }
        public void CreateTrip(Driver driver, Car car, DateTime startTime, DateTime endTime) 
        {

            Trip trip = new Trip() 
            {   
                Driver = driver, 
                Car = car, 
                StartDate = startTime, 
                EndDate = endTime, 
                TripDate = DateTime.Now.Date
            };
            Trips.Add(trip);
        }
        public string DisplayTripsByDate(DateTime date)
        {
            string result = "";
            foreach (Trip trip in Trips)
            {
                if (trip.TripDate == date)
                {
                    result += trip.DisplayTripInfo() + "\n";
                }
            }
            return result;
        }
        public List<Car> getCars()
        {
            return Cars;
        }
    }
}

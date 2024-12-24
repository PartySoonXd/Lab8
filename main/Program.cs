using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fleet fleet = new Fleet();

            Car car1 = new Sedan(60, "Rolls Royce Ghost", "а001аа124");
            Car car2 = new Truck(1000, "Volvo FH16", "a123aa124");
            fleet.AddCar(car1);
            fleet.AddCar(car2);

            Driver driver1 = new Driver() { Name = "Валера", ExperienceYears = 8, MedicalCertificate = new MedicalCertificate() { CertificateNumber = 35612, DoctorName = "Игорь", IssueDate = DateTime.Parse("25.11.2021") } };
            Driver driver2 = new Driver() { Name = "Александр", ExperienceYears = 3, MedicalCertificate = new MedicalCertificate() { CertificateNumber = 13566, DoctorName = "Николай", IssueDate = DateTime.Parse("12.08.2020") } };
            fleet.RegisterDriver(driver1);
            fleet.RegisterDriver(driver2);

            Random rnd = new Random();
            List<Car> cars = fleet.getCars();

            for (int i = 0; i < 5; i++)
            {
                fleet.CreateTrip(
                    fleet.Drivers[rnd.Next(fleet.Drivers.Count)],
                    cars[rnd.Next(cars.Count)],
                    DateTime.Now,
                    DateTime.Now.AddHours(rnd.Next(1, 15)).AddMinutes(rnd.Next(1, 61))
                );
            }

            Console.WriteLine(fleet.DisplayTripsByDate(DateTime.Parse("24.12.2024")));
        }
    }
}

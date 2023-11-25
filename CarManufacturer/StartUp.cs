using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {

            //Problem 01:
            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

            //Problem 02:
            //Car car = new Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());

            //Problem: 03
            //string make = Console.ReadLine();   
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine()); 
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar  = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar  = new Car(make, model, year, fuelQuantity, fuelConsumption);

            //Problem:04
            var tires = new Tire[4]
                {
                    new Tire(1, 2.5),
                    new Tire(1, 2.1),
                    new Tire(2, 0.5),
                    new Tire(2, 2.3)
                };
            Engine engine = new Engine(560, 6300);
            Car car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);
        }
    }
}

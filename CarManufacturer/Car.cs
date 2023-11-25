using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
        public Car(string make, string model, int year, double fuelQuanity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuanity;
            this.FuelConsumption = fuelConsumption;
           
        }
        public Car(string make, string model, int year, double fuelQuanity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuanity,  fuelConsumption )
        {
            this.Engine= engine;
            this.Tires = tires;
        }

        //string make;
        //string model;
        //int year;
        //double fuelConsumption;
        //double fuelQuantity;

        Tire[] tires;
        Engine engine;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
       
        public void Drive(double distance)
        {
            double result = FuelQuantity - (distance* FuelConsumption);
            if (result > 0)
            {
                FuelQuantity -= distance * FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:f2}");

            return sb.ToString();
        }
    }
}

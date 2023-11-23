using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public  class Car
    {
        string make;
        string model;
        int year;
        double fuelConsumption;
        double fuelQuantity;
        Engine engine;
        Tire tire;      
        public Car()
        {
                
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            
        }
        public Car(string make, string model, int year, double fuelQuanity, double fuelConsumption, Tire[] tire , Engine engine)
            :this(make, model, year, fuelQuanity, fuelConsumption)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuanity;
            this.Tire = tire;
            this.Engine = engine;

        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire Tire { get; set; }

        public void Drive(double distance)
        {
            double result = FuelQuantity - FuelConsumption;
            if (result>0)
            {
                FuelQuantity -= FuelConsumption;
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

            return  sb.ToString();
        }
    }
}

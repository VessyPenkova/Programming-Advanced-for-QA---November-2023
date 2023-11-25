using System.Reflection;

namespace _04._Vehicle_Catalogue__not_included_in_final_score_
{
    public class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (command != "end")
            {
                string[] inputInfo = command.Split("/").ToArray();

                string typeOfThevehicle = inputInfo[0];
                string vehiceBrand = inputInfo[1];
                string vehicleModel = inputInfo[2];

                if (typeOfThevehicle == "Car")
                {
                    int horsePower = int.Parse(inputInfo[3]);
                    Car currentcar = new Car(vehiceBrand, vehicleModel, horsePower);

                    catalog.Cars.Add(currentcar);
                }
                if (typeOfThevehicle == "Truck")
                {
                    int wheight = int.Parse(inputInfo[3]);
                    Truck truck = new Truck(vehiceBrand, vehicleModel, wheight);
                    catalog.Trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            if (catalog.Cars.Any())
            {
                List<Car> orderedcars = catalog.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in orderedcars)
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Any())
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}

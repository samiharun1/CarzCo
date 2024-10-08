
using System.Transactions;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            vehicleList.Add(new Car("volvo", "V60", 2000, 5));
            vehicleList.Add(new Motorcycle("Harley Davis", "s150", 2005, true));
            vehicleList.Add(new Truck("Nissan", "T6000", 2009, 3));

            var newList = FilterVehicles<Motorcycle>(vehicleList);
            PrintAll(vehicleList);
           // PrintAll(newList);
            var vehicleToSell = vehicleList.Find(v => v.Brand == "Nissan");
            SellVehicle(vehicleList, vehicleToSell);
            PrintAll(vehicleList);

        }
        static List<T> FilterVehicles<T>(List<Vehicle> vehicleList) where T : Vehicle

        {
            return vehicleList.OfType<T>().ToList();
           
        }
        static void SellVehicle(List<Vehicle> vehicleList, Vehicle vehicle)
        {
            Console.WriteLine($"Säljer fordonet av märke {vehicle.Brand}");
            vehicleList.Remove(vehicle);
        }
        static void PrintAll<T>(List<T> vehicleList) where T : Vehicle
        {
            foreach (var vehicle in vehicleList)
            {
                vehicle.PrintInfo();
            }
        }
    }
}


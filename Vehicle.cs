using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarzCo
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            //Konstruktor
            Brand = brand;
            Model = model;
            Year = year;

        }
        public virtual void PrintInfo()
        {
            Console.Write($"{this.Brand} {this.Model} {this.Year} ");
        }

    }
    public interface IDriveable
    {
        void Drive();
        
    }
    public class Car : Vehicle, IDriveable
    {
        public int NumberOfDoors;
        public Car(string brand, string model, int year, int numberOfDoors) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;


        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"bilen har {this.NumberOfDoors} dörrar.");
        }

        public void Drive()
        {
            Console.WriteLine("Bilen kör.");
        }
    }
    public class Motorcycle : Vehicle, IDriveable
    {
        public bool HasSideCar;
        public Motorcycle(string brand, string model, int year, bool hasSideCar) : base(brand, model, year)
        {
            HasSideCar = hasSideCar;


        }
        public void Drive()
        {
            Console.WriteLine("Motorcycle kör.");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            if (HasSideCar)
            {
                Console.WriteLine("motorcyckeln har en sidvagn.");
            }
            else 
            {
                Console.WriteLine("motorcyckeln har inte en sidvagn.");
            }
        }
    }
    public class Truck : Vehicle, IDriveable
    {
        public int WheelAxis;
        public Truck(string brand, string model, int year, int wheelAxis) : base(brand, model, year)
        {
            WheelAxis = wheelAxis;


        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"lastbilen har {this.WheelAxis} hjulaxlar.");
        }
        public void Drive()
        {
            Console.WriteLine("Truck kör.");
        }
    }

}


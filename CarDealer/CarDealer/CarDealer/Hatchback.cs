using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Hatchback : Vehicle
    {
        
        protected string Type { get; set; }
        public Hatchback(int Id, string Name, int Wheels, string Model, string Brand, double Power, double Price, double Mileage, string Type) : base(Id, Name, Wheels, Model, Brand, Power, Price, Mileage)
        {
            this.Type = Type;
        }
        public Hatchback()
        {

        }
        public override void ShowVehicle()
        {
            Console.WriteLine("Id: {0}\nName: {1}\nWheels: {2}\nModel: {3}\nBrand: {4}\nPower: {5}\nPrice: {6}\nMileage: {7}\nType: {8}\n-------", Id, Name, Wheels, Model, Brand, Power, Price, Mileage, Type);
            
        }
        protected override void CalculateRate()
        {
            Console.WriteLine("Calculate Rate.");
           
            
        }

    }
}

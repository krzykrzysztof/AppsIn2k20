using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Sedan : Vehicle
    {
        
        protected int NumbersOfSeats { get; set; }
        protected string Type { get; set; }
        public Sedan(int Id, string Name, int Wheels, string Model, string Brand, double Power, double Price, double Mileage, string Type, int NumbersOfSeats) : base(Id, Name, Wheels, Model, Brand, Power, Price, Mileage)
        {
            this.Type = Type;
            this.NumbersOfSeats = NumbersOfSeats;
        }
        public Sedan()
        {

        }
        public override void ShowVehicle()
        {
            Console.WriteLine("Id: {0}\nName: {1}\nWheels: {2}\nModel: {3}\nBrand: {4}\nPower: {5}\nPrice: {6}\nMileage: {7}\nType: {8}\nNumbersOfSeats: {9}\n-------", Id, Name, Wheels, Model, Brand, Power, Price, Mileage, Type, NumbersOfSeats);
        }

        protected override void CalculateRate()
        {
            Console.WriteLine("Calculate Rate.");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
   abstract class Vehicle
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public int Wheels { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public double Power { get; set; }
        public double Mileage { get; set; }

        abstract protected void CalculateRate();
        abstract public void ShowVehicle();
        protected Vehicle(int Id, string Name, int Wheels, string Model, string Brand, double Power, double Price, double Mileage)
        {
            this.Id = Id;
            this.Name = Name;
            this.Wheels = Wheels;
            this.Model = Model;
            this.Brand = Brand;
            this.Price = Price;
            this.Power = Power;
            this.Mileage = Mileage;
        }
        public Vehicle()
        {
                
        }
    }


}

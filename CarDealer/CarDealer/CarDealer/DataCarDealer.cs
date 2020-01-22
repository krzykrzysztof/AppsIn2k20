using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class DataCarDealer
    {
        public DataCarDealer()
        {

        }
        public readonly Hatchback[] hatchbackTab =
            {
                new Hatchback(1, "A3", 4, "V8", "Audi", 200, 200000, 500, "Hatchback" ),
                new Hatchback(2, "A3", 4, "P8", "Audi", 102, 15000, 5000, "Hatchback" ),
                new Hatchback(3, "C", 4, "CLS", "Mercedes", 200, 350000, 1200, "Hatchback" ),
                
            };
        public readonly Sedan[] sedanTab =
        {
            new Sedan(1,"A4",4,"B9","Audi",300,500000,10,"Sedan",5),
            new Sedan(2,"A5",4,"A5","Audi",300,500000,10,"Sedan",5),
            new Sedan(3,"E20",4,"M3","BMW",300,500000,10,"Sedan",5),
        };
        public readonly Suv[] suvTab =
        {
            new Suv(1,"CLS", 4, "E-Klasa", "Mercedes", 300, 300000, 20000, "Suv", 6, 50),
            new Suv(2,"ML", 4, "S-Klasa", "Mercedes", 200, 450000, 220000, "Suv", 5, 20),
            new Suv(3,"G", 4, "C-Klasa", "Mercedes", 250, 20000, 250000, "Suv", 5, 35),
        };
        public void ShowSuvTab()
        {
            foreach (var item in suvTab)
            {
                item.ShowVehicle();
            }
        }
        public  void ShowSedanTab()
        {
            foreach (var item in sedanTab)
            {
                item.ShowVehicle();
            }
        }
        public void ShowHatchback()
        {
            foreach (var item in hatchbackTab)
            {
                item.ShowVehicle();
            }
        }


    }
}

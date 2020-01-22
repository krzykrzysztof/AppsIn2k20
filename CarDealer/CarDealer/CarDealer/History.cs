using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class History : DataCarDealer, ICalcualteRate
    {
       

        public void CalculateRate(Vehicle car)
        {
            
            int installment;
            double Result;
            double FullCost;
            double OwnContribution;
            Console.WriteLine("Welcome in Rate Calculator");
            Console.WriteLine("Our procnet is 5.");
            Console.WriteLine("Enter a data.");
            Console.WriteLine("Own contribution: ");
            OwnContribution = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many installmentss: ");
            installment = Convert.ToInt16(Console.ReadLine());
            Result = ((car.Price / installment) + car.Price * 5 / 100) - (OwnContribution/installment);
            FullCost = Result * installment - installment;
            Console.Clear();
            Console.WriteLine("OwnContribution: {0} ZŁ", OwnContribution);
            Console.WriteLine("Installments: {0}Months", installment);
            Console.WriteLine("Installments cost: {0} ZŁ", Result);
            Console.WriteLine("Cost of the car: {0} ZŁ", car.Price);
            Console.WriteLine("Full cost: {0} ZŁ", FullCost);
            Console.WriteLine("Press any button to countiune");
            Console.ReadLine();
          

        }

        public void ChooseYourCarType()
        {
            try
            {
                int Choose2;
                int Choose;
                Console.WriteLine("Hi :)");
                Console.WriteLine("Do you want buy\n1.Sedan\n2.Suv\n3.Hatchback");
                Choose = Convert.ToInt32(Console.ReadLine());
                while (Choose != 1 && Choose!=2 && Choose !=3)
                {
                    Console.Clear();
                    Console.WriteLine("Bad number.");
                    Console.WriteLine("Do you want buy\n1.Sedan\n2.Suv\n3.Hatchback");
                    Choose = Convert.ToInt32(Console.ReadLine());
                }

                if (Choose == 1)
                {
                    Console.Clear();
                    ShowSedanTab();
                    Console.WriteLine("Which Sedan Do you want Buy (Id): ");
                    Choose2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    while (Choose2 != 1 && Choose2 != 2 && Choose2 != 3)
                    {
                        Console.Clear();
                        ShowSedanTab();
                        Console.WriteLine("Bad number.");
                        Console.WriteLine("Which Sedan Do you want Buy(Id): ");
                        Choose2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    if (true)
                    {
                        foreach (var item in sedanTab.Where(p => p.Id == Choose2))
                        {
                            item.ShowVehicle();
                            Console.WriteLine("Press any button to contntiue.");
                            Console.ReadLine();
                            CalculateRate(item);
                        }
                    }

                }
                else if (Choose == 2)
                {
                    Console.Clear();
                    ShowSuvTab();
                    Console.WriteLine("Which Suv Do you want Buy (Id): ");
                    Choose2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    while (Choose2 != 1 && Choose2 != 2 && Choose2 != 3)
                    {
                        Console.Clear();
                        ShowSuvTab();
                        Console.WriteLine("Bad number.");
                        Console.WriteLine("Which Suv Do you want Buy(Id): ");
                        Choose2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    if (true)
                    {
                        foreach (var item in suvTab.Where(p => p.Id == Choose2))
                        {
                            item.ShowVehicle();
                            Console.WriteLine("Press any button to contntiue.");
                            Console.ReadLine();
                            CalculateRate(item);
                        }
                    }
                }
                else if (Choose == 3)
                {
                    Console.Clear();
                    ShowHatchback();
                    Console.WriteLine("Which Hatchback Do you want Buy (Id): ");
                    Choose2 = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                    while (Choose2 != 1 && Choose2 != 2 && Choose2 != 3)
                    {
                        Console.Clear();
                        ShowHatchback();
                        Console.WriteLine("Bad number.");
                        Console.WriteLine("Which Hatchback Do you want Buy(Id): ");
                        Choose2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    if (true)
                    {
                        foreach (var item in hatchbackTab.Where(p => p.Id == Choose2))
                        {
                            item.ShowVehicle();
                            Console.WriteLine("Press any button to contntiue.");
                            Console.ReadLine();
                            CalculateRate(item);
                        }
                    }

                }
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any button to exit.");
                Console.ReadLine();
            }


        }
    }
}

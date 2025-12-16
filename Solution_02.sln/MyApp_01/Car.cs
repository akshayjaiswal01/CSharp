using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_01
{
    public class Car : Vehicle
    {
        String fueltype;

        public Car(String brand, String model, int year, String fuelType) : base(brand, model, year)
        {
            this.fueltype = fuelType;
            Console.WriteLine("Car constructor called");
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Fuel type : {0}", fueltype);
        }
    }
}

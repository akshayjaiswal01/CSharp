using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_01
{
    public class ElectricCar : Vehicle
    {
        int batteryCapacity;

        public ElectricCar(String brand, String model, int year ,int batteryCapacity) : base(brand, model, year)
        {
            this.batteryCapacity = batteryCapacity;
            Console.WriteLine("ElectricCar constructor called");
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Battery Capacity: {0}", batteryCapacity);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_01
{
    public class Vehicle
    {
        String brand;
        String model;
        int year;

        public Vehicle(String brand, String model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;

            Console.WriteLine("Vehicle constructor called");
        }  
        
        public virtual void display()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, Year: {2}", brand, model, year);
        }
    }
}

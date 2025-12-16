using System.Xml.Serialization;

namespace MyApp_01
{
    public class Program
    {
        private static string fuelType;

        static void Main(string[] args)
        {

            #region implicit type casting
            //int x = 100;

            //long y = x;

            //float z = y;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            #endregion

            #region explicit type casting
            //double d = 200;
            //int x = Convert.ToInt32(d);

            //int y = 10;
            //String str = Convert.ToString(y);

            //Console.WriteLine(d);
            //Console.WriteLine(x);

            //Console.WriteLine(y);
            //Console.WriteLine(str);

            //Object obj1 = new object();
            //String str1 = "something";

            //obj1 = str1;
            //Console.WriteLine(obj1);

            //String str2 = Convert.ToString(obj1);
            //Console.WriteLine(str2);



            #endregion



            int choice;

            do
            {
                Console.WriteLine(" 1. Car \n 2. Electrict Car \n 3. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Brand Name: ");
                        String brand = Console.ReadLine();

                        Console.WriteLine("Enter Model Name: ");
                        String model = Console.ReadLine();

                        Console.WriteLine("Enter Year");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Fuel Type: ");
                            String fuelType = Console.ReadLine();

                            Car car = new Car(brand, model, year, fuelType);
                            car.display();

                        break;


                    case 2:

                        Console.WriteLine("Enter Brand Name: ");
                        String ebrand = Console.ReadLine();

                        Console.WriteLine("Enter Model Name: ");
                        String emodel = Console.ReadLine();

                        Console.WriteLine("Enter Year");
                        int eyear = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Battery Capacity: ");
                        int batteryCapacity = Convert.ToInt32(Console.ReadLine());

                        ElectricCar ec = new ElectricCar(ebrand, emodel, eyear, batteryCapacity);

                        ec.display();
                        

                        break;

                    case 3:
                        Console.WriteLine("Thank You");

                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            }
            while (choice != 3);
            

            
        }
    }
}

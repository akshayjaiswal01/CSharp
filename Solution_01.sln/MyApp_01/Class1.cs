using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_01
{
    internal class Class1
    {
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }

        public Boolean checkPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

           for(int i= 2; i < num; i++)
           {
                if(num % i == 0)
                {
                    return false;
                }
           }

            return true;
        }

       public 

    }
}

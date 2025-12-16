using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class OracleServer : IDatabase
    {
        public void delete()
        {
            Console.WriteLine("Record deleted from oracle server");
        }

        public void insert()
        {
            Console.WriteLine("Record inserted in oracle server");
        }

        public void update()
        {
            Console.WriteLine("Record updated in oracle server");
        }
    }
}

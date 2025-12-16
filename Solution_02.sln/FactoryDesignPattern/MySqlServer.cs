using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class MySqlServer : IDatabase
    {
        public void delete()
        {
            Console.WriteLine("Record deleted from mysql server");
        }

        public void insert()
        {
            Console.WriteLine("Record inserted in mysql server");
        }

        public void update()
        {
            Console.WriteLine("Record updated in mysql server");
        }
    }
}

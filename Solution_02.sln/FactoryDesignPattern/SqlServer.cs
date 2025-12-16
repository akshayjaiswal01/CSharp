using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class SqlServer : IDatabase

    {
        public void delete()
        {
            Console.WriteLine("Record deleted from sql server");
        }

        public void insert()
        {
            Console.WriteLine("Record inserted in sql server");
        }

        public void update()
        {
            Console.WriteLine("Record updated in sql server");
        }
    }
}

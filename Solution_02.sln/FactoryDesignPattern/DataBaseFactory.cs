using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class DataBaseFactory
    {
        public IDatabase getSomeDatabase(int dbChoice)
        {
            IDatabase db = null;

            switch(dbChoice)
            {
                case 1:
                    db = new MySqlServer();
                    break;

                case 2:
                    db = new SqlServer();
                    break;

                case 3:
                    db = new OracleServer();
                    break;

                default:
                    db = null;
                    break;
            }

            return db;
        }

        



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Works_DI03
{
    public class AccesDatabase
    {
        public static ProductModel GetProductModel(int producctID)
        {
            string connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" providerName = "System.Data.SqlClient";
            return null;
        }
    }
}

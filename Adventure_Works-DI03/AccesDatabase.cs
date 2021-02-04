using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Adventure_Works_DI03
{
    public class AccesDatabase
    {
        private static List<ProductModel> productModels;
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static Random rand = new Random();

        public static ProductModel getProductModel(int producctID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string select_productModel = "EXEC sp_getProductModel " + producctID;
                var productModel = conn.Query<ProductModel>(select_productModel).FirstOrDefault();
                return productModel;
            }      
        }

        public static int getProductModel_ID()
        {
            List<int> ids = new List<int>();
            int randomID = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string selct_productModelID = "EXEC sp_getProductModel_ID";
                ids = conn.Query<int>(selct_productModelID).ToList();

                randomID = ids[rand.Next(ids.Count)];
                return randomID;
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Diagnostics;

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
                randomID = ids[rand.Next(0, ids.Count)];
                return randomID;
            } 
        }

        public static List<Product> getProductModel_Sizes(int producctID)
        {
            List<Product> ProductSizes = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string select_PMsizes = "EXEC sp_getProductModel_Size " + producctID;
                var productsQuery = conn.Query<Product>(select_PMsizes);

                List<string> result = new List<string>();
                foreach(var size in productsQuery)
                {
                    bool duplicate = false;
                    foreach (var product in ProductSizes)
                    {
                        if (product.Size == size.Size)
                        {
                            // This is a duplicate.
                            duplicate = true;
                            break;
                        }
                    }
                    // If not duplicate, add to result.
                    if (!duplicate)
                    {
                        ProductSizes.Add(size);
                    }

                }
            }
            return ProductSizes;
        }
    }
} 

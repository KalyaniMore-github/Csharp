using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp18
{
    public class BulkClassExample
    {
        private readonly string connectionString(string connectionString);
        public BulkInsertExample(string connectionString)
        {
            this.connectionString=connectionString;
        }
        public void BulkInsertProducts(IEnumerable<Product>products)
        {
            using(var connection=new SqlConnection(connectionString))
            {
                connection.Open();
                var datatable = new DataTable();
                datatable.Columns.Add("Name",typeof(string));
                datatable.Columns.Add("Price", typeof(string));
                foreach(var product in products) {
                    datatable.Rows.Add(product.Name,product.Price);
                }
                using (var bulkcopy = newSqlBulkCopy(connection))
                {
                    bulkcopy.DestinationTableName="Products";
                    bulkcopy.WriteToServer(datatable);
                }

            }
        }
    }
}

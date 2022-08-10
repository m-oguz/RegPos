using RegPos.DataAccess.Abstract;
using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.DataAccess.Concrete.SQLDatabase
{
    internal class ProductDal : IProductDal
    {
        List<Product> products;
        public void Add(Product product)
        {
            using (SqlConnection conn = new SqlConnection())
            {


                conn.ConnectionString =
                  "Data Source=regpos.database.windows.net;" +
                  "Initial Catalog=regpos;" +
                  "User id=regpos;" +
                  "Password=ziX5/*>>1q";
                conn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "Insert into Products (ProductId, ProductName, BarCode, CategoryId, UnitPrice, VatGroupId, Details, PhotoLink ) values ( " +
                        product.ProductId + ", \'" +
                        product.ProductName + "\', " +
                        product.BarCode + ", " +
                        product.CategoryId + ", " +
                        product.UnitPrice + ", " +
                        product.VatGroupId + ", \'" +
                        product.Details + "\', \'" +
                        product.PhotoLink + "\');";
                command = new SqlCommand(sql, conn);
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Successfully.");
            }

            void Delete(Product product)
            {

            }

            List<Product> GetAll()
            {
                return products;

            }

            List<Product> GetbyCategoryId(int categoryId)
            {
                return products.Where(p => p.CategoryId == categoryId).ToList();
            }

            void Update(Product product)
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetbyCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
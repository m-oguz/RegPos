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
    internal class CategoryDal : ICategoryDal
    {
        public void Add(Category category)
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
                string sql = "Insert into Categories (CategoryId, CategoryName, IsSubCategoryOf, Details ) values ( " +
                        category.CategoryId + ", \'" +
                        category.CategoryName + "\', " +
                        category.SubCategoryOf + ", \'" +
                        category.Details + "\');";
                command = new SqlCommand(sql, conn);
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Successfully.");
            }

            void Delete(Category category)
            {
                throw new NotImplementedException();
            }

            List<Category> GetAll()
            {
                throw new NotImplementedException();
            }

            void Remove(Category category)
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

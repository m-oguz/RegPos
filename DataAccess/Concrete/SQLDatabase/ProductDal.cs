using RegPos.DataAccess.Abstract;
using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
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

        }

        public void Delete(Product product)
        {

        }

        public List<Product> GetAll()
        {
            return products;

        }

        public List<Product> GetbyCategoryId(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

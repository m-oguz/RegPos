using RegPos.Business.Abstract;
using RegPos.DataAccess.Abstract;
using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.Business.Concrete
{
    internal class ProductManager : IProductService
    {
        IProductDal _productDal;


        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();


        }
    }
}

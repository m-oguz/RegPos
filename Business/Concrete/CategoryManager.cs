using RegPos.Business.Abstract;
using RegPos.DataAccess.Abstract;
using RegPos.DataAccess.Concrete.SQLDatabase;
using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegPos.Business.Concrete
{
    internal class CategoryManager : ICategoryService
    {
        
   
        public void Add(Category category)
        {
            CategoryDal categoryDal = new CategoryDal();
            categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

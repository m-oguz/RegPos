using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.DataAccess.Abstract
{
    internal interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        void Delete(Category category);
    }
}

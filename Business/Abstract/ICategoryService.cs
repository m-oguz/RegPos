using RegPos.DataAccess.Abstract;
using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.Business.Abstract
{
    internal interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);

    }
}

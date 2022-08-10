using RegPos.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.Entities.Concrete
{
    internal class Category : IEntity
    {
        public string CategoryName { get; set; }
        public int SubCategoryOf { get; set; }
        public bool IsActive { get; set; }
        public string Details { get; set; }
        public string PhotoLink { get; set; }





    }
}

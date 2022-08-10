using RegPos.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.Entities.Concrete
{
    internal class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BarCode { get; set; }
        public int CategoryId { get; set; }
        public double UnitPrice { get; set; }
        public int VatGroupId { get; set; }
        public bool IsActive { get; set; }
        public string Details { get; set; }
        public string PhotoLink { get; set; }



    }
}

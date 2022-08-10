using RegPos.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.Entities.Concrete
{
    internal class VatRate : IEntity
    {
        public string GroupName { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public string Details { get; set; }
    }
}

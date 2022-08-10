using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.DataAccess.Abstract
{
    internal interface IVatRateDal
    {
        List<VatRate> GetAll();
        void Add(VatRate vatRate);
        void Update(VatRate vatRate);
        void Delete(VatRate vatRate);
    }
}

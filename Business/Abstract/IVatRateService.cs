﻿using RegPos.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegPos.Business.Abstract
{
    internal interface IVatRateService
    {
        List<VatRate> GetAll();

    }
}

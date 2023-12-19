﻿using Soild.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.core.Service
{
    public interface IInservice
    {

        IEnumerable<Invoicing> GetAllInvoicings();

        Invoicing GetIdInvoicings(string id);
    }
}

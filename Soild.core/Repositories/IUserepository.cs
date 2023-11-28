using Soild.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.core.Repositories
{
    public interface IUserepository
    {
         List<Invoicing> GetAllInvoicings();
        List<Customers> GetAllCustomers();
        //TODO ID
        Invoicing GetIdCustomers(int id);
        Invoicing GetByIdInvoicings(int id);
    }
}

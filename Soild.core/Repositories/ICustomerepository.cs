using Soild.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.core.Repositories
{
    public interface ICustomerepository
    {
        
        List<Customers> GetAllCustomers();
        Customers GetIdCustomers(string id);
        int CountCustomers();



    }
}

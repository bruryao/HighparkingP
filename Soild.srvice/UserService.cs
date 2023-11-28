using Soild.core.Repositories;
using Soild.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.srvice
{
    public class UserService: IUserepository
    {
        private readonly IUserepository _irepository;

        public object ListCustomer { get; set; }

        public UserService(IUserepository irepository)
        {
            _irepository = irepository;

        }
        public List<Invoicing> GetInvoicings()
        {
            //TODO logic busyness
            return _irepository.GetAllInvoicings();
        }
        public List<Customers> GetCustomers()
        {
            return _irepository.GetAllCustomers();
        }

        public List<Invoicing> GetAllInvoicings()
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Invoicing GetIdCustomers(int id)
        {
            throw new NotImplementedException();
        }

        public Invoicing GetByIdInvoicings(int id)
        {
            throw new NotImplementedException();
        }
    }
}

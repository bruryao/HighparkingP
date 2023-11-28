using Soild.core.Entities;
using Soild.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.data.Repositories
{
    public class Userepository  : IUserepository
    {

        private readonly DataContext _context;
        public Userepository(DataContext context)
        {
            _context = context;
        }
        public List<Invoicing> GetAllInvoicings() {
            return _context.ListInvoicing;
            
        }
        public List<Customers> GetAllCustomers()
        {
            return _context.ListCustomer;

        }
        public Customers GetIdCustomers(int id)
        {
            return _context.ListCustomer.Find(i => i.Id.Equals(id));
        }
        public Invoicing GetIdInvoicings(int id)
        {
            return _context.ListInvoicing.Find(i => i.Id.Equals(id));
        }

        public Invoicing GetIdCustomers(string id)
        {
            throw new NotImplementedException();
        }

        public Invoicing GetByIdInvoicings(string id)
        {
            throw new NotImplementedException();
        }

        Invoicing IUserepository.GetIdCustomers(int id)
        {
            throw new NotImplementedException();
        }

        public Invoicing GetByIdInvoicings(int id)
        {
            throw new NotImplementedException();
        }
    }
}

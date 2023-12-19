using Soild.core.Entities;
using Soild.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.data.Repositories
{
    public class Customerrepositories:ICustomerepository
    {
        private readonly DataContext _context;
        public Customerrepositories(DataContext context)
        {
            _context = context;
        }
        public List<Customers> GetAllCustomers()
        {
            return _context.ListCustomer;

        }
        public Customers GetIdCustomers(string id)
        {
            return _context.ListCustomer.First(i => i.Id.Equals(id));
        }
        public int CountCustomers()
        {
            int count = _context.ListCustomer.Count;
            return count;
        }
    }
}

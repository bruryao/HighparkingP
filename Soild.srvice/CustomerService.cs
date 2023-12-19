using Soild.core.Entities;
using Soild.core.Repositories;
using Soild.core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.srvice
{
    public
        class CustomerService: ICustumerservice
    {
        private readonly ICustomerepository _cRepository;
        public CustomerService(ICustomerepository cRepository)
        {
            _cRepository = cRepository;
        }

        public Customers GetIdCustomers(string id)
        {

            return _cRepository.GetAllCustomers().First(u => u.Equals(id));

        }



        public IEnumerable<Customers> GetAllCustomers()
        {
            return _cRepository.GetAllCustomers();
        }
    }
}

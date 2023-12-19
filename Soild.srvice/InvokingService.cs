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
    public class InvokingService: IInservice
    {
        private readonly IInrepostory _invoicingRepository;
        public InvokingService(IInrepostory invoicingRepository)
        {
            _invoicingRepository = invoicingRepository;
        }

        public Invoicing GetIdInvoicings(string id)
        {

            return _invoicingRepository.GetAllInvoicings().First(u => u.Id.Equals(id));

        }



        public IEnumerable<Invoicing> GetAllInvoicings()
        {
            return _invoicingRepository.GetAllInvoicings();
        }
    }
}

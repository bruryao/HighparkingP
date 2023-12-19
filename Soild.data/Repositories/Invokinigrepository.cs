using Soild.core.Entities;
using Soild.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.data.Repositories
{
    public class Invokinigrepository:IInrepostory

    {

        private readonly DataContext _context;
        public Invokinigrepository(DataContext context)
        {
            _context = context;
        }

     

        public List<Invoicing> GetAllInvoicings() {
            return _context.ListInvoicing;
            
        }

        public Invoicing GetIdInvoicings(string id)
        {
            return _context.ListInvoicing.Find(i => i.Id.Equals(id));
        }
         public int CountInvoicings()
            {
                int count = _context.ListInvoicing.Count;
                return count;
          }
       

       
    }
}

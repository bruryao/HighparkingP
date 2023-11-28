using Soild.core.Entities;

namespace Soild.data
{
    public interface Idatacontext
    {
        public List<Invoicing> ListInvoicing { get; set; }
        public List<Customers> ListCustomer { get; set; }
    }
}

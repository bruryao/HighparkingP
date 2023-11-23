using HighparkingProject.Entities;

namespace HighparkingProject
{
    public interface Idatacontext
    {
        public List<Invoicing> ListInvoicing { get; set; }
        public List<Customers> ListCustomer { get; set; }
    }
}

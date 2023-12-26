using Microsoft.EntityFrameworkCore;
using Soild.core.Entities;
using System.Drawing;
using System.Xml.Linq;

namespace Soild.data
{
    public class DataContext:DbContext //todoהזרקת תליות של entites      : Idatacontext
    {
        public DbSet<Invoicing> ListInvoicing { get; set; }
        public DbSet<Customers> ListCustomer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=bruryao_db");   
        }



        //public DataContext()
        //{
        //    ListCustomer = new List<Customers>();
        //    ListInvoicing = new List<Invoicing>();
        //    ListCustomer.Add(new Customers { Id = "0", Name = "Adam", Phon = "055", Mail = "", Code = 122, Credit = "", Bit = "654", Kind = Status.Regular, Point = 0 });
        //    ListInvoicing.Add(new Invoicing { });
        //}

    }

}

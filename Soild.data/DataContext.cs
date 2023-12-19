﻿using Soild.core.Entities;
using System.Drawing;
using System.Xml.Linq;

namespace Soild.data
{
    public class DataContext //todoהזרקת תליות של entites      : Idatacontext
    {
        public List<Invoicing> ListInvoicing { get; set; }
        public List<Customers> ListCustomer { get; set; }


        public DataContext()
        {
            ListCustomer = new List<Customers>();
            ListInvoicing = new List<Invoicing>();
            ListCustomer.Add(new Customers { Id = "0", Name = "Adam", Phon = "055", Mail = "", Code = 122, Credit = "", Bit = "654", Kind = Status.Regular, Point = 0 });
            ListInvoicing.Add(new Invoicing { });
        }

    }

}

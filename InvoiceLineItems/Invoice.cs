using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceLineItems
{
    public class Invoice
	{
        //Invoice class that corresponds to the "Invoices" table in MMABooks database
		public Invoice() { }

        public int InvoiceID { get; set; }

        public int CustomerID { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal ProductTotal { get; set; }

        public decimal SalesTax { get; set; }

        public decimal Shipping { get; set; }

        public decimal InvoiceTotal { get; set; }
	}
}

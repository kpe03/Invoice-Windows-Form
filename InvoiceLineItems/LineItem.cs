using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceLineItems
{
    public class LineItem
    {
        //LineItem class that corresponds with the LineItems table in MMABooks database
        public LineItem() { }

        public int InvoiceID { get; set; }

        public string ProductCode { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal ItemTotal { get; set; }
    }
}

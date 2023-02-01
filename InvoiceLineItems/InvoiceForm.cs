using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InvoiceLineItems
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create LineItem list, get all LineItem data from database
            List<LineItem> list = new List<LineItem>();
            list = LineItemDB.GetLineItems();

            //Create an Invoice list, get all the Invoice data from database
            List<Invoice> invoiceList = new List<Invoice>();
            invoiceList = InvoiceDB.GetInvoices();

            //join data from lineitem and invoice 
            //get only data for ProductCode, Quantity, Item Total, Invoice Data, and Invoice Total
            var lineItemList = from line in list
                               join invoice in invoiceList
                               on line.InvoiceID equals invoice.InvoiceID
                               orderby invoice.InvoiceDate descending
                               select new
                               {
                                   line.InvoiceID,
                                   invoice.InvoiceDate,
                                   invoice.InvoiceTotal,
                                   line.ProductCode,
                                   line.UnitPrice,
                                   line.Quantity,
                                   line.ItemTotal

                               };

            //execute query and load results into the ListView control
            int invoiceID = 0;  //variable to hold the invoice ID
            int i = 0;  //variable to loop through the lineItemList
            foreach(var line in lineItemList)
            {
                //don't erase the invoice ID if there is only one invoice with that ID.
                if (line.InvoiceID != invoiceID)
                {
                    lvInvoices.Items.Add(line.InvoiceID.ToString());
                    invoiceID = line.InvoiceID;
                }
				//if two invoices have the same ID, erase the ID on the other ones.
				else
				{
                    lvInvoices.Items.Add("");
                }
                //add each property to the list view control
                lvInvoices.Items[i].SubItems.Add(Convert.ToDateTime(
                    line.InvoiceDate).ToShortDateString());
                lvInvoices.Items[i].SubItems.Add(line.InvoiceTotal.ToString("c"));
                lvInvoices.Items[i].SubItems.Add(line.ProductCode.ToString());
                lvInvoices.Items[i].SubItems.Add(line.UnitPrice.ToString("c"));
                lvInvoices.Items[i].SubItems.Add(line.Quantity.ToString());
                lvInvoices.Items[i].SubItems.Add(line.ItemTotal.ToString("c"));
                i += 1;
            }
            
        }
    }
}

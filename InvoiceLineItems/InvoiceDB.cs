using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceLineItems
{
    public static class InvoiceDB
    {
        public static List<Invoice> GetInvoices()
        {
            //create a list that holds Invoice objects
            List<Invoice> invoices = new List<Invoice>();
            //connect to database
            SqlConnection connection = MMABooksDB.GetConnection();

            //select from all columns of Invoices table
            string selectStatement
                = "SELECT * FROM Invoices";
            //create select command
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                //reader command
                SqlDataReader invoiceReader =
                    selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                //read each row of Invoices table, set each item to respective Invoice property
                while (invoiceReader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceID = (int)invoiceReader["InvoiceID"];
                    invoice.CustomerID = (int)invoiceReader["CustomerID"];
                    invoice.InvoiceDate = (DateTime)invoiceReader["InvoiceDate"];
                    invoice.ProductTotal = (decimal)invoiceReader["ProductTotal"];
                    invoice.SalesTax = (decimal)invoiceReader["SalesTax"];
                    invoice.Shipping = (decimal)invoiceReader["Shipping"];
                    invoice.InvoiceTotal = (decimal)invoiceReader["InvoiceTotal"];
                    //finally add object to the list
                    invoices.Add(invoice);
                }
                //close reader
                invoiceReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //return the list of invoices
            return invoices;
        }

    }
}

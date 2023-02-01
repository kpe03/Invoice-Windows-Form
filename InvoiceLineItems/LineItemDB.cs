using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceLineItems
{
    public class LineItemDB
    {
        public static List<LineItem> GetLineItems()
        {
            //create a List that holds LineItem objects
            List<LineItem> lineItems = new List<LineItem>();
            //connect to database
            SqlConnection connection = MMABooksDB.GetConnection();

            //select all columns from the Invoice Line Items table
            string selectStatement
                = "SELECT * FROM InvoiceLineItems";
            //create select command
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                //create reader command
                SqlDataReader lineItemReader =
                    selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                //read each row of the table. set each item to the respective property of LineItem
                while (lineItemReader.Read())
                {
                    LineItem lineItem = new LineItem();
                    lineItem.InvoiceID = (int)lineItemReader["InvoiceID"];
                    lineItem.ProductCode = lineItemReader["ProductCode"].ToString();
                    lineItem.UnitPrice = (decimal)lineItemReader["UnitPrice"];
                    lineItem.Quantity = (int)lineItemReader["Quantity"];
                    lineItem.ItemTotal = (decimal)lineItemReader["ItemTotal"];
                    //add the object to the list
                    lineItems.Add(lineItem);
                }
                //close reader
                lineItemReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //return the list of items
            return lineItems;
        }

    }
}

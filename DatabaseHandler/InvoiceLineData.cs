using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class InvoiceLineData
    {
        public int getinvoiceno()
        {
            int invoiceno = 0;
            try
            {

                using (kingtopEntities context = new kingtopEntities())
                {
                    invoiceno = (from record in context.invoicelines select record.invoiceno).ToList().Max();
                }
            }
            catch (Exception ex)
            {

            }
            return invoiceno;
        }
    }
}

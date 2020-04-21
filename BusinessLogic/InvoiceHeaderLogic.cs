using DatabaseHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InvoiceHeaderLogic
    {
        InvoiceHeaderData head = new InvoiceHeaderData();
        public int getinvoiceno()
        {
            return head.getinvoiceno();
        }
    }
}

using DatabaseHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InvoiceLineLogic
    {
        InvoiceLineData line = new InvoiceLineData();
        public int getinvoiceno()
        {
            return line.getinvoiceno();
        }
    }
}

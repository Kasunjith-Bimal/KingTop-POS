using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InvoiceHeaderDTO
    {
        public int invoiceno { get; set; }
        public string invoicedate { get; set; }
        public decimal totaldiscount { get; set; }
        public decimal totalprice { get; set; }
    }
}

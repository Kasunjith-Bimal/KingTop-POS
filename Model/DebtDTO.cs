using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DebtDTO
    {
        public int debtno { get; set; }
       // public int invoiceno { get; set; }
        public int customerid { get; set; }
        public string cusname { get; set; }
        public decimal debttotal { get; set; }
        //public string dates { get; set; }
       // public string username { get; set;}
    }
}

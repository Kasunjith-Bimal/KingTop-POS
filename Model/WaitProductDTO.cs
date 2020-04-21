using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class WaitProductDTO
    {
        public string barcode { get; set; }
        public string productid { get; set; }
        public string description { get; set; }
        public decimal quantity { get; set; }
        public int waitno { get; set; }
        
        public decimal sellingprice { get; set; }
        
        public decimal total { get; set; }
        public decimal discountprice { get; set; }
        public decimal lastprice { get; set; }
        public decimal discountsp { get; set; }



    }
}

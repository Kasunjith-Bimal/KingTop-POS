using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductDTO
    {
        public int barcode { get; set; } 
       public string productid { get; set; }
       public string description { get; set; }
       public int quantity { get; set; }
       public string expiredate { get; set; }
       public decimal purchaseprice { get; set; }
       public decimal sellingprice { get; set; }
       public Nullable<decimal> discountprice { get; set; }
       public Nullable<int> discountquantity { get; set; } 
       public decimal  total {get;set;}
       public decimal lastprice { get; set; }
       public decimal discountsp { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseHandler
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoiceline
    {
        public int invoiceno { get; set; }
        public string productid { get; set; }
        public string description { get; set; }
        public decimal quantity { get; set; }
        public decimal sellingprice { get; set; }
        public decimal discountprice { get; set; }
        public decimal totalprice { get; set; }
        public string username { get; set; }
        public string lastprice { get; set; }
        public Nullable<decimal> discountsp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerDTO
    {
            public int CustomerID { get; set; }
            public String FullName { get; set; }
            public String Address { get; set; }
            public String NicNo { get; set; }
            public String Gender { get; set; }
            public String TelephoneNumber { get; set; }     
    }
}

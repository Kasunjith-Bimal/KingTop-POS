using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        public Decimal DrawerAmount { get; set; }
        public Decimal WithDrawerAmount { get; set; }
        public String Date { get; set; }
    }
}

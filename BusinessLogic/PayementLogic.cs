using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PayementLogic
    {
        PayementData db = new PayementData();
        public void Adddata(PaymentDTO obj)
        {

            try
            {
                db.AdddataDb(obj); 
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PaymentDTO> GetData()
        {
            try
            {
               return db.GetDataDb();
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public void updatepayemnt(PaymentDTO obj)
        {
            try
            {
                db.updatepayemntDb(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

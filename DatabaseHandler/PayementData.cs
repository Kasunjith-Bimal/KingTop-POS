using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class PayementData
    {
        public void AdddataDb(PaymentDTO obj)
        {

            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    PaymentDetail adddetails = new PaymentDetail();

                    adddetails.Drawer_Amount = obj.DrawerAmount;
                    adddetails.WithDrawer_Amount = obj.WithDrawerAmount;
                    adddetails.Date = obj.Date;

                    context.PaymentDetails.Add(adddetails);

                    context.SaveChanges();


                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public List<PaymentDTO> GetDataDb()
        {
            string todaydate = DateTime.Now.ToShortDateString();
            List<PaymentDTO> list = new List<PaymentDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<PaymentDetail> relist = (from recode in context.PaymentDetails where recode.Date == todaydate select recode).ToList();

                    foreach (PaymentDetail item in relist )
                    {
                        PaymentDTO obj = new PaymentDTO();
                        obj.PaymentId = item.Payment_Id;
                        obj.DrawerAmount = item.Drawer_Amount;
                        obj.WithDrawerAmount =Convert.ToDecimal(item.WithDrawer_Amount);
                        obj.Date = item.Date;
                        
                        list.Add(obj);


                    }


                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }

        public void updatepayemntDb(PaymentDTO obj)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    PaymentDetail update = (from recode in context.PaymentDetails where recode.Payment_Id == obj.PaymentId select recode).FirstOrDefault();

                    update.Date = obj.Date;
                    update.Drawer_Amount = obj.DrawerAmount;
                    update.WithDrawer_Amount = obj.WithDrawerAmount;

                    context.Entry(update).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();



                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

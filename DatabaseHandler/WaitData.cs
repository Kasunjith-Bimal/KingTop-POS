using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class WaitData
    {
        public void WaitInvoiceAdd(WaitDTO obj)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {

                    wait obj1 = new wait();
                    
                    obj1.username = obj.user;
                    obj1.dates = obj.dates;
                    context.waits.Add(obj1);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
        }

        public List<WaitDTO> GetWaitDatadb()
        {
            List<WaitDTO> list1 = new List<WaitDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<wait> waitlist = (from record in context.waits select record).ToList();
                    foreach (wait item in waitlist)
                    {
                        WaitDTO obj = new WaitDTO();
                        obj.waitno = item.waitno;
                        obj.dates = item.dates;
                        obj.user = item.username;
                        
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list1;
        }

        public List<InvoiceLineDTO> BillwaitDatadb(int inno)
        {
            List<InvoiceLineDTO> list1 = new List<InvoiceLineDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<invoiceline> prolist = (from record in context.invoicelines where record.invoiceno == inno select record).ToList();
                    foreach (invoiceline item in prolist)
                    {
                        InvoiceLineDTO obj = new InvoiceLineDTO();
                        obj.invoiceno = item.invoiceno;
                        obj.productid = item.productid;
                        obj.description = item.description;
                        obj.discountprice = item.discountprice;
                        obj.sellingprice = item.sellingprice;
                        obj.quantity = item.quantity;
                        obj.totalprice = item.totalprice;
                        //obj.lastprice = item.tot;
                        obj.user = item.username;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list1;
        }
        public void RemoveWaitdb(int wno)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    wait wpro = (from record in context.waits where (record.waitno == wno) select record).FirstOrDefault();
                    context.waits.Remove(wpro);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void WaitProductAdd(List<WaitProductDTO> list)
        {
            
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<waitproduct> wpro = new List<waitproduct>();
                    foreach (WaitProductDTO item in list)
                    {
                        waitproduct obj = new waitproduct();
                        obj.waitno = item.waitno;
                        obj.barcode = item.barcode;
                        obj.description = item.description;
                        obj.productid = item.productid;
                        obj.quantity = item.quantity;
                        obj.sellingprice = item.sellingprice;
                        obj.total = item.total;
                        obj.lastprice = item.lastprice;
                        obj.discountsp = item.discountsp;
                        context.waitproducts.Add(obj);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            
        }
        public int GetWaitno()
        {
            int waitno = 0;
            try
            {

                using (kingtopEntities context = new kingtopEntities())
                {
                    waitno = (from record in context.waits select record.waitno).ToList().Max();
                }
            }
            catch (Exception ex)
            {

            }
            return waitno;
        }
        public List<WaitProductDTO> GetBillBackdb(int waitno)
        {
            List<WaitProductDTO> list1 = new List<WaitProductDTO>();
            try
            {
                
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<waitproduct> list = (from record in context.waitproducts where record.waitno == waitno select record).ToList();
                    foreach (waitproduct item in list)
                    {
                        WaitProductDTO obj = new WaitProductDTO();
                        obj.barcode = item.barcode;
                        obj.waitno = item.waitno;
                        obj.productid = item.productid;
                        obj.description = item.description;
                        obj.quantity = item.quantity;
                        obj.sellingprice = item.sellingprice;
                        obj.discountprice = item.discountprice;
                        obj.total = item.total;
                        obj.lastprice = item.lastprice;
                        obj.discountsp = item.discountsp;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list1;
        }
        public void DeleteWaitdata(int waitno)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    wait wt1 = (from record in context.waits where (record.waitno == waitno) select record).FirstOrDefault();
                    context.waits.Remove(wt1);
                    List<waitproduct> wt2 = (from record in context.waitproducts where (record.waitno == waitno) select record).ToList();
                    context.waitproducts.RemoveRange(wt2);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

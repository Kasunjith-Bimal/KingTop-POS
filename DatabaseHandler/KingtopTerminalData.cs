using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
   public class KingtopTerminalData
    {
        public void AddInvoiceHeaderdb(InvoiceHeaderDTO obj)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    invoiceheader head = new invoiceheader();
                    head.invoicedate = obj.invoicedate;
                    head.totaldiscount = obj.totaldiscount;
                    head.totalprice = obj.totalprice;
                    context.invoiceheaders.Add(head);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void AddInvoiceLinedb(List<InvoiceLineDTO> list)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    foreach (InvoiceLineDTO item in list)
                    {
                        invoiceline line = new invoiceline();
                        line.invoiceno = item.invoiceno;
                        line.productid = item.productid;
                        line.description = item.description;
                        line.quantity = item.quantity;
                        line.sellingprice = item.sellingprice;
                        line.discountprice = item.discountprice;
                        line.totalprice = item.totalprice;
                        line.username = item.user;
                        context.invoicelines.Add(line);
                        context.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class DebtData
    {
        public void AddDebtdb(DebtDTO obj)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    debt db1 = new debt();
                    db1.customerid = obj.customerid;
                 // db1.dates = obj.dates;
                    db1.customername = obj.cusname;
                    db1.debtamount = obj.debttotal;
                   // db1.invoiceno = obj.invoiceno;
                   // db1.username = obj.username;
                    context.debts.Add(db1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public List<DebtDTO> GetDatadbDebt()
        {
            List<DebtDTO> list1 = new List<DebtDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<debt> dblist = (from record in context.debts select record).ToList();
                    foreach (debt item in dblist)
                    {
                        DebtDTO obj = new DebtDTO();
                       // obj.username = item.username;
                        obj.cusname = item.customername;
                        obj.customerid = Convert.ToInt32(item.customerid);
                       // obj.dates = item.dates;
                        obj.debttotal = item.debtamount;
                        obj.debtno = item.debtno;
                       // obj.invoiceno = Convert.ToInt32(item.invoiceno);

                        list1.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list1;
        }
        public List<DebtDTO> SearchDebt(int id)
        {
            List<DebtDTO> list1 = new List<DebtDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<debt> dblist = (from record in context.debts  where record.customerid == id  select record ).ToList();
                    foreach (debt item in dblist)
                    {
                        DebtDTO obj = new DebtDTO();
                        // obj.username = item.username;
                        obj.cusname = item.customername;
                        obj.customerid = Convert.ToInt32(item.customerid);
                        // obj.dates = item.dates;
                        obj.debttotal = item.debtamount;
                        obj.debtno = item.debtno;
                        // obj.invoiceno = Convert.ToInt32(item.invoiceno);

                        list1.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return list1;
        }
    }
}

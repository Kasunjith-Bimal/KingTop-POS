using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseHandler
{
    public class CustomerData
    {
        public List<CustomerDTO> GetData()
        {
            List<CustomerDTO> list1 = new List<CustomerDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<Customer> prod = (from record in context.Customers select record).ToList();
                    foreach (Customer item in prod)
                    {
                        CustomerDTO obj = new CustomerDTO();
                        obj.CustomerID = item.CustomerID;
                        obj.FullName = item.FullName;
                        obj.Address = item.Address;
                        obj.NicNo = item.NICNo;
                        obj.TelephoneNumber = item.TelNo;
                        obj.Gender = item.Gender;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return list1;
        }
        public void getUpdate(CustomerDTO cu)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    Customer update = (from recode in context.Customers where recode.CustomerID == cu.CustomerID select recode).FirstOrDefault();
                    update.FullName = cu.FullName;
                    update.Gender = cu.Gender;
                    update.NICNo = cu.NicNo;
                    update.TelNo = cu.TelephoneNumber;
                    update.Address = cu.Address;

                    context.Entry(update).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();


                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void AddData(CustomerDTO cusadd)
        {
            try
            {
                using (kingtopEntities n = new kingtopEntities())
                {
                    Customer cus = new Customer();
                    cus.FullName = cusadd.FullName;
                    cus.Address = cusadd.Address;
                    cus.Gender = cusadd.Gender;
                    cus.TelNo = cusadd.TelephoneNumber;
                    cus.NICNo = cusadd.NicNo;

                    n.Customers.Add(cus);
                    n.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public List<CustomerDTO> SearchDataID(int id)
        {
            List<CustomerDTO> list1 = new List<CustomerDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<Customer> prod = (from record in context.Customers where record.CustomerID==id select record).ToList();
                    foreach (Customer item in prod)
                    {
                        CustomerDTO obj = new CustomerDTO();
                        obj.CustomerID = item.CustomerID;
                        obj.FullName = item.FullName;
                        obj.Address = item.Address;
                        obj.NicNo = item.NICNo;
                        obj.TelephoneNumber = item.TelNo;
                        obj.Gender = item.Gender;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return list1;
        }

        public List<CustomerDTO> SearchDataName(String name)
        {
            List<CustomerDTO> list1 = new List<CustomerDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<Customer> prod = (from record in context.Customers where record.FullName.Contains(name) select record).ToList();
                    foreach (Customer item in prod)
                    {
                        CustomerDTO obj = new CustomerDTO();
                        obj.CustomerID = item.CustomerID;
                        obj.FullName = item.FullName;
                        obj.Address = item.Address;
                        obj.NicNo = item.NICNo;
                        obj.TelephoneNumber = item.TelNo;
                        obj.Gender = item.Gender;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return list1;
        }
    }
}

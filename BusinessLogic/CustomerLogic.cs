using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public  class CustomerLogic
    {
        CustomerData cuobj = new CustomerData();
        public List<CustomerDTO> GetData()
        {
            try
            {
               return cuobj.GetData();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void getUpdate(CustomerDTO cu)
        {
            try
            {
                cuobj.getUpdate(cu);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void addData(CustomerDTO culist)
        {
            cuobj.AddData(culist);
        }
        public List<CustomerDTO> SearchDataID(int id)
        {
            try
            {
                return cuobj.SearchDataID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<CustomerDTO> SearchDataName(String name)
        {
            try
            {
                return cuobj.SearchDataName(name);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
}
}

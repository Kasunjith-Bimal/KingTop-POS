using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WaitLogic
    {
        WaitData waitd = new WaitData();
        /*public void wait(WaitDTO obj)
        {
            waitd.WaitAdd(obj);
        }
         */
        public List<WaitDTO> GetWaitData()
        {
            return waitd.GetWaitDatadb();
        }
        
        public void RemoveWait(int inno)
        {
            waitd.RemoveWaitdb(inno);
        }
        public void WaitProductLast(List<WaitProductDTO> list)
        {
            waitd.WaitProductAdd(list);
        }
        public void WaitInvoice(WaitDTO obj)
        {
            waitd.WaitInvoiceAdd(obj);
        }
        public int GetWaitno()
        {
            return waitd.GetWaitno();
        }
        public List<WaitProductDTO> GetBillBack(int waitno)
        {
            return waitd.GetBillBackdb(waitno);
        }
        public void DeleteWaitData(int waitno)
        {
            waitd.DeleteWaitdata(waitno);
        }
    }
}

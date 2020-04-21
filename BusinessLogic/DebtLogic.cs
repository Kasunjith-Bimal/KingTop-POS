using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DebtLogic
    {
        DebtData db = new DebtData();
        public void AddDebt(DebtDTO obj)
        {
            db.AddDebtdb(obj);
        }
        public List<DebtDTO> GetDebt()
        {
            return db.GetDatadbDebt();
        }
        public List<DebtDTO> SearchDebt(int cusid)
        {
            return db.SearchDebt(cusid);
        }
    }
}

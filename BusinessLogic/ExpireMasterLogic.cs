using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    
    public class ExpireMasterLogic
    {

        ExpireMasterData prodata = new ExpireMasterData();

        public List<ProductDTO> GetData()
        {
            return prodata.GetData();
        }
        public List<ProductDTO> SearchbId(string bid)
        {
            return prodata.SearchbId(bid);
        }
        public List<ProductDTO> SearchId(string id)
        {
            return prodata.SearchId(id);
        }
        public List<ProductDTO> Searchdes(string des)
        {
            return prodata.Searchdes(des);
        }
        public List<string> SuggestProduct()
        {
            return prodata.SugesstProduct();
        }
    }
}

using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TerminalLogic
    {
        ProductData prodata = new ProductData();
        KingtopTerminalData termdata = new KingtopTerminalData();
        public List<ProductDTO> GetProduct(string barcode)
        {
            return prodata.SearchBarcodedbpro(barcode);
        }

        public void AddInvoiceHeader(InvoiceHeaderDTO obj)
        {
            termdata.AddInvoiceHeaderdb(obj);
        }
        public void AddInvoiceLine(List<InvoiceLineDTO> list)
        {
            termdata.AddInvoiceLinedb(list);
        }
        public List<ProductDTO> GetProductpro(string productid)
        {
            return prodata.SearchProductidbpro(productid);
        }
        public List<ProductDTO> GetDescriptionpro(string des)
        {
            return prodata.SearchDescriptionbpro(des);
        }
    }
}

using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductLogic
    {
        ProductData prodata = new ProductData();
        public void AddData(ProductDTO obj)
        {
            try
            {
                prodata.AddDatadbpro(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<ProductDTO> GetData()
        {
            try
            {
                return prodata.GetDatadbpro();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<ProductDTO> SearchBarcode(string id)
        {
            try
            {
                return prodata.SearchBarcodedbpro(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<ProductDTO> SearchDataname(string name)
        {
            try
            {
                return prodata.SearchDatanamedbpro(name);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<string> SuggestProductpro1()
        {
            try
            {
                return prodata.SugesstProductdbprodd();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<string> SuggestProduct()
        {
            try
            {
                return prodata.SugesstProductdbpro();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<ProductDTO> SearchId(string id)
        {
            try
            {
                return prodata.SearchIddbpro(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdateProduct(ProductDTO obj)
        {
            try
            {
                prodata.UpdateProductdbpro(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DeleteProduct(string proid)
        {
            try
            {
                prodata.DeleteProductdbpro(proid);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdateProAfterBill(ProductDTO obj)
        {
            prodata.UpdateQuantity(obj);
        }
    }
}

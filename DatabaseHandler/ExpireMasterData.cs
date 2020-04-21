using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class ExpireMasterData
    {

        public List<ProductDTO> GetData()
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 orderby record.expiredate select record).ToList();
                    foreach (product1 item in prod)
                    {
                        ProductDTO obj = new ProductDTO();
                        obj.productid = item.productid;
                        obj.barcode = item.barcode;
                        obj.description = item.description;
                        obj.quantity = item.quantity;
                        obj.expiredate = item.expiredate;
                        obj.sellingprice = item.sellingprice;
                        obj.purchaseprice = item.purchaseprice;
                        obj.discountprice = item.discountprice;
                        obj.discountquantity = item.discountquantity;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return list1;
        }


         public List<ProductDTO> SearchbId(string bid)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 where record.barcode==bid select record).ToList();
                    foreach (product1 item in prod)
                    {
                        ProductDTO obj = new ProductDTO();
                        obj.productid = item.productid;
                        obj.barcode = item.barcode;
                        obj.description = item.description;
                        obj.quantity = item.quantity;
                        obj.expiredate = item.expiredate;
                        obj.sellingprice = item.sellingprice;
                        obj.purchaseprice = item.purchaseprice;
                        obj.discountprice = item.discountprice;
                        obj.discountquantity = item.discountquantity;
                        list1.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return list1;
        }


         public List<ProductDTO> SearchId(string id)
         {
             List<ProductDTO> list1 = new List<ProductDTO>();
             try
             {
                 using (kingtopEntities context = new kingtopEntities())
                 {
                     List<product1> prod = (from record in context.product1 where record.productid == id select record).ToList();
                     foreach (product1 item in prod)
                     {
                         ProductDTO obj = new ProductDTO();
                         obj.productid = item.productid;
                         obj.barcode = item.barcode;
                         obj.description = item.description;
                         obj.quantity = item.quantity;
                         obj.expiredate = item.expiredate;
                         obj.sellingprice = item.sellingprice;
                         obj.purchaseprice = item.purchaseprice;
                         obj.discountprice = item.discountprice;
                         obj.discountquantity = item.discountquantity;
                         list1.Add(obj);
                     }
                 }
             }
             catch (Exception)
             {

             }
             return list1;
         }


         public List<ProductDTO> Searchdes(string des)
         {
             List<ProductDTO> list1 = new List<ProductDTO>();
             try
             {
                 using (kingtopEntities context = new kingtopEntities())
                 {
                     List<product1> prod = (from record in context.product1 where record.description == des select record).ToList();
                     foreach (product1 item in prod)
                     {
                         ProductDTO obj = new ProductDTO();
                         obj.productid = item.productid;
                         obj.barcode = item.barcode;
                         obj.description = item.description;
                         obj.quantity = item.quantity;
                         obj.expiredate = item.expiredate;
                         obj.sellingprice = item.sellingprice;
                         obj.purchaseprice = item.purchaseprice;
                         obj.discountprice = item.discountprice;
                         obj.discountquantity = item.discountquantity;
                         list1.Add(obj);
                     }
                 }
             }
             catch (Exception)
             {

             }
             return list1;
         }

         public List<string> SugesstProduct()
         {
             List<string> list = new List<string>();
             try
             {
                 using (kingtopEntities context = new kingtopEntities())
                 {
                     list = (from record in context.product1 select record.description).ToList();

                 }
             }
             catch (Exception)
             {

             }
             return list;
         }

    }
}

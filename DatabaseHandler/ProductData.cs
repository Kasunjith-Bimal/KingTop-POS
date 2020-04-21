using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class ProductData
    {
        public void AddDatadbpro(ProductDTO obj)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    product1 prod = new product1();
                    prod.productid = obj.productid;
                    prod.barcode = obj.barcode;
                    prod.description = obj.description;
                    prod.quantity = obj.quantity;
                    prod.expiredate = obj.expiredate;
                    prod.purchaseprice = obj.purchaseprice;
                    prod.sellingprice = obj.sellingprice;
                    prod.discountquantity = obj.discountquantity;
                    prod.discountprice = obj.discountprice;
                    context.product1.Add(prod);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<ProductDTO> GetDatadbpro()
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 select record).ToList();
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
            catch (Exception ex)
            {
                throw;
            }
            return list1;
        }

        public List<ProductDTO> SearchBarcodedbpro(string barcode)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 where (record.barcode == barcode) select record).ToList();
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
            catch (Exception ex)
            {
                throw;
            }
            return list1;
        }

        public List<ProductDTO> SearchProductidbpro(string productid)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 where (record.productid == productid) select record).ToList();
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
            catch (Exception ex)
            {
                throw;
            }
            return list1;
        }
        public List<ProductDTO> SearchDescriptionbpro(string des)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 where (record.description == des) select record).ToList();
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
            catch (Exception ex)
            {
                throw;
            }
            return list1;
        }

        public List<ProductDTO> SearchDatanamedbpro(String name)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 where (record.description.Contains(name)) select record).ToList();
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
            catch (Exception ex)
            {
                throw;
            }
            return list1;
        }


        public List<ProductDTO> SearchIddbpro(String id)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    List<product1> prod = (from record in context.product1 where (record.productid.Contains(id)) select record).ToList();
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
            catch (Exception ex)
            {
                throw;
            }
            return list1;
        }

        public List<string> SugesstProductdbpro()
        {
            List<string> list = new List<string>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    list = (from record in context.product1 select record.description).ToList();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        public List<string> SugesstProductdbprodd()
        {
            List<string> list = new List<string>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    list = (from record in context.product1 select record.productid).ToList();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }



        public void UpdateProductdbpro(ProductDTO obj2)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    product1 item = (from record in context.product1 where record.productid == obj2.productid select record).FirstOrDefault();



                    item.productid = obj2.productid;
                    item.barcode = obj2.barcode;
                    item.description = obj2.description;
                    item.quantity = obj2.quantity;
                    item.expiredate = obj2.expiredate;
                    item.sellingprice = obj2.sellingprice;
                    item.purchaseprice = obj2.purchaseprice;
                    item.discountprice = obj2.discountprice;
                    item.discountquantity = obj2.discountquantity;
                    context.Entry(item).State = EntityState.Modified;
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteProductdbpro(string proid)
        {
            List<ProductDTO> list1 = new List<ProductDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    product1 pro = (from record in context.product1 where record.productid == proid select record).FirstOrDefault();
                    context.product1.Remove(pro);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void UpdateQuantity(ProductDTO obj)
        {
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {


                    product1 pro = (from record in context.product1
                                    where record.barcode == obj.barcode && record.description == obj.description
                                      && record.sellingprice == obj.sellingprice
                                    select record).FirstOrDefault();
                    pro.quantity = pro.quantity - obj.quantity;
                    context.Entry(pro).State = EntityState.Modified;


                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}

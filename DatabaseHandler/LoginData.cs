using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    public class LoginData
    {
        public bool AddDetailsDb(LoginDTO obj)
        {
            bool isSaved = false;
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    LoginDetail logindata = new LoginDetail();

                    logindata.Full_Name = obj.FullName;
                    logindata.Address = obj.Address;
                    logindata.Nic_No = obj.NicNo;
                    logindata.Telephone_No = obj.TelephoneNumber;
                    logindata.Gender = obj.Gender;
                    logindata.User_Name = obj.UserName;
                    logindata.Password = obj.Password;

                    context.LoginDetails.Add(logindata);

                    context.SaveChanges();



                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isSaved;
        }



        public List<String> GetUserNameDb()
        {
            List<String> Username = new List<string>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {

                    Username = (from recode in context.LoginDetails select recode.User_Name).ToList();


                }
             
            }
            catch (Exception ex)
            {
                throw;
            }
            return Username;
        }


        public List<LoginDTO> SelectdataDb(String Name)
        {
            List<LoginDTO> list = new List<LoginDTO>();
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {

                   LoginDetail logindata = (from recode in context.LoginDetails where recode.User_Name == Name select recode).FirstOrDefault();
                   
                    LoginDTO obj = new LoginDTO();

                    obj.UserName =logindata.User_Name;
                    obj.Password =logindata.Password;
                    obj.NicNo=logindata.Nic_No;
                    obj.FullName =logindata.Full_Name;
                    obj.Address =logindata.Address;
                    obj.Gender=logindata.Gender;
                    obj.TelephoneNumber=logindata.Telephone_No;

                    list.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }



        public bool DeleteDetailsDb(String user)
        {
            bool isSaved = false;
            try
            {
                using (kingtopEntities context = new kingtopEntities())
                {
                    LoginDetail deleteproduct = (from recode in context.LoginDetails where recode.User_Name == user select recode).FirstOrDefault();

                    context.LoginDetails.Remove(deleteproduct);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isSaved;
        }

        public bool SelectPasswordDb(LoginDTO objs)
        {
            bool isSaved = false;
            try
            {

                using (kingtopEntities context = new kingtopEntities())
                {

                    if (context.LoginDetails.Any(s => s.Password == objs.Password && s.User_Name == objs.UserName))
                    {
                        isSaved = true;

                    }
                   





                }

            }
            catch (Exception ex)
            {




            }





            return isSaved;


        }
    }
}

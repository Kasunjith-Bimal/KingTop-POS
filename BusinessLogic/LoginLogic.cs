using DatabaseHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LoginLogic
    {
        LoginData Db = new LoginData();

        public bool AddDetails(LoginDTO obj)
        {

            try
            {
                return Db.AddDetailsDb(obj);
            }
            catch (Exception ex)
            {
                throw;
            }



        }
        public List<String> GetUserNames()
        {
             try
            {
                return Db.GetUserNameDb();

            }
            catch (Exception ex)
            {
                throw;
            }
            
        }


        public List<LoginDTO> Selectdata(String UserName)
        {
            try
            {
                return Db.SelectdataDb(UserName);

            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public bool DeleteDetails(String Username)
        {

            try
            {
                return Db.DeleteDetailsDb(Username);
            }
            catch (Exception ex)
            {
                throw;
            }



        }


        public bool SelectPasswordlogic(LoginDTO obj)
        {


            return Db.SelectPasswordDb(obj);


        }
    }
}

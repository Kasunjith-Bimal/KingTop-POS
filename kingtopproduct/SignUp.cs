using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kingtopproduct
{
    public partial class SignUp : Form
    {
        LoginLogic Logic = new LoginLogic();
        public SignUp()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_confirmpassword.PasswordChar = '*';

        }
        public void setusernamecb()
        {
           
            List<String> returnuser = Logic.GetUserNames();
            cmb_selectuser.DataSource = returnuser;


        }
        private void btn_adduser_Click(object sender, EventArgs e)
        {



            try
            {
                String FullName = txt_fullname.Text;
                String Password = txt_password.Text;
                String ConfirmPassword = txt_confirmpassword.Text;
                String Address = txt_address.Text;
                String TelephoneNo = txt_telephoneno.Text;
                String NicNo = txt_nicno.Text;
                String UserName = txt_username.Text.ToString();
                String Gender = "";

                if (radio_male.Checked)
                {
                    Gender = radio_male.Text;
                }
                else
                {
                    Gender = radio_female.Text;
                }


                if (Password != ConfirmPassword)
                {
                    MessageBox.Show("ConfirmPassword is Not Match");


                }
                else
                {
                    if (!string.IsNullOrEmpty(FullName) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(NicNo) && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(ConfirmPassword))
                    {
                        LoginDTO loginObj = new LoginDTO();

                        loginObj.FullName = FullName;
                        loginObj.Address = Address;
                        loginObj.NicNo = NicNo;
                        loginObj.Gender = Gender;
                        loginObj.Password = Password;
                        loginObj.UserName = UserName;
                        loginObj.TelephoneNumber = TelephoneNo;

                        Logic.AddDetails(loginObj);

                        MessageBox.Show("Data is Enterd");
                    }
                    else
                    {

                        MessageBox.Show("Plese Enter All Filed");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            setusernamecb();

            txt_confirmpassword.Text = "";
            txt_password.Text = "";

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            setusernamecb();
            btn_delete.Enabled = false;

        }
        public void SelectUserdetails()
        {
            String SelectUser = cmb_selectuser.Text;

            var returnlist = Logic.Selectdata(SelectUser);

            foreach (var item in returnlist)
            {
                txt_username.Text = item.UserName;
                txt_telephoneno.Text = item.TelephoneNumber;
                txt_password.Text = item.Password;
                txt_nicno.Text = item.NicNo;
                txt_fullname.Text = item.FullName;
                txt_address.Text = item.Address;
                if (item.Gender == "Male")
                {
                    radio_male.Checked = true;
                }
                if (item.Gender == "Female")
                {
                    radio_female.Checked = true;
                }


            }


        }
        private void cmb_selectuser_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btn_update_Click(object sender, EventArgs e)
        {


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmb_selectuser.Text == "Admin")
            {
                MessageBox.Show("Waning! Select another user!");
            }
            else
            {
                SelectUserdetails();
                btn_delete.Enabled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_fullname.Text = "";
            txt_confirmpassword.Text = "";
            txt_nicno.Text = "";
            txt_password.Text = "";
            txt_telephoneno.Text = "";
            txt_username.Text = "";
            radio_male.Checked = false;
            radio_female.Checked = false;
            btn_delete.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            Logic.DeleteDetails(username);

            setusernamecb();

            txt_address.Text = "";
            txt_fullname.Text = "";
            txt_confirmpassword.Text = "";
            txt_nicno.Text = "";
            txt_password.Text = "";
            txt_telephoneno.Text = "";
            txt_username.Text = "";
            radio_female.Checked = false;
            radio_male.Checked = false;

            btn_delete.Enabled = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



    }
}

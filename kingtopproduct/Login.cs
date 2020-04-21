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
    public partial class Login : Form
    {
        LoginLogic Logic = new LoginLogic();
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';

        }
        public void getusername()
        {
            List<String> returnuser = Logic.GetUserNames();
            cmb_user.DataSource = returnuser;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            getusername();
        }

        private void btn_logic_Click(object sender, EventArgs e)
        {
            try
            {
                String passWordtext = txt_password.Text;
                String userName = cmb_user.Text;

                LoginDTO obj = new LoginDTO();

                obj.UserName = userName;
                obj.Password = passWordtext;
                if (Logic.SelectPasswordlogic(obj))
                {
                    if (cmb_user.Text == "Admin")
                    {
                        AdminHome adminwindow = new AdminHome();
                        this.Hide();
                        adminwindow.Show();
                    }
                    else
                    {
                       
                        kingtopterminal userwindow = new kingtopterminal();
                        userwindow.GetUser(userName);
                        this.Hide();
                        userwindow.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Password Incorect");

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_logic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    String passWordtext = txt_password.Text;
                    String userName = cmb_user.Text;

                    LoginDTO obj = new LoginDTO();

                    obj.UserName = userName;
                    obj.Password = passWordtext;
                    if (Logic.SelectPasswordlogic(obj))
                    {
                        if (cmb_user.Text == "Admin")
                        {
                            AdminHome adminwindow = new AdminHome();
                            this.Hide();
                            adminwindow.Show();
                        }
                        else
                        {
                            kingtopterminal userwindow = new kingtopterminal();
                            this.Hide();
                            userwindow.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Incorect");

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

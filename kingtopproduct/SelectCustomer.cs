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
    public partial class SelectCustomer : Form
    {
        public CustomerDTO objs = new CustomerDTO();
       // public static string customername1 = null;
       //public int customerid1;
        CustomerLogic cuslog = new CustomerLogic();
        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            dgv_customer.DataSource= cuslog.GetData();
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cusID="";
            string fullname="";
            foreach (DataGridViewRow item in dgv_customer.SelectedRows)
            {
                 cusID = item.Cells["CustomerID"].Value.ToString();
                fullname = item.Cells["FullName"].Value.ToString();
               
            }
            txt_customerid.Text = cusID;
            txt_customername.Text = fullname;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_customerid.Text = "";
            txt_customername.Text = "";
            txt_search.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cmb_search.SelectedIndex == 0)
            {
                int id = Convert.ToInt32(txt_search.Text);
                dgv_customer.DataSource = cuslog.SearchDataID(id);
            }
            if (cmb_search.SelectedIndex == 1)
            {
                String name = (txt_search.Text);
                dgv_customer.DataSource = cuslog.SearchDataName(name);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string name = txt_customername.Text;
            int id = Convert.ToInt32(txt_customerid.Text);
            
            objs.FullName = name;
           
            objs.CustomerID = id;
           
            
            this.Hide();
           /*kingtopterminal obj = new kingtopterminal();
            obj.Show();
            
            obj.GetCusData(name, id);*/
            
            
            
        }
    }
}

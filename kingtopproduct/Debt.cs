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
    public partial class Debt : Form
    {
        CustomerDTO jj = new CustomerDTO();
       
        DebtLogic debtlog = new DebtLogic();
        List<DebtDTO> listdebt = new List<DebtDTO>();
        string username1;
        string cusname1;
        int invoiceno1;
        int custoid;
        public Debt()
        {
            InitializeComponent();
        }

        private void Debt_Load(object sender, EventArgs e)
        {

            kingtopterminal ok = new kingtopterminal();
            CustomerDTO obj = ok.j; 
            txt_debt.Enabled = false;
            dataGridView1.DataSource = debtlog.SearchDebt(obj.CustomerID);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (lbl_cusname.Text == dataGridView1.Rows[i].Cells["cusname"].Value.ToString())
                {
                    k++;
                }
            }
            if (k != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    lbl_cusname.Text = dataGridView1.Rows[i].Cells["cusname"].Value.ToString();
                    txt_debt.Text = dataGridView1.Rows[i].Cells["debtamount"].Value.ToString();

                }
            }
            
        }

        public void get( string total, string username,string cusname,int cusid,string invoiceno)
        {
            username1 = username;
            custoid = cusid; 
            txt_debt.Text = total;
            cusname1 = cusname;
            lbl_cusname.Text = cusname;
            invoiceno1 = Convert.ToInt32(invoiceno);
            txt_search.Text = cusid.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (lbl_cusname.Text == dataGridView1.Rows[i].Cells["cusname"].Value.ToString())
                {
                    k++;
                }
            }
                if(k!=0)
                {
                    MessageBox.Show("User exits cannot add please update");
                }
                else
                {
                    DebtDTO obj = new DebtDTO();
                    obj.cusname = cusname1;
                    obj.customerid = custoid;
                    // obj.invoiceno = invoiceno1;
                    obj.debttotal = Convert.ToDecimal(txt_debt.Text);
                    // obj.dates = DateTime.Now.ToShortDateString();
                    //obj.username = username1;
                    debtlog.AddDebt(obj);
                    dataGridView1.DataSource = debtlog.GetDebt();
                }
            }
            
            

        
        public void GetS(CustomerDTO ob)
        {
            jj = ob;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_debt.Text = "";
            lbl_cusname.Text = "";
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.CurrentCell.RowIndex;
            string cusname = dataGridView1.Rows[rows].Cells["cusname"].Value.ToString();
            if (cusname == lbl_cusname.Text)
            {
                string debt = dataGridView1.Rows[rows].Cells["debtamount"].Value.ToString();
                string cusname1 = lbl_cusname.Text;
                string debt1 = txt_debt.Text;
            }
            else
                MessageBox.Show("Select Correct Customer");

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}

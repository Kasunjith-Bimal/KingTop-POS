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
        DebtLogic debtlog = new DebtLogic();
        List<DebtDTO> listdebt = new List<DebtDTO>();
        string username1;
        public Debt()
        {
            InitializeComponent();
        }

        private void Debt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = debtlog.GetDebt();
        }
        public void get(string n, string total, string username)
        {
            username1 = username;
            lbl_invoiceno.Text = n;
            txt_debt.Text = total;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            DebtDTO obj = new DebtDTO();
            obj.cusname = "ras";
            obj.customerid = 1;
            obj.debttotal = Convert.ToDecimal(txt_debt.Text);
            obj.invoiceno = Convert.ToInt32(lbl_invoiceno.Text);
            obj.dates = DateTime.Now.ToShortDateString();
            obj.username = username1;
            debtlog.AddDebt(obj);
        }
    }
}

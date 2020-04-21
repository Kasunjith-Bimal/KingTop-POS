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
    public partial class Debitreport : Form
    {
        public Debitreport()
        {
            InitializeComponent();
        }

        private void Debitreport_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.debt' table. You can move, or remove it, as needed.
            String Cusname = txt_cusname.Text;
            this.debtTableAdapter.Fill(this.DataSet2.debt,Cusname);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

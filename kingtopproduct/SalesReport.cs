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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.invoiceheader' table. You can move, or remove it, as needed.
            ;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.invoiceheader' table. You can move, or remove it, as needed.
           String Date =dtp_showdate.Value.ToShortDateString();
            this.invoiceheaderTableAdapter.Fill(this.DataSet1.invoiceheader,Date);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class Payment : Form
    {
        decimal withamount;
        PayementLogic Logic = new PayementLogic();
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString();
            txt_withdrawamount.Enabled = false;
            setdatagrid();
             
             btn_add.Enabled = false;

             dgv_showpayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             

        }
        public void setdatagrid()
        {
            List<PaymentDTO> addlist = new List<PaymentDTO>();
            addlist = Logic.GetData();
            dgv_showpayment.DataSource = addlist;
        }
        public void selectgriddata()
        {
            int Rowindex = dgv_showpayment.CurrentCell.RowIndex;
            String Drawamount = dgv_showpayment.Rows[Rowindex].Cells["DrawerAmount"].Value.ToString();
            String WithDrawamount = dgv_showpayment.Rows[Rowindex].Cells["WithDrawerAmount"].Value.ToString();


            withamount = Convert.ToDecimal(WithDrawamount);
            txt_draweramount.Text = Drawamount;
            txt_withdrawamount.Text = WithDrawamount;

            txt_draweramount.Enabled = false;
            txt_withdrawamount.Enabled = true;

            btn_add.Enabled = false;

            txt_withdrawamount.Text = "0.00";

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            PaymentDTO obj = new PaymentDTO();

            if (!string.IsNullOrEmpty(txt_draweramount.Text))
            {
                
                obj.DrawerAmount = Convert.ToDecimal(txt_draweramount.Text);
                obj.WithDrawerAmount = 0;
                obj.Date = DateTime.Now.ToShortDateString();


                Logic.Adddata(obj);

                txt_draweramount.Enabled = false;
                btn_add.Enabled = false;

                txt_withdrawamount.Enabled = true;

                setdatagrid();
            }
            else
            {
                MessageBox.Show("Plese Enter Drawer Amount");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_draweramount.Enabled = false;
            btn_add.Enabled = true;
            txt_withdrawamount.Text = "";
           
        }

        private void txt_draweramount_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_draweramount.Text))
            {

                int Rowindex = dgv_showpayment.CurrentCell.RowIndex;
                int paymntid = Convert.ToInt32(dgv_showpayment.Rows[Rowindex].Cells["PaymentId"].Value.ToString());

                PaymentDTO obj = new PaymentDTO();
                obj.PaymentId = paymntid;
                obj.Date = DateTime.Now.ToShortDateString();
                obj.DrawerAmount = Convert.ToDecimal(txt_draweramount.Text);
                obj.WithDrawerAmount = withamount + Convert.ToDecimal(txt_withdrawamount.Text);

                Logic.updatepayemnt(obj);

                setdatagrid();

                txt_withdrawamount.Text = "0.00";

            }
            else MessageBox.Show("Enter Drawamount!");
        }

        private void dgv_showpayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectgriddata();
        }

        private void txt_draweramount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
          && !char.IsDigit(e.KeyChar)
          && e.KeyChar != '.' )
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }


        }

        private void txt_withdrawamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
       && !char.IsDigit(e.KeyChar)
       && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

    }
}

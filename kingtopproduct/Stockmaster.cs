using BusinessLogic;
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
    public partial class Stockmaster : Form
    {
        StockLogic prolog = new StockLogic();
        public Stockmaster()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select.SelectedIndex > -1)
            {
                txt_search.Enabled = true;
            }
        }

        private void Stockmaster_Load(object sender, EventArgs e)
        {
            try
            {
                GetData();
                txt_search.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_select.SelectedIndex == 0)
            {
                if (txt_search.Text != "")
                {
                    string barcode = (txt_search.Text);
                    dgv_stock.DataSource = prolog.SearchBarcode(barcode);
                    dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hidefield();
                }
                else
                    GetData();
            }
            if (cmb_select.SelectedIndex == 1)
            {
                if (txt_search.Text != "")
                {
                    string name = txt_search.Text;
                    dgv_stock.DataSource = prolog.SearchDataname(name);
                    dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hidefield();
                }
                else
                    GetData();
            }
            if (cmb_select.SelectedIndex == 2)
            {
                if (txt_search.Text != "")
                {
                    string id = txt_search.Text;
                    dgv_stock.DataSource = prolog.SearchId(id);
                    dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    hidefield();
                }
                else
                    GetData();
            }
        }
        private void hidefield()
        {
            dgv_stock.Columns["expiredate"].Visible = false;
            dgv_stock.Columns["discountquantity"].Visible = false;
            dgv_stock.Columns["sellingprice"].Visible = false;
            dgv_stock.Columns["purchaseprice"].Visible = false;
            dgv_stock.Columns["discountprice"].Visible = false;
        }
        private void GetData()
        {
            dgv_stock.DataSource = prolog.GetData();
            dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hidefield();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cmb_select.SelectedIndex == 1)
            {
                List<string> listnew = prolog.SuggestProduct();
                var list1 = new AutoCompleteStringCollection();
                list1.AddRange(listnew.ToArray());
                txt_search.AutoCompleteCustomSource = list1;
            }

        }

    }
}

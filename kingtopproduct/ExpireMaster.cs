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
    public partial class ExpireMaster : Form
    {
        int combovalue;
        ExpireMasterLogic exlog = new ExpireMasterLogic();
        List<ProductDTO> list1 = new List<ProductDTO>();
        ProductDTO pro = new ProductDTO();
        public ExpireMaster()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void GetData()
        {
            dataGridView1.DataSource = exlog.GetData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ExpireMaster_Load(object sender, EventArgs e)
        {
            GetData();
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public int getComboValue()
        {
            return combovalue;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_selectType.SelectedIndex == 0)
                {
                    string bid = (txt_search.Text);
                    dataGridView1.DataSource = exlog.SearchbId(bid);
                }
                if (cmb_selectType.SelectedIndex == 1)
                {
                    string id = txt_search.Text;
                    dataGridView1.DataSource = exlog.SearchId(id);
                }
                if (cmb_selectType.SelectedIndex == 2)
                {
                    string des = txt_search.Text;
                    dataGridView1.DataSource = exlog.Searchdes(des);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> listnew = exlog.SuggestProduct();
                var list1 = new AutoCompleteStringCollection();
                list1.AddRange(listnew.ToArray());
                txt_search.AutoCompleteCustomSource = list1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            GetData();
            txt_search.Text = "";
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AdminHome adh = new AdminHome();
            this.Hide();
            adh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btn_search_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (cmb_selectType.SelectedIndex == 0)
                    {
                        string bid = (txt_search.Text);
                        dataGridView1.DataSource = exlog.SearchbId(bid);
                    }
                    if (cmb_selectType.SelectedIndex == 1)
                    {
                        string id = txt_search.Text;
                        dataGridView1.DataSource = exlog.SearchId(id);
                    }
                    if (cmb_selectType.SelectedIndex == 2)
                    {
                        string des = txt_search.Text;
                        dataGridView1.DataSource = exlog.Searchdes(des);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

    }
}

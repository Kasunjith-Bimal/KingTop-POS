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
    public partial class Form1 : Form
    {
        ProductLogic prolog = new ProductLogic();
        List<ProductDTO> list1 = new List<ProductDTO>();
        ProductDTO pro = new ProductDTO();
        ProductDTO obj = new ProductDTO();
        string barcode;
        string productid;
        string description;
        string quantity;
        string expiredate;
        string sellingprice;
        string purchaseprice;
        string discountprice;
        string discountquantity;
        public Form1()
        {
            InitializeComponent();
        }

        private void addDataButton()
        {
           
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                                  string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                                  string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) ||
                                  string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
                {
                    MessageBox.Show("Field Empty");
                }
                else
                {
                    AddData();
                    prolog.AddData(pro);
                    GetData();
                    clear();
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void AddData()
        {
            try
            {
                string dt = "";
                if (DateTime.Now.ToShortDateString() == dateTimePicker1.Value.ToShortDateString())
                {
                     dt = "";
                }
                else
                {
                    dt=dateTimePicker1.Value.ToShortDateString();
                }
                    pro.productid = textBox4.Text;
                    pro.barcode = (textBox1.Text);
                    pro.description = textBox2.Text;
                    pro.quantity = Convert.ToInt32(textBox3.Text);
                    pro.expiredate = dt;
                    pro.purchaseprice = Convert.ToDecimal(textBox6.Text);
                    pro.sellingprice = Convert.ToDecimal(textBox5.Text);
                    if (textBox7.Text == "")
                        pro.discountquantity = 0;
                    else
                    {
                        pro.discountquantity = Convert.ToInt32(textBox7.Text);
                    }
                    if (textBox8.Text == "")
                        pro.discountprice = 0;
                    else
                    {
                        pro.discountprice = Convert.ToDecimal(textBox8.Text);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("field empty");
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;


            try
            {
                GetData();
                Gridcolclear();
                textBox9.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void GetData()
        {
            dataGridView1.DataSource = prolog.GetData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GetUpdate();
                prolog.UpdateProduct(obj);
                GetData();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            List<string> listnew = prolog.SuggestProductpro1();
            var list1 = new AutoCompleteStringCollection();
            list1.AddRange(listnew.ToArray());
            textBox9.AutoCompleteCustomSource = list1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox9.Text != "")
                {
                    string barcode = (textBox9.Text);
                    dataGridView1.DataSource = prolog.SearchBarcode(barcode);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (textBox9.Text != "")
                {
                    string name = textBox9.Text;
                    dataGridView1.DataSource = prolog.SearchDataname(name);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (textBox9.Text != "")
                {
                    string id = textBox9.Text;
                    dataGridView1.DataSource = prolog.SearchId(id);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                textBox9.Enabled = true;
            }
        }
        private void clear()
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            dateTimePicker1.Text = "";

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                clear();
                barcode = item.Cells["barcode"].Value.ToString();
                productid = item.Cells["productid"].Value.ToString();
                description = item.Cells["description"].Value.ToString();
                quantity = item.Cells["quantity"].Value.ToString();
                try
                {
                    expiredate = item.Cells["expiredate"].Value.ToString();
                }
                catch (Exception)
                {
                    
                }
                sellingprice = item.Cells["sellingprice"].Value.ToString();
                purchaseprice = item.Cells["purchaseprice"].Value.ToString();
                try
                {
                discountprice = item.Cells["discountprice"].Value.ToString();
                discountquantity = item.Cells["discountquantity"].Value.ToString();
                }
                catch (Exception)
                {
                    
                }
                textBox1.Text = barcode;
                textBox4.Text = productid;
                textBox2.Text = description;
                textBox3.Text = quantity;
                
                if(expiredate == "")
                {
                    expiredate = DateTime.Now.ToShortDateString();
                }
                try
                {
                    dateTimePicker1.Value = Convert.ToDateTime(expiredate);
                }
                catch (Exception)
                {
                    
                }
                textBox5.Text = sellingprice;
                textBox6.Text = purchaseprice;
                textBox8.Text = discountprice;
                textBox7.Text = discountquantity;




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GetUpdate()
        {
            barcode = textBox1.Text;
            productid = textBox4.Text;
            description = textBox2.Text;
            quantity = textBox3.Text;
            expiredate = dateTimePicker1.Value.ToShortDateString();
            sellingprice = textBox5.Text;
            purchaseprice = textBox6.Text;
            discountprice = textBox8.Text;
            discountquantity = textBox7.Text;
            obj.barcode =(barcode);
            obj.productid = productid;
            obj.description = description;
            obj.quantity = Convert.ToDecimal(quantity);
            obj.expiredate = expiredate;
            obj.sellingprice = Convert.ToDecimal(sellingprice);
            obj.purchaseprice = Convert.ToDecimal(purchaseprice);
            obj.discountprice = Convert.ToDecimal(discountprice);
            obj.discountquantity = Convert.ToInt32(discountquantity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string proid = textBox4.Text;
                prolog.DeleteProduct(proid);
                GetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("select to delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("field empty");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
            }
        }
        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                char ch = e.KeyChar;
                if (!char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.Enter)
            //{
            //    addDataButton();
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addDataButton();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void Gridcolclear()
        {
            dataGridView1.Columns["total"].Visible = false;
            dataGridView1.Columns["lastprice"].Visible = false;
            //dataGridView1.Columns["purchaseprice"].Visible = false;
            dataGridView1.Columns["discountsp"].Visible = false;
        }
    }
}

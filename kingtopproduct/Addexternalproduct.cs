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
    public partial class Addexternalproduct : Form
    {
        ProductLogic prolog = new ProductLogic();
        List<ProductDTO> list1 = new List<ProductDTO>();
        ProductDTO pro = new ProductDTO();
        ProductDTO obj = new ProductDTO();
        public Addexternalproduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDataButton();
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
                MessageBox.Show("Data Saved");

            }

        }
       
        private void AddData()
        {
            try
            {

                pro.productid = textBox4.Text;
                pro.barcode = (textBox1.Text);
                pro.description = textBox2.Text;
                pro.quantity = Convert.ToInt32(textBox3.Text);
                pro.expiredate = dateTimePicker1.Value.ToShortDateString();
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
    }
}

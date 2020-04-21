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
    public partial class ViewCustomer : Form
    {
        CustomerLogic cul = new CustomerLogic();
        CustomerDTO cdto = new CustomerDTO();
        List<CustomerDTO> culist = new List<CustomerDTO>();

        String cusID;
        String fullname;
        String address;
        String nicNo;
        String gender;
        String telno;

        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txt_fullname.Text = "";
            txt_address.Text = "";
            txt_telephoneno.Text = "";
            txt_nicno.Text = "";
        }

        private void GetData()
        {
            dataGridView1.DataSource = cul.GetData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            GetData();
            
        }

        private void selectedRaw()
        {

        }

        public void getUpdate()
        {

            fullname = txt_fullname.Text;
            address = txt_address.Text;
            nicNo = txt_nicno.Text;
            if (radio_male.Checked)
            {
                gender = "Male";
            }
            else gender = "Female";
            telno = txt_telephoneno.Text;

            cdto.CustomerID = Convert.ToInt16(cusID);
            cdto.FullName = fullname;
            cdto.Address = address;
            cdto.NicNo = nicNo;
            cdto.Gender = gender;
            cdto.TelephoneNumber = telno;


            cul.getUpdate(cdto);
        }

        private void addData()
        {
            fullname = txt_fullname.Text;
            address = txt_address.Text;
            nicNo = txt_nicno.Text;
            if (radio_male.Checked)
            {
                gender = "Male";
            }
            else gender = "Female";
            telno = txt_telephoneno.Text;

            cdto.CustomerID = Convert.ToInt16(cusID);
            cdto.FullName = fullname;
            cdto.Address = address;
            cdto.NicNo = nicNo;
            cdto.Gender = gender;
            cdto.TelephoneNumber = telno;

            cul.addData(cdto);
            GetData();
            clear();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                getUpdate();
                GetData();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GetData();
            clear();
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                cusID = item.Cells["CustomerID"].Value.ToString();
                fullname = item.Cells["FullName"].Value.ToString();
                address = item.Cells["Address"].Value.ToString();
                nicNo = item.Cells["NICNo"].Value.ToString();
                gender = item.Cells["Gender"].Value.ToString();
                telno = item.Cells["TelephoneNumber"].Value.ToString();

                txt_fullname.Text = fullname;
                txt_address.Text = address;
                txt_nicno.Text = nicNo;
                if (gender == "Male")
                {
                    radio_male.PerformClick();
                }
                else radio_female.PerformClick();

                txt_telephoneno.Text = telno;
            }
        }
    }
}

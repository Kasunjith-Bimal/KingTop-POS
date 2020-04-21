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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void expireMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exMa = new ExpireMaster();
            exMa.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            
           // this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
           // this.WindowState = FormWindowState.Maximized;
        }

        private void stockQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stm = new Stockmaster();
            stm.Show();
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
             var form1 = new Form1();
             form1.Show();
        }

        private void withdrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form1 = new Form1();
                form1.Show();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                var exma = new ExpireMaster();
                exma.Show();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                var stma = new Stockmaster();
                stma.Show();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F7)
            {
                var pay = new Payment();
                pay.Show();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F4)
            {
                var siu = new SignUp();
                siu.Show();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F8)
            {
                var vc = new ViewCustomer();
                vc.Show();
                e.Handled = true;
            }

        }

        private void SignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            this.Close();
            lo.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timenow = DateTime.Now;
            this.lbl_datetime.Text = timenow.ToShortTimeString();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Stockmaster sm = new Stockmaster();
            sm.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SalesReport salesreportwindow = new SalesReport();
            salesreportwindow.Show();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Payment pa = new Payment();
            pa.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 im = new Form1();
            im.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ExpireMaster em = new ExpireMaster();
            em.Show();
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Debitreport debwindow = new Debitreport();
            debwindow.ShowDialog();

        }
    }
}

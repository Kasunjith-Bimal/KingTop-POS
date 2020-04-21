using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kingtopproduct
{
    public partial class kingtopterminal : Form
    {
        public CustomerDTO j = new CustomerDTO();
        public int cusids;
        public string totf;
        public string totl;
        public string dis;
        public string usee;
        public string custoname;
       
        ProductLogic prolog = new ProductLogic();
        TerminalLogic termlog = new TerminalLogic();
        InvoiceHeaderLogic inlog = new InvoiceHeaderLogic();
        InvoiceLineLogic linelog = new InvoiceLineLogic();
        List<ProductDTO> list1 = new List<ProductDTO>();
        List<ProductDTO> listw = new List<ProductDTO>();
        List<ProductDTO> listp = new List<ProductDTO>();
        List<ProductDTO> listpro = new List<ProductDTO>();
        List<WaitProductDTO> listwait = new List<WaitProductDTO>();
        List<InvoiceLineDTO> listnew = new List<InvoiceLineDTO>();
        WaitLogic waitlog = new WaitLogic();
        int no = 0;
        string expiredate;
        string purchaseprice;
        string discountprice;
        string discountquantity;

        public kingtopterminal()
        {
            InitializeComponent();
        }

        public void GetUser(string user)
        {
            
            lbl_username.Text = user;
            usee = user;
        }
        private void kingtopterminal_Load(object sender, EventArgs e)
        {
             this.TopMost = false;
            //this.FormBorderStyle = FormBorderStyle.None;
             this.WindowState = FormWindowState.Maximized;


            btn_search.Enabled = false;
            btn_debt.Enabled = false;
            if (txt_quantity.Text == "")
            {
                btn_add.Enabled = false;
            }
            else btn_add.Enabled = true;
            btn_debt.Enabled = false;

            dgv_wait.DataSource = waitlog.GetWaitData();
            dgv_wait.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            invoicelableincre();
            cmb_paytype.SelectedIndex = 0;

            btn_search.Enabled = false;

        

        }

        private void invoicelableincre()
        {
            string user = lbl_user.Text;
            int id = inlog.getinvoiceno() + 1;
            label19.Text = id.ToString();
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string barcode = (txt_barcode.Text);
                    dgv_product.DataSource = termlog.GetProduct(barcode);
                    dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    int rows = dgv_product.CurrentCell.RowIndex;
                    if (rows > -1)
                    {
                        txt_productid.Text = dgv_product.Rows[rows].Cells["productid"].Value.ToString();
                        txt_description.Text = dgv_product.Rows[rows].Cells["description"].Value.ToString();
                        txt_sellingprice.Text = dgv_product.Rows[rows].Cells["sellingprice"].Value.ToString();
                        purchaseprice = dgv_product.Rows[rows].Cells["purchaseprice"].Value.ToString();
                        expiredate = dgv_product.Rows[rows].Cells["expiredate"].Value.ToString();
                        discountprice = dgv_product.Rows[rows].Cells["discountprice"].Value.ToString();
                        discountquantity = dgv_product.Rows[rows].Cells["discountquantity"].Value.ToString();
                        dgv_product.Columns["total"].Visible = false;
                        dgv_product.Columns["lastprice"].Visible = false;
                        dgv_product.Columns["purchaseprice"].Visible = false;
                        //dgv_product.Columns["discountquantity"].Visible = false;
                        txt_quantity.Focus();
                    }

                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Barcode");
            }
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = dgv_product.CurrentCell.RowIndex;
            txt_productid.Text = dgv_product.Rows[rows].Cells["productid"].Value.ToString();
            txt_description.Text = dgv_product.Rows[rows].Cells["description"].Value.ToString();
            txt_barcode.Text = dgv_product.Rows[rows].Cells["barcode"].Value.ToString();
            txt_sellingprice.Text = dgv_product.Rows[rows].Cells["sellingprice"].Value.ToString();

            txt_quantity.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddToProductgrid();
            AddToBill();
            addclear();
            txt_barcode.Focus();
            btn_add.Enabled = false;
        }

        private void addclear()
        {
            txt_barcode.Text = "";
            txt_productid.Text = "";
            txt_description.Text = "";
            txt_sellingprice.Text = "";
            txt_discountsp.Text = "";
            txt_quantity.Text = "";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                setheader();
                setline();
                totf = txt_total.Text;
                dis = txt_discount.Text;
                totl = txt_totalprice.Text;
                int id = inlog.getinvoiceno();


                int idline = linelog.getinvoiceno();
                if (id == idline)
                {
                    id = idline + 1;
                }
                else
                    id = id + 1;
                lbl_invoiceno.Text = id.ToString();
                
                txt_barcode.Focus();


                updatetable();
                Printrecipt();
                addclear();
                printclear();
                list1.Clear();
                listpro.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Printrecipt()
        {
            PrintDialog printdia = new PrintDialog();
            PrintDocument printdoc = new PrintDocument();

            printdia.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            DialogResult result = printdia.ShowDialog();

            if (result == DialogResult.OK)
            {

                printdoc.Print();
            }


        }

        private void printclear()
        {
            txt_total.Text = "";
            txt_totalprice.Text = "";
            txt_discount.Text = "";
            dgv_product.DataSource = null;
            dgv_bill.DataSource = null;
            cmb_paytype.SelectedIndex = 0;
            list1.Clear();
            listpro.Clear();
        }

        private void AddToBill()
        {

            decimal total = 0;
            decimal discount1 = 0;
            decimal discount = 0;
            decimal fulltotal = 0;
            decimal discountsp = 0;
            decimal lastprice = 0;
            for (int i = 0; i < dgv_bill.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgv_bill.Rows[i].Cells["total"].Value);
                discount1 += Convert.ToDecimal(dgv_bill.Rows[i].Cells["discountprice"].Value);
                lastprice += Convert.ToDecimal(dgv_bill.Rows[i].Cells["lastprice"].Value);
                discountsp += Convert.ToDecimal(dgv_bill.Rows[i].Cells["discountsp"].Value);
            }
            /*  
              if (Convert.ToInt32(txt_quantity.Text) < 2)
              {
                  discount = 0;
              }*/

            txt_total.Text = total.ToString();
            txt_discount.Text = (discount + discount1 + discountsp).ToString();
            fulltotal = total - Convert.ToDecimal(txt_discount.Text);
            txt_totalprice.Text = lastprice.ToString();


        }

        private void AddToProductgrid()
        {
            if (txt_quantity.Text == "" || txt_barcode.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Field Missing");
            }
            else
            {
                dgv_bill.DataSource = null;
                string barcode = (txt_barcode.Text);
                string productid = txt_productid.Text;
                string description = txt_description.Text;

                decimal quantity = Convert.ToDecimal(txt_quantity.Text);
                decimal sellingprice = Convert.ToDecimal(txt_sellingprice.Text);

                decimal total = quantity * sellingprice;
                total = System.Math.Round(total, 2);
                ProductDTO obj = new ProductDTO();
                obj.quantity = quantity;
                obj.barcode = barcode;
                obj.productid = productid;
                obj.description = description;
                obj.sellingprice = sellingprice;
                obj.purchaseprice = Convert.ToDecimal(purchaseprice);
                obj.expiredate = expiredate;
                obj.discountquantity = Convert.ToInt32(discountquantity);
                obj.discountprice = Convert.ToDecimal(discountprice);

                if (quantity < obj.discountquantity)
                {
                    obj.discountprice = 0;
                }

                obj.discountprice = (obj.discountprice) * quantity;
                obj.total = total;
                decimal discountsp = 0;
                if (txt_discountsp.Text != "")
                {
                    discountsp = Convert.ToDecimal(txt_discountsp.Text);
                }
                obj.discountsp = discountsp;

                obj.lastprice = Convert.ToDecimal((total - discountsp) - (obj.discountprice));
                list1.Add(obj);
                list1.AddRange(listpro);
                
                dgv_bill.DataSource = list1;
                dgv_bill.Columns["purchaseprice"].Visible = false;
                dgv_bill.Columns["discountquantity"].Visible = false;
                //dgv_bill.Columns["discountprice"].Visible = false;
                dgv_bill.Columns["expiredate"].Visible = false;
                dgv_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                listpro.Clear();
            }
        }

        private void cmb_paytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_paytype.SelectedIndex == 1)
            {
                btn_search.Enabled =false;
                for (int i = 0; i < dgv_bill.Columns.Count; i++)
                {
                    for (int j = 0; j < dgv_bill.Rows.Count; j++)
                    {
                        dgv_bill.Rows[j].Cells["discountprice"].Value = "0.00";
                        dgv_bill.Rows[j].Cells["discountsp"].Value = "0.00";
                        dgv_bill.Rows[j].Cells["lastprice"].Value = dgv_bill.Rows[j].Cells["total"].Value;
                    }
                }
                decimal tot = 0;
                decimal dis = 0;
                for (int i = 0; i < dgv_bill.Rows.Count; i++)
                {
                    tot += Convert.ToDecimal(dgv_bill.Rows[i].Cells["lastprice"].Value);
                }
                txt_total.Text = tot.ToString();
                txt_discount.Text = dis.ToString();
                txt_totalprice.Text = tot.ToString();
            }
            else
                btn_search.Enabled = false;
        }

        private void btn_waitbill_Click(object sender, EventArgs e)
        {
            WaitBill();
            WaitProduct();
            dgv_bill.DataSource = null;
            dgv_wait.DataSource = waitlog.GetWaitData();
            list1.Clear();
            printclear();
        }

        private void setheader()
        {
            InvoiceHeaderDTO obj = new InvoiceHeaderDTO();
                obj.invoicedate = (DateTime.Now).ToShortDateString();
                obj.totaldiscount = Convert.ToDecimal(txt_discount.Text);
                obj.totalprice = Convert.ToDecimal(txt_totalprice.Text);
                termlog.AddInvoiceHeader(obj);
            
            
        }
        private void setline()
        {
            List<InvoiceLineDTO> list = new List<InvoiceLineDTO>();

            for (int i = 0; i < dgv_bill.Rows.Count; i++)
            {
                InvoiceLineDTO obj = new InvoiceLineDTO();
                obj.invoiceno = inlog.getinvoiceno();
                obj.productid = dgv_bill.Rows[i].Cells["productid"].Value.ToString();
                obj.description = dgv_bill.Rows[i].Cells["description"].Value.ToString();
                obj.quantity = Convert.ToDecimal(dgv_bill.Rows[i].Cells["quantity"].Value.ToString());
                obj.discountprice = Convert.ToDecimal(dgv_bill.Rows[i].Cells["discountprice"].Value.ToString());
                obj.sellingprice = Convert.ToDecimal(dgv_bill.Rows[i].Cells["sellingprice"].Value.ToString());
                obj.totalprice = Convert.ToDecimal(dgv_bill.Rows[i].Cells["lastprice"].Value.ToString());
                obj.user = lbl_user.Text;
                list.Add(obj);
            }
            termlog.AddInvoiceLine(list);
        }
        /*
        private void setline1()
        {
            List<InvoiceLineDTO> list = new List<InvoiceLineDTO>();
            int inno = 0;
            for (int i = 0; i < dgv_bill.Rows.Count; i++)
            {
                InvoiceLineDTO obj = new InvoiceLineDTO();
                obj.invoiceno = inlog.getinvoiceno();
                inno = obj.invoiceno;
                obj.productid = dgv_bill.Rows[i].Cells["productid"].Value.ToString();
                obj.description = dgv_bill.Rows[i].Cells["description"].Value.ToString();
                obj.quantity = Convert.ToInt32(dgv_bill.Rows[i].Cells["quantity"].Value.ToString());
                obj.discountprice = Convert.ToDecimal(dgv_bill.Rows[i].Cells["discountprice"].Value.ToString());
                obj.sellingprice = Convert.ToDecimal(dgv_bill.Rows[i].Cells["sellingprice"].Value.ToString());
                obj.totalprice = Convert.ToDecimal(dgv_bill.Rows[i].Cells["lastprice"].Value.ToString());
                obj.user = lbl_user.Text;
                list.Add(obj);
            }
            termlog.AddInvoiceLine(list);
            WaitDTO waitobj = new WaitDTO();
            waitobj.invoiceno = inno;
            waitobj.user = lbl_user.Text;
            waitobj.dates = DateTime.Now.ToShortDateString();
            waitlog.wait(waitobj);
            dgv_wait.DataSource = waitlog.GetWaitData();
            invoicelableincre();
            addclear();
            printclear();
        }
        */
        private void btn_clear_Click(object sender, EventArgs e)
        {
            addclear();
            printclear();
            list1.Clear();

        }

        private void btn_getbill_Click(object sender, EventArgs e)
        {
            int row = dgv_wait.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgv_wait.Rows[row].Cells["waitno"].Value.ToString());
            listwait = waitlog.GetBillBack(id);
            dgv_bill.DataSource = listwait;
            dgv_bill.Columns["waitno"].Visible = false;
            waitlog.DeleteWaitData(id);
             
            foreach (WaitProductDTO item in listwait)
            {
                ProductDTO p = new ProductDTO();
                p.barcode = item.barcode;
                p.description = item.description;
                p.discountprice = item.discountsp;
                p.lastprice = item.lastprice;
                p.productid = item.productid;
                p.quantity = item.quantity;
                p.sellingprice = item.sellingprice;
                p.total = item.total;
                listpro.Add(p);
            }
            //list1.AddRange(listpro);
            dgv_wait.DataSource = waitlog.GetWaitData();
            AddToBill();
        }

        private void AddToBill1()
        {




        }

        private void btn_debt_Click(object sender, EventArgs e)
        {
            
            Debt obj = new Debt();
            obj.ShowDialog();
            
            string total = txt_total.Text;
            string discount = txt_discount.Text;
            string totalprice = txt_totalprice.Text;
            string username = lbl_user.Text;
            obj.get(totalprice, lbl_username.Text, label21.Text, objk.CustomerID, label19.Text);
        }
        public CustomerDTO objk = new CustomerDTO();
        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_debt.Enabled = false;
            SelectCustomer objselect = new SelectCustomer();
            objselect.ShowDialog();
            objk = objselect.objs;

            label21.Text = objk.FullName;

        }

        public void updatetable()
        {
            foreach (ProductDTO item in list1)
            {
                ProductDTO obj = new ProductDTO();
                obj.barcode = item.barcode;
                obj.description = item.description;
                obj.sellingprice = item.sellingprice;
                obj.lastprice = item.lastprice;
                obj.productid = item.productid;
                obj.quantity = item.quantity;
                obj.total = item.total;
                obj.discountprice = item.discountprice;
                obj.discountquantity = item.discountquantity;
                obj.discountsp = item.discountsp;

                prolog.UpdateProAfterBill(obj);
            }


        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToProductgrid();
                AddToBill();
                addclear();
                txt_barcode.Focus();
                btn_add.Enabled = false; 
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.Text != "")
            {
                btn_add.Enabled = true;
            }
            else btn_add.Enabled = false;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv_bill.SelectedRows)
            {
                list1.RemoveAt(item.Index);

            }
            dgv_bill.DataSource = null;
            dgv_bill.Update();
            dgv_bill.Refresh();
            dgv_bill.DataSource = list1;
            dgv_bill.Columns["purchaseprice"].Visible = false;
            dgv_bill.Columns["discountquantity"].Visible = false;
            //dgv_bill.Columns["discountprice"].Visible = false;
            dgv_bill.Columns["expiredate"].Visible = false;
            dgv_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_barcode.Focus();
            AddToBill();
        }

        public void GetCusData(String name, int id)
        {
            label21.Text = name;
            cmb_paytype.SelectedIndex = 1;
            if (cmb_paytype.SelectedIndex == 1)
            {
                btn_search.Enabled = true;
            }
            if (cmb_paytype.SelectedIndex == 1 && label21.Text != "")
            {
                btn_search.Enabled = true;
                btn_debt.Enabled = true;
            }
        }
        public void WaitProduct()
        {
            int waitno = waitlog.GetWaitno();
            List<WaitProductDTO> listwait = new List<WaitProductDTO>();

            foreach (ProductDTO item in list1)
            {
                WaitProductDTO obj = new WaitProductDTO();
                obj.waitno = waitno;
                obj.productid = item.productid;
                obj.barcode = item.barcode;
                obj.description = item.description;
                obj.quantity = item.quantity;
                obj.sellingprice = item.sellingprice;
                obj.discountprice =  Convert.ToDecimal(item.discountprice);
                obj.total = item.total;
                obj.lastprice = item.lastprice;
                obj.discountsp = item.discountsp;
                listwait.Add(obj);
            }
            waitlog.WaitProductLast(listwait);
        }
        public void WaitBill()
        {
            String username = lbl_username.Text;
            String date = DateTime.Now.ToShortDateString();
            WaitDTO obj = new WaitDTO();
            obj.user = username;
            obj.dates = date;
            waitlog.WaitInvoice(obj);
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_productid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_productid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string productid = (txt_productid.Text);
                    dgv_product.DataSource = termlog.GetProductpro(productid);
                    dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    int rows = dgv_product.CurrentCell.RowIndex;
                    if (rows > -1)
                    {
                        txt_barcode.Text = dgv_product.Rows[rows].Cells["barcode"].Value.ToString();
                        txt_description.Text = dgv_product.Rows[rows].Cells["description"].Value.ToString();
                        txt_sellingprice.Text = dgv_product.Rows[rows].Cells["sellingprice"].Value.ToString();
                        purchaseprice = dgv_product.Rows[rows].Cells["purchaseprice"].Value.ToString();
                        expiredate = dgv_product.Rows[rows].Cells["expiredate"].Value.ToString();
                        discountprice = dgv_product.Rows[rows].Cells["discountprice"].Value.ToString();
                        discountquantity = dgv_product.Rows[rows].Cells["discountquantity"].Value.ToString();
                        dgv_product.Columns["total"].Visible = false;
                        dgv_product.Columns["lastprice"].Visible = false;
                        dgv_product.Columns["purchaseprice"].Visible = false;
                        //dgv_product.Columns["discountquantity"].Visible = false;
                        txt_quantity.Focus();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid ProductID");
            }

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            List<string> listnew = prolog.SuggestProduct();
            var listw = new AutoCompleteStringCollection();
            listw.AddRange(listnew.ToArray());
            txt_description.AutoCompleteCustomSource = listw;


            //List<string> listnew = prolog.SuggestProductpro1();
            //var listp = new AutoCompleteStringCollection();
            //listp.AddRange(listnew.ToArray());
            //txt_productid.AutoCompleteCustomSource = listp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics grapics = e.Graphics;
            Font font = new Font("Minion Pro", 11);
            float fontweight = font.GetHeight();



            int startx = 0;
            int starty = 0;
            int offset = 0;


            grapics.DrawString("KinTop", new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            grapics.DrawString("Super City", new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            grapics.DrawString("Kamburupitiya", new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            grapics.DrawString("0775291935", new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;

            string Date = label15.Text;
            string user = lbl_username.Text;
            int InvoiceN0 = Convert.ToInt32(lbl_invoiceno.Text);
            String dateuser = Date +" " +user+" " + "No:" + Convert.ToString(InvoiceN0);
            grapics.DrawString(dateuser, new Font("Courier New", 8), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            String underLine = "------------------------------------------";
            grapics.DrawString(underLine, new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;

            String Price = "ITEM  QTY  UPRC    AMT    LPRC";
            grapics.DrawString(Price, new Font("Courier New", 9), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            grapics.DrawString(underLine, new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            int i = 1;
            foreach (ProductDTO item in list1)
            {



                String Productid = item.productid.PadRight(7);
                String ProductDescrip = item.description.PadRight(8);
                String Quntity = Convert.ToString(item.quantity).PadRight(0);
                String SelingPrice = Convert.ToString(item.sellingprice).PadRight(9);
                String Realcost = Convert.ToString(item.total).PadRight(8);
                String Lastprice = Convert.ToString(item.lastprice).PadRight(0);
                String productline = Productid + Quntity + "*" + SelingPrice + Realcost + Lastprice;
                grapics.DrawString(Convert.ToString(i) + " " + ProductDescrip, new Font("Courier New", 8), new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + (int)fontweight + 6;
                grapics.DrawString(productline, new Font("Courier New", 8), new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + (int)fontweight + 6;
                i++;

            }
            foreach (ProductDTO item in listpro)
            {



                String Productid = item.productid.PadRight(7);
                String ProductDescrip = item.description.PadRight(8);
                String Quntity = Convert.ToString(item.quantity).PadRight(0);
                String SelingPrice = Convert.ToString(item.sellingprice).PadRight(9);
                String Realcost = Convert.ToString(item.total).PadRight(8);
                String Lastprice = Convert.ToString(item.lastprice).PadRight(0);
                String productline = Productid + Quntity + "*" + SelingPrice + Realcost + Lastprice;
                grapics.DrawString(Convert.ToString(i) + " " + ProductDescrip, new Font("Courier New", 8), new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + (int)fontweight + 6;
                grapics.DrawString(productline, new Font("Courier New", 8), new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + (int)fontweight + 6;
                i++;

            }
            grapics.DrawString(underLine, new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;
            grapics.DrawString("Total       :" + totf.PadRight(10), new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            grapics.DrawString("Discount    :" + dis.PadRight(10), new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            grapics.DrawString("Total Price :" + totl.PadRight(10), new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            grapics.DrawString("Thank you Come Again !!!", new Font("Courier New", 11), new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
        }

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string des = (txt_description.Text);
                    dgv_product.DataSource = termlog.GetDescriptionpro(des);
                    dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    int rows = dgv_product.CurrentCell.RowIndex;
                    if (rows > -1)
                    {
                       
                        txt_barcode.Text = dgv_product.Rows[rows].Cells["barcode"].Value.ToString();
                        txt_productid.Text = dgv_product.Rows[rows].Cells["productid"].Value.ToString();
                        txt_sellingprice.Text = dgv_product.Rows[rows].Cells["sellingprice"].Value.ToString();
                        purchaseprice = dgv_product.Rows[rows].Cells["purchaseprice"].Value.ToString();
                        expiredate = dgv_product.Rows[rows].Cells["expiredate"].Value.ToString();
                        discountprice = dgv_product.Rows[rows].Cells["discountprice"].Value.ToString();
                        discountquantity = dgv_product.Rows[rows].Cells["discountquantity"].Value.ToString();
                        dgv_product.Columns["total"].Visible = false;
                        dgv_product.Columns["lastprice"].Visible = false;
                        dgv_product.Columns["purchaseprice"].Visible = false;
                        //dgv_product.Columns["discountquantity"].Visible = false;
                        txt_quantity.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Description");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            Addexternalproduct windowex = new Addexternalproduct();
            windowex.Show();
        }

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                setheader();
                setline();
                totf = txt_total.Text;
                dis = txt_discount.Text;
                totl = txt_totalprice.Text;
                int id = inlog.getinvoiceno();


                int idline = linelog.getinvoiceno();
                if (id == idline)
                {
                    id = idline + 1;
                }
                else
                    id = id + 1;
                lbl_invoiceno.Text = id.ToString();

                txt_barcode.Focus();


                updatetable();
                Printrecipt();
                addclear();
                printclear();
                list1.Clear();
                listpro.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_productid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                try
                {
                    setheader();
                    setline();
                    totf = txt_total.Text;
                    dis = txt_discount.Text;
                    totl = txt_totalprice.Text;
                    int id = inlog.getinvoiceno();


                    int idline = linelog.getinvoiceno();
                    if (id == idline)
                    {
                        id = idline + 1;
                    }
                    else
                        id = id + 1;
                    lbl_invoiceno.Text = id.ToString();

                    txt_barcode.Focus();


                    updatetable();
                    Printrecipt();
                    addclear();
                    printclear();
                    list1.Clear();
                    listpro.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

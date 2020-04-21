namespace kingtopproduct
{
    partial class kingtopterminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kingtopterminal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_debt = new System.Windows.Forms.Button();
            this.btn_getbill = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_wait = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_waitbill = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_paytype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_invoiceno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_discountsp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_sellingprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.btn_addproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_debt
            // 
            this.btn_debt.Location = new System.Drawing.Point(339, 58);
            this.btn_debt.Name = "btn_debt";
            this.btn_debt.Size = new System.Drawing.Size(97, 23);
            this.btn_debt.TabIndex = 124;
            this.btn_debt.Text = "Debt";
            this.btn_debt.UseVisualStyleBackColor = true;
            this.btn_debt.Click += new System.EventHandler(this.btn_debt_Click);
            this.btn_debt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_getbill
            // 
            this.btn_getbill.Image = ((System.Drawing.Image)(resources.GetObject("btn_getbill.Image")));
            this.btn_getbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_getbill.Location = new System.Drawing.Point(349, 266);
            this.btn_getbill.Name = "btn_getbill";
            this.btn_getbill.Size = new System.Drawing.Size(98, 52);
            this.btn_getbill.TabIndex = 123;
            this.btn_getbill.Text = "Get Bill";
            this.btn_getbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_getbill.UseVisualStyleBackColor = true;
            this.btn_getbill.Click += new System.EventHandler(this.btn_getbill_Click);
            this.btn_getbill.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(464, -42);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 20);
            this.lbl_user.TabIndex = 122;
            this.lbl_user.Text = "User";
            this.lbl_user.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_totalprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_totalprice.Enabled = false;
            this.txt_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Maroon;
            this.txt_totalprice.Location = new System.Drawing.Point(975, 531);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(247, 40);
            this.txt_totalprice.TabIndex = 121;
            this.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_totalprice.TextChanged += new System.EventHandler(this.txt_totalprice_TextChanged);
            this.txt_totalprice.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Enabled = false;
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(975, 476);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(247, 24);
            this.txt_discount.TabIndex = 120;
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Red;
            this.txt_total.Location = new System.Drawing.Point(975, 418);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(247, 24);
            this.txt_total.TabIndex = 119;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            this.txt_total.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(839, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 30);
            this.label11.TabIndex = 118;
            this.label11.Text = "Total Price";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            this.label11.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(839, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 30);
            this.label12.TabIndex = 117;
            this.label12.Text = "Discount";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(839, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 30);
            this.label13.TabIndex = 116;
            this.label13.Text = "Total";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // dgv_wait
            // 
            this.dgv_wait.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_wait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_wait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_wait.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_wait.Location = new System.Drawing.Point(9, 30);
            this.dgv_wait.Name = "dgv_wait";
            this.dgv_wait.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_wait.Size = new System.Drawing.Size(486, 81);
            this.dgv_wait.TabIndex = 113;
            this.dgv_wait.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_clear
            // 
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(564, 266);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 52);
            this.btn_clear.TabIndex = 112;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_waitbill
            // 
            this.btn_waitbill.Image = ((System.Drawing.Image)(resources.GetObject("btn_waitbill.Image")));
            this.btn_waitbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_waitbill.Location = new System.Drawing.Point(238, 266);
            this.btn_waitbill.Name = "btn_waitbill";
            this.btn_waitbill.Size = new System.Drawing.Size(107, 52);
            this.btn_waitbill.TabIndex = 111;
            this.btn_waitbill.Text = "Wait Bill";
            this.btn_waitbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_waitbill.UseVisualStyleBackColor = true;
            this.btn_waitbill.Click += new System.EventHandler(this.btn_waitbill_Click);
            this.btn_waitbill.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_print
            // 
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(124, 266);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(108, 52);
            this.btn_print.TabIndex = 110;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            this.btn_print.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(12, 266);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 52);
            this.btn_add.TabIndex = 109;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_KeyDown);
            this.btn_add.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(236, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 23);
            this.btn_search.TabIndex = 108;
            this.btn_search.Text = "Select Customer ";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // cmb_paytype
            // 
            this.cmb_paytype.FormattingEnabled = true;
            this.cmb_paytype.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cmb_paytype.Location = new System.Drawing.Point(109, 58);
            this.cmb_paytype.Name = "cmb_paytype";
            this.cmb_paytype.Size = new System.Drawing.Size(121, 24);
            this.cmb_paytype.TabIndex = 107;
            this.cmb_paytype.SelectedIndexChanged += new System.EventHandler(this.cmb_paytype_SelectedIndexChanged);
            this.cmb_paytype.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "Payment Type";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            this.label10.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // dgv_bill
            // 
            this.dgv_bill.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bill.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_bill.Location = new System.Drawing.Point(7, 335);
            this.dgv_bill.Name = "dgv_bill";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dgv_bill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bill.Size = new System.Drawing.Size(804, 386);
            this.dgv_bill.TabIndex = 105;
            this.dgv_bill.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, -42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 29);
            this.label8.TabIndex = 102;
            this.label8.Text = "Kingtop";
            this.label8.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // lbl_invoiceno
            // 
            this.lbl_invoiceno.AutoSize = true;
            this.lbl_invoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceno.Location = new System.Drawing.Point(769, -52);
            this.lbl_invoiceno.Name = "lbl_invoiceno";
            this.lbl_invoiceno.Size = new System.Drawing.Size(61, 18);
            this.lbl_invoiceno.TabIndex = 97;
            this.lbl_invoiceno.Text = "Number";
            this.lbl_invoiceno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, -52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 96;
            this.label6.Text = "Invoice No";
            this.label6.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(517, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 119;
            this.label15.Text = "label15";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            this.label15.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(452, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 20);
            this.label16.TabIndex = 118;
            this.label16.Text = "Date";
            this.label16.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1074, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 122;
            this.label20.Text = "Invoice No";
            this.label20.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1217, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 123;
            this.label19.Text = "label19";
            this.label19.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 116;
            this.label7.Text = "Casier";
            this.label7.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 15);
            this.label22.TabIndex = 124;
            this.label22.Text = "Customer Name";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            this.label22.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(109, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 15);
            this.label21.TabIndex = 125;
            this.label21.Click += new System.EventHandler(this.label21_Click);
            this.label21.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(702, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 95;
            this.label5.Text = "Discount SP";
            this.label5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_discountsp
            // 
            this.txt_discountsp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_discountsp.Location = new System.Drawing.Point(708, 125);
            this.txt_discountsp.Name = "txt_discountsp";
            this.txt_discountsp.Size = new System.Drawing.Size(104, 20);
            this.txt_discountsp.TabIndex = 103;
            this.txt_discountsp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(578, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 94;
            this.label4.Text = "Quantity";
            this.label4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_quantity.Location = new System.Drawing.Point(578, 125);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(121, 20);
            this.txt_quantity.TabIndex = 101;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_KeyDown);
            this.txt_quantity.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_sellingprice
            // 
            this.txt_sellingprice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_sellingprice.Location = new System.Drawing.Point(456, 125);
            this.txt_sellingprice.Name = "txt_sellingprice";
            this.txt_sellingprice.ReadOnly = true;
            this.txt_sellingprice.Size = new System.Drawing.Size(121, 20);
            this.txt_sellingprice.TabIndex = 115;
            this.txt_sellingprice.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(136, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "ProductID";
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(256, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 93;
            this.label3.Text = "Description";
            this.label3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_description
            // 
            this.txt_description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_description.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_description.Location = new System.Drawing.Point(258, 125);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(191, 20);
            this.txt_description.TabIndex = 100;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_description_KeyDown);
            this.txt_description.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_productid
            // 
            this.txt_productid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_productid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_productid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_productid.Location = new System.Drawing.Point(139, 125);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(114, 20);
            this.txt_productid.TabIndex = 99;
            this.txt_productid.TextChanged += new System.EventHandler(this.txt_productid_TextChanged);
            this.txt_productid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productid_KeyDown);
            this.txt_productid.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // txt_barcode
            // 
            this.txt_barcode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_barcode.Location = new System.Drawing.Point(15, 125);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(118, 20);
            this.txt_barcode.TabIndex = 98;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            this.txt_barcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // dgv_product
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dgv_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_product.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_product.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_product.Location = new System.Drawing.Point(12, 151);
            this.dgv_product.Name = "dgv_product";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dgv_product.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(799, 89);
            this.dgv_product.TabIndex = 104;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            this.dgv_product.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 72);
            this.pictureBox3.TabIndex = 126;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(363, 30);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 20);
            this.lbl_username.TabIndex = 117;
            this.lbl_username.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_paytype);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.btn_debt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(824, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 104);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Select";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_wait);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(824, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 122);
            this.groupBox2.TabIndex = 128;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wait bill";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            this.groupBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1341, 79);
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 91;
            this.label14.Text = "Barcode";
            this.label14.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(450, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 114;
            this.label9.Text = "Selling Price";
            this.label9.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(453, 266);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(105, 52);
            this.btn_Delete.TabIndex = 133;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(675, 266);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(87, 52);
            this.btn_addproduct.TabIndex = 134;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            this.btn_addproduct.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_productid_PreviewKeyDown);
            // 
            // kingtopterminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1284, 733);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_getbill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dgv_bill);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_productid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_waitbill);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_discountsp);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.txt_sellingprice);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_invoiceno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "kingtopterminal";
            this.Text = "kingtopterminal";
            this.Load += new System.EventHandler(this.kingtopterminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_debt;
        private System.Windows.Forms.Button btn_getbill;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_wait;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_waitbill;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_paytype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_invoiceno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_discountsp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_sellingprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Button btn_addproduct;
    }
}
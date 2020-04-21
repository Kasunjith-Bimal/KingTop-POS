namespace kingtopproduct
{
    partial class SelectCustomer
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
            this.lbl_customername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.btn_select = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Location = new System.Drawing.Point(30, 39);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(77, 13);
            this.lbl_customername.TabIndex = 0;
            this.lbl_customername.Text = "Customername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(113, 32);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(164, 20);
            this.txt_customername.TabIndex = 2;
            // 
            // txt_customerid
            // 
            this.txt_customerid.Location = new System.Drawing.Point(113, 68);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(164, 20);
            this.txt_customerid.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(337, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(148, 20);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            " ID",
            " Name"});
            this.cmb_search.Location = new System.Drawing.Point(491, 31);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(83, 21);
            this.cmb_search.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(591, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_customer
            // 
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Location = new System.Drawing.Point(29, 154);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.ReadOnly = true;
            this.dgv_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customer.Size = new System.Drawing.Size(637, 294);
            this.dgv_customer.TabIndex = 7;
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick);
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(113, 106);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.dgv_customer);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_customername);
            this.Name = "SelectCustomer";
            this.Text = "SelectCustomer";
            this.Load += new System.EventHandler(this.SelectCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button button3;
    }
}
namespace kingtopproduct
{
    partial class Debt
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
            this.lbl_cusname = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_debt = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.lbl_debt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cusname
            // 
            this.lbl_cusname.AutoSize = true;
            this.lbl_cusname.Location = new System.Drawing.Point(213, 44);
            this.lbl_cusname.Name = "lbl_cusname";
            this.lbl_cusname.Size = new System.Drawing.Size(82, 13);
            this.lbl_cusname.TabIndex = 22;
            this.lbl_cusname.Text = "Customer Name";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(414, 159);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 37);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(317, 159);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 37);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(211, 159);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 37);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 291);
            this.dataGridView1.TabIndex = 18;
            // 
            // txt_debt
            // 
            this.txt_debt.Location = new System.Drawing.Point(216, 85);
            this.txt_debt.Name = "txt_debt";
            this.txt_debt.Size = new System.Drawing.Size(248, 20);
            this.txt_debt.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(601, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(349, 37);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 15;
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "invoiceno",
            "customername"});
            this.cmb_search.Location = new System.Drawing.Point(465, 36);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 21);
            this.cmb_search.TabIndex = 14;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            // 
            // lbl_debt
            // 
            this.lbl_debt.AutoSize = true;
            this.lbl_debt.Location = new System.Drawing.Point(116, 92);
            this.lbl_debt.Name = "lbl_debt";
            this.lbl_debt.Size = new System.Drawing.Size(69, 13);
            this.lbl_debt.TabIndex = 13;
            this.lbl_debt.Text = "Debt Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customername";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pay Amount";
            // 
            // Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cusname);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_debt);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.lbl_debt);
            this.Name = "Debt";
            this.Text = "Debt";
            this.Load += new System.EventHandler(this.Debt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cusname;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_debt;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label lbl_debt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}
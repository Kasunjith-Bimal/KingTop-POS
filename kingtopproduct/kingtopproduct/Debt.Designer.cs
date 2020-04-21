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
            this.lbl_debt = new System.Windows.Forms.Label();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_debt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_invoiceno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_debt
            // 
            this.lbl_debt.AutoSize = true;
            this.lbl_debt.Location = new System.Drawing.Point(53, 68);
            this.lbl_debt.Name = "lbl_debt";
            this.lbl_debt.Size = new System.Drawing.Size(69, 13);
            this.lbl_debt.TabIndex = 2;
            this.lbl_debt.Text = "Debt Amount";
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(402, 12);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 21);
            this.cmb_search.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(286, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(538, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_debt
            // 
            this.txt_debt.Location = new System.Drawing.Point(153, 61);
            this.txt_debt.Name = "txt_debt";
            this.txt_debt.Size = new System.Drawing.Size(248, 20);
            this.txt_debt.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 291);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(153, 103);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 37);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(259, 103);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 37);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(356, 103);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 37);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // lbl_invoiceno
            // 
            this.lbl_invoiceno.AutoSize = true;
            this.lbl_invoiceno.Location = new System.Drawing.Point(72, 36);
            this.lbl_invoiceno.Name = "lbl_invoiceno";
            this.lbl_invoiceno.Size = new System.Drawing.Size(35, 13);
            this.lbl_invoiceno.TabIndex = 12;
            this.lbl_invoiceno.Text = "label1";
            // 
            // Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 471);
            this.Controls.Add(this.lbl_invoiceno);
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

        private System.Windows.Forms.Label lbl_debt;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_debt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_invoiceno;
    }
}
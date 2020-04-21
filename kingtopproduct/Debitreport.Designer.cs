namespace kingtopproduct
{
    partial class Debitreport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_cusname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSet2 = new kingtopproduct.DataSet2();
            this.debtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtTableAdapter = new kingtopproduct.DataSet2TableAdapters.debtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.debtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kingtopproduct.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(101, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 246);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(577, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 22);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_cusname
            // 
            this.txt_cusname.Location = new System.Drawing.Point(400, 32);
            this.txt_cusname.Name = "txt_cusname";
            this.txt_cusname.Size = new System.Drawing.Size(138, 20);
            this.txt_cusname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Customer ";
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtBindingSource
            // 
            this.debtBindingSource.DataMember = "debt";
            this.debtBindingSource.DataSource = this.DataSet2;
            // 
            // debtTableAdapter
            // 
            this.debtTableAdapter.ClearBeforeFill = true;
            // 
            // Debitreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cusname);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Debitreport";
            this.Text = "Debitreport";
            this.Load += new System.EventHandler(this.Debitreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_cusname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource debtBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.debtTableAdapter debtTableAdapter;
    }
}
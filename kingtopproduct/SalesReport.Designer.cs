namespace kingtopproduct
{
    partial class SalesReport
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
            this.invoiceheaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new kingtopproduct.DataSet1();
            this.dtp_showdate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_search = new System.Windows.Forms.Button();
            this.invoiceheaderTableAdapter = new kingtopproduct.DataSet1TableAdapters.invoiceheaderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceheaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceheaderBindingSource
            // 
            this.invoiceheaderBindingSource.DataMember = "invoiceheader";
            this.invoiceheaderBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtp_showdate
            // 
            this.dtp_showdate.Location = new System.Drawing.Point(266, 33);
            this.dtp_showdate.Name = "dtp_showdate";
            this.dtp_showdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_showdate.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.invoiceheaderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kingtopproduct.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(110, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 643);
            this.reportViewer1.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(499, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // invoiceheaderTableAdapter
            // 
            this.invoiceheaderTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(878, 741);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtp_showdate);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceheaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_showdate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource invoiceheaderBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.invoiceheaderTableAdapter invoiceheaderTableAdapter;
        private System.Windows.Forms.Button btn_search;
    }
}
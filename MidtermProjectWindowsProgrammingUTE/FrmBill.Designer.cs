
namespace MidtermProjectWindowsProgrammingUTE
{
    partial class FrmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBill));
            this.HoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyKhachSan = new MidtermProjectWindowsProgrammingUTE.QuanLyKhachSan();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new MidtermProjectWindowsProgrammingUTE.QuanLyKhachSanTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDon
            // 
            this.HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QLKS";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.HoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.HoaDon.LocalReport.ReportEmbeddedResource = "MidtermProjectWindowsProgrammingUTE.Bill.rdlc";
            this.HoaDon.Location = new System.Drawing.Point(0, 0);
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.ServerReport.BearerToken = null;
            this.HoaDon.Size = new System.Drawing.Size(1359, 806);
            this.HoaDon.TabIndex = 0;
            // 
            // QuanLyKhachSan
            // 
            this.QuanLyKhachSan.DataSetName = "QuanLyKhachSan";
            this.QuanLyKhachSan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.QuanLyKhachSan;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 806);
            this.Controls.Add(this.HoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBill";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer HoaDon;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private QuanLyKhachSan QuanLyKhachSan;
        private QuanLyKhachSanTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
    }
}
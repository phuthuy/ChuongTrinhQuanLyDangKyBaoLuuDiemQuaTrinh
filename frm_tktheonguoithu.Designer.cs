namespace ThuHocPhi.Views.Thuhocphi.TKHP_theonguoithu
{
    partial class frm_tktheonguoithu
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
            this.dkbldqtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDongHP = new ThuHocPhi.dsDongHP();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dkbldqtTableAdapter = new ThuHocPhi.dsDongHPTableAdapters.dkbldqtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dkbldqtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dkbldqtBindingSource
            // 
            this.dkbldqtBindingSource.DataMember = "dkbldqt";
            this.dkbldqtBindingSource.DataSource = this.dsDongHP;
            // 
            // dsDongHP
            // 
            this.dsDongHP.DataSetName = "dsDongHP";
            this.dsDongHP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Datadstheonguoithu";
            reportDataSource1.Value = this.dkbldqtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuHocPhi.Views.Thuhocphi.TKHP_theonguoithu.rp_dstheonguoithu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(711, 365);
            this.reportViewer1.TabIndex = 0;
            // 
            // dkbldqtTableAdapter
            // 
            this.dkbldqtTableAdapter.ClearBeforeFill = true;
            // 
            // frm_tktheonguoithu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 365);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_tktheonguoithu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_tktheonguoithu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_tktheonguoithu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dkbldqtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dkbldqtBindingSource;
        private dsDongHP dsDongHP;
        private dsDongHPTableAdapters.dkbldqtTableAdapter dkbldqtTableAdapter;
    }
}
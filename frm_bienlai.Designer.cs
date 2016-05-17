namespace ThuHocPhi.Views.Thuhocphi
{
    partial class  frm_bienlai
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDongHP = new ThuHocPhi.dsDongHP();
            this.viewdsdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_dsdongTableAdapter = new ThuHocPhi.dsDongHPTableAdapters.View_dsdongTableAdapter();
            this.data_inbienlai = new ThuHocPhi.Views.Thuhocphi.InBienLai.data_inbienlai();
            this.datainbienlaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kqdkdqtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kqdk_dqtTableAdapter = new ThuHocPhi.Views.Thuhocphi.InBienLai.data_inbienlaiTableAdapters.kqdk_dqtTableAdapter();
            this.kqdkdqtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdsdongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_inbienlai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datainbienlaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdkdqtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdkdqtBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "data_inbienlai";
            reportDataSource2.Value = this.kqdkdqtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuHocPhi.Views.Thuhocphi.rp_inbienlai.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsDongHP
            // 
            this.dsDongHP.DataSetName = "dsDongHP";
            this.dsDongHP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewdsdongBindingSource
            // 
            this.viewdsdongBindingSource.DataMember = "View_dsdong";
            this.viewdsdongBindingSource.DataSource = this.dsDongHP;
            // 
            // view_dsdongTableAdapter
            // 
            this.view_dsdongTableAdapter.ClearBeforeFill = true;
            // 
            // data_inbienlai
            // 
            this.data_inbienlai.DataSetName = "data_inbienlai";
            this.data_inbienlai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datainbienlaiBindingSource
            // 
            this.datainbienlaiBindingSource.DataSource = this.data_inbienlai;
            this.datainbienlaiBindingSource.Position = 0;
            // 
            // kqdkdqtBindingSource
            // 
            this.kqdkdqtBindingSource.DataMember = "kqdk_dqt";
            this.kqdkdqtBindingSource.DataSource = this.datainbienlaiBindingSource;
            // 
            // kqdk_dqtTableAdapter
            // 
            this.kqdk_dqtTableAdapter.ClearBeforeFill = true;
            // 
            // kqdkdqtBindingSource1
            // 
            this.kqdkdqtBindingSource1.DataMember = "kqdk_dqt";
            this.kqdkdqtBindingSource1.DataSource = this.datainbienlaiBindingSource;
            // 
            // frm_bienlai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_bienlai";
            this.Text = "frm_bienlai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_bienlai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdsdongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_inbienlai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datainbienlaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdkdqtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdkdqtBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewdsdongBindingSource;
        private dsDongHP dsDongHP;
        private dsDongHPTableAdapters.View_dsdongTableAdapter view_dsdongTableAdapter;
        private System.Windows.Forms.BindingSource datainbienlaiBindingSource;
        private ThuHocPhi.Views.Thuhocphi.InBienLai.data_inbienlai data_inbienlai;
        private System.Windows.Forms.BindingSource kqdkdqtBindingSource;
        private InBienLai.data_inbienlaiTableAdapters.kqdk_dqtTableAdapter kqdk_dqtTableAdapter;
        private System.Windows.Forms.BindingSource kqdkdqtBindingSource1;
    }
}
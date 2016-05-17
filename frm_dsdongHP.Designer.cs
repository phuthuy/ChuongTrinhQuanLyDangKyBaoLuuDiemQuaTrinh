namespace ThuHocPhi.Views.Thuhocphi
{
    partial class frm_dsdongHP
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
            this.dsDongHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDongHP = new ThuHocPhi.dsDongHP();
            this.View_dsdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewdsdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_dsdongTableAdapter = new ThuHocPhi.dsDongHPTableAdapters.View_dsdongTableAdapter();
            this.dkbldqtTableAdapter = new ThuHocPhi.dsDongHPTableAdapters.dkbldqtTableAdapter();
            this.dkbldqtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dkbldqtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_dsdongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdsdongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkbldqtBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dkbldqtBindingSource
            // 
            this.dkbldqtBindingSource.DataMember = "dkbldqt";
            this.dkbldqtBindingSource.DataSource = this.dsDongHPBindingSource;
            // 
            // dsDongHPBindingSource
            // 
            this.dsDongHPBindingSource.DataSource = this.dsDongHP;
            this.dsDongHPBindingSource.Position = 0;
            // 
            // dsDongHP
            // 
            this.dsDongHP.DataSetName = "dsDongHP";
            this.dsDongHP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_dsdongBindingSource
            // 
            this.View_dsdongBindingSource.DataMember = "View_dsdong";
            this.View_dsdongBindingSource.DataSource = this.dsDongHP;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.dkbldqtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuHocPhi.Views.Thuhocphi.rp_dsdongHP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 400);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // viewdsdongBindingSource
            // 
            this.viewdsdongBindingSource.DataMember = "View_dsdong";
            this.viewdsdongBindingSource.DataSource = this.dsDongHPBindingSource;
            // 
            // view_dsdongTableAdapter
            // 
            this.view_dsdongTableAdapter.ClearBeforeFill = true;
            // 
            // dkbldqtTableAdapter
            // 
            this.dkbldqtTableAdapter.ClearBeforeFill = true;
            // 
            // dkbldqtBindingSource1
            // 
            this.dkbldqtBindingSource1.DataMember = "dkbldqt";
            this.dkbldqtBindingSource1.DataSource = this.dsDongHPBindingSource;
            // 
            // frm_dsdongHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 405);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_dsdongHP";
            this.Text = "frm_dsdongHP";
            this.Load += new System.EventHandler(this.frm_dsdongHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dkbldqtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_dsdongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdsdongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkbldqtBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewdsdongBindingSource;
        private System.Windows.Forms.BindingSource dsDongHPBindingSource;
        private dsDongHP dsDongHP;
        private dsDongHPTableAdapters.View_dsdongTableAdapter view_dsdongTableAdapter;
        private System.Windows.Forms.BindingSource View_dsdongBindingSource;
        private System.Windows.Forms.BindingSource dkbldqtBindingSource;
        private dsDongHPTableAdapters.dkbldqtTableAdapter dkbldqtTableAdapter;
        private System.Windows.Forms.BindingSource dkbldqtBindingSource1;
    }
}
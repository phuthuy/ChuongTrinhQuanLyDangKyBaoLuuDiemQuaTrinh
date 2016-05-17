namespace ThuHocPhi.Views.Thuhocphi
{
    partial class frm_xemDLCanthu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataHocphi = new ThuHocPhi.DataHocphi();
            this.kqdk_dqt1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kqdk_dqt1TableAdapter = new ThuHocPhi.DataHocphiTableAdapters.kqdk_dqt1TableAdapter();
            this.tableAdapterManager = new ThuHocPhi.DataHocphiTableAdapters.TableAdapterManager();
            this.kqdk_dqt1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHocphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdk_dqt1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdk_dqt1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kqdk_dqt1DataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 433);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SV:";
            // 
            // dataHocphi
            // 
            this.dataHocphi.DataSetName = "DataHocphi";
            this.dataHocphi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kqdk_dqt1BindingSource
            // 
            this.kqdk_dqt1BindingSource.DataMember = "kqdk_dqt1";
            this.kqdk_dqt1BindingSource.DataSource = this.dataHocphi;
            // 
            // kqdk_dqt1TableAdapter
            // 
            this.kqdk_dqt1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.dkbldqt1TableAdapter = null;
            this.tableAdapterManager.HocKyTableAdapter = null;
            this.tableAdapterManager.kqdk_dqtTableAdapter = null;
            this.tableAdapterManager.kqthuhocphi17_2TableAdapter = null;
            this.tableAdapterManager.KQTHUHOCPHI19_2TableAdapter = null;
            this.tableAdapterManager.kqthuhocphi22_2TableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuHocPhi.DataHocphiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // kqdk_dqt1DataGridView
            // 
            this.kqdk_dqt1DataGridView.AutoGenerateColumns = false;
            this.kqdk_dqt1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kqdk_dqt1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kqdk_dqt1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kqdk_dqt1DataGridView.DataSource = this.kqdk_dqt1BindingSource;
            this.kqdk_dqt1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kqdk_dqt1DataGridView.Location = new System.Drawing.Point(0, 0);
            this.kqdk_dqt1DataGridView.Name = "kqdk_dqt1DataGridView";
            this.kqdk_dqt1DataGridView.Size = new System.Drawing.Size(697, 433);
            this.kqdk_dqt1DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã SV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lop";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TongSoTC";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng Số TC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frm_xemDLCanthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_xemDLCanthu";
            this.Text = "frm_xemDLCanthu";
            this.Load += new System.EventHandler(this.frm_xemDLCanthu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHocphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdk_dqt1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kqdk_dqt1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DataHocphi dataHocphi;
        private System.Windows.Forms.BindingSource kqdk_dqt1BindingSource;
        private DataHocphiTableAdapters.kqdk_dqt1TableAdapter kqdk_dqt1TableAdapter;
        private DataHocphiTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kqdk_dqt1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
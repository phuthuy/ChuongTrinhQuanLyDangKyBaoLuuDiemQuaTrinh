using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuHocPhi.DataHocphiTableAdapters;
using ThuHocPhi.Shares;
using ThuHocPhi.Views.Thuhocphi;

namespace ThuHocPhi.Views
{
    
    public partial class frm_inbienlai : Form
    {
        public frm_inbienlai()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_inbienlai_Load(object sender, EventArgs e)
        {

        }
        DataDataContext db = new DataDataContext();
        //DataSet db = new DataSet();
       // List<data_inbienlai> dt = new List<data_inbienlai>();
      // kqdk_dqtTableAdapter.kqdk_dqt a = new kqdk_dqtTableAdapter.kqdk_dqt(); 
        private void txt_mssv_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_mssv_TextChanged(object sender, EventArgs e)
        {
            string  ma = txt_mssv.Text;
            var qr = db.view_thuhocphis.Where(o => o.MaSV == ma);
            string tien = txt_tien.Text;
            // var qr = db.kqdk_dqts.Where(o => o.MaSV == ma);
            if (qr.Count() > 0)
            {
                view_thuhocphi i = qr.SingleOrDefault();
                txt_ten.Text = i.HoTen;
                txt_tien.Text = i.TongTien.ToString();
                Constants.masv = ma;
                Constants.tensv = txt_ten.Text;
                Constants.sotien = txt_tien.Text;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_ten.Text = "";
            txt_mssv.Text = "";
            txt_tien.Text = "";
            Views.Thuhocphi.frm_bienlai f = new frm_bienlai();
            f.ShowDialog();
        }
    }
}

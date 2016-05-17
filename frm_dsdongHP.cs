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
using ThuHocPhi.Shares;

namespace ThuHocPhi.Views.Thuhocphi
{
    public partial class frm_dsdongHP : Form
    {
        public frm_dsdongHP()
        {
            InitializeComponent();
        }

        private void frm_dsdongHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDongHP.View_dsdong' table. You can move, or remove it, as needed.
          
            int hki = 1;
            
            this.reportViewer1.RefreshReport();
            this.dkbldqtTableAdapter.Fill(this.dsDongHP.dkbldqt, hki);
           // this.view_dsdongTableAdapter.Fill(this.dsDongHP.View_dsdong, hki);
           ReportParameter[] parameter = new ReportParameter[2];
            //khai báo một mảng tham số ở đây mình có 2 tham số
           
            parameter[0] = new ReportParameter("@HocKyID");
            parameter[0].Values.Add("Học kỳ 1 Năm 2015-2016");
            parameter[1] = new ReportParameter("@NguoiThu");
            parameter[1].Values.Add(Shares.Constants.luutk);
            //parameter[2] = new ReportParameter("nam");
            //parameter[2].Values.Add(Shares.Constants.Get_Year());
            //parameter[3] = new ReportParameter("user");
            //parameter[3].Values.Add(Constants.luutk);
            //reportViewer1.LocalReport.SetParameters(parameter);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace ThuHocPhi.Views.Thuhocphi.TKHP_theonguoithu
{
    public partial class frm_tktheonguoithu : Form
    {
        public frm_tktheonguoithu()
        {
            InitializeComponent();
        }

        private void frm_tktheonguoithu_Load(object sender, EventArgs e)
        {
            List<ReportParameter> Parameters = new List<ReportParameter>();
            //Tạo danh sách các Parameter để truyền cho Report 
            ReportParameter param = default(ReportParameter);
            param = new ReportParameter("user", Constants.luutk);
            //Parameters.Add(param);
            //param = new ReportParameter("txt_ten", Constants.tensv);
            //Parameters.Add(param);
            //param = new ReportParameter("txt_tien", Constants.sotien);
            Parameters.Add(param);
            reportViewer1.LocalReport.SetParameters(Parameters);
            this.dkbldqtTableAdapter.FillBy(this.dsDongHP.dkbldqt, Constants.luuhk, Constants.luutk);
            this.reportViewer1.RefreshReport();
        }
    }
}

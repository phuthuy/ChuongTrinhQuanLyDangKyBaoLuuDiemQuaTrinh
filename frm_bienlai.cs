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
using ThuHocPhi.Views.Thuhocphi;

namespace ThuHocPhi.Views.Thuhocphi
{
    public partial class frm_bienlai : Form
    {
        public frm_bienlai()
        {
            InitializeComponent();
        }

        private void frm_bienlai_Load(object sender, EventArgs e)
        {
            this.kqdk_dqtTableAdapter.Fill(this.data_inbienlai.kqdk_dqt , Constants.masv, 1);
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
            this.reportViewer1.RefreshReport();
            
            

        }
    }
}

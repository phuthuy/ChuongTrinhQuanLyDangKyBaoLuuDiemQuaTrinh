using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuHocPhi.Controls.Tudien;
using ThuHocPhi.Models;
using ThuHocPhi.Shares;

namespace ThuHocPhi.Views.TuDien
{
    public partial class frm_CapnhatSV : Form
    {
        DataDataContext db = new DataDataContext();
        sinhvien_ctrl sv_ctrl = new sinhvien_ctrl();
        public frm_CapnhatSV()
        {
            InitializeComponent();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

            
                if (txt_masv.Text == "")
                {
                    MessageBox.Show(String.Format(Constants.msg_Err_NullData, "Mã sinh viên"), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_masv.Focus();
                }
                else
                {
                    var rs = sv_ctrl.UpdateSV(txt_masv.Text,txt_hoten.Text,txt_lop.Text);
                    switch (rs.ErrCode)
                    {
                        case CEnum.HaveNoData:
                            MessageBox.Show(rs.ErrDesc, Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case CEnum.Success:
                            MessageBox.Show(rs.ErrDesc, Constants.msg_capt_Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case CEnum.Fail:
                            MessageBox.Show(rs.ErrDesc, Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frm_ThemMH : Form
    {
        DataDataContext db = new DataDataContext();
        monhoc_ctrl mh_ctrl = new monhoc_ctrl();
        public frm_ThemMH()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mamh.Text == "")
            {
                MessageBox.Show(String.Format(Constants.msg_Err_NullData, "Mã Môn học"), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mamh.Focus();
            }
            else
            {
                var rs = mh_ctrl.InserSV(txt_mamh.Text, txt_tenmh.Text, txt_sotchp.Text);
                switch (rs.ErrCode)
                {
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
    }
}

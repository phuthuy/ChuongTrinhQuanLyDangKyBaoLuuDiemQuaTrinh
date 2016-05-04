using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuHocPhi.Controls;
using ThuHocPhi.Models;
using ThuHocPhi.Shares;

namespace ThuHocPhi.Views.DLhocphi.HocKy
{
    public partial class frm_addhk : Form
    {
        DataDataContext db = new DataDataContext();
        HocKy_ctl ctl_hk = new HocKy_ctl();
        public frm_addhk()
        {
            InitializeComponent();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_hk.Text == "")
            {
                MessageBox.Show(String.Format(Constants.msg_Err_NullData, "Mã Khoa"), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hk.Focus();
            }
            else
            {
                var rs = ctl_hk.InserHK(txt_hk.Text, int.Parse(txt_hp.Text), false);
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

        private void frm_addhk_Load(object sender, EventArgs e)
        {
        }
    }
}

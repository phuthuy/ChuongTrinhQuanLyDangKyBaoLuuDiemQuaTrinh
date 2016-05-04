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

namespace ThuHocPhi.Views.DLhocphi.Import
{
    public partial class frm_capnhatDQT : Form
    {
        DataDataContext db = new DataDataContext();
        diemqt_ctrl dqt_ctrl = new diemqt_ctrl();
        public frm_capnhatDQT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_masv.Text == "")
            {
                MessageBox.Show(String.Format(Constants.msg_Err_NullData, "Mã sinh viên"), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_masv.Focus();
            }
            else
            {


                var rs = dqt_ctrl.UpdateDQT(txt_masv.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text);
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
        }
    }


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
    
    public partial class frm_xemdl : Form
    {
        DataDataContext db = new DataDataContext();
         diemqt_ctrl dqt_ctrl = new diemqt_ctrl();

        public frm_xemdl()
        {
            InitializeComponent();
        }

        private void btn_delall_click(object sender, EventArgs e)
        {

        }

        private void frm_xemdl_Load(object sender, EventArgs e)
        {
            //Hiển thị form full parent
            Utils.ShowFormCenterOfPanel(this);
            //load dữ liệu Khoa
            var rs = dqt_ctrl.GetAllDQT();
            UpdateDtg(rs);

        }

        private void UpdateDtg(ActionResult<List<diemqt_ett>> lst)
        {
            switch (lst.ErrCode)
            {
                case CEnum.HaveNoData:
                    break;
                case CEnum.Success:
                    dataGridView1.DataSource = lst.Data;
                    break;
                case CEnum.Fail:
                    break;
                default:
                    break;
            }
        }


        private void hocKyIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_click(object sender, EventArgs e)
        {
            frm_capnhatDQT frm = new frm_capnhatDQT();
            frm.txt_masv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Close();
            }
            var hk = dqt_ctrl.GetAllDQT();
            UpdateDtg(hk);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_themDQT frm = new frm_themDQT();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Close();
            }
            var hk = dqt_ctrl.GetAllDQT();
            UpdateDtg(hk);
        }
    }
}

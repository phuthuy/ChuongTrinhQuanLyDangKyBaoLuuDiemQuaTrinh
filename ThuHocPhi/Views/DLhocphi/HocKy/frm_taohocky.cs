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
    public partial class frm_taohocky : Form
    {
        DataDataContext db = new DataDataContext();
        HocKy_ctl hk_ctl = new HocKy_ctl();
        public frm_taohocky()
        {
            InitializeComponent();
        }
        private void frm_Taohocky_Load(object sender, EventArgs e)
        {
            //Hiển thị form full parent
            Utils.ShowFormCenterOfPanel(this);
            //load dữ liệu Khoa
            var rs = hk_ctl.GetAllHK();
            UpdateDtg(rs);
        }
        private void UpdateDtg(ActionResult<List<HocKy_ett>> lst)
        {
            switch (lst.ErrCode)
            {
                case CEnum.HaveNoData:
                    break;
                case CEnum.Success:
                    dtg_Hocky.DataSource = lst.Data;
                    break;
                case CEnum.Fail:
                    break;
                default:
                    break;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_addhk frm = new frm_addhk();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Close();
            }
            var hk = hk_ctl.GetAllHK();
            UpdateDtg(hk);
        }
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            frm_capnhat frm = new frm_capnhat();
            frm.txt_id.Text = dtg_Hocky.CurrentRow.Cells[0].Value.ToString();
            frm.txt_hk.Text = dtg_Hocky.CurrentRow.Cells[1].Value.ToString();
            frm.txt_hp.Text = dtg_Hocky.CurrentRow.Cells[2].Value.ToString();
            if (dtg_Hocky.CurrentRow.Cells[3].Value.ToString() == "false")
            {
                frm.ckb_km.CheckState = CheckState.Unchecked;
            }
            else if (dtg_Hocky.CurrentRow.Cells[3].Value.ToString() == "true")
            {
                frm.ckb_km.CheckState = CheckState.Checked;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Close();
            }
            var hk = hk_ctl.GetAllHK();
            UpdateDtg(hk);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var xoa = int.Parse(dtg_Hocky.CurrentRow.Cells[0].Value.ToString());
            var rs = hk_ctl.DeleteHK(xoa);
            switch (rs.ErrCode)
            {
                case CEnum.HaveNoData:
                    MessageBox.Show(rs.ErrDesc, Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case CEnum.Success:
                    MessageBox.Show(rs.ErrDesc, Constants.msg_capt_Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDtg(hk_ctl.GetAllHK());
                    break;
                case CEnum.Fail:
                    MessageBox.Show(rs.ErrDesc, Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void dtg_Hocky_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm_capnhat frm = new frm_capnhat();
            var r = dtg_Hocky.Rows[e.RowIndex];
            frm.txt_id.Text = r.Cells[0].Value.ToString();
            frm.txt_hk.Text = r.Cells[1].Value.ToString();
            frm.txt_hp.Text = r.Cells[2].Value.ToString();
            frm.ckb_km.Text = r.Cells[3].Value.ToString();
        }
    }
}

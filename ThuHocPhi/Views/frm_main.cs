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
using ThuHocPhi.Views.DLhocphi.HocKy;
using ThuHocPhi.Views.TuDien;

namespace ThuHocPhi.Views
{
   
    public partial class frm_main : Form
    {
        DataDataContext db = new DataDataContext();
        public frm_main()
        {
            InitializeComponent();
            this.nu_1.Visible = false;
            this.nu_2.Visible = false;
            this.nu_3.Visible = false;
            this.nu_4.Visible = true;
            this.nu_5.Visible = false;
            this.nu_6.Visible = true;
            lb_xinchao.Visible = false;
            lb_hocky.Visible = false;
        }

        private void khởiTạoHọcKìVàMứcHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_taohocky frm = new frm_taohocky();
            Utils.ShowFormInPanel(panel1, frm);
            Utils.ShowFormCenterOfPanel(frm);
        }

        private void dữLiệuHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inBiênLaiThuHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo đối tượng form tương ứng
            Views.frm_inbienlai f = new frm_inbienlai();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void thốngKêHọcPhíĐãThuTừNgàyĐếnNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //tạo đối tượng form tương ứng
            Views.frm_thongketheongay f = new frm_thongketheongay();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo đối tượng form tương ứng
            Views.frm_dschuadongtien f = new frm_dschuadongtien();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void xemSửaDsSvĐãĐóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo đối tượng form tương ứng
            Views.frm_svdadonghocphi f = new frm_svdadonghocphi();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo đối tượng form tương ứng
            Views.frm_doimatkhau f = new frm_doimatkhau();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo đối tượng form tương ứng
            Views.frm_quanlynguoidung f = new frm_quanlynguoidung();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void nu_5_Click(object sender, EventArgs e)
        {
            this.nu_1.Visible = false;
            this.nu_2.Visible = false;
            this.nu_3.Visible = false;
            this.nu_4.Visible = true;
            this.nu_5.Visible = false;
            this.nu_6.Visible = true;
            this.grp_Chinh.Visible = true;
            this.lb_xinchao.Visible = false;
            this.lb_hocky.Visible = false;
            txt_mk.Text = "";
            txt_tk.Text = "";

        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "")
            {
                MessageBox.Show(String.Format(Constants.msg_Err_NullData, "Tài khoản"), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tk.Focus();
            }
            else
            {
                if (txt_mk.Text == "")
                {
                    MessageBox.Show(String.Format(Constants.msg_Err_NullData, "Mật Khẩu"), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_mk.Focus();
                }
                else
                {
                    string tk = txt_tk.Text;
                    string mk = txt_mk.Text;

                    //lấy dữ liệu từ CSDL
                    var qr = db.users.Where(o => o.username == tk && o.password == mk);

                    //kiểm tra đăng nhập
                    if (qr.Count() > 0)
                    {
                        //trường hợp đăng nhập thành công. Hiển thị Menu tương ứng
                       // MessageBox.Show(Constants.msg_Info_Login_Success, Constants.msg_capt_Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (txt_tk.Text == "admin1")
                        {
                            this.nu_1.Visible = true;
                            this.nu_2.Visible = true;
                            this.nu_3.Visible = true;
                            this.nu_4.Visible = true;
                            this.nu_5.Visible = true;
                            this.nu_6.Visible = false;
                            grp_Chinh.Visible = false;
                            //panel1.Controls.Clear();
                        }
                        else
                        {
                            this.nu_1.Visible = false;
                            this.nu_2.Visible = true;
                            this.nu_3.Visible = true;
                            this.nu_4.Visible = true;
                            this.nu_5.Visible = true;
                            this.nu_6.Visible = true;
                            grp_Chinh.Visible = false;
                            //panel1.Controls.Clear();
                        }
                        this.lb_hocky.Visible = true;
                        this.lb_xinchao.Visible = true;
                        lb_xinchao.Text = "Xin chào :" + tk;
                    }
                    else
                    {
                        MessageBox.Show(Constants.msg_Err_Login_Fail, Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_tk.Focus();
                    }
                }
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void từĐiểnSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo đối tượng form tương ứng
            Views.TuDien.frm_sinhvien f = new frm_sinhvien();
            //Hiển thị form trong panel
            Utils.ShowFormInPanel(panel1, f);
            //Hiển thị form vào giữa panel
            Utils.ShowFormCenterOfPanel(f);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            this.nu_1.Visible = false;
            this.nu_2.Visible = false;
            this.nu_3.Visible = false;
            this.nu_4.Visible = true;
            this.nu_5.Visible = true;
            this.nu_6.Visible = true;
            lb_xinchao.Visible = false;
            lb_hocky.Visible = false;
           // grp_Chinh.Close();
        }
    }
}

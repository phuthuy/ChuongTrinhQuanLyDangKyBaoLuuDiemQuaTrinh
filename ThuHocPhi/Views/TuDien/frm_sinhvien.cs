using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ThuHocPhi.Shares;
using ThuHocPhi.Controls.Tudien;
using ThuHocPhi.Models.Tudien;
using ThuHocPhi.Models;

namespace ThuHocPhi.Views.TuDien
{
    public partial class frm_sinhvien : Form
    {
        DataDataContext db =new  DataDataContext();
        sinhvien_ctrl sv_ctrl = new sinhvien_ctrl();
        public frm_sinhvien()
        {
            InitializeComponent();
            btn_chon.Click += new EventHandler(btn_chon_click);
            btn_import.Click += new EventHandler(btn_import_click);
        }

        private void btn_import_click(object sender, EventArgs e)
        {
            if(!ValidInput())
                return;
            ShowData();
            DataTable data = ReadDataFromExcelFile();
            ReadDataFromExcelFile();
            ImportIntoDatabase(data);
        }

        private void btn_chon_click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            txt_chon.Text = of.ShowDialog() == DialogResult.OK ? of.FileName : "";
        }
        private void ShowData()
        {
            DataHocphiTableAdapters.SinhVienTableAdapter adapter = new DataHocphiTableAdapters.SinhVienTableAdapter();
            dataGridView1.DataSource = adapter.GetData();
        }
        private DataTable ReadDataFromExcelFile()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txt_chon.Text.Trim() + ";Extended Properties=Excel 8.0";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [TDSV$]", oledbConn);
                //cbo_hocky.SelectedValue.ToString();
                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }
        private bool ValidInput()
        {
            if (txt_chon.Text.Trim() == "")
            {
                MessageBox.Show("Xin vui lòng chọn tập tin excel cần import");
                return false;
            }
            return true;
        }
        private void ImportIntoDatabase(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }
            DataHocphiTableAdapters.SinhVienTableAdapter adapter = new DataHocphiTableAdapters.SinhVienTableAdapter();
            string masv = "", hoten = "", lop = "";            
            try
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {

                    masv = data.Rows[i]["MaSV"].ToString().Trim();
                    hoten = data.Rows[i]["HoTen"].ToString().Trim();
                    lop = data.Rows[i]["Lop"].ToString().Trim();
                    DataHocphi.SinhVienDataTable existingEmployee = adapter.GetDataByMaSV(masv);
                    //Nếu MaSV chưa tồn tại trong DB thì thêm mới
                    if (existingEmployee == null || existingEmployee.Rows.Count == 0)
                    {
                        adapter.InsertQuerySV(masv, hoten, lop);
                    }
                    //Ngược lại, sinh vien đã tồn tại trong DB thì update
                    //else
                    //{
                    //    adapter.UpdateQueryThuhocphi(masv, hoten, lop, mamh, tenmh, nhhk, sotc, sotchp, dqt, dthi, dtk, dso, diemchu, ngayluu, hockyid, masv);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Kết thúc import");
        }

        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
            //Hiển thị form full parent
            Utils.ShowFormCenterOfPanel(this);
            //load dữ liệu Khoa
            var rs = sv_ctrl.GetAllSV();
            UpdateDtg(rs);
        }
        //phần thêm sửa sinh viên
        private void UpdateDtg(ActionResult<List<sinhvien_ett>> lst)
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
        private void btn_chon_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            frm_CapnhatSV frm = new frm_CapnhatSV();
            frm.txt_masv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txt_hoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txt_lop.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Close();
            }
            var hk = sv_ctrl.GetAllSV();
            UpdateDtg(hk);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemSV f = new frm_ThemSV();
            //Hiển thị form trong panel
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
            var hk = sv_ctrl.GetAllSV();
            UpdateDtg(hk);
        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var Lst = (from s in db.SinhViens where s.MaSV.Contains(txt_timkiem.Text) select s).ToList();
            dataGridView1.DataSource = Lst;
        }
    }
}

//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuHocPhi.Models;
using ThuHocPhi.Models.Tudien;
using ThuHocPhi.Shares;

namespace ThuHocPhi.Controls.Tudien
{
    class sinhvien_ctrl
    {
        DataDataContext db = new DataDataContext();
        public ActionResult<List<sinhvien_ett>> GetAllSV()
        {
            ActionResult<List<sinhvien_ett>> op = new ActionResult<List<sinhvien_ett>>();
            op.Data = new List<sinhvien_ett>();
            try
            {
                var qr = db.SinhViens;

                if (qr.Count() > 0)
                {
                    //có dữ liệu
                    foreach (var i in qr)
                    {
                        sinhvien_ett k = new sinhvien_ett(i);
                        op.Data.Add(k);
                    }
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Shares.Constants.act_rs_get_Data_Success, "Sinhvien");
                    return op;
                }
                else
                {
                    //Không có dữ liệu;
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Shares.Constants.act_rs_get_Data_NULL, "Sinhvien");
                    op.Data = null;
                    return op;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                //Không có dữ liệu;
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Shares.Constants.act_rs_get_Data_Fail, "Sinhvien");
                op.Data = null;
                return op;
            }

        }
        public ActionResult<sinhvien_ett> InserSV(string masv, string hoten, string lop)
        {
            ActionResult<sinhvien_ett> op = new ActionResult<sinhvien_ett>();
            try
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = masv;
                sv.HoTen = hoten;
                sv.Lop = lop;
                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                op.ErrCode = CEnum.Success;
                op.ErrDesc = String.Format(Shares.Constants.act_rs_insert_Data_Success, "Sinhvien");
                op.Data = new sinhvien_ett(sv);
                return op;
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Shares.Constants.act_rs_insert_Data_Fail, "Sinhvien");
                op.Data = null;
                return op;
            }
        }
        public ActionResult<sinhvien_ett> UpdateSV(string masv, string hoten,string lop)
        {
            ActionResult<sinhvien_ett> op = new ActionResult<sinhvien_ett>();
            try
            {
                var qr = db.SinhViens.Where(o => o.MaSV == masv);
                if (qr.Count() > 0)
                {
                    SinhVien sv = qr.SingleOrDefault();
                    sv.MaSV = masv;
                    sv.HoTen = hoten;
                    sv.Lop = lop;
                    db.SubmitChanges();
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Shares.Constants.act_rs_update_Data_Success, "Sinhvien");
                    op.Data = new sinhvien_ett(sv);
                    return op;
                }
                else
                {
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Shares.Constants.act_rs_get_Data_NULL, "Sinhvien");
                    op.Data = null;
                    return op;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Shares.Constants.act_rs_update_Data_Fail, "Sinhvien");
                op.Data = null;
                return op;
            }
        }
       // public ActionResult<sinhvien_ett> SearchSV(string masv)
    }
}

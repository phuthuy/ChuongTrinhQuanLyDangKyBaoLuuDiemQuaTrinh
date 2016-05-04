using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuHocPhi.Models;
using ThuHocPhi.Shares;

namespace ThuHocPhi.Controls
{
    class diemqt_ctrl
    {
        public ActionResult<List<diemqt_ett>> GetAllDQT()
        {
            ActionResult<List<diemqt_ett>> op = new ActionResult<List<diemqt_ett>>();
            op.Data = new List<diemqt_ett>();
            try
            {
                var qr = db.kqdk_dqts;

                if (qr.Count() > 0)
                {
                    //có dữ liệu
                    foreach (var i in qr)
                    {
                        diemqt_ett k = new diemqt_ett(i);
                        op.Data.Add(k);
                    }
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_Success, "ĐQT");
                    return op;
                }
                else
                {
                    //Không có dữ liệu;
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_NULL, "ĐQT");
                    op.Data = null;
                    return op;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                //Không có dữ liệu;
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_get_Data_Fail, "ĐQT");
                op.Data = null;
                return op;
            }

        }
        DataDataContext db = new DataDataContext();
        public ActionResult<diemqt_ett> InsertDuLieu(string masv, string hoten, string lop, string mamh, string tenmh, string diemqt, string sotchp)
        {
            ActionResult<diemqt_ett> op = new ActionResult<diemqt_ett>();
            try
            {
                kqdk_dqt k = new kqdk_dqt();
                k.MaSV = masv;
                k.HoTen = hoten;
                k.Lop = lop;
                k.MaMH = mamh;
                k.TenMH = tenmh;
                //  k.Nhhk = nhhk;
                //k.SoTC = sotc;
               
                k.Diemqt = diemqt;
                k.SoTCHP = sotchp;
                //k.Diemthi = diemthi;
                //k.Diemso = diemso;
                //k.Diemchu = diemchu;
                //k.HocKyId = hockyid;
                // k.NgayLuu = ngayluu;
                db.kqdk_dqts.InsertOnSubmit(k);
                db.SubmitChanges();

                op.ErrCode = CEnum.Success;
                op.ErrDesc = String.Format(Constants.act_rs_insert_Data_Success, "ĐQT");
                op.Data = new diemqt_ett(k);
                return op;
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_insert_Data_Fail, "ĐQT");
                op.Data = null;
                return op;
            }
        }
        public ActionResult<diemqt_ett> UpdateDQT(string masv, string hoten, string lop, string mamh, string tenmh, string diemqt, string sotchp)
        {

            {
                ActionResult<diemqt_ett> op = new ActionResult<diemqt_ett>();
                try
                {
                    var qr = db.kqdk_dqts.Where(o => o.MaSV == masv);
                    if (qr.Count() > 0)
                    {
                        kqdk_dqt k = qr.SingleOrDefault();
                        k.MaSV = masv;
                        k.HoTen = hoten;
                        k.Lop = lop;
                        k.MaMH = mamh;
                        k.TenMH = tenmh;
                        //  k.Nhhk = nhhk;
                        //k.SoTC = sotc;
                        
                        k.Diemqt = diemqt;
                        k.SoTCHP = sotchp;
                        // k.NgayLuu = ngayluu;
                        db.SubmitChanges();
                        op.ErrCode = CEnum.Success;
                        op.ErrDesc = String.Format(Constants.act_rs_update_Data_Success, "ĐQT");
                        op.Data = new diemqt_ett(k);
                        return op;
                    }
                    else
                    {
                        op.ErrCode = CEnum.HaveNoData;
                        op.ErrDesc = String.Format(Constants.act_rs_get_Data_NULL, "ĐQT");
                        op.Data = null;
                        return op;
                    }
                }
                catch (Exception ex)
                {
                    Utils.ShowExceptionMsg(ex);
                    op.ErrCode = CEnum.Fail;
                    op.ErrDesc = String.Format(Constants.act_rs_update_Data_Fail, "ĐQT");
                    op.Data = null;
                    return op;
                }
            }
        }
        public ActionResult<bool> DeleteDQT(string masv)
        {
            ActionResult<bool> op = new ActionResult<bool>();
            try
            {
                var qr = db.kqdk_dqts.Where(o => o.MaSV == masv);
                if (qr.Count() > 0)
                {
                    kqdk_dqt kq = qr.SingleOrDefault();
                    db.kqdk_dqts.DeleteOnSubmit(kq);
                    db.SubmitChanges();
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Constants.act_rs_del_Data_Success, "ĐQT");
                    op.Data = true;
                    return op;
                }
                else
                {
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_NULL, "ĐQT");
                    op.Data = false;
                    return op;
                }

            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_del_Data_Fail, "ĐQT");
                op.Data = false;
                return op;
            }
        }
    }
}

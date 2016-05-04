using ThuHocPhi.Models;
using ThuHocPhi.Shares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Controls
{
    class HocKy_ctl
    {
        DataDataContext db = new DataDataContext();
        public ActionResult<List<HocKy_ett>> GetAllHK()
        {
            ActionResult<List<HocKy_ett>> op = new ActionResult<List<HocKy_ett>>();
            op.Data = new List<HocKy_ett>();
            try
            {
                var qr = db.HocKies;

                if (qr.Count() > 0)
                {
                    //có dữ liệu
                    foreach (var i in qr)
                    {
                        HocKy_ett k = new HocKy_ett(i);
                        op.Data.Add(k);
                    }
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_Success, "Khoa");
                    return op;
                }
                else
                {
                    //Không có dữ liệu;
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_NULL, "Khoa");
                    op.Data = null;
                    return op;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                //Không có dữ liệu;
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_get_Data_Fail, "Khoa");
                op.Data = null;
                return op;
            }

        }
        public ActionResult<HocKy_ett> InserHK(string hocky, decimal hocphi, bool trangthai)
        {
            ActionResult<HocKy_ett> op = new ActionResult<HocKy_ett>();
            try
            {
                HocKy hk = new HocKy();
                hk.HocKy1 = hocky;
                hk.HocPhi = hocphi;
                hk.TrangThai = trangthai;
                db.HocKies.InsertOnSubmit(hk);
                db.SubmitChanges();

                op.ErrCode = CEnum.Success;
                op.ErrDesc = String.Format(Constants.act_rs_insert_Data_Success, "HocKy");
                op.Data = new HocKy_ett(hk);
                return op;
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_insert_Data_Fail, "Khoa");
                op.Data = null;
                return op;
            }
        }
        public ActionResult<HocKy_ett> UpdateHK(int hkID,string hocky, decimal hocphi, bool trangthai)
        {
            ActionResult<HocKy_ett> op = new ActionResult<HocKy_ett>();
            try
            {
                var qr = db.HocKies.Where(o => o.HocKyID == hkID);
                if (qr.Count() > 0)
                {
                    HocKy hk = qr.SingleOrDefault();
                    hk.HocKy1 = hocky;
                    hk.HocPhi = hocphi;
                    hk.TrangThai = trangthai;

                    db.SubmitChanges();
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Constants.act_rs_update_Data_Success, "Khoa");
                    op.Data = new HocKy_ett(hk);
                    return op;
                }
                else
                {
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_NULL, "Khoa");
                    op.Data = null;
                    return op;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_update_Data_Fail, "Khoa");
                op.Data = null;
                return op;
            }
        }
        public ActionResult<bool> DeleteHK(int hockyid)
        {
            ActionResult<bool> op = new ActionResult<bool>();
            try
            {
                var qr = db.HocKies.Where(o => o.HocKyID == hockyid);
                if (qr.Count() > 0)
                {
                    HocKy hk = qr.SingleOrDefault();
                    db.HocKies.DeleteOnSubmit(hk);
                    db.SubmitChanges();
                    op.ErrCode = CEnum.Success;
                    op.ErrDesc = String.Format(Constants.act_rs_del_Data_Success, "HocKy");
                    op.Data = true;
                    return op;
                }
                else
                {
                    op.ErrCode = CEnum.HaveNoData;
                    op.ErrDesc = String.Format(Constants.act_rs_get_Data_NULL, "HocKy");
                    op.Data = false;
                    return op;
                }

            }
            catch (Exception ex)
            {
                Utils.ShowExceptionMsg(ex);
                op.ErrCode = CEnum.Fail;
                op.ErrDesc = String.Format(Constants.act_rs_del_Data_Fail, "HocKy");
                op.Data = false;
                return op;
            }
        }
    }
}

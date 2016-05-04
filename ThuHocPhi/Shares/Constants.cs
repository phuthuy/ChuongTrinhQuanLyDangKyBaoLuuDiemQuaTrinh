using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Shares
{
    class Constants
    {


            public static Models.DangNhap_ett DangNhap_Session { get; set; }

            #region msg content
            public const string msg_Err_Exception = "Đã xảy ra lỗi trong quá trình thực thi tác vụ. Bạn có muốn xem chi tiết lỗi không?";
            public const string msg_Err_NullData = "Trường {0} KHÔNG được để trống";
            public const string msg_Err_Login_Fail = "Tài khoản hoặc mật khẩu KHÔNG đúng. Vui lòng đăng nhập lại!!!";
            public const string msg_Info_Login_Success = "Đăng nhập thành công!";

            public const string msg_Info_Insert_Success = "Thêm mới {0} thành công";
            public const string msg_Info_Insert_Fail = "Thêm mới {0} thất bại";
            public const string msg_Info_Update_Success = "Cập nhật {0} thành công";
            public const string msg_Info_Update_Fail = "Cập nhật {0} thất bại";
            public const string msg_Info_Del_Success = "Xóa {0} thành công";
            public const string msg_Info_Del_Fail = "Xóa {0} thất bại";

            public const string msg_warning_Del = "Bạn có thật sự muốn xóa dữ liệu này không?";
            #endregion

            #region msg caption
            public const string msg_capt_Err = "Thông báo lỗi";
            public const string msg_capt_Info = "Thông báo";
            public const string msg_capt_Warning = "Cảnh báo";
            #endregion

            #region msg Action Result
            public const string act_rs_get_Data_Success = "Lấy {0} thành công";
            public const string act_rs_get_Data_Fail = "Lấy {0} thất bại";
            public const string act_rs_get_Data_NULL = "Không tồn tại {0} thỏa mãn điều kiện";
            public const string act_rs_insert_Data_Success = "Thêm mới {0} thành công";
            public const string act_rs_insert_Data_Fail = "Thêm mới {0} thất bại";
            public const string act_rs_update_Data_Success = "Cập nhật {0} thành công";
            public const string act_rs_update_Data_Fail = "Cập nhật {0} thất bại";
            public const string act_rs_del_Data_Success = "Xóa {0} thành công";
            public const string act_rs_del_Data_Fail = "Xóa {0} thất bại";
            #endregion
        }
}


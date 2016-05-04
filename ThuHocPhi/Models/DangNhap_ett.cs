using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Models
{
    class DangNhap_ett
    {
        public string username { get; set; }
        public string password { get; set; }
        public string Hoten { get; set; }
        public int? Phone { get; set; }

        public DangNhap_ett()
        {

        }

        public DangNhap_ett(user L)
        {
            this.username = L.username;
            this.password = L.password;
            this.Hoten = L.HoTen;
            this.Phone = L.Phone;
        }
    }
}

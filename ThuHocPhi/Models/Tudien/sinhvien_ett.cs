using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Models.Tudien
{
    class sinhvien_ett
    {
        public string MaSV { get; set;}
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public  sinhvien_ett() { }
        public  sinhvien_ett(SinhVien sv)
        {
            this.MaSV = sv.MaSV;
            this.HoTen = sv.HoTen;
            this.Lop = sv.Lop;
        }
    }
}

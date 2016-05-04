using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Models
{
    class HocKy_ett
    {

        public int HocKyID { get; set; }
        public string HocKy { get; set; }
        public decimal? HocPhi { get; set; }
        public Boolean? TrangThai { get; set; }
        public HocKy_ett()
        {

        }
        public HocKy_ett(HocKy HK)
        {
            this.HocKyID = HK.HocKyID;
            this.HocKy = HK.HocKy1;
            this.HocPhi = HK.HocPhi;
            this.TrangThai = HK.TrangThai;

        }
    }
}

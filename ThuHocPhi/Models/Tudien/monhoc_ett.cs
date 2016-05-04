using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Models.Tudien
{
    class monhoc_ett
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string SoTCHP { get; set; }
        public monhoc_ett() { }
        public monhoc_ett(MonHoc mh)
        {
            this.MaMH = mh.MaMH;
            this.TenMH = mh.TenMH;
            this.SoTCHP = mh.SoTCHP;
        }
    }
}

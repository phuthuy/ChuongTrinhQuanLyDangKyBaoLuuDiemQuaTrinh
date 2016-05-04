using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuHocPhi.Models
{
    class diemqt_ett
    {
        //public int MaKQ { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public string MaMH { get; set; }
        public string TenMH { get; set; }
      //  public string Nhhk { get; set; }
      //  public string SoTC { get; set; }
       
        public string Diemqt { get; set; }
        public string SoTCHP { get; set; }
        // public string Diemthi { get; set; }
        // public string DiemTk { get; set; }
        //  public string Diemso { get; set; }
        //public string Diemchu { get; set; }
        public DateTime? NgayLuu { get; set; }
       // public int? HocKyId { get; set; }
       // public string Log { get; set; }

        
        //public int HocKyID { get; set; }
        
        public diemqt_ett() { }
        public diemqt_ett(kqdk_dqt qk)
        {
            
            this.MaSV = qk.MaSV;
            this.HoTen = qk.HoTen;
            this.Lop = qk.Lop;
            this.MaMH = qk.MaMH;
            this.TenMH = qk.TenMH;
          //  this.Nhhk = qk.Nhhk;
          //  this.SoTC = qk.SoTC;
            
            this.Diemqt = qk.Diemqt;
            this.SoTCHP = qk.SoTCHP;
            //  this.DiemTk = qk.DiemTk;
            //  this.Diemso = qk.Diemso;
            //  this.Diemchu = qk.Diemchu;
            this.NgayLuu = qk.NgayLuu;
     //       this.HocKyId = qk.HocKyId;
        }
    }

}

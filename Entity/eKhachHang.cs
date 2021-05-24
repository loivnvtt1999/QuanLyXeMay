using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eKhachHang
    {
        string maKH, tenKH, cMNDKH, sdtKH, emailKH, maDC;
        DateTime ngaySinh;

        public eKhachHang()
        {
            this.MaKH = "";
            this.TenKH = "";
            this.CMNDKH = "";
            this.NgaySinh = DateTime.Today;
            this.SdtKH = "";
            this.EmailKH = "";
            this.MaDC = "";
        }

        public eKhachHang(string kh, string ten, string cmnd, DateTime ngay, string sdt, string email, string dc)
        {
            this.MaKH = kh;
            this.TenKH = ten;
            this.CMNDKH = cmnd;
            this.NgaySinh = ngay;
            this.SdtKH = sdt;
            this.EmailKH = email;
            this.MaDC = dc;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string CMNDKH { get => cMNDKH; set => cMNDKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }
        public string EmailKH { get => emailKH; set => emailKH = value; }
        public string MaDC { get => maDC; set => maDC = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}

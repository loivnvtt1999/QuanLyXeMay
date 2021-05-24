using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eCT_HoaDon
    {
        string maHD, maHDG;
        double giaBan, thue;

        public eCT_HoaDon()
        {
            this.MaHD = "";
            this.MaHDG = "";
            this.GiaBan = 0;
            this.Thue = 0;
        }

        public eCT_HoaDon(string hd, string hdg, double gia, double thue1)
        {
            this.MaHD = hd;
            this.MaHDG = hdg;
            this.GiaBan = gia;
            this.Thue = thue1;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaHDG { get => maHDG; set => maHDG = value; }
        public double Thue { get => thue; set => thue = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eHangXe
    {
        string maHang, tenHang, xuatXu;
        public eHangXe()
        {
            this.MaHang = "";
            this.TenHang = "";
            this.XuatXu = "";
        }
        public eHangXe(string ma, string ten, string xx)
        {
            this.MaHang = ma;
            this.TenHang = ten;
            this.XuatXu = xx;
        }
        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
    }
}

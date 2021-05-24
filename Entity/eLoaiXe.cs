using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eLoaiXe
    {
        string maLoai, tenLoai;
        public eLoaiXe()
        {
            this.MaLoai = "";
            this.TenLoai = "";
        }
        public eLoaiXe(string ma, string ten)
        {
            this.MaLoai = ma;
            this.TenLoai = ten;
        }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}

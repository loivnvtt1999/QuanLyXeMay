using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eThongKeSoLuongVaDoanhThuTheoThang
    {
        int thang, soLuong;
        double doanhThu;

        public int Thang { get => thang; set => thang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}

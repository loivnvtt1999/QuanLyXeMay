using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eThongKeXeBanTheoNhanVienTrongThangX
    {
        String maXe, tenXe, maNhanvien;
        int soLuong;
        double thanhTien;
        public string MaXe { get => maXe; set => maXe = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
       
        public string MaNhanvien { get => maNhanvien; set => maNhanvien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eXe
    {
        string maXe, tenXe, mauSac, phanKhoi, loaiPhanh, loaiBanh, maNCC, maHang, maLoai;
        double congSuat, dungTichBinhXang, khoiLuong, duongKinhPitTong, giaThanh;
        int doCaoYen, soLuong;

        public eXe()
        {
            this.MaXe = "";
            this.TenXe = "";
            this.MaHang = "";
            this.MaLoai = "";
            this.CongSuat = 0;
            this.DoCaoYen = 0;
            this.DungTichBinhXang = 0;
            this.KhoiLuong = 0;
            this.DuongKinhPitTong = 0;
            this.MauSac = "";
            this.PhanKhoi = "";
            this.SoLuong = 0;
            this.GiaThanh = 0;
            this.LoaiPhanh = "";
            this.LoaiBanh = "";
            this.MaNCC = "";
        }

        public eXe(string ma, string ten, string hang, string loai, double csuat, int docao, double dtbinh, double kluong, double duongkinh, string mau, string pkhoi, int sl, double gia, string phanh, string banh, string ncc)
        {
            this.MaXe = ma;
            this.TenXe = ten;
            this.MaHang = hang;
            this.MaLoai = loai;
            this.CongSuat = csuat;
            this.DoCaoYen = docao;
            this.DungTichBinhXang = dtbinh;
            this.KhoiLuong = kluong;
            this.DuongKinhPitTong = duongkinh;
            this.MauSac = mau;
            this.PhanKhoi = pkhoi;
            this.SoLuong = sl;
            this.GiaThanh = gia;
            this.LoaiPhanh = phanh;
            this.LoaiBanh = banh;
            this.MaNCC = ncc;
        }

        public string MaXe { get => maXe; set => maXe = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public string PhanKhoi { get => phanKhoi; set => phanKhoi = value; }
        public string LoaiPhanh { get => loaiPhanh; set => loaiPhanh = value; }
        public string LoaiBanh { get => loaiBanh; set => loaiBanh = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public int DoCaoYen { get => doCaoYen; set => doCaoYen = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double CongSuat { get => congSuat; set => congSuat = value; }
        public double DungTichBinhXang { get => dungTichBinhXang; set => dungTichBinhXang = value; }
        public double KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        public double DuongKinhPitTong { get => duongKinhPitTong; set => duongKinhPitTong = value; }
        public double GiaThanh { get => giaThanh; set => giaThanh = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
    }
}

//******************************************************************
//
//
//
//******************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class KhachHangDAL
    {
        QuanLyBanXeDataContext db;

        public KhachHangDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public bool kiemTraTrungMa(string makhach)
        {
            // Lấy khách hàng đầu tiên trong bảng có mã tương ứng được truyền vào, không có trả về null
            KhachHang kh = db.KhachHangs.Where(x => x.maKhachHang.Equals(makhach)).FirstOrDefault();
            // Khách hàng khác null tức là có trong hệ thống
            if (kh != null)
            {
                return true;
            }
            // Khách hàng không có trong hệ thống
            return false;
        }

        public int themtKhachHang(eKhachHang khmoi)
        {
            if (kiemTraTrungMa(khmoi.MaKH))
                return 0;
            KhachHang kh = new KhachHang();
            kh.maKhachHang = khmoi.MaKH;
            kh.tenKhachHang = khmoi.TenKH;
            kh.cmnd = khmoi.CMNDKH;
            kh.soDienThoaiKH = khmoi.SdtKH;
            kh.emailKH = khmoi.EmailKH;
            kh.ngaySinh = khmoi.NgaySinh;
            kh.maDiaChi = khmoi.MaDC;
            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
            return 1;
        }

        public int xoaKhachHang(eKhachHang khxoa)
        {

            if (!kiemTraTrungMa(khxoa.MaKH))
                return 0;
            KhachHang kh = db.KhachHangs.Where(x => x.maKhachHang.Equals(khxoa.MaKH)).FirstOrDefault();
            db.KhachHangs.DeleteOnSubmit(kh);
            db.SubmitChanges();
            return 1;
        }

        public int suaKhachHang(eKhachHang khsua)
        {
            if (!kiemTraTrungMa(khsua.MaKH))
                return 0;
            KhachHang kh = db.KhachHangs.Where(x => x.maKhachHang.Equals(khsua.MaKH)).FirstOrDefault();
            kh.tenKhachHang = khsua.MaKH;
            kh.cmnd = khsua.CMNDKH;
            kh.soDienThoaiKH = khsua.SdtKH;
            kh.emailKH = khsua.EmailKH;
            kh.ngaySinh = khsua.NgaySinh;
            kh.maDiaChi = kh.maDiaChi;
            db.SubmitChanges();
            return 1;
        }

        public eKhachHang layKhachHang(string makh)
        {
            if (!kiemTraTrungMa(makh))
                return null;
            KhachHang kh = db.KhachHangs.Where(x => x.maKhachHang.Equals(makh)).FirstOrDefault();
            eKhachHang k = new eKhachHang();
            k.MaKH = kh.maKhachHang;
            k.TenKH = kh.tenKhachHang;
            k.CMNDKH = kh.cmnd;
            k.SdtKH = kh.soDienThoaiKH;
            k.EmailKH = kh.emailKH;
            k.NgaySinh = kh.ngaySinh;
            k.MaDC = kh.maDiaChi;
            return k;
        }

        public eKhachHang layKhachHangTheoSDT(string sdt)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.soDienThoaiKH.Equals(sdt)).FirstOrDefault();
            if(kh!= null)
            {
                eKhachHang k = new eKhachHang();
                k.MaKH = kh.maKhachHang;
                k.TenKH = kh.tenKhachHang;
                k.CMNDKH = kh.cmnd;
                k.SdtKH = kh.soDienThoaiKH;
                k.EmailKH = kh.emailKH;
                k.NgaySinh = kh.ngaySinh;
                k.MaDC = kh.maDiaChi;
                return k;
            }
            return null;
        }

        public string PhatSinhMa()
        {
            int n = 0;
            string str = "KH";
            KhachHang kh = db.KhachHangs.ToList().LastOrDefault();
            if (kh != null)
            {
                string str1 = kh.maKhachHang.Substring(2);
                n = int.Parse(str1)+1;   
            }
            if (n < 10)
            {
                str = str + "000" + n.ToString();
            }
            else if (n < 100)
            {
                str = str + "00" + n.ToString();
            }
            else if (n < 1000)
            {
                str = str + "0" + n.ToString();
            }
            else if (n < 10000)
            {
                str = str + n.ToString();
            }
            return str;
        }

        public List<eKhachHang> LayToanBoDanhSach()
        {
            List<eKhachHang> l = new List<eKhachHang>();
            List<KhachHang> listkh = db.KhachHangs.ToList();
            foreach(KhachHang kh in listkh)
            {
                eKhachHang k = new eKhachHang();
                k.MaKH = kh.maKhachHang;
                k.TenKH = kh.tenKhachHang;
                k.CMNDKH = kh.cmnd;
                k.SdtKH = kh.soDienThoaiKH;
                k.EmailKH = kh.emailKH;
                k.NgaySinh = kh.ngaySinh;
                k.MaDC = kh.maDiaChi;
                l.Add(k);
            }
            return l;
        }

        public List<eKhachHang> LayDanhSachTheoTen(string ten)
        {
            List<eKhachHang> l = new List<eKhachHang>();
            List<KhachHang> listkh = db.KhachHangs.Where(x => x.tenKhachHang.Equals(ten)).ToList();
            foreach (KhachHang kh in listkh)
            {
                eKhachHang k = new eKhachHang();
                k.MaKH = kh.maKhachHang;
                k.TenKH = kh.tenKhachHang;
                k.CMNDKH = kh.cmnd;
                k.SdtKH = kh.soDienThoaiKH;
                k.EmailKH = kh.emailKH;
                k.NgaySinh = kh.ngaySinh;
                k.MaDC = kh.maDiaChi;
                l.Add(k);
            }
            return l;
        }
    }
}

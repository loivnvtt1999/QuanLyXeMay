using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class NhanVienDAL
    {
        QuanLyBanXeDataContext db;
        public NhanVienDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public List<eNhanVien> LayDanhSachNhanVien()
        {
            List<eNhanVien> l = new List<eNhanVien>();
            foreach (NhanVien nv in db.NhanViens)
            {
                eNhanVien nv1 = new eNhanVien();
                nv1.Anh = new MemoryStream(nv.hinhAnh.ToArray());
                nv1.ChucVu = nv.chucVu;
                nv1.Cmnd = nv.cmnd;
                nv1.MaDiaChi = nv.maDiaChi;
                nv1.MaNhanVien = nv.maNhanVien;
                nv1.MatKhau = nv.matKhau;
                nv1.SoDienThoaiNV = nv.soDienThoaiNV;
                nv1.TenNhanVien = nv.tenNhanVien;
                nv1.Email = nv.email;
                nv1.NgaySinh = nv.ngaySinh;
                l.Add(nv1);
            }
            return l;
        }

        public List<eNhanVien> LayDanhSachNhanVienKhongChuaAnh()
        {
            List<eNhanVien> l = new List<eNhanVien>();
            foreach (NhanVien nv in db.NhanViens)
            {
                eNhanVien nv1 = new eNhanVien();
                nv1.ChucVu = nv.chucVu;
                nv1.Cmnd = nv.cmnd;
                nv1.MaDiaChi = nv.maDiaChi;
                nv1.MaNhanVien = nv.maNhanVien;
                nv1.MatKhau = nv.matKhau;
                nv1.SoDienThoaiNV = nv.soDienThoaiNV;
                nv1.TenNhanVien = nv.tenNhanVien;
                nv1.Email = nv.email;
                nv1.NgaySinh = nv.ngaySinh;
                l.Add(nv1);
            }
            return l;
        }

        public eNhanVien TimNhanVienTheoMa(string maNV)
        {
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien.Equals(maNV)).FirstOrDefault();
            if (nv == null)
                return null;
            else
            {
                eNhanVien nv1 = new eNhanVien();
                if (nv.hinhAnh == null)
                {
                    nv1.Anh = null;
                }
                else
                {
                    nv1.Anh = new MemoryStream(nv.hinhAnh.ToArray());
                }
                nv1.ChucVu = nv.chucVu;
                nv1.Cmnd = nv.cmnd;
                nv1.MaDiaChi = nv.maDiaChi;
                nv1.MaNhanVien = nv.maNhanVien;
                nv1.MatKhau = nv.matKhau;
                nv1.SoDienThoaiNV = nv.soDienThoaiNV;
                nv1.TenNhanVien = nv.tenNhanVien;
                nv1.Email = nv.email;
                nv1.NgaySinh = nv.ngaySinh;
                return nv1;
            }
        }

        public bool KiemTraNhanVien(String ma)
        {
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien == ma).FirstOrDefault();
            if (nv == null)
            {
                return false;
            }
            return true;
        }

        public int ThemNhanVien(eNhanVien nvmoi)
        {
            if (KiemTraNhanVien(nvmoi.MaNhanVien))
                return 0;
            NhanVien nv = new NhanVien();
            nv.hinhAnh = nvmoi.Anh.ToArray();
            nv.maDiaChi = nvmoi.MaDiaChi;
            nv.maNhanVien = nvmoi.MaNhanVien;
            nv.email = nvmoi.Email;
            nv.matKhau = nvmoi.MatKhau;
            nv.soDienThoaiNV = nvmoi.SoDienThoaiNV;
            nv.ngaySinh = nvmoi.NgaySinh;
            nv.tenNhanVien = nvmoi.TenNhanVien;
            nv.cmnd = nvmoi.Cmnd;
            nv.chucVu = nvmoi.ChucVu;
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
            return 1;
        }

        public int SuaNhanVien(eNhanVien nvSua)
        {
            if (!KiemTraNhanVien(nvSua.MaNhanVien))
                return 0;
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien == nvSua.MaNhanVien).FirstOrDefault();
            nv.hinhAnh = nvSua.Anh.ToArray();
            nv.maDiaChi = nvSua.MaDiaChi;
            nv.email = nvSua.Email;
            nv.soDienThoaiNV = nvSua.SoDienThoaiNV;
            nv.chucVu = nvSua.ChucVu;
            db.SubmitChanges();
            return 1;
        }

        public int DatLaiMatKhau(string manv)
        {
            if (!KiemTraNhanVien(manv))
                return 0;
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien == manv).FirstOrDefault();
            nv.matKhau = "123";
            db.SubmitChanges();
            return 1;
        }

        public int XoaNhanVien(eNhanVien nvXoa)
        {
            if (!KiemTraNhanVien(nvXoa.MaNhanVien))
                return 0;
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien == nvXoa.MaNhanVien).FirstOrDefault();
            db.NhanViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
            return 1;
        }

        public eNhanVien KiemTraDangNhap(string taikhoan, string matkhau)
        {
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien.Equals(taikhoan) && x.matKhau.Equals(matkhau)).FirstOrDefault();
            if (nv == null)
                return null;
            else
            {
                eNhanVien nv1 = new eNhanVien();
                if (nv.hinhAnh == null)
                {
                    nv1.Anh = null;
                }
                else
                {
                    nv1.Anh = new MemoryStream(nv.hinhAnh.ToArray());
                }
                nv1.ChucVu = nv.chucVu;
                nv1.Cmnd = nv.cmnd;
                nv1.MaDiaChi = nv.maDiaChi;
                nv1.MaNhanVien = nv.maNhanVien;
                nv1.MatKhau = nv.matKhau;
                nv1.SoDienThoaiNV = nv.soDienThoaiNV;
                nv1.TenNhanVien = nv.tenNhanVien;
                nv1.Email = nv.email;
                nv1.NgaySinh = nv.ngaySinh;
                return nv1;
            }
        }

        public int DoiMatKhau(string taikhoan, string matkhau, string matkhaumoi)
        {
            NhanVien nv = db.NhanViens.Where(x => x.maNhanVien.Equals(taikhoan) && x.matKhau.Equals(matkhau)).FirstOrDefault();
            if (nv == null)
                return 0;
            else
            {
                nv.matKhau = matkhaumoi;
                db.SubmitChanges();
                return 1;
            }
        }
        public string PhatSinhMa()
        {
            int n = 0;
            string str = "NV";
            NhanVien nv = db.NhanViens.ToList().LastOrDefault();
            if (nv != null)
            {
                string str1 = nv.maNhanVien.Substring(3);
                n = int.Parse(str1) + 1;
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
    }
}

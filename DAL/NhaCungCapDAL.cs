using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class NhaCungCapDAL
    {
        QuanLyBanXeDataContext db;

        public NhaCungCapDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public bool kiemTraTrungMa(string mancc)
        {
            NhaCungCap nc = db.NhaCungCaps.Where(x => x.maNCC.Equals(mancc)).FirstOrDefault();
            if (nc != null)
            {
                return true;
            }
            return false;
        }

        public int themNhaCungCap(eNhaCungCap nccmoi)
        {
            if (kiemTraTrungMa(nccmoi.MaNCC))
                return 0;
            NhaCungCap nc = new NhaCungCap();
            nc.maNCC = nccmoi.MaNCC;
            nc.tenNCC = nccmoi.TenNCC;
            nc.soDienThoaiNCC = nccmoi.SdtNCC;
            nc.emailNCC = nccmoi.EmailNCC;
            nc.maDiaChi = nccmoi.MaNCC;
            db.NhaCungCaps.InsertOnSubmit(nc);
            db.SubmitChanges();
            return 1;
        }

        public int xoaNhaCungCap(eNhaCungCap nccxoa)
        {
            if (!kiemTraTrungMa(nccxoa.MaNCC))
                return 0;
            NhaCungCap nc = db.NhaCungCaps.Where(x => x.maNCC.Equals(nccxoa.MaNCC)).FirstOrDefault();
            db.NhaCungCaps.DeleteOnSubmit(nc);
            db.SubmitChanges();
            return 1;
        }

        public int suaNhaCungCap(eNhaCungCap nccsua)
        {
            if (!kiemTraTrungMa(nccsua.MaNCC))
                return 0;
            NhaCungCap nc = db.NhaCungCaps.Where(x => x.maNCC.Equals(nccsua.MaNCC)).FirstOrDefault();
            nc.tenNCC = nccsua.TenNCC;
            nc.soDienThoaiNCC = nccsua.SdtNCC;
            nc.emailNCC = nccsua.EmailNCC;
            nc.maDiaChi = nccsua.MaDC;
            db.SubmitChanges();
            return 1;
        }

        public eNhaCungCap layNhaCungCap(string mancc)
        {
            if (!kiemTraTrungMa(mancc))
                return null;
            NhaCungCap nc = db.NhaCungCaps.Where(x => x.maNCC.Equals(mancc)).FirstOrDefault();
            eNhaCungCap n = new eNhaCungCap();
            n.MaNCC = nc.maNCC;
            n.TenNCC = nc.tenNCC;
            n.SdtNCC = nc.soDienThoaiNCC;
            n.EmailNCC = nc.emailNCC;
            n.MaDC = nc.maDiaChi;
            return n;
        }
        public List<eNhaCungCap> LayToanBoNhaCungCap()
        {
            List<eNhaCungCap> l = new List<eNhaCungCap>();
            foreach (NhaCungCap ncc in db.NhaCungCaps)
            {
                eNhaCungCap encc = new eNhaCungCap();
                encc.MaNCC = ncc.maNCC;
                encc.MaDC = ncc.maDiaChi;
                encc.SdtNCC = ncc.soDienThoaiNCC;
                encc.EmailNCC = ncc.emailNCC;
                encc.TenNCC = ncc.tenNCC;
                l.Add(encc);
            }
            return l;
        }
        public string PhatSinhMa()
        {
            int n = 0;
            string str = "NCC";
            NhaCungCap ncc = db.NhaCungCaps.ToList().LastOrDefault();
            if (ncc != null)
            {
                string str1 = ncc.maNCC.Substring(3);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DiaChiDAL
    {
        QuanLyBanXeDataContext db;
        public DiaChiDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public eDiaChi getDiaChiTheoMa(string ma)
        {
            eDiaChi temp = new eDiaChi();
            var dc = db.DiaChis.Where(x => x.maDiaChi.Equals(ma)).FirstOrDefault();
            if (dc == null)
                return null;
            temp.MaDC = dc.maDiaChi;
            temp.SoNha = dc.soNha;
            temp.PhuongXa = dc.phuongXa;
            temp.QuanHuyen = dc.quanHuyen;
            temp.TinhThanhPho = dc.tinhThanh;
            temp.QuocGia = dc.quocGia;
            return temp;
        }

        private bool kiemTraTonTai(string ma)
        {
            var dc = db.DiaChis.Where(x => x.maDiaChi.Equals(ma)).FirstOrDefault();
            if (dc == null)
                return false;
            return true;
        }

        public int addDiaChi(eDiaChi newdc)
        {
            if (kiemTraTonTai(newdc.MaDC))
                return 0;
            DiaChi dc = new DiaChi();
            dc.maDiaChi = newdc.MaDC;
            dc.soNha = newdc.SoNha;
            dc.phuongXa = newdc.PhuongXa;
            dc.quanHuyen = newdc.QuanHuyen;
            dc.tinhThanh = newdc.TinhThanhPho;
            dc.quocGia = newdc.QuocGia;
            db.DiaChis.InsertOnSubmit(dc);
            db.SubmitChanges();
            return 1;
        }
        public string PhatSinhMa()
        {
            int n = 0;
            string str = "DC";
            HoaDon hd = db.HoaDons.ToList().LastOrDefault();
            if (hd != null)
            {
                string str1 = hd.maHoaDon.Substring(2);
                n = int.Parse(str1) + 1;
            }
            if (n < 10)
            {
                str = str + "0000" + n.ToString();
            }
            else if (n < 100)
            {
                str = str + "000" + n.ToString();
            }
            else if (n < 1000)
            {
                str = str + "00" + n.ToString();
            }
            else if (n < 10000)
            {
                str = str + "0" + n.ToString();
            }
            else if (n < 100000)
            {
                str = str + n.ToString();
            }
            return str;
        }
    }
}

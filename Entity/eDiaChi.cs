using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eDiaChi
    {
        string maDC, soNha, phuongXa, quanHuyen, tinhThanhPho, quocGia;

        public eDiaChi()
        {
            this.MaDC = "";
            this.SoNha = "";
            this.PhuongXa = "";
            this.QuanHuyen = "";
            this.TinhThanhPho = "";
            this.QuocGia = "";
        }

        public eDiaChi(string ma, string so, string xa, string huyen, string tinh, string qg)
        {
            this.MaDC = ma;
            this.SoNha = so;
            this.PhuongXa = xa;
            this.QuanHuyen = huyen;
            this.TinhThanhPho = tinh;
            this.QuocGia = qg;
        }

        public string MaDC { get => maDC; set => maDC = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        public string PhuongXa { get => phuongXa; set => phuongXa = value; }
        public string QuanHuyen { get => quanHuyen; set => quanHuyen = value; }
        public string TinhThanhPho { get => tinhThanhPho; set => tinhThanhPho = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
    }
}

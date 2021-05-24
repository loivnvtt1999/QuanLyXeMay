using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eNhaCungCap
    {
        string maNCC, tenNCC, sdtNCC, emailNCC, maDC;

        public eNhaCungCap()
        {
            this.MaNCC = "";
            this.TenNCC = "";
            this.SdtNCC = "";
            this.EmailNCC = "";
            this.MaDC = "";
        }

        public eNhaCungCap(string ma, string ten, string sdt, string email, string dc)
        {
            this.MaNCC = ma;
            this.TenNCC = ten;
            this.SdtNCC = sdt;
            this.EmailNCC = email;
            this.MaDC = dc;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string SdtNCC { get => sdtNCC; set => sdtNCC = value; }
        public string EmailNCC { get => emailNCC; set => emailNCC = value; }
        public string MaDC { get => maDC; set => maDC = value; }
    }
}

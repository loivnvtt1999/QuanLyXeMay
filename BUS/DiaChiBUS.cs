using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class DiaChiBUS
    {
        DiaChiDAL dcDAL;
        public DiaChiBUS()
        {
            this.dcDAL = new DiaChiDAL();
        }

        public eDiaChi LayDiaChiCoMa(string ma)
        {
            return dcDAL.getDiaChiTheoMa(ma);
        }

        public int ThemDiaChi(eDiaChi newdc)
        {
            return dcDAL.addDiaChi(newdc);
        }
        public string PhatSinhMa()
        {
            return dcDAL.PhatSinhMa();
        }
    }
}

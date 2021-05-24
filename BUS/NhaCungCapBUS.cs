using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAL nccDAL;
        public NhaCungCapBUS()
        {
            nccDAL = new NhaCungCapDAL();
        }

        public int themNhaCungCap(eNhaCungCap nccmoi)
        {
            return nccDAL.themNhaCungCap(nccmoi);
        }

        public int xoaNhaCungCap(eNhaCungCap nccxoa)
        {
            return nccDAL.xoaNhaCungCap(nccxoa);
        }

        public int suaNhaCungCap(eNhaCungCap nccsua)
        {
            return nccDAL.suaNhaCungCap(nccsua);
        }
        public eNhaCungCap LayNhaCungCap(string ma)
        {
            return nccDAL.layNhaCungCap(ma);
        }
        public List<eNhaCungCap> LayToanBoNhaCungCap()
        {
            return nccDAL.LayToanBoNhaCungCap();
        }
        public string PhatSinhMa()
        {
            return nccDAL.PhatSinhMa();
        }
    }
}

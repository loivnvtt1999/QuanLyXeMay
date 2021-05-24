using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace GUI
{
    public partial class frmThemNhaCungCap : Form
    {
        public eNhaCungCap nccmoitao;
        DiaChiBUS dcBUS;
        List<eNhaCungCap> lNCC;
        NhaCungCapBUS nccBUS;
        frmNhapDiaChi frmDC;
        eDiaChi dc;
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            lNCC = new List<eNhaCungCap>();
            nccBUS = new NhaCungCapBUS();
            dcBUS = new DiaChiBUS();
            btnLuu.Enabled = false;           
            btnSua.Enabled = false;
            tbxMaNCC.Enabled = false;
            dc = new eDiaChi();
            Khoa();
            btnThemDiaChi.Enabled = false;
            nccmoitao = new eNhaCungCap();
            lNCC = nccBUS.LayToanBoNhaCungCap();
            LoadDataToTreeView(treNCC, lNCC);
        }

        public void LoadDataToTreeView(TreeView tr, List<eNhaCungCap> l)
        {
            tr.Nodes.Clear();
            TreeNode ncon = new TreeNode("Danh sách nhà cung cấp");
            foreach (eNhaCungCap ncc in l)
            {
                TreeNode tn = new TreeNode(ncc.TenNCC);
                tn.Tag = ncc.MaNCC;
                ncon.Nodes.Add(tn);
            }
            tr.Nodes.Add(ncon);
            tr.ExpandAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Lưu ý mã tự phát sinh cần sửa lại
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            Mo();
            btnThem.Enabled = false;
            rtbxDiaChi.Text = null;
            tbxEmail.Text = null;
            tbxTenNCC.Text = null;
            tbxSoDienThoai.Text = null;
            btnThemDiaChi.Enabled = true;
            tbxMaNCC.Text = nccBUS.PhatSinhMa();
            btnLuu.Text = "Lưu thêm";
        }

        private void Khoa()
        {
            rtbxDiaChi.Enabled = false;
            tbxEmail.Enabled = false;
            tbxTenNCC.Enabled = false;
            tbxSoDienThoai.Enabled = false;
        }

        private void Mo()
        {
            rtbxDiaChi.Enabled = true;
            tbxEmail.Enabled = true;
            tbxTenNCC.Enabled = true;
            tbxSoDienThoai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Text = "Lưu sửa";
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            Mo();
            btnThem.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnLuu.Text.Equals("Lưu thêm"))
            {
                btnLuu.Enabled = false;
                eNhaCungCap nccmoi = new eNhaCungCap();
                nccmoi.MaNCC = tbxMaNCC.Text;
                nccmoi.TenNCC = tbxTenNCC.Text;
                nccmoi.EmailNCC = tbxEmail.Text;
                nccmoi.SdtNCC = tbxSoDienThoai.Text;
                nccmoi.MaDC = dc.MaDC;
                int kq = nccBUS.themNhaCungCap(nccmoi);
                if (kq == 1)
                {
                    nccmoitao = nccmoi;
                    MessageBox.Show("Thêm thành công");
                    lNCC = nccBUS.LayToanBoNhaCungCap();
                    LoadDataToTreeView(treNCC, lNCC);
                    btnThemDiaChi.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Text = "Lưu";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("??");
                }
            }
            else if (btnLuu.Text.Equals("Lưu sửa"))
            {
                btnLuu.Enabled = false;
                eNhaCungCap nccmoi = new eNhaCungCap();
                nccmoi.MaNCC = tbxMaNCC.Text;
                nccmoi.TenNCC = tbxTenNCC.Text;
                nccmoi.EmailNCC = tbxEmail.Text;
                nccmoi.SdtNCC = tbxSoDienThoai.Text;
                nccmoi.MaDC = dc.MaDC;
                int kq = nccBUS.suaNhaCungCap(nccmoi);
                if (kq == 1)
                {
                    nccmoitao = nccmoi;
                    MessageBox.Show("Sửa thành công");
                    lNCC = nccBUS.LayToanBoNhaCungCap();
                    LoadDataToTreeView(treNCC, lNCC);
                    btnThemDiaChi.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Text = "Lưu";
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("??");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treNCC_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treNCC.SelectedNode.Level == 1)
            {
                btnLuu.Enabled = false;
                Khoa();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                eNhaCungCap ncc = nccBUS.LayNhaCungCap(treNCC.SelectedNode.Tag.ToString());
                tbxMaNCC.Text = ncc.MaNCC;
                tbxTenNCC.Text = ncc.TenNCC;
                tbxSoDienThoai.Text = ncc.SdtNCC;
                tbxEmail.Text = ncc.EmailNCC;
                dc = dcBUS.LayDiaChiCoMa(ncc.MaDC);             
                string str = dc.SoNha + ", " + dc.PhuongXa + ", " + dc.QuanHuyen + ", " + dc.TinhThanhPho + ", " + dc.QuocGia;
                rtbxDiaChi.Text = str;
            }
        }

        private void btnThemDiaChi_Click(object sender, EventArgs e)
        {
            frmDC = new frmNhapDiaChi();
            frmDC.ShowDialog();
            if (frmDC.DialogResult == DialogResult.OK)
            {
                string diachi = "";
                diachi = frmDC.diaChiTamThoi.SoNha + ", " + frmDC.diaChiTamThoi.PhuongXa + ", " + frmDC.diaChiTamThoi.QuanHuyen + ", " + frmDC.diaChiTamThoi.TinhThanhPho + ", " + frmDC.diaChiTamThoi.QuocGia;
                rtbxDiaChi.Text = diachi;
                dc = frmDC.diaChiTamThoi;
            }
        }
    }
}

namespace GUI
{
    partial class frmThemNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhaCungCap));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpTTNCC = new System.Windows.Forms.GroupBox();
            this.btnThemDiaChi = new System.Windows.Forms.Button();
            this.rtbxDiaChi = new System.Windows.Forms.RichTextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbxTenNCC = new System.Windows.Forms.TextBox();
            this.tbxMaNCC = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.treNCC = new System.Windows.Forms.TreeView();
            this.grpTTNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(721, 332);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 41);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(594, 332);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 41);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(428, 332);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 41);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(280, 332);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 42);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpTTNCC
            // 
            this.grpTTNCC.Controls.Add(this.btnThemDiaChi);
            this.grpTTNCC.Controls.Add(this.rtbxDiaChi);
            this.grpTTNCC.Controls.Add(this.tbxEmail);
            this.grpTTNCC.Controls.Add(this.tbxSoDienThoai);
            this.grpTTNCC.Controls.Add(this.tbxTenNCC);
            this.grpTTNCC.Controls.Add(this.tbxMaNCC);
            this.grpTTNCC.Controls.Add(this.lblDiaChi);
            this.grpTTNCC.Controls.Add(this.lblEmail);
            this.grpTTNCC.Controls.Add(this.lblDienThoai);
            this.grpTTNCC.Controls.Add(this.lblTenNCC);
            this.grpTTNCC.Controls.Add(this.lblMa);
            this.grpTTNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTNCC.Location = new System.Drawing.Point(267, 7);
            this.grpTTNCC.Margin = new System.Windows.Forms.Padding(4);
            this.grpTTNCC.Name = "grpTTNCC";
            this.grpTTNCC.Padding = new System.Windows.Forms.Padding(4);
            this.grpTTNCC.Size = new System.Drawing.Size(560, 318);
            this.grpTTNCC.TabIndex = 7;
            this.grpTTNCC.TabStop = false;
            this.grpTTNCC.Text = "Thông tin nhà cung cấp";
            // 
            // btnThemDiaChi
            // 
            this.btnThemDiaChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemDiaChi.BackgroundImage")));
            this.btnThemDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemDiaChi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDiaChi.Location = new System.Drawing.Point(488, 239);
            this.btnThemDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDiaChi.Name = "btnThemDiaChi";
            this.btnThemDiaChi.Size = new System.Drawing.Size(40, 37);
            this.btnThemDiaChi.TabIndex = 3;
            this.btnThemDiaChi.UseVisualStyleBackColor = true;
            this.btnThemDiaChi.Click += new System.EventHandler(this.btnThemDiaChi_Click);
            // 
            // rtbxDiaChi
            // 
            this.rtbxDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxDiaChi.Location = new System.Drawing.Point(214, 222);
            this.rtbxDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxDiaChi.Name = "rtbxDiaChi";
            this.rtbxDiaChi.Size = new System.Drawing.Size(263, 79);
            this.rtbxDiaChi.TabIndex = 2;
            this.rtbxDiaChi.Text = "";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(214, 171);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(334, 30);
            this.tbxEmail.TabIndex = 1;
            // 
            // tbxSoDienThoai
            // 
            this.tbxSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoDienThoai.Location = new System.Drawing.Point(214, 127);
            this.tbxSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoDienThoai.Name = "tbxSoDienThoai";
            this.tbxSoDienThoai.Size = new System.Drawing.Size(334, 30);
            this.tbxSoDienThoai.TabIndex = 1;
            // 
            // tbxTenNCC
            // 
            this.tbxTenNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenNCC.Location = new System.Drawing.Point(214, 83);
            this.tbxTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenNCC.Name = "tbxTenNCC";
            this.tbxTenNCC.Size = new System.Drawing.Size(334, 30);
            this.tbxTenNCC.TabIndex = 1;
            // 
            // tbxMaNCC
            // 
            this.tbxMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaNCC.Location = new System.Drawing.Point(214, 38);
            this.tbxMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaNCC.Name = "tbxMaNCC";
            this.tbxMaNCC.Size = new System.Drawing.Size(334, 30);
            this.tbxMaNCC.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(121, 222);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 22);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(131, 177);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(76, 133);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(120, 22);
            this.lblDienThoai.TabIndex = 0;
            this.lblDienThoai.Text = "Số điện thoại:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.Location = new System.Drawing.Point(40, 89);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(152, 22);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(45, 44);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(148, 22);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã nhà cung cấp:";
            // 
            // treNCC
            // 
            this.treNCC.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treNCC.Location = new System.Drawing.Point(9, 7);
            this.treNCC.Margin = new System.Windows.Forms.Padding(4);
            this.treNCC.Name = "treNCC";
            this.treNCC.Size = new System.Drawing.Size(252, 376);
            this.treNCC.TabIndex = 6;
            this.treNCC.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treNCC_AfterSelect);
            // 
            // frmThemNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 393);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpTTNCC);
            this.Controls.Add(this.treNCC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmThemNhaCungCap";
            this.Load += new System.EventHandler(this.frmThemNhaCungCap_Load);
            this.grpTTNCC.ResumeLayout(false);
            this.grpTTNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpTTNCC;
        private System.Windows.Forms.Button btnThemDiaChi;
        private System.Windows.Forms.RichTextBox rtbxDiaChi;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSoDienThoai;
        private System.Windows.Forms.TextBox tbxTenNCC;
        private System.Windows.Forms.TextBox tbxMaNCC;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TreeView treNCC;
    }
}
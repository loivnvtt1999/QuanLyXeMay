namespace GUI
{
    partial class frmThongKeHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeHoaDon));
            this.grpCT = new System.Windows.Forms.GroupBox();
            this.bdnCT = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ttbxHD2 = new System.Windows.Forms.ToolStripTextBox();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.tbxTongHD = new System.Windows.Forms.TextBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.grpHD = new System.Windows.Forms.GroupBox();
            this.bdnHD = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXemChiTiet = new System.Windows.Forms.ToolStripButton();
            this.tbtnSapXep = new System.Windows.Forms.ToolStripButton();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.grpThangNam = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.grpCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnCT)).BeginInit();
            this.bdnCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.grpHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnHD)).BeginInit();
            this.bdnHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.grpThangNam.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCT
            // 
            this.grpCT.Controls.Add(this.bdnCT);
            this.grpCT.Controls.Add(this.dgvCT);
            this.grpCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpCT.Location = new System.Drawing.Point(0, 393);
            this.grpCT.Name = "grpCT";
            this.grpCT.Size = new System.Drawing.Size(1483, 284);
            this.grpCT.TabIndex = 13;
            this.grpCT.TabStop = false;
            this.grpCT.Text = "Chi tiết hóa đơn";
            // 
            // bdnCT
            // 
            this.bdnCT.AddNewItem = null;
            this.bdnCT.CountItem = this.bindingNavigatorCountItem1;
            this.bdnCT.CountItemFormat = "trên {0}";
            this.bdnCT.DeleteItem = null;
            this.bdnCT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnCT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.toolStripLabel1,
            this.ttbxHD2});
            this.bdnCT.Location = new System.Drawing.Point(3, 26);
            this.bdnCT.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bdnCT.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bdnCT.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bdnCT.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bdnCT.Name = "bdnCT";
            this.bdnCT.PositionItem = this.bindingNavigatorPositionItem1;
            this.bdnCT.Size = new System.Drawing.Size(1477, 27);
            this.bdnCT.TabIndex = 8;
            this.bdnCT.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(57, 24);
            this.bindingNavigatorCountItem1.Text = "trên {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Tổng số sản phẩm";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Vị trí sản phẩm";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 24);
            this.toolStripLabel1.Text = "Hóa đơn";
            // 
            // ttbxHD2
            // 
            this.ttbxHD2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ttbxHD2.Name = "ttbxHD2";
            this.ttbxHD2.ReadOnly = true;
            this.ttbxHD2.Size = new System.Drawing.Size(100, 27);
            // 
            // dgvCT
            // 
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCT.Location = new System.Drawing.Point(3, 56);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 51;
            this.dgvCT.RowTemplate.Height = 24;
            this.dgvCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT.Size = new System.Drawing.Size(1477, 225);
            this.dgvCT.TabIndex = 7;
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSo.Location = new System.Drawing.Point(159, 710);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(147, 22);
            this.lblTongSo.TabIndex = 11;
            this.lblTongSo.Text = "Tổng số hóa đơn:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.Location = new System.Drawing.Point(751, 710);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(181, 22);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "Tổng tiền trong tháng:";
            // 
            // tbxTongHD
            // 
            this.tbxTongHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTongHD.Location = new System.Drawing.Point(372, 705);
            this.tbxTongHD.Name = "tbxTongHD";
            this.tbxTongHD.ReadOnly = true;
            this.tbxTongHD.Size = new System.Drawing.Size(221, 30);
            this.tbxTongHD.TabIndex = 9;
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTongTien.Location = new System.Drawing.Point(990, 710);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.ReadOnly = true;
            this.tbxTongTien.Size = new System.Drawing.Size(222, 30);
            this.tbxTongTien.TabIndex = 10;
            // 
            // grpHD
            // 
            this.grpHD.Controls.Add(this.bdnHD);
            this.grpHD.Controls.Add(this.dgvHD);
            this.grpHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpHD.Location = new System.Drawing.Point(0, 90);
            this.grpHD.Name = "grpHD";
            this.grpHD.Size = new System.Drawing.Size(1483, 303);
            this.grpHD.TabIndex = 8;
            this.grpHD.TabStop = false;
            this.grpHD.Text = "Hóa đơn trong tháng";
            // 
            // bdnHD
            // 
            this.bdnHD.AddNewItem = null;
            this.bdnHD.CountItem = this.bindingNavigatorCountItem;
            this.bdnHD.CountItemFormat = "trên {0}";
            this.bdnHD.DeleteItem = null;
            this.bdnHD.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnHD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnXemChiTiet,
            this.tbtnSapXep});
            this.bdnHD.Location = new System.Drawing.Point(3, 26);
            this.bdnHD.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnHD.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnHD.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnHD.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnHD.Name = "bdnHD";
            this.bdnHD.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnHD.Size = new System.Drawing.Size(1477, 27);
            this.bdnHD.TabIndex = 1;
            this.bdnHD.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 24);
            this.bindingNavigatorCountItem.Text = "trên {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số hóa đơn";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hóa đơn";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTiet.Image")));
            this.btnXemChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(155, 24);
            this.btnXemChiTiet.Text = "Xem chi tiết hóa đơn";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // tbtnSapXep
            // 
            this.tbtnSapXep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnSapXep.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSapXep.Image")));
            this.tbtnSapXep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSapXep.Name = "tbtnSapXep";
            this.tbtnSapXep.Size = new System.Drawing.Size(162, 24);
            this.tbtnSapXep.Text = "Sắp xếp theo tổng tiền";
            this.tbtnSapXep.Click += new System.EventHandler(this.tbtnSapXep_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHD.Location = new System.Drawing.Point(3, 56);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(1477, 244);
            this.dgvHD.TabIndex = 7;
            this.dgvHD.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dgvHD.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // grpThangNam
            // 
            this.grpThangNam.Controls.Add(this.btnThongKe);
            this.grpThangNam.Controls.Add(this.cbNam);
            this.grpThangNam.Controls.Add(this.cbThang);
            this.grpThangNam.Controls.Add(this.lblNam);
            this.grpThangNam.Controls.Add(this.lblThang);
            this.grpThangNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThangNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThangNam.Location = new System.Drawing.Point(0, 0);
            this.grpThangNam.Name = "grpThangNam";
            this.grpThangNam.Size = new System.Drawing.Size(1483, 90);
            this.grpThangNam.TabIndex = 7;
            this.grpThangNam.TabStop = false;
            this.grpThangNam.Text = "Chọn thời điểm thống kê";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(1157, 30);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(178, 37);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cbNam.Location = new System.Drawing.Point(736, 33);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(303, 30);
            this.cbNam.TabIndex = 1;
            this.cbNam.Text = "2019";
            this.cbNam.SelectedValueChanged += new System.EventHandler(this.cbNam_SelectedValueChanged);
            this.cbNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNam_KeyDown);
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(237, 33);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(303, 30);
            this.cbThang.TabIndex = 1;
            this.cbThang.Text = "1";
            this.cbThang.SelectedValueChanged += new System.EventHandler(this.cbThang_SelectedValueChanged);
            this.cbThang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbThang_KeyDown);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(619, 41);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(53, 22);
            this.lblNam.TabIndex = 0;
            this.lblNam.Text = "Năm:";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(118, 41);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(64, 22);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // frmThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 767);
            this.Controls.Add(this.grpCT);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.tbxTongHD);
            this.Controls.Add(this.tbxTongTien);
            this.Controls.Add(this.grpHD);
            this.Controls.Add(this.grpThangNam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKeHoaDon";
            this.Text = "frmThongKeHoaDon";
            this.Load += new System.EventHandler(this.frmThongKeHoaDon_Load);
            this.grpCT.ResumeLayout(false);
            this.grpCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnCT)).EndInit();
            this.bdnCT.ResumeLayout(false);
            this.bdnCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.grpHD.ResumeLayout(false);
            this.grpHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnHD)).EndInit();
            this.bdnHD.ResumeLayout(false);
            this.bdnHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.grpThangNam.ResumeLayout(false);
            this.grpThangNam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCT;
        private System.Windows.Forms.BindingNavigator bdnCT;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ttbxHD2;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox tbxTongHD;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.GroupBox grpHD;
        private System.Windows.Forms.BindingNavigator bdnHD;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnXemChiTiet;
        private System.Windows.Forms.ToolStripButton tbtnSapXep;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.GroupBox grpThangNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
    }
}
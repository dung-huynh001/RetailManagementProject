
namespace CT239_NienLuan_QLBH
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHoiVien = new System.Windows.Forms.ComboBox();
            this.chkHoiVien = new System.Windows.Forms.CheckBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lVHoaDon = new System.Windows.Forms.ListView();
            this.SanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btTaoHoaDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.Controls.Add(this.txtGiamGia);
            this.gbHoaDon.Controls.Add(this.label5);
            this.gbHoaDon.Controls.Add(this.txtThanhToan);
            this.gbHoaDon.Controls.Add(this.label4);
            this.gbHoaDon.Controls.Add(this.cbHoiVien);
            this.gbHoaDon.Controls.Add(this.chkHoiVien);
            this.gbHoaDon.Controls.Add(this.txtTongTien);
            this.gbHoaDon.Controls.Add(this.label3);
            this.gbHoaDon.Controls.Add(this.lVHoaDon);
            this.gbHoaDon.Location = new System.Drawing.Point(484, 159);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(419, 408);
            this.gbHoaDon.TabIndex = 2;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Hóa đơn thanh toán";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(311, 342);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(34, 20);
            this.txtGiamGia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giảm giá";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(311, 371);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(82, 20);
            this.txtThanhToan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thanh Toán";
            // 
            // cbHoiVien
            // 
            this.cbHoiVien.FormattingEnabled = true;
            this.cbHoiVien.Location = new System.Drawing.Point(115, 17);
            this.cbHoiVien.Name = "cbHoiVien";
            this.cbHoiVien.Size = new System.Drawing.Size(121, 21);
            this.cbHoiVien.TabIndex = 4;
            this.cbHoiVien.SelectionChangeCommitted += new System.EventHandler(this.cbHoiVien_SelectionChangeCommitted);
            // 
            // chkHoiVien
            // 
            this.chkHoiVien.AutoSize = true;
            this.chkHoiVien.Location = new System.Drawing.Point(25, 19);
            this.chkHoiVien.Name = "chkHoiVien";
            this.chkHoiVien.Size = new System.Drawing.Size(84, 17);
            this.chkHoiVien.TabIndex = 3;
            this.chkHoiVien.Text = "Khách quen";
            this.chkHoiVien.UseVisualStyleBackColor = true;
            this.chkHoiVien.CheckedChanged += new System.EventHandler(this.chkHoiVien_CheckedChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(311, 314);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(82, 20);
            this.txtTongTien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng cộng";
            // 
            // lVHoaDon
            // 
            this.lVHoaDon.CheckBoxes = true;
            this.lVHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SanPham,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.lVHoaDon.FullRowSelect = true;
            this.lVHoaDon.GridLines = true;
            this.lVHoaDon.HideSelection = false;
            this.lVHoaDon.Location = new System.Drawing.Point(25, 55);
            this.lVHoaDon.Name = "lVHoaDon";
            this.lVHoaDon.Size = new System.Drawing.Size(361, 246);
            this.lVHoaDon.TabIndex = 0;
            this.lVHoaDon.UseCompatibleStateImageBehavior = false;
            this.lVHoaDon.View = System.Windows.Forms.View.Details;
            this.lVHoaDon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lVHoaDon_ItemSelectionChanged);
            this.lVHoaDon.SelectedIndexChanged += new System.EventHandler(this.lVHoaDon_SelectedIndexChanged);
            // 
            // SanPham
            // 
            this.SanPham.Text = "Tên sản phẩm";
            this.SanPham.Width = 126;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 86;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 82;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(803, 573);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(92, 23);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu Hóa Đơn";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(708, 573);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonGiaBan,
            this.MaLoaiSP});
            this.dgvMenu.Location = new System.Drawing.Point(18, 19);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(382, 364);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.Frozen = true;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 45;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Giá";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 70;
            // 
            // MaLoaiSP
            // 
            this.MaLoaiSP.DataPropertyName = "MaLoaiSP";
            this.MaLoaiSP.HeaderText = "Loại SP";
            this.MaLoaiSP.Name = "MaLoaiSP";
            this.MaLoaiSP.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMenu);
            this.groupBox1.Location = new System.Drawing.Point(33, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Cửa hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuHomePage";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.cấpTàiKhoảnToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::CT239_NienLuan_QLBH.Properties.Resources.home;
            this.hệThốngToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.trangChủToolStripMenuItem.Text = "Giới thiệu";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // cấpTàiKhoảnToolStripMenuItem
            // 
            this.cấpTàiKhoảnToolStripMenuItem.Name = "cấpTàiKhoảnToolStripMenuItem";
            this.cấpTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cấpTàiKhoảnToolStripMenuItem.Text = "Cấp tài khoản";
            this.cấpTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.cấpTàiKhoảnToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Image = global::CT239_NienLuan_QLBH.Properties.Resources.save_money;
            this.doanhThuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.doanhThuToolStripMenuItem.Text = "Quản lý danh thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHàngHóaToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Image = global::CT239_NienLuan_QLBH.Properties.Resources.list_text;
            this.quảnLýDanhMụcToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.quảnLýHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::CT239_NienLuan_QLBH.Properties.Resources.account;
            this.thôngTinTàiKhoảnToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.đăngXuấtToolStripMenuItem.Image = global::CT239_NienLuan_QLBH.Properties.Resources.logout;
            this.đăngXuấtToolStripMenuItem.Margin = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.cbTenSP);
            this.groupBox2.Controls.Add(this.cbLoaiSP);
            this.groupBox2.Controls.Add(this.nudSoLuong);
            this.groupBox2.Controls.Add(this.btTaoHoaDon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(484, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 104);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(160, 75);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(76, 23);
            this.btReset.TabIndex = 24;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTenSP
            // 
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(105, 43);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(121, 21);
            this.cbTenSP.TabIndex = 23;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(105, 15);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiSP.TabIndex = 22;
            this.cbLoaiSP.SelectionChangeCommitted += new System.EventHandler(this.cbLoaiSP_SelectionChangeCommitted);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(289, 44);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(49, 20);
            this.nudSoLuong.TabIndex = 21;
            // 
            // btTaoHoaDon
            // 
            this.btTaoHoaDon.Location = new System.Drawing.Point(242, 75);
            this.btTaoHoaDon.Name = "btTaoHoaDon";
            this.btTaoHoaDon.Size = new System.Drawing.Size(107, 23);
            this.btTaoHoaDon.TabIndex = 19;
            this.btTaoHoaDon.Text = "Thêm vào hóa đơn";
            this.btTaoHoaDon.UseVisualStyleBackColor = true;
            this.btTaoHoaDon.Click += new System.EventHandler(this.btTaoHoaDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Loại sản phẩm";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.gbHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSales";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btTaoHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lVHoaDon;
        private System.Windows.Forms.ColumnHeader SanPham;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkHoiVien;
        private System.Windows.Forms.ComboBox cbHoiVien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấpTàiKhoảnToolStripMenuItem;
    }
}
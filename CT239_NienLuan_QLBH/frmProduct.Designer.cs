
namespace CT239_NienLuan_QLBH
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.menuHoaDonBanHang = new System.Windows.Forms.MenuStrip();
            this.msAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.msUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.msDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.msSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.msPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDonBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHoaDonBanHang
            // 
            this.menuHoaDonBanHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuHoaDonBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAdd,
            this.msUpdate,
            this.msDelete,
            this.msSearch,
            this.txtTimKiem,
            this.msPrint,
            this.msLogout});
            this.menuHoaDonBanHang.Location = new System.Drawing.Point(0, 0);
            this.menuHoaDonBanHang.Name = "menuHoaDonBanHang";
            this.menuHoaDonBanHang.Size = new System.Drawing.Size(946, 28);
            this.menuHoaDonBanHang.TabIndex = 0;
            this.menuHoaDonBanHang.Text = "menuHoaDonBanHang";
            // 
            // msAdd
            // 
            this.msAdd.Image = ((System.Drawing.Image)(resources.GetObject("msAdd.Image")));
            this.msAdd.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msAdd.Name = "msAdd";
            this.msAdd.Size = new System.Drawing.Size(65, 24);
            this.msAdd.Text = "Thêm";
            this.msAdd.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // msUpdate
            // 
            this.msUpdate.Image = ((System.Drawing.Image)(resources.GetObject("msUpdate.Image")));
            this.msUpdate.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msUpdate.Name = "msUpdate";
            this.msUpdate.Size = new System.Drawing.Size(54, 24);
            this.msUpdate.Text = "Sửa";
            this.msUpdate.Click += new System.EventHandler(this.suaToolStripMenuItem_Click);
            // 
            // msDelete
            // 
            this.msDelete.Image = global::CT239_NienLuan_QLBH.Properties.Resources.delete;
            this.msDelete.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msDelete.Name = "msDelete";
            this.msDelete.Size = new System.Drawing.Size(55, 24);
            this.msDelete.Text = "Xóa";
            this.msDelete.Click += new System.EventHandler(this.msDelete_Click);
            // 
            // msSearch
            // 
            this.msSearch.Image = ((System.Drawing.Image)(resources.GetObject("msSearch.Image")));
            this.msSearch.Margin = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.msSearch.Name = "msSearch";
            this.msSearch.Size = new System.Drawing.Size(85, 24);
            this.msSearch.Text = "Tìm Kiếm";
            this.msSearch.Click += new System.EventHandler(this.msSearch_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(120, 24);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // msPrint
            // 
            this.msPrint.Image = ((System.Drawing.Image)(resources.GetObject("msPrint.Image")));
            this.msPrint.Margin = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.msPrint.Name = "msPrint";
            this.msPrint.Size = new System.Drawing.Size(45, 20);
            this.msPrint.Text = "In";
            this.msPrint.Click += new System.EventHandler(this.msPrint_Click);
            // 
            // msLogout
            // 
            this.msLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msLogout.Image = ((System.Drawing.Image)(resources.GetObject("msLogout.Image")));
            this.msLogout.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(65, 24);
            this.msLogout.Text = "Thoát";
            this.msLogout.Click += new System.EventHandler(this.msLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(130, 81);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(137, 20);
            this.txtTenSanPham.TabIndex = 5;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(130, 116);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(57, 20);
            this.txtDonViTinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(130, 151);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(89, 20);
            this.txtGiaNhap.TabIndex = 8;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonViTinh,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.SoLuongNhap,
            this.TonKho});
            this.dgvSanPham.Location = new System.Drawing.Point(314, 57);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(592, 360);
            this.dgvSanPham.TabIndex = 9;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.Frozen = true;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 65;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 130;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 65;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Giá nhập";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.Width = 75;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Giá bán";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 75;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "S.Lượng nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Width = 70;
            // 
            // TonKho
            // 
            this.TonKho.DataPropertyName = "SoLuongTon";
            this.TonKho.HeaderText = "Tồn kho";
            this.TonKho.Name = "TonKho";
            this.TonKho.Width = 70;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(130, 187);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(89, 20);
            this.txtGiaBan.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá bán";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(130, 224);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(41, 20);
            this.txtSoLuongNhap.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng nhập";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(192, 378);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btXacNhan.TabIndex = 16;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(96, 378);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 17;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(130, 261);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(41, 20);
            this.txtTonKho.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tồn kho";
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Location = new System.Drawing.Point(129, 300);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(105, 21);
            this.cbLoaiSanPham.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loại sản phẩm";
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("timKiemToolStripMenuItem.Image")));
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.timKiemToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 455);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.cbLoaiSanPham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuHoaDonBanHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuHoaDonBanHang;
            this.Name = "frmProduct";
            this.Text = " Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuHoaDonBanHang.ResumeLayout(false);
            this.menuHoaDonBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHoaDonBanHang;
        private System.Windows.Forms.ToolStripMenuItem msAdd;
        private System.Windows.Forms.ToolStripMenuItem msUpdate;
        private System.Windows.Forms.ToolStripMenuItem msDelete;
        private System.Windows.Forms.ToolStripMenuItem msPrint;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripMenuItem msSearch;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripMenuItem timKiemToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
    }
}


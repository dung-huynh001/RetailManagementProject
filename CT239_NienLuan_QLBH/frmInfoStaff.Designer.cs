
namespace CT239_NienLuan_QLBH
{
    partial class frmInfoStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoStaff));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbChanDung = new System.Windows.Forms.GroupBox();
            this.picChonAnh = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.btChonAnh = new System.Windows.Forms.Button();
            this.menuHoaDonBanHang = new System.Windows.Forms.MenuStrip();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.gbInfo.SuspendLayout();
            this.gbChanDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChonAnh)).BeginInit();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.menuHoaDonBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtpNgaySinh);
            this.gbInfo.Controls.Add(this.btHuy);
            this.gbInfo.Controls.Add(this.btXacNhan);
            this.gbInfo.Controls.Add(this.chkGioiTinh);
            this.gbInfo.Controls.Add(this.txtSDT);
            this.gbInfo.Controls.Add(this.txtDiaChi);
            this.gbInfo.Controls.Add(this.txtHoTen);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Location = new System.Drawing.Point(40, 71);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(396, 227);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin chi tiêt";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(102, 67);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 19;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 5, 4, 9, 38, 0, 0);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(203, 186);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 18;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(302, 186);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btXacNhan.TabIndex = 17;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(322, 34);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(40, 17);
            this.chkGioiTinh.TabIndex = 12;
            this.chkGioiTinh.Text = "Nữ";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(102, 141);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(102, 103);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(102, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(134, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // gbChanDung
            // 
            this.gbChanDung.Controls.Add(this.picChonAnh);
            this.gbChanDung.Location = new System.Drawing.Point(490, 71);
            this.gbChanDung.Name = "gbChanDung";
            this.gbChanDung.Size = new System.Drawing.Size(129, 161);
            this.gbChanDung.TabIndex = 2;
            this.gbChanDung.TabStop = false;
            this.gbChanDung.Text = "Hình đại diện";
            // 
            // picChonAnh
            // 
            this.picChonAnh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picChonAnh.Location = new System.Drawing.Point(6, 19);
            this.picChonAnh.Name = "picChonAnh";
            this.picChonAnh.Size = new System.Drawing.Size(117, 136);
            this.picChonAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChonAnh.TabIndex = 0;
            this.picChonAnh.TabStop = false;
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.dgvNhanVien);
            this.gbDanhSach.Location = new System.Drawing.Point(40, 304);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(579, 294);
            this.gbDanhSach.TabIndex = 3;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh Sách Nhân Viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Ho,
            this.Ten,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.SDT,
            this.Anh});
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 19);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(567, 269);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.Frozen = true;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 40;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            this.Ho.Width = 80;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.Width = 50;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Nữ";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GioiTinh.Width = 40;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 70;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 174;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.Width = 70;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "AnhDaiDien";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.Name = "Anh";
            this.Anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btChonAnh
            // 
            this.btChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChonAnh.Location = new System.Drawing.Point(544, 238);
            this.btChonAnh.Name = "btChonAnh";
            this.btChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btChonAnh.TabIndex = 4;
            this.btChonAnh.Text = "Chọn ảnh";
            this.btChonAnh.UseVisualStyleBackColor = true;
            this.btChonAnh.Click += new System.EventHandler(this.btAnh_Click);
            // 
            // menuHoaDonBanHang
            // 
            this.menuHoaDonBanHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuHoaDonBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.suaToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.txtTimKiem,
            this.thoatToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuHoaDonBanHang.Location = new System.Drawing.Point(0, 0);
            this.menuHoaDonBanHang.Name = "menuHoaDonBanHang";
            this.menuHoaDonBanHang.Size = new System.Drawing.Size(667, 27);
            this.menuHoaDonBanHang.TabIndex = 5;
            this.menuHoaDonBanHang.Text = "menuHoaDonBanHang";
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("themToolStripMenuItem.Image")));
            this.themToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.themToolStripMenuItem.Text = "Thêm";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suaToolStripMenuItem.Image")));
            this.suaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.suaToolStripMenuItem.Text = "Sửa";
            this.suaToolStripMenuItem.Click += new System.EventHandler(this.suaToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Image = global::CT239_NienLuan_QLBH.Properties.Resources.delete;
            this.xoaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem.Image")));
            this.tìmKiếmToolStripMenuItem.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(120, 23);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem.Image")));
            this.thoatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.thoatToolStripMenuItem.Text = "In";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ofdChonAnh
            // 
            this.ofdChonAnh.FileName = "ofdChonAnh";
            // 
            // frmInfoStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 637);
            this.Controls.Add(this.menuHoaDonBanHang);
            this.Controls.Add(this.btChonAnh);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbChanDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfoStaff";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmInfoNhanVien_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbChanDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChonAnh)).EndInit();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.menuHoaDonBanHang.ResumeLayout(false);
            this.menuHoaDonBanHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChanDung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btChonAnh;
        private System.Windows.Forms.PictureBox picChonAnh;
        private System.Windows.Forms.MenuStrip menuHoaDonBanHang;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.OpenFileDialog ofdChonAnh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewImageColumn Anh;
    }
}
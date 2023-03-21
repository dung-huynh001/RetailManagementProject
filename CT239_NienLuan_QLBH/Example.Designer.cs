
namespace CT239_NienLuan_QLBH
{
    partial class Example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Example));
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuHoaDonBanHang = new System.Windows.Forms.MenuStrip();
            this.msAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.msUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.msDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.msSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.msPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.menuHoaDonBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(131, 141);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(89, 20);
            this.txtGiaNhap.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Giá nhập";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(131, 106);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(57, 20);
            this.txtDonViTinh.TabIndex = 40;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(131, 71);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(137, 20);
            this.txtTenSanPham.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(131, 251);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(41, 20);
            this.txtTonKho.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Tồn kho";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(97, 368);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 51;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(193, 368);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btXacNhan.TabIndex = 50;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Location = new System.Drawing.Point(130, 290);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(105, 21);
            this.cbLoaiSanPham.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Loại sản phẩm";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(131, 214);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(41, 20);
            this.txtSoLuongNhap.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Số lượng nhập";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(131, 177);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(89, 20);
            this.txtGiaBan.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Giá bán";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn,
            this.donGiaBanDataGridViewTextBoxColumn,
            this.donGiaNhapDataGridViewTextBoxColumn,
            this.soLuongNhapDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn});
            this.dgvSanPham.DataSource = this.sANPHAMBindingSource;
            this.dgvSanPham.Location = new System.Drawing.Point(293, 47);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(665, 360);
            this.dgvSanPham.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Đơn vị tính";
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
            this.menuHoaDonBanHang.Size = new System.Drawing.Size(1003, 28);
            this.menuHoaDonBanHang.TabIndex = 54;
            this.menuHoaDonBanHang.Text = "menuHoaDonBanHang";
            // 
            // msAdd
            // 
            this.msAdd.Image = ((System.Drawing.Image)(resources.GetObject("msAdd.Image")));
            this.msAdd.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msAdd.Name = "msAdd";
            this.msAdd.Size = new System.Drawing.Size(65, 24);
            this.msAdd.Text = "Thêm";
            this.msAdd.Click += new System.EventHandler(this.msAdd_Click);
            // 
            // msUpdate
            // 
            this.msUpdate.Image = ((System.Drawing.Image)(resources.GetObject("msUpdate.Image")));
            this.msUpdate.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msUpdate.Name = "msUpdate";
            this.msUpdate.Size = new System.Drawing.Size(54, 24);
            this.msUpdate.Text = "Sửa";
            // 
            // msDelete
            // 
            this.msDelete.Image = global::CT239_NienLuan_QLBH.Properties.Resources.delete;
            this.msDelete.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msDelete.Name = "msDelete";
            this.msDelete.Size = new System.Drawing.Size(55, 24);
            this.msDelete.Text = "Xóa";
            // 
            // msSearch
            // 
            this.msSearch.Image = ((System.Drawing.Image)(resources.GetObject("msSearch.Image")));
            this.msSearch.Margin = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.msSearch.Name = "msSearch";
            this.msSearch.Size = new System.Drawing.Size(85, 24);
            this.msSearch.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(120, 24);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown_1);
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
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.Width = 65;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            this.donViTinhDataGridViewTextBoxColumn.Width = 90;
            // 
            // donGiaBanDataGridViewTextBoxColumn
            // 
            this.donGiaBanDataGridViewTextBoxColumn.DataPropertyName = "DonGiaBan";
            this.donGiaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.donGiaBanDataGridViewTextBoxColumn.Name = "donGiaBanDataGridViewTextBoxColumn";
            this.donGiaBanDataGridViewTextBoxColumn.Width = 80;
            // 
            // donGiaNhapDataGridViewTextBoxColumn
            // 
            this.donGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.donGiaNhapDataGridViewTextBoxColumn.Name = "donGiaNhapDataGridViewTextBoxColumn";
            this.donGiaNhapDataGridViewTextBoxColumn.Width = 80;
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            this.soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.HeaderText = "S.lượng nhập";
            this.soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            this.soLuongNhapDataGridViewTextBoxColumn.Width = 90;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "Còn lại";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.Width = 90;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataSource = typeof(CT239_NienLuan_QLBH.SANPHAM);
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 455);
            this.Controls.Add(this.menuHoaDonBanHang);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.label3);
            this.Name = "Example";
            this.Text = "Example";
            this.Load += new System.EventHandler(this.Example_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.menuHoaDonBanHang.ResumeLayout(false);
            this.menuHoaDonBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuHoaDonBanHang;
        private System.Windows.Forms.ToolStripMenuItem msAdd;
        private System.Windows.Forms.ToolStripMenuItem msUpdate;
        private System.Windows.Forms.ToolStripMenuItem msDelete;
        private System.Windows.Forms.ToolStripMenuItem msSearch;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripMenuItem msPrint;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
    }
}

namespace CT239_NienLuan_QLBH
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.gbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsrname = new System.Windows.Forms.TextBox();
            this.lbRPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.gbTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaiKhoan
            // 
            this.gbTaiKhoan.Controls.Add(this.cbPermission);
            this.gbTaiKhoan.Controls.Add(this.label1);
            this.gbTaiKhoan.Controls.Add(this.txtRePass);
            this.gbTaiKhoan.Controls.Add(this.txtPass);
            this.gbTaiKhoan.Controls.Add(this.txtUsrname);
            this.gbTaiKhoan.Controls.Add(this.lbRPassword);
            this.gbTaiKhoan.Controls.Add(this.lbPassword);
            this.gbTaiKhoan.Controls.Add(this.lbUsername);
            this.gbTaiKhoan.Location = new System.Drawing.Point(52, 54);
            this.gbTaiKhoan.Name = "gbTaiKhoan";
            this.gbTaiKhoan.Size = new System.Drawing.Size(352, 171);
            this.gbTaiKhoan.TabIndex = 4;
            this.gbTaiKhoan.TabStop = false;
            this.gbTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // cbPermission
            // 
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Items.AddRange(new object[] {
            "1 - Quản lý",
            "2 - Bán hàng"});
            this.cbPermission.Location = new System.Drawing.Point(137, 125);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(102, 21);
            this.cbPermission.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quyền hạn";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(137, 91);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(131, 20);
            this.txtRePass.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(137, 58);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(131, 20);
            this.txtPass.TabIndex = 8;
            // 
            // txtUsrname
            // 
            this.txtUsrname.Location = new System.Drawing.Point(137, 28);
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.Size = new System.Drawing.Size(131, 20);
            this.txtUsrname.TabIndex = 7;
            // 
            // lbRPassword
            // 
            this.lbRPassword.AutoSize = true;
            this.lbRPassword.Location = new System.Drawing.Point(38, 94);
            this.lbRPassword.Name = "lbRPassword";
            this.lbRPassword.Size = new System.Drawing.Size(93, 13);
            this.lbRPassword.TabIndex = 6;
            this.lbRPassword.Text = "Nhập lại mật khẩu";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(38, 61);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(52, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(38, 31);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 13);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Tên đăng nhập";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(240, 248);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(65, 28);
            this.btHuy.TabIndex = 5;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(339, 248);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(65, 28);
            this.btXacNhan.TabIndex = 6;
            this.btXacNhan.Text = "Xác Nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cấp cho nhân viên";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(127, 18);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cbNhanVien.TabIndex = 8;
            this.cbNhanVien.SelectionChangeCommitted += new System.EventHandler(this.cbNhanVien_SelectionChangeCommitted);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 306);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.gbTaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSignUp";
            this.Text = "Cấp Tài Khoản";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.gbTaiKhoan.ResumeLayout(false);
            this.gbTaiKhoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTaiKhoan;
        private System.Windows.Forms.Label lbRPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsrname;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.TextBox txtRePass;
    }
}
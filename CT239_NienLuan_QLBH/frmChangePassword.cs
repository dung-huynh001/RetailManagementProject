using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CT239_NienLuan_QLBH
{
    public partial class frmChangePassword : Form
    {
        DataProvider sql = new DataProvider();
        DataTable DtTaiKhoan;
        String usr;
        String oldpss;


        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            usr = frmLogin.Usr;
            DtTaiKhoan = sql.FillDataTable("SELECT Password FROM TAIKHOAN WHERE Username = '" + usr + "'");
            oldpss = DtTaiKhoan.Rows[0][0].ToString().Trim();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMatKhauCu.Text.CompareTo(oldpss) == 0)
                {
                    if (txtMatKhauMoi.Text.CompareTo(txtMatKhauCu.Text) == 0)
                    {
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!");
                    }
                    else
                    {
                        if (txtMatKhauMoi.Text.CompareTo(txtNhapLai.Text) == 0)
                        {
                            sql.ExecuteNonQuery("Update TAIKHOAN Set Password = '" + this.txtMatKhauMoi.Text.ToString() + "' WHERE Username = '" + usr + "'");
                            MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại");
                            this.Close();
                            Form frm = new frmLogin();
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nhập lại không trùng khớp!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Hệ thống đang gặp sự cố!");
            }
        }
    }
}

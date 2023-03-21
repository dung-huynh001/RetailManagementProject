using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT239_NienLuan_QLBH
{
    public partial class frmSignUp : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private String manv;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUsrname.Clear();
            txtRePass.Clear();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            String usrname = txtUsrname.Text.Trim();
            String pass = txtPass.Text.Trim();
            String repass = txtRePass.Text.Trim();
            int permission;
            if (cbPermission.SelectedIndex == 0)
            {
                permission = 1;
            }
            else permission = 2;

            DataTable dtTaiKhoan = dataProvider.FillDataTable("SELECT * FROM TAIKHOAN WHERE Username = '" + usrname + "'");
            if (dtTaiKhoan.Rows.Count != 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
                return;
            }
            else
            {
                if(pass.CompareTo(repass) == 0)
                {
                    String query = "INSERT INTO TAIKHOAN VALUES('" + usrname + "', '" + pass + "', " + permission + ", " + manv + ")";
                    dataProvider.ExecuteNonQuery(query);
                    MessageBox.Show("Cấp tài khoản thành công!");
                    txtPass.Clear();
                    txtUsrname.Clear();
                    txtRePass.Clear();
                    cbPermission.ResetText();
                }
                else
                {
                    MessageBox.Show("Nhập lại không trùng khớp!");
                }
            }
        }
        
        private void LoadData()
        {
            DataTable dtGetStaff = dataProvider.FillDataTable("SELECT MaNV, Ho, Ten FROM NHANVIEN WHERE MaNV NOT IN (SELECT MaNV FROM TAIKHOAN)");
            DataTable dtStaff = DesignUtils.getTableDisplayWrapper(dtGetStaff, " ", "HoTen", "Ho", "Ten");
            DesignUtils.putDataOnCombobox(dtStaff, cbNhanVien, "HoTen", "MaNV");
        }
        String permission = frmLogin.Permission.Trim();
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if(permission.CompareTo("2") == 0)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng!");
                this.Close();
                return;
            }
            LoadData();
        }

        private void cbNhanVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            manv = cbNhanVien.SelectedValue.ToString();
            MessageBox.Show(manv);
        }
    }
}

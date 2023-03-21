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
using System.IO;

namespace RetailManagement
{
    public partial class frmInfoPersonal : Form
    {
        DataProvider sql = new DataProvider();
        String manv;
        public frmInfoPersonal()
        {
            InitializeComponent();
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Gif);
            return m.ToArray();
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        void readOnlyTextBox(Boolean b)
        {
            txtDiaChi.ReadOnly =  b;
            txtHoTen.ReadOnly = b;
            txtNgaySinh.ReadOnly = b;
            txtSDT.ReadOnly = b;
        }

        void visibleButton(Boolean b)
        {
            this.btXacNhan.Visible = b;
            this.btHuy.Visible = b;
            this.btChonAnh.Visible = b;
            this.btSua.Visible = !b;
        }

        public void LoadData()
        {
            readOnlyTextBox(true);
            try
            {
                String usr = frmLogin.getUsername();
                DataTable dtInfo = sql.FillDataTable("SELECT MaNV FROM TAIKHOAN WHERE Username ='" + usr + "'");

                String manv = dtInfo.Rows[0][0].ToString();
                DataTable dtNhanVien = sql.FillDataTable("SELECT * FROM NHANVIEN WHERE MaNV ='" + manv + "'");

                String hoten = dtNhanVien.Rows[0][1].ToString() + " " + dtNhanVien.Rows[0][2].ToString();

                this.txtMaNV.Text = dtNhanVien.Rows[0][0].ToString();
                this.txtHoTen.Text = hoten;
                this.rbNu.Checked = Convert.ToBoolean(dtNhanVien.Rows[0][3]);
                this.rbNam.Checked = !rbNu.Checked;

                this.txtNgaySinh.Text = dtNhanVien.Rows[0][4].ToString();
                this.txtDiaChi.Text = dtNhanVien.Rows[0][5].ToString();
                this.txtSDT.Text = dtNhanVien.Rows[0][6].ToString();
                var anhDaiDien = dtNhanVien.Rows[0][7];
                picChonAnh.Visible = true;
                if (String.IsNullOrEmpty(anhDaiDien.ToString()))
                {
                    picChonAnh.Image = null;
                    return;
                }
                byte[] b = (byte[])anhDaiDien;
                picChonAnh.Image = ByteArrayToImage(b);
            }
            catch (Exception)
            {
                MessageBox.Show("Tải dữ liệu Nhân Viên thất bại!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            readOnlyTextBox(false);
            visibleButton(true);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            readOnlyTextBox(true);
            visibleButton(false);
        }
        
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            String ho, ten, diachi, ngaysinh, sdt;
            manv = txtMaNV.Text;
            DesignUtils.separationName(this.txtHoTen.Text.Trim(), out ho, out ten);
            ngaysinh = txtNgaySinh.Text;
            diachi = txtDiaChi.Text;
            sdt = txtSDT.Text;
            int lengthOfSDT = sdt.Trim().Length;
            if (lengthOfSDT > 10)
            {
                MessageBox.Show("Số điện thoại không vượt quá 10 ký tự!");
                return;
            }
            Boolean gioitinh = rbNu.Checked;
            byte[] b = null;
            if (picChonAnh.Image != null)
                b = ImageToByteArray(picChonAnh.Image);
            if (b != null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RE1ARQC\SQLEXPRESS;Initial Catalog=CT239_QuanLyBanHang;Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET Ho = N'" + ho + "', Ten = N'" + ten + "', GioiTinh = '" + gioitinh + "', NgaySinh = '" + ngaysinh + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "', AnhDaiDien = @anh WHERE MaNV = '" + manv + "'", con);
                cmd.Parameters.Add("@anh", b);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                sql.ExecuteNonQuery("UPDATE NHANVIEN SET Ho = N'" + ho + "', Ten = N'" + ten + "', GioiTinh = '" + gioitinh + "', NgaySinh = '" + ngaysinh + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "' WHERE MaNV = '" + manv + "'");
            }
            MessageBox.Show("Thêm thành công!");
            readOnlyTextBox(true);
            visibleButton(false);
        }

        private void frmInfoPersonal_Load(object sender, EventArgs e)
        {
            LoadData();
            visibleButton(false);
        }

        private void btChonAnh_Click(object sender, EventArgs e)
        {
            ofdChonAnh.ShowDialog();
            string file = ofdChonAnh.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            try
            {
                Image image = Image.FromFile(file);
                picChonAnh.Image = image;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy ảnh!");
            }
        }
    }
}

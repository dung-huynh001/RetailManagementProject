using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CT239_NienLuan_QLBH
{
    public partial class frmInfoStaff : Form
    {
        DataProvider dataProvider = new DataProvider();
        Boolean add = false;
        String permission = frmLogin.Permission.Trim();
        public frmInfoStaff()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            DataTable dtNhanVien = dataProvider.FillDataTable("SELECT * FROM NHANVIEN");
            DesignUtils.putDataOnDataGridView(dgvNhanVien, dtNhanVien);
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            int sizeofdgvNhanVien = dgvNhanVien.Rows.Count;
            
            for(int i = 0; i < sizeofdgvNhanVien - 1; i++)
            {
                ac.Add(dgvNhanVien.Rows[i].Cells[1].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells[2].Value.ToString());
            }
            txtTimKiem.AutoCompleteCustomSource = ac;
        }

        Boolean access(String message)
        {
            if(permission.CompareTo("2") == 0)
            {
                MessageBox.Show(message);
            }
            return true;
        }

        private void btAnh_Click(object sender, EventArgs e)
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


        private void frmInfoNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            readOnlyTextBox(true);
            btHuy.Visible = false;
            btXacNhan.Visible = false;
            btChonAnh.Visible = false;
        }

        private void resetGroupBoxInfo()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            chkGioiTinh.Checked = false;
            dtpNgaySinh.ResetText();
        }

        private void readOnlyTextBox (Boolean b)
        {
            txtHoTen.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtSDT.ReadOnly = b;
            chkGioiTinh.Checked = false;
            dtpNgaySinh.ResetText();
        }

        private void visibleButton(Boolean b)
        {
            btChonAnh.Visible = b;
            btHuy.Visible = b;
            btXacNhan.Visible = b;
        }



        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!access("Bạn không có quyền thêm nhân viên mới!"))
                return;
            readOnlyTextBox(false);
            resetGroupBoxInfo();
            add = true;
            btHuy.Visible = true;
            btXacNhan.Visible = true;
            btChonAnh.Visible = true;
        }


        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Gif);
            return m.ToArray();
        }

        void Reload()
        {
            readOnlyTextBox(true);
            resetGroupBoxInfo();
            txtTimKiem.Clear();
            picChonAnh.Image = null;
            LoadData();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            String ho, ten, diachi, ngaysinh, sdt;
            DesignUtils.separationName(this.txtHoTen.Text.Trim(), out ho, out ten);
            ngaysinh = dtpNgaySinh.Value.ToString();
            diachi = txtDiaChi.Text;
            sdt = txtSDT.Text;
            int lengthOfSDT = sdt.Trim().Length;
            if (lengthOfSDT > 10)
            {
                MessageBox.Show("Số điện thoại không vượt quá 10 ký tự!");
                return;
            }
            Boolean gioitinh = chkGioiTinh.Checked;
            byte[] b = null;
            if (picChonAnh.Image != null)
                b = ImageToByteArray(picChonAnh.Image);
            if (add)
            {
                if(b != null)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RE1ARQC\SQLEXPRESS;Initial Catalog=CT239_QuanLyBanHang;Integrated Security = True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN(Ho, Ten, GioiTinh, NgaySinh, DiaChi, SDT, AnhDaiDien) VALUES(N'" + ho + "', N'" + ten + "', '" + gioitinh + "', '" + ngaysinh + "', N'" + diachi + "', '" + sdt + "', @anh)", con);
                    cmd.Parameters.Add("@anh", b);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                    dataProvider.ExecuteNonQuery("INSERT INTO NHANVIEN(Ho, Ten, GioiTinh, NgaySinh, DiaChi, SDT) VALUES(N'" + ho + "', N'" + ten + "', '" + gioitinh + "', '" + ngaysinh + "', N'" + diachi + "', '" + sdt + "')");
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                String manv = DesignUtils.getRowFromDataGridView(dgvNhanVien).Cells[0].Value.ToString();
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
                    dataProvider.ExecuteNonQuery("UPDATE NHANVIEN SET Ho = N'" + ho + "', Ten = N'" + ten + "', GioiTinh = '" + gioitinh + "', NgaySinh = '" + ngaysinh + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "' WHERE MaNV = '" + manv + "'");
                }
                    
            }
            Reload();
            btHuy.Visible = false;
            btXacNhan.Visible = false;
            btChonAnh.Visible = false;
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!access("Bạn không có quyền sửa thông tin nhân viên!"))
            {
                return;
            }
            add = false;
            visibleButton(true);
            readOnlyTextBox(false);

            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvNhanVien);
            txtHoTen.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            chkGioiTinh.Checked = (Boolean)row.Cells[3].Value;
            dtpNgaySinh.Value = (DateTime)row.Cells[4].Value;
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        String IDStuff = null;
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sizeofdgvNhanVien = dgvNhanVien.Rows.Count;
            visibleButton(false);
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvNhanVien);
            if (row.Index >= sizeofdgvNhanVien - 1)
                return;
            txtHoTen.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            chkGioiTinh.Checked = (Boolean)row.Cells[3].Value;
            dtpNgaySinh.Value = (DateTime)row.Cells[4].Value;
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            IDStuff = row.Cells[0].Value.ToString().Trim();
            if (String.IsNullOrEmpty(row.Cells[7].Value.ToString()))
            {
                picChonAnh.Image = null;
                return;
            }
            
            DataTable dtAvatar = dataProvider.FillDataTable("SELECT AnhDaiDien FROM NHANVIEN WHERE MaNV = '" + IDStuff + "'");
            var avatar = dtAvatar.Rows[0][0]; 
            byte[] b = (byte[])avatar;
            picChonAnh.Image = ByteArrayToImage(b);
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!access("Bạn không có quyền xóa nhân viên!"))
            {
                return;
            }
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvNhanVien);
            String manv = row.Cells[0].Value.ToString().Trim();
            String hoten = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa nhân viên " + hoten + "?!", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                dataProvider.ExecuteNonQuery("DELETE TOP(1) FROM NHANVIEN WHERE MaNV = " + manv + "");
                LoadData();
            }
            Reload();
            btHuy.Visible = false;
            btXacNhan.Visible = false;
            btChonAnh.Visible = false;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            resetGroupBoxInfo();
            readOnlyTextBox(true);
            visibleButton(false);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String ho;
                if (!String.IsNullOrEmpty(txtTimKiem.Text))
                    ho = txtTimKiem.Text.Substring(0, txtTimKiem.Text.LastIndexOf(" ")).Trim();
                else ho = "";
                using (SalesManagementEntities db = new SalesManagementEntities())
                {
                    dgvNhanVien.DataSource = db.NHANVIENs.Where(p => p.Ho.Contains(ho)).ToList();
                }
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    DesignUtils.ToExcel(dgvNhanVien, save.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't export to Excel!");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

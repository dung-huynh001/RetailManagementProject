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
    public partial class frmProduct : Form
    {
        DataProvider dataProvider = new DataProvider();
        Boolean add;
        String permission = frmLogin.Permission.Trim();
        public frmProduct()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            DataTable dtSanPham = dataProvider.FillDataTable("SELECT * FROM SANPHAM ORDER BY MaLoaiSP");
            dtSanPham.Columns.RemoveAt(7);
            DesignUtils.putDataOnDataGridView(dgvSanPham,dtSanPham);
            DataTable dtLoaiSP = dataProvider.FillDataTable("SELECT * FROM LOAISANPHAM");
            DesignUtils.putDataOnCombobox(dtLoaiSP, cbLoaiSanPham, "TenLoaiSP", "MaLoaiSP");
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            int sizeofdgvSanPham = dgvSanPham.Rows.Count;
            for (int i = 0; i < sizeofdgvSanPham - 1; i++)
            {
                ac.Add(dgvSanPham.Rows[i].Cells[1].Value.ToString());
            }
            txtTimKiem.AutoCompleteCustomSource = ac;
             
        }

        private void visibleButton(Boolean b)
        {
            btHuy.Visible = b;
            btXacNhan.Visible = b;
        }

        private void resetTextBox()
        {
            txtTenSanPham.Clear();
            txtDonViTinh.Clear();
            txtGiaBan.Clear();
            txtGiaNhap.Clear();
            txtSoLuongNhap.Clear();
            txtTonKho.Clear();
        }

        void readOnlyTextBox(bool b)
        {
            txtTenSanPham.ReadOnly = b;
            txtDonViTinh.ReadOnly = b;
            txtGiaBan.ReadOnly = b;
            txtGiaNhap.ReadOnly = b;
            txtSoLuongNhap.ReadOnly = b;
            txtTonKho.ReadOnly = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            resetTextBox();
            readOnlyTextBox(true);
            visibleButton(false);
        }

        Boolean access(String message)
        {
            if (permission.CompareTo("2") == 0)
            {
                MessageBox.Show(message);
                return false;
            }
                
            return true;
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!access("Bạn không có quyền thêm sản phẩm!"))
            {
                return;
            }
            resetTextBox();
            visibleButton(true);
            readOnlyTextBox(false);
            add = true;
            String query = "SELECT * FROM LOAISANPHAM";
            DataTable dtLoai = dataProvider.FillDataTable(query);
            DesignUtils.putDataOnCombobox(dtLoai, cbLoaiSanPham, "TenLoaiSP", "MaLoaiSP");
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            resetTextBox();
            readOnlyTextBox(true);
            visibleButton(false);
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvSanPham);
            String masp = row.Cells[0].Value.ToString().Trim();
            String tensp = txtTenSanPham.Text.Trim();
            String donvitinh = txtDonViTinh.Text.Trim();
            String gianhap = txtGiaNhap.Text.Trim();
            String giaban = txtGiaBan.Text.Trim();
            String soluongnhap = txtSoLuongNhap.Text.Trim();
            String tonkho = txtTonKho.Text.Trim();
            String loaisp = cbLoaiSanPham.SelectedValue.ToString();
            visibleButton(true);
            if (add)
            {
                dataProvider.ExecuteNonQuery("INSERT INTO SANPHAM(TenSP, DonViTinh, DonGiaBan, DonGiaNhap, SoLuongNhap, SoLuongTon, MaLoaiSP) VALUES(N'" + tensp + "', N'" + donvitinh + "', '" + giaban + "', '" + gianhap + "', " + soluongnhap + ", " + soluongnhap + ", " + loaisp + ")");
                MessageBox.Show("Thêm sản phẩm thành công!");
                msDelete.Enabled = true;
                msUpdate.Enabled = true;
                msSearch.Enabled = true;
                msPrint.Enabled = true;
            }
            else
            {
                dataProvider.ExecuteNonQuery("UPDATE SANPHAM SET TenSP = N'" + tensp + "', DonViTinh = N'" + donvitinh + "', DonGiaNhap = " + gianhap + ", DonGiaBan = " + giaban + ", SoLuongNhap = " + soluongnhap + ", SoLuongTon = " + tonkho + ", MaLoaiSP = " + loaisp + " WHERE MaSP = " + masp + "");
                MessageBox.Show("Đã cập nhật lại thông tin sản phẩm!");
                msDelete.Enabled = true;
                msAdd.Enabled = true;
                msSearch.Enabled = true;
                msPrint.Enabled = true;
            }
            resetTextBox();
            readOnlyTextBox(true);
            visibleButton(false);
            LoadData();
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!access("Bạn không có quyền sửa thông tin sản phẩm!"))
            {
                return;
            }
            visibleButton(true);
            readOnlyTextBox(false);
            add = false;
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvSanPham);
            String masp = row.Cells[0].Value.ToString();
            DataTable dtLoai = dataProvider.FillDataTable("SELECT * FROM LOAISANPHAM");
            DesignUtils.putDataOnCombobox(dtLoai, cbLoaiSanPham, "TenLoaiSP", "MaLoaiSP");
            DataTable dtMaLoai = dataProvider.FillDataTable("SELECT MaLoaiSP FROM SANPHAM WHERE MaSP = " + masp + "");
            String maloai = dtMaLoai.Rows[0][0].ToString();
            cbLoaiSanPham.SelectedValue = maloai;
            txtTenSanPham.Text = row.Cells[1].Value.ToString();
            txtDonViTinh.Text = row.Cells[2].Value.ToString();
            txtGiaBan.Text = row.Cells[3].Value.ToString();
            txtGiaNhap.Text = row.Cells[4].Value.ToString();
            txtSoLuongNhap.Text = row.Cells[5].Value.ToString();
            txtTonKho.Text = row.Cells[6].Value.ToString();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvSanPham);
            String masp = row.Cells[0].Value.ToString();
            DataTable dtLoai = dataProvider.FillDataTable("SELECT * FROM LOAISANPHAM");
            DesignUtils.putDataOnCombobox(dtLoai, cbLoaiSanPham, "TenLoaiSP", "MaLoaiSP");
            DataTable dtMaLoai = dataProvider.FillDataTable("SELECT MaLoaiSP FROM SANPHAM WHERE MaSP = " + masp + "");
            String maloai = dtMaLoai.Rows[0][0].ToString();
            cbLoaiSanPham.SelectedValue = maloai;
            txtTenSanPham.Text = row.Cells[1].Value.ToString();
            txtDonViTinh.Text = row.Cells[2].Value.ToString();
            txtGiaBan.Text = row.Cells[3].Value.ToString();
            txtGiaNhap.Text = row.Cells[4].Value.ToString();
            txtSoLuongNhap.Text = row.Cells[5].Value.ToString();
            txtTonKho.Text = row.Cells[6].Value.ToString();
        }

        private void msSearch_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SalesManagementEntities db = new SalesManagementEntities())
                {
                    dgvSanPham.DataSource = db.SANPHAMs.Where(p => p.TenSP.Contains(txtTimKiem.Text)).ToList();
                }
            }
        }

        private void msPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    DesignUtils.ToExcel(dgvSanPham, save.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't export to Excel!");
            }
        }

        private void msDelete_Click(object sender, EventArgs e)
        {
            if (!access("Bạn không có quyền xóa sản phẩm!"))
            {
                return;
            }
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvSanPham);
            String masp = row.Cells[0].Value.ToString().Trim();
            String tensp = row.Cells[1].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa sản phẩm " + tensp + "?!", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                dataProvider.ExecuteNonQuery("DELETE TOP(1) FROM SANPHAM WHERE MaSP = " + masp + "");
                LoadData();
            }
            resetTextBox();
            visibleButton(false);
        }

        private void msLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

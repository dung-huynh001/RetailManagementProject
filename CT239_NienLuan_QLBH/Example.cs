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
    public partial class Example : Form
    {
        DataProvider dataProvider = new DataProvider();
        Boolean add;

        public Example()
        {
            InitializeComponent();
        }

        private void txtTimKiem_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                using(SalesManagementEntities db = new SalesManagementEntities())
                {
                    sANPHAMBindingSource.DataSource = db.SANPHAMs.Where(p => p.TenSP.Contains(txtTimKiem.Text)).ToList();
                }
            }
        }

        private void Example_Load(object sender, EventArgs e)
        {
            using (SalesManagementEntities db = new SalesManagementEntities())
            {
                sANPHAMBindingSource.DataSource = db.SANPHAMs.ToList();
                AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
                foreach (SANPHAM s in sANPHAMBindingSource.DataSource as List<SANPHAM>)
                {
                    ac.Add(s.TenSP);
                }
                txtTimKiem.AutoCompleteCustomSource = ac;
            }
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

        private void msAdd_Click(object sender, EventArgs e)
        {
            resetTextBox();
            visibleButton(true);
            add = true;
            String query = "SELECT * FROM LOAISANPHAM";
            DataTable dtLoai = dataProvider.FillDataTable(query);
            DesignUtils.putDataOnCombobox(dtLoai, cbLoaiSanPham, "TenLoaiSP", "MaLoaiSP");
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            resetTextBox();
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
                //MessageBox.Show("INSERT INTO SANPHAM(TenSP, DonViTinh, DonGiaBan, DonGiaNhap, SoLuongNhap, SoLuongTon, MaLoaiSP) VALUES(N'" + tensp + "', N'" + donvitinh + "', '" + giaban + "', '" + gianhap + "', " + soluongnhap + ", " + soluongnhap + ", " + loaisp + ")");
                dataProvider.ExecuteNonQuery("INSERT INTO SANPHAM(TenSP, DonViTinh, DonGiaBan, DonGiaNhap, SoLuongNhap, SoLuongTon, MaLoaiSP) VALUES(N'" + tensp + "', N'" + donvitinh + "', '" + giaban + "', '" + gianhap + "', " + soluongnhap + ", " + soluongnhap + ", " + loaisp + ")");
                MessageBox.Show("Thêm sản phẩm thành công!");
                msDelete.Enabled = true;
                msUpdate.Enabled = true;
                msSearch.Enabled = true;
                msPrint.Enabled = true;
            }
            else
            {
                //MessageBox.Show("UPDATE SANPHAM SET TenSP = N'" + tensp + "', DonViTinh = N, " + donvitinh + "', DonGiaBan = '" + giaban + "', DonGiaNhap = '" + gianhap + "', SoLuongNhap = " + soluongnhap + ", SoLuongTon = " + tonkho + "MaLoaiSP = " + loaisp + "");
                dataProvider.ExecuteNonQuery("UPDATE SANPHAM SET TenSP = N'" + tensp + "', DonViTinh = N," + donvitinh + "', DonGiaBan = '" + giaban + "', DonGiaNhap = '" + gianhap + "', SoLuongNhap = " + soluongnhap + ", SoLuongTon = " + tonkho + "MaLoaiSP = " + loaisp + "");
                MessageBox.Show("Đã cập nhật lại thông tin sản phẩm!");
                msDelete.Enabled = true;
                msAdd.Enabled = true;
                msSearch.Enabled = true;
                msPrint.Enabled = true;
            }
            resetTextBox();
            visibleButton(false);
        }

        private void msPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                if(save.ShowDialog() == DialogResult.OK)
                {
                    DesignUtils.ToExcel(dgvSanPham, save.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't export to Excel!");
            }
        }
    }
}

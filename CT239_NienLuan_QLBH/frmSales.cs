using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailManagement
{
    public partial class frmSales : Form
    {
        DataProvider dataProvider = new DataProvider();
        String permission = frmLogin.Permission.Trim();

        public frmSales()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            DataTable dtMenu = dataProvider.FillDataTable("SELECT MaSP, TenSP, DonGiaBan, MaLoaiSP FROM SANPHAM");
            DataTable dtLoaiSP = dataProvider.FillDataTable("SELECT * FROM LOAISANPHAM");
            DesignUtils.putDataOnDataGridView(dgvMenu, dtMenu);
            DesignUtils.putDataOnCombobox(dtLoaiSP, this.cbLoaiSP, "TenLoaiSP", "MaLoaiSP");
        }

        public void callfrmLogin()
        {
            Form frm = new frmLogin();
            frm.ShowDialog();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            chkHoiVien.Checked = false;
            cbHoiVien.Visible = false;
            callfrmLogin();
            LoadData();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInfoStaff();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInfoCustomer();
            frm.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInfoPersonal();
            frm.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvMenu);
                String maloaisp = row.Cells[3].Value.ToString();
                putTenSP(maloaisp);
                String tensp = row.Cells[0].Value.ToString();
                this.cbLoaiSP.SelectedValue = maloaisp;
                this.cbTenSP.SelectedValue = tensp;
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn dòng bạn ơi!");
            }
        }

        private void putTenSP(String condition)
        {
            DataTable dtSanPham = dataProvider.FillDataTable("SELECT MaSP, TenSP FROM SANPHAM WHERE MaLoaiSP = '" + condition + "'");
            DesignUtils.putDataOnCombobox(dtSanPham, this.cbTenSP, "TenSP", "MaSP");
        }

        private void cbLoaiSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtSanPham = dataProvider.FillDataTable("SELECT MaSP, TenSP FROM SANPHAM WHERE MaLoaiSP = '" + this.cbLoaiSP.SelectedValue.ToString() + "'");
            DesignUtils.putDataOnCombobox(dtSanPham, this.cbTenSP, "TenSP", "MaSP");
        }

        private static Int64 TongTien = 0;
        private void btTaoHoaDon_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            ListViewItem item = new ListViewItem();
            if (this.nudSoLuong.Value != 0)
            {
                String masp = DesignUtils.getIDProductFromCombobox(this.cbTenSP);
                DataTable dtHoaDon = dataProvider.FillDataTable("SELECT TenSP, DonGiaBan FROM SANPHAM WHERE MaSP = '" + masp + "'");
                String tensp = dtHoaDon.Rows[0][0].ToString();
                String dongia = dtHoaDon.Rows[0][1].ToString();
                String soluong = this.nudSoLuong.Value.ToString();
                foreach(ListViewItem i in lVHoaDon.Items)
                {
                    if(tensp.CompareTo(i.SubItems[0].Text) == 0)
                    {
                        check = true;
                        item = i;
                        break;
                    }
                }
                if (check)
                {
                    try
                    {
                        Int64 sl = Int64.Parse(item.SubItems[2].Text);
                        sl += Convert.ToInt64(soluong);
                        item.SubItems[2].Text = sl.ToString();
                        item.SubItems[3].Text = (Convert.ToInt64(dongia) * Convert.ToInt64(item.SubItems[2].Text)).ToString();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                else
                {
                    DesignUtils.createListViewItemForOrder(lVHoaDon, tensp, dongia, soluong);
                }

                TongTien += Convert.ToInt64(dongia) * Convert.ToInt64(soluong);
                txtTongTien.Text = TongTien.ToString();

                if (chkHoiVien.Checked)
                {
                    txtThanhToan.Text = (Convert.ToInt64(txtTongTien.Text) * 0.95).ToString();
                }
                else
                {
                    txtGiamGia.Text = "0%";
                    txtThanhToan.Text = txtTongTien.Text;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nudSoLuong.Value = 0;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn xóa các sản phẩm đã chọn?");
            Boolean valid = dialog == DialogResult.OK;

            int i = lVHoaDon.CheckedItems.Count;
            if (valid && i > 0)
            {
                while (i > 0)
                {
                    TongTien  -= Convert.ToInt64(lVHoaDon.CheckedItems[i - 1].SubItems[3].Text);
                    lVHoaDon.Items.Remove(lVHoaDon.CheckedItems[i - 1]);
                    i--;
                }
            }
            txtTongTien.Text = TongTien.ToString();
            if (chkHoiVien.Checked)
                txtThanhToan.Text = (TongTien * 0.95).ToString();
            else txtThanhToan.Text = txtTongTien.Text;
        }

        private void putIDTypeProduct(String tensp)
        {
            try
            {
                DataTable dtLoaiSP = dataProvider.FillDataTable("SELECT MaLoaiSP FROM SANPHAM WHERE TenSP = N'" + tensp + "'");
                cbLoaiSP.SelectedValue = dtLoaiSP.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy tên sp!");
            }
        }

        private void lVHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVHoaDon.SelectedItems.Count > 0)
            {
                DataTable dtSanPham = dataProvider.FillDataTable("SELECT MaSP FROM SANPHAM WHERE TenSP = N'" + this.lVHoaDon.SelectedItems[0].Text.Trim() + "'");

                cbTenSP.SelectedValue = dtSanPham.Rows[0][0].ToString();
                putIDTypeProduct(this.lVHoaDon.SelectedItems[0].SubItems[0].Text.Trim());
            }
            else { }
        }

        private void lVHoaDon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lVHoaDon.SelectedItems.Count > 0)
            {
                DataTable dtSanPham = dataProvider.FillDataTable("SELECT MaSP FROM SANPHAM WHERE TenSP = N'" + this.lVHoaDon.SelectedItems[0].Text.Trim() + "'");
                cbTenSP.SelectedValue = dtSanPham.Rows[0][0].ToString();
                putIDTypeProduct(this.lVHoaDon.SelectedItems[0].SubItems[0].Text.Trim());
            }
            else { }
        }

        private String makh;

        private void chkHoiVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoiVien.Checked)
            {
                cbHoiVien.Visible = true;
                txtGiamGia.Text = "5%";
                if (!String.IsNullOrEmpty(txtTongTien.Text))
                    txtThanhToan.Text = (Convert.ToInt32(txtTongTien.Text) * 0.95).ToString();
                else txtThanhToan.Text = "";
                DataTable dtTmp = dataProvider.FillDataTable("SELECT MaKH, Ho, Ten FROM KHACHHANG");
                DataTable dtHoiVien = DesignUtils.getTableDisplayWrapper(dtTmp, " ", "HoTen", "Ho", "Ten");
                DesignUtils.putDataOnCombobox(dtHoiVien, this.cbHoiVien, "HoTen", "MaKH");
                MessageBox.Show("Hội viên được giảm 5% tổng trị giá hóa đơn.");
            }
            else
            {
                cbHoiVien.Visible = false;
                txtGiamGia.Text = "0%";
                txtThanhToan.Text = txtTongTien.Text;
            }
        }
        
        private void btLuu_Click(object sender, EventArgs e)
        {
            DateTime ngaylap;
            String usrname = frmLogin.Usr;
            DataTable dtNhanVien = dataProvider.FillDataTable("SELECT MaNV FROM TAIKHOAN WHERE Username = '" + usrname + "'");
            String manv = dtNhanVien.Rows[0][0].ToString().Trim();
            int sizeOfListView = lVHoaDon.Items.Count;
            if (sizeOfListView > 0)
            {
                DataTable dtHoaDon = new DataTable();
                ngaylap = DateTime.Now;
                if (!chkHoiVien.Checked)
                {
                    dataProvider.ExecuteNonQuery("INSERT INTO HOADON(MaKH, MaNV, NgayLap, ThanhTien, TriGiaHD) VALUES(NULL, " + manv + ", '" + ngaylap.ToString() + "', '" + txtTongTien.Text + "', '" + txtThanhToan.Text + "')");
                }
                else
                {
                    dataProvider.ExecuteNonQuery("INSERT INTO HOADON(MaKH, MaNV, NgayLap, ThanhTien, TriGiaHD) VALUES(" + makh + ", " + manv + ", '" + ngaylap.ToString() + "', '" + txtTongTien.Text + "', '" + txtThanhToan.Text + "')");
                }
                dtHoaDon = dataProvider.FillDataTable("SELECT TOP 1 MaHD FROM HOADON WHERE NgayLap = '" + ngaylap.ToString() + "' ORDER BY MaHD DESC");
                String mahd = dtHoaDon.Rows[0][0].ToString().Trim();
                
                for(int i = 0; i < sizeOfListView; i++)
                { 
                    String sl = lVHoaDon.Items[i].SubItems[2].Text;
                    String tensp = lVHoaDon.Items[i].SubItems[0].Text;
                    DataTable dtSanPham = dataProvider.FillDataTable("SELECT MaSP FROM SANPHAM WHERE TenSP = N'" + tensp.Trim() + "'");
                    String masp = dtSanPham.Rows[0][0].ToString();
                    if (!String.IsNullOrEmpty(masp) && !String.IsNullOrEmpty(mahd))
                    {
                        dataProvider.ExecuteNonQuery("INSERT INTO CHITIETHOADON VALUES (" + mahd + ", " + masp + ", " + sl + ")");
                    }
                }
            }
            txtGiamGia.Text = "0%";
            txtThanhToan.Clear();
            txtTongTien.Clear();
            chkHoiVien.Checked = false;
            cbHoiVien.Visible = false;
            lVHoaDon.Items.Clear();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTotalRevenue();
            frm.ShowDialog();
        }

        private void cấpTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmIntroduction();
            frm.ShowDialog();
        }

        private void cbHoiVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            makh = cbHoiVien.SelectedValue.ToString().Trim();
        }
    }
}

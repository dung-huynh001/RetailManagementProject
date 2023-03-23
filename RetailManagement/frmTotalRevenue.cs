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
    public partial class frmTotalRevenue : Form
    {
        DataProvider dataProvider = new DataProvider();
        private static String mahd;
        private int tongthu;

        public String maHD
        {
            get => mahd;
            set
            {
                mahd = value;
            }
        }
        public frmTotalRevenue()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            cbThang.Visible = false;
            rbAll.Visible = rbThang.Visible = false;
            try
            {
                DataTable dtTemp1 = dataProvider.FillDataTable("SELECT hd.MaHD, nv.Ho, nv.Ten, hd.NgayLap, hd.TriGiaHD, kh.Ho, kh.Ten FROM HOADON hd LEFT JOIN KHACHHANG kh ON hd.MaKH = kh.MaKH, NHANVIEN nv WHERE hd.MaNV = nv.MaNV");
                DataTable dtTemp2 = DesignUtils.getTableDisplayWrapper(dtTemp1, " ", "KhachHang", "Ho1", "Ten1");
                DataTable dtHoaDon = DesignUtils.getTableDisplayWrapper(dtTemp2, " ", "NhanVien", "Ho", "Ten");
                dtHoaDon.Columns.RemoveAt(8);
                dtHoaDon.Columns.RemoveAt(7);
                dtHoaDon.Columns.RemoveAt(4);
                dtHoaDon.Columns.RemoveAt(3);
                DesignUtils.putDataOnDataGridView(dgvHoaDon, dtHoaDon);
                int sl = dgvHoaDon.Rows.Count;
                for (int i = 0; i < sl - 1; i++)
                {
                    tongthu += Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                }
                this.txtTongThu.Text = tongthu.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("!");
            }
        }

        private void frmTotalRevenue_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                cbThang.Visible = false;
                try
                {
                    String year = getYear();
                    DataTable dtTemp1 = dataProvider.FillDataTable("SELECT hd.MaHD, nv.Ho, nv.Ten, hd.NgayLap, hd.TriGiaHD, kh.Ho, kh.Ten FROM HOADON hd LEFT JOIN KHACHHANG kh ON hd.MaKH = kh.MaKH, NHANVIEN nv WHERE hd.MaNV = nv.MaNV AND hd.NgayLap like '" + year + "%'");
                    if (dtTemp1.Rows.Count > 0)
                    {
                        DataTable dtTemp2 = DesignUtils.getTableDisplayWrapper(dtTemp1, " ", "KhachHang", "Ho1", "Ten1");
                        DataTable dtHoaDon = DesignUtils.getTableDisplayWrapper(dtTemp2, " ", "NhanVien", "Ho", "Ten");
                        dtHoaDon.Columns.RemoveAt(8);
                        dtHoaDon.Columns.RemoveAt(7);
                        dtHoaDon.Columns.RemoveAt(4);
                        dtHoaDon.Columns.RemoveAt(3);
                        DesignUtils.putDataOnDataGridView(dgvHoaDon, dtHoaDon);
                        tongthu = 0;
                        int sl = dgvHoaDon.Rows.Count;
                        for (int i = 0; i < sl - 1; i++)
                        {
                            tongthu += Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                        }
                        this.txtTongThu.Text = tongthu.ToString();
                    }
                    else MessageBox.Show("Năm " + year + " không có hóa đơn được lập!");
                }
                catch (Exception)
                {
                    MessageBox.Show("!");
                }
            }
        }

        private void rbThang_CheckedChanged(object sender, EventArgs e)
        {
            cbThang.Visible = true;
        }

        private int getMonth()
        {
            int month;
            string m = this.cbThang.SelectedItem.ToString().Trim();
            switch (m)
            {
                case "Tháng 1":
                    month = 1;
                    break;
                case "Tháng 2":
                    month = 2;
                    break;
                case "Tháng 3":
                    month = 3;
                    break;
                case "Tháng 4":
                    month = 4;
                    break;
                case "Tháng 5":
                    month = 5;
                    break;
                case "Tháng 6":
                    month = 6;
                    break;
                case "Tháng 7":
                    month = 7;
                    break;
                case "Tháng 8":
                    month = 8;
                    break;
                case "Tháng 9":
                    month = 9;
                    break;
                case "Tháng 10":
                    month = 10;
                    break;
                case "Tháng 11":
                    month = 11;
                    break;
                default:
                    month = 12;
                    break;
            }
            return month;
        }

        private String getYear()
        {
            string year = this.cbNam.SelectedItem.ToString().Trim(); 
            return year;
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbThang.Checked)
            {
                cbThang.Visible = true;
                try
                {
                    String month = getMonth().ToString();
                    String year = getYear();
                    DataTable dtTemp1 = dataProvider.FillDataTable("SELECT hd.MaHD, nv.Ho, nv.Ten, hd.NgayLap, hd.TriGiaHD, kh.Ho, kh.Ten FROM HOADON hd LEFT JOIN KHACHHANG kh ON hd.MaKH = kh.MaKH, NHANVIEN nv WHERE hd.MaNV = nv.MaNV AND hd.NgayLap like '" + year + "-0" + month + "%'");
                    if (dtTemp1.Rows.Count > 0)
                    {
                        DataTable dtTemp2 = DesignUtils.getTableDisplayWrapper(dtTemp1, " ", "KhachHang", "Ho1", "Ten1");
                        DataTable dtHoaDon = DesignUtils.getTableDisplayWrapper(dtTemp2, " ", "NhanVien", "Ho", "Ten");
                        dtHoaDon.Columns.RemoveAt(8);
                        dtHoaDon.Columns.RemoveAt(7);
                        dtHoaDon.Columns.RemoveAt(4);
                        dtHoaDon.Columns.RemoveAt(3);
                        DesignUtils.putDataOnDataGridView(dgvHoaDon, dtHoaDon);
                        tongthu = 0;
                        int sl = dgvHoaDon.Rows.Count;
                        for (int i = 0; i < sl - 1; i++)
                        {
                            tongthu += Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                        }
                        this.txtTongThu.Text = tongthu.ToString();
                    }
                    else MessageBox.Show("Tháng " + month + " không có hóa đơn được lập!");
                }
                catch (Exception)
                {
                    MessageBox.Show("!");
                }
            }
            else
            {
                cbThang.Visible = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            String mahd = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            DataTable dtCTHD = dataProvider.FillDataTable("SELECT sp.TenSP, cthd.SoLuong, sp.DonGiaBan FROM CHITIETHOADON cthd, HOADON hd, SANPHAM sp WHERE cthd.MaHD = hd.MaHD AND cthd.MaSP = sp.MaSP AND hd.MaHD = '" + mahd + "'");
            DesignUtils.putDataOnDataGridView(dgvCTHD, dtCTHD);
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbAll.Visible = true;
            rbThang.Visible = true;
            try
            {
                String year = getYear();
                DataTable dtTemp1 = dataProvider.FillDataTable("SELECT hd.MaHD, nv.Ho, nv.Ten, hd.NgayLap, hd.TriGiaHD, kh.Ho, kh.Ten FROM HOADON hd LEFT JOIN KHACHHANG kh ON hd.MaKH = kh.MaKH, NHANVIEN nv WHERE hd.MaNV = nv.MaNV AND hd.NgayLap like '" + year + "%'");
                DataTable dtTemp2 = DesignUtils.getTableDisplayWrapper(dtTemp1, " ", "KhachHang", "Ho1", "Ten1");
                DataTable dtHoaDon = DesignUtils.getTableDisplayWrapper(dtTemp2, " ", "NhanVien", "Ho", "Ten");
                dtHoaDon.Columns.RemoveAt(8);
                dtHoaDon.Columns.RemoveAt(7);
                dtHoaDon.Columns.RemoveAt(4);
                dtHoaDon.Columns.RemoveAt(3);
                DesignUtils.putDataOnDataGridView(dgvHoaDon, dtHoaDon);
                tongthu = 0;
                int sl = dgvHoaDon.Rows.Count;
                for (int i = 0; i < sl - 1; i++)
                {
                    tongthu += Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                }
                this.txtTongThu.Text = tongthu.ToString();
                if (dtTemp1.Rows.Count == 0)
                    MessageBox.Show("Năm " + year + " không có hóa đơn được lập!");
            }
            catch (Exception)
            {
                MessageBox.Show("!");
            }
        }

    }
}

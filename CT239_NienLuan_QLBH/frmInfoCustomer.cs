using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CT239_NienLuan_QLBH
{
    public partial class frmInfoCustomer : Form
    {
        DataProvider dataProvider = new DataProvider();
        Boolean add;
        String makh = null;
        String permission = frmLogin.Permission.Trim();
        public frmInfoCustomer()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            visibleButton(false);
            DataTable KhachHang = dataProvider.FillDataTable("SELECT MaKH, Ho, Ten, DiaChi, SDT FROM KHACHHANG");
            DesignUtils.putDataOnDataGridView(dgvKhachHang, KhachHang);
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            int sizeofdgvKhachHang = dgvKhachHang.Rows.Count;
            for(int i = 0; i < sizeofdgvKhachHang - 1; i++)
            {
                ac.Add(dgvKhachHang.Rows[i].Cells[1].Value.ToString() + " " + dgvKhachHang.Rows[i].Cells[2].Value.ToString());
            }
            txtTimKiem.AutoCompleteCustomSource = ac;
        }

        Boolean access(String message)
        {
            if(permission.CompareTo("2") == 0)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        void clearTextbox()
        {
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();
        }

        void readOnlyTextbox(Boolean b)
        {
            txtDiaChi.ReadOnly = b;
            txtHoTen.ReadOnly = b;
            txtSDT.ReadOnly = b;
        }

        void Reload()
        {
            clearTextbox();
            readOnlyTextbox(true);
            LoadData();
        }

        private void frmInfoCustomer_Load(object sender, EventArgs e)
        {
            readOnlyTextbox(true);
            LoadData();
        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String ho;
                if (!String.IsNullOrEmpty(txtTimKiem.Text))
                    ho = txtTimKiem.Text.Substring(0, txtTimKiem.Text.LastIndexOf(" ")).Trim();
                else ho = "";
                using (SalesManagementEntities db = new SalesManagementEntities())
                {
                    dgvKhachHang.DataSource = db.KHACHHANGs.Where(p => p.Ho.Contains(ho)).ToList();
                }
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    DesignUtils.ToExcel(dgvKhachHang, save.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't export to Excel!");
            }
        }

        void visibleButton(Boolean b)
        {
            btHuy.Visible = b;
            btXacNhan.Visible = b;
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            String ho, ten, diachi, sdt;
            DesignUtils.separationName(txtHoTen.Text, out ho, out ten);
            diachi = txtDiaChi.Text;
            sdt = txtSDT.Text;
            int lengthOfSDT = sdt.Trim().Length;
            if (lengthOfSDT > 10)
            {
                MessageBox.Show("Số điện thoại không vượt quá 10 ký tự!");
                return;
            }
            if (add)
            {
                try
                {
                    dataProvider.ExecuteNonQuery("INSERT INTO KHACHHANG(Ho, Ten, DiaChi, SDT) VALUES(N'" + ho + "', N'" + ten + "', N'" + diachi + "', '" + sdt + "')");
                }
                catch (Exception)
                {
                    MessageBox.Show("Quá trình thêm khách quen bị lỗi!");
                    return;
                }
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                try
                {
                    dataProvider.ExecuteNonQuery("UPDATE KHACHHANG SET HO = N'" + ho + "', Ten = N'" + ten + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "' WHERE MaKH = '" + makh + "'" );
                }
                catch (Exception)
                {
                    MessageBox.Show("Quá trình thay đổi thông tin bị lỗi");
                    return;
                }
                MessageBox.Show("Thay đổi thông tin thành công!");
            }
            Reload();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readOnlyTextbox(false);
            add = true;
            clearTextbox();
            visibleButton(true);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            visibleButton(false);
            Reload();
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readOnlyTextbox(false);
            add = false;
            visibleButton(true);
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvKhachHang);
            makh = row.Cells[0].Value.ToString().Trim();
            txtHoTen.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvKhachHang);
            int sizeOfDgvKhachHang = dgvKhachHang.Rows.Count;
            if (row.Index >= sizeOfDgvKhachHang - 1)
                return;
            makh = row.Cells[0].Value.ToString().Trim();
            txtHoTen.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DesignUtils.getRowFromDataGridView(dgvKhachHang);
            int sizeOfDgvKhachHang = dgvKhachHang.Rows.Count;
            if (row.Index >= sizeOfDgvKhachHang - 1)
                return;
            makh = row.Cells[0].Value.ToString();
            String hoten = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn xóa nhân viên " + hoten + "?!", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                dataProvider.ExecuteNonQuery("DELETE TOP(1) FROM KHACHHANG WHERE MaKH = '" + makh + "'");
                LoadData();
            }
            Reload();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

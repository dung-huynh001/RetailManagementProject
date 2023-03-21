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
    public partial class frmLogin : Form
    {
        private static String usr;
        private static String permission = "";
        private String pss;
        private DataProvider sql;

        public static String Usr{
            get => usr;
            set => usr = value;
        }

        public static String Permission
        {
            get => permission;
            set => permission = value;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        public Boolean Login()
        {
            Boolean check = false;
            try
            {
                sql = new DataProvider();
                String query = "SELECT * FROM TAIKHOAN WHERE Username = '" + usr + "' AND Password = '" + pss + "'";
                DataTable dtResult = sql.FillDataTable(query);
                Permission = dtResult.Rows[0][2].ToString();
                check = dtResult.Rows.Count == 1;
            }
            catch (Exception)
            {
                MessageBox.Show("!");
            }
            return check;
        }

        public static String getUsername()
        {
            return usr;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            usr = this.txtUsername.Text;
            pss = this.txtPassword.Text;
            if (Login())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập chưa chính xác!");
                this.txtUsername.Focus();
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
                ClosedByXButtonOrAltF4 = true;
            base.WndProc(ref msg);
        }

        protected override void OnShown(EventArgs e)
        {
            ClosedByXButtonOrAltF4 = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ClosedByXButtonOrAltF4)
                Application.Exit();
        }
    }
}

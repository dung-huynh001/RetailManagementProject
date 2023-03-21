using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT239_NienLuan_QLBH
{
    class DataProvider
    {
        private static String strConnection  = @"Data Source=DESKTOP-RE1ARQC\SQLEXPRESS;Initial Catalog=CT239_QuanLyBanHang;Integrated Security = True";
        private static SqlConnection conn;
        private static SqlCommand cmd;
        public DataProvider()
        {
            conn = new SqlConnection(strConnection);
        }
        // Điền dữ liệu vào dtTable
        public DataTable FillDataTable(String query)
        {
            DataTable dtTable = new DataTable();
            try
            {
                SqlDataAdapter daTable = new SqlDataAdapter(query, conn);
                dtTable.Clear();
                daTable.Fill(dtTable);
            }
            catch (SqlException)
            {
                MessageBox.Show("Tải dữ liệu thất bại!!");
            }
            return dtTable;
        }

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void ExecuteNonQuery(String command)
        {
            conn.Open();
            try
            {
                cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thực hiện ExecuteNonQuery!");
            }
            conn.Close();
        }

        public String ExecuteScalar(String command)
        {
            String result = null;
            conn.Open();
            try
            {
                cmd = new SqlCommand(command, conn);
                result = (String)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thực hiện ExecuteScalar!");
            }
            return result;
        }
    }
}

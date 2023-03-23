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

namespace RetailManagement
{
    class DesignUtils
    {
        public static void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Niên Luận Cơ Sở Ngành KTPM";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {

                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        worksheet.Cells[i + 2, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    }
                }
                excel.Columns.AutoFit();
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        public static void putDataOnCombobox(DataTable dtTable, ComboBox cb, String displayMember, String valueMember)
        {
            try
            {
                cb.DataSource = dtTable;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! Can't put data on combobox.");
            }
        }

        public static void separationName(String fullname, out String lastname, out String name)
        {
            lastname = fullname.Substring(0, fullname.LastIndexOf(" "));
            name = fullname.Substring(fullname.LastIndexOf(" ") + 1);
        }

        public static void putDataOnCombobox(DataView dvTable, ComboBox cb, String displayMember, String valueMember)
        {
            try
            {
                cb.DataSource = dvTable;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! Can't put data on combobox.");
            }
        }

        public static void putDataOnDataGridView(DataGridView dgv, DataTable dtTable)
        {
            try
            {
                dgv.DataSource = dtTable;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! Can't put data on DataGridView.");
            }
        }

        public static void putDataOnCombobox_DataGidView(DataGridView dataGridView, DataTable dtTable, String column, String displayMember, String valueMember)
        {
            try
            {
                (dataGridView.Columns[column] as DataGridViewComboBoxColumn).DataSource = dtTable;
                (dataGridView.Columns[column] as DataGridViewComboBoxColumn).DisplayMember = displayMember;
                (dataGridView.Columns[column] as DataGridViewComboBoxColumn).ValueMember = valueMember;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! Can't put data from DataGridView to Combobox.");
            }
            
        }

        public static void createListViewItemForOrder(ListView list, String SanPham, String DonGia, String SoLuong)
        {

            try
            {
                String ThanhTien = (Int64.Parse(DonGia) * Int64.Parse(SoLuong)).ToString();
                ListViewItem item = new ListViewItem();
                item.Text = SanPham;
                list.Items.Add(item);

                ListViewItem.ListViewSubItem dongia = new ListViewItem.ListViewSubItem(item, DonGia);
                item.SubItems.Add(dongia);

                ListViewItem.ListViewSubItem soluong = new ListViewItem.ListViewSubItem(item, SoLuong);
                item.SubItems.Add(soluong);

                ListViewItem.ListViewSubItem thanhtien = new ListViewItem.ListViewSubItem(item, ThanhTien);
                item.SubItems.Add(thanhtien);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể tải dữ liệu lên " + list);
            }
        }

        public static DataGridViewRow getRowFromDataGridView(DataGridView dataGridView)
        {
            DataGridViewRow row = new DataGridViewRow();
            int r = dataGridView.CurrentCell.RowIndex;
            row = dataGridView.Rows[r];
            return row;
        }

        public static String getIDProductFromCombobox(ComboBox cb)
        {
            String product = null;
            product = cb.SelectedValue.ToString();
            return product;
        }

        //public Boolean 

        public static DataTable getTableDisplayWrapper(DataTable core, String seperateString, string diplayMember, params string[] args)
        {
            DataTable wrapper = new DataTable();
            // Make new display column 
            wrapper.Columns.Add(new DataColumn(diplayMember, Type.GetType("System.String")));
            // Copy columns from original table
            foreach (DataColumn columnCore in core.Columns)
            {
                wrapper.Columns.Add(new DataColumn(columnCore.ColumnName, columnCore.DataType));
            }
            // Copy rows from original table with a new display cell for each row
            foreach (DataRow rowCore in core.Rows)
            {
                DataRow rowWrapper = wrapper.NewRow();
                string displayCell = "";
                // Create display cell
                foreach (string arg in args)
                {
                    try
                    {
                        displayCell += rowCore[arg] + seperateString;
                    }
                    catch (ArgumentException)
                    {
                        throw new Exception("Invalid data field");
                    }
                }
                displayCell = displayCell.Remove(displayCell.Length - seperateString.Length);
                rowWrapper[diplayMember] = displayCell;
                // Copy cells from original row
                foreach (DataColumn columnCore in core.Columns)
                {
                    if (columnCore.ColumnName == "Hinh") continue;
                    // Avoid to make a shallow copy
                    rowWrapper[columnCore.ColumnName] = rowCore[columnCore].ToString();
                }
                wrapper.Rows.Add(rowWrapper);
            }
            return wrapper;
        }
    }
}

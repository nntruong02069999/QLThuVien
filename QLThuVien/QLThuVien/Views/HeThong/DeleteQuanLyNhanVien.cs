using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Models;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace QLThuVien.Views.HeThong
{
    public partial class DeleteQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            string query = "Select IDNhanVien from NhanVien";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaNhanVien.Items.Add(row[0]);
            }
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhanVien = cbMaNhanVien.Text;
            string query = "Select TenNhanVien from NhanVien where IDNhanVien =N'" + maNhanVien + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            string tenNhanVien = dataTable.Rows[0].Field<String>("TenNhanVien");
            tbTenNhanVien.Text = tenNhanVien;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = cbMaNhanVien.Text;
            if (string.IsNullOrWhiteSpace(maNhanVien))
            {
                XtraMessageBox.Show("Vui lòng chọn thông tin cần xóa .", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult log = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (log == DialogResult.Yes)
                {
                    try
                    {
                        string query = "Delete from NhanVien where IDNhanVien = N'" + maNhanVien + "'";
                        SqlCommand sqlCommand = new SqlCommand(query);
                        db.executeQuery(sqlCommand);
                        QuanLyNhanVien.utcQuanLyNhanVien.QuanLyNhanVien_Loading();
                        this.Hide();
                    }
                    catch (Exception err)
                    {
                        XtraMessageBox.Show("Không thể xóa. Nhân viên bạn muốn xóa đang tồn tại đâu đó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
    }
}
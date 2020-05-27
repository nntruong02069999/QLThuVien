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
    public partial class ChangeItemQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public ChangeItemQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void ChangeItemQuanLyNhanVien_Load(object sender, EventArgs e)
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maNhanVien = cbMaNhanVien.Text;
            string tenNHanVien = tbTenNhanVien.Text;
            if (string.IsNullOrWhiteSpace(maNhanVien))
            {
                XtraMessageBox.Show("Vui lòng chọn nhà xuất bản muốn thay đổi .", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Bạn chắc chắn muốn thay đổi ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string query = "Update NhanVien Set TenNhanVien = N'" + tenNHanVien + "' where IDNhanVien =N'" + maNhanVien + "'";
                    SqlCommand command = new SqlCommand(query);
                    db.executeQuery(command);
                    QuanLyNhanVien.utcQuanLyNhanVien.QuanLyNhanVien_Loading();
                    this.Hide();
                }
            }
        }
    }
}
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
            string load = "select IDNhanVien from NhanVien";
            DataTable dataTable = new DataTable();

            db.readDatathroughAdapter(load, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaNhanVien.Items.Add(row[0]);
            }
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbMaNhanVien.Text;
            string check = "select TenNhanVien from NhanVien where IDNhanVien = N'" + @maNV + "'";

            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(check, dataTable);

            string tenNV = dataTable.Rows[0].Field<String>("TenNhanVien");
            tbTenNhanVien.Text = tenNV;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maNV = cbMaNhanVien.Text;
            string tenNV = tbTenNhanVien.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên muốn chỉnh sửa thông tin.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Xác nhận chỉnh sửa thông tin?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand update = new SqlCommand("update NhanVien set TenNhanVien = N'" + @tenNV + "' where IDNhanVien = N'" + @maNV + "'");
                    db.executeQuery(update);

                    QuanLyNhanVien.utcQuanLyNhanVien.QuanLyNhanVien_Loading();
                    this.Hide();
                }
            }
        }
    }
}
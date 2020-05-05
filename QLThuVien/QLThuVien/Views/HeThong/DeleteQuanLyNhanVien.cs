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
    public partial class DeleteQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            string check = "select IDNhanVien from NhanVien";
            DataTable dataTable = new DataTable();

            db.readDatathroughAdapter(check, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaNhanVien.Items.Add(row[0]);
            }
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbMaNhanVien.Text;
            string check = "select TenNhanVien from NhanVien where IDNhanVien =N'" + @maNV + "'";
            DataTable dataTable = new DataTable();

            db.readDatathroughAdapter(check, dataTable);

            string tenNV = dataTable.Rows[0].Field<String>("TenNhanVien");
            tbTenNhanVien.Text = tenNV;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maNV = cbMaNhanVien.Text;

            if (string.IsNullOrWhiteSpace(maNV))
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult log = XtraMessageBox.Show("Xác nhận xóa nhân viên?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (log == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand delete = new SqlCommand("delete from NhanVien where IDNhanVien = N'" + @maNV + "'");

                        db.executeQuery(delete);
                        QuanLyNhanVien.utcQuanLyNhanVien.QuanLyNhanVien_Loading();
                        this.Hide();
                    }
                    catch (Exception err)
                    {
                        XtraMessageBox.Show("Vui lòng kiểm tra lại thông tin nhân viên.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
    }
}
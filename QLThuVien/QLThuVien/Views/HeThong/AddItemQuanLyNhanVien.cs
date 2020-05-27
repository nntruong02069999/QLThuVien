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
    public partial class AddItemQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public AddItemQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maNhanVien = tbMaNhanVien.Text;
            string tenNhanVien = tbTenNhanVien.Text;
            if (string.IsNullOrWhiteSpace(maNhanVien) || string.IsNullOrWhiteSpace(tenNhanVien))
            {
                XtraMessageBox.Show("Không được để trống thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from NhanVien where IDNhanVien = N'" + maNhanVien + "'";
                DataTable dataTable = new DataTable();
                db.readDatathroughAdapter(query, dataTable);
                if (dataTable.Rows.Count != 0)
                {

                    XtraMessageBox.Show("Mã nhân viên bản đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = XtraMessageBox.Show("Bạn chắc chắn muốn thêm ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string inSert = "Insert into NhanVien values (N'" + maNhanVien + "', N'" + tenNhanVien + "')";
                        SqlCommand command = new SqlCommand(inSert);
                        db.executeQuery(command);
                        QuanLyNhanVien.utcQuanLyNhanVien.QuanLyNhanVien_Loading();
                        this.Hide();
                    }
                }
            }
        }
    }
}
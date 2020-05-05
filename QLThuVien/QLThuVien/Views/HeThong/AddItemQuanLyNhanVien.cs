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
            string maNV = tbMaNhanVien.Text;
            string tenNV = tbTenNhanVien.Text;
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(tenNV))
            {
                XtraMessageBox.Show("Vui lòng không để trống thông tin.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string check = "select * from NhanVien where IDNhanVien = N'" + @maNV + "'";
                DataTable dataTable = new DataTable();
                
                db.readDatathroughAdapter(check, dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    XtraMessageBox.Show("Mã nhân viên đã tồn tại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = XtraMessageBox.Show("Xác nhận thêm nhân viên?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        SqlCommand insert = new SqlCommand("insert into NhanVien(IDNhanVien,TenNhanVien) values (N'" + @maNV + "', N'" + @tenNV + "')");

                        db.executeQuery(insert);
                        QuanLyNhanVien.utcQuanLyNhanVien.QuanLyNhanVien_Loading();
                        this.Hide();
                    }
                }
            }
        }
    }
}
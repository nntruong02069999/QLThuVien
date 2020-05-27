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
    public partial class DeleteQuanLySach : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLySach()
        {
            InitializeComponent();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maSach = tbMaSach.Text;
            DataTable dataTable = new DataTable();
            if(string.IsNullOrWhiteSpace(maSach))
            {
                XtraMessageBox.Show("Không được phép để trống mã sách !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string queryCheck = "Select * from DAUSACH where MaSach = N'" + maSach + "'";
                db.readDatathroughAdapter(queryCheck, dataTable);
                if(dataTable.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không tìm thấy đầu sách", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult log = XtraMessageBox.Show("Bạn chắc chắn muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(log == DialogResult.Yes)
                    {
                        try
                        {
                            string query = "Delete from DAUSACH where MaSach = N'" + maSach + "'";
                            SqlCommand command = new SqlCommand(query);
                            db.executeQuery(command);
                            QuanLySach.utcQuanLySach.QuanLySach_Loading();
                            this.Hide();
                        }
                        catch (Exception err)
                        {
                            XtraMessageBox.Show("Không thể xóa vì sách có thể đang được mượn", "Thông tin đến bạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
            }
        }
    }
}
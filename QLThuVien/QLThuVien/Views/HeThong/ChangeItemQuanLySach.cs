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
    public partial class ChangeItemQuanLySach : DevExpress.XtraEditors.XtraForm
    {
        public ChangeItemQuanLySach()
        {
            InitializeComponent();
        }
        Database db = new Database();

        public static string getMaSach; 
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string maSach = tbMaSach.Text;
            DataTable dataTable = new DataTable();
            if(string.IsNullOrWhiteSpace(maSach))
            {
                XtraMessageBox.Show("Không được phép để trống mã sách !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from DauSach where MaSach = N'" + maSach + "'";
                db.readDatathroughAdapter(query, dataTable);
                if(dataTable.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không tìm thấy đầu sách !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChangingItemQuanLySach form = new ChangingItemQuanLySach();
                    form.Show();
                }
            }
        }

        private void  tbMaSach_BindingContextChanged(object sender, EventArgs e)
        {
            getMaSach = tbMaSach.Text;
        }
    }
}
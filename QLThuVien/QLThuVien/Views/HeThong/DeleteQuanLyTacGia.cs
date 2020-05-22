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
    public partial class DeleteQuanLyTacGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyTacGia()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyTacGia_Load(object sender, EventArgs e)
        {
            string query = "Select MaTacGia from TacGia";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaTacGia.Items.Add(row[0]);
            }
        }

        private void cbMaTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maTacGia = cbMaTacGia.Text;
            string query = "Select TenTacGia from TacGia where MaTacGia =N'" + maTacGia + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            string tenTacGia = dataTable.Rows[0].Field<String>("TenTacGia");
            tbTenTacGia.Text = tenTacGia;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maTacGia = cbMaTacGia.Text;
            if (string.IsNullOrWhiteSpace(maTacGia))
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
                        string query = "Delete from TacGia where MaTacGia = N'" + maTacGia + "'";
                        SqlCommand sqlCommand = new SqlCommand(query);
                        db.executeQuery(sqlCommand);
                        QuanLyTacGia.utcQuanLyTacGia.QuanLyTacGia_Loadding();
                        this.Hide();
                    }
                    catch (Exception err)
                    {
                        XtraMessageBox.Show("Không thể xóa. Tác giả bạn muốn xóa đang tồn tại ở các bảng khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
    }
}
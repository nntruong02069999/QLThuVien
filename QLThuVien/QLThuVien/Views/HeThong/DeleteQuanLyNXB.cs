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
    public partial class DeleteQuanLyNXB : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyNXB()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyNXB_Load(object sender, EventArgs e)
        {
            string query = "Select MaNXB from NXB";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaNXB.Items.Add(row[0]);
            }
        }

        private void cbMaNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNXB = cbMaNXB.Text;
            string query = "Select TenNXB from NXB where MaNXB =N'" + maNXB + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            string tenNXB = dataTable.Rows[0].Field<String>("TenNXB");
            tbTenNXB.Text = tenNXB;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maNXB = cbMaNXB.Text;
            if (string.IsNullOrWhiteSpace(maNXB))
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
                        string query = "Delete from NXB where MaNXB = N'" + maNXB + "'";
                        SqlCommand sqlCommand = new SqlCommand(query);
                        db.executeQuery(sqlCommand);
                        QuanLyNXB.utcQuanLyNXB.QuanLyNXB_Loading();
                        this.Hide();
                    }
                    catch (Exception err)
                    {
                        XtraMessageBox.Show("Không thể xóa. NXB bạn muốn xóa đang tồn tại ở đầu sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
    }
}
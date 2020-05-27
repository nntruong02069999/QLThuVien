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
    public partial class DeleteQuanLyTheLoai : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyTheLoai_Load(object sender, EventArgs e)
        {
            string query = "Select MaTheLoai from TheLoai";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaTheLoai.Items.Add(row[0]);
            }
        }

        private void cbMaTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maTheLoai = cbMaTheLoai.Text;
            string query = "Select TenTheLoai from TheLoai where MaTheLoai =N'" + maTheLoai + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            string tenTheLoai = dataTable.Rows[0].Field<String>("TenTheLoai");
            tbTenTheLoai.Text = tenTheLoai;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maTheLoai = cbMaTheLoai.Text;
            if(string.IsNullOrWhiteSpace(maTheLoai))
            {
                XtraMessageBox.Show("Vui lòng chọn thông tin cần xóa .", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult log = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(log == DialogResult.Yes)
                {
                    try
                    {
                        string query = "Delete from TheLoai where MaTheLoai = N'" + maTheLoai + "'";
                        SqlCommand sqlCommand = new SqlCommand(query);
                        db.executeQuery(sqlCommand);
                        QuanLyTheLoai.utcQuanLyTheLoai.QuanLyTheLoai_Loading();
                        this.Hide();
                    }
                    catch (Exception err)
                    {
                        XtraMessageBox.Show("Không thể xóa. Thể loại bạn muốn xóa đang tồn tại ở đầu sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }                   
                }             
            }
        }
    }
}
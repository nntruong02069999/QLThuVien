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
    public partial class ChangeQuanLyTheLoai : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public ChangeQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void ChangeQuanLyTheLoai_Load(object sender, EventArgs e)
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maTheLoai = cbMaTheLoai.Text;
            string tenTheLoai = tbTenTheLoai.Text;
            if(string.IsNullOrWhiteSpace(maTheLoai) || string.IsNullOrWhiteSpace(tenTheLoai))
            {
                XtraMessageBox.Show("Vui lòng chọn thể loại thay đổi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Bạn có chắc chắn muốn thay đổi ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    string changeItem = "Update TheLoai Set TenTheLoai = N'" + tenTheLoai + "' where MaTheLoai = N'" + maTheLoai + "'";
                    SqlCommand sqlCommand = new SqlCommand(changeItem);
                    db.executeQuery(sqlCommand);
                    QuanLyTheLoai.utcQuanLyTheLoai.QuanLyTheLoai_Loading();
                    this.Hide();
                }
            }
        }
    }
}
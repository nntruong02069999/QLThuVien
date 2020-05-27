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
    public partial class ChangeItemQuanLyNXB : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public ChangeItemQuanLyNXB()
        {
            InitializeComponent();
        }

        private void ChangeItemQuanLyNXB_Load(object sender, EventArgs e)
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maNXB = cbMaNXB.Text;
            string tenNXB = tbTenNXB.Text;
            if(string.IsNullOrWhiteSpace(maNXB))
            {
                XtraMessageBox.Show("Vui lòng chọn nhà xuất bản muốn thay đổi .", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Bạn chắc chắn muốn thay đổi ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    string query = "Update NXB Set TenNXB = N'" + tenNXB + "' where MaNXB =N'" + maNXB + "'";
                    SqlCommand command = new SqlCommand(query);
                    db.executeQuery(command);
                    QuanLyNXB.utcQuanLyNXB.QuanLyNXB_Loading();
                    this.Hide();
                }
            }
        }
    }
}